namespace tictactoe
{
    partial class TicTacToeForm
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
            this.topLeftPictureBox = new System.Windows.Forms.PictureBox();
            this.topCenterPictureBox = new System.Windows.Forms.PictureBox();
            this.topRightPictureBox = new System.Windows.Forms.PictureBox();
            this.middleLeftPictureBox = new System.Windows.Forms.PictureBox();
            this.middleCenterPictureBox = new System.Windows.Forms.PictureBox();
            this.middleRightPictureBox = new System.Windows.Forms.PictureBox();
            this.bottomLeftPictureBox = new System.Windows.Forms.PictureBox();
            this.bottomCenterPictureBox = new System.Windows.Forms.PictureBox();
            this.bottomRightPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.topLeftPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topCenterPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topRightPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleLeftPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleCenterPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleRightPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomLeftPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomCenterPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomRightPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // topLeftPictureBox
            // 
            this.topLeftPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topLeftPictureBox.Location = new System.Drawing.Point(35, 34);
            this.topLeftPictureBox.Name = "topLeftPictureBox";
            this.topLeftPictureBox.Size = new System.Drawing.Size(100, 50);
            this.topLeftPictureBox.TabIndex = 0;
            this.topLeftPictureBox.TabStop = false;
            this.topLeftPictureBox.Click += new System.EventHandler(this.Cell_Click);
            // 
            // topCenterPictureBox
            // 
            this.topCenterPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topCenterPictureBox.Location = new System.Drawing.Point(141, 34);
            this.topCenterPictureBox.Name = "topCenterPictureBox";
            this.topCenterPictureBox.Size = new System.Drawing.Size(100, 50);
            this.topCenterPictureBox.TabIndex = 1;
            this.topCenterPictureBox.TabStop = false;
            this.topCenterPictureBox.Click += new System.EventHandler(this.Cell_Click);
            // 
            // topRightPictureBox
            // 
            this.topRightPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topRightPictureBox.Location = new System.Drawing.Point(247, 34);
            this.topRightPictureBox.Name = "topRightPictureBox";
            this.topRightPictureBox.Size = new System.Drawing.Size(100, 50);
            this.topRightPictureBox.TabIndex = 2;
            this.topRightPictureBox.TabStop = false;
            this.topRightPictureBox.Click += new System.EventHandler(this.Cell_Click);
            // 
            // middleLeftPictureBox
            // 
            this.middleLeftPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.middleLeftPictureBox.Location = new System.Drawing.Point(35, 90);
            this.middleLeftPictureBox.Name = "middleLeftPictureBox";
            this.middleLeftPictureBox.Size = new System.Drawing.Size(100, 50);
            this.middleLeftPictureBox.TabIndex = 3;
            this.middleLeftPictureBox.TabStop = false;
            this.middleLeftPictureBox.Click += new System.EventHandler(this.Cell_Click);
            // 
            // middleCenterPictureBox
            // 
            this.middleCenterPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.middleCenterPictureBox.Location = new System.Drawing.Point(141, 90);
            this.middleCenterPictureBox.Name = "middleCenterPictureBox";
            this.middleCenterPictureBox.Size = new System.Drawing.Size(100, 50);
            this.middleCenterPictureBox.TabIndex = 4;
            this.middleCenterPictureBox.TabStop = false;
            this.middleCenterPictureBox.Click += new System.EventHandler(this.Cell_Click);
            // 
            // middleRightPictureBox
            // 
            this.middleRightPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.middleRightPictureBox.Location = new System.Drawing.Point(247, 90);
            this.middleRightPictureBox.Name = "middleRightPictureBox";
            this.middleRightPictureBox.Size = new System.Drawing.Size(100, 50);
            this.middleRightPictureBox.TabIndex = 5;
            this.middleRightPictureBox.TabStop = false;
            this.middleRightPictureBox.Click += new System.EventHandler(this.Cell_Click);
            // 
            // bottomLeftPictureBox
            // 
            this.bottomLeftPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bottomLeftPictureBox.Location = new System.Drawing.Point(35, 146);
            this.bottomLeftPictureBox.Name = "bottomLeftPictureBox";
            this.bottomLeftPictureBox.Size = new System.Drawing.Size(100, 50);
            this.bottomLeftPictureBox.TabIndex = 6;
            this.bottomLeftPictureBox.TabStop = false;
            this.bottomLeftPictureBox.Click += new System.EventHandler(this.Cell_Click);
            // 
            // bottomCenterPictureBox
            // 
            this.bottomCenterPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bottomCenterPictureBox.Location = new System.Drawing.Point(141, 146);
            this.bottomCenterPictureBox.Name = "bottomCenterPictureBox";
            this.bottomCenterPictureBox.Size = new System.Drawing.Size(100, 50);
            this.bottomCenterPictureBox.TabIndex = 7;
            this.bottomCenterPictureBox.TabStop = false;
            this.bottomCenterPictureBox.Click += new System.EventHandler(this.Cell_Click);
            // 
            // bottomRightPictureBox
            // 
            this.bottomRightPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bottomRightPictureBox.Location = new System.Drawing.Point(247, 146);
            this.bottomRightPictureBox.Name = "bottomRightPictureBox";
            this.bottomRightPictureBox.Size = new System.Drawing.Size(100, 50);
            this.bottomRightPictureBox.TabIndex = 8;
            this.bottomRightPictureBox.TabStop = false;
            this.bottomRightPictureBox.Click += new System.EventHandler(this.Cell_Click);
            // 
            // TicTacToeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 231);
            this.Controls.Add(this.bottomRightPictureBox);
            this.Controls.Add(this.bottomCenterPictureBox);
            this.Controls.Add(this.bottomLeftPictureBox);
            this.Controls.Add(this.middleRightPictureBox);
            this.Controls.Add(this.middleCenterPictureBox);
            this.Controls.Add(this.middleLeftPictureBox);
            this.Controls.Add(this.topRightPictureBox);
            this.Controls.Add(this.topCenterPictureBox);
            this.Controls.Add(this.topLeftPictureBox);
            this.Name = "TicTacToeForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.topLeftPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topCenterPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topRightPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleLeftPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleCenterPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleRightPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomLeftPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomCenterPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomRightPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox topLeftPictureBox;
        private System.Windows.Forms.PictureBox topCenterPictureBox;
        private System.Windows.Forms.PictureBox topRightPictureBox;
        private System.Windows.Forms.PictureBox middleLeftPictureBox;
        private System.Windows.Forms.PictureBox middleCenterPictureBox;
        private System.Windows.Forms.PictureBox middleRightPictureBox;
        private System.Windows.Forms.PictureBox bottomLeftPictureBox;
        private System.Windows.Forms.PictureBox bottomCenterPictureBox;
        private System.Windows.Forms.PictureBox bottomRightPictureBox;
    }
}

