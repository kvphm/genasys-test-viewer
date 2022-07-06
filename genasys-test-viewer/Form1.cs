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

            // Clear listbox.
            this.listBox1.Items.Clear();

            // Clear panel 2.
            clearPanel2();

            // Finds and set the column numbers for all of the designated headers.
            setColNums();

            // Display number of tests found for that particular unit SN.
            this.lblResultNum.Text = allSnTests.Count + Constants.LBL_TESTS_FOUND;

            // Add items to listbox.
            addItemsToListBox();
        }

        // Triggers when a new row has been selected in the listbox.
        private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            // Clears panel 2.
            clearPanel2();

            // If selected item is null, return.
            if (listBox1.SelectedItem == null) return;

            // The index of the selected test.
            int selectionIndex = listBox1.FindString(listBox1.SelectedItem.ToString());

            // Get and set info from selected test.
            setPanel2Info(selectionIndex);

            // Expand the test tree upon selection.
            testTreeView.ExpandAll();
        }

        // Triggers when the listbox is drawn.
        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        { 
            // Draws background of listbox.
            e.DrawBackground();

            // Sets selection to white smoke.
            Brush brush = ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                ? Brushes.WhiteSmoke
                : new SolidBrush(e.BackColor);
            e.Graphics.FillRectangle(brush, e.Bounds);

            // Test passed = green. Test failed = red.
            if (e.Index < 0) return;
            string text = ((ListBox)sender).Items[e.Index].ToString();
            brush = text.EndsWith(Constants.LBL_PASSED) ? Brushes.Green : Brushes.Red;
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
                        color = Color.Gray;
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
            // When panel 1 is collapsed and button is pressed.
            if (this.splitContainer1.Panel1Collapsed == true)
            {
                this.btnResize.Text = Constants.MINIMIZE;
                this.splitContainer1.Panel1Collapsed = false;
            }
            // When panel 1 is not collapsed.
            else
            {
                this.btnResize.Text = Constants.MAXIMIZE;
                this.splitContainer1.Panel1Collapsed = true;
            }
        }

        /* ----------------------------- Helper Functions ----------------------------- */
        // Add items to list box.
        private void addItemsToListBox()
        {
            // Iterating through each test in List<List<string>>.
            for (int i = 0; i < allSnTests.Count; i++)
            {
                // Determines if test has passed or failed from data.
                string status = allSnTests[i][Constants.UNIT_PASS_FAIL_COL_NUM].Equals(Constants.LBL_PASSED)
                    ? Constants.LBL_PASSED
                    : Constants.LBL_FAILED;

                // Find date and time for each row in listbox.
                string date = allSnTests[i][Constants.DATE_COL_NUM];
                string time = allSnTests[i][Constants.TIME_COL_NUM];

                // Format text and add a new row to the listbox.
                string text = $"{date} {time} - {status}";
                if (problematicSnList.Contains(unitSn))
                {
                    text += $" {Constants.WARNING_SIGN}";
                }
                this.listBox1.Items.Add(text);
            }
        }

        private void clearPanel2()
        {
            // Clear title.
            this.lblTitle.Text = "";

            // Clear first column of second panel.
            this.lblOperator.Text = "";
            this.lblDate.Text = "";
            this.lblTime.Text = "";
            this.lblWoNum.Text = "";
            this.lblModel.Text = "";
            this.lblSoftwareVer.Text = "";
            this.lblRemarks.Text = "";

            // Clear second column of second panel.
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

            // Clear third column of second panel.
            this.lblDriverSn1.Text = "";
            this.lblDriverSn2.Text = "";
            this.lblDriverSn3.Text = "";
            this.lblDriverSn4.Text = "";
            this.lblDriverSn5.Text = "";
            this.lblDriverSn6.Text = "";
            this.lblDriverSn7.Text = "";
            this.lblDriverSn8.Text = "";

            // Clear test tree nodes.
            testTreeView.Nodes.Clear();
        }

        // Sets column number for each header.
        private void setColNums()
        {
            // Header row.
            string[] headerRow = File.ReadLines(Constants.PATH).First().Split(',');

            // Column 0 - 6 have been assigned in Constants.

            // Sets P/F.
            this.passFailColNums = new List<int>();
            bool wasInPfRegion = false;
            for (int i = Constants.MODEL_COL_NUM + 1; i < headerRow.Length; i++)
            {
                if (allSnTests.Count == 0) continue;
                else if (
                    allSnTests.Last()[i].Equals(Constants.LBL_PASSED) ||
                    allSnTests.Last()[i].Equals(Constants.LBL_FAILED) ||
                    allSnTests.Last()[i].Equals(Constants.LBL_NT)
                )
                {
                    wasInPfRegion = true;
                    this.passFailColNums.Add(i);
                }
                else if (wasInPfRegion)
                {
                    break;
                }
            }

            // Sets component SN.
            this.compSnColNums = new List<int>();
            bool wasInSnRegion = false;
            for (int i = Constants.MODEL_COL_NUM + 1; i < headerRow.Length; i++)
            {
                if (allSnTests.Count == 0) continue;
                else if (
                    !headerRow[i].Contains(Constants.CHT_HEADER_DRIVER) &&
                    !allSnTests.Last()[i].Equals(Constants.LBL_PASSED) &&
                    !allSnTests.Last()[i].Equals(Constants.LBL_FAILED) &&
                    !allSnTests.Last()[i].Equals(Constants.LBL_NT)
                )
                {
                    wasInSnRegion = true;
                    this.compSnColNums.Add(i);
                }
                else if (wasInSnRegion) {
                    break;
                }
            }

            // Sets driver SN.
            this.compSnColNums = new List<int>();
            this.driverSnColNums = GetColNumsFromHeaderSubstr(Constants.CHT_HEADER_DRIVER);

            // Set miscellaneous data.
            this.softwareColNum = headerRow.Length - 2;
            this.remarksColNum = headerRow.Length - 1;
        }

        // Gets column number(s) from header name as substring.
        private List<int> GetColNumsFromHeaderSubstr(string substr)
        {
            // List to store column numbers.
            List<int> colNums = new List<int>();

            // Header row array.
            string[] headerRow = File.ReadLines(Constants.PATH).First().Split(',');
            for (int i = 0; i < headerRow.Length; i++)
            {
                // If there is an element that contains substr, add element to colNums.
                if (headerRow[i].Contains(substr))
                {
                    colNums.Add(i);
                }
            }

            // Return a List of ColNums.
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
            if (unitSn.Trim() != Constants.CHT_HEADER_UNIT_SN) {
                this.problematicSnList = new List<string>();
                using (var reader = new StreamReader(@Constants.PATH))
                {
                    int unitSnCol = Constants.UNIT_SN_COL_NUM;

                    // Iterating through each line of .CSV file.
                    while (!reader.EndOfStream)
                    {
                        // Parse data.
                        var line = reader.ReadLine();
                        var values = line.Split(';');
                        List<String> row = values[0].Split(',').ToList();

                        // If unit SN matches, add row (as a list) into another list.
                        // Ignores header row.
                        /*
                        if (row[unitSnCol] == unitSn)
                        {
                            */
                            // Append empty strings if there are missing fields at end.
                            int headerRowSize = File.ReadLines(Constants.PATH).First().Split(',').Length;
                            int selectedRowSize = row.Count;
                            int elementsNeeded = headerRowSize - selectedRowSize;
                            if (elementsNeeded > 0) {
                                for (int i = 0; i < elementsNeeded; i++)
                                {
                                    row.Add("");
                                }
                            }

                            // If data in rows have empty strings, disregarding the "Remarks" field,
                            // this would mean that the data shown is problematic. Problematic SNs
                            // will be added to problematicSnList.
                            List<string> temp = new List<string>(row);
                            temp.RemoveAt(row.Count - 1);
                            if (temp.Contains("")) {
                                problematicSnList.Add(unitSn);
                            }
                            
                            // Add row into list of rows once data have been collected and parsed.
                            allTestsFromSn.Add(new List<string>(row));
                      
                        //}
                    }
                }
                // To make list of tests ordered as latest first.
                allTestsFromSn.Reverse();
            }

            // Return test data for selected unit SN.
            return allTestsFromSn;
        }

        // Sets info on panel given the selection index.
        private void setPanel2Info(int selectionIndex)
        {
            // Set title.
            this.unitSn = allSnTests[selectionIndex][Constants.UNIT_SN_COL_NUM];
            string text = Constants.LBL_UNIT + unitSn;
            if (problematicSnList.Contains(unitSn))
            {
                text += $" {Constants.WARNING_SIGN}";
            }
            this.lblTitle.Text = text;

            // Selected row.
            List<string> selectedRow = allSnTests[selectionIndex];

            // Retrieve column 1 data. 
            string op = selectedRow[Constants.OP_COL_NUM];
            string date = selectedRow[Constants.DATE_COL_NUM];
            string time = selectedRow[Constants.TIME_COL_NUM];
            string woNum = selectedRow[Constants.WO_NUM_COL_NUM];
            string model = selectedRow[Constants.MODEL_COL_NUM];
            string softwareVer = selectedRow[softwareColNum];
            string remarks = selectedRow[remarksColNum];

            // If field is not empty, set column 1 data (general info).
            if (op.Trim() != "") this.lblOperator.Text = Constants.CHT_HEADER_OPERATOR + Constants.COLON + op.ToUpper();
            if (date.Trim() != "") this.lblDate.Text = Constants.CHT_HEADER_DATE + Constants.COLON + date;
            if (time.Trim() != "") this.lblTime.Text = Constants.CHT_HEADER_TIME + Constants.COLON + time;
            if (woNum.Trim() != "") this.lblWoNum.Text = Constants.CHT_HEADER_WO_NUM + Constants.COLON + woNum;
            if (model.Trim() != "") this.lblModel.Text = Constants.CHT_HEADER_MODEL + Constants.COLON + model;
            if (softwareVer.Trim() != "") this.lblSoftwareVer.Text = Constants.CHT_HEADER_SOFTWARE_VER + Constants.COLON + softwareVer;
            if (remarks.Trim() != "") this.lblRemarks.Text = Constants.CHT_HEADER_REMARKS + Constants.COLON + remarks;

            // Get and set column 2 data (component SN).
            for (int i = 0; i < compSnColNums.Count; i++)
            {
                string lblHeader = GetHeaderStrFromColNum(compSnColNums[i]);
                string lblValue = selectedRow[compSnColNums[i]];
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

            // Get and set column 3 data (Driver SN).
            for (int i = 0; i < driverSnColNums.Count; i++)
            {
                string lblHeader = GetHeaderStrFromColNum(driverSnColNums[i]);
                string lblValue = selectedRow[driverSnColNums[i]];
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
            string unitPassFail = selectedRow[Constants.UNIT_PASS_FAIL_COL_NUM];
            System.Windows.Forms.TreeNode nodeRoot = new System.Windows.Forms.TreeNode(
               Constants.CHT_HEADER_PASS_FAIL + Constants.COLON + unitPassFail
            );
            this.testTreeView.Nodes.Add(nodeRoot);

            // Set test results from selected test to tree.
            for (int i = 0; i < passFailColNums.Count; i++)
            {
                string lblHeader = GetHeaderStrFromColNum(passFailColNums[i]);
                string lblValue = selectedRow[passFailColNums[i]];
                if (lblValue.Trim() == "") continue;
                string label = lblHeader + Constants.COLON + lblValue;
                nodeRoot.Nodes.Add(new System.Windows.Forms.TreeNode(Constants.TREE_SPACING + label));
            }

        }

    }
}
