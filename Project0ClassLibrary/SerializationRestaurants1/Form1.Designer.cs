namespace SerializationRestaurants1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Restaurant_textbox = new System.Windows.Forms.TextBox();
            this.Restaurant_label = new System.Windows.Forms.Label();
            this.Address_textbox = new System.Windows.Forms.TextBox();
            this.Address_label = new System.Windows.Forms.Label();
            this.textbox_email = new System.Windows.Forms.TextBox();
            this.Phone_label = new System.Windows.Forms.Label();
            this.textbox_phone = new System.Windows.Forms.TextBox();
            this.Email_label = new System.Windows.Forms.Label();
            this.Rating_textbox = new System.Windows.Forms.TextBox();
            this.Rating_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(453, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Restaurant_textbox
            // 
            this.Restaurant_textbox.Location = new System.Drawing.Point(286, 55);
            this.Restaurant_textbox.Name = "Restaurant_textbox";
            this.Restaurant_textbox.Size = new System.Drawing.Size(242, 20);
            this.Restaurant_textbox.TabIndex = 2;
            // 
            // Restaurant_label
            // 
            this.Restaurant_label.AutoSize = true;
            this.Restaurant_label.Location = new System.Drawing.Point(177, 62);
            this.Restaurant_label.Name = "Restaurant_label";
            this.Restaurant_label.Size = new System.Drawing.Size(93, 13);
            this.Restaurant_label.TabIndex = 3;
            this.Restaurant_label.Text = "Restaurant Name:";
            this.Restaurant_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Address_textbox
            // 
            this.Address_textbox.Location = new System.Drawing.Point(286, 111);
            this.Address_textbox.Name = "Address_textbox";
            this.Address_textbox.Size = new System.Drawing.Size(242, 20);
            this.Address_textbox.TabIndex = 4;
            // 
            // Address_label
            // 
            this.Address_label.AutoSize = true;
            this.Address_label.Location = new System.Drawing.Point(219, 118);
            this.Address_label.Name = "Address_label";
            this.Address_label.Size = new System.Drawing.Size(48, 13);
            this.Address_label.TabIndex = 5;
            this.Address_label.Text = "Address:";
            this.Address_label.Click += new System.EventHandler(this.Address_label_Click);
            // 
            // textbox_email
            // 
            this.textbox_email.Location = new System.Drawing.Point(286, 166);
            this.textbox_email.Name = "textbox_email";
            this.textbox_email.Size = new System.Drawing.Size(242, 20);
            this.textbox_email.TabIndex = 6;
            // 
            // Phone_label
            // 
            this.Phone_label.AutoSize = true;
            this.Phone_label.Location = new System.Drawing.Point(232, 173);
            this.Phone_label.Name = "Phone_label";
            this.Phone_label.Size = new System.Drawing.Size(35, 13);
            this.Phone_label.TabIndex = 7;
            this.Phone_label.Text = "Email:";
            // 
            // textbox_phone
            // 
            this.textbox_phone.Location = new System.Drawing.Point(286, 227);
            this.textbox_phone.Name = "textbox_phone";
            this.textbox_phone.Size = new System.Drawing.Size(242, 20);
            this.textbox_phone.TabIndex = 8;
            // 
            // Email_label
            // 
            this.Email_label.AutoSize = true;
            this.Email_label.Location = new System.Drawing.Point(226, 234);
            this.Email_label.Name = "Email_label";
            this.Email_label.Size = new System.Drawing.Size(41, 13);
            this.Email_label.TabIndex = 9;
            this.Email_label.Text = "Phone:";
            // 
            // Rating_textbox
            // 
            this.Rating_textbox.Location = new System.Drawing.Point(286, 279);
            this.Rating_textbox.Name = "Rating_textbox";
            this.Rating_textbox.Size = new System.Drawing.Size(242, 20);
            this.Rating_textbox.TabIndex = 10;
            // 
            // Rating_label
            // 
            this.Rating_label.AutoSize = true;
            this.Rating_label.Location = new System.Drawing.Point(183, 286);
            this.Rating_label.Name = "Rating_label";
            this.Rating_label.Size = new System.Drawing.Size(84, 13);
            this.Rating_label.TabIndex = 11;
            this.Rating_label.Text = "Average Rating:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Rating_label);
            this.Controls.Add(this.Rating_textbox);
            this.Controls.Add(this.Email_label);
            this.Controls.Add(this.textbox_phone);
            this.Controls.Add(this.Phone_label);
            this.Controls.Add(this.textbox_email);
            this.Controls.Add(this.Address_label);
            this.Controls.Add(this.Address_textbox);
            this.Controls.Add(this.Restaurant_label);
            this.Controls.Add(this.Restaurant_textbox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Restaurant_textbox;
        private System.Windows.Forms.Label Restaurant_label;
        private System.Windows.Forms.TextBox Address_textbox;
        private System.Windows.Forms.Label Address_label;
        private System.Windows.Forms.TextBox textbox_email;
        private System.Windows.Forms.Label Phone_label;
        private System.Windows.Forms.TextBox textbox_phone;
        private System.Windows.Forms.Label Email_label;
        private System.Windows.Forms.TextBox Rating_textbox;
        private System.Windows.Forms.Label Rating_label;
    }
}

