using System.Drawing;
using Spectre.Console;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;
using ZXing.QrCode.Internal;
using ZXing.Rendering;


namespace qrcodeapp
{
    public class GenerateClass
    {
        

        public void GenerateQR(string url, int qrcodeSize, string qrname)
        {
            FileClass file = new FileClass();

            BarcodeWriter<Bitmap> writer = new BarcodeWriter<Bitmap>();
            writer.Format = BarcodeFormat.QR_CODE;
            writer.Options = new EncodingOptions
            {
                Width = qrcodeSize,
                Height = qrcodeSize,
                Margin = 0
            };
            var result = writer.Write(url);
            string path = qrname + ".png";
            if (File.Exists(path))
                File.Delete(path);
            using (var bFile = new FileStream(path, FileMode.CreateNew))
            {
                result.Save(bFile, System.Drawing.Imaging.ImageFormat.Png);
            }
            string action = AnsiConsole.Ask<string>("[green]Read QR(y/n)[/]:");
            if(action == "y" || action == "Y")
            {
                var reader = new BarcodeReader(new BarcodeReader(), new DecodingOptions { TryHarder = true });
                reader.Options = new DecodingOptions { TryHarder = true };

                var barcodeBitmap = new Bitmap(path);

                var result2 = reader.Decode(new Bitmap(@"" + path));
            }
            else if(action == "n" || action == "N")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Exiting...");
                Console.ResetColor();
                Environment.Exit(0);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong choose, exiting...");
                Console.ResetColor();
                Environment.Exit(0);
            }
        }
    }
}