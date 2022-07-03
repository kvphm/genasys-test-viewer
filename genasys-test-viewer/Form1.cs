using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace genasys_test_viewer
{
    public partial class formGenasysTestViewer : Form
    {
        public formGenasysTestViewer()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string unitSn = this.txtUnitSnValue.Text;
            List<List<string>> allSnTests = GetAllTestsFromUnitSn(unitSn);
            if (String.IsNullOrEmpty(unitSn.Trim()))
            {
                Reinitialize();
                return;
            }
            this.lblResultNum.Text = allSnTests.Count + Constants.LBL_TESTS_FOUND;
            foreach (var aTest in allSnTests)
            {                
                /*
                Label lbl = new System.Windows.Forms.Label();
                lbl.AutoSize = true;
                lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
                lbl.Location = new System.Drawing.Point(3, 19);
                lbl.Name = "aTest";
                lbl.Size = new System.Drawing.Size(140, 17);
                lbl.TabIndex = 4;
                lbl.Text = "11/11/2022 11:11PM - ";
                this.pnlResults.Controls.Add(lbl);
                */
                
            }
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            if (this.splitContainer1.Panel1Collapsed == true)
            {
                this.btnResize.Text = "«";
                this.splitContainer1.Panel1Collapsed = false;
            }
            else
            {
                this.btnResize.Text = "»";
                this.splitContainer1.Panel1Collapsed = true;
            }
        }

        private void Reinitialize()
        {
            // TODO
        }

        private List<int> GetColNumsFromStr(string str)
        {
            List<int> colNums = new List<int>();
            string[] row1 = File.ReadLines(Constants.PATH).First().Split(',');
            for (int i = 0; i < row1.Length; i++)
            {
                if (row1[i].Equals(str))
                {
                    colNums.Add(i);
                }
            }
            return colNums;
        }

        private List<int> GetColNumsFromSubstr(string substr)
        {
            List<int> colNums = new List<int>();
            string[] row1 = File.ReadLines(Constants.PATH).First().Split(',');
            for (int i = 0; i < row1.Length; i++)
            {
                if (row1[i].Contains(substr))
                {
                    colNums.Add(i);
                }
            }
            return colNums;
        }

        private List<List<string>> GetAllTestsFromUnitSn(string unitSn)
        {
            List<List<string>> alltestsFromSn = new List<List<string>>();
            using (var reader = new StreamReader(@Constants.PATH))
            {
                List<int> unitSnCol = GetColNumsFromStr(Constants.CHT_HEADER_UNIT_SN);
                if (unitSnCol == null)
                {
                    throw new System.IO.FileFormatException(Constants.CHT_HEADER_UNIT_SN + Constants.ERR_1);
                }
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    String[] row = values[0].Split(',');
                    if (row[unitSnCol[0]] == unitSn)
                    {
                        alltestsFromSn.Add(new List<string>(row));
                    }
                }
            }
            alltestsFromSn.Reverse();
            return alltestsFromSn;
        }

        private void lblUnitSnHeader_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
