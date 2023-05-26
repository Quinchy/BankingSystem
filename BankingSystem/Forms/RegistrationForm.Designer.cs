namespace BankingSystem.Forms
{
    partial class RegistrationForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            submitButton = new Utils.Components.RoundedButton();
            panel1 = new Panel();
            panel9 = new Panel();
            registrationLabel = new Label();
            registrationDescriptionLabel = new Label();
            panel6 = new Panel();
            label5 = new Label();
            textBox5 = new TextBox();
            roundedPanel4 = new Utils.Components.RoundedPanel();
            label4 = new Label();
            panel7 = new Panel();
            panel5 = new Panel();
            label3 = new Label();
            textBox4 = new TextBox();
            roundedPanel3 = new Utils.Components.RoundedPanel();
            textBox6 = new TextBox();
            roundedPanel5 = new Utils.Components.RoundedPanel();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            panel8 = new Panel();
            textBox2 = new TextBox();
            roundedPanel1 = new Utils.Components.RoundedPanel();
            firstNameLabel = new Label();
            textBox1 = new TextBox();
            panel4 = new Panel();
            roundedPanel6 = new Utils.Components.RoundedPanel();
            textBox3 = new TextBox();
            roundedPanel2 = new Utils.Components.RoundedPanel();
            panel2 = new Panel();
            showPasswordCheckbox = new CheckBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // submitButton
            // 
            submitButton.BorderColor = Color.Transparent;
            submitButton.ButtonColor = Color.FromArgb(92, 184, 92);
            submitButton.Cursor = Cursors.Hand;
            submitButton.FlatAppearance.BorderSize = 0;
            submitButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            submitButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            submitButton.FlatStyle = FlatStyle.Flat;
            submitButton.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            submitButton.Location = new Point(246, 554);
            submitButton.Name = "submitButton";
            submitButton.OnHoverBorderColor = Color.Transparent;
            submitButton.OnHoverButtonColor = Color.FromArgb(124, 205, 124);
            submitButton.OnHoverTextColor = Color.WhiteSmoke;
            submitButton.Size = new Size(149, 65);
            submitButton.TabIndex = 2;
            submitButton.Text = "Submit";
            submitButton.TextColor = Color.WhiteSmoke;
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(48, 48, 51);
            panel1.Controls.Add(showPasswordCheckbox);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(registrationLabel);
            panel1.Controls.Add(registrationDescriptionLabel);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(submitButton);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(roundedPanel4);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(roundedPanel3);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(roundedPanel5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(roundedPanel1);
            panel1.Controls.Add(firstNameLabel);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(roundedPanel6);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(roundedPanel2);
            panel1.Location = new Point(640, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(640, 720);
            panel1.TabIndex = 3;
            // 
            // panel9
            // 
            panel9.BackColor = Color.WhiteSmoke;
            panel9.Location = new Point(32, 98);
            panel9.Name = "panel9";
            panel9.Size = new Size(571, 2);
            panel9.TabIndex = 31;
            // 
            // registrationLabel
            // 
            registrationLabel.AutoSize = true;
            registrationLabel.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            registrationLabel.ForeColor = Color.FromArgb(92, 184, 92);
            registrationLabel.Location = new Point(32, 41);
            registrationLabel.Name = "registrationLabel";
            registrationLabel.Size = new Size(236, 44);
            registrationLabel.TabIndex = 3;
            registrationLabel.Text = "Registration";
            // 
            // registrationDescriptionLabel
            // 
            registrationDescriptionLabel.AutoSize = true;
            registrationDescriptionLabel.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            registrationDescriptionLabel.ForeColor = Color.WhiteSmoke;
            registrationDescriptionLabel.Location = new Point(43, 117);
            registrationDescriptionLabel.Name = "registrationDescriptionLabel";
            registrationDescriptionLabel.Size = new Size(412, 24);
            registrationDescriptionLabel.TabIndex = 4;
            registrationDescriptionLabel.Text = "Please provide your basic details below.";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Silver;
            panel6.Location = new Point(347, 476);
            panel6.Name = "panel6";
            panel6.Size = new Size(245, 2);
            panel6.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(336, 409);
            label5.Name = "label5";
            label5.Size = new Size(151, 19);
            label5.TabIndex = 30;
            label5.Text = "Confirm Password";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.WhiteSmoke;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.ForeColor = Color.FromArgb(48, 48, 51);
            textBox5.Location = new Point(347, 456);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(245, 19);
            textBox5.TabIndex = 19;
            // 
            // roundedPanel4
            // 
            roundedPanel4.BackColor = Color.Transparent;
            roundedPanel4.BorderColor = Color.WhiteSmoke;
            roundedPanel4.CornerRadius = 10;
            roundedPanel4.ForeColor = Color.Transparent;
            roundedPanel4.Location = new Point(336, 448);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(267, 34);
            roundedPanel4.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(32, 409);
            label4.Name = "label4";
            label4.Size = new Size(86, 19);
            label4.TabIndex = 29;
            label4.Text = "Password";
            // 
            // panel7
            // 
            panel7.BackColor = Color.Silver;
            panel7.Location = new Point(347, 371);
            panel7.Name = "panel7";
            panel7.Size = new Size(245, 2);
            panel7.TabIndex = 20;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Silver;
            panel5.Location = new Point(43, 476);
            panel5.Name = "panel5";
            panel5.Size = new Size(245, 2);
            panel5.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(336, 301);
            label3.Name = "label3";
            label3.Size = new Size(124, 19);
            label3.TabIndex = 28;
            label3.Text = "Phone Number";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.WhiteSmoke;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.ForeColor = Color.FromArgb(48, 48, 51);
            textBox4.Location = new Point(43, 456);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(245, 19);
            textBox4.TabIndex = 16;
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.Transparent;
            roundedPanel3.BorderColor = Color.WhiteSmoke;
            roundedPanel3.CornerRadius = 10;
            roundedPanel3.ForeColor = Color.Transparent;
            roundedPanel3.Location = new Point(32, 448);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(267, 34);
            roundedPanel3.TabIndex = 15;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.WhiteSmoke;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.ForeColor = Color.FromArgb(48, 48, 51);
            textBox6.Location = new Point(347, 351);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(245, 19);
            textBox6.TabIndex = 22;
            // 
            // roundedPanel5
            // 
            roundedPanel5.BackColor = Color.Transparent;
            roundedPanel5.BorderColor = Color.WhiteSmoke;
            roundedPanel5.CornerRadius = 10;
            roundedPanel5.ForeColor = Color.Transparent;
            roundedPanel5.Location = new Point(336, 343);
            roundedPanel5.Name = "roundedPanel5";
            roundedPanel5.Size = new Size(267, 34);
            roundedPanel5.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(32, 301);
            label2.Name = "label2";
            label2.Size = new Size(51, 19);
            label2.TabIndex = 27;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(336, 201);
            label1.Name = "label1";
            label1.Size = new Size(90, 19);
            label1.TabIndex = 26;
            label1.Text = "Last Name";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Location = new Point(347, 269);
            panel3.Name = "panel3";
            panel3.Size = new Size(245, 2);
            panel3.TabIndex = 23;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Silver;
            panel8.Location = new Point(43, 269);
            panel8.Name = "panel8";
            panel8.Size = new Size(245, 2);
            panel8.TabIndex = 23;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.WhiteSmoke;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.FromArgb(48, 48, 51);
            textBox2.Location = new Point(347, 249);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(245, 19);
            textBox2.TabIndex = 25;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.Transparent;
            roundedPanel1.BorderColor = Color.WhiteSmoke;
            roundedPanel1.CornerRadius = 10;
            roundedPanel1.ForeColor = Color.Transparent;
            roundedPanel1.Location = new Point(336, 241);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(267, 34);
            roundedPanel1.TabIndex = 24;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            firstNameLabel.ForeColor = Color.WhiteSmoke;
            firstNameLabel.Location = new Point(32, 201);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(91, 19);
            firstNameLabel.TabIndex = 5;
            firstNameLabel.Text = "First Name";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(48, 48, 51);
            textBox1.Location = new Point(43, 249);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 19);
            textBox1.TabIndex = 25;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Silver;
            panel4.Location = new Point(43, 371);
            panel4.Name = "panel4";
            panel4.Size = new Size(245, 2);
            panel4.TabIndex = 11;
            // 
            // roundedPanel6
            // 
            roundedPanel6.BackColor = Color.Transparent;
            roundedPanel6.BorderColor = Color.WhiteSmoke;
            roundedPanel6.CornerRadius = 10;
            roundedPanel6.ForeColor = Color.Transparent;
            roundedPanel6.Location = new Point(32, 241);
            roundedPanel6.Name = "roundedPanel6";
            roundedPanel6.Size = new Size(267, 34);
            roundedPanel6.TabIndex = 24;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.WhiteSmoke;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = Color.FromArgb(48, 48, 51);
            textBox3.Location = new Point(43, 351);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(245, 19);
            textBox3.TabIndex = 13;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.Transparent;
            roundedPanel2.BorderColor = Color.WhiteSmoke;
            roundedPanel2.CornerRadius = 10;
            roundedPanel2.ForeColor = Color.Transparent;
            roundedPanel2.Location = new Point(32, 343);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(267, 34);
            roundedPanel2.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(640, 720);
            panel2.TabIndex = 4;
            // 
            // showPasswordCheckbox
            // 
            showPasswordCheckbox.AutoSize = true;
            showPasswordCheckbox.FlatAppearance.CheckedBackColor = Color.FromArgb(92, 184, 92);
            showPasswordCheckbox.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            showPasswordCheckbox.ForeColor = Color.WhiteSmoke;
            showPasswordCheckbox.Location = new Point(43, 497);
            showPasswordCheckbox.Name = "showPasswordCheckbox";
            showPasswordCheckbox.Size = new Size(126, 19);
            showPasswordCheckbox.TabIndex = 32;
            showPasswordCheckbox.Text = "Show Password?";
            showPasswordCheckbox.UseVisualStyleBackColor = true;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1280, 720);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        private Utils.Components.RoundedButton submitButton;
        private Panel panel1;
        private Panel panel2;
        private Label registrationLabel;
        private Label registrationDescriptionLabel;
        private Label firstNameLabel;
        private Panel panel4;
        private TextBox textBox3;
        private Utils.Components.RoundedPanel roundedPanel2;
        private Panel panel5;
        private TextBox textBox4;
        private Utils.Components.RoundedPanel roundedPanel3;
        private Panel panel6;
        private TextBox textBox5;
        private Utils.Components.RoundedPanel roundedPanel4;
        private Panel panel7;
        private TextBox textBox6;
        private Utils.Components.RoundedPanel roundedPanel5;
        private Label label1;
        private Panel panel3;
        private Panel panel8;
        private TextBox textBox2;
        private Utils.Components.RoundedPanel roundedPanel1;
        private TextBox textBox1;
        private Utils.Components.RoundedPanel roundedPanel6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel9;
        private CheckBox showPasswordCheckbox;
    }
}