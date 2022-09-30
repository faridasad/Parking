namespace Parking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.entry_button = new System.Windows.Forms.Button();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.availableBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.headerText = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.detailsBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusText = new System.Windows.Forms.Label();
            this.userInput = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // entry_button
            // 
            this.entry_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.entry_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.entry_button.Location = new System.Drawing.Point(34, 122);
            this.entry_button.Name = "entry_button";
            this.entry_button.Size = new System.Drawing.Size(133, 42);
            this.entry_button.TabIndex = 0;
            this.entry_button.Text = "ENTER";
            this.entry_button.UseVisualStyleBackColor = false;
            this.entry_button.Click += new System.EventHandler(this.entry_button_Click);
            // 
            // totalBox
            // 
            this.totalBox.Location = new System.Drawing.Point(555, 130);
            this.totalBox.Name = "totalBox";
            this.totalBox.ReadOnly = true;
            this.totalBox.Size = new System.Drawing.Size(57, 22);
            this.totalBox.TabIndex = 2;
            this.totalBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // availableBox
            // 
            this.availableBox.Location = new System.Drawing.Point(555, 189);
            this.availableBox.Name = "availableBox";
            this.availableBox.ReadOnly = true;
            this.availableBox.Size = new System.Drawing.Size(57, 22);
            this.availableBox.TabIndex = 3;
            this.availableBox.TextChanged += new System.EventHandler(this.availableBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Uni Sans Book", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(461, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "available";
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.headerText.Font = new System.Drawing.Font("Open Sans Condensed SemiBold", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.ForeColor = System.Drawing.Color.White;
            this.headerText.Location = new System.Drawing.Point(34, 21);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(212, 62);
            this.headerText.TabIndex = 6;
            this.headerText.Text = "P A R K I N G";
            this.headerText.Click += new System.EventHandler(this.label3_Click);
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.exit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_button.Location = new System.Drawing.Point(34, 181);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(133, 43);
            this.exit_button.TabIndex = 7;
            this.exit_button.Text = "EXIT";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // detailsBox
            // 
            this.detailsBox.FormattingEnabled = true;
            this.detailsBox.ItemHeight = 16;
            this.detailsBox.Location = new System.Drawing.Point(34, 275);
            this.detailsBox.Name = "detailsBox";
            this.detailsBox.Size = new System.Drawing.Size(579, 212);
            this.detailsBox.TabIndex = 8;
            this.detailsBox.SelectedIndexChanged += new System.EventHandler(this.detailsBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Uni Sans Book", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(461, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "total";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // statusText
            // 
            this.statusText.AutoSize = true;
            this.statusText.BackColor = System.Drawing.Color.Transparent;
            this.statusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusText.ForeColor = System.Drawing.Color.IndianRed;
            this.statusText.Location = new System.Drawing.Point(31, 254);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(0, 18);
            this.statusText.TabIndex = 10;
            // 
            // userInput
            // 
            this.userInput.Location = new System.Drawing.Point(504, 21);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(108, 22);
            this.userInput.TabIndex = 11;
            this.userInput.TextChanged += new System.EventHandler(this.userInput_TextChanged);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(537, 56);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 27);
            this.loginButton.TabIndex = 12;
            this.loginButton.Text = "Log in";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(701, 512);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.userInput);
            this.Controls.Add(this.statusText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.detailsBox);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.headerText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.availableBox);
            this.Controls.Add(this.totalBox);
            this.Controls.Add(this.entry_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "PARKING";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button entry_button;
        private System.Windows.Forms.TextBox totalBox;
        private System.Windows.Forms.TextBox availableBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.ListBox detailsBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label statusText;
        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.Button loginButton;
    }
}

