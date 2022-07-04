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
            if (String.IsNullOrEmpty(unitSn.Trim())) return;
            this.lblResultNum.Text = allSnTests.Count + Constants.LBL_TESTS_FOUND;
            int dateColNum = GetColNumFromStr(Constants.CHT_HEADER_DATE);
            int timeColNum = GetColNumFromStr(Constants.CHT_HEADER_TIME);
            int passFailColNum = GetColNumFromStr(Constants.CHT_HEADER_PASS_FAIL);
            this.listBox1.Items.Clear();
            for (int i = 0; i < allSnTests.Count; i++)
            {
                string status = allSnTests[i][passFailColNum].Equals("")
                    ? Constants.LBL_INCONCLUSIVE
                    : allSnTests[i][passFailColNum];
                string date = allSnTests[i][dateColNum];
                if (date.Equals(""))
                {
                    throw new System.IO.FileFormatException(Constants.ERR_2 + (i + 1));
                }
                string time = allSnTests[i][timeColNum];
                if (time.Equals(""))
                {
                    throw new System.IO.FileFormatException(Constants.ERR_3 + (i + 1));
                }
                this.listBox1.Items.Add(
                    allSnTests[i][dateColNum] + " " + allSnTests[i][timeColNum] + " - " + status
                );
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

        private int GetColNumFromStr(string str)
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
            if (colNums.Count != 1)
            {
                throw new System.IO.FileFormatException(str + Constants.ERR_1);
            }
            return colNums[0];
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
                int unitSnCol = GetColNumFromStr(Constants.CHT_HEADER_UNIT_SN);
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    String[] row = values[0].Split(',');
                    if (row[unitSnCol] == unitSn)
                    {
                        alltestsFromSn.Add(new List<string>(row));
                    }
                }
            }
            alltestsFromSn.Reverse();
            return alltestsFromSn;
        }

    }
}
