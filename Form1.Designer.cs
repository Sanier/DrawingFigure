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
            this.RectangleSideA = new System.Windows.Forms.NumericUpDown();
            this.RectangleSideB = new System.Windows.Forms.NumericUpDown();
            this.TriangleSize = new System.Windows.Forms.NumericUpDown();
            this.Radius = new System.Windows.Forms.NumericUpDown();
            this.BoldLines = new System.Windows.Forms.NumericUpDown();
            this.BoldLinesName = new System.Windows.Forms.Label();
            this.BorderStyleName = new System.Windows.Forms.Label();
            this.BorderStyle = new System.Windows.Forms.TrackBar();
            this.FigureStyle = new System.Windows.Forms.TrackBar();
            this.FigureStyleName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RectangleSideA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RectangleSideB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TriangleSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Radius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoldLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FigureStyle)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxFigur
            // 
            this.listBoxFigur.FormattingEnabled = true;
            this.listBoxFigur.ItemHeight = 15;
            this.listBoxFigur.Location = new System.Drawing.Point(12, 12);
            this.listBoxFigur.Name = "listBoxFigur";
            this.listBoxFigur.Size = new System.Drawing.Size(182, 94);
            this.listBoxFigur.TabIndex = 0;
            this.listBoxFigur.SelectedIndexChanged += new System.EventHandler(this.ListBoxFigur_SelectedIndexChanged);
            // 
            // panelCanvas
            // 
            this.panelCanvas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelCanvas.Location = new System.Drawing.Point(225, 12);
            this.panelCanvas.Name = "panelCanvas";
            this.panelCanvas.Size = new System.Drawing.Size(690, 528);
            this.panelCanvas.TabIndex = 1;
            this.panelCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelCanvas_Paint);
            this.panelCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelCanvas_MouseClick);
            this.panelCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelCanvas_MouseDown);
            this.panelCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelCanvas_MouseUp);
            // 
            // RectangleSideA
            // 
            this.RectangleSideA.Location = new System.Drawing.Point(12, 124);
            this.RectangleSideA.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.RectangleSideA.Name = "RectangleSideA";
            this.RectangleSideA.Size = new System.Drawing.Size(179, 23);
            this.RectangleSideA.TabIndex = 2;
            this.RectangleSideA.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RectangleSideA.ValueChanged += new System.EventHandler(this.RectangleSideA_ValueChanged);
            // 
            // RectangleSideB
            // 
            this.RectangleSideB.Location = new System.Drawing.Point(12, 162);
            this.RectangleSideB.Maximum = new decimal(new int[] {
            450,
            0,
            0,
            0});
            this.RectangleSideB.Name = "RectangleSideB";
            this.RectangleSideB.Size = new System.Drawing.Size(179, 23);
            this.RectangleSideB.TabIndex = 3;
            this.RectangleSideB.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RectangleSideB.Visible = false;
            this.RectangleSideB.ValueChanged += new System.EventHandler(this.RectangleSideB_ValueChanged);
            // 
            // TriangleSize
            // 
            this.TriangleSize.Location = new System.Drawing.Point(12, 124);
            this.TriangleSize.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.TriangleSize.Name = "TriangleSize";
            this.TriangleSize.Size = new System.Drawing.Size(179, 23);
            this.TriangleSize.TabIndex = 4;
            this.TriangleSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.TriangleSize.ValueChanged += new System.EventHandler(this.TriangleSize_ValueChanged);
            // 
            // Radius
            // 
            this.Radius.Location = new System.Drawing.Point(12, 162);
            this.Radius.Maximum = new decimal(new int[] {
            450,
            0,
            0,
            0});
            this.Radius.Name = "Radius";
            this.Radius.Size = new System.Drawing.Size(179, 23);
            this.Radius.TabIndex = 5;
            this.Radius.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Radius.ValueChanged += new System.EventHandler(this.Radius_ValueChanged);
            // 
            // BoldLines
            // 
            this.BoldLines.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BoldLines.Location = new System.Drawing.Point(12, 218);
            this.BoldLines.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.BoldLines.Name = "BoldLines";
            this.BoldLines.Size = new System.Drawing.Size(179, 23);
            this.BoldLines.TabIndex = 6;
            this.BoldLines.ValueChanged += new System.EventHandler(this.BoldLines_ValueChanged);
            // 
            // BoldLinesName
            // 
            this.BoldLinesName.AutoSize = true;
            this.BoldLinesName.Location = new System.Drawing.Point(46, 200);
            this.BoldLinesName.Name = "BoldLinesName";
            this.BoldLinesName.Size = new System.Drawing.Size(96, 15);
            this.BoldLinesName.TabIndex = 7;
            this.BoldLinesName.Text = "Толщина линии";
            // 
            // BorderStyleName
            // 
            this.BorderStyleName.AutoSize = true;
            this.BorderStyleName.Location = new System.Drawing.Point(46, 258);
            this.BorderStyleName.Name = "BorderStyleName";
            this.BorderStyleName.Size = new System.Drawing.Size(93, 15);
            this.BorderStyleName.TabIndex = 8;
            this.BorderStyleName.Text = "Цвет окантовки";
            // 
            // BorderStyle
            // 
            this.BorderStyle.Location = new System.Drawing.Point(12, 276);
            this.BorderStyle.Maximum = 765;
            this.BorderStyle.Name = "BorderStyle";
            this.BorderStyle.Size = new System.Drawing.Size(179, 45);
            this.BorderStyle.TabIndex = 9;
            this.BorderStyle.Scroll += new System.EventHandler(this.BorderStyle_Scroll);
            // 
            // FigureStyle
            // 
            this.FigureStyle.Location = new System.Drawing.Point(15, 346);
            this.FigureStyle.Maximum = 765;
            this.FigureStyle.Name = "FigureStyle";
            this.FigureStyle.Size = new System.Drawing.Size(179, 45);
            this.FigureStyle.TabIndex = 11;
            this.FigureStyle.Scroll += new System.EventHandler(this.FigureStyle_Scroll);
            // 
            // FigureStyleName
            // 
            this.FigureStyleName.AutoSize = true;
            this.FigureStyleName.Location = new System.Drawing.Point(49, 328);
            this.FigureStyleName.Name = "FigureStyleName";
            this.FigureStyleName.Size = new System.Drawing.Size(79, 15);
            this.FigureStyleName.TabIndex = 10;
            this.FigureStyleName.Text = "Цвет фигуры";
            this.FigureStyleName.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(927, 552);
            this.Controls.Add(this.FigureStyle);
            this.Controls.Add(this.FigureStyleName);
            this.Controls.Add(this.BorderStyle);
            this.Controls.Add(this.BorderStyleName);
            this.Controls.Add(this.BoldLinesName);
            this.Controls.Add(this.BoldLines);
            this.Controls.Add(this.Radius);
            this.Controls.Add(this.TriangleSize);
            this.Controls.Add(this.RectangleSideB);
            this.Controls.Add(this.RectangleSideA);
            this.Controls.Add(this.panelCanvas);
            this.Controls.Add(this.listBoxFigur);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.RectangleSideA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RectangleSideB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TriangleSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Radius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoldLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FigureStyle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxFigur;
        private Panel panelCanvas;
        private NumericUpDown RectangleSideA;
        private NumericUpDown RectangleSideB;
        private NumericUpDown TriangleSize;
        private NumericUpDown Radius;
        private NumericUpDown BoldLines;
        private Label BoldLinesName;
        private Label BorderStyleName;
        private TrackBar BorderStyle;
        private TrackBar FigureStyle;
        private Label FigureStyleName;
    }
}