using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace MidTermLibraryGUI
{
    public class BookHelper: Form
    {
        public static void Write(BookClass Book)
        {
            StreamWriter sw = new StreamWriter("Library.txt");

            sw.WriteLine(Program.BookArray.Length);

            for (int i = 0; i < Program.BookArray.Length; i++)
            {
                sw.WriteLine(Program.BookArray[i].TitleProp);
                sw.WriteLine(Program.BookArray[i].AuthorProp);
                sw.WriteLine(Program.BookArray[i].GenreProp);
                sw.WriteLine(Program.BookArray[i].StatusProp);
                sw.WriteLine(Program.BookArray[i].DueDateProp);
            }
            sw.Close();
        }

        public static void Read()
        {
            StreamReader sr = new StreamReader("Library.txt");

            Program.BookArray = new BookClass[Convert.ToInt32(sr.ReadLine())];

            for (int i = 0; i < Program.BookArray.Length; i++)
            {
                Program.BookArray[i] = new BookClass();
                Program.BookArray[i].TitleProp = sr.ReadLine();
                Program.BookArray[i].AuthorProp = sr.ReadLine();
                Program.BookArray[i].GenreProp = sr.ReadLine();
                Program.BookArray[i].StatusProp = sr.ReadLine();
                Program.BookArray[i].DueDateProp = sr.ReadLine();
                Program.BookArray[i].IndexProp = i;
            }

            sr.Close();
        }

    }
}
