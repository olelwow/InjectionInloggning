namespace InjectionInloggning
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblQuerry = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(148, 34);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(291, 30);
            this.txtUser.TabIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(148, 89);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(291, 30);
            this.txtPass.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 61);
            this.button1.TabIndex = 4;
            this.button1.Text = "Logga in";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(38, 285);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(139, 25);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Du är utloggad";
            // 
            // lblQuerry
            // 
            this.lblQuerry.AutoSize = true;
            this.lblQuerry.Location = new System.Drawing.Point(38, 148);
            this.lblQuerry.Name = "lblQuerry";
            this.lblQuerry.Size = new System.Drawing.Size(97, 25);
            this.lblQuerry.TabIndex = 6;
            this.lblQuerry.Text = "sqlQuerry";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 407);
            this.Controls.Add(this.lblQuerry);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblQuerry;
    }
}

