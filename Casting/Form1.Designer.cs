namespace Casting
{
    partial class Casting
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
            this.listBoxCountry = new System.Windows.Forms.ListBox();
            this.listBoxState = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxCountry
            // 
            this.listBoxCountry.FormattingEnabled = true;
            this.listBoxCountry.Location = new System.Drawing.Point(0, 0);
            this.listBoxCountry.Name = "listBoxCountry";
            this.listBoxCountry.Size = new System.Drawing.Size(434, 134);
            this.listBoxCountry.TabIndex = 0;
            this.listBoxCountry.SelectedIndexChanged += new System.EventHandler(this.listBoxCountry_SelectedIndexChanged);
            // 
            // listBoxState
            // 
            this.listBoxState.FormattingEnabled = true;
            this.listBoxState.Location = new System.Drawing.Point(1, 131);
            this.listBoxState.Name = "listBoxState";
            this.listBoxState.Size = new System.Drawing.Size(433, 355);
            this.listBoxState.TabIndex = 1;
            // 
            // Casting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 487);
            this.Controls.Add(this.listBoxState);
            this.Controls.Add(this.listBoxCountry);
            this.Name = "Casting";
            this.Text = "Casting";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Casting_FormClosed);
            this.Load += new System.EventHandler(this.Casting_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCountry;
        private System.Windows.Forms.ListBox listBoxState;
    }
}

