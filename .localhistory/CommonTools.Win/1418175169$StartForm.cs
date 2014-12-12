﻿
using System.Drawing;
using System.Windows.Forms;

namespace CommonTools.Win
{
    public partial class StartForm : BaseForm
    {



        public StartForm()
        {
            ApplySkin("McSkin");
            InitializeComponent();
        }

        private void StartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        ///  加解密
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-12-10 09:19:54
        private void PicEncrypte_Click(object sender, System.EventArgs e)
        {
            ChangeBackColor(Color.SteelBlue, PicEncrypte);
        }

        /// <summary>
        ///  鼠标停留控件
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-12-08 21:01:27
        private void PicEncrypte_MouseEnter(object sender, System.EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is PictureBox && control.Focused)
                {
                    ChangeBackColor(Color.Navy, PicEncrypte);
                }
            }
        }

        /// <summary>
        ///  鼠标离开控件
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-12-08 21:05:52
        private void PicEncrypte_MouseLeave(object sender, System.EventArgs e)
        {
            ChangeBackColor(Color.Transparent, PicEncrypte);
        }

        /// <summary>
        ///  设置按钮边框颜色
        /// </summary>
        /// <param name="color">颜色</param>
        /// <param name="pictureBox">按钮</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-12-08 21:01:07
        private void SetPicBoxColor(Color color, PictureBox pictureBox)
        {
            Graphics g = pictureBox.CreateGraphics();
            Pen pen = new Pen(color, 2);
            g.DrawRectangle(pen, pictureBox.ClientRectangle.X, pictureBox.ClientRectangle.Y, pictureBox.ClientRectangle.X + pictureBox.ClientRectangle.Width, pictureBox.ClientRectangle.Y + pictureBox.ClientRectangle.Height);
        }

        /// <summary>
        ///  改变背景色
        /// </summary>
        /// <param name="color">颜色</param>
        /// <param name="pictureBox">按钮</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-12-08 21:40:03
        private void ChangeBackColor(Color color, PictureBox pictureBox)
        {
            pictureBox.BackColor = color;
            pictureBox.Refresh();
        }



    }
}