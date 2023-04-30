using Newtonsoft.Json;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using ZXing;

namespace StaffForms.Class
{
	public class QRCoderManager
	{
		private static QRCoderManager _instance;

		private QRCoderManager()
		{

		}

		public static QRCoderManager Instance => _instance ?? (_instance = new QRCoderManager());

		public void ExportQRCode(List<Item> items, Account account)
		{
			// Create data object to be encoded in the QR code
			var data = new { Items = items, AccountantId = account.EmployeeId };

			// Serialize the data object to JSON
			var jsonData = JsonConvert.SerializeObject(data);

			Bitmap qrCodeImage = GenerateQRCode(jsonData);

			// Export the QR code image to a file
			ExportImage(qrCodeImage);
		}

		private Bitmap GenerateQRCode(string jsonData)
		{
			var qrGenerator = new QRCodeGenerator();
			QRCodeData qrCodeData = qrGenerator.CreateQrCode(jsonData, QRCodeGenerator.ECCLevel.Q);
			var qrCode = new QRCode(qrCodeData);
			Bitmap qrCodeImage = qrCode.GetGraphic(20);

			return qrCodeImage;
		}

		private void ExportImage(Bitmap image)
		{
			var saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "PNG Image|*.png";

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				image.Save(saveFileDialog.FileName, ImageFormat.Png);
				MessageBox.Show("QR code exported successfully.");
			}
		}

		public QRData GetQRData()
		{
			var jsonData = ScanQRCode();

			if (jsonData == null) return null;

			var qrData = JsonConvert.DeserializeObject<QRData>(jsonData);

			return qrData;
		}

		private string ScanQRCode()
		{
			var openFileDialog = new OpenFileDialog
			{
				Filter = "PNG Image|*.png",
				Title = "Select QR code to scan"
			};

			if (openFileDialog.ShowDialog() != DialogResult.OK) return null;
			
			// Load the selected image file into a Bitmap object
			var bitmap = new Bitmap(openFileDialog.FileName);

			// Create an instance of the ZXing BarcodeReader class
			var barcodeReader = new BarcodeReader
			{
				// Set the barcode reader options to decode QR codes
				Options = new ZXing.Common.DecodingOptions
				{
					PossibleFormats = new List<BarcodeFormat> { BarcodeFormat.QR_CODE }
				}
			};

			try
			{
				// Decode the QR code from the Bitmap object
				var result = barcodeReader.Decode(bitmap);

				// Check if the QR code was decoded successfully
				return result?.Text;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
	}
}
