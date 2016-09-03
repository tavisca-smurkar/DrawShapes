namespace ShapeForm
{
    partial class CircleForm
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
            this.circlePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // circlePanel
            // 
            this.circlePanel.Location = new System.Drawing.Point(12, 12);
            this.circlePanel.Name = "circlePanel";
            this.circlePanel.Size = new System.Drawing.Size(607, 515);
            this.circlePanel.TabIndex = 0;
            // 
            // CircleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 539);
            this.Controls.Add(this.circlePanel);
            this.Name = "CircleForm";
            this.Text = "CircleForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel circlePanel;
    }
}