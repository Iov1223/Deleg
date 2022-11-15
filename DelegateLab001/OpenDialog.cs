using System.Windows.Forms;
using System.IO;

namespace DelegateLab001
{
    public class OpenDialog
    {
        static public string GetFile()
        {
            var fileContent = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "d:\\";
            openFileDialog.Filter = "c_sharp files (*.cs)|*.cs|txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileStream = openFileDialog.OpenFile();
                StreamReader reader = new StreamReader(fileStream);
                fileContent = reader.ReadToEnd();
                reader.Close();
            }
            return fileContent;
        }
    }
}
