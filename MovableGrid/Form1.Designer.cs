namespace MovableGrid
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.boxImg = new System.Windows.Forms.PictureBox();
            this.btn_selectImg = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.boxImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 619);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(767, 10);
            this.label3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Location = new System.Drawing.Point(10, 609);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(767, 10);
            this.label4.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Location = new System.Drawing.Point(767, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 599);
            this.label5.TabIndex = 5;
            // 
            // boxImg
            // 
            this.boxImg.BackColor = System.Drawing.Color.Black;
            this.boxImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boxImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxImg.Location = new System.Drawing.Point(16, 53);
            this.boxImg.Name = "boxImg";
            this.boxImg.Size = new System.Drawing.Size(750, 550);
            this.boxImg.TabIndex = 6;
            this.boxImg.TabStop = false;
            this.boxImg.Paint += new System.Windows.Forms.PaintEventHandler(this.boxImg_Paint);
            this.boxImg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.boxImg_MouseDown);
            // 
            // btn_selectImg
            // 
            this.btn_selectImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(89)))));
            this.btn_selectImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_selectImg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_selectImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_selectImg.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_selectImg.ForeColor = System.Drawing.Color.White;
            this.btn_selectImg.Location = new System.Drawing.Point(12, 13);
            this.btn_selectImg.Name = "btn_selectImg";
            this.btn_selectImg.Size = new System.Drawing.Size(157, 37);
            this.btn_selectImg.TabIndex = 7;
            this.btn_selectImg.Text = "Select Image";
            this.btn_selectImg.UseVisualStyleBackColor = false;
            this.btn_selectImg.Click += new System.EventHandler(this.btn_selectImg_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(89)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(609, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(187, 20);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(390, 45);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(52)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(777, 619);
            this.ControlBox = false;
            this.Controls.Add(this.boxImg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_selectImg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Movable Grid";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.boxImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox boxImg;
        internal System.Windows.Forms.Button btn_selectImg;
        internal System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

