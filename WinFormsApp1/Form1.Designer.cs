﻿namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            label5 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            imageList1 = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(206, 50);
            label1.TabIndex = 0;
            label1.Text = "computer";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(420, 9);
            label2.Name = "label2";
            label2.Size = new Size(138, 50);
            label2.TabIndex = 1;
            label2.Text = "player";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 306);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 2;
            label3.Text = "Stop";
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(31, 95);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 192);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(402, 95);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(156, 192);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(40, 334);
            button1.Name = "button1";
            button1.Size = new Size(141, 72);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(402, 334);
            button2.Name = "button2";
            button2.Size = new Size(138, 72);
            button2.TabIndex = 6;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(446, 306);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 7;
            label4.Text = "Stop";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(217, 165);
            label5.Name = "label5";
            label5.Size = new Size(161, 43);
            label5.TabIndex = 8;
            label5.Text = "Playing...";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "poker1.jpg");
            imageList1.Images.SetKeyName(1, "poker2.jpg");
            imageList1.Images.SetKeyName(2, "poker3.jpg");
            imageList1.Images.SetKeyName(3, "poker4.jpg");
            imageList1.Images.SetKeyName(4, "poker5.jpg");
            imageList1.Images.SetKeyName(5, "poker6.jpg");
            imageList1.Images.SetKeyName(6, "poker7.jpg");
            imageList1.Images.SetKeyName(7, "poker8.jpg");
            imageList1.Images.SetKeyName(8, "poker9.jpg");
            imageList1.Images.SetKeyName(9, "poker10.jpg");
            imageList1.Images.SetKeyName(10, "poker11.jpg");
            imageList1.Images.SetKeyName(11, "poker12.jpg");
            imageList1.Images.SetKeyName(12, "poker13.jpg");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private Button button2;
        private Label label4;
        private Label label5;
        private System.Windows.Forms.Timer timer1;
        private ImageList imageList1;
    }
}