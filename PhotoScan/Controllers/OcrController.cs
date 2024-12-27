using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using PhotoScan.Service;
using System.Text.RegularExpressions;

namespace PhotoScan.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class OcrController : ControllerBase
    {
        private readonly OcrService _ocrService;

        public OcrController()
        {
            // Replace with the actual tessdata folder path
            _ocrService = new OcrService(@"C:\Program Files\Tesseract-OCR\tessdata");
        }

        [HttpPost("extract-text")]
        public IActionResult ExtractText([FromForm] IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("No file uploaded.");

            var filePath = Path.GetTempFileName();

            try
            {
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                var text = _ocrService.ExtractTextFromImage(filePath);
                string rawText = text.ToString();

                // Clean and format text
                string cleanedText = Regex.Replace(rawText, @"\s+", " "); // Remove excessive whitespace
                cleanedText = Regex.Replace(cleanedText, @"\\n|__", " "); // Replace \n and __ with space
                cleanedText = Regex.Replace(cleanedText, @"http://locaihost", "http://localhost"); // Correct URL typo

                // Output the result
                Console.WriteLine(cleanedText);
                return Ok(new { Text = text });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Error = ex.Message });
            }
            finally
            {
                if (System.IO.File.Exists(filePath))
                    System.IO.File.Delete(filePath);
            }
        }
    }

}
