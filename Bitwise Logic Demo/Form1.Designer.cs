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
            this.lblResult = new System.Windows.Forms.Label();
            this.lblOut2 = new System.Windows.Forms.Label();
            this.lblRe = new System.Windows.Forms.Label();
            this.lblOp2R = new System.Windows.Forms.Label();
            this.lblOp1R = new System.Windows.Forms.Label();
            this.lblOut1 = new System.Windows.Forms.Label();
            this.cbxBits = new System.Windows.Forms.ComboBox();
            this.cbxSpace = new System.Windows.Forms.ComboBox();
            this.lblGate = new System.Windows.Forms.Label();
            this.lblBits = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxOp2 = new System.Windows.Forms.TextBox();
            this.tbxOp1 = new System.Windows.Forms.TextBox();
            this.lblOp2 = new System.Windows.Forms.Label();
            this.cbxFormat = new System.Windows.Forms.ComboBox();
            this.lblOp1 = new System.Windows.Forms.Label();
            this.lblFormat = new System.Windows.Forms.Label();
            this.gbxCalc.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxGates
            // 
            this.cbxGates.FormattingEnabled = true;
            this.cbxGates.Location = new System.Drawing.Point(264, 25);
            this.cbxGates.Name = "cbxGates";
            this.cbxGates.Size = new System.Drawing.Size(168, 26);
            this.cbxGates.TabIndex = 0;
            this.cbxGates.SelectedIndexChanged += new System.EventHandler(this.CbxGates_SelectedIndexChanged);
            // 
            // gbxCalc
            // 
            this.gbxCalc.Controls.Add(this.btnSubmit);
            this.gbxCalc.Controls.Add(this.lblResult);
            this.gbxCalc.Controls.Add(this.lblOut2);
            this.gbxCalc.Controls.Add(this.lblRe);
            this.gbxCalc.Controls.Add(this.lblOp2R);
            this.gbxCalc.Controls.Add(this.lblOp1R);
            this.gbxCalc.Controls.Add(this.lblOut1);
            this.gbxCalc.Location = new System.Drawing.Point(27, 214);
            this.gbxCalc.Name = "gbxCalc";
            this.gbxCalc.Size = new System.Drawing.Size(1376, 316);
            this.gbxCalc.TabIndex = 1;
            this.gbxCalc.TabStop = false;
            this.gbxCalc.Text = "Calculator";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(1229, 264);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(115, 32);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Calculate";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(168, 159);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(502, 27);
            this.lblResult.TabIndex = 12;
            this.lblResult.Text = "00000000 00000000 00000000 00000000";
            // 
            // lblOut2
            // 
            this.lblOut2.AutoSize = true;
            this.lblOut2.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOut2.Location = new System.Drawing.Point(168, 106);
            this.lblOut2.Name = "lblOut2";
            this.lblOut2.Size = new System.Drawing.Size(502, 27);
            this.lblOut2.TabIndex = 11;
            this.lblOut2.Text = "00000000 00000000 00000000 00000000";
            // 
            // lblRe
            // 
            this.lblRe.AutoSize = true;
            this.lblRe.Location = new System.Drawing.Point(63, 168);
            this.lblRe.Name = "lblRe";
            this.lblRe.Size = new System.Drawing.Size(68, 18);
            this.lblRe.TabIndex = 10;
            this.lblRe.Text = "Result";
            this.lblRe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblOp2R
            // 
            this.lblOp2R.AutoSize = true;
            this.lblOp2R.Location = new System.Drawing.Point(33, 112);
            this.lblOp2R.Name = "lblOp2R";
            this.lblOp2R.Size = new System.Drawing.Size(98, 18);
            this.lblOp2R.TabIndex = 9;
            this.lblOp2R.Text = "Operand 2";
            this.lblOp2R.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblOp1R
            // 
            this.lblOp1R.AutoSize = true;
            this.lblOp1R.Location = new System.Drawing.Point(33, 66);
            this.lblOp1R.Name = "lblOp1R";
            this.lblOp1R.Size = new System.Drawing.Size(98, 18);
            this.lblOp1R.TabIndex = 8;
            this.lblOp1R.Text = "Operand 1";
            this.lblOp1R.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblOut1
            // 
            this.lblOut1.AutoSize = true;
            this.lblOut1.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOut1.Location = new System.Drawing.Point(168, 60);
            this.lblOut1.Name = "lblOut1";
            this.lblOut1.Size = new System.Drawing.Size(502, 27);
            this.lblOut1.TabIndex = 0;
            this.lblOut1.Text = "00000000 00000000 00000000 00000000";
            // 
            // cbxBits
            // 
            this.cbxBits.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxBits.FormattingEnabled = true;
            this.cbxBits.Items.AddRange(new object[] {
            "64",
            "32",
            "16",
            "8",
            "4"});
            this.cbxBits.Location = new System.Drawing.Point(264, 71);
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
            this.cbxSpace.Location = new System.Drawing.Point(264, 120);
            this.cbxSpace.Name = "cbxSpace";
            this.cbxSpace.Size = new System.Drawing.Size(168, 26);
            this.cbxSpace.TabIndex = 5;
            this.cbxSpace.SelectedIndexChanged += new System.EventHandler(this.CbxSpace_SelectedIndexChanged);
            // 
            // lblGate
            // 
            this.lblGate.AutoSize = true;
            this.lblGate.Location = new System.Drawing.Point(17, 22);
            this.lblGate.Name = "lblGate";
            this.lblGate.Size = new System.Drawing.Size(48, 18);
            this.lblGate.TabIndex = 6;
            this.lblGate.Text = "Gate";
            // 
            // lblBits
            // 
            this.lblBits.AutoSize = true;
            this.lblBits.Location = new System.Drawing.Point(17, 74);
            this.lblBits.Name = "lblBits";
            this.lblBits.Size = new System.Drawing.Size(48, 18);
            this.lblBits.TabIndex = 7;
            this.lblBits.Text = "Bits";
            this.lblBits.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Space Every ... Bits";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxSpace);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxGates);
            this.groupBox1.Controls.Add(this.lblBits);
            this.groupBox1.Controls.Add(this.lblGate);
            this.groupBox1.Controls.Add(this.cbxBits);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 158);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Overhead";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxOp2);
            this.groupBox2.Controls.Add(this.tbxOp1);
            this.groupBox2.Controls.Add(this.lblOp2);
            this.groupBox2.Controls.Add(this.cbxFormat);
            this.groupBox2.Controls.Add(this.lblOp1);
            this.groupBox2.Controls.Add(this.lblFormat);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(515, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(888, 158);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Args";
            // 
            // tbxOp2
            // 
            this.tbxOp2.Location = new System.Drawing.Point(140, 115);
            this.tbxOp2.Name = "tbxOp2";
            this.tbxOp2.Size = new System.Drawing.Size(728, 26);
            this.tbxOp2.TabIndex = 10;
            this.tbxOp2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxOp2_KeyPress);
            // 
            // tbxOp1
            // 
            this.tbxOp1.Location = new System.Drawing.Point(140, 66);
            this.tbxOp1.Name = "tbxOp1";
            this.tbxOp1.Size = new System.Drawing.Size(728, 26);
            this.tbxOp1.TabIndex = 9;
            this.tbxOp1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxOp1_KeyPress);
            // 
            // lblOp2
            // 
            this.lblOp2.AutoSize = true;
            this.lblOp2.Location = new System.Drawing.Point(17, 115);
            this.lblOp2.Name = "lblOp2";
            this.lblOp2.Size = new System.Drawing.Size(98, 18);
            this.lblOp2.TabIndex = 8;
            this.lblOp2.Text = "Operand 2";
            this.lblOp2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbxFormat
            // 
            this.cbxFormat.FormattingEnabled = true;
            this.cbxFormat.Location = new System.Drawing.Point(140, 19);
            this.cbxFormat.Name = "cbxFormat";
            this.cbxFormat.Size = new System.Drawing.Size(728, 26);
            this.cbxFormat.TabIndex = 0;
            this.cbxFormat.SelectedIndexChanged += new System.EventHandler(this.CbxFormat_SelectedIndexChanged);
            // 
            // lblOp1
            // 
            this.lblOp1.AutoSize = true;
            this.lblOp1.Location = new System.Drawing.Point(17, 74);
            this.lblOp1.Name = "lblOp1";
            this.lblOp1.Size = new System.Drawing.Size(98, 18);
            this.lblOp1.TabIndex = 7;
            this.lblOp1.Text = "Operand 1";
            this.lblOp1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Location = new System.Drawing.Point(17, 22);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(68, 18);
            this.lblFormat.TabIndex = 6;
            this.lblFormat.Text = "Format";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 668);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbxCalc);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmMain";
            this.Text = "Bitwise Logic Demo";
            this.gbxCalc.ResumeLayout(false);
            this.gbxCalc.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxGates;
        private System.Windows.Forms.GroupBox gbxCalc;
        private System.Windows.Forms.ComboBox cbxBits;
        private System.Windows.Forms.Label lblOut1;
        private System.Windows.Forms.ComboBox cbxSpace;
        private System.Windows.Forms.Label lblGate;
        private System.Windows.Forms.Label lblBits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbxOp2;
        private System.Windows.Forms.TextBox tbxOp1;
        private System.Windows.Forms.Label lblOp2;
        private System.Windows.Forms.ComboBox cbxFormat;
        private System.Windows.Forms.Label lblOp1;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblOut2;
        private System.Windows.Forms.Label lblRe;
        private System.Windows.Forms.Label lblOp2R;
        private System.Windows.Forms.Label lblOp1R;
    }
}

