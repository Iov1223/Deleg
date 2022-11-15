using System.Windows.Forms;

namespace DelegateLab001
{
    public delegate void myDelegate(string text);
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        private void PrintInlabelPrintFile(string text)
        {

            labelPrintFile.Text = text;
        }
        private void buttonShowResult_MouseClick(object sender, MouseEventArgs e)
        {
            Finde finde = new Finde();
            string _fileContent = finde.FindeEmail();
            myDelegate _myDelegate = PrintInlabelPrintFile;
            PrintRes.Print(_myDelegate, _fileContent);
        }
    }
}
