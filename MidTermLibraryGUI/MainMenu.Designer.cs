namespace MidTermLibraryGUI
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InvButton = new System.Windows.Forms.Button();
            this.ReturnBook = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.AddBook = new System.Windows.Forms.Button();
            this.GCLogo = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GCLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // InvButton
            // 
            this.InvButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InvButton.BackColor = System.Drawing.Color.Black;
            this.InvButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.InvButton.FlatAppearance.BorderSize = 30;
            this.InvButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvButton.ForeColor = System.Drawing.Color.White;
            this.InvButton.Location = new System.Drawing.Point(190, 286);
            this.InvButton.Name = "InvButton";
            this.InvButton.Size = new System.Drawing.Size(292, 125);
            this.InvButton.TabIndex = 0;
            this.InvButton.Text = "Search/Checkout a Book";
            this.InvButton.UseVisualStyleBackColor = false;
            this.InvButton.Click += new System.EventHandler(this.InvButton_Click);
            // 
            // ReturnBook
            // 
            this.ReturnBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReturnBook.BackColor = System.Drawing.Color.Black;
            this.ReturnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnBook.ForeColor = System.Drawing.Color.White;
            this.ReturnBook.Location = new System.Drawing.Point(581, 286);
            this.ReturnBook.Name = "ReturnBook";
            this.ReturnBook.Size = new System.Drawing.Size(292, 125);
            this.ReturnBook.TabIndex = 2;
            this.ReturnBook.Text = "Return a Book";
            this.ReturnBook.UseVisualStyleBackColor = false;
            this.ReturnBook.Click += new System.EventHandler(this.ReturnBook_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.BackColor = System.Drawing.Color.Black;
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ExitButton.Location = new System.Drawing.Point(580, 479);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(292, 125);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit Application";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AddBook
            // 
            this.AddBook.BackColor = System.Drawing.Color.Black;
            this.AddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBook.ForeColor = System.Drawing.Color.White;
            this.AddBook.Location = new System.Drawing.Point(190, 479);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(292, 125);
            this.AddBook.TabIndex = 4;
            this.AddBook.Text = "Add a Book";
            this.AddBook.UseVisualStyleBackColor = false;
            this.AddBook.Click += new System.EventHandler(this.AddBookMenuClick);
            // 
            // GCLogo
            // 
            this.GCLogo.Image = global::MidTermLibraryGUI.Properties.Resources.grandcircuslogo1;
            this.GCLogo.Location = new System.Drawing.Point(0, -1);
            this.GCLogo.Name = "GCLogo";
            this.GCLogo.Size = new System.Drawing.Size(273, 216);
            this.GCLogo.TabIndex = 7;
            this.GCLogo.TabStop = false;
            // 
            // background
            // 
            this.background.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.background.BackColor = System.Drawing.Color.White;
            this.background.Location = new System.Drawing.Point(270, -1);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(833, 216);
            this.background.TabIndex = 8;
            this.background.Paint += new System.Windows.Forms.PaintEventHandler(this.background_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(349, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(714, 117);
            this.label1.TabIndex = 7;
            this.label1.Text = "Little Free Library";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1100, 663);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReturnBook);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.InvButton);
            this.Controls.Add(this.GCLogo);
            this.Controls.Add(this.background);
            this.Controls.Add(this.AddBook);
            this.Name = "MainMenu";
            this.Text = "GCLFL";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GCLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InvButton;
        private System.Windows.Forms.Button ReturnBook;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button AddBook;
        private System.Windows.Forms.PictureBox GCLogo;
        private System.Windows.Forms.FlowLayoutPanel background;
        private System.Windows.Forms.Label label1;
    }
}

