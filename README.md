# Photo Scan Project

This project is a **Photo Scan Application** built with **.NET Core 8 MVC** and integrates **Tesseract OCR** to extract text content from images. The application provides a seamless way to upload images and retrieve textual data with high accuracy.

---

## Features

- **Image Upload**: Supports multiple image formats for scanning.
- **Text Extraction**: Extracts text content from uploaded images using Tesseract OCR.
- **Cleaned Output**: Filters unnecessary noise for better readability.
- **Error Handling**: Handles common errors like unsupported file types or OCR initialization failures.
- **Cross-Platform Support**: Built with .NET Core 8, ensuring compatibility across platforms.

---

## Requirements

### Software Prerequisites
- **.NET Core 8 SDK**
- **Visual Studio 2022** or higher
- **Tesseract OCR** installed on the system ([Installation Guide](https://github.com/UB-Mannheim/tesseract/wiki))
- **tessdata** folder containing language `.traineddata` files (e.g., `eng.traineddata` for English).

### Environment Setup
- Operating System: Windows/Linux/macOS
- Add Tesseract OCR to your system's PATH (for Windows).

---

## Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/photo-scan.git
   cd photo-scan
   ```

2. Install dependencies:
   Ensure the required .NET Core SDK and Tesseract OCR are installed.

3. Configure `tessdata` Path:
   Update the path to the `tessdata` folder in your application settings. Example:
   ```csharp
   new TesseractEngine(@"C:\\Program Files\\Tesseract-OCR\\tessdata", "eng");
   ```

4. Run the application:
   ```bash
   dotnet run
   ```

5. Open the browser and navigate to:
   ```
   http://localhost:5000
   ```

---

## Usage

1. Upload an image through the web interface.
2. Click the **Extract Text** button.
3. View the extracted text displayed on the results page.

---

## Troubleshooting

### Common Issues

- **Failed to initialize Tesseract engine**: Ensure the `tessdata` path is correct and the required `.traineddata` files are present.
- **Unsupported image format**: Verify the image format is supported (e.g., JPG, PNG, BMP).
- **OCR accuracy issues**: Use high-quality images for better results.

### Logs

Application logs are stored in the `Logs` directory for debugging purposes.

---

## Contributions

We welcome contributions! Feel free to fork the repository and submit pull requests.

### Steps to Contribute:
1. Fork the repository.
2. Create a feature branch:
   ```bash
   git checkout -b feature/your-feature-name
   ```
3. Commit changes:
   ```bash
   git commit -m "Add your feature description"
   ```
4. Push to the branch:
   ```bash
   git push origin feature/your-feature-name
   ```
5. Open a pull request.

---

## License

This project is licensed under the [MIT License](LICENSE).

---

## Acknowledgements

- [Tesseract OCR](https://github.com/tesseract-ocr/tesseract) for the OCR engine.
- [Microsoft](https://dotnet.microsoft.com/) for the .NET Core framework.

---

## Contact

For issues or inquiries, please contact:
- **Your Name**: [omgorasiya23@gmail.com](mailto:omgorasiya23@gmail.com)
- **GitHub**: [AxoneWebDevGit](https://github.com/AxoneWebDevGit)

