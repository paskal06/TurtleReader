namespace TurtleReader
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
            this.TurtleButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TurtleButton
            // 
            this.TurtleButton.Location = new System.Drawing.Point(13, 13);
            this.TurtleButton.Name = "TurtleButton";
            this.TurtleButton.Size = new System.Drawing.Size(75, 23);
            this.TurtleButton.TabIndex = 0;
            this.TurtleButton.Text = "Start";
            this.TurtleButton.UseVisualStyleBackColor = true;
            this.TurtleButton.Click += new System.EventHandler(this.TurtleButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Change Moves";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 604);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TurtleButton);
            this.Name = "Form1";
            this.Text = "Turtle Reader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TurtleButton;
        private System.Windows.Forms.Button button1;
    }
}

