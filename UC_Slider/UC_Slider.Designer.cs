namespace UC_Slider
{
    partial class UC_Slider
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // UC_Slider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UC_Slider";
            this.Load += new System.EventHandler(this.UC_Slider_Load);
            this.BackColorChanged += new System.EventHandler(this.UC_Slider_BackColorChanged);
            this.SizeChanged += new System.EventHandler(this.UC_Slider_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UC_Slider_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UC_Slider_MouseDown);
            this.MouseEnter += new System.EventHandler(this.UC_Slider_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UC_Slider_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UC_Slider_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UC_Slider_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
