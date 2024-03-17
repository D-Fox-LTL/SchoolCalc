using System.Linq.Expressions;

namespace Calculator
{
    public partial class Form1 : Form
    {
        float floatPosOne;
        float floatPosTwo;
        float floatResult;
        int intOperantID;   //0-nothing, 1-plus, 2-minus, 3-multi, 4-division, 5-power

        clsOperants OP = new clsOperants();

        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button == btZero)
            {
                txtDisplay.Text += "0";
            }
            else if (button == btOne)
            {
                txtDisplay.Text += "1";
            }
            else if (button == btTwo)
            {
                txtDisplay.Text += "2";
            }
            else if (button == btThree)
            {
                txtDisplay.Text += "3";
            }
            else if (button == btFour)
            {
                txtDisplay.Text += "4";
            }
            else if (button == btFive)
            {
                txtDisplay.Text += "5";
            }
            else if (button == btSix)
            {
                txtDisplay.Text += "6";
            }
            else if (button == btSeven)
            {
                txtDisplay.Text += "7";
            }
            else if (button == btEight)
            {
                txtDisplay.Text += "8";
            }
            else if (button == btNine)
            {
                txtDisplay.Text += "9";
            }
            else if (button == btDecimal)
            {
                if (txtDisplay.Text.Length > 0 && !txtDisplay.Text.Contains("."))
                {
                    txtDisplay.Text += ".";
                }
            }


        }

        private void txtDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
                {
                    e.Handled = true;
                }

                // only allow one decimal point and one minus
                if (((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) || ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1)))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    btEquals.PerformClick();
                }

                if (e.KeyChar == Convert.ToChar(Keys.Back))
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length-1);
                }

                switch (e.KeyChar)
                {
                    case '+':
                        btPlus.PerformClick();
                        break;

                    case '-':
                        if ((sender as TextBox).Text.IndexOf('-')! > -1)
                        {
                            btMinus.PerformClick();
                        }
                        break;

                    case '*':
                        btMultiply.PerformClick();
                        break;

                    case '/':
                        btDivision.PerformClick();
                        break;

                    case '^':
                        btPower.PerformClick();
                        break;

                    case '=':
                        btEquals.PerformClick();
                        break;
                }
            }
            catch { }
        }

        private void btOp_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            ///Math operants            TODO

            try
            {
                if (button == btPlus)
                {
                    switch (intOperantID)
                    {
                        case 0:
                            floatPosOne = float.Parse(txtDisplay.Text.ToString());
                            floatResult = floatResult + floatPosOne;
                            txtDisplay.Text = string.Empty;
                            intOperantID = 1;
                            break;
                        case 1:
                            floatPosTwo = float.Parse(txtDisplay.Text.ToString());
                            floatResult = OP.opPlus(floatPosOne, floatPosTwo);
                            txtDisplay.Text = string.Empty;
                            intOperantID = 1;
                            break;
                        case 2:
                            floatPosTwo = float.Parse(txtDisplay.Text.ToString());
                            floatResult = OP.opMinus(floatPosOne, floatPosTwo);
                            txtDisplay.Text = string.Empty;
                            intOperantID = 1;
                            break;
                        case 3:
                            floatPosTwo = float.Parse(txtDisplay.Text.ToString());
                            floatResult = OP.opMulti(floatPosOne, floatPosTwo);
                            txtDisplay.Text = string.Empty;
                            intOperantID = 1;
                            break;
                        case 4:
                            floatPosTwo = float.Parse(txtDisplay.Text.ToString());
                            floatResult = OP.opDivide(floatPosOne, floatPosTwo);
                            txtDisplay.Text = string.Empty;
                            intOperantID = 1;
                            break;
                        case 5:
                            floatPosTwo = float.Parse(txtDisplay.Text.ToString());
                            floatResult = OP.opPower(floatPosOne, floatPosTwo);
                            txtDisplay.Text = string.Empty;
                            intOperantID = 1;
                            break;
                    }
                }
                else if (button == btMinus)
                {
                    if (!txtDisplay.Text.Contains("-") && !(txtDisplay.Text.Length > 0))
                    {
                        txtDisplay.Text += "-";
                    }
                    else
                    {
                        switch (intOperantID)
                        {
                            case 0:
                                floatPosOne = float.Parse(txtDisplay.Text.ToString());
                                floatResult = floatResult - floatPosOne;
                                txtDisplay.Text = string.Empty;
                                intOperantID = 2;
                                break;
                            case 1:
                                floatPosTwo = float.Parse(txtDisplay.Text.ToString());
                                floatResult = OP.opPlus(floatPosOne, floatPosTwo);
                                txtDisplay.Text = string.Empty;
                                intOperantID = 2;
                                break;
                            case 2:
                                floatPosTwo = float.Parse(txtDisplay.Text.ToString());
                                floatResult = OP.opMinus(floatPosOne, floatPosTwo);
                                txtDisplay.Text = string.Empty;
                                intOperantID = 2;
                                break;
                            case 3:
                                floatPosTwo = float.Parse(txtDisplay.Text.ToString());
                                floatResult = OP.opMulti(floatPosOne, floatPosTwo);
                                txtDisplay.Text = string.Empty;
                                intOperantID = 2;
                                break;
                            case 4:
                                floatPosTwo = float.Parse(txtDisplay.Text.ToString());
                                floatResult = OP.opDivide(floatPosOne, floatPosTwo);
                                txtDisplay.Text = string.Empty;
                                intOperantID = 2;
                                break;
                            case 5:
                                floatPosTwo = float.Parse(txtDisplay.Text.ToString());
                                floatResult = OP.opPower(floatPosOne, floatPosTwo);
                                txtDisplay.Text = string.Empty;
                                intOperantID = 2;
                                break;
                        }
                    }
                }
                else if (button == btMultiply)
                {
                    switch (intOperantID)
                    {
                        case 0:
                            floatPosOne = float.Parse(txtDisplay.Text.ToString());
                            floatResult = floatResult * floatPosOne;
                            txtDisplay.Text = string.Empty;
                            intOperantID = 3;
                            break;
                        case 1:
                            floatPosTwo = float.Parse(txtDisplay.Text.ToString());
                            floatResult = OP.opPlus(floatPosOne, floatPosTwo);
                            txtDisplay.Text = string.Empty;
                            intOperantID = 3;
                            break;
                        case 2:
                            floatPosTwo = float.Parse(txtDisplay.Text.ToString());
                            floatResult = OP.opMinus(floatPosOne, floatPosTwo);
                            txtDisplay.Text = string.Empty;
                            intOperantID = 3;
                            break;
                        case 3:
                            floatPosTwo = float.Parse(txtDisplay.Text.ToString());
                            floatResult = OP.opMulti(floatPosOne, floatPosTwo);
                            txtDisplay.Text = string.Empty;
                            intOperantID = 3;
                            break;
                        case 4:
                            floatPosTwo = float.Parse(txtDisplay.Text.ToString());
                            floatResult = OP.opDivide(floatPosOne, floatPosTwo);
                            txtDisplay.Text = string.Empty;
                            intOperantID = 3;
                            break;
                        case 5:
                            floatPosTwo = float.Parse(txtDisplay.Text.ToString());
                            floatResult = OP.opPower(floatPosOne, floatPosTwo);
                            txtDisplay.Text = string.Empty;
                            intOperantID = 3;
                            break;
                    }
                }
                else if (button == btDivision)
                {
                    switch (intOperantID)
                    {
                        case 0:
                            floatPosOne = float.Parse(txtDisplay.Text.ToString());
                            floatResult = floatResult / floatPosOne;
                            txtDisplay.Text = string.Empty;
                            intOperantID = 4;
                            break;
                        case 1:
                            floatPosTwo = float.Parse(txtDisplay.Text.ToString());
                            floatResult = OP.opPlus(floatPosOne, floatPosTwo);
                            txtDisplay.Text = string.Empty;
                            intOperantID = 4;
                            break;
                        case 2:
                            floatPosTwo = float.Parse(txtDisplay.Text.ToString());
                            floatResult = OP.opMinus(floatPosOne, floatPosTwo);
                            txtDisplay.Text = string.Empty;
                            intOperantID = 4;
                            break;
                        case 3:
                            floatPosTwo = float.Parse(txtDisplay.Text.ToString());
                            floatResult = OP.opMulti(floatPosOne, floatPosTwo);
                            txtDisplay.Text = string.Empty;
                            intOperantID = 4;
                            break;
                        case 4:
                            floatPosTwo = float.Parse(txtDisplay.Text.ToString());
                            floatResult = OP.opDivide(floatPosOne, floatPosTwo);
                            txtDisplay.Text = string.Empty;
                            intOperantID = 4;
                            break;
                        case 5:
                            floatPosTwo = float.Parse(txtDisplay.Text.ToString());
                            floatResult = OP.opPower(floatPosOne, floatPosTwo);
                            txtDisplay.Text = string.Empty;
                            intOperantID = 4;
                            break;
                    }
                }
                else if (button == btPower)
                {
                    switch (intOperantID)
                    {
                        case 0:
                            floatPosOne = float.Parse(txtDisplay.Text.ToString());
                            floatResult = OP.opPower(floatResult, floatPosOne);
                            txtDisplay.Text = string.Empty;
                            intOperantID = 5;
                            break;
                        case 1:
                            floatPosTwo = float.Parse(txtDisplay.Text.ToString());
                            floatResult = OP.opPlus(floatPosOne, floatPosTwo);
                            txtDisplay.Text = string.Empty;
                            intOperantID = 5;
                            break;
                        case 2:
                            floatPosTwo = float.Parse(txtDisplay.Text.ToString());
                            floatResult = OP.opMinus(floatPosOne, floatPosTwo);
                            txtDisplay.Text = string.Empty;
                            intOperantID = 5;
                            break;
                        case 3:
                            floatPosTwo = float.Parse(txtDisplay.Text.ToString());
                            floatResult = OP.opMulti(floatPosOne, floatPosTwo);
                            txtDisplay.Text = string.Empty;
                            intOperantID = 5;
                            break;
                        case 4:
                            floatPosTwo = float.Parse(txtDisplay.Text.ToString());
                            floatResult = OP.opDivide(floatPosOne, floatPosTwo);
                            txtDisplay.Text = string.Empty;
                            intOperantID = 5;
                            break;
                        case 5:
                            floatPosTwo = float.Parse(txtDisplay.Text.ToString());
                            floatResult = OP.opPower(floatPosOne, floatPosTwo);
                            txtDisplay.Text = string.Empty;
                            intOperantID = 5;
                            break;
                    }
                }
                else if (button == btEquals)
                {
                    switch (intOperantID)
                    {
                        case 0:
                            txtDisplay.Text = floatResult.ToString();
                            break;
                        case 1:
                            floatPosTwo = float.Parse(txtDisplay.Text.ToString());
                            floatResult = OP.opPlus(floatPosOne, floatPosTwo);
                            txtDisplay.Text = floatResult.ToString();
                            intOperantID = 0;
                            break;
                        case 2:
                            floatPosTwo = float.Parse(txtDisplay.Text.ToString());
                            floatResult = OP.opMinus(floatPosOne, floatPosTwo);
                            txtDisplay.Text = floatResult.ToString();
                            intOperantID = 0;
                            break;
                        case 3:
                            floatPosTwo = float.Parse(txtDisplay.Text.ToString());
                            floatResult = OP.opMulti(floatPosOne, floatPosTwo);
                            txtDisplay.Text = floatResult.ToString();
                            intOperantID = 0;
                            break;
                        case 4:
                            floatPosTwo = float.Parse(txtDisplay.Text.ToString());
                            floatResult = OP.opDivide(floatPosOne, floatPosTwo);
                            txtDisplay.Text = floatResult.ToString();
                            intOperantID = 0;
                            break;
                        case 5:
                            floatPosTwo = float.Parse(txtDisplay.Text.ToString());
                            floatResult = OP.opPower(floatPosOne, floatPosTwo);
                            txtDisplay.Text = floatResult.ToString();
                            intOperantID = 0;
                            break;
                    }

                }
                else if (button == btErase)
                {
                    intOperantID = 0; floatResult = floatPosTwo = floatPosOne = 0;
                    txtDisplay.Text = string.Empty;
                }
            } catch { }
        }
    }
    public class clsOperants
    {
        public clsOperants() { }

        public float opMinus(float flOne, float flTwo)
        {
            return flOne - flTwo;
        }
        public float opPlus(float flOne, float flTwo)
        {
            return flOne + flTwo;
        }
        public float opMulti(float flOne, float flTwo)
        {
            return flOne * flTwo;
        }
        public float opDivide(float flOne, float flTwo)
        {
            return flOne / flTwo;
        }
        public float opPower(float flOne, float flPower)
        {
            double dbOne = double.Parse(flOne.ToString());
            double dbPower = double.Parse(flPower.ToString());
            return float.Parse(double.Pow(dbOne, dbPower).ToString());
        }
    }
}