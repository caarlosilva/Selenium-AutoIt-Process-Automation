using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesseract;

namespace MainForm.OCR
{
    public static class TesseractOCR
    {
        public static string GetTextFromImage(string path)
        {
            var ocrtext = string.Empty;
            Bitmap image = new Bitmap(path);

            using (var engine = new TesseractEngine("tessdata", "eng+por", EngineMode.TesseractAndCube))
            {
                engine.SetVariable("tessedit_char_whitelist", "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzçÇãÃáàõéúí");
                engine.SetVariable("tessedit_unrej_any_wd", true);
                using (var page = engine.Process(image))
                    ocrtext = page.GetText();
            }
            return ocrtext;
        }
    }
}
