namespace nimw
{
    partial class Form4
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(598, 68);
            label1.Name = "label1";
            label1.Size = new Size(46, 28);
            label1.TabIndex = 0;
            label1.Text = "اسم";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(598, 127);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 1;
            label2.Text = "سال تولید";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(598, 187);
            label3.Name = "label3";
            label3.Size = new Size(113, 28);
            label3.TabIndex = 2;
            label3.Text = "نوع محصول";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(431, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 34);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(431, 127);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 34);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(431, 187);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 34);
            textBox3.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(629, 364);
            button1.Name = "button1";
            button1.Size = new Size(128, 54);
            button1.TabIndex = 8;
            button1.Text = "ok";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
    }
}