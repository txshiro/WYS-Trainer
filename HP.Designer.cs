namespace WYSTrainer
{
    partial class HP
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.customHP = new System.Windows.Forms.TextBox();
            this.SaveHPMR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Desktop;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(25, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current HP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Desktop;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(131, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "0";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Desktop;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(25, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Custom HP";
            // 
            // customHP
            // 
            this.customHP.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.customHP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customHP.Location = new System.Drawing.Point(134, 109);
            this.customHP.Name = "customHP";
            this.customHP.Size = new System.Drawing.Size(100, 13);
            this.customHP.TabIndex = 4;
            this.customHP.TextChanged += new System.EventHandler(this.customHP_TextChanged);
            // 
            // SaveHPMR
            // 
            this.SaveHPMR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SaveHPMR.FlatAppearance.BorderSize = 0;
            this.SaveHPMR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveHPMR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SaveHPMR.Location = new System.Drawing.Point(63, 147);
            this.SaveHPMR.Name = "SaveHPMR";
            this.SaveHPMR.Size = new System.Drawing.Size(75, 23);
            this.SaveHPMR.TabIndex = 5;
            this.SaveHPMR.Text = "Save";
            this.SaveHPMR.UseVisualStyleBackColor = false;
            this.SaveHPMR.Click += new System.EventHandler(this.SaveHPMR_Click);
            // 
            // HP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.Controls.Add(this.SaveHPMR);
            this.Controls.Add(this.customHP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "HP";
            this.Size = new System.Drawing.Size(758, 485);
            this.Load += new System.EventHandler(this.HP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox customHP;
        private System.Windows.Forms.Button SaveHPMR;
    }
}
