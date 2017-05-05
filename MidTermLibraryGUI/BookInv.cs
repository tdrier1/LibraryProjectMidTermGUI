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
        public BookInv()
        {
            InitializeComponent();
        }

        private void Display()
        {
            InvBox.Items.Clear();

            for (int i = 0; i < Program.BookArray.Length; i++)
            {
                InvBox.Items.Add(Program.BookArray[i].ToString());
            }
        }

        private void ClearForm()  //clears screen for next output
        {
            BookInvTitleTxt.Text = String.Empty;
            BookInvAuthTxt.Text = String.Empty;
            GenreList.Text = String.Empty;
        }

        private void Search()  //method to search through library text file
        {
            StreamReader sr = new StreamReader("Library.txt");

            Program.BookArray = new BookClass[Convert.ToInt32(sr.ReadLine())];

            string TitleSearch = BookInvTitleTxt.Text;
            string AuthSearch = BookInvAuthTxt.Text;
            string GenreSearch = GenreList.Text;            //variables to tell what user is searching for

            InvBox.Items.Clear();

            for (int i = 0; i < Program.BookArray.Length; i++)  //for loop searches input through library text file
            {
                Program.BookArray[i] = new BookClass();
                Program.BookArray[i].TitleProp = sr.ReadLine();
                Program.BookArray[i].AuthorProp = sr.ReadLine();
                Program.BookArray[i].GenreProp = sr.ReadLine();
                Program.BookArray[i].StatusProp = sr.ReadLine();
                Program.BookArray[i].DueDateProp = sr.ReadLine();
                Program.BookArray[i].IndexProp = i;
            
                if (Program.BookArray[i].TitleProp.ToLower() == TitleSearch.ToLower() || Program.BookArray[i].AuthorProp.ToLower() == AuthSearch.ToLower() || Program.BookArray[i].GenreProp == GenreSearch)
                {
                    InvBox.Items.Add(Program.BookArray[i].ToString());  
                }
            }
            sr.Close();
        }

        private void BookInv_Load(object sender, EventArgs e) //button to output inventory
        {
            BookHelper.Read();
            Display();
        }

        private void SearchButton_Click(object sender, EventArgs e)  // added button to search
        {
            Search();
        }

        private void InvBox_SelectedIndexChanged(object sender, EventArgs e) //output for when user selects book from inventory
        { 
            if (InvBox.SelectedIndex <= 100)
            {
                BookClass.SelectProp = InvBox.GetItemText(InvBox.SelectedItem);

                BookPopup Inv = new BookPopup();
                Inv.Show();
            }
        }

        private void MainMenu_Click(object sender, EventArgs e) //button to return to main menu
        {
            this.Close();
        }

        private void UpdateButton_Click(object sender, EventArgs e)  //button to update book status
        {
            BookHelper.Read();
            Display();
        }

        private void BookInvTitleTxt_KeyDown(object sender, KeyEventArgs e) // added so user can just push enter instead of clicking on actual button
        {
            if (e.KeyCode == Keys.Enter)
                SearchButton.PerformClick();
        }
        
        private void BookInvAuthTxt_KeyDown(object sender, KeyEventArgs e)  //added so user can just push enter instead of clicking on actual button
        {
            if (e.KeyCode == Keys.Enter)
                SearchButton.PerformClick();
        }
    }
}
