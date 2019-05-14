using System;
using System.Windows.Forms;

namespace Bitwise_Logic_Demo
{
    public partial class frmMain : Form
    {
        private enum GATES { AND, OR, NOR, NAND, XOR, XNOR, SLL, SRL, ADD, SUB, MULT, TWOSCOMP, NOT };
        private enum FORMAT { DECIMAL, HEX, BINARY };

        GATES selectedGate;
        int bitArchitecture = 32;
        int bitSpacing = 8;

        bool signed = true;

        FORMAT inFormat1, inFormat2;

        public frmMain()
        {
            InitializeComponent();

            foreach(GATES gate in Enum.GetValues(typeof(GATES)))
            {
                cbxGates.Items.Add(gate.ToString());
            }

            foreach (FORMAT fmat in Enum.GetValues(typeof(FORMAT)))
            {
                cbxFormat1.Items.Add(fmat.ToString());
                cbxFormat2.Items.Add(fmat.ToString());
            }

            cbxGates.SelectedIndex = 0;
            cbxBits.SelectedIndex = 2;
            cbxSpace.SelectedIndex = 3;
            cbxFormat1.SelectedIndex = 0;
            cbxFormat2.SelectedIndex = 0;
            tbxOp1.Text = "12";
            tbxOp2.Text = "3";

            submit();
        }

        private void CbxGates_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (GATES gate in Enum.GetValues(typeof(GATES)))
            {
                if (gate.ToString().Equals(cbxGates.Text))
                {
                    selectedGate = gate;
                    break;
                }
            }
        }

        private void CbxBits_SelectedIndexChanged(object sender, EventArgs e)
        {
            bitArchitecture = int.Parse(cbxBits.Text.Replace("u", ""));
            signed = !cbxBits.Text.Contains("u");
        }

        private void CbxSpace_SelectedIndexChanged(object sender, EventArgs e)
        {
            bitSpacing = int.Parse(cbxSpace.Text);
        }

