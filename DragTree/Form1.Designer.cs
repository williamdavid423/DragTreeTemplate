﻿namespace DragTree
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.row1col1 = new System.Windows.Forms.Label();
            this.row1col2 = new System.Windows.Forms.Label();
            this.row2col1 = new System.Windows.Forms.Label();
            this.row2col2 = new System.Windows.Forms.Label();
            this.row3col1 = new System.Windows.Forms.Label();
            this.row3col2 = new System.Windows.Forms.Label();
            this.row4col1 = new System.Windows.Forms.Label();
            this.row4col2 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.goButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.reactionLabel = new System.Windows.Forms.Label();
            this.lightTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // row1col1
            // 
            this.row1col1.BackColor = System.Drawing.Color.DimGray;
            this.row1col1.Location = new System.Drawing.Point(39, 32);
            this.row1col1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.row1col1.Name = "row1col1";
            this.row1col1.Size = new System.Drawing.Size(33, 32);
            this.row1col1.TabIndex = 0;
            // 
            // row1col2
            // 
            this.row1col2.BackColor = System.Drawing.Color.DimGray;
            this.row1col2.Location = new System.Drawing.Point(100, 32);
            this.row1col2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.row1col2.Name = "row1col2";
            this.row1col2.Size = new System.Drawing.Size(33, 32);
            this.row1col2.TabIndex = 1;
            // 
            // row2col1
            // 
            this.row2col1.BackColor = System.Drawing.Color.DimGray;
            this.row2col1.Location = new System.Drawing.Point(39, 89);
            this.row2col1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.row2col1.Name = "row2col1";
            this.row2col1.Size = new System.Drawing.Size(33, 32);
            this.row2col1.TabIndex = 2;
            // 
            // row2col2
            // 
            this.row2col2.BackColor = System.Drawing.Color.DimGray;
            this.row2col2.Location = new System.Drawing.Point(100, 89);
            this.row2col2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.row2col2.Name = "row2col2";
            this.row2col2.Size = new System.Drawing.Size(33, 32);
            this.row2col2.TabIndex = 3;
            // 
            // row3col1
            // 
            this.row3col1.BackColor = System.Drawing.Color.DimGray;
            this.row3col1.Location = new System.Drawing.Point(39, 144);
            this.row3col1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.row3col1.Name = "row3col1";
            this.row3col1.Size = new System.Drawing.Size(33, 32);
            this.row3col1.TabIndex = 4;
            // 
            // row3col2
            // 
            this.row3col2.BackColor = System.Drawing.Color.DimGray;
            this.row3col2.Location = new System.Drawing.Point(100, 144);
            this.row3col2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.row3col2.Name = "row3col2";
            this.row3col2.Size = new System.Drawing.Size(33, 32);
            this.row3col2.TabIndex = 5;
            // 
            // row4col1
            // 
            this.row4col1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.row4col1.Location = new System.Drawing.Point(39, 205);
            this.row4col1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.row4col1.Name = "row4col1";
            this.row4col1.Size = new System.Drawing.Size(33, 32);
            this.row4col1.TabIndex = 6;
            // 
            // row4col2
            // 
            this.row4col2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.row4col2.Location = new System.Drawing.Point(100, 205);
            this.row4col2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.row4col2.Name = "row4col2";
            this.row4col2.Size = new System.Drawing.Size(33, 32);
            this.row4col2.TabIndex = 7;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(176, 155);
            this.startButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(63, 32);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(176, 205);
            this.goButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(63, 32);
            this.goButton.TabIndex = 9;
            this.goButton.Text = "GO!";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(173, 58);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(58, 17);
            this.timeLabel.TabIndex = 10;
            this.timeLabel.Text = "0.000";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(176, 106);
            this.resetButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(63, 32);
            this.resetButton.TabIndex = 11;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // reactionLabel
            // 
            this.reactionLabel.AutoSize = true;
            this.reactionLabel.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactionLabel.ForeColor = System.Drawing.Color.White;
            this.reactionLabel.Location = new System.Drawing.Point(173, 32);
            this.reactionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.reactionLabel.Name = "reactionLabel";
            this.reactionLabel.Size = new System.Drawing.Size(98, 17);
            this.reactionLabel.TabIndex = 12;
            this.reactionLabel.Text = "Reaction:";
            // 
            // lightTimer
            // 
            this.lightTimer.Interval = 400;
            this.lightTimer.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(284, 279);
            this.Controls.Add(this.reactionLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.row4col2);
            this.Controls.Add(this.row4col1);
            this.Controls.Add(this.row3col2);
            this.Controls.Add(this.row3col1);
            this.Controls.Add(this.row2col2);
            this.Controls.Add(this.row2col1);
            this.Controls.Add(this.row1col2);
            this.Controls.Add(this.row1col1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Racing Tree";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label row1col1;
        private System.Windows.Forms.Label row1col2;
        private System.Windows.Forms.Label row2col1;
        private System.Windows.Forms.Label row2col2;
        private System.Windows.Forms.Label row3col1;
        private System.Windows.Forms.Label row3col2;
        private System.Windows.Forms.Label row4col1;
        private System.Windows.Forms.Label row4col2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label reactionLabel;
        private System.Windows.Forms.Timer lightTimer;
    }
}

