using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;

namespace FilterExcelDuplicates
{
    public partial class ExcelDuplicateSifter : Form
    {
        public ExcelDuplicateSifter()
        {
            InitializeComponent();
        }

        private void Browse1_Click(object sender, EventArgs e)
        {

            DialogResult result = openFileDialog1.ShowDialog(this); // Show the dialog.
            
            openFileDialog1.DefaultExt = ".xlsx";

            string ext = Path.GetExtension(openFileDialog1.FileName);

            if (result == DialogResult.OK && (ext.Equals(".xlsx") || ext.Equals(".xls") || ext.Equals(".csv"))) // Test result.
            {
                BrowseTB1.Text = openFileDialog1.FileName;
               
                SiftButton.Enabled = true;
                SheetNameTB.Enabled = true;
                SheetNameLBL.Enabled = true;
                hasHeaderRow.Enabled = true;
                SheetNameTB.Text = "Sheet1";

            }
            else
            {
                MessageBox.Show("Incorrect File Type");
            }
        }

        private void ExcelDuplicateSifter_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            SiftButton.Enabled = false;
            BrowseTB1.Enabled = false;
            SheetNameTB.Enabled = false;
            SheetNameLBL.Enabled = false;
            hasHeaderRow.Enabled = false;
        }

        private void BrowseTB1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SiftButton_Click(object sender, EventArgs e)
        {
            try
            {
                string filenm = BrowseTB1.Text;
                if (SheetNameTB.Text == "")
                {
                    MessageBox.Show("Please Enter a Sheet name.");
                    return;
                }
                //This code re-generates the entire Building/Room for all of campus (as listed in the main inventory file)
                //TODO: change path to generic OneDrive Path for inventory, BasicConfig, and Access Control, revise and rename sheet as well.
                //TODO: Add xml Wrappers <root> or whatever. This is a complete generation.
                NPOI.XSSF.UserModel.XSSFWorkbook xssfwb;
                using (FileStream file = new FileStream(filenm, FileMode.Open, FileAccess.Read))
                {
                    xssfwb = new NPOI.XSSF.UserModel.XSSFWorkbook(file);
                }
                ISheet sheet = xssfwb.GetSheet(SheetNameTB.Text);
                int numRows = sheet.LastRowNum;
                int numCols = sheet.GetRow(0).LastCellNum;

                List<string> values = new List<string>();

                try
                {
                    using (StreamWriter configFile = File.AppendText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\SiftedResults.txt"))
                    {
                        for (int row = hasHeaderRow.Checked ? 1 : 0; row <= numRows; row++) //That's dope
                        {
                            for (int col = 0; col < numCols; col++)
                            {
                                string cellVal = sheet.GetRow(row).GetCell(col).StringCellValue;

                                if (!values.Contains(cellVal))
                                {
                                    values.Add(cellVal);
                                }
                            }
                        }

                        foreach (string val in values)
                        {
                            configFile.WriteLine(val);
                        }

                        MessageBox.Show("The Results have been saved to your Desktop.");

                        RestartButton_Click(sender, e);

                    }
                }
                catch (NullReferenceException) //Hey man, it just happens sometimes.
                {
                    //Do nothing
                }
            } catch (Exception er)
            {
               MessageBox.Show("Error: " + er);
            }


        }

        private void SheetNameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void SheetNameLBL_Click(object sender, EventArgs e)
        {

        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            this.CenterToScreen();
            BrowseTB1.Text = "";
            SheetNameTB.Text = "";
            SiftButton.Enabled = false;
            BrowseTB1.Enabled = false;
            SheetNameTB.Enabled = false;
            SheetNameLBL.Enabled = false;
            hasHeaderRow.Enabled = false;
        }
    }
}
