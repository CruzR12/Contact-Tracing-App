namespace Contact_Tracing_App
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
            this.name_txtbox = new System.Windows.Forms.TextBox();
            this.age_txtbox = new System.Windows.Forms.TextBox();
            this.address_txtbox = new System.Windows.Forms.TextBox();
            this.cpnumber_txtbox = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.age_label = new System.Windows.Forms.Label();
            this.Address_Label = new System.Windows.Forms.Label();
            this.cpnumber_label = new System.Windows.Forms.Label();
            this.enter_btn = new System.Windows.Forms.Button();
            this.date_and_time = new System.Windows.Forms.DateTimePicker();
            this.gender_label = new System.Windows.Forms.Label();
            this.male_chckbx = new System.Windows.Forms.CheckBox();
            this.female_chckbox = new System.Windows.Forms.CheckBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_txtbox
            // 
            this.name_txtbox.Location = new System.Drawing.Point(43, 126);
            this.name_txtbox.Name = "name_txtbox";
            this.name_txtbox.Size = new System.Drawing.Size(373, 20);
            this.name_txtbox.TabIndex = 0;
            // 
            // age_txtbox
            // 
            this.age_txtbox.Location = new System.Drawing.Point(43, 205);
            this.age_txtbox.Name = "age_txtbox";
            this.age_txtbox.Size = new System.Drawing.Size(373, 20);
            this.age_txtbox.TabIndex = 1;
            // 
            // address_txtbox
            // 
            this.address_txtbox.Location = new System.Drawing.Point(43, 247);
            this.address_txtbox.Name = "address_txtbox";
            this.address_txtbox.Size = new System.Drawing.Size(373, 20);
            this.address_txtbox.TabIndex = 2;
            // 
            // cpnumber_txtbox
            // 
            this.cpnumber_txtbox.Location = new System.Drawing.Point(43, 289);
            this.cpnumber_txtbox.Name = "cpnumber_txtbox";
            this.cpnumber_txtbox.Size = new System.Drawing.Size(373, 20);
            this.cpnumber_txtbox.TabIndex = 3;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(40, 110);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(35, 13);
            this.name_label.TabIndex = 4;
            this.name_label.Text = "Name";
            // 
            // age_label
            // 
            this.age_label.AutoSize = true;
            this.age_label.Location = new System.Drawing.Point(40, 189);
            this.age_label.Name = "age_label";
            this.age_label.Size = new System.Drawing.Size(26, 13);
            this.age_label.TabIndex = 5;
            this.age_label.Text = "Age";
            // 
            // Address_Label
            // 
            this.Address_Label.AutoSize = true;
            this.Address_Label.Location = new System.Drawing.Point(40, 231);
            this.Address_Label.Name = "Address_Label";
            this.Address_Label.Size = new System.Drawing.Size(45, 13);
            this.Address_Label.TabIndex = 6;
            this.Address_Label.Text = "Address";
            // 
            // cpnumber_label
            // 
            this.cpnumber_label.AutoSize = true;
            this.cpnumber_label.Location = new System.Drawing.Point(40, 273);
            this.cpnumber_label.Name = "cpnumber_label";
            this.cpnumber_label.Size = new System.Drawing.Size(78, 13);
            this.cpnumber_label.TabIndex = 7;
            this.cpnumber_label.Text = "Phone Number";
            // 
            // enter_btn
            // 
            this.enter_btn.Location = new System.Drawing.Point(341, 330);
            this.enter_btn.Name = "enter_btn";
            this.enter_btn.Size = new System.Drawing.Size(75, 31);
            this.enter_btn.TabIndex = 8;
            this.enter_btn.Text = "Enter";
            this.enter_btn.UseVisualStyleBackColor = true;
            // 
            // date_and_time
            // 
            this.date_and_time.Location = new System.Drawing.Point(1, 1);
            this.date_and_time.Name = "date_and_time";
            this.date_and_time.Size = new System.Drawing.Size(200, 20);
            this.date_and_time.TabIndex = 9;
            // 
            // gender_label
            // 
            this.gender_label.AutoSize = true;
            this.gender_label.Location = new System.Drawing.Point(40, 150);
            this.gender_label.Name = "gender_label";
            this.gender_label.Size = new System.Drawing.Size(42, 13);
            this.gender_label.TabIndex = 11;
            this.gender_label.Text = "Gender";
            // 
            // male_chckbx
            // 
            this.male_chckbx.AutoSize = true;
            this.male_chckbx.Location = new System.Drawing.Point(73, 167);
            this.male_chckbx.Name = "male_chckbx";
            this.male_chckbx.Size = new System.Drawing.Size(49, 17);
            this.male_chckbx.TabIndex = 12;
            this.male_chckbx.Text = "Male";
            this.male_chckbx.UseVisualStyleBackColor = true;
            // 
            // female_chckbox
            // 
            this.female_chckbox.AutoSize = true;
            this.female_chckbox.Location = new System.Drawing.Point(128, 167);
            this.female_chckbox.Name = "female_chckbox";
            this.female_chckbox.Size = new System.Drawing.Size(60, 17);
            this.female_chckbox.TabIndex = 13;
            this.female_chckbox.Text = "Female";
            this.female_chckbox.UseVisualStyleBackColor = true;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(243, 330);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 31);
            this.add_btn.TabIndex = 14;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 392);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.female_chckbox);
            this.Controls.Add(this.male_chckbx);
            this.Controls.Add(this.gender_label);
            this.Controls.Add(this.date_and_time);
            this.Controls.Add(this.enter_btn);
            this.Controls.Add(this.cpnumber_label);
            this.Controls.Add(this.Address_Label);
            this.Controls.Add(this.age_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.cpnumber_txtbox);
            this.Controls.Add(this.address_txtbox);
            this.Controls.Add(this.age_txtbox);
            this.Controls.Add(this.name_txtbox);
            this.Name = "Form1";
            this.Text = "Contact Tracing App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_txtbox;
        private System.Windows.Forms.TextBox age_txtbox;
        private System.Windows.Forms.TextBox address_txtbox;
        private System.Windows.Forms.TextBox cpnumber_txtbox;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label age_label;
        private System.Windows.Forms.Label Address_Label;
        private System.Windows.Forms.Label cpnumber_label;
        private System.Windows.Forms.Button enter_btn;
        private System.Windows.Forms.DateTimePicker date_and_time;
        private System.Windows.Forms.Label gender_label;
        private System.Windows.Forms.CheckBox male_chckbx;
        private System.Windows.Forms.CheckBox female_chckbox;
        private System.Windows.Forms.Button add_btn;
    }
}

