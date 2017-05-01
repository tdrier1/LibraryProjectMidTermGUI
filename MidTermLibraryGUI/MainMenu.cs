using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidTermLibraryGUI
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void InvButton_Click(object sender, EventArgs e)
        {   
            BookInv Inv = new BookInv();
            Inv.Show();
        }

        private void AddBookMenuClick(object sender, EventArgs e)
        {
            AddBookForm frm = new AddBookForm();
            frm.Show();
        }

        private void ReturnBook_Click(object sender, EventArgs e)
        {
            BookRet Inv = new BookRet();
            Inv.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            GCLogo.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void background_Paint(object sender, PaintEventArgs e)
        {
            background.SendToBack();
        }
    }
}
