using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TextFromClipboard
{
    class Program
    {

        [STAThread]
        static void Main(string[] args)
        {
            String s = Clipboard.GetText();
            string[] words = s.Split(new char[] {' ', ',', '.', '!', '?', ':', ';', '\n'}, StringSplitOptions.RemoveEmptyEntries);
            words = words.OrderBy(x => x.ToLower()).Distinct().Take(1000).ToArray();
            Console.WriteLine(string.Join("\n", words));
            Console.ReadKey();            
        }
    }
}