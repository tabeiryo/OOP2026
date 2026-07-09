namespace Exercise01
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
            bt1 = new Button();
            label1 = new Label();
            texbox1 = new TextBox();
            bt2 = new Button();
            texbox2 = new TextBox();
            bt3 = new Button();
            texbox3 = new TextBox();
            SuspendLayout();
            // 
            // bt1
            // 
            bt1.Font = new Font("Yu Gothic UI", 14F);
            bt1.Location = new Point(81, 65);
            bt1.Name = "bt1";
            bt1.Size = new Size(75, 42);
            bt1.TabIndex = 0;
            bt1.Text = "丸1";
            bt1.UseVisualStyleBackColor = true;
            bt1.Click += bt1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(148, 23);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // texbox1
            // 
            texbox1.Location = new Point(195, 80);
            texbox1.Name = "texbox1";
            texbox1.Size = new Size(231, 23);
            texbox1.TabIndex = 2;
            // 
            // bt2
            // 
            bt2.Font = new Font("Yu Gothic UI", 14F);
            bt2.Location = new Point(81, 130);
            bt2.Name = "bt2";
            bt2.Size = new Size(75, 42);
            bt2.TabIndex = 0;
            bt2.Text = "丸2";
            bt2.UseVisualStyleBackColor = true;
            bt2.Click += bt2_Click;
            // 
            // texbox2
            // 
            texbox2.Location = new Point(195, 145);
            texbox2.Name = "texbox2";
            texbox2.Size = new Size(231, 23);
            texbox2.TabIndex = 2;
            // 
            // bt3
            // 
            bt3.Font = new Font("Yu Gothic UI", 14F);
            bt3.Location = new Point(81, 202);
            bt3.Name = "bt3";
            bt3.Size = new Size(75, 42);
            bt3.TabIndex = 0;
            bt3.Text = "丸3";
            bt3.UseVisualStyleBackColor = true;
            bt3.Click += bt3_Click;
            // 
            // texbox3
            // 
            texbox3.Location = new Point(195, 217);
            texbox3.Name = "texbox3";
            texbox3.Size = new Size(231, 23);
            texbox3.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(texbox3);
            Controls.Add(texbox2);
            Controls.Add(bt3);
            Controls.Add(texbox1);
            Controls.Add(bt2);
            Controls.Add(label1);
            Controls.Add(bt1);
            Name = "Form1";
            Text = "問題9,1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt1;
        private Label label1;
        private TextBox texbox1;
        private Button bt2;
        private TextBox texbox2;
        private Button bt3;
        private TextBox texbox3;
    }
}
