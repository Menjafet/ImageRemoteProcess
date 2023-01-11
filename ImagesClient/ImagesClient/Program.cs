// See https://aka.ms/new-console-template for more information
using htttpLib;


namespace baby

{
    public static class Class2
    {
        private static async Task Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var folder = @"C:\\Users\\jaftb\\Documents\\ImagesClient\\ImagesClient";
            var fileName = "test";
            var url = "https://cdn.discordapp.com/attachments/458291463663386646/592779619212460054/Screenshot_20190624-201411.jpg?query&with.dots";

            await Class1.DownloadImageAsync(folder, fileName, new Uri(url));
        }
    }
}