﻿namespace ShapeForm
{
    partial class LineForm
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
            this.linePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // linePanel
            // 
            this.linePanel.Location = new System.Drawing.Point(12, 12);
            this.linePanel.Name = "linePanel";
            this.linePanel.Size = new System.Drawing.Size(256, 238);
            this.linePanel.TabIndex = 0;
            this.linePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.linePanel_Paint);
            // 
            // LineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.linePanel);
            this.Name = "LineForm";
            this.Text = "LineForm";
            this.Load += new System.EventHandler(this.LineForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel linePanel;
    }
}