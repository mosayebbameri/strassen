using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Strassen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[,] A;
        int[,] B;
        int[,] C;
        int matrix_size;
        int stage = 1;

        string helpa1 = "ابتدا اولین ماتریس را وارد کنید. بین درایه های ماتریس از space و بین ردیف های ماتریس از Enter استفاده کنید.";
        string helpa2 = "پس از وارد کردن کامل ماتریس بر روی گزینه 'ادامه' کلیک کنید.";
        string helpb1 = "حال دومین ماتریس را همانند ماتریس قبل وارد کنید.";
        string helpc1 = "حاصل ضرب ابن دو ماتریس به این صورت می باشد.";
        string helpc2 = "برای برگشتن به مرحله قبل بر روی گزینه 'بازگشت' و برای انجام عملیات جدید بر روی گزینه 'شروع مجدد'  کلیک کنید.";



        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.IndianRed;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            (sender as Label).BackColor = SystemColors.Control;
        }

        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Label).BackColor = Color.DarkRed;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void FormMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            if (stage == 1)
            {
                int n = textbox.Text.Split('\n').Length;
                A = new int[n, n];
                B = new int[n, n];
                C = new int[n, n];

                //ساخت ماتریس اول
                A = Strassen.Parse(textbox.Text);

                if (A == null)
                {
                    MessageBox.Show("ماتریس به درستی وارد نشده است");
                    return;
                }
                matrix_size = (int)Math.Sqrt(A.Length);




                //Get B Ready:
                //کارهای گرافیکی
                stage = 2;

                textbox.Text = "";
                lbl1.BackColor = Color.SlateGray;
                lbl2.BackColor = Color.DarkSlateBlue;
                btnback.Visible = true;
                lblh1.Text = helpb1;
                lblmatrix.Text = "Matrix B";

            }
            //شروع قسمت دوم
            else if (stage == 2)
            {
                B = Strassen.Parse(textbox.Text);
                if (B == null)
                {
                    MessageBox.Show("ماتریس به درستی وارد نشده است");
                    return;
                }
                if (matrix_size != (int)Math.Sqrt(B.Length))
                {
                    MessageBox.Show("اندازه دو ماتریس با هم برابر نمی باشد");
                    return;
                }



                //Get C Ready:
                stage = 3;

                textbox.Text = "";
                lbl2.BackColor = Color.SlateGray;
                lbl3.BackColor = Color.DarkSlateBlue;
                btnnext.Visible = false;
                btnrenew.Visible = true;
                lblh1.Text = helpc1;
                lblh2.Text = helpc2;
                lblmatrix.Text = "The Result is:";

                Strassen s = new Strassen();
                C = s.strassenMatrixMultiplication(A, B);
                print(C);

            }
        }

        private void print(int[,] m)
        {
            for (int i = 0; i < matrix_size; i++)
            {
                for (int j = 0; j < matrix_size; j++)
                {
                    textbox.Text += m[i, j] + " ";
                }
                textbox.Text = textbox.Text.Substring(0, textbox.Text.Length - 1);
                textbox.Text += '\n';
            }
            textbox.Text = textbox.Text.Substring(0, textbox.Text.Length - 1);
        }

        private void btnrenew_Click(object sender, EventArgs e)
        {
            stage = 1;

            textbox.Text = "";
            lbl1.BackColor = Color.DarkSlateBlue;
            lbl2.BackColor = Color.SlateGray;
            lbl3.BackColor = Color.SlateGray;
            btnnext.Visible = true;
            btnrenew.Visible = false;
            btnback.Visible = false;
            lblh1.Text = helpa1;
            lblh2.Text = helpa2;
            lblmatrix.Text = "Matrix A";
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            if (stage == 2)
            {
                stage = 1;
                textbox.Text = "";
                print(A);
                lbl1.BackColor = Color.DarkSlateBlue;
                lbl2.BackColor = Color.SlateGray;
                lbl3.BackColor = Color.SlateGray;
                btnnext.Visible = true;
                btnrenew.Visible = false;
                btnback.Visible = false;
                lblh1.Text = helpa1;
                lblh2.Text = helpa2;
                lblmatrix.Text = "Matrix A";
            }
            else if (stage == 3)
            {
                stage = 2;

                textbox.Text = "";
                lbl1.BackColor = Color.SlateGray;
                lbl2.BackColor = Color.DarkSlateBlue;
                lbl3.BackColor = Color.SlateGray;
                btnback.Visible = true;
                btnnext.Visible = true;
                btnrenew.Visible = false;
                lblh1.Text = helpb1;
                lblh2.Text = helpa1;
                print(B);
                lblmatrix.Text = "Matrix B";
            }
        }

        private void textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblh1_Click(object sender, EventArgs e)
        {

        }

        private void lblh2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       
    }
}
