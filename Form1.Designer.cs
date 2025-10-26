namespace SimpleCalculatorApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDisplay = new TextBox();
            btn0 = new Button();
            button2 = new Button();
            button3 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            lblCredit = new Label();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.BorderStyle = BorderStyle.None;
            txtDisplay.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtDisplay.Location = new Point(66, 44);
            txtDisplay.Margin = new Padding(4, 5, 4, 5);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(430, 81);
            txtDisplay.TabIndex = 0;
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // btn0
            // 
            btn0.BackColor = Color.WhiteSmoke;
            btn0.FlatAppearance.BorderColor = Color.LightGray;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn0.Location = new Point(66, 520);
            btn0.Margin = new Padding(4, 5, 4, 5);
            btn0.Name = "btn0";
            btn0.Size = new Size(90, 84);
            btn0.TabIndex = 1;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += Number_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.Location = new Point(173, 520);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(90, 84);
            button2.TabIndex = 2;
            button2.Text = ",";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Comma_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.BlueViolet;
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(378, 517);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(122, 87);
            button3.TabIndex = 22;
            button3.Text = "=";
            button3.UseVisualStyleBackColor = false;
            button3.Click += Equal_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.WhiteSmoke;
            btn1.FlatAppearance.BorderColor = Color.LightGray;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn1.Location = new Point(66, 426);
            btn1.Margin = new Padding(4, 5, 4, 5);
            btn1.Name = "btn1";
            btn1.Size = new Size(90, 84);
            btn1.TabIndex = 4;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += Number_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.WhiteSmoke;
            btn2.FlatAppearance.BorderColor = Color.LightGray;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn2.Location = new Point(173, 426);
            btn2.Margin = new Padding(4, 5, 4, 5);
            btn2.Name = "btn2";
            btn2.Size = new Size(90, 84);
            btn2.TabIndex = 5;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += Number_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.WhiteSmoke;
            btn3.FlatAppearance.BorderColor = Color.LightGray;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn3.Location = new Point(280, 426);
            btn3.Margin = new Padding(4, 5, 4, 5);
            btn3.Name = "btn3";
            btn3.Size = new Size(90, 84);
            btn3.TabIndex = 6;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += Number_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.WhiteSmoke;
            btn4.FlatAppearance.BorderColor = Color.LightGray;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn4.Location = new Point(66, 332);
            btn4.Margin = new Padding(4, 5, 4, 5);
            btn4.Name = "btn4";
            btn4.Size = new Size(90, 84);
            btn4.TabIndex = 7;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += Number_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.WhiteSmoke;
            btn5.FlatAppearance.BorderColor = Color.LightGray;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn5.Location = new Point(173, 332);
            btn5.Margin = new Padding(4, 5, 4, 5);
            btn5.Name = "btn5";
            btn5.Size = new Size(90, 84);
            btn5.TabIndex = 8;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += Number_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.WhiteSmoke;
            btn6.FlatAppearance.BorderColor = Color.LightGray;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn6.Location = new Point(280, 332);
            btn6.Margin = new Padding(4, 5, 4, 5);
            btn6.Name = "btn6";
            btn6.Size = new Size(90, 84);
            btn6.TabIndex = 9;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += Number_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.WhiteSmoke;
            btn7.FlatAppearance.BorderColor = Color.LightGray;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn7.Location = new Point(66, 238);
            btn7.Margin = new Padding(4, 5, 4, 5);
            btn7.Name = "btn7";
            btn7.Size = new Size(90, 84);
            btn7.TabIndex = 21;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += Number_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.WhiteSmoke;
            btn8.FlatAppearance.BorderColor = Color.LightGray;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn8.Location = new Point(173, 238);
            btn8.Margin = new Padding(4, 5, 4, 5);
            btn8.Name = "btn8";
            btn8.Size = new Size(90, 84);
            btn8.TabIndex = 11;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += Number_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.WhiteSmoke;
            btn9.FlatAppearance.BorderColor = Color.LightGray;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn9.Location = new Point(280, 235);
            btn9.Margin = new Padding(4, 5, 4, 5);
            btn9.Name = "btn9";
            btn9.Size = new Size(90, 84);
            btn9.TabIndex = 12;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += Number_Click;
            // 
            // button13
            // 
            button13.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button13.Location = new Point(394, 135);
            button13.Margin = new Padding(4, 5, 4, 5);
            button13.Name = "button13";
            button13.Size = new Size(102, 87);
            button13.TabIndex = 13;
            button13.Text = "/";
            button13.UseVisualStyleBackColor = true;
            button13.Click += Operator_Click;
            // 
            // button14
            // 
            button14.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button14.Location = new Point(394, 232);
            button14.Margin = new Padding(4, 5, 4, 5);
            button14.Name = "button14";
            button14.Size = new Size(102, 87);
            button14.TabIndex = 14;
            button14.Text = "x";
            button14.UseVisualStyleBackColor = true;
            button14.Click += Operator_Click;
            // 
            // button15
            // 
            button15.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button15.Location = new Point(394, 323);
            button15.Margin = new Padding(4, 5, 4, 5);
            button15.Name = "button15";
            button15.Size = new Size(102, 87);
            button15.TabIndex = 15;
            button15.Text = "-";
            button15.UseVisualStyleBackColor = true;
            button15.Click += Operator_Click;
            // 
            // button16
            // 
            button16.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button16.Location = new Point(394, 417);
            button16.Margin = new Padding(4, 5, 4, 5);
            button16.Name = "button16";
            button16.Size = new Size(102, 87);
            button16.TabIndex = 16;
            button16.Text = "+";
            button16.UseVisualStyleBackColor = true;
            button16.Click += Operator_Click;
            // 
            // button17
            // 
            button17.BackColor = Color.LightGray;
            button17.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button17.Location = new Point(280, 135);
            button17.Margin = new Padding(4, 5, 4, 5);
            button17.Name = "button17";
            button17.Size = new Size(90, 87);
            button17.TabIndex = 17;
            button17.Text = "pi";
            button17.UseVisualStyleBackColor = false;
            button17.Click += Pi_Click;
            // 
            // button18
            // 
            button18.BackColor = Color.LightCoral;
            button18.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button18.ForeColor = Color.White;
            button18.Location = new Point(173, 135);
            button18.Margin = new Padding(4, 5, 4, 5);
            button18.Name = "button18";
            button18.Size = new Size(90, 87);
            button18.TabIndex = 18;
            button18.Text = "AC";
            button18.UseVisualStyleBackColor = false;
            button18.Click += Clear_Click;
            // 
            // button19
            // 
            button19.BackColor = Color.Black;
            button19.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button19.ForeColor = SystemColors.Control;
            button19.Location = new Point(66, 135);
            button19.Margin = new Padding(4, 5, 4, 5);
            button19.Name = "button19";
            button19.Size = new Size(90, 87);
            button19.TabIndex = 19;
            button19.Text = "<-";
            button19.UseVisualStyleBackColor = false;
            button19.Click += Backspace_Click;
            // 
            // button20
            // 
            button20.BackColor = Color.LightGray;
            button20.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button20.Location = new Point(280, 520);
            button20.Margin = new Padding(4, 5, 4, 5);
            button20.Name = "button20";
            button20.Size = new Size(90, 84);
            button20.TabIndex = 20;
            button20.Text = "+/-";
            button20.UseVisualStyleBackColor = false;
            button20.Click += Negate_Click;
            // 
            // lblCredit
            // 
            lblCredit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblCredit.AutoSize = true;
            lblCredit.Cursor = Cursors.Hand;
            lblCredit.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            lblCredit.ForeColor = Color.DimGray;
            lblCredit.Location = new Point(273, 627);
            lblCredit.Name = "lblCredit";
            lblCredit.Size = new Size(223, 23);
            lblCredit.TabIndex = 23;
            lblCredit.Text = "Developed by Umut Albayrak";
            lblCredit.Click += lblCredit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(569, 697);
            Controls.Add(lblCredit);
            Controls.Add(button20);
            Controls.Add(button19);
            Controls.Add(button18);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btn0);
            Controls.Add(txtDisplay);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simple Calculator — Umut Albayrak";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btn0;
        private Button button2;
        private Button button3;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
        private Label lblCredit;
    }
}
