﻿namespace BinCrypto
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
            this.tbResult = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbOriginal = new System.Windows.Forms.TextBox();
            this.tbOriginalDat = new System.Windows.Forms.TextBox();
            this.tbGamma = new System.Windows.Forms.TextBox();
            this.tbGammaDat = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tbCrypt = new System.Windows.Forms.TextBox();
            this.tbResultDat = new System.Windows.Forms.TextBox();
            this.openFileDialogText = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogGamma = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogDatText = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialogText = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialogDatGamma = new System.Windows.Forms.SaveFileDialog();
            this.tbResult.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbResult
            // 
            this.tbResult.Controls.Add(this.tabPage1);
            this.tbResult.Controls.Add(this.tabPage2);
            this.tbResult.Controls.Add(this.tabPage3);
            this.tbResult.Location = new System.Drawing.Point(-1, 3);
            this.tbResult.Name = "tbResult";
            this.tbResult.SelectedIndex = 0;
            this.tbResult.Size = new System.Drawing.Size(678, 366);
            this.tbResult.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(670, 340);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Properties";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(249, 20);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(157, 58);
            this.button7.TabIndex = 6;
            this.button7.Text = "Open Gamma";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(19, 263);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(618, 47);
            this.button6.TabIndex = 5;
            this.button6.Text = "Crypt";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(19, 196);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(618, 49);
            this.button5.TabIndex = 4;
            this.button5.Text = "Serialize";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(343, 113);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(294, 57);
            this.button4.TabIndex = 3;
            this.button4.Text = "Save Serialized Gamma";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(474, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 58);
            this.button3.TabIndex = 2;
            this.button3.Text = "Save Result";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(293, 57);
            this.button2.TabIndex = 1;
            this.button2.Text = "Save Serialized Text";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open Text";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(670, 340);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ViewText";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tbOriginal, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbOriginalDat, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbGamma, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbGammaDat, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(658, 327);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tbOriginal
            // 
            this.tbOriginal.Location = new System.Drawing.Point(3, 3);
            this.tbOriginal.Multiline = true;
            this.tbOriginal.Name = "tbOriginal";
            this.tbOriginal.Size = new System.Drawing.Size(323, 157);
            this.tbOriginal.TabIndex = 0;
            // 
            // tbOriginalDat
            // 
            this.tbOriginalDat.Location = new System.Drawing.Point(332, 3);
            this.tbOriginalDat.Multiline = true;
            this.tbOriginalDat.Name = "tbOriginalDat";
            this.tbOriginalDat.Size = new System.Drawing.Size(323, 157);
            this.tbOriginalDat.TabIndex = 1;
            // 
            // tbGamma
            // 
            this.tbGamma.Location = new System.Drawing.Point(3, 166);
            this.tbGamma.Multiline = true;
            this.tbGamma.Name = "tbGamma";
            this.tbGamma.Size = new System.Drawing.Size(323, 158);
            this.tbGamma.TabIndex = 2;
            // 
            // tbGammaDat
            // 
            this.tbGammaDat.Location = new System.Drawing.Point(332, 166);
            this.tbGammaDat.Multiline = true;
            this.tbGammaDat.Name = "tbGammaDat";
            this.tbGammaDat.Size = new System.Drawing.Size(323, 158);
            this.tbGammaDat.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(670, 340);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ViewResult";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.tbCrypt, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbResultDat, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(664, 333);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tbCrypt
            // 
            this.tbCrypt.Location = new System.Drawing.Point(3, 3);
            this.tbCrypt.Multiline = true;
            this.tbCrypt.Name = "tbCrypt";
            this.tbCrypt.Size = new System.Drawing.Size(657, 160);
            this.tbCrypt.TabIndex = 0;
            // 
            // tbResultDat
            // 
            this.tbResultDat.Location = new System.Drawing.Point(3, 169);
            this.tbResultDat.Multiline = true;
            this.tbResultDat.Name = "tbResultDat";
            this.tbResultDat.Size = new System.Drawing.Size(657, 161);
            this.tbResultDat.TabIndex = 1;
            // 
            // openFileDialogText
            // 
            this.openFileDialogText.FileName = "openFileDialogText";
            // 
            // openFileDialogGamma
            // 
            this.openFileDialogGamma.FileName = "openFileDialogGamma";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 370);
            this.Controls.Add(this.tbResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbResult.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbResult;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbOriginal;
        private System.Windows.Forms.TextBox tbOriginalDat;
        private System.Windows.Forms.TextBox tbGamma;
        private System.Windows.Forms.TextBox tbGammaDat;
        private System.Windows.Forms.OpenFileDialog openFileDialogText;
        private System.Windows.Forms.OpenFileDialog openFileDialogGamma;
        private System.Windows.Forms.SaveFileDialog saveFileDialogDatText;
        private System.Windows.Forms.SaveFileDialog saveFileDialogText;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox tbCrypt;
        private System.Windows.Forms.TextBox tbResultDat;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.SaveFileDialog saveFileDialogDatGamma;
    }
}

