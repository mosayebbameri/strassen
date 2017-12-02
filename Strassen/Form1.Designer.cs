namespace Strassen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pmain = new System.Windows.Forms.Panel();
            this.popration = new System.Windows.Forms.Panel();
            this.textbox = new System.Windows.Forms.RichTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lblmatrix = new System.Windows.Forms.Label();
            this.phelp = new System.Windows.Forms.Panel();
            this.lblh2 = new System.Windows.Forms.Label();
            this.pbuttons = new System.Windows.Forms.Panel();
            this.btnnext = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Label();
            this.btnrenew = new System.Windows.Forms.Label();
            this.lblh1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.pspace = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pmain.SuspendLayout();
            this.popration.SuspendLayout();
            this.phelp.SuspendLayout();
            this.pbuttons.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pmain
            // 
            this.pmain.Controls.Add(this.popration);
            this.pmain.Controls.Add(this.phelp);
            this.pmain.Controls.Add(this.tableLayoutPanel1);
            this.pmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pmain.Location = new System.Drawing.Point(0, 153);
            this.pmain.Name = "pmain";
            this.pmain.Size = new System.Drawing.Size(715, 375);
            this.pmain.TabIndex = 5;
            // 
            // popration
            // 
            this.popration.BackColor = System.Drawing.Color.WhiteSmoke;
            this.popration.Controls.Add(this.textbox);
            this.popration.Controls.Add(this.label17);
            this.popration.Controls.Add(this.lblmatrix);
            this.popration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.popration.Location = new System.Drawing.Point(0, 34);
            this.popration.Name = "popration";
            this.popration.Size = new System.Drawing.Size(410, 341);
            this.popration.TabIndex = 1;
            // 
            // textbox
            // 
            this.textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textbox.Location = new System.Drawing.Point(12, 46);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(390, 257);
            this.textbox.TabIndex = 3;
            this.textbox.Text = "";
            this.textbox.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Silver;
            this.label17.Dock = System.Windows.Forms.DockStyle.Right;
            this.label17.Location = new System.Drawing.Point(408, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(2, 341);
            this.label17.TabIndex = 2;
            this.label17.Text = "label17";
            // 
            // lblmatrix
            // 
            this.lblmatrix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblmatrix.BackColor = System.Drawing.Color.Gainsboro;
            this.lblmatrix.Location = new System.Drawing.Point(11, 18);
            this.lblmatrix.Name = "lblmatrix";
            this.lblmatrix.Size = new System.Drawing.Size(392, 28);
            this.lblmatrix.TabIndex = 1;
            this.lblmatrix.Text = "Matrix A";
            // 
            // phelp
            // 
            this.phelp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.phelp.Controls.Add(this.lblh2);
            this.phelp.Controls.Add(this.pbuttons);
            this.phelp.Controls.Add(this.lblh1);
            this.phelp.Controls.Add(this.label15);
            this.phelp.Dock = System.Windows.Forms.DockStyle.Right;
            this.phelp.Location = new System.Drawing.Point(410, 34);
            this.phelp.Name = "phelp";
            this.phelp.Size = new System.Drawing.Size(305, 341);
            this.phelp.TabIndex = 0;
            // 
            // lblh2
            // 
            this.lblh2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblh2.Location = new System.Drawing.Point(0, 245);
            this.lblh2.Name = "lblh2";
            this.lblh2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblh2.Size = new System.Drawing.Size(305, 58);
            this.lblh2.TabIndex = 4;
            this.lblh2.Text = "پس از وارد کردن کامل ماتریس بر روی گزینه \'ادامه\' کلیک کنید.";
            this.lblh2.Click += new System.EventHandler(this.lblh2_Click);
            // 
            // pbuttons
            // 
            this.pbuttons.Controls.Add(this.btnnext);
            this.pbuttons.Controls.Add(this.btnback);
            this.pbuttons.Controls.Add(this.btnrenew);
            this.pbuttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbuttons.Location = new System.Drawing.Point(0, 303);
            this.pbuttons.Name = "pbuttons";
            this.pbuttons.Size = new System.Drawing.Size(305, 38);
            this.pbuttons.TabIndex = 6;
            // 
            // btnnext
            // 
            this.btnnext.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnnext.Location = new System.Drawing.Point(10, 4);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(109, 28);
            this.btnnext.TabIndex = 0;
            this.btnnext.Text = "ادامه";
            this.btnnext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnnext.Click += new System.EventHandler(this.label10_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnback.Location = new System.Drawing.Point(190, 4);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(109, 28);
            this.btnback.TabIndex = 1;
            this.btnback.Text = "بازگشت";
            this.btnback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnback.Visible = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnrenew
            // 
            this.btnrenew.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnrenew.Location = new System.Drawing.Point(6, 4);
            this.btnrenew.Name = "btnrenew";
            this.btnrenew.Size = new System.Drawing.Size(144, 28);
            this.btnrenew.TabIndex = 2;
            this.btnrenew.Text = "شروع مجدد";
            this.btnrenew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnrenew.Visible = false;
            this.btnrenew.Click += new System.EventHandler(this.btnrenew_Click);
            // 
            // lblh1
            // 
            this.lblh1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblh1.Location = new System.Drawing.Point(0, 31);
            this.lblh1.Name = "lblh1";
            this.lblh1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblh1.Size = new System.Drawing.Size(305, 89);
            this.lblh1.TabIndex = 3;
            this.lblh1.Text = "ابتدا اولین ماتریس را وارد کنید. بین درایه های ماتریس از space و بین ردیف های مات" +
    "ریس از Enter استفاده کنید.";
            this.lblh1.Click += new System.EventHandler(this.lblh1_Click);
            // 
            // label15
            // 
            this.label15.Dock = System.Windows.Forms.DockStyle.Top;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label15.Size = new System.Drawing.Size(305, 31);
            this.label15.TabIndex = 5;
            this.label15.Text = "راهنما:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.Controls.Add(this.lbl3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(715, 34);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // lbl3
            // 
            this.lbl3.BackColor = System.Drawing.Color.SlateGray;
            this.lbl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl3.Location = new System.Drawing.Point(3, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(232, 34);
            this.lbl3.TabIndex = 4;
            this.lbl3.Text = "مرحله سوم";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl1.Location = new System.Drawing.Point(479, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(233, 34);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "مرحله اول";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl2
            // 
            this.lbl2.BackColor = System.Drawing.Color.SlateGray;
            this.lbl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl2.Location = new System.Drawing.Point(241, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(232, 34);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "مرحله دوم";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pspace
            // 
            this.pspace.Dock = System.Windows.Forms.DockStyle.Top;
            this.pspace.Location = new System.Drawing.Point(0, 147);
            this.pspace.Name = "pspace";
            this.pspace.Size = new System.Drawing.Size(715, 6);
            this.pspace.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 147);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMove);
            // 
            // label9
            // 
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Location = new System.Drawing.Point(12, 102);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(111, 27);
            this.label9.TabIndex = 6;
            this.label9.Text = "تمام صفحه";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            this.label9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label4_MouseDown);
            this.label9.MouseEnter += new System.EventHandler(this.label4_MouseEnter);
            this.label9.MouseLeave += new System.EventHandler(this.label4_MouseLeave);
            // 
            // label4
            // 
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Location = new System.Drawing.Point(12, 26);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(111, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "خروج از برنامه";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label4_MouseDown);
            this.label4.MouseEnter += new System.EventHandler(this.label4_MouseEnter);
            this.label4.MouseLeave += new System.EventHandler(this.label4_MouseLeave);
            // 
            // label5
            // 
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Location = new System.Drawing.Point(12, 64);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(111, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "پنهان کردن";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label4_MouseDown);
            this.label5.MouseEnter += new System.EventHandler(this.label4_MouseEnter);
            this.label5.MouseLeave += new System.EventHandler(this.label4_MouseLeave);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(459, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(242, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "دانشگاه آزاد اسلامی - واحد سرخس";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMove);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(459, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(242, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "مصیب بامری";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMove);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(399, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(309, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "الگوریتم ضرب استراسن";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(715, 528);
            this.Controls.Add(this.pmain);
            this.Controls.Add(this.pspace);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pmain.ResumeLayout(false);
            this.popration.ResumeLayout(false);
            this.phelp.ResumeLayout(false);
            this.pbuttons.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pmain;
        private System.Windows.Forms.Panel phelp;
        private System.Windows.Forms.Panel popration;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Panel pspace;
        private System.Windows.Forms.Label lblh2;
        private System.Windows.Forms.Panel pbuttons;
        private System.Windows.Forms.Label btnnext;
        private System.Windows.Forms.Label btnback;
        private System.Windows.Forms.Label btnrenew;
        private System.Windows.Forms.Label lblh1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblmatrix;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RichTextBox textbox;
    }
}

