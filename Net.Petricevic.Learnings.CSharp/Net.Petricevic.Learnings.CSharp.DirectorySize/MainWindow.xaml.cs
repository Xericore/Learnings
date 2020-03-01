using System.Windows;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace Net.Petricevic.Learnings.CSharp.DirectorySize
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _selectedDirectory;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SelectDirectoryButton_Click(object sender, RoutedEventArgs e)
        {
            var openFolderDialog = new CommonOpenFileDialog {IsFolderPicker = true};

            var result = openFolderDialog.ShowDialog();

            if (result == CommonFileDialogResult.Ok)
            {
                _selectedDirectory = openFolderDialog.FileName;

                DirectoryComponent root = new DirectoryComponent(_selectedDirectory);

                long megabytes = FileSizeConverter.ConvertBytesToMegabytes(root.SizeInBytes);

                DirectorySizeLabel.Content = megabytes;
            }
        }
    }
}
