using System.Globalization;
using System.Linq.Expressions;



namespace Calculator
{
    public partial class Form1 : Form
    {
        float floatPosOne;
        float floatPosTwo;
        float floatResult;
        int intOperantID;   //0-nothing, 1-plus, 2-minus, 3-multi, 4-division, 5-power

        
        //if bt txt is changed, change it also here
        const string bttxtPlus = "+";
        const string bttxtMinus = "-";
        const string bttxtDevide = "/";
        const string bttxtMultiply = "x";
        const string bttxtEquals = "=";
        const string bttxtClear = "C";
        const string bttxtPower = "Power";
        CultureInfo culture;        //WTF WHY DO CZECH PEOPLE HAVE FUCKING , INSTEAD OF .????

        clsOperants OP = new clsOperants();


        public Form1()
        {
            InitializeComponent();
            culture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            culture.NumberFormat.NumberDecimalSeparator = ".";
        }

        private void bt_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button.Text != ".")
            {
                txtDisplay.Text += button.Text;
            }
            else
            {
                if (txtDisplay.Text.Length > 0 && !txtDisplay.Text.Contains("."))
                {
                    txtDisplay.Text += ".";
                }
            }
            //Why is it so complicated ??? Am I dumb or...
            //switch (button.Text)
            //{
            //    case "0":
            //        txtDisplay.Text += "0";
            //        break;
            //    case "1":
            //        txtDisplay.Text += "1";
            //        break;
            //    case "2":
            //        txtDisplay.Text += "2";
            //        break;
            //    case "3":
            //        txtDisplay.Text += "3";
            //        break;
            //    case "4":
            //        txtDisplay.Text += "4";
            //        break;
            //    case "5":
            //        txtDisplay.Text += "5";
            //        break;
            //    case "6":
            //        txtDisplay.Text += "6";
            //        break;
            //    case "7":
            //        txtDisplay.Text += "7";
            //        break;
            //    case "8":
            //        txtDisplay.Text += "8";
            //        break;
            //    case "9":
            //        txtDisplay.Text += "9";
            //        break;
            //    case ".":
            //        if (txtDisplay.Text.Length > 0 && !txtDisplay.Text.Contains("."))
            //        {
            //            txtDisplay.Text += ".";
            //        }
            //        break;
            //}
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
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
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
            
            try
            {
                switch (button.Text)            //by text to use switch
                {
                    case bttxtPlus:
                        Operations(intOperantID, 1, button.Text);
                        break;
                    case bttxtMinus:
                        if (!txtDisplay.Text.Contains("-") && !(txtDisplay.Text.Length > 0))
                        {
                            txtDisplay.Text += "-";
                        }
                        else
                        {
                            Operations(intOperantID, 2, button.Text);
                        }
                        break;
                    case bttxtMultiply:
                        Operations(intOperantID, 3, button.Text);
                        break;
                    case bttxtDevide:
                        Operations(intOperantID, 4, button.Text);
                        break;
                    case bttxtPower:
                        Operations(intOperantID, 5, button.Text);
                        break;
                    case bttxtEquals:
                        Operations(intOperantID, 0, button.Text);
                        break;
                    case bttxtClear:
                        intOperantID = 0; floatResult = floatPosTwo = floatPosOne = 0;
                        txtDisplay.Text = string.Empty;
                        break;
                }
            }
            catch 
            {
                MessageBox.Show("gg");
            }
        }
        /// <summary>
        /// Operations dependend on Operant ID to know which action to do and then do something -> 5+5/2=       5+  \n  ID=1 5* \n  5+5=10 ID=3 \n ...
        /// </summary>
        /// <param name="ID">intOperantID</param>
        /// <param name="Operant">To which new ID to change</param>
        /// <param name="Operation">button.text</param>
        private void Operations(int ID, int Operant, string Operation)
        {
            switch (ID)
            {
                case 0:
                    OperationsCaseZero(Operation); break;
                case 1:
                    floatPosTwo = float.Parse(txtDisplay.Text.ToString(), culture);
                    floatResult = OP.opPlus(floatPosOne, floatPosTwo);
                    txtDisplay.Text = floatResult.ToString();
                    intOperantID = Operant;
                    break;
                case 2:
                    floatPosTwo = float.Parse(txtDisplay.Text.ToString(), culture);
                    floatResult = OP.opMinus(floatPosOne, floatPosTwo);
                    txtDisplay.Text = floatResult.ToString();
                    intOperantID = Operant;
                    break;
                case 3:
                    floatPosTwo = float.Parse(txtDisplay.Text.ToString(), culture);
                    floatResult = OP.opMulti(floatPosOne, floatPosTwo);
                    txtDisplay.Text = floatResult.ToString();
                    intOperantID = Operant;
                    break;
                case 4:
                    floatPosTwo = float.Parse(txtDisplay.Text.ToString(), culture);
                    floatResult = OP.opDivide(floatPosOne, floatPosTwo);
                    txtDisplay.Text = floatResult.ToString();
                    intOperantID = Operant;
                    break;
                case 5:
                    floatPosTwo = float.Parse(txtDisplay.Text.ToString(), culture);
                    floatResult = OP.opPower(floatPosOne, floatPosTwo);
                    txtDisplay.Text = floatResult.ToString();
                    intOperantID = Operant;
                    break;
            }
        }
        /// <summary>
        /// Switch for void Operations function, bcs I don't wanna do if elses y'know
        /// </summary>
        /// <param name="Operation"></param>
        private void OperationsCaseZero(string Operation)
        {
            switch (Operation)
            {
                case bttxtPlus:
                    floatPosOne = float.Parse(txtDisplay.Text.ToString(), culture);
                    floatResult = floatResult + floatPosOne;
                    txtDisplay.Text = string.Empty;
                    intOperantID = 1;
                    break;
                case bttxtMinus:
                    floatPosOne = float.Parse(txtDisplay.Text.ToString(), culture);
                    floatResult = floatResult - floatPosOne;
                    txtDisplay.Text = string.Empty;
                    intOperantID = 2;
                    break;
                case bttxtMultiply:
                    floatPosOne = float.Parse(txtDisplay.Text.ToString(), culture);
                    floatResult = floatResult * floatPosOne;
                    txtDisplay.Text = string.Empty;
                    intOperantID = 3;
                    break;
                case bttxtDevide:
                    floatPosOne = float.Parse(txtDisplay.Text.ToString(), culture);
                    floatResult = floatResult / floatPosOne;
                    txtDisplay.Text = string.Empty;
                    intOperantID = 4;
                    break;
                case bttxtPower:
                    floatPosOne = float.Parse(txtDisplay.Text.ToString(), culture);
                    floatResult = OP.opPower(floatResult, floatPosOne);
                    txtDisplay.Text = string.Empty;
                    intOperantID = 5;
                    break;
                case bttxtEquals:
                    txtDisplay.Text = floatResult.ToString();
                    break;
            }
        }
    }
        public class clsOperants
        {
            public clsOperants() 
        { 
            //Naaaaaah lmaooooooo
        }

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