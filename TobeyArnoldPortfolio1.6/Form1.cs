using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TobeyArnoldPortfolio1._6
{
    /// <author>Tobey Arnold</author>
    /// <datecreated>02/05/17</datecreated>
    /// <version>1.0</version>
    /// 
    /// <summary>
    /// Gets user input via buttons and performs selected calculation
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double leftNumber = 0;
        double result = 0;

        //store which button was clicked
        bool plusButtonClicked = false;
        bool minusButtonClicked = false;
        bool divideButtonClicked = false;
        bool multiplyButtonClicked = false;

        /// <summary>
        /// Adds the buttons contents to the display
        /// </summary>
        /// <param name="sender">The object linked to the method</param>
        /// <param name="e">Contains event data</param>
        private void Btn0Click(object sender, EventArgs e)
        {
            //display the buttons number on the display
            txtResult.Text = txtResult.Text + btn0.Text;
        }

        /// <summary>
        /// Adds the buttons contents to the display
        /// </summary>
        /// <param name="sender">The object linked to the method</param>
        /// <param name="e">Contains event data</param>
        private void Btn1Click(object sender, EventArgs e)
        {
            //display the buttons number on the display
            txtResult.Text = txtResult.Text + btn1.Text;
        }

        /// <summary>
        /// Adds the buttons contents to the display
        /// </summary>
        /// <param name="sender">The object linked to the method</param>
        /// <param name="e">Contains event data</param>
        private void Btn2Click(object sender, EventArgs e)
        {
            //display the buttons number on the display
            txtResult.Text = txtResult.Text + btn2.Text;
        }

        /// <summary>
        /// Adds the buttons contents to the display
        /// </summary>
        /// <param name="sender">The object linked to the method</param>
        /// <param name="e">Contains event data</param>
        private void Btn3Click(object sender, EventArgs e)
        {
            //display the buttons number on the display
            txtResult.Text = txtResult.Text + btn3.Text;
        }

        /// <summary>
        /// Adds the buttons contents to the display
        /// </summary>
        /// <param name="sender">The object linked to the method</param>
        /// <param name="e">Contains event data</param>
        private void Btn4Click(object sender, EventArgs e)
        {
            //display the buttons number on the display
            txtResult.Text = txtResult.Text + btn4.Text;
        }

        /// <summary>
        /// Adds the buttons contents to the display
        /// </summary>
        /// <param name="sender">The object linked to the method</param>
        /// <param name="e">Contains event data</param>
        private void Btn5Click(object sender, EventArgs e)
        {
            //display the buttons number on the display
            txtResult.Text = txtResult.Text + btn5.Text;
        }

        /// <summary>
        /// Adds the buttons contents to the display
        /// </summary>
        /// <param name="sender">The object linked to the method</param>
        /// <param name="e">Contains event data</param>
        private void Btn6Click(object sender, EventArgs e)
        {
            //display the buttons number on the display
            txtResult.Text = txtResult.Text + btn6.Text;
        }

        /// <summary>
        /// Adds the buttons contents to the display
        /// </summary>
        /// <param name="sender">The object linked to the method</param>
        /// <param name="e">Contains event data</param>
        private void Btn7Click(object sender, EventArgs e)
        {
            //display the buttons number on the display
            txtResult.Text = txtResult.Text + btn7.Text;
        }

        /// <summary>
        /// Adds the buttons contents to the display
        /// </summary>
        /// <param name="sender">The object linked to the method</param>
        /// <param name="e">Contains event data</param>
        private void Btn8Click(object sender, EventArgs e)
        {
            //display the buttons number on the display
            txtResult.Text = txtResult.Text + btn8.Text;
        }

        /// <summary>
        /// Adds the buttons contents to the display
        /// </summary>
        /// <param name="sender">The object linked to the method</param>
        /// <param name="e">Contains event data</param>
        private void Btn9Click(object sender, EventArgs e)
        {
            //display the buttons number on the display
            txtResult.Text = txtResult.Text + btn9.Text;
        }

        /// <summary>
        /// Clicked the clear button
        /// </summary>
        /// <param name="sender">The object linked to the method</param>
        /// <param name="e">Contains event data</param>
        private void BtnClearClick(object sender, EventArgs e)
        {
            //clear the text from the display
            if (txtResult != null)
            {
                txtResult.Clear();

                //clear the stored numbers
                leftNumber = 0;
                result = 0;
            }
        }

        /// <summary>
        /// Adds a decimal point
        /// </summary>
        /// <param name="sender">The object linked to the method</param>
        /// <param name="e">Contains event data</param>
        private void BtnDecimalClick(object sender, EventArgs e)
        {
            //display the buttons number on the display
            txtResult.Text = txtResult.Text + btnDecimal.Text;
        }

        /// <summary>
        /// Lets the program know the add button was clicked
        /// </summary>
        /// <param name="sender">The object linked to the method</param>
        /// <param name="e">Contains event data</param>
        private void BtnAddClick(object sender, EventArgs e)
        {
            try
            {
                //get the number from the display
                leftNumber += double.Parse(txtResult.Text);

                //clear the display
                txtResult.Clear();

                //set clicked variable to true
                plusButtonClicked = true;
                minusButtonClicked = false;
                divideButtonClicked = false;
                multiplyButtonClicked = false;
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Number");
            }
        }

        /// <summary>
        /// Lets the program know the subtract button was clicked
        /// </summary>
        /// <param name="sender">The object linked to the method</param>
        /// <param name="e">Contains event data</param>
        private void BtnSubtractClick(object sender, EventArgs e)
        {
            try
            {
                //get the number from the display
                leftNumber += double.Parse(txtResult.Text);

                //clear the display
                txtResult.Clear();

                //set clicked variable to true
                plusButtonClicked = false;
                minusButtonClicked = true;
                divideButtonClicked = false;
                multiplyButtonClicked = false;
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Number");
            }
        }

        /// <summary>
        /// Lets the program know the divide button was clicked
        /// </summary>
        /// <param name="sender">The object linked to the method</param>
        /// <param name="e">Contains event data</param>
        private void BtnDivideClick(object sender, EventArgs e)
        {
            try
            {
                //get the number from the display
                leftNumber += double.Parse(txtResult.Text);

                //clear the display
                txtResult.Clear();

                //set clicked variable to true
                plusButtonClicked = false;
                minusButtonClicked = false;
                divideButtonClicked = true;
                multiplyButtonClicked = false;
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Number");
            }
        }

        /// <summary>
        /// Lets the program know the multiply button was clicked
        /// </summary>
        /// <param name="sender">The object linked to the method</param>
        /// <param name="e">Contains event data</param>
        private void BtnMultiplyClick(object sender, EventArgs e)
        {
            try
            {
                //get the number from the display
                leftNumber += double.Parse(txtResult.Text);

                //clear the display
                txtResult.Clear();

                //set clicked variable to true
                plusButtonClicked = false;
                minusButtonClicked = false;
                divideButtonClicked = false;
                multiplyButtonClicked = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Number");
            }
        }

        /// <summary>
        /// Lets the program know the equals button was clicked and calls the relevant function
        /// </summary>
        /// <param name="sender">The object linked to the method</param>
        /// <param name="e">Contains event data</param>
        private void BtnEqualsClick(object sender, EventArgs e)
        {
            try
            {
                if (plusButtonClicked == true)
                {
                    //run the function from the library
                    result = BasicMath.Arithmetic.Add(leftNumber, double.Parse(txtResult.Text));
                }
                else if (minusButtonClicked == true)
                {
                    //run the function from the library
                    result = BasicMath.Arithmetic.Subtract(leftNumber, double.Parse(txtResult.Text));
                }
                else if (divideButtonClicked == true)
                {
                    //run the function from the library
                    result = BasicMath.Arithmetic.Divide(leftNumber, double.Parse(txtResult.Text));
                }
                else if (multiplyButtonClicked == true)
                {
                    //run the function from the library
                    result = BasicMath.Arithmetic.Multiply(leftNumber, double.Parse(txtResult.Text));
                }
                //display the result
                txtResult.Text = result.ToString();
                leftNumber = 0;
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Number");
            }
        }

        /// <summary>
        /// Lets the program know the square root button was clicked
        /// </summary>
        /// <param name="sender">The object linked to the method</param>
        /// <param name="e">Contains event data</param>
        private void BtnSquareRootClick(object sender, EventArgs e)
        {
            try
            {
                //get the number from the display
                double num = double.Parse(txtResult.Text);
                if (num >= 0)
                {
                    //run the function from the library
                    txtResult.Text = AdvArithmetic.Arithmetic.SquareRoot(num).ToString();
                }
                else
                {
                    MessageBox.Show("Number must be positive", "Error Message");
                    txtResult.Text = "0";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Number");
            }
        }

        /// <summary>
        /// Lets the program know the square root button was clicked
        /// </summary>
        /// <param name="sender">The object linked to the method</param>
        /// <param name="e">Contains event data</param>
        private void BtnCubeRootClick(object sender, EventArgs e)
        {
            try
            {
                //get the number from the display
                double num = double.Parse(txtResult.Text);
                if (num >= 0)
                {
                    //run the function from the library
                    txtResult.Text = AdvArithmetic.Arithmetic.CubeRoot(num).ToString();
                }
                else
                {
                    MessageBox.Show("Number must be positive", "Error Message");
                    txtResult.Text = "0";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Number");
            }
        }

        /// <summary>
        /// Clears the display
        /// </summary>
        /// <param name="sender">The object linked to the method</param>
        /// <param name="e">Contains event data</param>
        private void ClearToolStripMenuItemClick(object sender, EventArgs e)
        {
            //clear the display
            txtResult.Clear();
        }

        /// <summary>
        /// Quits the application
        /// </summary>
        /// <param name="sender">The object linked to the method</param>
        /// <param name="e">Contains event data</param>
        private void QuitToolStripMenuItemClick(object sender, EventArgs e)
        {
            //ask the user if they really want to quit
            if (MessageBox.Show("Really Quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                //quit the application
                Application.Exit();
            }
        }

        /// <summary>
        /// Inverts the operation
        /// </summary>
        /// <param name="sender">The object linked to the method</param>
        /// <param name="e">Contains event data</param>
        private void BtnInverseClick(object sender, EventArgs e)
        {
            try
            {
                if (plusButtonClicked == true)
                {
                    //run the function from the library
                    result = BasicMath.Arithmetic.Subtract(leftNumber, double.Parse(txtResult.Text));
                }
                else if (minusButtonClicked == true)
                {
                    //run the function from the library
                    result = BasicMath.Arithmetic.Add(leftNumber, double.Parse(txtResult.Text));
                }
                else if (divideButtonClicked == true)
                {
                    //run the function from the library
                    result = BasicMath.Arithmetic.Multiply(leftNumber, double.Parse(txtResult.Text));
                }
                else if (multiplyButtonClicked == true)
                {
                    //run the function from the library
                    result = BasicMath.Arithmetic.Divide(leftNumber, double.Parse(txtResult.Text));
                }
                txtResult.Text = result.ToString();
                leftNumber = 0;
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Number");
            }
        }

        /// <summary>
        /// Performs Tan on the displays' value
        /// </summary>
        /// <param name="sender">The object linked to the method</param>
        /// <param name="e">Contains event data</param>
        private void BtnTanClick(object sender, EventArgs e)
        {
            try
            {
                //get the number from the display
                double num = double.Parse(txtResult.Text);
                if (num >= 0 && num < 90)
                {
                    //run the function from the library
                    num = TrigArithmetic.Arithmetic.Tan(num);

                    txtResult.Text = num.ToString();
                }
                else
                {
                    MessageBox.Show("Invalid Number");
                    txtResult.Text = "0";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Number");
            }
        }

        /// <summary>
        /// Performs Sin on the displays' value
        /// </summary>
        /// <param name="sender">The object linked to the method</param>
        /// <param name="e">Contains event data</param>
        private void BtnSinClick(object sender, EventArgs e)
        {
            try
            {
                //get the number from the display
                double num = double.Parse(txtResult.Text);
                if (num >= 0 && num < 90)
                {
                    //run the function from the library
                    num = TrigArithmetic.Arithmetic.Sin(num);

                    txtResult.Text = num.ToString();
                }
                else
                {
                    MessageBox.Show("Invalid Number");
                    txtResult.Text = "0";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Number");
            }
        }

        /// <summary>
        /// Performs Cos on the displays' value
        /// </summary>
        /// <param name="sender">The object linked to the method</param>
        /// <param name="e">Contains event data</param>
        private void BtnCosClick(object sender, EventArgs e)
        {
            try
            {
                //get the number from the display
                double num = double.Parse(txtResult.Text);
                if (num >= 0 && num < 90)
                {
                    //run the function from the library
                    num = TrigArithmetic.Arithmetic.Cos(num);

                    txtResult.Text = num.ToString();
                }
                else
                {
                    MessageBox.Show("Invalid Number");
                    txtResult.Text = "0";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Number");
            }

        }
    }
}
