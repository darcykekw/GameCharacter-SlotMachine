namespace WinformGameCharacter1
{
    partial class StartForm
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
            this.txtExit = new System.Windows.Forms.Button();
            this.txtStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtExit
            // 
            this.txtExit.BackColor = System.Drawing.SystemColors.Control;
            this.txtExit.BackgroundImage = global::WinformGameCharacter1.Properties.Resources.Screenshot_2024_12_04_0852101;
            this.txtExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtExit.Location = new System.Drawing.Point(411, 218);
            this.txtExit.Name = "txtExit";
            this.txtExit.Size = new System.Drawing.Size(125, 66);
            this.txtExit.TabIndex = 0;
            this.txtExit.UseVisualStyleBackColor = false;
            this.txtExit.Click += new System.EventHandler(this.txtExit_Click);
            // 
            // txtStart
            // 
            this.txtStart.BackgroundImage = global::WinformGameCharacter1.Properties.Resources.Screenshot_2024_12_04_0851551;
            this.txtStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtStart.Location = new System.Drawing.Point(210, 218);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(136, 66);
            this.txtStart.TabIndex = 1;
            this.txtStart.UseVisualStyleBackColor = true;
            this.txtStart.Click += new System.EventHandler(this.txtStart_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinformGameCharacter1.Properties.Resources.Screenshot_2024_12_01_173958;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.txtExit);
            this.DoubleBuffered = true;
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button txtExit;
        private System.Windows.Forms.Button txtStart;
    }
}