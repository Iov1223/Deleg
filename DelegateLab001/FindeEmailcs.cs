using System.Text.RegularExpressions;

namespace DelegateLab001
{
    
    public class Finde 
    {
        string _fileContent;
        public Finde()
        {
            _fileContent = OpenDialog.GetFile();
        }
        public string FindeEmail()
        {
            Regex regex = new Regex(@"(\w*@\w*[.]\w*)|(\w*[.]\w*@\w*[.]\w*)", RegexOptions.IgnoreCase);
            MatchCollection matches = regex.Matches(_fileContent);
            string str = "";
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    str += match.Value + '\n';
                }
                    
                return str;
            }
            else
            {
                return "Электронная почта не найдена!";
            }
        }
    }
    
}
