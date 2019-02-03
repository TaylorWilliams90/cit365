namespace MegaDesk_3_TaylorWilliams
{
    partial class AddQuote
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
            this.CustomerName = new System.Windows.Forms.Label();
            this.Qoutewidth = new System.Windows.Forms.Label();
            this.Qoutedepth = new System.Windows.Forms.Label();
            this.Qoutedrawers = new System.Windows.Forms.Label();
            this.Qouterush = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.width = new System.Windows.Forms.TextBox();
            this.depth = new System.Windows.Forms.TextBox();
            this.Drawers = new System.Windows.Forms.TextBox();
            this.cancelQuoteButton = new System.Windows.Forms.Button();
            this.CalcQuote = new System.Windows.Forms.Button();
            this.materialtxt = new System.Windows.Forms.Label();
            this.MaterialBox = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSize = true;
            this.CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerName.Location = new System.Drawing.Point(38, 43);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(263, 37);
            this.CustomerName.TabIndex = 0;
            this.CustomerName.Text = "Customer name :";
            // 
            // Qoutewidth
            // 
            this.Qoutewidth.AutoSize = true;
            this.Qoutewidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qoutewidth.Location = new System.Drawing.Point(38, 103);
            this.Qoutewidth.Name = "Qoutewidth";
            this.Qoutewidth.Size = new System.Drawing.Size(230, 37);
            this.Qoutewidth.TabIndex = 1;
            this.Qoutewidth.Text = "Width of desk :";
            // 
            // Qoutedepth
            // 
            this.Qoutedepth.AutoSize = true;
            this.Qoutedepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qoutedepth.Location = new System.Drawing.Point(38, 170);
            this.Qoutedepth.Name = "Qoutedepth";
            this.Qoutedepth.Size = new System.Drawing.Size(232, 37);
            this.Qoutedepth.TabIndex = 2;
            this.Qoutedepth.Text = "Depth of desk :";
            // 
            // Qoutedrawers
            // 
            this.Qoutedrawers.AutoSize = true;
            this.Qoutedrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qoutedrawers.Location = new System.Drawing.Point(38, 232);
            this.Qoutedrawers.Name = "Qoutedrawers";
            this.Qoutedrawers.Size = new System.Drawing.Size(309, 37);
            this.Qoutedrawers.TabIndex = 3;
            this.Qoutedrawers.Text = "Number of drawers :";
            // 
            // Qouterush
            // 
            this.Qouterush.AutoSize = true;
            this.Qouterush.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qouterush.Location = new System.Drawing.Point(38, 408);
            this.Qouterush.Name = "Qouterush";
            this.Qouterush.Size = new System.Drawing.Size(401, 37);
            this.Qouterush.TabIndex = 4;
            this.Qouterush.Text = "Days to order to complete :";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(510, 43);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(204, 35);
            this.name.TabIndex = 5;
            // 
            // width
            // 
            this.width.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.width.Location = new System.Drawing.Point(511, 103);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(204, 35);
            this.width.TabIndex = 6;
            this.width.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.width_KeyPress_1);
            // 
            // depth
            // 
            this.depth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depth.Location = new System.Drawing.Point(511, 170);
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(204, 35);
            this.depth.TabIndex = 7;
            this.depth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.depth_KeyPress);
            // 
            // Drawers
            // 
            this.Drawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drawers.Location = new System.Drawing.Point(511, 234);
            this.Drawers.Name = "Drawers";
            this.Drawers.Size = new System.Drawing.Size(204, 35);
            this.Drawers.TabIndex = 8;
            // 
            // cancelQuoteButton
            // 
            this.cancelQuoteButton.Location = new System.Drawing.Point(263, 565);
            this.cancelQuoteButton.Name = "cancelQuoteButton";
            this.cancelQuoteButton.Size = new System.Drawing.Size(202, 46);
            this.cancelQuoteButton.TabIndex = 10;
            this.cancelQuoteButton.Text = "Cancel";
            this.cancelQuoteButton.UseVisualStyleBackColor = true;
            this.cancelQuoteButton.Click += new System.EventHandler(this.cancelQuoteButton_Click);
            // 
            // CalcQuote
            // 
            this.CalcQuote.Location = new System.Drawing.Point(511, 565);
            this.CalcQuote.Name = "CalcQuote";
            this.CalcQuote.Size = new System.Drawing.Size(202, 46);
            this.CalcQuote.TabIndex = 11;
            this.CalcQuote.Text = "Process Quote";
            this.CalcQuote.UseVisualStyleBackColor = true;
            this.CalcQuote.Click += new System.EventHandler(this.CalcQuote_Click);
            // 
            // materialtxt
            // 
            this.materialtxt.AutoSize = true;
            this.materialtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialtxt.Location = new System.Drawing.Point(38, 324);
            this.materialtxt.Name = "materialtxt";
            this.materialtxt.Size = new System.Drawing.Size(332, 37);
            this.materialtxt.TabIndex = 13;
            this.materialtxt.Text = "Material for the order :";
            // 
            // MaterialBox
            // 
            this.MaterialBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialBox.FormattingEnabled = true;
            this.MaterialBox.Location = new System.Drawing.Point(511, 324);
            this.MaterialBox.Name = "MaterialBox";
            this.MaterialBox.Size = new System.Drawing.Size(204, 37);
            this.MaterialBox.TabIndex = 14;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(511, 411);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(203, 37);
            this.comboBox2.TabIndex = 15;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 635);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.MaterialBox);
            this.Controls.Add(this.materialtxt);
            this.Controls.Add(this.CalcQuote);
            this.Controls.Add(this.cancelQuoteButton);
            this.Controls.Add(this.Drawers);
            this.Controls.Add(this.depth);
            this.Controls.Add(this.width);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Qouterush);
            this.Controls.Add(this.Qoutedrawers);
            this.Controls.Add(this.Qoutedepth);
            this.Controls.Add(this.Qoutewidth);
            this.Controls.Add(this.CustomerName);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomerName;
        private System.Windows.Forms.Label Qoutewidth;
        private System.Windows.Forms.Label Qoutedepth;
        private System.Windows.Forms.Label Qoutedrawers;
        private System.Windows.Forms.Label Qouterush;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox width;
        private System.Windows.Forms.TextBox depth;
        private System.Windows.Forms.TextBox Drawers;
        private System.Windows.Forms.Button cancelQuoteButton;
        private System.Windows.Forms.Button CalcQuote;
        private System.Windows.Forms.Label materialtxt;
        private System.Windows.Forms.ComboBox MaterialBox;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}