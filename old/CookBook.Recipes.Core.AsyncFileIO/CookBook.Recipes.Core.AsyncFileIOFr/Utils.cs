using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CookBook.Recipes.Core.AsyncFileIO
{
    public static class Utils
    {
        public static async Task<int> CopyDirectoryAsyncTask(string sourceDir, string targetDir) {
            int count = Directory.EnumerateFiles(targetDir).Count();

            foreach (var filename in Directory.EnumerateFiles(sourceDir)) {
                using (FileStream sourceStream = File.Open(filename, FileMode.Open)) {
                    using (FileStream DestinationStram = File.Create(targetDir + filename.Substring(filename.LastIndexOf('\\')))) {
                        await sourceStream.CopyToAsync(DestinationStram);
                    }
                }

            }

            return (Directory.EnumerateFiles(targetDir).Count() - count);

        }
    }
}