        private void CbxFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (FORMAT fmat in Enum.GetValues(typeof(FORMAT)))
            {
                if (fmat.ToString().Equals(cbxFormat1.Text))
                {
                    inFormat1 = fmat;
                    break;
                }
            }
        }

        private void CbxFormat2_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (FORMAT fmat in Enum.GetValues(typeof(FORMAT)))
            {
                if (fmat.ToString().Equals(cbxFormat2.Text))
                {
                    inFormat2 = fmat;
                    break;
                }
            }
        }

        void parse(string txt, FORMAT f, out string res, out long res2)
        {
            res = "";

            txt = txt.Replace(" ", "").ToLower();
            long? val = null;
            try
            {
                if (f == FORMAT.DECIMAL)
                {
                    val = Convert.ToInt64(txt, 10);
                    res = Convert.ToString((long)val, 2);
                }
                else if (f == FORMAT.HEX)
                {
                    txt = txt.Replace("0x", "");
                    val = Convert.ToInt64(txt, 16);
                    res = Convert.ToString((long)val, 2);
                }
                else if (f == FORMAT.BINARY)
                {
                    txt = txt.Replace("0b", "");
                    val = Convert.ToInt64(txt, 2);
                    res = Convert.ToString((long)val, 2);
                }
            }
            catch (Exception) { }

            string bitOverflow = "You have a bit overflow! Check your architecture";


            if (val == null)
            {
                MessageBox.Show("Invalid input! Please ensure that your format is correct.");
                res = "";
                res2 = 0;
            }
            else { 
                 res = formatStr(res);

                int totBits = res.Replace(" ", "").Length - 1;

                res2 = (long)val;
                if (res2 < 0 && signed)
                    return;

                bool overflow =
                    ((ulong)res2 > UInt64.MaxValue && bitArchitecture == 64 && !signed) ||
                    (res2 > UInt32.MaxValue && bitArchitecture == 32 && !signed) ||
                    (res2 > UInt16.MaxValue && bitArchitecture == 16 && !signed) || 
                    totBits > bitArchitecture;

                if (overflow)
                    MessageBox.Show(bitOverflow);
            }
        }

        string formatStr(string s)
        {
            if (s.Length > bitArchitecture)
                s = s.Substring(s.Length - bitArchitecture, bitArchitecture);

            for (int i = 0; i < bitArchitecture; i++)
            {
                if (s.Length != bitArchitecture)
                {
                    s = "0" + (s);
                }
            }
            if (bitSpacing >= bitArchitecture)
                return s;

            int iter = 0, offset = 0;
            string spaced = "";
            while (iter * bitSpacing < bitArchitecture)
            {
                spaced = s.Substring(bitArchitecture - offset - bitSpacing, bitSpacing) + " " + spaced;

                offset += bitSpacing;
                iter++;
            }

            return spaced;
        }

        void submit()
        {
            parse(tbxOp1.Text, inFormat1, out string op1, out long o1);
            parse(tbxOp2.Text, inFormat2, out string op2, out long o2);

            //binary does not care about sign
            lblb1.Text = op1;
            lblb2.Text = op2;

            try
            {
                lbld1.Text = Convert.ToString(o1, 10);
                lbld2.Text = Convert.ToString(o2, 10);
                lblh1.Text = Convert.ToString(o1, 16);
                lblh2.Text = Convert.ToString(o2, 16);


                if (signed && op1[0] == '1')
                {
                    if (bitArchitecture == 64)
                    {
                        Int64 neg = Convert.ToInt64(op1.Replace(" ", ""), 2);
                        lbld1.Text = Convert.ToString(neg, 10);
                    }
                    else if (bitArchitecture == 32)
                    {
                        Int32 neg = Convert.ToInt32(op1.Replace(" ", ""), 2);
                        lbld1.Text = Convert.ToString(neg, 10);
                    }
                    else if (bitArchitecture == 16)
                    {
                        Int16 neg = Convert.ToInt16(op1.Replace(" ", ""), 2);
                        lbld1.Text = Convert.ToString(neg, 10);
                    }
                }

                long result = calc(o1, o2);
                string str = Convert.ToString(result, 2);

                lblb3.Text = formatStr(str);
                lbld3.Text = Convert.ToString(result, 10);
                lblh3.Text = Convert.ToString(result, 16);

                if (signed && op2[0] == '1')
                {
                    if (bitArchitecture == 64)
                    {
                        Int64 neg = Convert.ToInt64(op2.Replace(" ", ""), 2);
                        lbld2.Text = Convert.ToString(neg, 10);
                    }
                    else if (bitArchitecture == 32)
                    {
                        Int32 neg = Convert.ToInt32(op2.Replace(" ", ""), 2);
                        lbld2.Text = Convert.ToString(neg, 10);
                    }
                    else if (bitArchitecture == 32)
                    {
                        Int16 neg = Convert.ToInt16(op2.Replace(" ", ""), 2);
                        lbld2.Text = Convert.ToString(neg, 10);
                    }
                }
            }
            catch (Exception) { }
        }

        private void BtnSubmit_Click(object sender, EventArgs e) => submit();


        long calc(long o1, long o2)
        {
            if (selectedGate == GATES.NOT || selectedGate == GATES.TWOSCOMP)
            {
                lblh2.Text = "";
                lbld2.Text = "";
                lblb2.Text = "GATE USES 1 INPUT ONLY";
            }

            o1 = ~(~o1);
            o2 = ~(~o2);
            switch (selectedGate)
            {
                case GATES.ADD:
                    return o1 + o2;
                case GATES.AND:
                    return o1 & o2;
                case GATES.OR:
                    return o1 | o2;
                case GATES.NOR:
                    return ~(o1 | o2);
                case GATES.NAND:
                    return ~(o1 & o2);
                case GATES.XOR:
                    return (o1 ^ o2);
                case GATES.XNOR:
                    return ~(o1 ^ o2);
                case GATES.SLL:
                    return o1 << (int)o2;
                case GATES.SRL:
                    return o1 >> (int)o2;
                case GATES.SUB:
                    return o1 - o2;
                case GATES.MULT:
                    return o1 * o2;
                case GATES.TWOSCOMP:
                    return ~(o1) + 1;
                case GATES.NOT:
                    return ~o1;
                default:
                    return 0;
            }
        }

        void copyToClipboard(Label lbl)
        {
            Clipboard.SetText(lbl.Text.Trim().Replace(" ", ""));
        }

        private void lbl_copy(object sender, EventArgs e) => copyToClipboard((Label)sender);

        void convert(FORMAT conFormat)
        {
            long val = 0;
            try
            {
                if (conFormat == FORMAT.BINARY && tbxConBin.Text != string.Empty)
                    val = Convert.ToInt64(tbxConBin.Text, 2);
                else if (conFormat == FORMAT.HEX && tbxConHex.Text != string.Empty)
                    val = Convert.ToInt64(tbxConHex.Text, 16);
                else if (conFormat == FORMAT.DECIMAL && tbxConDec.Text != string.Empty)
                    val = Convert.ToInt64(tbxConDec.Text, 10);

                tbxConBin.Text = Convert.ToString(val, 2);
                tbxConDec.Text = Convert.ToString(val, 10);
                tbxConHex.Text = Convert.ToString(val, 16);
            }
            catch (Exception) {  }
        }

        private void TbxConHex_TextChanged(object sender, EventArgs e)
        {
            convert(FORMAT.HEX);
        }

        private void TbxConBin_TextChanged(object sender, EventArgs e)
        {
            convert(FORMAT.BINARY);
        }

        private void TbxConDec_TextChanged(object sender, EventArgs e)
        {
            convert(FORMAT.DECIMAL);
        }

        private void TbxConHex_DoubleClick(object sender, EventArgs e)
        {
            tbxConBin.Text = "";
            tbxConDec.Text = "";
            tbxConHex.Text = "";
        }

        private void Lbld1_Click(object sender, EventArgs e) => copyToClipboard((Label)sender);

        private void swap_click(object sender, EventArgs e)
        {
            int i = cbxFormat1.SelectedIndex;
            string s = tbxOp1.Text;
            tbxOp1.Text = tbxOp2.Text;
            tbxOp2.Text = s;
            cbxFormat1.SelectedIndex = cbxFormat2.SelectedIndex;
            cbxFormat2.SelectedIndex = i;
        }

    }
}
