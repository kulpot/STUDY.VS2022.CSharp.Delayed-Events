namespace Delayed_Events
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
            this.textBox21 = new Delayed_Events.TextBox2();
            this.SuspendLayout();
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(12, 12);
            this.textBox21.Multiline = true;
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(401, 198);
            this.textBox21.TabIndex = 0;
            this.textBox21.TextChangedDelayedInterval = 1000;
            this.textBox21.TextChangedDelayed += new System.EventHandler(this.textBox21_TextChangedDelayed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.textBox21);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox2 textBox21;
    }
}

