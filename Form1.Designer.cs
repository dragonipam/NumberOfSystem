namespace NumberSystem2
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.inputBox2 = new System.Windows.Forms.ComboBox();
            this.inputBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.outBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(68, 54);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(125, 27);
            this.txt1.TabIndex = 0;
            this.txt1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(307, 55);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(125, 27);
            this.txt2.TabIndex = 1;
            this.txt2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt3
            // 
            this.txt3.Enabled = false;
            this.txt3.Location = new System.Drawing.Point(469, 55);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(323, 27);
            this.txt3.TabIndex = 2;
            this.txt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt3.TextChanged += new System.EventHandler(this.txt3_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "="});
            this.comboBox1.Location = new System.Drawing.Point(211, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(79, 28);
            this.comboBox1.TabIndex = 3;
            // 
            // inputBox2
            // 
            this.inputBox2.FormattingEnabled = true;
            this.inputBox2.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "="});
            this.inputBox2.Location = new System.Drawing.Point(353, 97);
            this.inputBox2.Name = "inputBox2";
            this.inputBox2.Size = new System.Drawing.Size(79, 28);
            this.inputBox2.TabIndex = 4;
            // 
            // inputBox1
            // 
            this.inputBox1.FormattingEnabled = true;
            this.inputBox1.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "="});
            this.inputBox1.Location = new System.Drawing.Point(114, 97);
            this.inputBox1.Name = "inputBox1";
            this.inputBox1.Size = new System.Drawing.Size(79, 28);
            this.inputBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Первое значение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Второе значение";
            // 
            // outBox1
            // 
            this.outBox1.FormattingEnabled = true;
            this.outBox1.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "="});
            this.outBox1.Location = new System.Drawing.Point(713, 97);
            this.outBox1.Name = "outBox1";
            this.outBox1.Size = new System.Drawing.Size(79, 28);
            this.outBox1.TabIndex = 8;
            this.outBox1.SelectedIndexChanged += new System.EventHandler(this.onValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(742, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ответ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 320);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.outBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputBox1);
            this.Controls.Add(this.inputBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Name = "Form1";
            this.Text = "Калькулятор систем счисления";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt1;
        private TextBox txt2;
        private TextBox txt3;
        private ComboBox comboBox1;
        private ComboBox inputBox2;
        private ComboBox inputBox1;
        private Label label1;
        private Label label2;
        private ComboBox outBox1;
        private Label label3;
    }
}