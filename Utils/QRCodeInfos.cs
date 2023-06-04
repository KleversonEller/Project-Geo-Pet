// using QRCoder;
// using System.Drawing;

// namespace project_geopet.Utils;

// public static class QRCodeInfos
// {
//     public static Bitmap GenerateQRCode(string name, string email, string cep)
//     {
//         QRCodeGenerator qrGeneration = new();
//         QRCodeData qrCodeData = qrGeneration
//             .CreateQrCode($"{name} - {email} - {cep}", QRCodeGenerator.ECCLevel.Q);
//         QRCode qrCode = new(qrCodeData);
//         Bitmap qrCodeImage = qrCode.GetGraphic(20);
//         return qrCodeImage;
//     }

//     public static byte[] GenerateByteArray(string name, string email, string cep)
//     {
//         var image = GenerateQRCode(name, email, cep);
//         return ImageToByte(image);
//     }

//     private static byte[] ImageToByte(Image img)
//     {
//         using var stream = new MemoryStream();
//         img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
//         return stream.ToArray();
//     }
// }