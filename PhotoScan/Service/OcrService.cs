using System;
using System.IO;
using Tesseract;

namespace PhotoScan.Service
{
    public class OcrService
    {
        private readonly string _tesseractDataPath;

        public OcrService(string tesseractDataPath)
        {
            _tesseractDataPath = tesseractDataPath;
        }

        public string ExtractTextFromImage(string imagePath)
        {
            try
            {
                using var engine = new TesseractEngine(_tesseractDataPath, "eng", EngineMode.Default);
                using var img = Pix.LoadFromFile(imagePath);
                using var page = engine.Process(img);

                return page.GetText();
            }
            catch (Exception ex)
            {
                // Log error
                return $"Error: {ex.Message}";
            }
        }
    }

}
