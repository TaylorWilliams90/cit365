﻿namespace MegaDesk_3_TaylorWilliams
{
    partial class MegaDesk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MegaDesk));
            this.AddQuote = new System.Windows.Forms.Button();
            this.ViewQuotes = new System.Windows.Forms.Button();
            this.SearchQuotes = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddQuote
            // 
            this.AddQuote.Location = new System.Drawing.Point(30, 19);
            this.AddQuote.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddQuote.Name = "AddQuote";
            this.AddQuote.Size = new System.Drawing.Size(111, 40);
            this.AddQuote.TabIndex = 0;
            this.AddQuote.Text = "Add New Quote";
            this.AddQuote.UseVisualStyleBackColor = true;
            this.AddQuote.Click += new System.EventHandler(this.AddQuote_Click);
            // 
            // ViewQuotes
            // 
            this.ViewQuotes.Location = new System.Drawing.Point(30, 81);
            this.ViewQuotes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ViewQuotes.Name = "ViewQuotes";
            this.ViewQuotes.Size = new System.Drawing.Size(111, 40);
            this.ViewQuotes.TabIndex = 1;
            this.ViewQuotes.Text = "Veiw Quotes";
            this.ViewQuotes.UseVisualStyleBackColor = true;
            // 
            // SearchQuotes
            // 
            this.SearchQuotes.Location = new System.Drawing.Point(30, 148);
            this.SearchQuotes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchQuotes.Name = "SearchQuotes";
            this.SearchQuotes.Size = new System.Drawing.Size(111, 40);
            this.SearchQuotes.TabIndex = 2;
            this.SearchQuotes.Text = "Search Quotes";
            this.SearchQuotes.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(30, 210);
            this.Exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(111, 40);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(187, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 276);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MegaDesk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 348);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.SearchQuotes);
            this.Controls.Add(this.ViewQuotes);
            this.Controls.Add(this.AddQuote);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MegaDesk";
            this.Text = "MegaDesk";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddQuote;
        private System.Windows.Forms.Button ViewQuotes;
        private System.Windows.Forms.Button SearchQuotes;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

