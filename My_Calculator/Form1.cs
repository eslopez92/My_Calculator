using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace My_First_GUI
{
    public partial class Form1 : Form
    {
        public string Equation {get; set;}//string to display to text field for equation
        public string SubEquation { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyUp += new KeyEventHandler(Form1_KeyUp);
        }

        private void Form1_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad1)
                this.Num1_Button.PerformClick();
        }

        public Form1()
        {
            InitializeComponent();

            //initalization
            this.Equation = "";
            this.SubEquation = "";
            
        }

        public double sqrt(double number)//square root function
        {
            return Math.Pow(number, 0.5);
        }


                                   //BUTTON FUNCTIONS
#region

                                   //NUMBER BUTTONS
#region
        private void Num0_Button_Click(object sender, EventArgs e)
        {

            this.Equation = this.Equation + "0";
            Result_Field.Text = this.Equation;//string must be reversed;
        }
        
        private void Num1_Button_Click(object sender, EventArgs e)
        {
            this.Equation = this.Equation + "1";
            Result_Field.Text = this.Equation;//string must be reversed;
        }

        private void Num2_Button_Click(object sender, EventArgs e)
        {
            this.Equation = this.Equation + "2";
            Result_Field.Text = this.Equation;//string must be reversed;
        }

        private void Num3_Button_Click(object sender, EventArgs e)
        {
            this.Equation = this.Equation + "3";
            Result_Field.Text = this.Equation;//string must be reversed;
        }

        private void Num4_Button_Click(object sender, EventArgs e)
        {
            this.Equation = this.Equation + "4";
            Result_Field.Text = this.Equation;//string must be reversed;
        }

        private void Num5_Button_Click(object sender, EventArgs e)
        {
            this.Equation = this.Equation + "5";
            Result_Field.Text = this.Equation;//string must be reversed;
        }

        private void Num6_Button_Click(object sender, EventArgs e)
        {
            this.Equation = this.Equation + "6";
            Result_Field.Text = this.Equation;//string must be reversed;

        }

        private void Num7_Button_Click(object sender, EventArgs e)
        {
            this.Equation = this.Equation + "7";
            Result_Field.Text = this.Equation;//string must be reversed
        }

        private void Num8_Button_Click(object sender, EventArgs e)
        {
            this.Equation = this.Equation + "8";
            Result_Field.Text = this.Equation;//string must be reversed; 
        }

        private void Num9_Button_Click(object sender, EventArgs e)
        {
            this.Equation = this.Equation + "9";
            Result_Field.Text = this.Equation;//string must be reversed;
        }
#endregion

                                   //OPERATOR BUTTONS
#region

        private void Add_Button_Click(object sender, EventArgs e)
        {
            this.Equation = this.Equation + "+";
            Result_Field.Text = this.Equation;//string must be reversed;
        }

        private void Subtract_Button_Click(object sender, EventArgs e)
        {
            this.Equation = this.Equation + "-";
            Result_Field.Text = this.Equation;//string must be reversed;
        }
        
        private void Multiply_Button_Click(object sender, EventArgs e)
        {
            this.Equation = this.Equation + "*";
            Result_Field.Text = this.Equation;//string must be reversed;
        }
        
        private void Divide_Button_Click(object sender, EventArgs e)
        {
            this.Equation = this.Equation + "/";
            Result_Field.Text = this.Equation;//string must be reversed;
        }

        private void Modulus_Button_Click(object sender, EventArgs e)
        {
            this.Equation = this.Equation + "%";
            Result_Field.Text = this.Equation;//string must be reversed;
        }


        private void Negate_Button_Click(object sender, EventArgs e)
        {
            this.Equation = "-(" + this.Equation + ")";
            Result_Field.Text = this.Equation;
            //this.Equation;//string must be reversed
        }

        private void Square_Root_Button_Click(object sender, EventArgs e)
        {
            this.Equation = "Sqrt(" + this.Equation + ")";
            Result_Field.Text = this.Equation;
        }

        private void Invert_Button_Click(object sender, EventArgs e)
        {
            this.Equation = "1/(" + this.Equation + ")";
            Result_Field.Text = this.Equation;
        }
