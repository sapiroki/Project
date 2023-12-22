namespace Project
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
            canvasPictureBox = new PictureBox();
            colorButton = new Button();
            clearButton = new Button();
            saveButton = new Button();
            brushSizeTrackBar = new TrackBar();
            eraserButton = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)canvasPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)brushSizeTrackBar).BeginInit();
            SuspendLayout();
            // 
            // canvasPictureBox
            // 
            canvasPictureBox.BackColor = Color.White;
            canvasPictureBox.BorderStyle = BorderStyle.FixedSingle;
            canvasPictureBox.Cursor = Cursors.Cross;
            canvasPictureBox.Location = new Point(12, 12);
            canvasPictureBox.Name = "canvasPictureBox";
            canvasPictureBox.Size = new Size(810, 375);
            canvasPictureBox.TabIndex = 0;
            canvasPictureBox.TabStop = false;
            canvasPictureBox.MouseDown += canvasPictureBox_MouseDown;
            canvasPictureBox.MouseMove += canvasPictureBox_MouseMove;
            canvasPictureBox.MouseUp += canvasPictureBox_MouseUp;
            // 
            // colorButton
            // 
            colorButton.Location = new Point(12, 416);
            colorButton.Name = "colorButton";
            colorButton.Size = new Size(108, 66);
            colorButton.TabIndex = 1;
            colorButton.Text = "Change color";
            colorButton.UseVisualStyleBackColor = true;
            colorButton.Click += colorButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(126, 416);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(110, 66);
            clearButton.TabIndex = 4;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(460, 416);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(110, 66);
            saveButton.TabIndex = 5;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // brushSizeTrackBar
            // 
            brushSizeTrackBar.Location = new Point(644, 436);
            brushSizeTrackBar.Name = "brushSizeTrackBar";
            brushSizeTrackBar.Size = new Size(130, 56);
            brushSizeTrackBar.TabIndex = 6;
            // 
            // eraserButton
            // 
            eraserButton.Location = new Point(242, 416);
            eraserButton.Name = "eraserButton";
            eraserButton.Size = new Size(101, 66);
            eraserButton.TabIndex = 7;
            eraserButton.Text = "Eraser";
            eraserButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(679, 413);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 8;
            label1.Text = "Pen size";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 504);
            Controls.Add(label1);
            Controls.Add(eraserButton);
            Controls.Add(brushSizeTrackBar);
            Controls.Add(saveButton);
            Controls.Add(clearButton);
            Controls.Add(colorButton);
            Controls.Add(canvasPictureBox);
            Name = "Form1";
            Text = "Painter";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)canvasPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)brushSizeTrackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox canvasPictureBox;
        private Button colorButton;
        private Button clearButton;
        private Button saveButton;
        private TrackBar brushSizeTrackBar;
        private Button eraserButton;
        private Label label1;
    }
}