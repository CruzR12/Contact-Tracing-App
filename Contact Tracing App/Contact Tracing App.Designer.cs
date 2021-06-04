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
            this.components = new System.ComponentModel.Container();
            this.name_txtbox = new System.Windows.Forms.TextBox();
            this.age_txtbox = new System.Windows.Forms.TextBox();
            this.address_txtbox = new System.Windows.Forms.TextBox();
            this.cpnumber_txtbox = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.age_label = new System.Windows.Forms.Label();
            this.Address_Label = new System.Windows.Forms.Label();
            this.cpnumber_label = new System.Windows.Forms.Label();
            this.enter_btn = new System.Windows.Forms.Button();
            this.gender_label = new System.Windows.Forms.Label();
            this.male_chckbx = new System.Windows.Forms.CheckBox();
            this.female_chckbx = new System.Windows.Forms.CheckBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.time_label = new System.Windows.Forms.Label();
            this.date_label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // name_txtbox
            // 
            this.name_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_txtbox.Location = new System.Drawing.Point(43, 126);
            this.name_txtbox.Name = "name_txtbox";
            this.name_txtbox.Size = new System.Drawing.Size(373, 24);
            this.name_txtbox.TabIndex = 0;
            // 
            // age_txtbox
            // 
            this.age_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age_txtbox.Location = new System.Drawing.Point(44, 213);
            this.age_txtbox.Name = "age_txtbox";
            this.age_txtbox.Size = new System.Drawing.Size(373, 24);
            this.age_txtbox.TabIndex = 1;
            // 
            // address_txtbox
            // 
            this.address_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_txtbox.Location = new System.Drawing.Point(43, 262);
            this.address_txtbox.Name = "address_txtbox";
            this.address_txtbox.Size = new System.Drawing.Size(373, 24);
            this.address_txtbox.TabIndex = 2;
            // 
            // cpnumber_txtbox
            // 
            this.cpnumber_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpnumber_txtbox.Location = new System.Drawing.Point(43, 311);
            this.cpnumber_txtbox.Name = "cpnumber_txtbox";
            this.cpnumber_txtbox.Size = new System.Drawing.Size(373, 24);
            this.cpnumber_txtbox.TabIndex = 3;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.name_label.Location = new System.Drawing.Point(40, 104);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(46, 19);
            this.name_label.TabIndex = 4;
            this.name_label.Text = "Name";
            // 
            // age_label
            // 
            this.age_label.AutoSize = true;
            this.age_label.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.age_label.Location = new System.Drawing.Point(40, 191);
            this.age_label.Name = "age_label";
            this.age_label.Size = new System.Drawing.Size(34, 19);
            this.age_label.TabIndex = 5;
            this.age_label.Text = "Age";
            // 
            // Address_Label
            // 
            this.Address_Label.AutoSize = true;
            this.Address_Label.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Address_Label.Location = new System.Drawing.Point(40, 240);
            this.Address_Label.Name = "Address_Label";
            this.Address_Label.Size = new System.Drawing.Size(60, 19);
            this.Address_Label.TabIndex = 6;
            this.Address_Label.Text = "Address";
            // 
            // cpnumber_label
            // 
            this.cpnumber_label.AutoSize = true;
            this.cpnumber_label.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cpnumber_label.Location = new System.Drawing.Point(40, 289);
            this.cpnumber_label.Name = "cpnumber_label";
            this.cpnumber_label.Size = new System.Drawing.Size(101, 19);
            this.cpnumber_label.TabIndex = 7;
            this.cpnumber_label.Text = "Phone Number";
            // 
            // enter_btn
            // 
            this.enter_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_btn.Location = new System.Drawing.Point(341, 358);
            this.enter_btn.Name = "enter_btn";
            this.enter_btn.Size = new System.Drawing.Size(75, 31);
            this.enter_btn.TabIndex = 8;
            this.enter_btn.Text = "Enter";
            this.enter_btn.UseVisualStyleBackColor = true;
            this.enter_btn.Click += new System.EventHandler(this.enter_btn_Click);
            // 
            // gender_label
            // 
            this.gender_label.AutoSize = true;
            this.gender_label.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.gender_label.Location = new System.Drawing.Point(40, 153);
            this.gender_label.Name = "gender_label";
            this.gender_label.Size = new System.Drawing.Size(54, 19);
            this.gender_label.TabIndex = 11;
            this.gender_label.Text = "Gender";
            // 
            // male_chckbx
            // 
            this.male_chckbx.AutoSize = true;
            this.male_chckbx.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.male_chckbx.Location = new System.Drawing.Point(73, 172);
            this.male_chckbx.Name = "male_chckbx";
            this.male_chckbx.Size = new System.Drawing.Size(59, 23);
            this.male_chckbx.TabIndex = 12;
            this.male_chckbx.Text = "Male";
            this.male_chckbx.UseVisualStyleBackColor = true;
            this.male_chckbx.CheckedChanged += new System.EventHandler(this.male_chckbx_CheckedChanged);
            // 
            // female_chckbx
            // 
            this.female_chckbx.AutoSize = true;
            this.female_chckbx.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.female_chckbx.Location = new System.Drawing.Point(138, 172);
            this.female_chckbx.Name = "female_chckbx";
            this.female_chckbx.Size = new System.Drawing.Size(72, 23);
            this.female_chckbx.TabIndex = 13;
            this.female_chckbx.Text = "Female";
            this.female_chckbx.UseVisualStyleBackColor = true;
            this.female_chckbx.CheckedChanged += new System.EventHandler(this.female_chckbox_CheckedChanged);
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(243, 358);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 31);
            this.add_btn.TabIndex = 14;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_label.Location = new System.Drawing.Point(1, 18);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(38, 19);
            this.time_label.TabIndex = 15;
            this.time_label.Text = "Time";
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_label.Location = new System.Drawing.Point(1, -1);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(38, 19);
            this.date_label.TabIndex = 16;
            this.date_label.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 416);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.female_chckbx);
            this.Controls.Add(this.male_chckbx);
            this.Controls.Add(this.gender_label);
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
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Label gender_label;
        private System.Windows.Forms.CheckBox male_chckbx;
        private System.Windows.Forms.CheckBox female_chckbx;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.Timer timer1;
    }
}

