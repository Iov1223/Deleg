namespace DelegateLab001
{
    public class PrintRes
    {
        public static void Print(myDelegate printRes, string text)
        {
            printRes?.Invoke(text);
        }
    }
}
