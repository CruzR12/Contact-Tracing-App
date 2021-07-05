namespace Contact_Tracing_App
{
    partial class Contact_Tracing_App_File_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contact_Tracing_App_File_View));
            this.fileview_box = new System.Windows.Forms.RichTextBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.view_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fileview_box
            // 
            this.fileview_box.Location = new System.Drawing.Point(8, 8);
            this.fileview_box.Name = "fileview_box";
            this.fileview_box.Size = new System.Drawing.Size(440, 375);
            this.fileview_box.TabIndex = 0;
            this.fileview_box.Text = "";
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.back_btn.Location = new System.Drawing.Point(8, 393);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 31);
            this.back_btn.TabIndex = 16;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // view_btn
            // 
            this.view_btn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.view_btn.Location = new System.Drawing.Point(373, 393);
            this.view_btn.Name = "view_btn";
            this.view_btn.Size = new System.Drawing.Size(75, 31);
            this.view_btn.TabIndex = 17;
            this.view_btn.Text = "View";
            this.view_btn.UseVisualStyleBackColor = true;
            this.view_btn.Click += new System.EventHandler(this.view_btn_Click);
            // 
            // Contact_Tracing_App_File_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 436);
            this.Controls.Add(this.view_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.fileview_box);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Contact_Tracing_App_File_View";
            this.Text = "Contact Tracing App";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox fileview_box;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button view_btn;
    }
}