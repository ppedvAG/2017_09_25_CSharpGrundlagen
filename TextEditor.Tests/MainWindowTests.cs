using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextEditor.Files;

namespace TextEditor.Tests
{
    [TestClass]
    public class MainWindowTests
    {
        [TestMethod]
        public void CanCreateInstance()
        {
            var manager = new TestFileManager();
            var window = new MainWindow(manager);
            Assert.IsNotNull(window);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_filemanager_null_ArgumentNullException()
        {
            new MainWindow(null);
        }

        private class TestFileManager : IFileManager
        {
            public Task<string> GetAllText(string path)
            {
                throw new NotImplementedException();
            }

            public void SaveAllText(string path, string text)
            {
                throw new NotImplementedException();
            }
        }
    }
}
