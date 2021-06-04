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
            this.view_btn = new System.Windows.Forms.Button();
            this.gender_label = new System.Windows.Forms.Label();
            this.male_chckbx = new System.Windows.Forms.CheckBox();
            this.female_chckbx = new System.Windows.Forms.CheckBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.time_label = new System.Windows.Forms.Label();
            this.date_label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cntct_trcng_txt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name_txtbox
            // 
            this.name_txtbox.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.name_txtbox.Location = new System.Drawing.Point(43, 132);
            this.name_txtbox.Name = "name_txtbox";
            this.name_txtbox.Size = new System.Drawing.Size(373, 26);
            this.name_txtbox.TabIndex = 0;
            // 
            // age_txtbox
            // 
            this.age_txtbox.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.age_txtbox.Location = new System.Drawing.Point(44, 230);
            this.age_txtbox.Name = "age_txtbox";
            this.age_txtbox.Size = new System.Drawing.Size(373, 26);
            this.age_txtbox.TabIndex = 1;
            // 
            // address_txtbox
            // 
            this.address_txtbox.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.address_txtbox.Location = new System.Drawing.Point(43, 281);
            this.address_txtbox.Name = "address_txtbox";
            this.address_txtbox.Size = new System.Drawing.Size(373, 26);
            this.address_txtbox.TabIndex = 2;
            // 
            // cpnumber_txtbox
            // 
            this.cpnumber_txtbox.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.cpnumber_txtbox.Location = new System.Drawing.Point(44, 332);
            this.cpnumber_txtbox.Name = "cpnumber_txtbox";
            this.cpnumber_txtbox.Size = new System.Drawing.Size(373, 26);
            this.cpnumber_txtbox.TabIndex = 3;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Tahoma", 10F);
            this.name_label.Location = new System.Drawing.Point(40, 110);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(43, 17);
            this.name_label.TabIndex = 4;
            this.name_label.Text = "Name";
            // 
            // age_label
            // 
            this.age_label.AutoSize = true;
            this.age_label.Font = new System.Drawing.Font("Tahoma", 10F);
            this.age_label.Location = new System.Drawing.Point(40, 208);
            this.age_label.Name = "age_label";
            this.age_label.Size = new System.Drawing.Size(31, 17);
            this.age_label.TabIndex = 5;
            this.age_label.Text = "Age";
            // 
            // Address_Label
            // 
            this.Address_Label.AutoSize = true;
            this.Address_Label.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Address_Label.Location = new System.Drawing.Point(40, 259);
            this.Address_Label.Name = "Address_Label";
            this.Address_Label.Size = new System.Drawing.Size(56, 17);
            this.Address_Label.TabIndex = 6;
            this.Address_Label.Text = "Address";
            // 
            // cpnumber_label
            // 
            this.cpnumber_label.AutoSize = true;
            this.cpnumber_label.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cpnumber_label.Location = new System.Drawing.Point(40, 310);
            this.cpnumber_label.Name = "cpnumber_label";
            this.cpnumber_label.Size = new System.Drawing.Size(100, 17);
            this.cpnumber_label.TabIndex = 7;
            this.cpnumber_label.Text = "Phone Number";
            // 
            // view_btn
            // 
            this.view_btn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.view_btn.Location = new System.Drawing.Point(341, 381);
            this.view_btn.Name = "view_btn";
            this.view_btn.Size = new System.Drawing.Size(75, 31);
            this.view_btn.TabIndex = 8;
            this.view_btn.Text = "View File";
            this.view_btn.UseVisualStyleBackColor = true;
            this.view_btn.Click += new System.EventHandler(this.enter_btn_Click);
            // 
            // gender_label
            // 
            this.gender_label.AutoSize = true;
            this.gender_label.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gender_label.Location = new System.Drawing.Point(40, 161);
            this.gender_label.Name = "gender_label";
            this.gender_label.Size = new System.Drawing.Size(52, 17);
            this.gender_label.TabIndex = 11;
            this.gender_label.Text = "Gender";
            // 
            // male_chckbx
            // 
            this.male_chckbx.AutoSize = true;
            this.male_chckbx.Font = new System.Drawing.Font("Tahoma", 10F);
            this.male_chckbx.Location = new System.Drawing.Point(74, 183);
            this.male_chckbx.Name = "male_chckbx";
            this.male_chckbx.Size = new System.Drawing.Size(53, 21);
            this.male_chckbx.TabIndex = 12;
            this.male_chckbx.Text = "Male";
            this.male_chckbx.UseVisualStyleBackColor = true;
            this.male_chckbx.CheckedChanged += new System.EventHandler(this.male_chckbx_CheckedChanged);
            // 
            // female_chckbx
            // 
            this.female_chckbx.AutoSize = true;
            this.female_chckbx.Font = new System.Drawing.Font("Tahoma", 10F);
            this.female_chckbx.Location = new System.Drawing.Point(139, 183);
            this.female_chckbx.Name = "female_chckbx";
            this.female_chckbx.Size = new System.Drawing.Size(69, 21);
            this.female_chckbx.TabIndex = 13;
            this.female_chckbx.Text = "Female";
            this.female_chckbx.UseVisualStyleBackColor = true;
            this.female_chckbx.CheckedChanged += new System.EventHandler(this.female_chckbox_CheckedChanged);
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.add_btn.Location = new System.Drawing.Point(243, 381);
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
            this.time_label.Font = new System.Drawing.Font("Tahoma", 10F);
            this.time_label.Location = new System.Drawing.Point(1, 18);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(37, 17);
            this.time_label.TabIndex = 15;
            this.time_label.Text = "Time";
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Font = new System.Drawing.Font("Tahoma", 10F);
            this.date_label.Location = new System.Drawing.Point(1, -1);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(37, 17);
            this.date_label.TabIndex = 16;
            this.date_label.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cntct_trcng_txt
            // 
            this.cntct_trcng_txt.AutoSize = true;
            this.cntct_trcng_txt.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Bold);
            this.cntct_trcng_txt.Location = new System.Drawing.Point(101, 52);
            this.cntct_trcng_txt.Name = "cntct_trcng_txt";
            this.cntct_trcng_txt.Size = new System.Drawing.Size(252, 38);
            this.cntct_trcng_txt.TabIndex = 17;
            this.cntct_trcng_txt.Text = "Contact Tracing";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 436);
            this.Controls.Add(this.cntct_trcng_txt);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.female_chckbx);
            this.Controls.Add(this.male_chckbx);
            this.Controls.Add(this.gender_label);
            this.Controls.Add(this.view_btn);
            this.Controls.Add(this.cpnumber_label);
            this.Controls.Add(this.Address_Label);
            this.Controls.Add(this.age_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.cpnumber_txtbox);
            this.Controls.Add(this.address_txtbox);
            this.Controls.Add(this.age_txtbox);
            this.Controls.Add(this.name_txtbox);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
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
        private System.Windows.Forms.Button view_btn;
        private System.Windows.Forms.Label gender_label;
        private System.Windows.Forms.CheckBox male_chckbx;
        private System.Windows.Forms.CheckBox female_chckbx;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label cntct_trcng_txt;
    }
}

