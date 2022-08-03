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
            this.listBoxFigure = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBoxFigur = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxFigure
            // 
            this.listBoxFigure.FormattingEnabled = true;
            this.listBoxFigure.ItemHeight = 15;
            this.listBoxFigure.Location = new System.Drawing.Point(12, 12);
            this.listBoxFigure.Name = "listBoxFigure";
            this.listBoxFigure.Size = new System.Drawing.Size(129, 154);
            this.listBoxFigure.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(9, 18);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 94);
            this.listBox1.TabIndex = 0;
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
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(927, 552);
            this.Controls.Add(this.listBoxFigur);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listBoxFigure;
        private ListBox listBox1;
        private ListBox listBoxFigur;
    }
}