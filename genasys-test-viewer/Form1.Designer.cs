using System.Collections.Generic;
using System.Drawing;

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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.testTreeView = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDriverSn8 = new System.Windows.Forms.Label();
            this.lblDriverSn3 = new System.Windows.Forms.Label();
            this.lblDriverSn7 = new System.Windows.Forms.Label();
            this.lblDriverSn5 = new System.Windows.Forms.Label();
            this.lblDriverSn6 = new System.Windows.Forms.Label();
            this.lblDriverSn4 = new System.Windows.Forms.Label();
            this.lblDriverSn2 = new System.Windows.Forms.Label();
            this.lblDriverSn1 = new System.Windows.Forms.Label();
            this.lblCompSn10 = new System.Windows.Forms.Label();
            this.lblCompSn9 = new System.Windows.Forms.Label();
            this.lblCompSn8 = new System.Windows.Forms.Label();
            this.lblCompSn4 = new System.Windows.Forms.Label();
            this.lblCompSn6 = new System.Windows.Forms.Label();
            this.lblCompSn5 = new System.Windows.Forms.Label();
            this.lblCompSn7 = new System.Windows.Forms.Label();
            this.lblCompSn3 = new System.Windows.Forms.Label();
            this.lblCompSn2 = new System.Windows.Forms.Label();
            this.lblCompSn1 = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblWoNum = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblSoftwareVer = new System.Windows.Forms.Label();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnResize = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUnitSnValue
            // 
            this.txtUnitSnValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtUnitSnValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtUnitSnValue.Location = new System.Drawing.Point(172, 3);
            this.txtUnitSnValue.Name = "txtUnitSnValue";
            this.txtUnitSnValue.Size = new System.Drawing.Size(133, 23);
            this.txtUnitSnValue.TabIndex = 1;
            // 
            // lblUnitSnHeader
            // 
            this.lblUnitSnHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnitSnHeader.AutoSize = true;
            this.lblUnitSnHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblUnitSnHeader.Location = new System.Drawing.Point(3, 0);
            this.lblUnitSnHeader.Name = "lblUnitSnHeader";
            this.lblUnitSnHeader.Size = new System.Drawing.Size(163, 37);
            this.lblUnitSnHeader.TabIndex = 0;
            this.lblUnitSnHeader.Text = "Enter unit SN:";
            this.lblUnitSnHeader.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSearch.Location = new System.Drawing.Point(313, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(71, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblResultNum
            // 
            this.lblResultNum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResultNum.AutoSize = true;
            this.lblResultNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblResultNum.Location = new System.Drawing.Point(12, 137);
            this.lblResultNum.Name = "lblResultNum";
            this.lblResultNum.Size = new System.Drawing.Size(0, 26);
            this.lblResultNum.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-55, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(386, 88);
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
            this.splitContainer1.Panel1.Controls.Add(this.lblResultNum);
            this.splitContainer1.Panel1.Controls.Add(this.listBox1);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.testTreeView);
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Panel2.Controls.Add(this.lblTitle);
            this.splitContainer1.Size = new System.Drawing.Size(857, 751);
            this.splitContainer1.SplitterDistance = 277;
            this.splitContainer1.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(17, 166);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(244, 552);
            this.listBox1.TabIndex = 5;
            this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 169F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tableLayoutPanel1.Controls.Add(this.txtUnitSnValue, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSearch, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblUnitSnHeader, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-60, 97);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(454, 37);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // testTreeView
            // 
            this.testTreeView.AllowDrop = true;
            this.testTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.testTreeView.BackColor = System.Drawing.SystemColors.Menu;
            this.testTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.testTreeView.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.testTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.testTreeView.Location = new System.Drawing.Point(9, 344);
            this.testTreeView.Name = "testTreeView";
            this.testTreeView.Scrollable = false;
            this.testTreeView.Size = new System.Drawing.Size(561, 402);
            this.testTreeView.TabIndex = 26;
            this.testTreeView.DrawNode += new System.Windows.Forms.DrawTreeNodeEventHandler(this.testTreeView_DrawNode);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.lblDriverSn8, 2, 7);
            this.tableLayoutPanel2.Controls.Add(this.lblDriverSn3, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblDriverSn7, 2, 6);
            this.tableLayoutPanel2.Controls.Add(this.lblDriverSn5, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblDriverSn6, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblDriverSn4, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblDriverSn2, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblDriverSn1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblCompSn10, 1, 9);
            this.tableLayoutPanel2.Controls.Add(this.lblCompSn9, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.lblCompSn8, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.lblCompSn4, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblCompSn6, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblCompSn5, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblCompSn7, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.lblCompSn3, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblCompSn2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblCompSn1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblOperator, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblDate, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblTime, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblWoNum, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblModel, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblSoftwareVer, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblRemarks, 0, 6);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 58);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 10;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(567, 280);
            this.tableLayoutPanel2.TabIndex = 25;
            // 
            // lblDriverSn8
            // 
            this.lblDriverSn8.AutoSize = true;
            this.lblDriverSn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblDriverSn8.Location = new System.Drawing.Point(381, 196);
            this.lblDriverSn8.Name = "lblDriverSn8";
            this.lblDriverSn8.Size = new System.Drawing.Size(0, 26);
            this.lblDriverSn8.TabIndex = 24;
            // 
            // lblDriverSn3
            // 
            this.lblDriverSn3.AutoSize = true;
            this.lblDriverSn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblDriverSn3.Location = new System.Drawing.Point(381, 56);
            this.lblDriverSn3.Name = "lblDriverSn3";
            this.lblDriverSn3.Size = new System.Drawing.Size(0, 26);
            this.lblDriverSn3.TabIndex = 19;
            // 
            // lblDriverSn7
            // 
            this.lblDriverSn7.AutoSize = true;
            this.lblDriverSn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblDriverSn7.Location = new System.Drawing.Point(381, 168);
            this.lblDriverSn7.Name = "lblDriverSn7";
            this.lblDriverSn7.Size = new System.Drawing.Size(0, 26);
            this.lblDriverSn7.TabIndex = 23;
            // 
            // lblDriverSn5
            // 
            this.lblDriverSn5.AutoSize = true;
            this.lblDriverSn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblDriverSn5.Location = new System.Drawing.Point(381, 112);
            this.lblDriverSn5.Name = "lblDriverSn5";
            this.lblDriverSn5.Size = new System.Drawing.Size(0, 26);
            this.lblDriverSn5.TabIndex = 21;
            // 
            // lblDriverSn6
            // 
            this.lblDriverSn6.AutoSize = true;
            this.lblDriverSn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblDriverSn6.Location = new System.Drawing.Point(381, 140);
            this.lblDriverSn6.Name = "lblDriverSn6";
            this.lblDriverSn6.Size = new System.Drawing.Size(0, 26);
            this.lblDriverSn6.TabIndex = 22;
            // 
            // lblDriverSn4
            // 
            this.lblDriverSn4.AutoSize = true;
            this.lblDriverSn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblDriverSn4.Location = new System.Drawing.Point(381, 84);
            this.lblDriverSn4.Name = "lblDriverSn4";
            this.lblDriverSn4.Size = new System.Drawing.Size(0, 26);
            this.lblDriverSn4.TabIndex = 20;
            // 
            // lblDriverSn2
            // 
            this.lblDriverSn2.AutoSize = true;
            this.lblDriverSn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblDriverSn2.Location = new System.Drawing.Point(381, 28);
            this.lblDriverSn2.Name = "lblDriverSn2";
            this.lblDriverSn2.Size = new System.Drawing.Size(0, 26);
            this.lblDriverSn2.TabIndex = 18;
            // 
            // lblDriverSn1
            // 
            this.lblDriverSn1.AutoSize = true;
            this.lblDriverSn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblDriverSn1.Location = new System.Drawing.Point(381, 0);
            this.lblDriverSn1.Name = "lblDriverSn1";
            this.lblDriverSn1.Size = new System.Drawing.Size(0, 26);
            this.lblDriverSn1.TabIndex = 17;
            // 
            // lblCompSn10
            // 
            this.lblCompSn10.AutoSize = true;
            this.lblCompSn10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblCompSn10.Location = new System.Drawing.Point(192, 252);
            this.lblCompSn10.Name = "lblCompSn10";
            this.lblCompSn10.Size = new System.Drawing.Size(0, 26);
            this.lblCompSn10.TabIndex = 16;
            // 
            // lblCompSn9
            // 
            this.lblCompSn9.AutoSize = true;
            this.lblCompSn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblCompSn9.Location = new System.Drawing.Point(192, 224);
            this.lblCompSn9.Name = "lblCompSn9";
            this.lblCompSn9.Size = new System.Drawing.Size(0, 26);
            this.lblCompSn9.TabIndex = 15;
            // 
            // lblCompSn8
            // 
            this.lblCompSn8.AutoSize = true;
            this.lblCompSn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblCompSn8.Location = new System.Drawing.Point(192, 196);
            this.lblCompSn8.Name = "lblCompSn8";
            this.lblCompSn8.Size = new System.Drawing.Size(0, 26);
            this.lblCompSn8.TabIndex = 14;
            // 
            // lblCompSn4
            // 
            this.lblCompSn4.AutoSize = true;
            this.lblCompSn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblCompSn4.Location = new System.Drawing.Point(192, 84);
            this.lblCompSn4.Name = "lblCompSn4";
            this.lblCompSn4.Size = new System.Drawing.Size(0, 26);
            this.lblCompSn4.TabIndex = 10;
            // 
            // lblCompSn6
            // 
            this.lblCompSn6.AutoSize = true;
            this.lblCompSn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblCompSn6.Location = new System.Drawing.Point(192, 140);
            this.lblCompSn6.Name = "lblCompSn6";
            this.lblCompSn6.Size = new System.Drawing.Size(0, 26);
            this.lblCompSn6.TabIndex = 12;
            // 
            // lblCompSn5
            // 
            this.lblCompSn5.AutoSize = true;
            this.lblCompSn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblCompSn5.Location = new System.Drawing.Point(192, 112);
            this.lblCompSn5.Name = "lblCompSn5";
            this.lblCompSn5.Size = new System.Drawing.Size(0, 26);
            this.lblCompSn5.TabIndex = 11;
            // 
            // lblCompSn7
            // 
            this.lblCompSn7.AutoSize = true;
            this.lblCompSn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblCompSn7.Location = new System.Drawing.Point(192, 168);
            this.lblCompSn7.Name = "lblCompSn7";
            this.lblCompSn7.Size = new System.Drawing.Size(0, 26);
            this.lblCompSn7.TabIndex = 13;
            // 
            // lblCompSn3
            // 
            this.lblCompSn3.AutoSize = true;
            this.lblCompSn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblCompSn3.Location = new System.Drawing.Point(192, 56);
            this.lblCompSn3.Name = "lblCompSn3";
            this.lblCompSn3.Size = new System.Drawing.Size(0, 26);
            this.lblCompSn3.TabIndex = 9;
            // 
            // lblCompSn2
            // 
            this.lblCompSn2.AutoSize = true;
            this.lblCompSn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblCompSn2.Location = new System.Drawing.Point(192, 28);
            this.lblCompSn2.Name = "lblCompSn2";
            this.lblCompSn2.Size = new System.Drawing.Size(0, 26);
            this.lblCompSn2.TabIndex = 8;
            // 
            // lblCompSn1
            // 
            this.lblCompSn1.AutoSize = true;
            this.lblCompSn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblCompSn1.Location = new System.Drawing.Point(192, 0);
            this.lblCompSn1.Name = "lblCompSn1";
            this.lblCompSn1.Size = new System.Drawing.Size(0, 26);
            this.lblCompSn1.TabIndex = 7;
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblOperator.Location = new System.Drawing.Point(3, 0);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(0, 26);
            this.lblOperator.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblDate.Location = new System.Drawing.Point(3, 28);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 26);
            this.lblDate.TabIndex = 1;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTime.Location = new System.Drawing.Point(3, 56);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 26);
            this.lblTime.TabIndex = 2;
            // 
            // lblWoNum
            // 
            this.lblWoNum.AutoSize = true;
            this.lblWoNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblWoNum.Location = new System.Drawing.Point(3, 84);
            this.lblWoNum.Name = "lblWoNum";
            this.lblWoNum.Size = new System.Drawing.Size(0, 26);
            this.lblWoNum.TabIndex = 3;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblModel.Location = new System.Drawing.Point(3, 112);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(0, 26);
            this.lblModel.TabIndex = 4;
            // 
            // lblSoftwareVer
            // 
            this.lblSoftwareVer.AutoSize = true;
            this.lblSoftwareVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblSoftwareVer.Location = new System.Drawing.Point(3, 140);
            this.lblSoftwareVer.Name = "lblSoftwareVer";
            this.lblSoftwareVer.Size = new System.Drawing.Size(0, 26);
            this.lblSoftwareVer.TabIndex = 5;
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblRemarks.Location = new System.Drawing.Point(3, 168);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(0, 26);
            this.lblRemarks.TabIndex = 6;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(2, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 37);
            this.lblTitle.TabIndex = 0;
            // 
            // btnResize
            // 
            this.btnResize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResize.Location = new System.Drawing.Point(2, 12);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(20, 28);
            this.btnResize.TabIndex = 5;
            this.btnResize.Text = "🗕";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // formGenasysTestViewer
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 775);
            this.Controls.Add(this.btnResize);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "formGenasysTestViewer";
            this.Text = "Genasys Test Viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private List<List<string>> allSnTests;
        private string unitSn;
        private int opColNum;
        private int dateColNum;
        private int timeColNum;
        private int woNumColNum;
        private int unitPassFailColNum;
        private int modelColNum;
        private int softwareColNum;
        private int remarksColNum;

        private List<int> compSnColNums;
        private List<int> driverSnColNums;
        private List<int> passFailColNums;

        private System.Windows.Forms.TextBox txtUnitSnValue;
        private System.Windows.Forms.Label lblUnitSnHeader;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblResultNum;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblWoNum;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.Label lblSoftwareVer;
        private System.Windows.Forms.Label lblCompSn2;
        private System.Windows.Forms.Label lblCompSn1;
        private System.Windows.Forms.Label lblCompSn9;
        private System.Windows.Forms.Label lblCompSn8;
        private System.Windows.Forms.Label lblCompSn7;
        private System.Windows.Forms.Label lblCompSn6;
        private System.Windows.Forms.Label lblCompSn5;
        private System.Windows.Forms.Label lblCompSn4;
        private System.Windows.Forms.Label lblCompSn3;
        private System.Windows.Forms.Label lblCompSn10;
        private System.Windows.Forms.Label lblDriverSn2;
        private System.Windows.Forms.Label lblDriverSn1;
        private System.Windows.Forms.Label lblDriverSn8;
        private System.Windows.Forms.Label lblDriverSn7;
        private System.Windows.Forms.Label lblDriverSn6;
        private System.Windows.Forms.Label lblDriverSn5;
        private System.Windows.Forms.Label lblDriverSn4;
        private System.Windows.Forms.Label lblDriverSn3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TreeView testTreeView;
    }
}

