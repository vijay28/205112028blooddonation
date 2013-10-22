namespace WindowsFormsApplication3
{
    partial class Form3
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
            this.CHOICE = new System.Windows.Forms.Label();
            this.DONAR = new System.Windows.Forms.Button();
            this.RECIPIENT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LOGOUT = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CHOICE
            // 
            this.CHOICE.AutoSize = true;
            this.CHOICE.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHOICE.ForeColor = System.Drawing.Color.Blue;
            this.CHOICE.Location = new System.Drawing.Point(279, 99);
            this.CHOICE.Name = "CHOICE";
            this.CHOICE.Size = new System.Drawing.Size(242, 37);
            this.CHOICE.TabIndex = 0;
            this.CHOICE.Text = "CHOICE FORM";
            this.CHOICE.Click += new System.EventHandler(this.CHOICE_Click);
            // 
            // DONAR
            // 
            this.DONAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DONAR.ForeColor = System.Drawing.Color.Blue;
            this.DONAR.Location = new System.Drawing.Point(172, 231);
            this.DONAR.Name = "DONAR";
            this.DONAR.Size = new System.Drawing.Size(188, 39);
            this.DONAR.TabIndex = 1;
            this.DONAR.Text = "STUDENT DONAR";
            this.DONAR.UseVisualStyleBackColor = true;
            this.DONAR.Click += new System.EventHandler(this.DONAR_Click);
            // 
            // RECIPIENT
            // 
            this.RECIPIENT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RECIPIENT.ForeColor = System.Drawing.Color.Blue;
            this.RECIPIENT.Location = new System.Drawing.Point(485, 231);
            this.RECIPIENT.Name = "RECIPIENT";
            this.RECIPIENT.Size = new System.Drawing.Size(186, 39);
            this.RECIPIENT.TabIndex = 2;
            this.RECIPIENT.Text = "STUDENT RECIPIENT";
            this.RECIPIENT.UseVisualStyleBackColor = true;
            this.RECIPIENT.Click += new System.EventHandler(this.RECIPIENT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(237, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "FOR REGISTRATION";
            // 
            // LOGOUT
            // 
            this.LOGOUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGOUT.ForeColor = System.Drawing.Color.Blue;
            this.LOGOUT.Location = new System.Drawing.Point(357, 333);
            this.LOGOUT.Name = "LOGOUT";
            this.LOGOUT.Size = new System.Drawing.Size(128, 33);
            this.LOGOUT.TabIndex = 4;
            this.LOGOUT.Text = "LOGOUT";
            this.LOGOUT.UseVisualStyleBackColor = true;
            this.LOGOUT.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(21, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "DATABASE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 451);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LOGOUT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RECIPIENT);
            this.Controls.Add(this.DONAR);
            this.Controls.Add(this.CHOICE);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CHOICE;
        private System.Windows.Forms.Button DONAR;
        private System.Windows.Forms.Button RECIPIENT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LOGOUT;
        private System.Windows.Forms.Button button1;
    }
}