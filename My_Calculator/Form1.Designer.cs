namespace My_First_GUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.Negate_Button = new System.Windows.Forms.Button();
            this.Square_Root_Button = new System.Windows.Forms.Button();
            this.Num7_Button = new System.Windows.Forms.Button();
            this.Num8_Button = new System.Windows.Forms.Button();
            this.Num9_Button = new System.Windows.Forms.Button();
            this.Divide_Button = new System.Windows.Forms.Button();
            this.Modulus_Button = new System.Windows.Forms.Button();
            this.Num4_Button = new System.Windows.Forms.Button();
            this.Num5_Button = new System.Windows.Forms.Button();
            this.Num6_Button = new System.Windows.Forms.Button();
            this.Multiply_Button = new System.Windows.Forms.Button();
            this.Invert_Button = new System.Windows.Forms.Button();
            this.Num1_Button = new System.Windows.Forms.Button();
            this.Num2_Button = new System.Windows.Forms.Button();
            this.Num3_Button = new System.Windows.Forms.Button();
            this.Subtract_Button = new System.Windows.Forms.Button();
            this.Equals_Button = new System.Windows.Forms.Button();
            this.Num0_Button = new System.Windows.Forms.Button();
            this.Decimal_Button = new System.Windows.Forms.Button();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Result_Field = new System.Windows.Forms.RichTextBox();
            this.Parentheses_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Delete_Button
            // 
            this.Delete_Button.Location = new System.Drawing.Point(9, 84);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(41, 35);
            this.Delete_Button.TabIndex = 0;
            this.Delete_Button.Text = "DEL";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Clear_Button
            // 
            this.Clear_Button.Location = new System.Drawing.Point(56, 84);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(41, 35);
            this.Clear_Button.TabIndex = 2;
            this.Clear_Button.Text = "C";
            this.Clear_Button.UseVisualStyleBackColor = true;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // Negate_Button
            // 
            this.Negate_Button.Location = new System.Drawing.Point(150, 84);
            this.Negate_Button.Name = "Negate_Button";
            this.Negate_Button.Size = new System.Drawing.Size(41, 35);
            this.Negate_Button.TabIndex = 3;
            this.Negate_Button.Text = "  +    -";
            this.Negate_Button.UseVisualStyleBackColor = true;
            this.Negate_Button.Click += new System.EventHandler(this.Negate_Button_Click);
            // 
            // Square_Root_Button
            // 
            this.Square_Root_Button.Location = new System.Drawing.Point(197, 84);
            this.Square_Root_Button.Name = "Square_Root_Button";
            this.Square_Root_Button.Size = new System.Drawing.Size(41, 35);
            this.Square_Root_Button.TabIndex = 4;
            this.Square_Root_Button.Text = "Sqrt()\r\n";
            this.Square_Root_Button.UseVisualStyleBackColor = true;
            this.Square_Root_Button.Click += new System.EventHandler(this.Square_Root_Button_Click);
            // 
            // Num7_Button
            // 
            this.Num7_Button.Location = new System.Drawing.Point(9, 125);
            this.Num7_Button.Name = "Num7_Button";
            this.Num7_Button.Size = new System.Drawing.Size(41, 35);
            this.Num7_Button.TabIndex = 5;
            this.Num7_Button.Text = "7";
            this.Num7_Button.UseVisualStyleBackColor = true;
            this.Num7_Button.Click += new System.EventHandler(this.Num7_Button_Click);
            // 
            // Num8_Button
            // 
            this.Num8_Button.Location = new System.Drawing.Point(56, 125);
            this.Num8_Button.Name = "Num8_Button";
            this.Num8_Button.Size = new System.Drawing.Size(41, 35);
            this.Num8_Button.TabIndex = 6;
            this.Num8_Button.Text = "8";
            this.Num8_Button.UseVisualStyleBackColor = true;
            this.Num8_Button.Click += new System.EventHandler(this.Num8_Button_Click);
            // 
            // Num9_Button
            // 
            this.Num9_Button.Location = new System.Drawing.Point(103, 125);
            this.Num9_Button.Name = "Num9_Button";
            this.Num9_Button.Size = new System.Drawing.Size(41, 35);
            this.Num9_Button.TabIndex = 7;
            this.Num9_Button.Text = "9";
            this.Num9_Button.UseVisualStyleBackColor = true;
            this.Num9_Button.Click += new System.EventHandler(this.Num9_Button_Click);
            // 
            // Divide_Button
            // 
            this.Divide_Button.Location = new System.Drawing.Point(150, 125);
            this.Divide_Button.Name = "Divide_Button";
            this.Divide_Button.Size = new System.Drawing.Size(41, 35);
            this.Divide_Button.TabIndex = 8;
            this.Divide_Button.Text = "/";
            this.Divide_Button.UseVisualStyleBackColor = true;
            this.Divide_Button.Click += new System.EventHandler(this.Divide_Button_Click);
            // 
            // Modulus_Button
            // 
            this.Modulus_Button.Location = new System.Drawing.Point(197, 125);
            this.Modulus_Button.Name = "Modulus_Button";
            this.Modulus_Button.Size = new System.Drawing.Size(41, 35);
            this.Modulus_Button.TabIndex = 9;
            this.Modulus_Button.Text = "%";
            this.Modulus_Button.UseVisualStyleBackColor = true;
            this.Modulus_Button.Click += new System.EventHandler(this.Modulus_Button_Click);
            // 
            // Num4_Button
            // 
            this.Num4_Button.Location = new System.Drawing.Point(9, 166);
            this.Num4_Button.Name = "Num4_Button";
            this.Num4_Button.Size = new System.Drawing.Size(41, 35);
            this.Num4_Button.TabIndex = 10;
            this.Num4_Button.Text = "4";
            this.Num4_Button.UseVisualStyleBackColor = true;
            this.Num4_Button.Click += new System.EventHandler(this.Num4_Button_Click);
            // 
            // Num5_Button
            // 
            this.Num5_Button.Location = new System.Drawing.Point(56, 166);
            this.Num5_Button.Name = "Num5_Button";
            this.Num5_Button.Size = new System.Drawing.Size(41, 35);
            this.Num5_Button.TabIndex = 11;
            this.Num5_Button.Text = "5";
            this.Num5_Button.UseVisualStyleBackColor = true;
            this.Num5_Button.Click += new System.EventHandler(this.Num5_Button_Click);
            // 
            // Num6_Button
            // 
            this.Num6_Button.Location = new System.Drawing.Point(103, 166);
            this.Num6_Button.Name = "Num6_Button";
            this.Num6_Button.Size = new System.Drawing.Size(41, 35);
            this.Num6_Button.TabIndex = 12;
            this.Num6_Button.Text = "6";
            this.Num6_Button.UseVisualStyleBackColor = true;
            this.Num6_Button.Click += new System.EventHandler(this.Num6_Button_Click);
            // 
            // Multiply_Button
            // 
            this.Multiply_Button.Location = new System.Drawing.Point(150, 166);
            this.Multiply_Button.Name = "Multiply_Button";
            this.Multiply_Button.Size = new System.Drawing.Size(41, 35);
            this.Multiply_Button.TabIndex = 13;
            this.Multiply_Button.Text = "*";
            this.Multiply_Button.UseVisualStyleBackColor = true;
            this.Multiply_Button.Click += new System.EventHandler(this.Multiply_Button_Click);
            // 
            // Invert_Button
            // 
            this.Invert_Button.Location = new System.Drawing.Point(197, 166);
            this.Invert_Button.Name = "Invert_Button";
            this.Invert_Button.Size = new System.Drawing.Size(41, 35);
            this.Invert_Button.TabIndex = 14;
            this.Invert_Button.Text = "1/x";
            this.Invert_Button.UseVisualStyleBackColor = true;
            this.Invert_Button.Click += new System.EventHandler(this.Invert_Button_Click);
            // 
            // Num1_Button
            // 
            this.Num1_Button.Location = new System.Drawing.Point(9, 207);
            this.Num1_Button.Name = "Num1_Button";
            this.Num1_Button.Size = new System.Drawing.Size(41, 35);
            this.Num1_Button.TabIndex = 15;
            this.Num1_Button.Text = "1";
            this.Num1_Button.UseVisualStyleBackColor = true;
            this.Num1_Button.Click += new System.EventHandler(this.Num1_Button_Click);
            // 
            // Num2_Button
            // 
            this.Num2_Button.Location = new System.Drawing.Point(56, 207);
            this.Num2_Button.Name = "Num2_Button";
            this.Num2_Button.Size = new System.Drawing.Size(41, 35);
            this.Num2_Button.TabIndex = 16;
            this.Num2_Button.Text = "2";
            this.Num2_Button.UseVisualStyleBackColor = true;
            this.Num2_Button.Click += new System.EventHandler(this.Num2_Button_Click);
            // 
            // Num3_Button
            // 
            this.Num3_Button.Location = new System.Drawing.Point(103, 207);
            this.Num3_Button.Name = "Num3_Button";
            this.Num3_Button.Size = new System.Drawing.Size(41, 35);
            this.Num3_Button.TabIndex = 17;
            this.Num3_Button.Text = "3";
            this.Num3_Button.UseVisualStyleBackColor = true;
            this.Num3_Button.Click += new System.EventHandler(this.Num3_Button_Click);
            // 
            // Subtract_Button
            // 
            this.Subtract_Button.Location = new System.Drawing.Point(150, 207);
            this.Subtract_Button.Name = "Subtract_Button";
            this.Subtract_Button.Size = new System.Drawing.Size(41, 35);
            this.Subtract_Button.TabIndex = 18;
            this.Subtract_Button.Text = "-";
            this.Subtract_Button.UseVisualStyleBackColor = true;
            this.Subtract_Button.Click += new System.EventHandler(this.Subtract_Button_Click);
            // 
            // Equals_Button
            // 
            this.Equals_Button.Location = new System.Drawing.Point(197, 207);
            this.Equals_Button.Name = "Equals_Button";
            this.Equals_Button.Size = new System.Drawing.Size(41, 76);
            this.Equals_Button.TabIndex = 19;
            this.Equals_Button.Text = "=";
            this.Equals_Button.UseVisualStyleBackColor = true;
            this.Equals_Button.Click += new System.EventHandler(this.Equals_Button_Click);
            // 
            // Num0_Button
            // 
            this.Num0_Button.Location = new System.Drawing.Point(9, 248);
            this.Num0_Button.Name = "Num0_Button";
            this.Num0_Button.Size = new System.Drawing.Size(85, 35);
            this.Num0_Button.TabIndex = 20;
            this.Num0_Button.Text = "0";
            this.Num0_Button.UseVisualStyleBackColor = true;
            this.Num0_Button.Click += new System.EventHandler(this.Num0_Button_Click);
            // 
            // Decimal_Button
            // 
            this.Decimal_Button.Location = new System.Drawing.Point(103, 248);
            this.Decimal_Button.Name = "Decimal_Button";
            this.Decimal_Button.Size = new System.Drawing.Size(41, 35);
            this.Decimal_Button.TabIndex = 22;
            this.Decimal_Button.Text = ".";
            this.Decimal_Button.UseVisualStyleBackColor = true;
            this.Decimal_Button.Click += new System.EventHandler(this.Decimal_Button_Click);
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(150, 248);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(41, 35);
            this.Add_Button.TabIndex = 23;
            this.Add_Button.Text = "+";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Result_Field
            // 
            this.Result_Field.BackColor = System.Drawing.SystemColors.WindowText;
            this.Result_Field.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Result_Field.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result_Field.ForeColor = System.Drawing.SystemColors.Info;
            this.Result_Field.Location = new System.Drawing.Point(9, 12);
            this.Result_Field.Name = "Result_Field";
            this.Result_Field.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Result_Field.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Result_Field.Size = new System.Drawing.Size(228, 66);
            this.Result_Field.TabIndex = 24;
            this.Result_Field.Text = "";
            this.Result_Field.TextChanged += new System.EventHandler(this.Result_Field_TextChanged);
            // 
            // Parentheses_Button
            // 
            this.Parentheses_Button.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Parentheses_Button.Location = new System.Drawing.Point(103, 84);
            this.Parentheses_Button.Name = "Parentheses_Button";
            this.Parentheses_Button.Size = new System.Drawing.Size(41, 35);
            this.Parentheses_Button.TabIndex = 25;
            this.Parentheses_Button.Text = "( )";
            this.Parentheses_Button.UseVisualStyleBackColor = true;
            this.Parentheses_Button.Click += new System.EventHandler(this.Parentheses_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 293);
            this.Controls.Add(this.Parentheses_Button);
            this.Controls.Add(this.Result_Field);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.Decimal_Button);
            this.Controls.Add(this.Num0_Button);
            this.Controls.Add(this.Equals_Button);
            this.Controls.Add(this.Subtract_Button);
            this.Controls.Add(this.Num3_Button);
            this.Controls.Add(this.Num2_Button);
            this.Controls.Add(this.Num1_Button);
            this.Controls.Add(this.Invert_Button);
            this.Controls.Add(this.Multiply_Button);
            this.Controls.Add(this.Num6_Button);
            this.Controls.Add(this.Num5_Button);
            this.Controls.Add(this.Num4_Button);
            this.Controls.Add(this.Modulus_Button);
            this.Controls.Add(this.Divide_Button);
            this.Controls.Add(this.Num9_Button);
            this.Controls.Add(this.Num8_Button);
            this.Controls.Add(this.Num7_Button);
            this.Controls.Add(this.Square_Root_Button);
            this.Controls.Add(this.Negate_Button);
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.Delete_Button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Button Clear_Button;
        private System.Windows.Forms.Button Negate_Button;
        private System.Windows.Forms.Button Square_Root_Button;
        private System.Windows.Forms.Button Num7_Button;
        private System.Windows.Forms.Button Num8_Button;
        private System.Windows.Forms.Button Num9_Button;
        private System.Windows.Forms.Button Divide_Button;
        private System.Windows.Forms.Button Modulus_Button;
        private System.Windows.Forms.Button Num4_Button;
        private System.Windows.Forms.Button Num5_Button;
        private System.Windows.Forms.Button Num6_Button;
        private System.Windows.Forms.Button Multiply_Button;
        private System.Windows.Forms.Button Invert_Button;
        private System.Windows.Forms.Button Num1_Button;
        private System.Windows.Forms.Button Num2_Button;
        private System.Windows.Forms.Button Num3_Button;
        private System.Windows.Forms.Button Subtract_Button;
        private System.Windows.Forms.Button Equals_Button;
        private System.Windows.Forms.Button Num0_Button;
        private System.Windows.Forms.Button Decimal_Button;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.RichTextBox Result_Field;
        private System.Windows.Forms.Button Parentheses_Button;

    }
}

