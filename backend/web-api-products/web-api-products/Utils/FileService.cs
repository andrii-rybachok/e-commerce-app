using System.Drawing;
using web_api_products.Models;

namespace web_api_products.Utils
{
	public static class FileService
	{
		//jpg files
		public static byte[] ConvertImageToByteArray(string filePath)
		{
			// Read the image file from disk
			using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
			{
				// Create a binary reader to read the file stream
				BinaryReader binaryReader = new BinaryReader(fileStream);

				// Read the image data into a byte array
				byte[] imageData = binaryReader.ReadBytes((int)fileStream.Length);

				return imageData;
			}
		}
		public static decimal GetSize(string filePath)
		{
			decimal Size;
			using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
			{
				 Size = fileStream.Length;
			}
			return Size;
		}
	}
}
