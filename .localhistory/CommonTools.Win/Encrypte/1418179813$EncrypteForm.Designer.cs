﻿namespace CommonTools.Win
{
    partial class EncrypteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncrypteForm));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.TabMd5 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtPlaintext = new DevExpress.XtraEditors.TextEdit();
            this.TxtNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtCiphertext = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.PicEncrypte = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.TabMd5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPlaintext.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCiphertext.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicEncrypte)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.TabMd5;
            this.xtraTabControl1.Size = new System.Drawing.Size(1160, 638);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabMd5});
            // 
            // TabMd5
            // 
            this.TabMd5.Controls.Add(this.PicEncrypte);
            this.TabMd5.Controls.Add(this.textEdit3);
            this.TabMd5.Controls.Add(this.labelControl7);
            this.TabMd5.Controls.Add(this.labelControl5);
            this.TabMd5.Controls.Add(this.textEdit2);
            this.TabMd5.Controls.Add(this.labelControl6);
            this.TabMd5.Controls.Add(this.TxtCiphertext);
            this.TabMd5.Controls.Add(this.labelControl4);
            this.TabMd5.Controls.Add(this.labelControl3);
            this.TabMd5.Controls.Add(this.TxtNumber);
            this.TabMd5.Controls.Add(this.labelControl2);
            this.TabMd5.Controls.Add(this.TxtPlaintext);
            this.TabMd5.Controls.Add(this.labelControl1);
            this.TabMd5.Name = "TabMd5";
            this.TabMd5.Size = new System.Drawing.Size(1154, 609);
            this.TabMd5.Text = "MD5加密";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(79, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 24);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "明文:";
            // 
            // TxtPlaintext
            // 
            this.TxtPlaintext.Location = new System.Drawing.Point(134, 52);
            this.TxtPlaintext.Name = "TxtPlaintext";
            this.TxtPlaintext.Size = new System.Drawing.Size(930, 20);
            this.TxtPlaintext.TabIndex = 1;
            // 
            // TxtNumber
            // 
            this.TxtNumber.EditValue = "1";
            this.TxtNumber.Location = new System.Drawing.Point(174, 121);
            this.TxtNumber.Name = "TxtNumber";
            this.TxtNumber.Size = new System.Drawing.Size(64, 20);
            this.TxtNumber.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(79, 118);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 24);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "加密次数:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(264, 118);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(104, 24);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "(默认加密1次)";
            // 
            // TxtCiphertext
            // 
            this.TxtCiphertext.Location = new System.Drawing.Point(134, 196);
            this.TxtCiphertext.Name = "TxtCiphertext";
            this.TxtCiphertext.Size = new System.Drawing.Size(930, 20);
            this.TxtCiphertext.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(79, 193);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 24);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "密文:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Location = new System.Drawing.Point(834, 117);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(230, 24);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "(最高为32位密文,只能填写数字)";
            // 
            // textEdit2
            // 
            this.textEdit2.EditValue = "0";
            this.textEdit2.Location = new System.Drawing.Point(549, 121);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(93, 20);
            this.textEdit2.TabIndex = 8;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.Location = new System.Drawing.Point(454, 118);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(82, 24);
            this.labelControl6.TabIndex = 7;
            this.labelControl6.Text = "密文长度:";
            // 
            // textEdit3
            // 
            this.textEdit3.EditValue = "32";
            this.textEdit3.Location = new System.Drawing.Point(721, 122);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(93, 20);
            this.textEdit3.TabIndex = 11;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.Location = new System.Drawing.Point(674, 128);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(27, 20);
            this.labelControl7.TabIndex = 10;
            this.labelControl7.Text = "~";
            this.labelControl7.UseMnemonic = false;
            // 
            // PicEncrypte
            // 
            this.PicEncrypte.BackColor = System.Drawing.Color.Transparent;
            this.PicEncrypte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicEncrypte.Location = new System.Drawing.Point(444, 281);
            this.PicEncrypte.Name = "PicEncrypte";
            this.PicEncrypte.Size = new System.Drawing.Size(128, 128);
            this.PicEncrypte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicEncrypte.TabIndex = 12;
            this.PicEncrypte.TabStop = false;
            // 
            // EncrypteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.xtraTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EncrypteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "加/解密";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EncrypteForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.TabMd5.ResumeLayout(false);
            this.TabMd5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPlaintext.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCiphertext.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicEncrypte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage TabMd5;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TxtPlaintext;
        private DevExpress.XtraEditors.TextEdit TxtNumber;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtCiphertext;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.PictureBox PicEncrypte;

    }
}