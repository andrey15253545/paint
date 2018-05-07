namespace paint
{
    partial class Graph
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Graph));
            this.panelTools = new System.Windows.Forms.Panel();
            this.Triangle = new System.Windows.Forms.PictureBox();
            this.pictRectangle = new System.Windows.Forms.PictureBox();
            this.pictRound = new System.Windows.Forms.PictureBox();
            this.pictSquare = new System.Windows.Forms.PictureBox();
            this.pictLine = new System.Windows.Forms.PictureBox();
            this.pictEllipse = new System.Windows.Forms.PictureBox();
            this.drawField = new System.Windows.Forms.PictureBox();
            this.pictRed = new System.Windows.Forms.PictureBox();
            this.colorshow = new System.Windows.Forms.ColorDialog();
            this.panelTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Triangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictRectangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictRound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictSquare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictEllipse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictRed)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTools
            // 
            this.panelTools.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelTools.Controls.Add(this.pictRed);
            this.panelTools.Controls.Add(this.Triangle);
            this.panelTools.Controls.Add(this.pictRectangle);
            this.panelTools.Controls.Add(this.pictRound);
            this.panelTools.Controls.Add(this.pictSquare);
            this.panelTools.Controls.Add(this.pictLine);
            this.panelTools.Controls.Add(this.pictEllipse);
            this.panelTools.Location = new System.Drawing.Point(12, 12);
            this.panelTools.Name = "panelTools";
            this.panelTools.Size = new System.Drawing.Size(105, 211);
            this.panelTools.TabIndex = 0;
            // 
            // Triangle
            // 
            this.Triangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Triangle.BackgroundImage")));
            this.Triangle.Location = new System.Drawing.Point(55, 105);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(40, 38);
            this.Triangle.TabIndex = 5;
            this.Triangle.TabStop = false;
            this.Triangle.Click += new System.EventHandler(this.Triangle_Click);
            // 
            // pictRectangle
            // 
            this.pictRectangle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictRectangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictRectangle.BackgroundImage")));
            this.pictRectangle.Location = new System.Drawing.Point(55, 55);
            this.pictRectangle.Name = "pictRectangle";
            this.pictRectangle.Size = new System.Drawing.Size(40, 38);
            this.pictRectangle.TabIndex = 4;
            this.pictRectangle.TabStop = false;
            this.pictRectangle.Click += new System.EventHandler(this.pictRectangle_Click);
            // 
            // pictRound
            // 
            this.pictRound.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictRound.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictRound.BackgroundImage")));
            this.pictRound.Location = new System.Drawing.Point(5, 55);
            this.pictRound.Name = "pictRound";
            this.pictRound.Size = new System.Drawing.Size(40, 38);
            this.pictRound.TabIndex = 3;
            this.pictRound.TabStop = false;
            this.pictRound.Click += new System.EventHandler(this.pictRound_Click);
            // 
            // pictSquare
            // 
            this.pictSquare.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictSquare.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictSquare.BackgroundImage")));
            this.pictSquare.Location = new System.Drawing.Point(55, 5);
            this.pictSquare.Name = "pictSquare";
            this.pictSquare.Size = new System.Drawing.Size(40, 38);
            this.pictSquare.TabIndex = 2;
            this.pictSquare.TabStop = false;
            this.pictSquare.Click += new System.EventHandler(this.pictSquare_Click);
            // 
            // pictLine
            // 
            this.pictLine.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictLine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictLine.BackgroundImage")));
            this.pictLine.Location = new System.Drawing.Point(5, 5);
            this.pictLine.Name = "pictLine";
            this.pictLine.Size = new System.Drawing.Size(40, 38);
            this.pictLine.TabIndex = 1;
            this.pictLine.TabStop = false;
            this.pictLine.Click += new System.EventHandler(this.pictLine_Click);
            // 
            // pictEllipse
            // 
            this.pictEllipse.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictEllipse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictEllipse.BackgroundImage")));
            this.pictEllipse.Location = new System.Drawing.Point(5, 105);
            this.pictEllipse.Name = "pictEllipse";
            this.pictEllipse.Size = new System.Drawing.Size(40, 38);
            this.pictEllipse.TabIndex = 0;
            this.pictEllipse.TabStop = false;
            this.pictEllipse.Click += new System.EventHandler(this.pictEllipse_Click);
            // 
            // drawField
            // 
            this.drawField.BackColor = System.Drawing.SystemColors.Window;
            this.drawField.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.drawField.Location = new System.Drawing.Point(121, 12);
            this.drawField.Name = "drawField";
            this.drawField.Size = new System.Drawing.Size(653, 477);
            this.drawField.TabIndex = 1;
            this.drawField.TabStop = false;
            this.drawField.Paint += new System.Windows.Forms.PaintEventHandler(this.drawField_Paint);
            this.drawField.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawField_MouseDown);
            this.drawField.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawField_MouseMove);
            this.drawField.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawField_MouseUp);
            // 
            // pictRed
            // 
            this.pictRed.BackColor = System.Drawing.Color.Black;
            this.pictRed.Location = new System.Drawing.Point(5, 149);
            this.pictRed.Name = "pictRed";
            this.pictRed.Size = new System.Drawing.Size(90, 59);
            this.pictRed.TabIndex = 0;
            this.pictRed.TabStop = false;
            this.pictRed.Click += new System.EventHandler(this.pictRed_Click);
            // 
            // Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 501);
            this.Controls.Add(this.drawField);
            this.Controls.Add(this.panelTools);
            this.Name = "Graph";
            this.Text = "Form1";
            this.panelTools.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Triangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictRectangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictRound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictSquare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictEllipse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictRed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTools;
        private System.Windows.Forms.PictureBox pictLine;
        private System.Windows.Forms.PictureBox pictEllipse;
        private System.Windows.Forms.PictureBox pictRound;
        private System.Windows.Forms.PictureBox pictSquare;
        private System.Windows.Forms.PictureBox drawField;
        private System.Windows.Forms.PictureBox pictRectangle;
        private System.Windows.Forms.PictureBox Triangle;
        private System.Windows.Forms.PictureBox pictRed;
        private System.Windows.Forms.ColorDialog colorshow;
    }
}