#endregion        

                                   //MISC. BUTTONS
#region
        private void Delete_Button_Click(object sender, EventArgs e)
        {
            if(Equation.Length>0)//checks to make sure the equation string is not null
                this.Equation = this.Equation.Substring(0, Equation.Length - 1);

            Result_Field.Text = this.Equation;
        }

        

        private void Equals_Button_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();//instance of a data table

            try
            {
                //square root checking
                #region
                SubEquation = "Sqrt(";//checks to see if sqrt has been entered
                int counter_1 = 0;//a counter to count to see how many characeters inside is the S in Sqrt
                int counter_2 = 0;//a counter to count to see how many characeters after sqrt
                int part_pairs = 0; //used to count the # of closed parth withing sqrt
                string orginal_equation;//used to save original equation
                double result_sub;
                if (this.Equation.Contains(SubEquation))
                {
                    orginal_equation = this.Equation;
                    //scans whole equation until sqrt is found
                    foreach (char ch1 in this.Equation)
                    {
                        if (ch1 == 'S')//only s in this case has square roots
                        {
                            //scans inside of sqrt
                            foreach (char ch2 in this.Equation.Substring(counter_1, this.Equation.Length))//starts scanning where the S is located
                            {                           

                                if (ch2 == '(')
                                    part_pairs++;
                                else if (ch2 == ')')
                                    part_pairs--;

                                if (ch2 == ')' && part_pairs == 0)//closed parth of squrt
                                    break;
                                counter_2++;
                            }

                            this.SubEquation = this.Equation.Substring(counter_1 + 5 /*4 is an offset*/ , (counter_2-1) - (counter_1+4));//right end
                            
                            break;
                        }
                        counter_1++;
                    }
                    var result = dt.Compute(this.SubEquation, "");//computes string equation
                    result_sub = Convert.ToDouble(result);//computes everything in sqrt
                    result_sub = sqrt(result_sub);//actually takes sqrt of everything inside

                   
                    this.Equation = this.Equation.Replace("Sqrt(" + SubEquation + ")", Convert.ToString(result_sub));//relpaces the sqrt() part of string and replaces it with the value of the actual sqrt()
                    result = dt.Compute(this.Equation, "");
                    Result_Field.Text = orginal_equation + "\n= " + string.Format("{0:N8}",result);//shows the result on text field to 8 decimal places
                    this.Equation = string.Format("{0:N8}", result);//changes string eq to the result
                }

                #endregion

                else
                {
                    var result = dt.Compute(this.Equation, "");//computes string equation
                    Result_Field.Text = this.Equation + "\n= " + string.Format("{0:N8}", result);//shows the result on text field to 8 decimal places
                    this.Equation = string.Format("{0:N8}", result);//changes string eq to the result
                }
            }
            catch (Exception)
            {
                Result_Field.Text = "Syntax Error";
                this.Equation = "";//reseting it
            }

        }

        

        private void Decimal_Button_Click(object sender, EventArgs e)
        {
            this.Equation = this.Equation + ".";
            Result_Field.Text = this.Equation;//string must be reversed;
        }



        private void Parentheses_Button_Click(object sender, EventArgs e)
        {
            int parth_set=0;//counts the number of open parenthses

            //counts the number of open and close parentheses
            foreach (char ch in this.Equation)
            {
                if (ch == '(')
                    parth_set++;
                else if (ch == ')')
                    parth_set--;
                else ;
                    //do nothing
            }

            if (parth_set == 0)
                this.Equation += "(";

            else if (parth_set > 0)
                this.Equation += ")";

            else
                MessageBox.Show("ERROR!!");

            Result_Field.Text = this.Equation;

        }
        
        private void Clear_Button_Click(object sender, EventArgs e)
        {
            this.Equation = "";
            Result_Field.Text = this.Equation;
        }
#endregion

        private void Result_Field_TextChanged(object sender, EventArgs e)
        {
            this.Equation = Result_Field.Text;
        }

        


#endregion


    }
}
