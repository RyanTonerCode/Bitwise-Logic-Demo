using System;
using System.Windows.Forms;

namespace Bitwise_Logic_Demo
{
    public partial class frmMain : Form
    {

        Gates selectedGate;
        int bitArchitecture = 32;
        int bitSpacing = 8;

        Format inFormat1, inFormat2;

        public frmMain()
        {
            InitializeComponent();

            foreach(Gates gate in Enum.GetValues(typeof(Gates)))
            {
                cbxGates.Items.Add(gate.ToString());
            }

            foreach (Format fmat in Enum.GetValues(typeof(Format)))
            {
                cbxFormat1.Items.Add(fmat.ToString());
                cbxFormat2.Items.Add(fmat.ToString());
            }

            cbxGates.SelectedIndex = 0;
            cbxBits.SelectedIndex = 1;
            cbxSpace.SelectedIndex = 3;
            cbxFormat1.SelectedIndex = 0;
            cbxFormat2.SelectedIndex = 0;
            tbxOp1.Text = "12";
            tbxOp2.Text = "3";

            submit();
        }

        private enum Gates{ AND, OR, NOR, NAND, XOR, XNOR, SLL, SRL, ADD, SUB, MULT, TWOSCOMP, NOT };
        private enum Format { DECIMAL, HEX, BINARY };

        private void CbxGates_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Gates gate in Enum.GetValues(typeof(Gates)))
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
            bitArchitecture = int.Parse(cbxBits.Text);
        }

        private void CbxSpace_SelectedIndexChanged(object sender, EventArgs e)
        {
            bitSpacing = int.Parse(cbxSpace.Text);
        }

        private void CbxFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Format fmat in Enum.GetValues(typeof(Format)))
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
            foreach (Format fmat in Enum.GetValues(typeof(Format)))
            {
                if (fmat.ToString().Equals(cbxFormat1.Text))
                {
                    inFormat2 = fmat;
                    break;
                }
            }
        }

        void parse(string txt, Format f, out string res, out long res2)
        {
            res = "";

            txt = txt.Replace(" ", "").ToLower();
            long? val = null;
            try
            {
                if (f == Format.DECIMAL)
                {
                    val = Convert.ToInt64(txt, 10);
                    res = Convert.ToString((long)val, 2);
                }
                else if (f == Format.HEX)
                {
                    txt = txt.Replace("0x", "");
                    val = Convert.ToInt64(txt, 16);
                    res = Convert.ToString((long)val, 2);
                }
                else if (f == Format.BINARY)
                {
                    txt = txt.Replace("0b", "");
                    val = Convert.ToInt64(txt, 2);
                    res = Convert.ToString((long)val, 2);
                }
            }
            catch (Exception) { }

            if (val == null)
            {
                MessageBox.Show("Invalid input! Please ensure that your format is correct.");
                res = "";
                res2 = 0;
            }
            else { 
                 res = formatStr(res);
                 res2 = (long)val;
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

            lblb1.Text = op1;
            lblb2.Text = op2;

            try
            {
                lbld1.Text = Convert.ToString(o1, 10);
                lbld2.Text = Convert.ToString(o2, 10);
                lblh1.Text = Convert.ToString(o1, 16);
                lblh2.Text = Convert.ToString(o2, 16);


                long result = calc(o1, o2);
                string str = Convert.ToString(result, 2);

                lblb3.Text = formatStr(str);
                lbld3.Text = Convert.ToString(result, 10);
                lblh3.Text = Convert.ToString(result, 16);
            }
            catch (Exception) { }
        }

        private void BtnSubmit_Click(object sender, EventArgs e) => submit();


        long calc(long o1, long o2)
        {
            if (selectedGate == Gates.NOT || selectedGate == Gates.TWOSCOMP)
            {
                lblh2.Text = "";
                lbld2.Text = "";
                lblb2.Text = "GATE USES 1 INPUT ONLY";
            }

            o1 = ~(~o1);
            o2 = ~(~o2);
            switch (selectedGate)
            {
                case Gates.ADD:
                    return o1 + o2;
                case Gates.AND:
                    return o1 & o2;
                case Gates.OR:
                    return o1 | o2;
                case Gates.NOR:
                    return ~(o1 | o2);
                case Gates.NAND:
                    return ~(o1 & o2);
                case Gates.XOR:
                    return (o1 ^ o2);
                case Gates.XNOR:
                    return ~(o1 ^ o2);
                case Gates.SLL:
                    return o1 << (int)o2;
                case Gates.SRL:
                    return o1 >> (int)o2;
                case Gates.SUB:
                    return o1 - o2;
                case Gates.MULT:
                    return o1 * o2;
                case Gates.TWOSCOMP:
                    return ~(o1) + 1;
                case Gates.NOT:
                    return ~o1;
                default:
                    return 0;
            }
        }

        private void TbxOp1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                parse(tbxOp1.Text, inFormat1, out string op1, out long o1);
                lblb1.Text = op1;
            }
        }

        void copyToClipboard(Label lbl)
        {
            Clipboard.SetText(lbl.Text.Trim().Replace(" ", ""));
        }

        private void lbl_copy(object sender, EventArgs e) => copyToClipboard((Label)sender);

        void convert(Format conFormat)
        {
            long val = 0;
            try
            {
                if (conFormat == Format.BINARY && tbxConBin.Text != string.Empty)
                    val = Convert.ToInt64(tbxConBin.Text, 2);
                else if (conFormat == Format.HEX && tbxConHex.Text != string.Empty)
                    val = Convert.ToInt64(tbxConHex.Text, 16);
                else if (conFormat == Format.DECIMAL && tbxConDec.Text != string.Empty)
                    val = Convert.ToInt64(tbxConDec.Text, 10);

                tbxConBin.Text = Convert.ToString(val, 2);
                tbxConDec.Text = Convert.ToString(val, 10);
                tbxConHex.Text = Convert.ToString(val, 16);
            }
            catch (Exception) {  }
        }

        private void TbxConHex_TextChanged(object sender, EventArgs e)
        {
            convert(Format.HEX);
        }

        private void TbxConBin_TextChanged(object sender, EventArgs e)
        {
            convert(Format.BINARY);
        }

        private void TbxConDec_TextChanged(object sender, EventArgs e)
        {
            convert(Format.DECIMAL);
        }

        private void TbxConHex_DoubleClick(object sender, EventArgs e)
        {
            tbxConBin.Text = "";
            tbxConDec.Text = "";
            tbxConHex.Text = "";
        }

        private void Lbld1_Click(object sender, EventArgs e) => copyToClipboard((Label)sender);

        private void TbxOp2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                parse(tbxOp2.Text, inFormat1, out string op2, out long o1);
                lblb2.Text = op2;
            }
        }
    }
}
