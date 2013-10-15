namespace WindowsFormsApplication3
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
            this.USER = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PASS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LOGIN = new System.Windows.Forms.Button();
            this.HOME = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // USER
            // 
            this.USER.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USER.ForeColor = System.Drawing.Color.Black;
            this.USER.Location = new System.Drawing.Point(287, 83);
            this.USER.Name = "USER";
            this.USER.Size = new System.Drawing.Size(134, 21);
            this.USER.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "USERNAME";
            // 
            // PASS
            // 
            this.PASS.Location = new System.Drawing.Point(287, 138);
            this.PASS.Name = "PASS";
            this.PASS.PasswordChar = '*';
            this.PASS.Size = new System.Drawing.Size(134, 20);
            this.PASS.TabIndex = 2;
            this.PASS.TextChanged += new System.EventHandler(this.PASS_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "PASSWORD";
            // 
            // LOGIN
            // 
            this.LOGIN.Location = new System.Drawing.Point(254, 196);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(106, 23);
            this.LOGIN.TabIndex = 4;
            this.LOGIN.Text = "LOGIN";
            this.LOGIN.UseVisualStyleBackColor = true;
            this.LOGIN.Click += new System.EventHandler(this.LOGIN_Click);
            // 
            // HOME
            // 
            this.HOME.Location = new System.Drawing.Point(3, 62);
            this.HOME.Name = "HOME";
            this.HOME.Size = new System.Drawing.Size(75, 23);
            this.HOME.TabIndex = 5;
            this.HOME.Text = "HOME";
            this.HOME.UseVisualStyleBackColor = true;
            this.HOME.Click += new System.EventHandler(this.HOME_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.BlueViolet;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(677, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "WELCOME TO BLOOD DONATION SYSTEM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.nitt2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(719, 544);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HOME);
            this.Controls.Add(this.LOGIN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PASS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.USER);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox USER;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PASS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LOGIN;
        private System.Windows.Forms.Button HOME;
        private System.Windows.Forms.Label label3;
    }
}

