﻿
using System.Windows.Forms;
using CommonTools.Common;

namespace CommonTools.Win.Encrypte
{
    public partial class EncrypteForm : BaseForm
    {



        public EncrypteForm()
        {
            ApplySkin("McSkin");
            InitializeComponent();
        }

        private void EncrypteForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        ///  MD5加密
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-12-10 11:05:50
        private void PicSubmitMd5_Click(object sender, System.EventArgs e)
        {
            string plaintext = TxtPlaintext.Text.Trim();
            int txtnumber = TxtNumber.Text.Trim().ConvertToInt();
            int ciphertext1 = TxtCiphertext1.Text.Trim().ConvertToInt();
            int ciphertext2 = TxtCiphertext2.Text.Trim().ConvertToInt();
            if (string.IsNullOrEmpty(plaintext))
            {
                MessageBox.Show("请填写明文！");
                return;
            }
            if (txtnumber == -2 || ciphertext1 == -2 || ciphertext2 == -2)
            {
                MessageBox.Show("请正确填写数字！");
                return;
            }
            if (txtnumber <= 0)
            {
                MessageBox.Show("次数必须是大于1的整数！");
                return;
            }
            if (ciphertext1 < 0 || ciphertext1 > 32 || ciphertext2 <= 0 ||
                ciphertext2 > 32)
            {
                MessageBox.Show("密文长度必须在0~32范围内!");
                return;
            }
            //循环加密
            for (int i = 0; i < txtnumber; i++)
            {
                plaintext = plaintext.GetMd5();
            }
            //获取指定的长度密文
            TxtCiphertext.Text = plaintext.SubstringValue(ciphertext1, ciphertext2 - ciphertext1);
        }

        /// <summary>
        ///  组合键
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-12-10 15:47:34
        private void EncrypteForm_KeyDown(object sender, KeyEventArgs e)
        {
            if ((int)e.Modifiers == ((int)Keys.Control + (int)Keys.Alt + (int)Keys.Shift))
            {
                labelControl2.Visible = labelControl3.Visible = labelControl5.Visible = labelControl6.Visible = labelControl7.Visible = TxtNumber.Visible = TxtCiphertext1.Visible = TxtCiphertext2.Visible = !labelControl2.Visible;
            }
        }

        /// <summary>
        ///  返回按钮
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-12-10 15:47:26
        private void BtnReturn_Click(object sender, System.EventArgs e)
        {
            StartForm start = new StartForm();
            Application.Exit();
            start.Show();
            
        }



    }
}
