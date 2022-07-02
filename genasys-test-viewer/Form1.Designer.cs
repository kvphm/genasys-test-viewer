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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formGenasysTestViewer));
            this.lblUnitSnHeader = new System.Windows.Forms.Label();
            this.pnlResults = new System.Windows.Forms.Panel();
            this.lblResultNum = new System.Windows.Forms.Label();
            this.pnlSelection = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtUnitSnValue = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUnitSnHeader
            // 
            this.lblUnitSnHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnitSnHeader.AutoSize = true;
            this.lblUnitSnHeader.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold);
            this.lblUnitSnHeader.Location = new System.Drawing.Point(17, 97);
            this.lblUnitSnHeader.Name = "lblUnitSnHeader";
            this.lblUnitSnHeader.Size = new System.Drawing.Size(107, 19);
            this.lblUnitSnHeader.TabIndex = 0;
            this.lblUnitSnHeader.Text = "Enter Unit SN:";
            // 
            // pnlResults
            // 
            this.pnlResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlResults.AutoScroll = true;
            this.pnlResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlResults.Controls.Add(this.lblResultNum);
            this.pnlResults.Location = new System.Drawing.Point(12, 124);
            this.pnlResults.Name = "pnlResults";
            this.pnlResults.Size = new System.Drawing.Size(307, 225);
            this.pnlResults.TabIndex = 0;
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
            this.pnlSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSelection.AutoScroll = true;
            this.pnlSelection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSelection.Location = new System.Drawing.Point(325, 11);
            this.pnlSelection.Name = "pnlSelection";
            this.pnlSelection.Size = new System.Drawing.Size(447, 338);
            this.pnlSelection.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSearch.Location = new System.Drawing.Point(236, 94);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 25);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtUnitSnValue
            // 
            this.txtUnitSnValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtUnitSnValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtUnitSnValue.Location = new System.Drawing.Point(130, 95);
            this.txtUnitSnValue.Name = "txtUnitSnValue";
            this.txtUnitSnValue.Size = new System.Drawing.Size(100, 23);
            this.txtUnitSnValue.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // formGenasysTestViewer
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlSelection);
            this.Controls.Add(this.pnlResults);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtUnitSnValue);
            this.Controls.Add(this.lblUnitSnHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formGenasysTestViewer";
            this.Text = "Genasys Test Viewer";
            this.pnlResults.ResumeLayout(false);
            this.pnlResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TxtUnitSnValue_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lblUnitSnHeader;
        private System.Windows.Forms.Panel pnlResults;
        private System.Windows.Forms.Label lblResultNum;
        private System.Windows.Forms.Panel pnlSelection;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtUnitSnValue;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

