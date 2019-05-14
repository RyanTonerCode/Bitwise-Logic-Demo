namespace Bitwise_Logic_Demo
{
    partial class frmMain
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
            this.cbxGates = new System.Windows.Forms.ComboBox();
            this.gbxCalc = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tblRegView = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbld1 = new System.Windows.Forms.Label();
            this.lblh1 = new System.Windows.Forms.Label();
            this.lblb1 = new System.Windows.Forms.Label();
            this.lbld2 = new System.Windows.Forms.Label();
            this.lblb2 = new System.Windows.Forms.Label();
            this.lblb3 = new System.Windows.Forms.Label();
            this.lblh3 = new System.Windows.Forms.Label();
            this.lbld3 = new System.Windows.Forms.Label();
            this.lblh2 = new System.Windows.Forms.Label();
            this.cbxBits = new System.Windows.Forms.ComboBox();
            this.cbxSpace = new System.Windows.Forms.ComboBox();
            this.lblGate = new System.Windows.Forms.Label();
            this.lblBits = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.cbxFormat2 = new System.Windows.Forms.ComboBox();
            this.tbxOp2 = new System.Windows.Forms.TextBox();
            this.tbxOp1 = new System.Windows.Forms.TextBox();
            this.lblOp2 = new System.Windows.Forms.Label();
            this.cbxFormat1 = new System.Windows.Forms.ComboBox();
            this.lblOp1 = new System.Windows.Forms.Label();
            this.lblFormat = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbxConHex = new System.Windows.Forms.TextBox();
            this.tbxConDec = new System.Windows.Forms.TextBox();
            this.tbxConBin = new System.Windows.Forms.TextBox();
            this.gbxCalc.SuspendLayout();
            this.tblRegView.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxGates
            // 
            this.cbxGates.FormattingEnabled = true;
            this.cbxGates.Location = new System.Drawing.Point(125, 25);
            this.cbxGates.Name = "cbxGates";
            this.cbxGates.Size = new System.Drawing.Size(168, 26);
            this.cbxGates.TabIndex = 0;
            this.cbxGates.SelectedIndexChanged += new System.EventHandler(this.CbxGates_SelectedIndexChanged);
            // 
            // gbxCalc
            // 
            this.gbxCalc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbxCalc.Controls.Add(this.btnSubmit);
            this.gbxCalc.Controls.Add(this.tblRegView);
            this.gbxCalc.Location = new System.Drawing.Point(12, 194);
            this.gbxCalc.Margin = new System.Windows.Forms.Padding(5);
            this.gbxCalc.Name = "gbxCalc";
            this.gbxCalc.Size = new System.Drawing.Size(1410, 263);
            this.gbxCalc.TabIndex = 1;
            this.gbxCalc.TabStop = false;
            this.gbxCalc.Text = "Calculator";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(1272, 223);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(115, 32);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Calculate";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // tblRegView
            // 
            this.tblRegView.BackColor = System.Drawing.Color.Silver;
            this.tblRegView.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblRegView.ColumnCount = 4;
            this.tblRegView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblRegView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 216F));
            this.tblRegView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.tblRegView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 899F));
            this.tblRegView.Controls.Add(this.label6, 0, 3);
            this.tblRegView.Controls.Add(this.label3, 0, 1);
            this.tblRegView.Controls.Add(this.label4, 0, 2);
            this.tblRegView.Controls.Add(this.label1, 1, 0);
            this.tblRegView.Controls.Add(this.label5, 2, 0);
            this.tblRegView.Controls.Add(this.label7, 3, 0);
            this.tblRegView.Controls.Add(this.label8, 0, 0);
            this.tblRegView.Controls.Add(this.lbld1, 1, 1);
            this.tblRegView.Controls.Add(this.lblh1, 2, 1);
            this.tblRegView.Controls.Add(this.lblb1, 3, 1);
            this.tblRegView.Controls.Add(this.lbld2, 1, 2);
            this.tblRegView.Controls.Add(this.lblb2, 3, 2);
            this.tblRegView.Controls.Add(this.lblb3, 3, 3);
            this.tblRegView.Controls.Add(this.lblh3, 2, 3);
            this.tblRegView.Controls.Add(this.lbld3, 1, 3);
            this.tblRegView.Controls.Add(this.lblh2, 2, 2);
            this.tblRegView.Location = new System.Drawing.Point(0, 25);
            this.tblRegView.Name = "tblRegView";
            this.tblRegView.RowCount = 4;
            this.tblRegView.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblRegView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblRegView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblRegView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblRegView.Size = new System.Drawing.Size(1410, 192);
            this.tblRegView.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Result";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Op. 1";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Op. 2";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Decimal";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(335, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hex";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(513, 12);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Binary";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 5);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 32);
            this.label8.TabIndex = 7;
            this.label8.Text = "Click to copy";
            // 
            // lbld1
            // 
            this.lbld1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbld1.AutoSize = true;
            this.lbld1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbld1.Location = new System.Drawing.Point(118, 57);
            this.lbld1.Name = "lbld1";
            this.lbld1.Size = new System.Drawing.Size(198, 18);
            this.lbld1.TabIndex = 8;
            this.lbld1.Text = "9223372036854775807";
            this.lbld1.Click += new System.EventHandler(this.lbl_copy);
            // 
            // lblh1
            // 
            this.lblh1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblh1.AutoSize = true;
            this.lblh1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblh1.Location = new System.Drawing.Point(335, 57);
            this.lblh1.Name = "lblh1";
            this.lblh1.Size = new System.Drawing.Size(168, 18);
            this.lblh1.TabIndex = 9;
            this.lblh1.Text = "7FFFFFFFFFFFFFFF";
            this.lblh1.Click += new System.EventHandler(this.lbl_copy);
            // 
            // lblb1
            // 
            this.lblb1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblb1.AutoSize = true;
            this.lblb1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblb1.Location = new System.Drawing.Point(513, 56);
            this.lblb1.Name = "lblb1";
            this.lblb1.Size = new System.Drawing.Size(879, 21);
            this.lblb1.TabIndex = 10;
            this.lblb1.Text = "0111 1111 1111 1111 1111 1111 1111 1111 1111 1111 1111 1111 1111 1111 1111 1111";
            this.lblb1.Click += new System.EventHandler(this.lbl_copy);
            // 
            // lbld2
            // 
            this.lbld2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbld2.AutoSize = true;
            this.lbld2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbld2.Location = new System.Drawing.Point(118, 107);
            this.lbld2.Name = "lbld2";
            this.lbld2.Size = new System.Drawing.Size(198, 18);
            this.lbld2.TabIndex = 11;
            this.lbld2.Text = "9223372036854775807";
            this.lbld2.Click += new System.EventHandler(this.lbl_copy);
            // 
            // lblb2
            // 
            this.lblb2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblb2.AutoSize = true;
            this.lblb2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblb2.Location = new System.Drawing.Point(513, 106);
            this.lblb2.Name = "lblb2";
            this.lblb2.Size = new System.Drawing.Size(879, 21);
            this.lblb2.TabIndex = 13;
            this.lblb2.Text = "0111 1111 1111 1111 1111 1111 1111 1111 1111 1111 1111 1111 1111 1111 1111 1111";
            this.lblb2.Click += new System.EventHandler(this.lbl_copy);
            // 
            // lblb3
            // 
            this.lblb3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblb3.AutoSize = true;
            this.lblb3.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblb3.Location = new System.Drawing.Point(513, 156);
            this.lblb3.Name = "lblb3";
            this.lblb3.Size = new System.Drawing.Size(879, 21);
            this.lblb3.TabIndex = 14;
            this.lblb3.Text = "0111 1111 1111 1111 1111 1111 1111 1111 1111 1111 1111 1111 1111 1111 1111 1111";
            this.lblb3.Click += new System.EventHandler(this.lbl_copy);
            // 
            // lblh3
            // 
            this.lblh3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblh3.AutoSize = true;
            this.lblh3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblh3.Location = new System.Drawing.Point(335, 157);
            this.lblh3.Name = "lblh3";
            this.lblh3.Size = new System.Drawing.Size(168, 18);
            this.lblh3.TabIndex = 15;
            this.lblh3.Text = "7FFFFFFFFFFFFFFF";
            this.lblh3.Click += new System.EventHandler(this.lbl_copy);
            // 
            // lbld3
            // 
            this.lbld3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbld3.AutoSize = true;
            this.lbld3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbld3.Location = new System.Drawing.Point(118, 157);
            this.lbld3.Name = "lbld3";
            this.lbld3.Size = new System.Drawing.Size(198, 18);
            this.lbld3.TabIndex = 16;
            this.lbld3.Text = "9223372036854775807";
            this.lbld3.Click += new System.EventHandler(this.lbl_copy);
            // 
            // lblh2
            // 
            this.lblh2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblh2.AutoSize = true;
            this.lblh2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblh2.Location = new System.Drawing.Point(335, 107);
            this.lblh2.Name = "lblh2";
            this.lblh2.Size = new System.Drawing.Size(168, 18);
            this.lblh2.TabIndex = 12;
            this.lblh2.Text = "7FFFFFFFFFFFFFFF";
            this.lblh2.Click += new System.EventHandler(this.lbl_copy);
            // 
            // cbxBits
            // 
            this.cbxBits.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxBits.FormattingEnabled = true;
            this.cbxBits.Items.AddRange(new object[] {
            "64",
            "64u",
            "32",
            "32u",
            "16",
            "16u",
            "8u",
            "4u"});
            this.cbxBits.Location = new System.Drawing.Point(125, 74);
            this.cbxBits.Name = "cbxBits";
            this.cbxBits.Size = new System.Drawing.Size(168, 26);
            this.cbxBits.TabIndex = 2;
            this.cbxBits.SelectedIndexChanged += new System.EventHandler(this.CbxBits_SelectedIndexChanged);
            // 
            // cbxSpace
            // 
            this.cbxSpace.FormattingEnabled = true;
            this.cbxSpace.Items.AddRange(new object[] {
            "64",
            "32",
            "16",
            "8",
            "4"});
            this.cbxSpace.Location = new System.Drawing.Point(125, 117);
            this.cbxSpace.Name = "cbxSpace";
            this.cbxSpace.Size = new System.Drawing.Size(168, 26);
            this.cbxSpace.TabIndex = 5;
            this.cbxSpace.SelectedIndexChanged += new System.EventHandler(this.CbxSpace_SelectedIndexChanged);
            // 
            // lblGate
            // 
            this.lblGate.AutoSize = true;
            this.lblGate.Location = new System.Drawing.Point(6, 25);
            this.lblGate.Name = "lblGate";
            this.lblGate.Size = new System.Drawing.Size(48, 18);
            this.lblGate.TabIndex = 6;
            this.lblGate.Text = "Gate";
            // 
            // lblBits
            // 
            this.lblBits.AutoSize = true;
            this.lblBits.Location = new System.Drawing.Point(6, 74);
            this.lblBits.Name = "lblBits";
            this.lblBits.Size = new System.Drawing.Size(48, 18);
            this.lblBits.TabIndex = 7;
            this.lblBits.Text = "Bits";
            this.lblBits.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bit Space";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.cbxSpace);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxGates);
            this.groupBox1.Controls.Add(this.lblBits);
            this.groupBox1.Controls.Add(this.lblGate);
            this.groupBox1.Controls.Add(this.cbxBits);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 158);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Overhead";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.lblNum);
            this.groupBox2.Controls.Add(this.cbxFormat2);
            this.groupBox2.Controls.Add(this.tbxOp2);
            this.groupBox2.Controls.Add(this.tbxOp1);
            this.groupBox2.Controls.Add(this.lblOp2);
            this.groupBox2.Controls.Add(this.cbxFormat1);
            this.groupBox2.Controls.Add(this.lblOp1);
            this.groupBox2.Controls.Add(this.lblFormat);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(347, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1075, 158);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Args";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(568, 19);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(68, 18);
            this.lblNum.TabIndex = 12;
            this.lblNum.Text = "Number";
            // 
            // cbxFormat2
            // 
            this.cbxFormat2.FormattingEnabled = true;
            this.cbxFormat2.Location = new System.Drawing.Point(110, 102);
            this.cbxFormat2.Name = "cbxFormat2";
            this.cbxFormat2.Size = new System.Drawing.Size(129, 26);
            this.cbxFormat2.TabIndex = 11;
            this.cbxFormat2.SelectedIndexChanged += new System.EventHandler(this.CbxFormat2_SelectedIndexChanged);
            // 
            // tbxOp2
            // 
            this.tbxOp2.Location = new System.Drawing.Point(260, 102);
            this.tbxOp2.Name = "tbxOp2";
            this.tbxOp2.Size = new System.Drawing.Size(792, 26);
            this.tbxOp2.TabIndex = 10;
            // 
            // tbxOp1
            // 
            this.tbxOp1.Location = new System.Drawing.Point(260, 45);
            this.tbxOp1.Name = "tbxOp1";
            this.tbxOp1.Size = new System.Drawing.Size(792, 26);
            this.tbxOp1.TabIndex = 9;
            // 
            // lblOp2
            // 
            this.lblOp2.AutoSize = true;
            this.lblOp2.Location = new System.Drawing.Point(6, 110);
            this.lblOp2.Name = "lblOp2";
            this.lblOp2.Size = new System.Drawing.Size(98, 18);
            this.lblOp2.TabIndex = 8;
            this.lblOp2.Text = "Operand 2";
            this.lblOp2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblOp2.Click += new System.EventHandler(this.swap_click);
            // 
            // cbxFormat1
            // 
            this.cbxFormat1.FormattingEnabled = true;
            this.cbxFormat1.Location = new System.Drawing.Point(110, 45);
            this.cbxFormat1.Name = "cbxFormat1";
            this.cbxFormat1.Size = new System.Drawing.Size(129, 26);
            this.cbxFormat1.TabIndex = 0;
            this.cbxFormat1.SelectedIndexChanged += new System.EventHandler(this.CbxFormat_SelectedIndexChanged);
            // 
            // lblOp1
            // 
            this.lblOp1.AutoSize = true;
            this.lblOp1.Location = new System.Drawing.Point(6, 48);
            this.lblOp1.Name = "lblOp1";
            this.lblOp1.Size = new System.Drawing.Size(98, 18);
            this.lblOp1.TabIndex = 7;
            this.lblOp1.Text = "Operand 1";
            this.lblOp1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblOp1.Click += new System.EventHandler(this.swap_click);
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Location = new System.Drawing.Point(143, 19);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(68, 18);
            this.lblFormat.TabIndex = 6;
            this.lblFormat.Text = "Format";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 187F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 756F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label12, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label13, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label14, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbxConHex, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbxConDec, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbxConBin, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(21, 489);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.51402F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.48598F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1280, 108);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 32);
            this.label9.TabIndex = 13;
            this.label9.Text = "Double click to clear";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 18);
            this.label11.TabIndex = 2;
            this.label11.Text = "Convert";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(144, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 18);
            this.label12.TabIndex = 3;
            this.label12.Text = "Decimal";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(332, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 18);
            this.label13.TabIndex = 4;
            this.label13.Text = "Hex";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(526, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 18);
            this.label14.TabIndex = 6;
            this.label14.Text = "Binary";
            // 
            // tbxConHex
            // 
            this.tbxConHex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxConHex.Location = new System.Drawing.Point(338, 60);
            this.tbxConHex.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbxConHex.Name = "tbxConHex";
            this.tbxConHex.Size = new System.Drawing.Size(175, 26);
            this.tbxConHex.TabIndex = 8;
            this.tbxConHex.TextChanged += new System.EventHandler(this.TbxConHex_TextChanged);
            this.tbxConHex.DoubleClick += new System.EventHandler(this.TbxConHex_DoubleClick);
            // 
            // tbxConDec
            // 
            this.tbxConDec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxConDec.Location = new System.Drawing.Point(152, 60);
            this.tbxConDec.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbxConDec.Name = "tbxConDec";
            this.tbxConDec.Size = new System.Drawing.Size(165, 26);
            this.tbxConDec.TabIndex = 10;
            this.tbxConDec.TextChanged += new System.EventHandler(this.TbxConDec_TextChanged);
            this.tbxConDec.DoubleClick += new System.EventHandler(this.TbxConHex_DoubleClick);
            // 
            // tbxConBin
            // 
            this.tbxConBin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxConBin.Location = new System.Drawing.Point(537, 60);
            this.tbxConBin.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbxConBin.Name = "tbxConBin";
            this.tbxConBin.Size = new System.Drawing.Size(727, 26);
            this.tbxConBin.TabIndex = 9;
            this.tbxConBin.TextChanged += new System.EventHandler(this.TbxConBin_TextChanged);
            this.tbxConBin.DoubleClick += new System.EventHandler(this.TbxConHex_DoubleClick);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 634);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbxCalc);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmMain";
            this.Text = "Bitwise Logic Demo";
            this.gbxCalc.ResumeLayout(false);
            this.tblRegView.ResumeLayout(false);
            this.tblRegView.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxGates;
        private System.Windows.Forms.GroupBox gbxCalc;
        private System.Windows.Forms.ComboBox cbxBits;
        private System.Windows.Forms.ComboBox cbxSpace;
        private System.Windows.Forms.Label lblGate;
        private System.Windows.Forms.Label lblBits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbxOp2;
        private System.Windows.Forms.TextBox tbxOp1;
        private System.Windows.Forms.Label lblOp2;
        private System.Windows.Forms.ComboBox cbxFormat1;
        private System.Windows.Forms.Label lblOp1;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.ComboBox cbxFormat2;
        private System.Windows.Forms.TableLayoutPanel tblRegView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbld1;
        private System.Windows.Forms.Label lblh1;
        private System.Windows.Forms.Label lblb1;
        private System.Windows.Forms.Label lbld2;
        private System.Windows.Forms.Label lblb2;
        private System.Windows.Forms.Label lblb3;
        private System.Windows.Forms.Label lblh3;
        private System.Windows.Forms.Label lbld3;
        private System.Windows.Forms.Label lblh2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbxConHex;
        private System.Windows.Forms.TextBox tbxConBin;
        private System.Windows.Forms.TextBox tbxConDec;
        private System.Windows.Forms.Label label9;
    }
}

