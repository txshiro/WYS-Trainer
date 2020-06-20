namespace WYSTrainer
{
    partial class Settable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.turnAI = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.collisionsOFF = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.roomid = new System.Windows.Forms.TextBox();
            this.saveSet = new System.Windows.Forms.Button();
            this.dontknowB = new System.Windows.Forms.CheckBox();
            this.disableTextures = new System.Windows.Forms.CheckBox();
            this.chal = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idk = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // turnAI
            // 
            this.turnAI.AutoSize = true;
            this.turnAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.turnAI.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.turnAI.Location = new System.Drawing.Point(9, 23);
            this.turnAI.Name = "turnAI";
            this.turnAI.Size = new System.Drawing.Size(113, 26);
            this.turnAI.TabIndex = 0;
            this.turnAI.Text = "Turn off AI";
            this.turnAI.UseVisualStyleBackColor = true;
            this.turnAI.CheckedChanged += new System.EventHandler(this.turnAI_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(98, 62);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 16);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(25, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Deaths";
            // 
            // collisionsOFF
            // 
            this.collisionsOFF.AutoSize = true;
            this.collisionsOFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.collisionsOFF.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.collisionsOFF.Location = new System.Drawing.Point(205, 439);
            this.collisionsOFF.Name = "collisionsOFF";
            this.collisionsOFF.Size = new System.Drawing.Size(306, 26);
            this.collisionsOFF.TabIndex = 3;
            this.collisionsOFF.Text = "Turn off Collisions (Dont do it LUL)";
            this.collisionsOFF.UseVisualStyleBackColor = true;
            this.collisionsOFF.Visible = false;
            this.collisionsOFF.CheckedChanged += new System.EventHandler(this.collisionsOFF_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(25, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Room";
            // 
            // roomid
            // 
            this.roomid.BackColor = System.Drawing.Color.Gray;
            this.roomid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roomid.ForeColor = System.Drawing.SystemColors.Info;
            this.roomid.Location = new System.Drawing.Point(98, 31);
            this.roomid.Multiline = true;
            this.roomid.Name = "roomid";
            this.roomid.Size = new System.Drawing.Size(100, 16);
            this.roomid.TabIndex = 5;
            this.roomid.TextChanged += new System.EventHandler(this.roomid_TextChanged);
            // 
            // saveSet
            // 
            this.saveSet.BackColor = System.Drawing.Color.Silver;
            this.saveSet.FlatAppearance.BorderSize = 0;
            this.saveSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveSet.Location = new System.Drawing.Point(71, 126);
            this.saveSet.Name = "saveSet";
            this.saveSet.Size = new System.Drawing.Size(75, 23);
            this.saveSet.TabIndex = 6;
            this.saveSet.Text = "Save";
            this.saveSet.UseVisualStyleBackColor = false;
            this.saveSet.Click += new System.EventHandler(this.saveSet_Click_1);
            // 
            // dontknowB
            // 
            this.dontknowB.AutoSize = true;
            this.dontknowB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dontknowB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dontknowB.Location = new System.Drawing.Point(9, 87);
            this.dontknowB.Name = "dontknowB";
            this.dontknowB.Size = new System.Drawing.Size(89, 26);
            this.dontknowB.TabIndex = 7;
            this.dontknowB.Text = "??????";
            this.dontknowB.UseVisualStyleBackColor = true;
            this.dontknowB.CheckedChanged += new System.EventHandler(this.dontknowB_CheckedChanged);
            // 
            // disableTextures
            // 
            this.disableTextures.AutoSize = true;
            this.disableTextures.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.disableTextures.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.disableTextures.Location = new System.Drawing.Point(9, 55);
            this.disableTextures.Name = "disableTextures";
            this.disableTextures.Size = new System.Drawing.Size(158, 26);
            this.disableTextures.TabIndex = 8;
            this.disableTextures.Text = "Disable textures";
            this.disableTextures.UseVisualStyleBackColor = true;
            this.disableTextures.CheckedChanged += new System.EventHandler(this.disableTextures_CheckedChanged);
            // 
            // chal
            // 
            this.chal.AutoSize = true;
            this.chal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chal.Location = new System.Drawing.Point(489, 388);
            this.chal.Name = "chal";
            this.chal.Size = new System.Drawing.Size(152, 26);
            this.chal.TabIndex = 10;
            this.chal.Text = "15 seconds run";
            this.chal.UseVisualStyleBackColor = true;
            this.chal.Visible = false;
            this.chal.CheckedChanged += new System.EventHandler(this.chal_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.idk);
            this.panel1.Controls.Add(this.roomid);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.saveSet);
            this.panel1.Location = new System.Drawing.Point(12, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 152);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.turnAI);
            this.panel2.Controls.Add(this.disableTextures);
            this.panel2.Controls.Add(this.dontknowB);
            this.panel2.Location = new System.Drawing.Point(419, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 149);
            this.panel2.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WYSTrainer.Properties.Resources.weebshit;
            this.pictureBox1.Location = new System.Drawing.Point(248, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkRed;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(63, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(607, 62);
            this.label3.TabIndex = 7;
            this.label3.Text = "AFTER CHANGING ROOM PRESS ESC TWICE\r\nIF BLUR DOESN\'T WORK  PRESS ESC OR R";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(277, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "hack more lmao";
            this.label4.Visible = false;
            // 
            // idk
            // 
            this.idk.AutoSize = true;
            this.idk.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.idk.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.idk.Location = new System.Drawing.Point(24, 89);
            this.idk.Name = "idk";
            this.idk.Size = new System.Drawing.Size(68, 22);
            this.idk.TabIndex = 7;
            this.idk.Text = "BLUR?";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Gray;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox2.Location = new System.Drawing.Point(98, 92);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 16);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Settable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.collisionsOFF);
            this.Name = "Settable";
            this.Size = new System.Drawing.Size(715, 559);
            this.Load += new System.EventHandler(this.Settable_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox turnAI;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox collisionsOFF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox roomid;
        private System.Windows.Forms.Button saveSet;
        private System.Windows.Forms.CheckBox dontknowB;
        private System.Windows.Forms.CheckBox disableTextures;
        private System.Windows.Forms.CheckBox chal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label idk;
    }
}
