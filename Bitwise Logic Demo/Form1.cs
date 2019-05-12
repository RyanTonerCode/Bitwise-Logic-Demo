using System;
using System.Windows.Forms;

namespace Bitwise_Logic_Demo
{
    public partial class frmMain : Form
    {

        Gates selectedGate;
        int bitArchitecture = 32;
        int bitSpacing = 8;

        Format inFormat;

        public frmMain()
        {
            InitializeComponent();

            foreach(Gates gate in Enum.GetValues(typeof(Gates)))
            {
                cbxGates.Items.Add(gate.ToString());
            }

            foreach (Format fmat in Enum.GetValues(typeof(Format)))
            {
                cbxFormat.Items.Add(fmat.ToString());
            }

            cbxGates.SelectedIndex = 0;
            cbxBits.SelectedIndex = 1;
            cbxSpace.SelectedIndex = 3;
            cbxFormat.SelectedIndex = 0;
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
                if (fmat.ToString().Equals(cbxFormat.Text))
                {
                    inFormat = fmat;
                    break;
                }
            }
        }

        void parse(TextBox tbx, out string res, out long res2)
        {
            res = "";

            string txt = tbx.Text.Replace(" ", "").ToLower();
            long? val = null;
            try
            {
                if (inFormat == Format.DECIMAL)
                {
                    val = Convert.ToInt64(txt, 10);
                    res = Convert.ToString((long)val, 2);
                }
                else if (inFormat == Format.HEX)
                {
                    txt = txt.Replace("0x", "");
                    val = Convert.ToInt64(txt, 16);
                    res = Convert.ToString((long)val, 2);
                }
                else if (inFormat == Format.BINARY)
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
            parse(tbxOp1, out string op1, out long o1);
            parse(tbxOp2, out string op2, out long o2);

            lblOut1.Text = op1;
            lblOut2.Text = op2;

            try
            {

                long result = calc(o1, o2);
                string str = Convert.ToString(result, 2);

                lblResult.Text = formatStr(str);
            }
            catch (Exception) { }
        }

        private void BtnSubmit_Click(object sender, EventArgs e) => submit();


        long calc(long o1, long o2)
        {
            if (selectedGate == Gates.NOT || selectedGate == Gates.TWOSCOMP)
                lblOut2.Text = "GATE USES 1 INPUT ONLY";

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
                parse(tbxOp1, out string op1, out long l);
                lblOut1.Text = op1;
            }
        }

        private void TbxOp2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                parse(tbxOp2, out string op2, out long l);
                lblOut2.Text = op2;
            }
        }
    }
}
