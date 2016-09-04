namespace ShapeForm
{
    partial class HexagonForm
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
            this.hexagonPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // hexagonPanel
            // 
            this.hexagonPanel.Location = new System.Drawing.Point(12, 12);
            this.hexagonPanel.Name = "hexagonPanel";
            this.hexagonPanel.Size = new System.Drawing.Size(713, 512);
            this.hexagonPanel.TabIndex = 0;
            // 
            // HexagonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 536);
            this.Controls.Add(this.hexagonPanel);
            this.Name = "HexagonForm";
            this.Text = "HexagonForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel hexagonPanel;
    }
}