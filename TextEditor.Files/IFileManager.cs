using System.Threading.Tasks;

namespace TextEditor.Files
{
    public interface IFileManager
    {
        Task<string> GetAllText(string path);
        void SaveAllText(string path, string text);
    }
}