namespace FilterExcelDuplicates
{
    partial class ExcelDuplicateSifter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelDuplicateSifter));
            this.Browse1 = new System.Windows.Forms.Button();
            this.BrowseTB1 = new System.Windows.Forms.TextBox();
            this.BrowseLBL1 = new System.Windows.Forms.Label();
            this.BrowseLBL2 = new System.Windows.Forms.Label();
            this.SiftButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SheetNameTB = new System.Windows.Forms.TextBox();
            this.SheetNameLBL = new System.Windows.Forms.Label();
            this.RestartButton = new System.Windows.Forms.Button();
            this.hasHeaderRow = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Browse1
            // 
            this.Browse1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Browse1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browse1.Location = new System.Drawing.Point(174, 71);
            this.Browse1.Name = "Browse1";
            this.Browse1.Size = new System.Drawing.Size(87, 24);
            this.Browse1.TabIndex = 0;
            this.Browse1.Text = "Browse...";
            this.Browse1.UseVisualStyleBackColor = false;
            this.Browse1.Click += new System.EventHandler(this.Browse1_Click);
            // 
            // BrowseTB1
            // 
            this.BrowseTB1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseTB1.Location = new System.Drawing.Point(35, 101);
            this.BrowseTB1.Name = "BrowseTB1";
            this.BrowseTB1.Size = new System.Drawing.Size(351, 23);
            this.BrowseTB1.TabIndex = 2;
            this.BrowseTB1.TextChanged += new System.EventHandler(this.BrowseTB1_TextChanged);
            // 
            // BrowseLBL1
            // 
            this.BrowseLBL1.AutoSize = true;
            this.BrowseLBL1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseLBL1.Location = new System.Drawing.Point(121, 39);
            this.BrowseLBL1.Name = "BrowseLBL1";
            this.BrowseLBL1.Size = new System.Drawing.Size(198, 15);
            this.BrowseLBL1.TabIndex = 4;
            this.BrowseLBL1.Text = "Select the Excel file you want to sift";
            // 
            // BrowseLBL2
            // 
            this.BrowseLBL2.AutoSize = true;
            this.BrowseLBL2.Location = new System.Drawing.Point(348, 196);
            this.BrowseLBL2.Name = "BrowseLBL2";
            this.BrowseLBL2.Size = new System.Drawing.Size(0, 15);
            this.BrowseLBL2.TabIndex = 5;
            // 
            // SiftButton
            // 
            this.SiftButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SiftButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SiftButton.Location = new System.Drawing.Point(228, 265);
            this.SiftButton.Name = "SiftButton";
            this.SiftButton.Size = new System.Drawing.Size(66, 23);
            this.SiftButton.TabIndex = 6;
            this.SiftButton.Text = "Sift!";
            this.SiftButton.UseVisualStyleBackColor = false;
            this.SiftButton.Click += new System.EventHandler(this.SiftButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SheetNameTB
            // 
            this.SheetNameTB.Location = new System.Drawing.Point(174, 188);
            this.SheetNameTB.Name = "SheetNameTB";
            this.SheetNameTB.Size = new System.Drawing.Size(87, 23);
            this.SheetNameTB.TabIndex = 7;
            this.SheetNameTB.Text = "Sheet1";
            this.SheetNameTB.TextChanged += new System.EventHandler(this.SheetNameTB_TextChanged);
            // 
            // SheetNameLBL
            // 
            this.SheetNameLBL.AutoSize = true;
            this.SheetNameLBL.Location = new System.Drawing.Point(121, 161);
            this.SheetNameLBL.Name = "SheetNameLBL";
            this.SheetNameLBL.Size = new System.Drawing.Size(202, 15);
            this.SheetNameLBL.TabIndex = 8;
            this.SheetNameLBL.Text = "Enter name of sheet you want to sift";
            this.SheetNameLBL.Click += new System.EventHandler(this.SheetNameLBL_Click);
            // 
            // RestartButton
            // 
            this.RestartButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RestartButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartButton.Location = new System.Drawing.Point(145, 265);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(66, 23);
            this.RestartButton.TabIndex = 9;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = false;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // hasHeaderRow
            // 
            this.hasHeaderRow.AutoSize = true;
            this.hasHeaderRow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.hasHeaderRow.Location = new System.Drawing.Point(161, 230);
            this.hasHeaderRow.Name = "hasHeaderRow";
            this.hasHeaderRow.Size = new System.Drawing.Size(121, 19);
            this.hasHeaderRow.TabIndex = 10;
            this.hasHeaderRow.Text = "Has Header Row?";
            this.hasHeaderRow.UseVisualStyleBackColor = false;
            // 
            // ExcelDuplicateSifter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(430, 359);
            this.Controls.Add(this.hasHeaderRow);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.SheetNameLBL);
            this.Controls.Add(this.SheetNameTB);
            this.Controls.Add(this.SiftButton);
            this.Controls.Add(this.BrowseLBL2);
            this.Controls.Add(this.BrowseLBL1);
            this.Controls.Add(this.BrowseTB1);
            this.Controls.Add(this.Browse1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExcelDuplicateSifter";
            this.Text = "Excel Duplicate Sifter";
            this.Load += new System.EventHandler(this.ExcelDuplicateSifter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Browse1;
        private System.Windows.Forms.TextBox BrowseTB1;
        private System.Windows.Forms.Label BrowseLBL1;
        private System.Windows.Forms.Label BrowseLBL2;
        private System.Windows.Forms.Button SiftButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox SheetNameTB;
        private System.Windows.Forms.Label SheetNameLBL;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.CheckBox hasHeaderRow;
    }
}

