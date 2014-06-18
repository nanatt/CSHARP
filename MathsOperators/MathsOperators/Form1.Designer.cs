namespace MathsOperators
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lhsOperand = new System.Windows.Forms.TextBox();
            this.rhsOperand = new System.Windows.Forms.TextBox();
            this.addition = new System.Windows.Forms.RadioButton();
            this.subtraction = new System.Windows.Forms.RadioButton();
            this.multiplication = new System.Windows.Forms.RadioButton();
            this.division = new System.Windows.Forms.RadioButton();
            this.remainder = new System.Windows.Forms.RadioButton();
            this.calculate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.expression = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "left operand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "right operand";
            // 
            // lhsOperand
            // 
            this.lhsOperand.Location = new System.Drawing.Point(12, 29);
            this.lhsOperand.Name = "lhsOperand";
            this.lhsOperand.Size = new System.Drawing.Size(69, 20);
            this.lhsOperand.TabIndex = 2;
            // 
            // rhsOperand
            // 
            this.rhsOperand.Location = new System.Drawing.Point(201, 29);
            this.rhsOperand.Name = "rhsOperand";
            this.rhsOperand.Size = new System.Drawing.Size(79, 20);
            this.rhsOperand.TabIndex = 3;
            // 
            // addition
            // 
            this.addition.AutoSize = true;
            this.addition.Location = new System.Drawing.Point(101, 29);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(72, 17);
            this.addition.TabIndex = 4;
            this.addition.TabStop = true;
            this.addition.Text = "+ Addition";
            this.addition.UseVisualStyleBackColor = true;
            // 
            // subtraction
            // 
            this.subtraction.AutoSize = true;
            this.subtraction.Location = new System.Drawing.Point(101, 52);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(85, 17);
            this.subtraction.TabIndex = 5;
            this.subtraction.TabStop = true;
            this.subtraction.Text = "- Subtraction";
            this.subtraction.UseVisualStyleBackColor = true;
            // 
            // multiplication
            // 
            this.multiplication.AutoSize = true;
            this.multiplication.Location = new System.Drawing.Point(101, 75);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(93, 17);
            this.multiplication.TabIndex = 6;
            this.multiplication.TabStop = true;
            this.multiplication.Text = "* Multiplication";
            this.multiplication.UseVisualStyleBackColor = true;
            // 
            // division
            // 
            this.division.AutoSize = true;
            this.division.Location = new System.Drawing.Point(101, 98);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(70, 17);
            this.division.TabIndex = 7;
            this.division.TabStop = true;
            this.division.Text = "/ Division";
            this.division.UseVisualStyleBackColor = true;
            // 
            // remainder
            // 
            this.remainder.AutoSize = true;
            this.remainder.Location = new System.Drawing.Point(101, 121);
            this.remainder.Name = "remainder";
            this.remainder.Size = new System.Drawing.Size(87, 17);
            this.remainder.TabIndex = 8;
            this.remainder.TabStop = true;
            this.remainder.Text = "% Remainder";
            this.remainder.UseVisualStyleBackColor = true;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(12, 144);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 9;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Expression";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Result";
            // 
            // expression
            // 
            this.expression.Location = new System.Drawing.Point(86, 173);
            this.expression.Name = "expression";
            this.expression.Size = new System.Drawing.Size(100, 20);
            this.expression.TabIndex = 12;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(86, 199);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(149, 20);
            this.result.TabIndex = 13;
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(12, 227);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(75, 23);
            this.quit.TabIndex = 14;
            this.quit.Text = "Quit";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.result);
            this.Controls.Add(this.expression);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.remainder);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.subtraction);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.rhsOperand);
            this.Controls.Add(this.lhsOperand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "MathsOperators";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lhsOperand;
        private System.Windows.Forms.TextBox rhsOperand;
        private System.Windows.Forms.RadioButton addition;
        private System.Windows.Forms.RadioButton subtraction;
        private System.Windows.Forms.RadioButton multiplication;
        private System.Windows.Forms.RadioButton division;
        private System.Windows.Forms.RadioButton remainder;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox expression;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button quit;
    }
}

