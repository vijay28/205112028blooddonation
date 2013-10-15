namespace WindowsFormsApplication3
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RNO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NAME = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ADDRESS = new System.Windows.Forms.TextBox();
            this.MOB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.EMAIL = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SUBMIT = new System.Windows.Forms.Button();
            this.BGROUP = new System.Windows.Forms.ComboBox();
            this.HOME = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(171, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "BLOOD DONATION SYSTEM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(235, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "REGISTRATION FORM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(270, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "STUDENT DONAR";
            // 
            // RNO
            // 
            this.RNO.Location = new System.Drawing.Point(344, 181);
            this.RNO.Multiline = true;
            this.RNO.Name = "RNO";
            this.RNO.Size = new System.Drawing.Size(254, 25);
            this.RNO.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(173, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "ROLLNO.";
            // 
            // NAME
            // 
            this.NAME.Location = new System.Drawing.Point(344, 252);
            this.NAME.Multiline = true;
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(254, 27);
            this.NAME.TabIndex = 5;
            this.NAME.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(173, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "NAME";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(173, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "ADDRESS";
            // 
            // ADDRESS
            // 
            this.ADDRESS.Location = new System.Drawing.Point(344, 316);
            this.ADDRESS.Multiline = true;
            this.ADDRESS.Name = "ADDRESS";
            this.ADDRESS.Size = new System.Drawing.Size(254, 80);
            this.ADDRESS.TabIndex = 8;
            // 
            // MOB
            // 
            this.MOB.Location = new System.Drawing.Point(344, 434);
            this.MOB.Multiline = true;
            this.MOB.Name = "MOB";
            this.MOB.Size = new System.Drawing.Size(254, 25);
            this.MOB.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(173, 434);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "MOBILENO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(177, 494);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 24);
            this.label8.TabIndex = 11;
            this.label8.Text = "EMAIL";
            // 
            // EMAIL
            // 
            this.EMAIL.Location = new System.Drawing.Point(348, 494);
            this.EMAIL.Multiline = true;
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Size = new System.Drawing.Size(254, 47);
            this.EMAIL.TabIndex = 12;
            this.EMAIL.TextChanged += new System.EventHandler(this.EMAIL_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(177, 569);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 24);
            this.label9.TabIndex = 14;
            this.label9.Text = "BLOODGROUP";
            // 
            // SUBMIT
            // 
            this.SUBMIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUBMIT.ForeColor = System.Drawing.Color.Blue;
            this.SUBMIT.Location = new System.Drawing.Point(344, 613);
            this.SUBMIT.Name = "SUBMIT";
            this.SUBMIT.Size = new System.Drawing.Size(166, 39);
            this.SUBMIT.TabIndex = 22;
            this.SUBMIT.Text = "SUBMIT";
            this.SUBMIT.UseVisualStyleBackColor = true;
            this.SUBMIT.Click += new System.EventHandler(this.SUBMIT_Click);
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
            this.BGROUP.Location = new System.Drawing.Point(348, 569);
            this.BGROUP.Name = "BGROUP";
            this.BGROUP.Size = new System.Drawing.Size(141, 24);
            this.BGROUP.TabIndex = 23;
            this.BGROUP.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // HOME
            // 
            this.HOME.Location = new System.Drawing.Point(12, 12);
            this.HOME.Name = "HOME";
            this.HOME.Size = new System.Drawing.Size(75, 23);
            this.HOME.TabIndex = 24;
            this.HOME.Text = "HOME";
            this.HOME.UseVisualStyleBackColor = true;
            this.HOME.Click += new System.EventHandler(this.HOME_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 702);
            this.Controls.Add(this.HOME);
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RNO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RNO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NAME;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ADDRESS;
        private System.Windows.Forms.TextBox MOB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox EMAIL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button SUBMIT;
        private System.Windows.Forms.ComboBox BGROUP;
        private System.Windows.Forms.Button HOME;
    }
}