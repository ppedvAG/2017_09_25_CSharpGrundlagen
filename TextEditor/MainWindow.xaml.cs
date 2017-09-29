using Microsoft.Win32;
using System.IO;
using System.Windows;
using TextEditor.Properties;

namespace TextEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ReadUserSettings();

            Title = "Mein Text Editor.";
        }

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            var path = GetFileOpenPath();
            if (path == null)
                return;

            var content = GetAllText(path);
            contentTextBox.Text = content;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            var path = GetFileSavePath();
            if (path == null)
                return;

            var content = contentTextBox.Text;
            SaveAllText(path, content);
        }

        private string GetAllText(string path)
        {
            //return File.ReadAllText(path);

            using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (var sr = new StreamReader(fs))
                return sr.ReadToEnd();
        }

        private void SaveAllText(string path, string text)
        {
            //return File.WriteAllText(path, text);

            using (var fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            using (var sw = new StreamWriter(fs))
                sw.Write(text);
        }

        private string GetFileSavePath()
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "Textfiles (*.txt)|*.txt|CSharp (*.cs)|*.cs";
            dialog.Title = "Save file from my special Text Editor";

            var result = dialog.ShowDialog();

            return result == true ? dialog.FileName : null;
        }

        private string GetFileOpenPath()
        {
            var dialog = new OpenFileDialog();
            dialog.CheckFileExists = true;
            dialog.Filter = "Textfiles (*.txt)|*.txt|CSharp (*.cs)|*.cs|All Files (*.*)|*.*";
            dialog.Title = "Open file for my special Text Editor";

            var result = dialog.ShowDialog();

            return result == true ? dialog.FileName : null;
        }

        private void Exit_Click(object sender, RoutedEventArgs e) => Close();

        private void ReadUserSettings()
        {
            Width = Settings.Default.WindowSize.Width;
            Height = Settings.Default.WindowSize.Height;
        }

        private void WindowSize_Changed(object sender, SizeChangedEventArgs e)
        {
            Settings.Default.WindowSize = e.NewSize;
            Settings.Default.Save();
        }
    }
}
