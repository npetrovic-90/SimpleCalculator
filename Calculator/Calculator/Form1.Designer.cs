﻿namespace Calculator
{
	partial class MainWindow
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
			this.ButtonPanel = new System.Windows.Forms.Panel();
			this.Number7 = new System.Windows.Forms.Button();
			this.Number8 = new System.Windows.Forms.Button();
			this.Number9 = new System.Windows.Forms.Button();
			this.MultiplicationSign = new System.Windows.Forms.Button();
			this.ButtonCE = new System.Windows.Forms.Button();
			this.DivideSign = new System.Windows.Forms.Button();
			this.MinusSign = new System.Windows.Forms.Button();
			this.PlusSign = new System.Windows.Forms.Button();
			this.Number6 = new System.Windows.Forms.Button();
			this.Number3 = new System.Windows.Forms.Button();
			this.Number5 = new System.Windows.Forms.Button();
			this.Number4 = new System.Windows.Forms.Button();
			this.Number1 = new System.Windows.Forms.Button();
			this.Number2 = new System.Windows.Forms.Button();
			this.Separator = new System.Windows.Forms.Button();
			this.Number0 = new System.Windows.Forms.Button();
			this.ButtonC = new System.Windows.Forms.Button();
			this.EqualSign = new System.Windows.Forms.Button();
			this.StringResult = new System.Windows.Forms.TextBox();
			this.NumericResult = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.ButtonPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// ButtonPanel
			// 
			this.ButtonPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ButtonPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ButtonPanel.Controls.Add(this.EqualSign);
			this.ButtonPanel.Controls.Add(this.ButtonC);
			this.ButtonPanel.Controls.Add(this.Number0);
			this.ButtonPanel.Controls.Add(this.Separator);
			this.ButtonPanel.Controls.Add(this.Number2);
			this.ButtonPanel.Controls.Add(this.Number1);
			this.ButtonPanel.Controls.Add(this.Number4);
			this.ButtonPanel.Controls.Add(this.Number5);
			this.ButtonPanel.Controls.Add(this.Number3);
			this.ButtonPanel.Controls.Add(this.Number6);
			this.ButtonPanel.Controls.Add(this.PlusSign);
			this.ButtonPanel.Controls.Add(this.MinusSign);
			this.ButtonPanel.Controls.Add(this.DivideSign);
			this.ButtonPanel.Controls.Add(this.ButtonCE);
			this.ButtonPanel.Controls.Add(this.MultiplicationSign);
			this.ButtonPanel.Controls.Add(this.Number9);
			this.ButtonPanel.Controls.Add(this.Number8);
			this.ButtonPanel.Controls.Add(this.Number7);
			this.ButtonPanel.Location = new System.Drawing.Point(22, 144);
			this.ButtonPanel.Margin = new System.Windows.Forms.Padding(0);
			this.ButtonPanel.Name = "ButtonPanel";
			this.ButtonPanel.Padding = new System.Windows.Forms.Padding(1);
			this.ButtonPanel.Size = new System.Drawing.Size(560, 351);
			this.ButtonPanel.TabIndex = 0;
			this.ButtonPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// Number7
			// 
			this.Number7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Number7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Number7.Location = new System.Drawing.Point(29, 45);
			this.Number7.Name = "Number7";
			this.Number7.Size = new System.Drawing.Size(60, 60);
			this.Number7.TabIndex = 0;
			this.Number7.Text = "7";
			this.Number7.UseVisualStyleBackColor = false;
			// 
			// Number8
			// 
			this.Number8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Number8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Number8.Location = new System.Drawing.Point(95, 45);
			this.Number8.Name = "Number8";
			this.Number8.Size = new System.Drawing.Size(60, 60);
			this.Number8.TabIndex = 1;
			this.Number8.Text = "8";
			this.Number8.UseVisualStyleBackColor = false;
			// 
			// Number9
			// 
			this.Number9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Number9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Number9.Location = new System.Drawing.Point(161, 45);
			this.Number9.Name = "Number9";
			this.Number9.Size = new System.Drawing.Size(60, 60);
			this.Number9.TabIndex = 2;
			this.Number9.Text = "9";
			this.Number9.UseVisualStyleBackColor = false;
			// 
			// MultiplicationSign
			// 
			this.MultiplicationSign.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.MultiplicationSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MultiplicationSign.Location = new System.Drawing.Point(227, 45);
			this.MultiplicationSign.Name = "MultiplicationSign";
			this.MultiplicationSign.Size = new System.Drawing.Size(60, 60);
			this.MultiplicationSign.TabIndex = 3;
			this.MultiplicationSign.Text = "*";
			this.MultiplicationSign.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.MultiplicationSign.UseVisualStyleBackColor = false;
			// 
			// ButtonCE
			// 
			this.ButtonCE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ButtonCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonCE.Location = new System.Drawing.Point(293, 45);
			this.ButtonCE.Name = "ButtonCE";
			this.ButtonCE.Size = new System.Drawing.Size(60, 60);
			this.ButtonCE.TabIndex = 4;
			this.ButtonCE.Text = "CE";
			this.ButtonCE.UseVisualStyleBackColor = false;
			// 
			// DivideSign
			// 
			this.DivideSign.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.DivideSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DivideSign.Location = new System.Drawing.Point(227, 111);
			this.DivideSign.Name = "DivideSign";
			this.DivideSign.Size = new System.Drawing.Size(60, 60);
			this.DivideSign.TabIndex = 5;
			this.DivideSign.Text = "/";
			this.DivideSign.UseVisualStyleBackColor = false;
			// 
			// MinusSign
			// 
			this.MinusSign.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.MinusSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MinusSign.Location = new System.Drawing.Point(227, 177);
			this.MinusSign.Name = "MinusSign";
			this.MinusSign.Size = new System.Drawing.Size(60, 60);
			this.MinusSign.TabIndex = 6;
			this.MinusSign.Text = "-";
			this.MinusSign.UseVisualStyleBackColor = false;
			// 
			// PlusSign
			// 
			this.PlusSign.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.PlusSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PlusSign.Location = new System.Drawing.Point(227, 243);
			this.PlusSign.Name = "PlusSign";
			this.PlusSign.Size = new System.Drawing.Size(60, 60);
			this.PlusSign.TabIndex = 7;
			this.PlusSign.Text = "+";
			this.PlusSign.UseVisualStyleBackColor = false;
			// 
			// Number6
			// 
			this.Number6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Number6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Number6.Location = new System.Drawing.Point(161, 111);
			this.Number6.Name = "Number6";
			this.Number6.Size = new System.Drawing.Size(60, 60);
			this.Number6.TabIndex = 8;
			this.Number6.Text = "6";
			this.Number6.UseVisualStyleBackColor = false;
			// 
			// Number3
			// 
			this.Number3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Number3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Number3.Location = new System.Drawing.Point(161, 177);
			this.Number3.Name = "Number3";
			this.Number3.Size = new System.Drawing.Size(60, 60);
			this.Number3.TabIndex = 9;
			this.Number3.Text = "3";
			this.Number3.UseVisualStyleBackColor = false;
			// 
			// Number5
			// 
			this.Number5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Number5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Number5.Location = new System.Drawing.Point(95, 111);
			this.Number5.Name = "Number5";
			this.Number5.Size = new System.Drawing.Size(60, 60);
			this.Number5.TabIndex = 10;
			this.Number5.Text = "5";
			this.Number5.UseVisualStyleBackColor = false;
			// 
			// Number4
			// 
			this.Number4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Number4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Number4.Location = new System.Drawing.Point(29, 111);
			this.Number4.Name = "Number4";
			this.Number4.Size = new System.Drawing.Size(60, 60);
			this.Number4.TabIndex = 11;
			this.Number4.Text = "4";
			this.Number4.UseVisualStyleBackColor = false;
			// 
			// Number1
			// 
			this.Number1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Number1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Number1.Location = new System.Drawing.Point(29, 177);
			this.Number1.Name = "Number1";
			this.Number1.Size = new System.Drawing.Size(60, 60);
			this.Number1.TabIndex = 12;
			this.Number1.Text = "1";
			this.Number1.UseVisualStyleBackColor = false;
			// 
			// Number2
			// 
			this.Number2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Number2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Number2.Location = new System.Drawing.Point(95, 177);
			this.Number2.Name = "Number2";
			this.Number2.Size = new System.Drawing.Size(60, 60);
			this.Number2.TabIndex = 13;
			this.Number2.Text = "2";
			this.Number2.UseVisualStyleBackColor = false;
			// 
			// Separator
			// 
			this.Separator.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Separator.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Separator.Location = new System.Drawing.Point(161, 243);
			this.Separator.Name = "Separator";
			this.Separator.Size = new System.Drawing.Size(60, 60);
			this.Separator.TabIndex = 14;
			this.Separator.Text = ".";
			this.Separator.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.Separator.UseVisualStyleBackColor = false;
			// 
			// Number0
			// 
			this.Number0.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Number0.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Number0.Location = new System.Drawing.Point(29, 243);
			this.Number0.Name = "Number0";
			this.Number0.Size = new System.Drawing.Size(126, 60);
			this.Number0.TabIndex = 15;
			this.Number0.Text = "0";
			this.Number0.UseVisualStyleBackColor = false;
			// 
			// ButtonC
			// 
			this.ButtonC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ButtonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonC.Location = new System.Drawing.Point(293, 111);
			this.ButtonC.Name = "ButtonC";
			this.ButtonC.Size = new System.Drawing.Size(60, 60);
			this.ButtonC.TabIndex = 16;
			this.ButtonC.Text = "C";
			this.ButtonC.UseVisualStyleBackColor = false;
			// 
			// EqualSign
			// 
			this.EqualSign.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.EqualSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EqualSign.Location = new System.Drawing.Point(293, 177);
			this.EqualSign.Name = "EqualSign";
			this.EqualSign.Size = new System.Drawing.Size(60, 126);
			this.EqualSign.TabIndex = 17;
			this.EqualSign.Text = "=";
			this.EqualSign.UseVisualStyleBackColor = false;
			// 
			// StringResult
			// 
			this.StringResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StringResult.Location = new System.Drawing.Point(22, 26);
			this.StringResult.Multiline = true;
			this.StringResult.Name = "StringResult";
			this.StringResult.ReadOnly = true;
			this.StringResult.Size = new System.Drawing.Size(559, 35);
			this.StringResult.TabIndex = 1;
			this.StringResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.StringResult.WordWrap = false;
			this.StringResult.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// NumericResult
			// 
			this.NumericResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NumericResult.Location = new System.Drawing.Point(22, 67);
			this.NumericResult.Multiline = true;
			this.NumericResult.Name = "NumericResult";
			this.NumericResult.Size = new System.Drawing.Size(559, 36);
			this.NumericResult.TabIndex = 2;
			this.NumericResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.NumericResult.WordWrap = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
			this.label1.Location = new System.Drawing.Point(20, 106);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(129, 12);
			this.label1.TabIndex = 3;
			this.label1.Text = "validation placeholder";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(603, 512);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.NumericResult);
			this.Controls.Add(this.StringResult);
			this.Controls.Add(this.ButtonPanel);
			this.Name = "MainWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Calculator";
			this.ButtonPanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel ButtonPanel;
		private System.Windows.Forms.Button Number7;
		private System.Windows.Forms.Button EqualSign;
		private System.Windows.Forms.Button ButtonC;
		private System.Windows.Forms.Button Number0;
		private System.Windows.Forms.Button Separator;
		private System.Windows.Forms.Button Number2;
		private System.Windows.Forms.Button Number1;
		private System.Windows.Forms.Button Number4;
		private System.Windows.Forms.Button Number5;
		private System.Windows.Forms.Button Number3;
		private System.Windows.Forms.Button Number6;
		private System.Windows.Forms.Button PlusSign;
		private System.Windows.Forms.Button MinusSign;
		private System.Windows.Forms.Button DivideSign;
		private System.Windows.Forms.Button ButtonCE;
		private System.Windows.Forms.Button MultiplicationSign;
		private System.Windows.Forms.Button Number9;
		private System.Windows.Forms.Button Number8;
		private System.Windows.Forms.TextBox StringResult;
		private System.Windows.Forms.TextBox NumericResult;
		private System.Windows.Forms.Label label1;
	}
}

