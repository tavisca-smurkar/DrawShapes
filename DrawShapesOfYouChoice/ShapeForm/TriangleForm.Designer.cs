namespace ShapeForm
{
    partial class TriangleForm
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
            this.trianglePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // trianglePanel
            // 
            this.trianglePanel.Location = new System.Drawing.Point(12, 12);
            this.trianglePanel.Name = "trianglePanel";
            this.trianglePanel.Size = new System.Drawing.Size(688, 512);
            this.trianglePanel.TabIndex = 0;
            // 
            // TriangleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 536);
            this.Controls.Add(this.trianglePanel);
            this.Name = "TriangleForm";
            this.Text = "TriangleForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel trianglePanel;
    }
}