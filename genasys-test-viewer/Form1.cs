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
        // formGenasysTestViewer constructor.
        public formGenasysTestViewer()
        {
            // Component initialization.
            InitializeComponent();
        }

        /* ---------------------------------- Events ---------------------------------- */
        // Triggers when "Search" button is pressed.
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Gets unit SN from user-inputted text box.
            this.unitSn = this.txtUnitSnValue.Text;

            // If textbox is empty or contains only whitespace characters, return. 
            if (String.IsNullOrEmpty(unitSn.Trim())) return;

            // Reads a CSV file and puts all tests in List<List<string>>
            this.allSnTests = GetAllTestsFromUnitSn(unitSn);

            // Clear both panels to begin a new search.
            clearPanels();

            // Finds and set the column numbers for all of the designated headers.
            setColNums();

            // Display number of tests found for that particular unit SN.
            this.lblResultNum.Text = allSnTests.Count + Constants.LBL_TESTS_FOUND;
            
            // Iterating through each test in List<List<string>>.
            for (int i = 0; i < allSnTests.Count; i++)
            {

                // Determines if test has passed or failed from data.
                string status;
                if (allSnTests[i][unitPassFailColNum].Equals(Constants.LBL_PASSED))
                {
                    status = Constants.LBL_PASSED;
                }
                else
                {
                    if (allSnTests[i].Contains(Constants.LBL_FAILED))
                    {
                        status = Constants.LBL_FAILED;
                    }
                    else
                    {
                        status = Constants.LBL_INCONCLUSIVE;
                    }
                }

                // Find date and time for each row in listbox. If there's no date and time,
                // FileFormatException will be thrown.
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

                // Format text and add a new row to the listbox.
                this.listBox1.Items.Add(date + " " + time + " - " + status);
            }
        }

        // Triggers when a new row has been selected in the listbox.
        private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            // If selected item is "invalid", return.
            if (listBox1.SelectedItem == null) return;

            // Format and set title for panel 2.
            string title = "Unit " + unitSn;
            this.lblTitle.Text = title;

            // The index of the selected item.
            int selectIndex = listBox1.FindString(listBox1.SelectedItem.ToString());

            // Get info from selected row.
            string op = allSnTests[selectIndex][opColNum];
            string date = allSnTests[selectIndex][dateColNum];
            string time = allSnTests[selectIndex][timeColNum];
            string woNum = allSnTests[selectIndex][woNumColNum];
            string model = allSnTests[selectIndex][modelColNum];

            string unitPassFail = allSnTests[selectIndex][unitPassFailColNum];

            // TODO
            // ...
        }

        // Triggers when the listbox is drawn.
        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Draws background of listbox.
            e.DrawBackground();

            // Sets selection to yellow.
            Brush brush = ((e.State & DrawItemState.Selected) == DrawItemState.Selected) 
                ? Brushes.WhiteSmoke
                : new SolidBrush(e.BackColor);
            e.Graphics.FillRectangle(brush, e.Bounds);
            
            // If test is a pass, make the forecolor green. Else, make it black.
            if (e.Index < 0) return;
            string text = ((ListBox)sender).Items[e.Index].ToString();
            if (text.EndsWith(Constants.LBL_PASSED))
            {
                brush = Brushes.Green;
            }
            else if (text.EndsWith(Constants.LBL_FAILED))
            {
                brush = Brushes.Red;
            }
            else
            {
                brush = Brushes.Black;
            }
            e.Graphics.DrawString(
                text,
                e.Font, 
                brush, 
                e.Bounds, 
                StringFormat.GenericDefault
            );
            e.DrawFocusRectangle();

            // Needed because owner-set parameters. For horizontal scroll capabilities.
            this.listBox1.HorizontalExtent = 401;
        }

        // Triggers when the resize button is pressed.
        private void btnResize_Click(object sender, EventArgs e)
        {
            if (this.splitContainer1.Panel1Collapsed == true)
            {
                this.btnResize.Text = Constants.MINIMIZE;
                this.splitContainer1.Panel1Collapsed = false;
            }
            else
            {
                this.btnResize.Text = Constants.MAXIMIZE;
                this.splitContainer1.Panel1Collapsed = true;
            }
        }

        /* ----------------------------- Helper Functions ----------------------------- */
        // Clear panels.
        private void clearPanels()
        {
            this.listBox1.Items.Clear();
            this.lblTitle.Text = "";
        }

        // Sets column number for each header.
        private void setColNums()
        {
            // Column numbers from exact strings.
            this.opColNum = GetColNumFromHeaderStr(Constants.CHT_HEADER_OPERATOR);
            this.woNumColNum = GetColNumFromHeaderStr(Constants.CHT_HEADER_WONum);
            this.dateColNum = GetColNumFromHeaderStr(Constants.CHT_HEADER_DATE);
            this.timeColNum = GetColNumFromHeaderStr(Constants.CHT_HEADER_TIME);
            this.unitPassFailColNum = GetColNumFromHeaderStr(Constants.CHT_HEADER_PASS_FAIL);
            this.modelColNum = GetColNumFromHeaderStr(Constants.CHT_HEADER_MODEL);

            // Column numbers from substrings.
            this.componentSnColNums = GetColNumsFromHeaderSubstr(Constants.CHT_HEADER_SN)
                .Where(x => !x.ToString()
                .Contains(Constants.CHT_HEADER_DRIVER))
                .ToList();
            this.driverSnColNums = GetColNumsFromHeaderSubstr(Constants.CHT_HEADER_DRIVER);
        }

        // Gets column number from header name as a string.
        private int GetColNumFromHeaderStr(string str)
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

        // Gets column number(s) from header name as substring.
        private List<int> GetColNumsFromHeaderSubstr(string substr)
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

        // Get header string from column number.
        private string GetHeaderStrFromColNum(int colNum)
        {
            try
            {
                return allSnTests[0][colNum];
            }
            catch(Exception)
            {
                throw new System.IO.FileFormatException(Constants.ERR_4);
            }
        }

        // Compiles all tests from a given unit SN into a List<List<String>>.
        private List<List<string>> GetAllTestsFromUnitSn(string unitSn)
        {
            List<List<string>> allTestsFromSn = new List<List<string>>();
            using (var reader = new StreamReader(@Constants.PATH))
            {
                int unitSnCol = GetColNumFromHeaderStr(Constants.CHT_HEADER_UNIT_SN);
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    String[] row = values[0].Split(',');
                    if (row[unitSnCol] == unitSn)
                    {
                        allTestsFromSn.Add(new List<string>(row));
                    }
                }
            }
            allTestsFromSn.Reverse();
            return allTestsFromSn;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
