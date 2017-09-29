using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace TextEditor.Files
{
    public class FileManager : IFileManager
    {
        public async Task<string> GetAllText(string path)
        {
            //return File.ReadAllText(path);
            return await Task.Run(async () =>
            {
                Thread.Sleep(3000);

                using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                using (var sr = new StreamReader(fs))
                    return await sr.ReadToEndAsync();
            });
        }

        public void SaveAllText(string path, string text)
        {
            //return File.WriteAllText(path, text);

            using (var fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            using (var sw = new StreamWriter(fs))
                sw.Write(text);
        }
    }
}
