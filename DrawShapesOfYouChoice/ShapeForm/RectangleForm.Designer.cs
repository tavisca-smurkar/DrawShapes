namespace ShapeForm
{
    partial class RectangleForm
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
            this.reactanglePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // reactanglePanel
            // 
            this.reactanglePanel.Location = new System.Drawing.Point(12, 12);
            this.reactanglePanel.Name = "reactanglePanel";
            this.reactanglePanel.Size = new System.Drawing.Size(903, 533);
            this.reactanglePanel.TabIndex = 0;
            // 
            // RectangleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 557);
            this.Controls.Add(this.reactanglePanel);
            this.Name = "RectangleForm";
            this.Text = "RectangleForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel reactanglePanel;
    }
}