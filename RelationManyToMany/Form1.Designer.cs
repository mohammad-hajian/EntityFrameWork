namespace RelationManyToMany
{
    partial class Form
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
            this.button_Record = new System.Windows.Forms.Button();
            this.button_Add_Groups = new System.Windows.Forms.Button();
            this.button_Add_Users = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Record
            // 
            this.button_Record.Location = new System.Drawing.Point(0, 0);
            this.button_Record.Name = "button_Record";
            this.button_Record.Size = new System.Drawing.Size(271, 89);
            this.button_Record.TabIndex = 0;
            this.button_Record.Text = "Add New Record";
            this.button_Record.UseVisualStyleBackColor = true;
            this.button_Record.Click += new System.EventHandler(this.button_Record_Click);
            // 
            // button_Add_Groups
            // 
            this.button_Add_Groups.Location = new System.Drawing.Point(0, 95);
            this.button_Add_Groups.Name = "button_Add_Groups";
            this.button_Add_Groups.Size = new System.Drawing.Size(271, 100);
            this.button_Add_Groups.TabIndex = 1;
            this.button_Add_Groups.Text = "Add Groups To User";
            this.button_Add_Groups.UseVisualStyleBackColor = true;
            this.button_Add_Groups.Click += new System.EventHandler(this.button_Add_Groups_Click);
            // 
            // button_Add_Users
            // 
            this.button_Add_Users.Location = new System.Drawing.Point(0, 201);
            this.button_Add_Users.Name = "button_Add_Users";
            this.button_Add_Users.Size = new System.Drawing.Size(271, 92);
            this.button_Add_Users.TabIndex = 2;
            this.button_Add_Users.Text = "Add Users To Groups";
            this.button_Add_Users.UseVisualStyleBackColor = true;
            this.button_Add_Users.Click += new System.EventHandler(this.button_Add_Users_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 293);
            this.Controls.Add(this.button_Add_Users);
            this.Controls.Add(this.button_Add_Groups);
            this.Controls.Add(this.button_Record);
            this.Name = "Form";
            this.Text = "RelationManyToMany";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Record;
        private System.Windows.Forms.Button button_Add_Groups;
        private System.Windows.Forms.Button button_Add_Users;
    }
}

