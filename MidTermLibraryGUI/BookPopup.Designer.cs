namespace MidTermLibraryGUI
{
    partial class BookPopup
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
            this.CheckOutButton = new System.Windows.Forms.Button();
            this.ExitInv = new System.Windows.Forms.Button();
            this.CheckoutLabel = new System.Windows.Forms.Label();
            this.BookImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BookImage)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckOutButton
            // 
            this.CheckOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CheckOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOutButton.Location = new System.Drawing.Point(379, 150);
            this.CheckOutButton.Name = "CheckOutButton";
            this.CheckOutButton.Size = new System.Drawing.Size(225, 100);
            this.CheckOutButton.TabIndex = 0;
            this.CheckOutButton.Text = "Check Out";
            this.CheckOutButton.UseVisualStyleBackColor = false;
            this.CheckOutButton.Click += new System.EventHandler(this.CheckOutButton_Click);
            // 
            // ExitInv
            // 
            this.ExitInv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ExitInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitInv.Location = new System.Drawing.Point(379, 306);
            this.ExitInv.Name = "ExitInv";
            this.ExitInv.Size = new System.Drawing.Size(225, 100);
            this.ExitInv.TabIndex = 1;
            this.ExitInv.Text = "No Thanks";
            this.ExitInv.UseVisualStyleBackColor = false;
            this.ExitInv.Click += new System.EventHandler(this.ExitInv_Click);
            // 
            // CheckoutLabel
            // 
            this.CheckoutLabel.AutoSize = true;
            this.CheckoutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckoutLabel.Location = new System.Drawing.Point(83, 36);
            this.CheckoutLabel.Name = "CheckoutLabel";
            this.CheckoutLabel.Size = new System.Drawing.Size(165, 40);
            this.CheckoutLabel.TabIndex = 3;
            this.CheckoutLabel.Text = "Selection";
            // 
            // BookImage
            // 
            this.BookImage.Image = global::MidTermLibraryGUI.Properties.Resources.book;
            this.BookImage.Location = new System.Drawing.Point(24, 113);
            this.BookImage.Name = "BookImage";
            this.BookImage.Size = new System.Drawing.Size(313, 402);
            this.BookImage.TabIndex = 2;
            this.BookImage.TabStop = false;
            this.BookImage.WaitOnLoad = true;
            // 
            // BookPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(657, 576);
            this.Controls.Add(this.CheckoutLabel);
            this.Controls.Add(this.BookImage);
            this.Controls.Add(this.ExitInv);
            this.Controls.Add(this.CheckOutButton);
            this.Name = "BookPopup";
            this.Text = "BookPopup";
            this.Load += new System.EventHandler(this.BookPopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BookImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CheckOutButton;
        private System.Windows.Forms.Button ExitInv;
        private System.Windows.Forms.Label CheckoutLabel;
        private System.Windows.Forms.PictureBox BookImage;
    }
}