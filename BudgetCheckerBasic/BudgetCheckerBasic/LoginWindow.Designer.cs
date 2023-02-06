namespace BudgetCheckerBasic
{
    partial class LoginWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.StayLoggedCheckbox = new System.Windows.Forms.CheckBox();
            this.RemMeCheckbox = new System.Windows.Forms.CheckBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.SingUpBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StayLoggedCheckbox
            // 
            this.StayLoggedCheckbox.AutoSize = true;
            this.StayLoggedCheckbox.Location = new System.Drawing.Point(12, 124);
            this.StayLoggedCheckbox.Name = "StayLoggedCheckbox";
            this.StayLoggedCheckbox.Size = new System.Drawing.Size(82, 17);
            this.StayLoggedCheckbox.TabIndex = 0;
            this.StayLoggedCheckbox.Text = "Stay logged";
            this.StayLoggedCheckbox.UseVisualStyleBackColor = true;
            // 
            // RemMeCheckbox
            // 
            this.RemMeCheckbox.AutoSize = true;
            this.RemMeCheckbox.Location = new System.Drawing.Point(12, 101);
            this.RemMeCheckbox.Name = "RemMeCheckbox";
            this.RemMeCheckbox.Size = new System.Drawing.Size(95, 17);
            this.RemMeCheckbox.TabIndex = 1;
            this.RemMeCheckbox.Text = "Remember Me";
            this.RemMeCheckbox.UseVisualStyleBackColor = true;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(12, 28);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(100, 20);
            this.LoginTextBox.TabIndex = 2;
            // 
            // PassTextBox
            // 
            this.PassTextBox.Location = new System.Drawing.Point(12, 75);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.Size = new System.Drawing.Size(100, 20);
            this.PassTextBox.TabIndex = 3;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(13, 12);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(33, 13);
            this.LoginLabel.TabIndex = 4;
            this.LoginLabel.Text = "Login";
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Location = new System.Drawing.Point(13, 59);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(53, 13);
            this.PassLabel.TabIndex = 5;
            this.PassLabel.Text = "Password";
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(138, 75);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 23);
            this.LoginBtn.TabIndex = 6;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            // 
            // SingUpBtn
            // 
            this.SingUpBtn.Location = new System.Drawing.Point(137, 24);
            this.SingUpBtn.Name = "SingUpBtn";
            this.SingUpBtn.Size = new System.Drawing.Size(75, 23);
            this.SingUpBtn.TabIndex = 7;
            this.SingUpBtn.Text = "SingUp";
            this.SingUpBtn.UseVisualStyleBackColor = true;
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 156);
            this.Controls.Add(this.SingUpBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.PassTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.RemMeCheckbox);
            this.Controls.Add(this.StayLoggedCheckbox);
            this.Name = "Form1";
            this.Text = "Zaloguj";
            this.Load += new System.EventHandler(this.LoginWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox StayLoggedCheckbox;
        private System.Windows.Forms.CheckBox RemMeCheckbox;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button SingUpBtn;
    }
}

