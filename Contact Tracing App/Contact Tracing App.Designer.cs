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
            this.address_txtboc = new System.Windows.Forms.TextBox();
            this.cpnumber_txtbox = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.age_label = new System.Windows.Forms.Label();
            this.Address_Label = new System.Windows.Forms.Label();
            this.cpnumber_label = new System.Windows.Forms.Label();
            this.enter_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_txtbox
            // 
            this.name_txtbox.Location = new System.Drawing.Point(41, 62);
            this.name_txtbox.Name = "name_txtbox";
            this.name_txtbox.Size = new System.Drawing.Size(373, 20);
            this.name_txtbox.TabIndex = 0;
            // 
            // age_txtbox
            // 
            this.age_txtbox.Location = new System.Drawing.Point(41, 108);
            this.age_txtbox.Name = "age_txtbox";
            this.age_txtbox.Size = new System.Drawing.Size(373, 20);
            this.age_txtbox.TabIndex = 1;
            // 
            // address_txtboc
            // 
            this.address_txtboc.Location = new System.Drawing.Point(41, 153);
            this.address_txtboc.Name = "address_txtboc";
            this.address_txtboc.Size = new System.Drawing.Size(373, 20);
            this.address_txtboc.TabIndex = 2;
            // 
            // cpnumber_txtbox
            // 
            this.cpnumber_txtbox.Location = new System.Drawing.Point(41, 197);
            this.cpnumber_txtbox.Name = "cpnumber_txtbox";
            this.cpnumber_txtbox.Size = new System.Drawing.Size(373, 20);
            this.cpnumber_txtbox.TabIndex = 3;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(38, 46);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(35, 13);
            this.name_label.TabIndex = 4;
            this.name_label.Text = "Name";
            // 
            // age_label
            // 
            this.age_label.AutoSize = true;
            this.age_label.Location = new System.Drawing.Point(38, 92);
            this.age_label.Name = "age_label";
            this.age_label.Size = new System.Drawing.Size(26, 13);
            this.age_label.TabIndex = 5;
            this.age_label.Text = "Age";
            // 
            // Address_Label
            // 
            this.Address_Label.AutoSize = true;
            this.Address_Label.Location = new System.Drawing.Point(38, 137);
            this.Address_Label.Name = "Address_Label";
            this.Address_Label.Size = new System.Drawing.Size(45, 13);
            this.Address_Label.TabIndex = 6;
            this.Address_Label.Text = "Address";
            // 
            // cpnumber_label
            // 
            this.cpnumber_label.AutoSize = true;
            this.cpnumber_label.Location = new System.Drawing.Point(38, 181);
            this.cpnumber_label.Name = "cpnumber_label";
            this.cpnumber_label.Size = new System.Drawing.Size(78, 13);
            this.cpnumber_label.TabIndex = 7;
            this.cpnumber_label.Text = "Phone Number";
            // 
            // enter_btn
            // 
            this.enter_btn.Location = new System.Drawing.Point(339, 252);
            this.enter_btn.Name = "enter_btn";
            this.enter_btn.Size = new System.Drawing.Size(75, 31);
            this.enter_btn.TabIndex = 8;
            this.enter_btn.Text = "Enter";
            this.enter_btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 309);
            this.Controls.Add(this.enter_btn);
            this.Controls.Add(this.cpnumber_label);
            this.Controls.Add(this.Address_Label);
            this.Controls.Add(this.age_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.cpnumber_txtbox);
            this.Controls.Add(this.address_txtboc);
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
        private System.Windows.Forms.TextBox address_txtboc;
        private System.Windows.Forms.TextBox cpnumber_txtbox;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label age_label;
        private System.Windows.Forms.Label Address_Label;
        private System.Windows.Forms.Label cpnumber_label;
        private System.Windows.Forms.Button enter_btn;
    }
}

