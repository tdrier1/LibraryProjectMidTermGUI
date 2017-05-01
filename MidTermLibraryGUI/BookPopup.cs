using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace MidTermLibraryGUI
{
    public partial class BookPopup : Form
    {
        private BookClass[] BookArray = new BookClass[1];

        private void BookPopup_Load(object sender, EventArgs e)
        {
            BookImage.SizeMode = PictureBoxSizeMode.StretchImage;

            BookClass book = new BookClass();

            Read();

            var result = Regex.Match(BookClass.SelectProp, @"\d+$").Value;

            int index1 = Convert.ToInt32(result);

            this.CheckoutLabel.Text = BookArray[index1].TitleProp;

        }

        public BookPopup()
        {
            InitializeComponent();
        }

        private void Read()
        {
            StreamReader sr = new StreamReader("Library.txt");
            BookArray = new BookClass[Convert.ToInt32(sr.ReadLine())];

            for (int i = 0; i < BookArray.Length; i++)
            {
                BookArray[i] = new BookClass();
                BookArray[i].TitleProp = sr.ReadLine();
                BookArray[i].AuthorProp = sr.ReadLine();
                BookArray[i].GenreProp = sr.ReadLine();
                BookArray[i].StatusProp = sr.ReadLine();
                BookArray[i].DueDateProp = sr.ReadLine();
                BookArray[i].IndexProp = i;
            }
            sr.Close();
        }

        private void Write(BookClass book)
        {
            StreamWriter sw = new StreamWriter("Library.txt");

            sw.WriteLine(BookArray.Length);

            for (int i = 0; i < BookArray.Length; i++)
            {
                sw.WriteLine(BookArray[i].TitleProp);
                sw.WriteLine(BookArray[i].AuthorProp);
                sw.WriteLine(BookArray[i].GenreProp);
                sw.WriteLine(BookArray[i].StatusProp);
                sw.WriteLine(BookArray[i].DueDateProp);
            }
            sw.Close();
        }

        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            BookClass book = new BookClass();
            Read();

            var result = Regex.Match(BookClass.SelectProp, @"\d+$").Value;

            int index1 = Convert.ToInt32(result);

            BookArray[index1].StatusProp = "Checked Out";
            BookArray[index1].DueDateProp = DateTime.Now.AddDays(14).ToString("MM/dd/yy");

            Write(book);
            

            this.Close();
        }

        private void ExitInv_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
