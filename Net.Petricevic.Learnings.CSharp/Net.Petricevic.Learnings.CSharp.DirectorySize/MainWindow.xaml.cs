using System.Windows;
using Microsoft.WindowsAPICodePack.Dialogs;
using Net.Petricevic.Learnings.CSharp.DirectorySize.SizedComponents;
using Net.Petricevic.Learnings.CSharp.DirectorySize.Util;

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

            if (result != CommonFileDialogResult.Ok) return;

            _selectedDirectory = openFolderDialog.FileName;

            var root = new SizedDirectory(_selectedDirectory);

            DisplaySizeInUi(root.SizeInBytes);
        }

        private void DisplaySizeInUi(long sizeInBytes)
        {
            long megabytes = FileSizeConverter.ConvertBytesToMegabytes(sizeInBytes);

            DirectorySizeLabel.Content = megabytes;
        }
    }
}
