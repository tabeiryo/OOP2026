namespace Section01
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
            Button = new Button();
            label1 = new Label();
            tboutput = new TextBox();
            num1 = new NumericUpDown();
            num2 = new NumericUpDown();
            pbpic = new PictureBox();
            button1 = new Button();
            ofdopen = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)num1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbpic).BeginInit();
            SuspendLayout();
            // 
            // Button
            // 
            Button.Font = new Font("Yu Gothic UI", 18F);
            Button.Location = new Point(317, 196);
            Button.Name = "Button";
            Button.Size = new Size(142, 63);
            Button.TabIndex = 0;
            Button.Text = "ボタン";
            Button.UseVisualStyleBackColor = true;
            Button.Click += Button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 24F);
            label1.Location = new Point(289, 9);
            label1.Name = "label1";
            label1.Size = new Size(188, 45);
            label1.TabIndex = 1;
            label1.Text = "CHAPTER09";
            // 
            // tboutput
            // 
            tboutput.Location = new Point(344, 280);
            tboutput.Name = "tboutput";
            tboutput.Size = new Size(100, 23);
            tboutput.TabIndex = 2;
            // 
            // num1
            // 
            num1.Location = new Point(242, 356);
            num1.Maximum = new decimal(new int[] { -1304428544, 434162106, 542, 0 });
            num1.Name = "num1";
            num1.Size = new Size(120, 23);
            num1.TabIndex = 4;
            // 
            // num2
            // 
            num2.Location = new Point(400, 360);
            num2.Name = "num2";
            num2.Size = new Size(120, 23);
            num2.TabIndex = 5;
            // 
            // pbpic
            // 
            pbpic.Location = new Point(539, 49);
            pbpic.Name = "pbpic";
            pbpic.Size = new Size(347, 309);
            pbpic.TabIndex = 6;
            pbpic.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(670, 364);
            button1.Name = "button1";
            button1.Size = new Size(86, 66);
            button1.TabIndex = 7;
            button1.Text = "open...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ofdopen
            // 
            ofdopen.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 589);
            Controls.Add(button1);
            Controls.Add(pbpic);
            Controls.Add(num2);
            Controls.Add(num1);
            Controls.Add(tboutput);
            Controls.Add(label1);
            Controls.Add(Button);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)num1).EndInit();
            ((System.ComponentModel.ISupportInitialize)num2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbpic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Button;
        private Label label1;
        private TextBox tboutput;
        private NumericUpDown num1;
        private NumericUpDown num2;
        private PictureBox pbpic;
        private Button button1;
        private OpenFileDialog ofdopen;
    }
}
