namespace CarReportSystem
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
            label1 = new Label();
            dtpdate = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            rbtoyota = new RadioButton();
            arcive = new ComboBox();
            rbnissan = new RadioButton();
            rbhonda = new RadioButton();
            rbsubaru = new RadioButton();
            rbgaisya = new RadioButton();
            rbsonota = new RadioButton();
            groupBox1 = new GroupBox();
            carname = new ComboBox();
            label6 = new Label();
            GridViueRecords = new DataGridView();
            texbox1 = new TextBox();
            label7 = new Label();
            button1 = new Button();
            btDELpig = new Button();
            btADD = new Button();
            btDELrec = new Button();
            bt1 = new Button();
            pictureBox1 = new PictureBox();
            button6 = new Button();
            btModefighRecords = new Button();
            menuStrip1 = new MenuStrip();
            ファイルFToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripSeparator3 = new ToolStripSeparator();
            開くToolStripMenuItem = new ToolStripMenuItem();
            保存ToolStripMenuItem = new ToolStripMenuItem();
            色設定ToolStripMenuItem = new ToolStripMenuItem();
            終了ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            ヘルプHToolStripMenuItem = new ToolStripMenuItem();
            このアプリについてToolStripMenuItem = new ToolStripMenuItem();
            btOPENpig = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridViueRecords).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 12F);
            label1.Location = new Point(20, 53);
            label1.Name = "label1";
            label1.Size = new Size(42, 21);
            label1.TabIndex = 0;
            label1.Text = "日付";
            // 
            // dtpdate
            // 
            dtpdate.Font = new Font("Yu Gothic UI", 12F);
            dtpdate.Location = new Point(73, 45);
            dtpdate.Name = "dtpdate";
            dtpdate.Size = new Size(200, 29);
            dtpdate.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 12F);
            label2.Location = new Point(9, 100);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 0;
            label2.Text = "記録者";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 12F);
            label3.Location = new Point(9, 150);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 0;
            label3.Text = "メーカー";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 12F);
            label4.Location = new Point(20, 199);
            label4.Name = "label4";
            label4.Size = new Size(42, 21);
            label4.TabIndex = 0;
            label4.Text = "車名";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 12F);
            label5.Location = new Point(7, 238);
            label5.Name = "label5";
            label5.Size = new Size(55, 21);
            label5.TabIndex = 0;
            label5.Text = "レポート";
            // 
            // rbtoyota
            // 
            rbtoyota.AutoSize = true;
            rbtoyota.Location = new Point(0, 23);
            rbtoyota.Name = "rbtoyota";
            rbtoyota.Size = new Size(50, 19);
            rbtoyota.TabIndex = 2;
            rbtoyota.TabStop = true;
            rbtoyota.Text = "トヨタ";
            rbtoyota.UseVisualStyleBackColor = true;
            // 
            // arcive
            // 
            arcive.Font = new Font("Yu Gothic UI", 11F);
            arcive.FormattingEnabled = true;
            arcive.Location = new Point(73, 93);
            arcive.Name = "arcive";
            arcive.Size = new Size(121, 28);
            arcive.TabIndex = 3;
            // 
            // rbnissan
            // 
            rbnissan.AutoSize = true;
            rbnissan.Location = new Point(56, 23);
            rbnissan.Name = "rbnissan";
            rbnissan.Size = new Size(49, 19);
            rbnissan.TabIndex = 2;
            rbnissan.TabStop = true;
            rbnissan.Text = "日産";
            rbnissan.UseVisualStyleBackColor = true;
            // 
            // rbhonda
            // 
            rbhonda.AutoSize = true;
            rbhonda.Location = new Point(111, 23);
            rbhonda.Name = "rbhonda";
            rbhonda.Size = new Size(53, 19);
            rbhonda.TabIndex = 2;
            rbhonda.TabStop = true;
            rbhonda.Text = "ホンダ";
            rbhonda.UseVisualStyleBackColor = true;
            // 
            // rbsubaru
            // 
            rbsubaru.AutoSize = true;
            rbsubaru.Location = new Point(170, 23);
            rbsubaru.Name = "rbsubaru";
            rbsubaru.Size = new Size(54, 19);
            rbsubaru.TabIndex = 2;
            rbsubaru.TabStop = true;
            rbsubaru.Text = "スバル";
            rbsubaru.UseVisualStyleBackColor = true;
            // 
            // rbgaisya
            // 
            rbgaisya.AutoSize = true;
            rbgaisya.Location = new Point(230, 23);
            rbgaisya.Name = "rbgaisya";
            rbgaisya.Size = new Size(49, 19);
            rbgaisya.TabIndex = 2;
            rbgaisya.TabStop = true;
            rbgaisya.Text = "外車";
            rbgaisya.UseVisualStyleBackColor = true;
            // 
            // rbsonota
            // 
            rbsonota.AutoSize = true;
            rbsonota.Location = new Point(276, 23);
            rbsonota.Name = "rbsonota";
            rbsonota.Size = new Size(56, 19);
            rbsonota.TabIndex = 2;
            rbsonota.TabStop = true;
            rbsonota.Text = "その他";
            rbsonota.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtoyota);
            groupBox1.Controls.Add(rbnissan);
            groupBox1.Controls.Add(rbsonota);
            groupBox1.Controls.Add(rbhonda);
            groupBox1.Controls.Add(rbgaisya);
            groupBox1.Controls.Add(rbsubaru);
            groupBox1.Location = new Point(68, 127);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(364, 56);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // carname
            // 
            carname.Font = new Font("Yu Gothic UI", 11F);
            carname.FormattingEnabled = true;
            carname.Location = new Point(73, 192);
            carname.Name = "carname";
            carname.Size = new Size(225, 28);
            carname.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 12F);
            label6.Location = new Point(7, 437);
            label6.Name = "label6";
            label6.Size = new Size(74, 21);
            label6.TabIndex = 0;
            label6.Text = "記事一覧";
            label6.Click += label6_Click;
            // 
            // GridViueRecords
            // 
            GridViueRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridViueRecords.Location = new Point(79, 437);
            GridViueRecords.Name = "GridViueRecords";
            GridViueRecords.Size = new Size(650, 180);
            GridViueRecords.TabIndex = 5;
            // 
            // texbox1
            // 
            texbox1.Location = new Point(79, 240);
            texbox1.Multiline = true;
            texbox1.Name = "texbox1";
            texbox1.Size = new Size(252, 172);
            texbox1.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 12F);
            label7.Location = new Point(419, 69);
            label7.Name = "label7";
            label7.Size = new Size(42, 21);
            label7.TabIndex = 0;
            label7.Text = "画像";
            label7.Click += label7_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Chartreuse;
            button1.Location = new Point(-2, 518);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "開く";
            button1.UseVisualStyleBackColor = false;
            // 
            // btDELpig
            // 
            btDELpig.BackColor = Color.Gold;
            btDELpig.Font = new Font("Yu Gothic UI", 15F);
            btDELpig.ForeColor = Color.Crimson;
            btDELpig.Location = new Point(605, 70);
            btDELpig.Name = "btDELpig";
            btDELpig.Size = new Size(87, 42);
            btDELpig.TabIndex = 7;
            btDELpig.Text = "削除";
            btDELpig.UseVisualStyleBackColor = false;
            // 
            // btADD
            // 
            btADD.BackColor = SystemColors.Highlight;
            btADD.ForeColor = Color.Cornsilk;
            btADD.Location = new Point(476, 397);
            btADD.Name = "btADD";
            btADD.Size = new Size(75, 34);
            btADD.TabIndex = 7;
            btADD.Text = "追加";
            btADD.UseVisualStyleBackColor = false;
            // 
            // btDELrec
            // 
            btDELrec.BackColor = Color.Crimson;
            btDELrec.Font = new Font("Yu Gothic UI", 10F);
            btDELrec.ForeColor = Color.FloralWhite;
            btDELrec.Location = new Point(671, 397);
            btDELrec.Name = "btDELrec";
            btDELrec.Size = new Size(75, 27);
            btDELrec.TabIndex = 7;
            btDELrec.Text = "削除";
            btDELrec.UseVisualStyleBackColor = false;
            // 
            // bt1
            // 
            bt1.BackColor = Color.Cornsilk;
            bt1.Font = new Font("Yu Gothic UI", 15F);
            bt1.ForeColor = Color.DarkBlue;
            bt1.Location = new Point(316, 32);
            bt1.Name = "bt1";
            bt1.Size = new Size(84, 42);
            bt1.TabIndex = 7;
            bt1.Text = "新規";
            bt1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(455, 118);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(274, 236);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // button6
            // 
            button6.Location = new Point(-2, 562);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 7;
            button6.Text = "保存";
            button6.UseVisualStyleBackColor = true;
            // 
            // btModefighRecords
            // 
            btModefighRecords.BackColor = Color.DarkMagenta;
            btModefighRecords.ForeColor = Color.DarkGreen;
            btModefighRecords.Location = new Point(557, 397);
            btModefighRecords.Name = "btModefighRecords";
            btModefighRecords.Size = new Size(75, 34);
            btModefighRecords.TabIndex = 7;
            btModefighRecords.Text = "修正";
            btModefighRecords.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ファイルFToolStripMenuItem, ヘルプHToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            ファイルFToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator1, toolStripSeparator3, 開くToolStripMenuItem, 保存ToolStripMenuItem, 色設定ToolStripMenuItem, 終了ToolStripMenuItem, toolStripSeparator2 });
            ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            ファイルFToolStripMenuItem.Size = new Size(79, 20);
            ファイルFToolStripMenuItem.Text = "ファイル＆(F)";
            ファイルFToolStripMenuItem.Click += ファイルFToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(177, 6);
            // 
            // 開くToolStripMenuItem
            // 
            開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            開くToolStripMenuItem.Size = new Size(180, 22);
            開くToolStripMenuItem.Text = "開く...";
            // 
            // 保存ToolStripMenuItem
            // 
            保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            保存ToolStripMenuItem.Size = new Size(180, 22);
            保存ToolStripMenuItem.Text = "保存...";
            // 
            // 色設定ToolStripMenuItem
            // 
            色設定ToolStripMenuItem.Name = "色設定ToolStripMenuItem";
            色設定ToolStripMenuItem.Size = new Size(180, 22);
            色設定ToolStripMenuItem.Text = "色設定";
            // 
            // 終了ToolStripMenuItem
            // 
            終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            終了ToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            終了ToolStripMenuItem.Size = new Size(180, 22);
            終了ToolStripMenuItem.Text = "終了&(x)";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(177, 6);
            // 
            // ヘルプHToolStripMenuItem
            // 
            ヘルプHToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { このアプリについてToolStripMenuItem });
            ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
            ヘルプHToolStripMenuItem.Size = new Size(65, 20);
            ヘルプHToolStripMenuItem.Text = "ヘルプ(H)";
            // 
            // このアプリについてToolStripMenuItem
            // 
            このアプリについてToolStripMenuItem.Name = "このアプリについてToolStripMenuItem";
            このアプリについてToolStripMenuItem.Size = new Size(180, 22);
            このアプリについてToolStripMenuItem.Text = "このアプリについて";
            // 
            // btOPENpig
            // 
            btOPENpig.BackColor = Color.DarkOrange;
            btOPENpig.Font = new Font("Yu Gothic UI", 15F);
            btOPENpig.ForeColor = Color.Cyan;
            btOPENpig.Location = new Point(515, 70);
            btOPENpig.Name = "btOPENpig";
            btOPENpig.Size = new Size(84, 42);
            btOPENpig.TabIndex = 7;
            btOPENpig.Text = "開く";
            btOPENpig.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 622);
            Controls.Add(pictureBox1);
            Controls.Add(btOPENpig);
            Controls.Add(bt1);
            Controls.Add(btDELpig);
            Controls.Add(btDELrec);
            Controls.Add(btModefighRecords);
            Controls.Add(btADD);
            Controls.Add(button6);
            Controls.Add(button1);
            Controls.Add(texbox1);
            Controls.Add(GridViueRecords);
            Controls.Add(groupBox1);
            Controls.Add(carname);
            Controls.Add(arcive);
            Controls.Add(dtpdate);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "市場レポート管理システム";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridViueRecords).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpdate;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private RadioButton rbtoyota;
        private ComboBox arcive;
        private RadioButton rbnissan;
        private RadioButton rbhonda;
        private RadioButton rbsubaru;
        private RadioButton rbgaisya;
        private RadioButton rbsonota;
        private GroupBox groupBox1;
        private ComboBox carname;
        private Label label6;
        private DataGridView GridViueRecords;
        private TextBox texbox1;
        private Label label7;
        private Button button1;
        private Button btDELpig;
        private Button btADD;
        private Button btDELrec;
        private Button bt1;
        private PictureBox pictureBox1;
        private Button button6;
        private Button btModefighRecords;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ファイルFToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem 開くToolStripMenuItem;
        private ToolStripMenuItem 保存ToolStripMenuItem;
        private ToolStripMenuItem 色設定ToolStripMenuItem;
        private ToolStripMenuItem 終了ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem ヘルプHToolStripMenuItem;
        private ToolStripMenuItem このアプリについてToolStripMenuItem;
        private Button btOPENpig;
    }
}
