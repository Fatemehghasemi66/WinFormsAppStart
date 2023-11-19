namespace WinFormsAppStart
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            SaveBottun = new Button();
            firstnameTextBox = new TextBox();
            lastnameTextBox = new TextBox();
            lastname = new Label();
            firstname = new Label();
            rememberCheckBox = new CheckBox();
            listBoX = new ListBox();
            dateTimePicker1 = new DateTimePicker();
            speltBox = new ListBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // SaveBottun
            // 
            SaveBottun.AccessibleName = "enter";
            SaveBottun.BackColor = SystemColors.ActiveCaption;
            SaveBottun.Location = new Point(162, 333);
            SaveBottun.Name = "SaveBottun";
            SaveBottun.Size = new Size(278, 89);
            SaveBottun.TabIndex = 0;
            SaveBottun.Text = "Save";
            SaveBottun.UseVisualStyleBackColor = false;
            SaveBottun.Click += SaveBottun_Click;
            // 
            // firstnameTextBox
            // 
            firstnameTextBox.BackColor = SystemColors.Window;
            firstnameTextBox.Location = new Point(268, 89);
            firstnameTextBox.Name = "firstnameTextBox";
            firstnameTextBox.Size = new Size(236, 39);
            firstnameTextBox.TabIndex = 1;
            firstnameTextBox.TextChanged += textBox1_TextChanged;
            // 
            // lastnameTextBox
            // 
            lastnameTextBox.Location = new Point(268, 152);
            lastnameTextBox.Name = "lastnameTextBox";
            lastnameTextBox.Size = new Size(236, 39);
            lastnameTextBox.TabIndex = 2;
            // 
            // lastname
            // 
            lastname.AutoSize = true;
            lastname.ForeColor = SystemColors.HotTrack;
            lastname.Location = new Point(104, 155);
            lastname.Name = "lastname";
            lastname.Size = new Size(114, 32);
            lastname.TabIndex = 3;
            lastname.Text = "lastName";
            // 
            // firstname
            // 
            firstname.AutoSize = true;
            firstname.ForeColor = SystemColors.HotTrack;
            firstname.Location = new Point(100, 96);
            firstname.Name = "firstname";
            firstname.Size = new Size(118, 32);
            firstname.TabIndex = 4;
            firstname.Text = "firstName";
            // 
            // rememberCheckBox
            // 
            rememberCheckBox.AutoSize = true;
            rememberCheckBox.Location = new Point(195, 277);
            rememberCheckBox.Name = "rememberCheckBox";
            rememberCheckBox.Size = new Size(204, 36);
            rememberCheckBox.TabIndex = 5;
            rememberCheckBox.Text = "Remember Me";
            rememberCheckBox.UseVisualStyleBackColor = true;
            // 
            // listBoX
            // 
            listBoX.ForeColor = SystemColors.WindowFrame;
            listBoX.FormattingEnabled = true;
            listBoX.ItemHeight = 32;
            listBoX.Location = new Point(526, 89);
            listBoX.Name = "listBoX";
            listBoX.Size = new Size(755, 164);
            listBoX.TabIndex = 7;
            listBoX.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(104, 217);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(400, 39);
            dateTimePicker1.TabIndex = 8;
            // 
            // speltBox
            // 
            speltBox.FormattingEnabled = true;
            speltBox.ItemHeight = 32;
            speltBox.Location = new Point(526, 259);
            speltBox.Name = "speltBox";
            speltBox.Size = new Size(755, 196);
            speltBox.TabIndex = 9;
            speltBox.SelectedIndexChanged += speltBox_SelectedIndexChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1393, 584);
            Controls.Add(speltBox);
            Controls.Add(dateTimePicker1);
            Controls.Add(listBoX);
            Controls.Add(rememberCheckBox);
            Controls.Add(firstname);
            Controls.Add(lastname);
            Controls.Add(lastnameTextBox);
            Controls.Add(firstnameTextBox);
            Controls.Add(SaveBottun);
            Name = "Form1";
            Text = "RegistrationForm";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaveBottun;
        private TextBox firstnameTextBox;
        private TextBox lastnameTextBox;
        private Label lastname;
        private Label firstname;
        private CheckBox rememberCheckBox;
        private ListBox listBoX;
        private DateTimePicker dateTimePicker1;
        private ListBox speltBox;
        private ErrorProvider errorProvider1;
    }
}