﻿using System;
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
            this.allSnTests = GetAllTestsFromUnitSn(unitSn);

            // TODO
            // Clear panel 2 when new search

            if (String.IsNullOrEmpty(unitSn.Trim())) return;
            this.lblResultNum.Text = allSnTests.Count + Constants.LBL_TESTS_FOUND;
            this.dateColNum = GetColNumFromStr(Constants.CHT_HEADER_DATE);
            this.timeColNum = GetColNumFromStr(Constants.CHT_HEADER_TIME);
            this.passFailColNum = GetColNumFromStr(Constants.CHT_HEADER_PASS_FAIL);
            this.listBox1.Items.Clear();
            for (int i = 0; i < allSnTests.Count; i++)
            {
                string status = allSnTests[i][passFailColNum].Equals("")
                    ? Constants.LBL_NA
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
                this.listBox1.Items.Add(allSnTests[i][dateColNum] + " " + allSnTests[i][timeColNum] + " - " + status);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            int index = listBox1.FindString(listBox1.SelectedItem.ToString());
            Console.WriteLine(this.allSnTests[index][0]); // works!

            // LRAD 400X
            //
            // Operator Initials: SP
            // Time: 11/11/2022 5:14 PM
            // 
            // Serial Numbers
            // 858034270
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Brush brush = ((e.State & DrawItemState.Selected) == DrawItemState.Selected) 
                ? Brushes.Yellow 
                : new SolidBrush(e.BackColor);
            e.Graphics.FillRectangle(brush, e.Bounds);
            string text = ((ListBox)sender).Items[e.Index].ToString();
            brush = Brushes.Black;
            if (text.EndsWith("PASSED"))
            {
                brush = Brushes.Green;
            }
            else if (text.EndsWith("FAILED"))
            {
                brush = Brushes.Red;
            }
            else if (text.EndsWith("N/A"))
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
            List<List<string>> allTestsFromSn = new List<List<string>>();
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
                        allTestsFromSn.Add(new List<string>(row));
                    }
                }
            }
            allTestsFromSn.Reverse();
            return allTestsFromSn;
        }

    }
}
