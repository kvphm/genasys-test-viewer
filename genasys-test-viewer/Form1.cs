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
            string serialNum = this.txtSerialNumberValue.Text;
            if (serialNum.Trim() == "")
            {
                Reinitialize();
                return;
            }
            List<List<string>> alltestsFromSn = GetAllTestsFromSn(serialNum);
            this.lblResultNum.Text = alltestsFromSn.Count + Constants.LBL_TESTS_FOUND;
            
        }

        private List<List<string>> GetAllTestsFromSn(string serialNum)
        {
            List<List<string>> alltestsFromSn = new List<List<string>>();
            using (var reader = new StreamReader(@Constants.PATH))
            {
                int unitSnCol = GetColNum(Constants.CHT_HEADER_UNIT_SN);
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    String[] row = values[0].Split(',');
                    if (row[unitSnCol] == serialNum)
                    {
                        alltestsFromSn.Add(new List<string>(row));
                    }
                }
            }
            return alltestsFromSn;
        }

        private int GetColNum(string headerName)
        {
            return File.ReadLines(Constants.PATH).First().IndexOf(headerName);
        }

        private void Reinitialize()
        {
            // TODO
        }

        private void pnlResults_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
