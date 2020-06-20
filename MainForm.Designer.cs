namespace WYSTrainer
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.ProcOpenLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.SettableB = new System.Windows.Forms.Button();
            this.HPBOSS = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Button();
            this.Timers2 = new System.Windows.Forms.Button();
            this.Statisticts2 = new System.Windows.Forms.Button();
            this.timers1 = new WYSTrainer.Timers();
            this.statisticts1 = new WYSTrainer.Statisticts();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.settable1 = new WYSTrainer.Settable();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(35, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Will You Snail";
            // 
            // ProcOpenLabel
            // 
            this.ProcOpenLabel.AutoSize = true;
            this.ProcOpenLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ProcOpenLabel.ForeColor = System.Drawing.Color.Lime;
            this.ProcOpenLabel.Location = new System.Drawing.Point(36, 60);
            this.ProcOpenLabel.Name = "ProcOpenLabel";
            this.ProcOpenLabel.Size = new System.Drawing.Size(36, 20);
            this.ProcOpenLabel.TabIndex = 1;
            this.ProcOpenLabel.Text = "N/A";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(23)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.SettableB);
            this.panel1.Controls.Add(this.HPBOSS);
            this.panel1.Controls.Add(this.Info);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ProcOpenLabel);
            this.panel1.Controls.Add(this.Timers2);
            this.panel1.Controls.Add(this.Statisticts2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 556);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 526);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 27);
            this.label2.TabIndex = 24;
            this.label2.Text = "txshiro#4353";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::WYSTrainer.Properties.Resources.katakuri___one_piece_by_k9k992_dcxc6ji_fullview_cropped__2__cropped;
            this.pictureBox3.Location = new System.Drawing.Point(3, 526);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // SettableB
            // 
            this.SettableB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(23)))));
            this.SettableB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SettableB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettableB.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SettableB.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SettableB.Location = new System.Drawing.Point(-12, 309);
            this.SettableB.Name = "SettableB";
            this.SettableB.Size = new System.Drawing.Size(232, 43);
            this.SettableB.TabIndex = 4;
            this.SettableB.Text = "Settable";
            this.SettableB.UseVisualStyleBackColor = false;
            this.SettableB.Click += new System.EventHandler(this.SettableB_Click);
            // 
            // HPBOSS
            // 
            this.HPBOSS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(23)))));
            this.HPBOSS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HPBOSS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HPBOSS.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HPBOSS.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.HPBOSS.Location = new System.Drawing.Point(-12, 370);
            this.HPBOSS.Name = "HPBOSS";
            this.HPBOSS.Size = new System.Drawing.Size(232, 43);
            this.HPBOSS.TabIndex = 3;
            this.HPBOSS.Text = "HP (Bosses)";
            this.HPBOSS.UseVisualStyleBackColor = false;
            this.HPBOSS.Visible = false;
            this.HPBOSS.Click += new System.EventHandler(this.HPBOSS_Click);
            // 
            // Info
            // 
            this.Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.Info.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Info.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Info.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Info.Location = new System.Drawing.Point(-22, 109);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(232, 43);
            this.Info.TabIndex = 2;
            this.Info.Text = "Info";
            this.Info.UseVisualStyleBackColor = false;
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // Timers2
            // 
            this.Timers2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(23)))));
            this.Timers2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Timers2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Timers2.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Timers2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Timers2.Location = new System.Drawing.Point(-12, 242);
            this.Timers2.Name = "Timers2";
            this.Timers2.Size = new System.Drawing.Size(232, 43);
            this.Timers2.TabIndex = 1;
            this.Timers2.Text = "Timers";
            this.Timers2.UseVisualStyleBackColor = false;
            this.Timers2.Click += new System.EventHandler(this.Timers2_Click);
            // 
            // Statisticts2
            // 
            this.Statisticts2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(23)))));
            this.Statisticts2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Statisticts2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Statisticts2.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Statisticts2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Statisticts2.Location = new System.Drawing.Point(-12, 173);
            this.Statisticts2.Name = "Statisticts2";
            this.Statisticts2.Size = new System.Drawing.Size(232, 43);
            this.Statisticts2.TabIndex = 0;
            this.Statisticts2.Text = "Statisticts";
            this.Statisticts2.UseVisualStyleBackColor = false;
            this.Statisticts2.Click += new System.EventHandler(this.Statisticts2_Click);
            // 
            // timers1
            // 
            this.timers1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.timers1.Location = new System.Drawing.Point(197, -1);
            this.timers1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.timers1.Name = "timers1";
            this.timers1.Size = new System.Drawing.Size(720, 554);
            this.timers1.TabIndex = 3;
            this.timers1.Load += new System.EventHandler(this.timers1_Load);
            // 
            // statisticts1
            // 
            this.statisticts1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.statisticts1.Location = new System.Drawing.Point(197, 0);
            this.statisticts1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.statisticts1.Name = "statisticts1";
            this.statisticts1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statisticts1.Size = new System.Drawing.Size(720, 556);
            this.statisticts1.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(262, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(589, 60);
            this.label7.TabIndex = 13;
            this.label7.Text = "Welcome to WYS Trainer";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(248, 305);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(622, 28);
            this.label12.TabIndex = 17;
            this.label12.Text = "YOU CAN MAKE THE GAME CRASH IF YOU CHOOSE WRONG VALUES!";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WYSTrainer.Properties.Resources.banana;
            this.pictureBox2.Location = new System.Drawing.Point(206, 242);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WYSTrainer.Properties.Resources.banana;
            this.pictureBox4.Location = new System.Drawing.Point(852, 242);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 60);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            // 
            // settable1
            // 
            this.settable1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.settable1.Location = new System.Drawing.Point(197, 0);
            this.settable1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.settable1.Name = "settable1";
            this.settable1.Size = new System.Drawing.Size(720, 556);
            this.settable1.TabIndex = 19;
            this.settable1.Load += new System.EventHandler(this.settable1_Load);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(913, 556);
            this.Controls.Add(this.statisticts1);
            this.Controls.Add(this.timers1);
            this.Controls.Add(this.settable1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox4);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Will You Snail? Trainer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ProcOpenLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Timers2;
        private System.Windows.Forms.Button Statisticts2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Info;
        private System.Windows.Forms.Button HPBOSS;
        private System.Windows.Forms.Button SettableB;
        private Settable settable1;
        private Statisticts statisticts1;
        private Timers timers1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

