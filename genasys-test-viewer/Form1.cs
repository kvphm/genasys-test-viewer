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
            this.unitSn = this.txtUnitSnValue.Text.Trim();

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
                string status = allSnTests[i][unitPassFailColNum].Equals(Constants.LBL_PASSED)
                    ? Constants.LBL_PASSED
                    : Constants.LBL_FAILED;

                // Find date and time for each row in listbox.
                string date = allSnTests[i][dateColNum];
                string time = allSnTests[i][timeColNum];

                // Format text and add a new row to the listbox.
                this.listBox1.Items.Add(date + " " + time + " - " + status);
            }
        }

        // Triggers when a new row has been selected in the listbox.
        private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            // Clears test tree node.
            testTreeView.Nodes.Clear();

            // If selected item is "invalid", return.
            if (listBox1.SelectedItem == null) return;

            // Format and set title for panel 2.
            this.lblTitle.Text = Constants.LBL_UNIT + unitSn;

            // The index of the selected test.
            int selectionIndex = listBox1.FindString(listBox1.SelectedItem.ToString());

            // Get and set info from selected test.
            string op = allSnTests[selectionIndex][opColNum].ToUpper();
            string date = allSnTests[selectionIndex][dateColNum];
            string time = allSnTests[selectionIndex][timeColNum];
            string woNum = allSnTests[selectionIndex][woNumColNum];
            string model = allSnTests[selectionIndex][modelColNum];
            string softwareVer = allSnTests[selectionIndex][softwareColNum];
            string remarks = allSnTests[selectionIndex][remarksColNum];

            if (op.Trim() != "") this.lblOperator.Text = Constants.CHT_HEADER_OPERATOR + Constants.COLON + op;
            if (date.Trim() != "") this.lblDate.Text = Constants.CHT_HEADER_DATE + Constants.COLON + date;
            if (time.Trim() != "") this.lblTime.Text = Constants.CHT_HEADER_TIME + Constants.COLON + time;
            if (woNum.Trim() != "") this.lblWoNum.Text = Constants.CHT_HEADER_WO_NUM + Constants.COLON + woNum;
            if (model.Trim() != "") this.lblModel.Text = Constants.CHT_HEADER_MODEL + Constants.COLON + model;
            if (softwareVer.Trim() != "") this.lblSoftwareVer.Text = Constants.CHT_HEADER_SOFTWARE_VER + Constants.COLON + softwareVer;
            if (remarks.Trim() != "") this.lblRemarks.Text = Constants.CHT_HEADER_REMARKS + Constants.COLON + remarks;

            for (int i = 0; i < compSnColNums.Count; i++)
            {
                string lblHeader = GetHeaderStrFromColNum(compSnColNums[i]);
                string lblValue = allSnTests[selectionIndex][compSnColNums[i]];
                if (lblValue.Trim() == "") continue;
                string label = lblHeader + Constants.COLON + lblValue;
                switch (i)
                {
                    case 0:
                        this.lblCompSn1.Text = label;
                        break;
                    case 1:
                        this.lblCompSn2.Text = label;
                        break;
                    case 2:
                        this.lblCompSn3.Text = label;
                        break;
                    case 3:
                        this.lblCompSn4.Text = label;
                        break;
                    case 4:
                        this.lblCompSn5.Text = label;
                        break;
                    case 5:
                        this.lblCompSn6.Text = label;
                        break;
                    case 6:
                        this.lblCompSn7.Text = label;
                        break;
                    case 7:
                        this.lblCompSn8.Text = label;
                        break;
                    case 8:
                        this.lblCompSn9.Text = label;
                        break;
                    case 9:
                        this.lblCompSn10.Text = label;
                        break;
                    default:
                        throw new IndexOutOfRangeException(Constants.ERR_5);
                }
            }

            for (int i = 0; i < driverSnColNums.Count; i++)
            {
                string lblHeader = GetHeaderStrFromColNum(driverSnColNums[i]);
                string lblValue = allSnTests[selectionIndex][driverSnColNums[i]];
                if (lblValue.Trim() == "") continue;
                string label = lblHeader + Constants.COLON + lblValue;
                switch (i)
                {
                    case 0:
                        this.lblDriverSn1.Text = label;
                        break;
                    case 1:
                        this.lblDriverSn2.Text = label;
                        break;
                    case 2:
                        this.lblDriverSn3.Text = label;
                        break;
                    case 3:
                        this.lblDriverSn4.Text = label;
                        break;
                    case 4:
                        this.lblDriverSn5.Text = label;
                        break;
                    case 5:
                        this.lblDriverSn6.Text = label;
                        break;
                    case 6:
                        this.lblDriverSn7.Text = label;
                        break;
                    case 7:
                        this.lblDriverSn8.Text = label;
                        break;
                    default:
                        throw new IndexOutOfRangeException(Constants.ERR_6);
                }
            }

            // Get test results from selected test.
            string unitPassFail = allSnTests[selectionIndex][unitPassFailColNum];
            System.Windows.Forms.TreeNode nodeRoot = new System.Windows.Forms.TreeNode(
               Constants.CHT_HEADER_PASS_FAIL + Constants.COLON + unitPassFail
            );
            this.testTreeView.Nodes.Add(nodeRoot);
            this.passFailColNums = new List<int>();
            for (int i = driverSnColNums.Last() + 1; i < allSnTests[0].Count; i++)
            {
                if (allSnTests[selectionIndex][i].Equals(Constants.LBL_PASSED) || 
                    allSnTests[selectionIndex][i].Equals(Constants.LBL_FAILED) || 
                    allSnTests[selectionIndex][i].Equals(Constants.LBL_NT)
                ) {
                    passFailColNums.Add(i);
                }
                else
                {
                    break;
                }
            }

            // Set test results from selected test to tree.
            for (int i = 0; i < passFailColNums.Count; i++)
            {
                string lblHeader = GetHeaderStrFromColNum(passFailColNums[i]);
                string lblValue = allSnTests[selectionIndex][passFailColNums[i]];
                if (lblValue.Trim() == "") continue;
                string label = lblHeader + Constants.COLON + lblValue;
                nodeRoot.Nodes.Add(new System.Windows.Forms.TreeNode(Constants.TREE_SPACING + label));
            }

            // Expand the test tree upon selection.
            testTreeView.ExpandAll();
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

            // If test is a pass, make the forecolor green. Else, make it red.
            if (e.Index < 0) return;
            string text = ((ListBox)sender).Items[e.Index].ToString();
            if (text.EndsWith(Constants.LBL_PASSED))
            {
                brush = Brushes.Green;
            }
            else
            {
                brush = Brushes.Red;
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
            this.listBox1.HorizontalExtent = Constants.HORIZONTAL_EXTENT_PANEL_1;
        }

        // Triggers when node in testTreeView are drawn.
        private void testTreeView_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            // The text of a node.
            string text = e.Node.Text;

            // Split text into array with two elements.
            // First element contains entire string except last word.
            // Second element contains last word.
            string[] texts = new string[2];
            texts[0] = text.Substring(0, text.LastIndexOf(' '));
            texts[1] = e.Node.Text.Split(' ').Last();

            // Color parts of string.
            using (Font font = new Font(new System.Drawing.Font("Microsoft Sans Serif", 16F), FontStyle.Regular))
            {
                // First part of the string will have the default black color.
                using (Brush brush = new SolidBrush(Color.Black))
                {
                    e.Graphics.DrawString(texts[0], font, brush, e.Bounds.Left, e.Bounds.Top);
                }

                // Second part of the string will have a color depending on the test verdict.
                Color color;
                switch(texts[1].ToString())
                {
                    case Constants.LBL_PASSED:
                        color = Color.Green;
                        break;
                    case Constants.LBL_FAILED:
                        color = Color.Red;
                        break;
                    case Constants.LBL_NT:
                    default:
                        color = Color.Black;
                        break;
                }
                using (Brush brush = new SolidBrush(color))
                {
                    SizeF s = e.Graphics.MeasureString(texts[0], font);
                    e.Graphics.DrawString(texts[1], font, brush, e.Bounds.Left + (int)s.Width, e.Bounds.Top);
                }
            }
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

            this.lblOperator.Text = "";
            this.lblDate.Text = "";
            this.lblTime.Text = "";
            this.lblWoNum.Text = "";
            this.lblModel.Text = "";
            this.lblSoftwareVer.Text = "";
            this.lblRemarks.Text = "";

            this.lblCompSn1.Text = "";
            this.lblCompSn2.Text = "";
            this.lblCompSn3.Text = "";
            this.lblCompSn4.Text = "";
            this.lblCompSn5.Text = "";
            this.lblCompSn6.Text = "";
            this.lblCompSn7.Text = "";
            this.lblCompSn8.Text = "";
            this.lblCompSn9.Text = "";
            this.lblCompSn10.Text = "";

            this.lblDriverSn1.Text = "";
            this.lblDriverSn2.Text = "";
            this.lblDriverSn3.Text = "";
            this.lblDriverSn4.Text = "";
            this.lblDriverSn5.Text = "";
            this.lblDriverSn6.Text = "";
            this.lblDriverSn7.Text = "";
            this.lblDriverSn8.Text = "";

            testTreeView.Nodes.Clear();
        }

        // Sets column number for each header.
        private void setColNums()
        {
            // Column numbers from exact strings.
            this.opColNum = GetColNumFromHeaderStr(Constants.CHT_HEADER_OPERATOR);
            this.woNumColNum = GetColNumFromHeaderStr(Constants.CHT_HEADER_WO_NUM);
            this.dateColNum = GetColNumFromHeaderStr(Constants.CHT_HEADER_DATE);
            this.timeColNum = GetColNumFromHeaderStr(Constants.CHT_HEADER_TIME);
            this.unitPassFailColNum = GetColNumFromHeaderStr(Constants.CHT_HEADER_PASS_FAIL);
            this.modelColNum = GetColNumFromHeaderStr(Constants.CHT_HEADER_MODEL);
            this.softwareColNum = GetColNumFromHeaderStr(Constants.CHT_HEADER_SOFTWARE_VER);
            this.remarksColNum = GetColNumFromHeaderStr(Constants.CHT_HEADER_REMARKS);

            // Column numbers from substrings.
            this.compSnColNums = GetColNumsFromHeaderSubstr(Constants.CHT_HEADER_SN)
                .Where(x =>
                    !GetHeaderStrFromColNum(x).Equals(Constants.CHT_HEADER_UNIT_SN) &&
                    !GetHeaderStrFromColNum(x).Contains(Constants.CHT_HEADER_DRIVER))
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
                return File.ReadLines(Constants.PATH).First().Split(',')[colNum];
            }
            catch (Exception)
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

    }
}
