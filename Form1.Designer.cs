namespace Drawing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxFigur = new System.Windows.Forms.ListBox();
            this.panelCanvas = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // listBoxFigur
            // 
            this.listBoxFigur.FormattingEnabled = true;
            this.listBoxFigur.ItemHeight = 15;
            this.listBoxFigur.Location = new System.Drawing.Point(12, 12);
            this.listBoxFigur.Name = "listBoxFigur";
            this.listBoxFigur.Size = new System.Drawing.Size(182, 259);
            this.listBoxFigur.TabIndex = 0;
            this.listBoxFigur.SelectedIndexChanged += new System.EventHandler(this.listBoxFigur_SelectedIndexChanged);
            // 
            // panelCanvas
            // 
            this.panelCanvas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelCanvas.Location = new System.Drawing.Point(225, 12);
            this.panelCanvas.Name = "panelCanvas";
            this.panelCanvas.Size = new System.Drawing.Size(690, 528);
            this.panelCanvas.TabIndex = 1;
            this.panelCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCanvas_Paint);
            this.panelCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCanvas_MouseDown);
            this.panelCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelCanvas_MouseUp);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(927, 552);
            this.Controls.Add(this.panelCanvas);
            this.Controls.Add(this.listBoxFigur);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listBoxFigur;
        private Panel panelCanvas;
    }
}