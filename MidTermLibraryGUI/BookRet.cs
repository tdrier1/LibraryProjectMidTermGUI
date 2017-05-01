using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace MidTermLibraryGUI
{
    public partial class BookRet : Form
    {
        private BookClass[] BookArray = new BookClass[1];

        public BookRet()
        {
            InitializeComponent();
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

        private void Search()
        {
            StreamReader sr = new StreamReader("Library.txt");

            BookArray = new BookClass[Convert.ToInt32(sr.ReadLine())];

            ReturnBox.Items.Clear();

            for (int i = 0; i < BookArray.Length; i++)
            {
                BookArray[i] = new BookClass();
                BookArray[i].TitleProp = sr.ReadLine();
                BookArray[i].AuthorProp = sr.ReadLine();
                BookArray[i].GenreProp = sr.ReadLine();
                BookArray[i].StatusProp = sr.ReadLine();
                BookArray[i].DueDateProp = sr.ReadLine();
                BookArray[i].IndexProp = i;

                if (BookArray[i].StatusProp == "Checked Out")
                {
                    ReturnBox.Items.Add(BookArray[i].ToString());

                }
            }
            sr.Close();
        }

        private void ReturnBox_SelectedIndexChanged(object sender, MouseEventArgs e)
        {
            BookClass book = new BookClass();

            if (ReturnBox.SelectedIndex <= 100)
            {
                string text = ReturnBox.GetItemText(ReturnBox.SelectedItem);
                var result = Regex.Match(text, @"\d+$").Value;
                int index1 = Convert.ToInt32(result);

                MessageBox.Show(BookArray[index1].TitleProp + " has been returned!");
                BookArray[index1].StatusProp = "Available";
                BookArray[index1].DueDateProp = "On Shelf";
            }

            Write(book);
            ReturnBox.Items.Clear();
            Read();
            Search();

        }

        private void BookRet_Load(object sender, EventArgs e)
        {
            Read();
            Search();
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
