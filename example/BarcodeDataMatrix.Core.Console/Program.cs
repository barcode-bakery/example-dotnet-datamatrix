using System.Threading.Tasks;

namespace BarcodeDataMatrix.Core.Console
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // See each barcode file to see how you can save to a file or a MemoryStream.
            await ExampleDataMatrix.CreateAsync("barcode_datamatrix.png");
        }
    }
}
