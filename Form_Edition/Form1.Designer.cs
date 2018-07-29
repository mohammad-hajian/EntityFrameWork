namespace Form_Edition
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
            this.Button_Add = new System.Windows.Forms.Button();
            this.Button_Check = new System.Windows.Forms.Button();
            this.Button_DeleteName = new System.Windows.Forms.Button();
            this.Button_Delete = new System.Windows.Forms.Button();
            this.Button_Show = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Button_Add
            // 
            this.Button_Add.Location = new System.Drawing.Point(0, 0);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(419, 42);
            this.Button_Add.TabIndex = 0;
            this.Button_Add.Text = "Add New Countries";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // Button_Check
            // 
            this.Button_Check.Location = new System.Drawing.Point(0, 362);
            this.Button_Check.Name = "Button_Check";
            this.Button_Check.Size = new System.Drawing.Size(419, 41);
            this.Button_Check.TabIndex = 1;
            this.Button_Check.Text = "Check";
            this.Button_Check.UseVisualStyleBackColor = true;
            this.Button_Check.Click += new System.EventHandler(this.Button_Check_Click);
            // 
            // Button_DeleteName
            // 
            this.Button_DeleteName.Location = new System.Drawing.Point(0, 287);
            this.Button_DeleteName.Name = "Button_DeleteName";
            this.Button_DeleteName.Size = new System.Drawing.Size(419, 43);
            this.Button_DeleteName.TabIndex = 2;
            this.Button_DeleteName.Text = "Delete a Country By Name";
            this.Button_DeleteName.UseVisualStyleBackColor = true;
            this.Button_DeleteName.Click += new System.EventHandler(this.Button_DeleteName_Click);
            // 
            // Button_Delete
            // 
            this.Button_Delete.Location = new System.Drawing.Point(0, 239);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(419, 42);
            this.Button_Delete.TabIndex = 3;
            this.Button_Delete.Text = "Delete All Countries";
            this.Button_Delete.UseVisualStyleBackColor = true;
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // Button_Show
            // 
            this.Button_Show.Location = new System.Drawing.Point(0, 48);
            this.Button_Show.Name = "Button_Show";
            this.Button_Show.Size = new System.Drawing.Size(419, 45);
            this.Button_Show.TabIndex = 4;
            this.Button_Show.Text = "Show All Countries";
            this.Button_Show.UseVisualStyleBackColor = true;
            this.Button_Show.Click += new System.EventHandler(this.Button_Show_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 336);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(419, 20);
            this.textBox1.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 99);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(419, 134);
            this.listBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 404);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Button_Show);
            this.Controls.Add(this.Button_Delete);
            this.Controls.Add(this.Button_DeleteName);
            this.Controls.Add(this.Button_Check);
            this.Controls.Add(this.Button_Add);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Countries";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.Button Button_Check;
        private System.Windows.Forms.Button Button_DeleteName;
        private System.Windows.Forms.Button Button_Delete;
        private System.Windows.Forms.Button Button_Show;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

