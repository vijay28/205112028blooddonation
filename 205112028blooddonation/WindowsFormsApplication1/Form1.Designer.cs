﻿namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.BGROUP = new System.Windows.Forms.ComboBox();
            this.SUBMIT = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.EMAIL = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MOB = new System.Windows.Forms.TextBox();
            this.ADDRESS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NAME = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BGROUP
            // 
            this.BGROUP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGROUP.ForeColor = System.Drawing.Color.Blue;
            this.BGROUP.FormattingEnabled = true;
            this.BGROUP.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.BGROUP.Location = new System.Drawing.Point(312, 321);
            this.BGROUP.Name = "BGROUP";
            this.BGROUP.Size = new System.Drawing.Size(141, 24);
            this.BGROUP.TabIndex = 34;
            this.BGROUP.SelectedIndexChanged += new System.EventHandler(this.BGROUP_SelectedIndexChanged);
            // 
            // SUBMIT
            // 
            this.SUBMIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUBMIT.ForeColor = System.Drawing.Color.Blue;
            this.SUBMIT.Location = new System.Drawing.Point(308, 365);
            this.SUBMIT.Name = "SUBMIT";
            this.SUBMIT.Size = new System.Drawing.Size(166, 39);
            this.SUBMIT.TabIndex = 33;
            this.SUBMIT.Text = "SUBMIT";
            this.SUBMIT.UseVisualStyleBackColor = true;
            this.SUBMIT.Click += new System.EventHandler(this.SUBMIT_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(141, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 24);
            this.label9.TabIndex = 32;
            this.label9.Text = "BLOODGROUP";
            // 
            // EMAIL
            // 
            this.EMAIL.Location = new System.Drawing.Point(312, 246);
            this.EMAIL.Multiline = true;
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Size = new System.Drawing.Size(254, 47);
            this.EMAIL.TabIndex = 31;
            this.EMAIL.TextChanged += new System.EventHandler(this.EMAIL_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(141, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 24);
            this.label8.TabIndex = 30;
            this.label8.Text = "EMAIL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(137, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 24);
            this.label7.TabIndex = 29;
            this.label7.Text = "MOBILENO";
            // 
            // MOB
            // 
            this.MOB.Location = new System.Drawing.Point(308, 186);
            this.MOB.Multiline = true;
            this.MOB.Name = "MOB";
            this.MOB.Size = new System.Drawing.Size(254, 25);
            this.MOB.TabIndex = 28;
            this.MOB.TextChanged += new System.EventHandler(this.MOB_TextChanged);
            // 
            // ADDRESS
            // 
            this.ADDRESS.Location = new System.Drawing.Point(308, 68);
            this.ADDRESS.Multiline = true;
            this.ADDRESS.Name = "ADDRESS";
            this.ADDRESS.Size = new System.Drawing.Size(254, 80);
            this.ADDRESS.TabIndex = 27;
            this.ADDRESS.TextChanged += new System.EventHandler(this.ADDRESS_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(137, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 24);
            this.label6.TabIndex = 26;
            this.label6.Text = "ADDRESS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(137, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 24);
            this.label5.TabIndex = 25;
            this.label5.Text = "NAME";
            // 
            // NAME
            // 
            this.NAME.Location = new System.Drawing.Point(308, 4);
            this.NAME.Multiline = true;
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(254, 27);
            this.NAME.TabIndex = 24;
            this.NAME.TextChanged += new System.EventHandler(this.NAME_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 405);
            this.Controls.Add(this.BGROUP);
            this.Controls.Add(this.SUBMIT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.EMAIL);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MOB);
            this.Controls.Add(this.ADDRESS);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NAME);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox BGROUP;
        private System.Windows.Forms.Button SUBMIT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox EMAIL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MOB;
        private System.Windows.Forms.TextBox ADDRESS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NAME;
    }
}

