using MessagingToolkit.QRCode.Codec;
using System.Drawing;
using project_geopet.Models;

namespace project_geopet.Services;

public static class QRCodeInfos
{
    public static Bitmap GenerateQRCode(Pet infos)
    {
        QRCodeEncoder qrCodecEncoder = new()
        {
            QRCodeBackgroundColor = Color.White,
            QRCodeForegroundColor = Color.Black,
            CharacterSet = "UTF-8",
            QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE,
            QRCodeScale = 6,
            QRCodeVersion = 0,
            QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.Q
        };
        Bitmap imageQRCode;
        Pet dados = infos;
        imageQRCode = qrCodecEncoder.Encode(dados.ToString());
        return imageQRCode;
    }
}