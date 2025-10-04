namespace LMS_AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button2 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(314, 240);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter your Username";
            textBox1.Size = new Size(464, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(314, 295);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Enter your Password";
            textBox2.Size = new Size(464, 27);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(438, 371);
            button1.Name = "button1";
            button1.Size = new Size(195, 43);
            button1.TabIndex = 2;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(66, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(709, 70);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua Titling MT", 25F, FontStyle.Italic);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(101, 11);
            label1.Name = "label1";
            label1.Size = new Size(466, 49);
            label1.TabIndex = 0;
            label1.Text = "ADMIN LOG-IN FORM";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(button2);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox4);
            panel2.Location = new Point(66, 109);
            panel2.Name = "panel2";
            panel2.Size = new Size(709, 314);
            panel2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.GradientInactiveCaption;
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.Location = new Point(113, 55);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Enter your Username";
            textBox3.Size = new Size(464, 34);
            textBox3.TabIndex = 0;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.GradientInactiveCaption;
            textBox4.Font = new Font("Segoe UI", 12F);
            textBox4.Location = new Point(113, 110);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Enter your Password";
            textBox4.Size = new Size(464, 34);
            textBox4.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.Font = new Font("Segoe UI", 11F);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(231, 186);
            button2.Name = "button2";
            button2.Size = new Size(195, 43);
            button2.TabIndex = 2;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button button2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}
