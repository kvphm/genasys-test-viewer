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
            this.txtUnitSnValue = new System.Windows.Forms.TextBox();
            this.lblUnitSnHeader = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblResultNum = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnResize = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUnitSnValue
            // 
            this.txtUnitSnValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtUnitSnValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtUnitSnValue.Location = new System.Drawing.Point(165, 97);
            this.txtUnitSnValue.Name = "txtUnitSnValue";
            this.txtUnitSnValue.Size = new System.Drawing.Size(173, 32);
            this.txtUnitSnValue.TabIndex = 1;
            // 
            // lblUnitSnHeader
            // 
            this.lblUnitSnHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnitSnHeader.AutoSize = true;
            this.lblUnitSnHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblUnitSnHeader.Location = new System.Drawing.Point(5, 100);
            this.lblUnitSnHeader.Name = "lblUnitSnHeader";
            this.lblUnitSnHeader.Size = new System.Drawing.Size(162, 26);
            this.lblUnitSnHeader.TabIndex = 0;
            this.lblUnitSnHeader.Text = "Enter unit SN:";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSearch.Location = new System.Drawing.Point(344, 100);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 25);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblResultNum
            // 
            this.lblResultNum.AutoSize = true;
            this.lblResultNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblResultNum.Location = new System.Drawing.Point(5, 132);
            this.lblResultNum.Name = "lblResultNum";
            this.lblResultNum.Size = new System.Drawing.Size(165, 26);
            this.lblResultNum.TabIndex = 0;
            this.lblResultNum.Text = "0 test(s) found";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(413, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(23, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.lblResultNum);
            this.splitContainer1.Panel1.Controls.Add(this.txtUnitSnValue);
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.lblUnitSnHeader);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Size = new System.Drawing.Size(335, 337);
            this.splitContainer1.SplitterDistance = 93;
            this.splitContainer1.TabIndex = 5;
            // 
            // btnResize
            // 
            this.btnResize.BackColor = System.Drawing.Color.Transparent;
            this.btnResize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResize.Location = new System.Drawing.Point(2, 12);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(20, 28);
            this.btnResize.TabIndex = 5;
            this.btnResize.Text = "-";
            this.btnResize.UseVisualStyleBackColor = false;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // formGenasysTestViewer
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btnResize);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "formGenasysTestViewer";
            this.Text = "Genasys Test Viewer (v1.0.0)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void TxtUnitSnValue_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox txtUnitSnValue;
        private System.Windows.Forms.Label lblUnitSnHeader;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblResultNum;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnResize;
    }
}

