namespace genasys_test_viewer
{
    partial class formGenasysTestViewer
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
            this.lblSerialNumberHeader = new System.Windows.Forms.Label();
            this.txtSerialNumberValue = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlResults = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblResultNum = new System.Windows.Forms.Label();
            this.pnlSelection = new System.Windows.Forms.Panel();
            this.pnlResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSerialNumberHeader
            // 
            this.lblSerialNumberHeader.AutoSize = true;
            this.lblSerialNumberHeader.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold);
            this.lblSerialNumberHeader.Location = new System.Drawing.Point(16, 13);
            this.lblSerialNumberHeader.Name = "lblSerialNumberHeader";
            this.lblSerialNumberHeader.Size = new System.Drawing.Size(107, 19);
            this.lblSerialNumberHeader.TabIndex = 0;
            this.lblSerialNumberHeader.Text = "Enter Unit SN:";
            // 
            // txtSerialNumberValue
            // 
            this.txtSerialNumberValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSerialNumberValue.Location = new System.Drawing.Point(129, 12);
            this.txtSerialNumberValue.Name = "txtSerialNumberValue";
            this.txtSerialNumberValue.Size = new System.Drawing.Size(100, 23);
            this.txtSerialNumberValue.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSearch.Location = new System.Drawing.Point(235, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 25);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlResults
            // 
            this.pnlResults.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlResults.AutoScroll = true;
            this.pnlResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlResults.Controls.Add(this.linkLabel2);
            this.pnlResults.Controls.Add(this.linkLabel1);
            this.pnlResults.Controls.Add(this.lblResultNum);
            this.pnlResults.Location = new System.Drawing.Point(12, 48);
            this.pnlResults.Name = "pnlResults";
            this.pnlResults.Size = new System.Drawing.Size(307, 390);
            this.pnlResults.TabIndex = 0;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.linkLabel2.Location = new System.Drawing.Point(3, 36);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(144, 17);
            this.linkLabel2.TabIndex = 5;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "11/11/2022 11:11 PM";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.linkLabel1.Location = new System.Drawing.Point(3, 19);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(144, 17);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "11/11/2022 11:11 PM";
            // 
            // lblResultNum
            // 
            this.lblResultNum.AutoSize = true;
            this.lblResultNum.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold);
            this.lblResultNum.Location = new System.Drawing.Point(2, 0);
            this.lblResultNum.Name = "lblResultNum";
            this.lblResultNum.Size = new System.Drawing.Size(0, 19);
            this.lblResultNum.TabIndex = 0;
            // 
            // pnlSelection
            // 
            this.pnlSelection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSelection.Location = new System.Drawing.Point(325, 11);
            this.pnlSelection.Name = "pnlSelection";
            this.pnlSelection.Size = new System.Drawing.Size(463, 427);
            this.pnlSelection.TabIndex = 3;
            // 
            // formGenasysTestViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlSelection);
            this.Controls.Add(this.pnlResults);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSerialNumberValue);
            this.Controls.Add(this.lblSerialNumberHeader);
            this.MaximizeBox = false;
            this.Name = "formGenasysTestViewer";
            this.Text = "GENASYS Test Viewer";
            this.pnlResults.ResumeLayout(false);
            this.pnlResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSerialNumberHeader;
        private System.Windows.Forms.TextBox txtSerialNumberValue;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnlResults;
        private System.Windows.Forms.Label lblResultNum;
        private System.Windows.Forms.Panel pnlSelection;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

