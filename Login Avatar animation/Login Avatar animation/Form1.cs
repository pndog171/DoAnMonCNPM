using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Login_Avatar_animation
{
    public partial class Form1 : Form
    {
        List<Image> images = new List<Image>();
        string[] location = new string[25];
        public Form1()
        {
            InitializeComponent();
            location[0] = @"C:\Users\nguye\Downloads\Login Avatar animation\Login Avatar animation\animation\textbox_user_1.jpg";
            location[1] = @"C:\Users\nguye\Downloads\Login Avatar animation\Login Avatar animation\animation\textbox_user_2.jpg";
            location[2] = @"C:\Users\nguye\Downloads\Login Avatar animation\Login Avatar animation\animation\textbox_user_4.jpg";
            location[3] = @"C:\Users\nguye\Downloads\Login Avatar animation\Login Avatar animation\animation\textbox_user_5.jpg";
            location[4] = @"C:\Users\nguye\Downloads\Login Avatar animation\Login Avatar animation\animation\textbox_user_6.jpg";
            location[5] = @"C:\Users\nguye\Downloads\Login Avatar animation\Login Avatar animation\animation\textbox_user_7.jpg";
            location[6] = @"C:\Users\nguye\Downloads\Login Avatar animation\Login Avatar animation\animation\textbox_user_8.jpg";
            location[7] = @"C:\Users\nguye\Downloads\Login Avatar animation\Login Avatar animation\animation\textbox_user_9.jpg";
            location[8] = @"C:\Users\nguye\Downloads\Login Avatar animation\Login Avatar animation\animation\textbox_user_10.jpg";
            location[9] = @"C:\Users\nguye\Downloads\Login Avatar animation\Login Avatar animation\animation\textbox_user_11.jpg";
            location[10] = @"C:\Users\nguye\Downloads\Login Avatar animation\Login Avatar animation\animation\textbox_user_12.jpg";
            location[11] = @"C:\Users\nguye\Downloads\Login Avatar animation\Login Avatar animation\animation\textbox_user_13.jpg";
            location[12] = @"C:\Users\nguye\Downloads\Login Avatar animation\Login Avatar animation\animation\textbox_user_14.jpg";
            location[13] = @"C:\Users\nguye\Downloads\Login Avatar animation\Login Avatar animation\animation\textbox_user_15.jpg";
            location[14] = @"C:\Users\nguye\Downloads\Login Avatar animation\Login Avatar animation\animation\textbox_user_16.jpg";
            location[15] = @"C:\Users\nguye\Downloads\Login Avatar animation\Login Avatar animation\animation\textbox_user_17.jpg";
            location[16] = @"C:\Users\nguye\Downloads\Login Avatar animation\Login Avatar animation\animation\textbox_user_18.jpg";
            location[17] = @"C:\Users\nguye\Downloads\Login Avatar animation\Login Avatar animation\animation\textbox_user_19.jpg";
            location[18] = @"C:\Users\nguye\Downloads\Login Avatar animation\Login Avatar animation\animation\textbox_user_20.jpg";
            location[19] = @"C:\Users\nguye\Downloads\Login Avatar animation\Login Avatar animation\animation\textbox_user_21.jpg";
            location[20] = @"C:\Users\nguye\Downloads\Login Avatar animation\Login Avatar animation\animation\textbox_user_22.jpg";
            location[21] = @"C:\Users\nguye\Downloads\Login Avatar animation\Login Avatar animation\animation\textbox_user_23.jpg";
            location[22] = @"C:\Users\nguye\Downloads\Login Avatar animation\Login Avatar animation\animation\textbox_user_24.jpg";
            tounage();
        }

        private void tounage()
        {
            for(int i = 0; i < 23; i++)
            {
                Bitmap bitmap = new Bitmap(location[i]);
                images.Add(bitmap);
            }
            images.Add(Properties.Resources.textbox_user_24);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox1.Text.Length <= 15)
            {
                pictureBox1.Image = images[textBox1.Text.Length - 1];
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (textBox1.Text.Length <= 0)
                pictureBox1.Image = Properties.Resources.debut;
            else
                pictureBox1.Image = images[22];
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            Bitmap bmpass = new Bitmap(@"C:\Users\nguye\Downloads\Login Avatar animation\Login Avatar animation\animation\textbox_password.png");
            pictureBox1.Image = bmpass;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
                pictureBox1.Image = images[textBox1.Text.Length - 1];
            else
                pictureBox1.Image = Properties.Resources.debut;
            
        }
    }
}
