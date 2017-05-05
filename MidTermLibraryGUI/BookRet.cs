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
        public BookRet()
        {
            InitializeComponent();
        }

        private void Search()
        {
            StreamReader sr = new StreamReader("Library.txt");

            Program.BookArray = new BookClass[Convert.ToInt32(sr.ReadLine())];

            ReturnBox.Items.Clear();

            for (int i = 0; i < Program.BookArray.Length; i++)
            {
                Program.BookArray[i] = new BookClass();
                Program.BookArray[i].TitleProp = sr.ReadLine();
                Program.BookArray[i].AuthorProp = sr.ReadLine();
                Program.BookArray[i].GenreProp = sr.ReadLine();
                Program.BookArray[i].StatusProp = sr.ReadLine();
                Program.BookArray[i].DueDateProp = sr.ReadLine();
                Program.BookArray[i].IndexProp = i;

                if (Program.BookArray[i].StatusProp == "Checked Out")
                {
                    ReturnBox.Items.Add(Program.BookArray[i].ToString());

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
                if (text != "")

                {
                    var result = Regex.Match(text, @"\d+$").Value;
                    int index1 = Convert.ToInt32(result);

                    MessageBox.Show(Program.BookArray[index1].TitleProp + " has been returned!");
                    Program.BookArray[index1].StatusProp = "Available";
                    Program.BookArray[index1].DueDateProp = "On Shelf";
                }
            }

            BookHelper.Write(book);
            ReturnBox.Items.Clear();
            BookHelper.Read();
            Search();

        }

        private void BookRet_Load(object sender, EventArgs e)
        {
            BookHelper.Read();
            Search();
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
