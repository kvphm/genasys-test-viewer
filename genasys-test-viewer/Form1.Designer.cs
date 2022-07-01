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
            this.lblResultNum = new System.Windows.Forms.Label();
            this.pnlSelection = new System.Windows.Forms.Panel();
            this.lblSelectedTitle = new System.Windows.Forms.Label();
            this.pnlResults.SuspendLayout();
            this.pnlSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSerialNumberHeader
            // 
            this.lblSerialNumberHeader.AutoSize = true;
            this.lblSerialNumberHeader.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold);
            this.lblSerialNumberHeader.Location = new System.Drawing.Point(238, 13);
            this.lblSerialNumberHeader.Name = "lblSerialNumberHeader";
            this.lblSerialNumberHeader.Size = new System.Drawing.Size(107, 19);
            this.lblSerialNumberHeader.TabIndex = 0;
            this.lblSerialNumberHeader.Text = "Enter Unit SN:";
            // 
            // txtSerialNumberValue
            // 
            this.txtSerialNumberValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSerialNumberValue.Location = new System.Drawing.Point(351, 12);
            this.txtSerialNumberValue.Name = "txtSerialNumberValue";
            this.txtSerialNumberValue.Size = new System.Drawing.Size(100, 23);
            this.txtSerialNumberValue.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSearch.Location = new System.Drawing.Point(457, 11);
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
            this.pnlResults.Controls.Add(this.lblResultNum);
            this.pnlResults.Location = new System.Drawing.Point(12, 48);
            this.pnlResults.Name = "pnlResults";
            this.pnlResults.Size = new System.Drawing.Size(171, 390);
            this.pnlResults.TabIndex = 0;
            this.pnlResults.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlResults_Paint);
            // 
            // lblResultNum
            // 
            this.lblResultNum.AutoSize = true;
            this.lblResultNum.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold);
            this.lblResultNum.Location = new System.Drawing.Point(3, 0);
            this.lblResultNum.Name = "lblResultNum";
            this.lblResultNum.Size = new System.Drawing.Size(0, 19);
            this.lblResultNum.TabIndex = 0;
            // 
            // pnlSelection
            // 
            this.pnlSelection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSelection.Controls.Add(this.lblSelectedTitle);
            this.pnlSelection.Location = new System.Drawing.Point(189, 48);
            this.pnlSelection.Name = "pnlSelection";
            this.pnlSelection.Size = new System.Drawing.Size(599, 390);
            this.pnlSelection.TabIndex = 3;
            // 
            // lblSelectedTitle
            // 
            this.lblSelectedTitle.AutoSize = true;
            this.lblSelectedTitle.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold);
            this.lblSelectedTitle.Location = new System.Drawing.Point(3, 0);
            this.lblSelectedTitle.Name = "lblSelectedTitle";
            this.lblSelectedTitle.Size = new System.Drawing.Size(48, 19);
            this.lblSelectedTitle.TabIndex = 0;
            this.lblSelectedTitle.Text = "label1";
            this.lblSelectedTitle.Click += new System.EventHandler(this.label1_Click);
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
            this.Name = "formGenasysTestViewer";
            this.Text = "GENASYS Test Viewer";
            this.pnlResults.ResumeLayout(false);
            this.pnlResults.PerformLayout();
            this.pnlSelection.ResumeLayout(false);
            this.pnlSelection.PerformLayout();
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
        private System.Windows.Forms.Label lblSelectedTitle;
    }
}

