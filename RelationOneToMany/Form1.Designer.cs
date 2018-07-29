namespace RelationOneToMany
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
            this.Button_Add = new System.Windows.Forms.Button();
            this.Button_Do = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_Add
            // 
            this.Button_Add.Location = new System.Drawing.Point(0, 0);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(316, 85);
            this.Button_Add.TabIndex = 0;
            this.Button_Add.Text = "Add some Country";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // Button_Do
            // 
            this.Button_Do.Location = new System.Drawing.Point(0, 91);
            this.Button_Do.Name = "Button_Do";
            this.Button_Do.Size = new System.Drawing.Size(316, 109);
            this.Button_Do.TabIndex = 1;
            this.Button_Do.Text = "Do Something";
            this.Button_Do.UseVisualStyleBackColor = true;
            this.Button_Do.Click += new System.EventHandler(this.Button_Do_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 410);
            this.Controls.Add(this.Button_Do);
            this.Controls.Add(this.Button_Add);
            this.Name = "Form1";
            this.Text = "Relation One To Many";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.Button Button_Do;
    }
}

