﻿namespace Прогр2
{
    partial class FAquarium
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
            this.FAqu = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FShark = new System.Windows.Forms.PictureBox();
            this.FGet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FTicket = new System.Windows.Forms.MaskedTextBox();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FAqu)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FShark)).BeginInit();
            this.SuspendLayout();
            // 
            // FAqu
            // 
            this.FAqu.Dock = System.Windows.Forms.DockStyle.Left;
            this.FAqu.Location = new System.Drawing.Point(0, 0);
            this.FAqu.Name = "FAqu";
            this.FAqu.Size = new System.Drawing.Size(731, 670);
            this.FAqu.TabIndex = 0;
            this.FAqu.TabStop = false;
            this.FAqu.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FShark);
            this.groupBox1.Controls.Add(this.FGet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.FTicket);
            this.groupBox1.Location = new System.Drawing.Point(751, 297);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 373);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Get Car";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // FShark
            // 
            this.FShark.Location = new System.Drawing.Point(49, 110);
            this.FShark.Name = "FShark";
            this.FShark.Size = new System.Drawing.Size(200, 177);
            this.FShark.TabIndex = 3;
            this.FShark.TabStop = false;
            // 
            // FGet
            // 
            this.FGet.Location = new System.Drawing.Point(81, 312);
            this.FGet.Name = "FGet";
            this.FGet.Size = new System.Drawing.Size(133, 41);
            this.FGet.TabIndex = 2;
            this.FGet.Text = "Get";
            this.FGet.UseVisualStyleBackColor = true;
            this.FGet.Click += new System.EventHandler(this.FGet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "number";
            // 
            // FTicket
            // 
            this.FTicket.Location = new System.Drawing.Point(61, 67);
            this.FTicket.Mask = "00";
            this.FTicket.Name = "FTicket";
            this.FTicket.Size = new System.Drawing.Size(163, 26);
            this.FTicket.TabIndex = 0;
            // 
            // listBoxLevels
            // 
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.ItemHeight = 20;
            this.listBoxLevels.Location = new System.Drawing.Point(821, 67);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(163, 224);
            this.listBoxLevels.TabIndex = 5;
            this.listBoxLevels.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(1001, 127);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(54, 81);
            this.buttonUp.TabIndex = 6;
            this.buttonUp.Text = "->";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(751, 127);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(54, 81);
            this.buttonDown.TabIndex = 7;
            this.buttonDown.Text = "<-";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(830, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "Выбрать акулу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FAquarium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 670);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FAqu);
            this.Name = "FAquarium";
            this.Text = "FAquarium";
            ((System.ComponentModel.ISupportInitialize)(this.FAqu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FShark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox FAqu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox FTicket;
        private System.Windows.Forms.PictureBox FShark;
        private System.Windows.Forms.Button FGet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxLevels;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button button1;
    }
}