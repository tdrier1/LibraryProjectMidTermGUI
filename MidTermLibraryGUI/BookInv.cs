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
    public partial class BookInv : Form
    {
        private BookClass[] BookArray = new BookClass[1];

        public BookInv()
        {
            InitializeComponent();
        }

        private void Read()
        {
            StreamReader sr = new StreamReader("Library.txt");
                BookArray = new BookClass[Convert.ToInt32(sr.ReadLine())];
           //  Program.BookArray = new BookClass[Convert.ToInt32(sr.ReadLine())];
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

        private void Display()
        {
            InvBox.Items.Clear();

            for (int i = 0; i < BookArray.Length; i++)
            {
                InvBox.Items.Add(BookArray[i].ToString());
            }
        }

        private void ClearForm()
        {
            BookInvTitleTxt.Text = String.Empty;
            BookInvAuthTxt.Text = String.Empty;
            GenreList.Text = String.Empty;
        }

        private void Search()
        {
            StreamReader sr = new StreamReader("Library.txt");

            BookArray = new BookClass[Convert.ToInt32(sr.ReadLine())];

            string TitleSearch = BookInvTitleTxt.Text;
            string AuthSearch = BookInvAuthTxt.Text;
            string GenreSeach = GenreList.Text;

            InvBox.Items.Clear();

            for (int i = 0; i < BookArray.Length; i++)
            {
                BookArray[i] = new BookClass();
                BookArray[i].TitleProp = sr.ReadLine();
                BookArray[i].AuthorProp = sr.ReadLine();
                BookArray[i].GenreProp = sr.ReadLine();
                BookArray[i].StatusProp = sr.ReadLine();
                BookArray[i].DueDateProp = sr.ReadLine();
                BookArray[i].IndexProp = i;

                if (BookArray[i].TitleProp == TitleSearch || BookArray[i].AuthorProp == AuthSearch || BookArray[i].GenreProp == GenreSeach)
                {
                    InvBox.Items.Add(BookArray[i].ToString());
                }
            }
            sr.Close();
        }

        private void BookInv_Load(object sender, EventArgs e)
        {
            Read();
            Display();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void InvBox_SelectedIndexChanged(object sender, EventArgs e)
        { 
            if (InvBox.SelectedIndex <= 100)
            {
                BookClass.SelectProp = InvBox.GetItemText(InvBox.SelectedItem);

                BookPopup Inv = new BookPopup();
                Inv.Show();
            }
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Read();
            Display();
        }
    }
}
