using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Tetris1
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer hudba = new System.Media.SoundPlayer();
        private Label[,] labely;
        private Color[,] misto;
        private int spawnmisto;
        private int spawnmisto2;
        private int AktTvar = 0;
        private int otoceni = 0;
        private int vyska;
        private int skore = 0;
        private Color randomColor;
        private bool spusteno = false;
        private int cas;
        private bool padani = false;
        private bool VN = false;
        private bool StisknutiW = false;
        public Form1()
        {
            hudba.SoundLocation = "Tetris  Main Theme.wav";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            cas = 1000;
            misto = new Color[20, 10];
            for (int i = 0; i < (misto.GetLength(0)); i++)
            {
                for (int x = 0; x < misto.GetLength(1); x++)
                {
                    misto[i, x] = Color.Black;
                }
            }
            spawnmisto = 0;
            spawnmisto2 = 4;
            InitializeComponent();
            labely = new Label[20, 10] { { label0, label1, label2, label3, label4, label5, label6, label7, label8, label9 }, { label10, label11, label12, label13, label14, label15, label16, label17, label18, label19 }, { label20, label21, label22, label23, label24, label25, label26, label27, label28, label29 }, { label30, label31, label32, label33, label34, label35, label36, label37, label38, label39 }, { label40, label41, label42, label43, label44, label45, label46, label47, label48, label49 }, { label50, label51, label52, label53, label54, label55, label56, label57, label58, label59 }, { label60, label61, label62, label63, label64, label65, label66, label67, label68, label69 }, { label70, label71, label72, label73, label74, label75, label76, label77, label78, label79 }, { label80, label81, label82, label83, label84, label85, label86, label87, label88, label89 }, { label90, label91, label92, label93, label94, label95, label96, label97, label98, label99 }, { label100, label101, label102, label103, label104, label105, label106, label107, label108, label109 }, { label110, label111, label112, label113, label114, label115, label116, label117, label118, label119 }, { label120, label121, label122, label123, label124, label125, label126, label127, label128, label129 }, { label130, label131, label132, label133, label134, label135, label136, label137, label138, label139 }, { label140, label141, label142, label143, label144, label145, label146, label147, label148, label149 }, { label150, label151, label152, label153, label154, label155, label156, label157, label158, label159 }, { label160, label161, label162, label163, label164, label165, label166, label167, label168, label169 }, { label170, label171, label172, label173, label174, label175, label176, label177, label178, label179 }, { label180, label181, label182, label183, label184, label185, label186, label187, label188, label189 }, { label190, label191, label192, label193, label194, label195, label196, label197, label198, label199 } };
            if (VN == false)
            {
                label202.Visible = false;
                label203.Visible = false;
                numericUpDown2.Enabled = false;
                numericUpDown2.Visible = false;
                button1.Enabled = false;
                button1.Visible = false;
                button2.Enabled = false;
                button2.Visible = false;
                this.Width = 360;
                numericUpDown1.Enabled = false;
                numericUpDown1.Visible = false;
                label201.Visible = false;
                VN = false;
                checkBox1.Enabled = false;
                checkBox1.Visible = false;
                checkBox2.Enabled = false;
                checkBox2.Visible = false;
            }
            checkBox1.Checked = true;
            checkBox2.Checked = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Label[] labely1 = new Label[] { label0, label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label11, label12, label13, label14, label15, label16, label17, label18, label19, label20, label21, label22, label23, label24, label25, label26, label27, label28, label29, label30, label31, label32, label33, label34, label35, label36, label37, label38, label39, label40, label41, label42, label43, label44, label45, label46, label47, label48, label49, label50, label51, label52, label53, label54, label55, label56, label57, label58, label59, label60, label61, label62, label63, label64, label65, label66, label67, label68, label69, label70, label71, label72, label73, label74, label75, label76, label77, label78, label79, label80, label81, label82, label83, label84, label85, label86, label87, label88, label89, label90, label91, label92, label93, label94, label95, label96, label97, label98, label99, label100, label101, label102, label103, label104, label105, label106, label107, label108, label109, label110, label111, label112, label113, label114, label115, label116, label117, label118, label119, label120, label121, label122, label123, label124, label125, label126, label127, label128, label129, label130, label131, label132, label133, label134, label135, label136, label137, label138, label139, label140, label141, label142, label143, label144, label145, label146, label147, label148, label149, label150, label151, label152, label153, label154, label155, label156, label157, label158, label159, label160, label161, label162, label163, label164, label165, label166, label167, label168, label169, label170, label171, label172, label173, label174, label175, label176, label177, label178, label179, label180, label181, label182, label183, label184, label185, label186, label187, label188, label189, label190, label191, label192, label193, label194, label195, label196, label197, label198, label199 };
            Random rnd = new Random();
            for (int i = 0; i < 200; i++)
            {
                randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                labely1[i].BackColor = randomColor;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void clear()
        {
            for (int i = 0; i < (misto.GetLength(0)); i++)
            {
                for (int x = 0; x < misto.GetLength(1); x++)
                {
                    misto[i, x] = Color.Black;
                }

            }
            zobrazeni();
        }

        public void zobrazeni()
        {
            for (int i = 0; i < (labely.GetLength(0)); i++)
            {
                for (int x = 0; x < labely.GetLength(1); x++)
                {
                    labely[i, x].BackColor = misto[i, x];
                }

            }
        }
        public void tvar()
        {
            Random rnd = new Random();
            AktTvar = rnd.Next(0, 7);
        }

        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        private void konec()
        {
            spusteno = false;
            MessageBox.Show("Prohrál jsi!\nTvoje skóre bylo: " + skore + "\nStiskni OK pro pokračování");
            start.Enabled = true;
            button7.Enabled = true;
            if (VN == true)
            {
                numericUpDown2.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;
                numericUpDown1.Enabled = true;
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
            }
            skore = 0;
            clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (VN == true)
            {
                numericUpDown2.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                numericUpDown1.Enabled = false;
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
            }
            Console.WriteLine("test");
            start.Enabled = false;
            label200.Text = "SKÓRE: " + skore;
            spusteno = true;
            button7.Enabled = false;
            while (spusteno == true)
            {
                otoceni = 0;
                spawnmisto2 = 4;
                spawnmisto = 0;
                padani = false;

                Random rnd = new Random();

                do
                {
                    randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                } while (randomColor == Color.Black);
                tvar();
                if(numericUpDown2.Value != 7)
                    AktTvar = Convert.ToInt32(numericUpDown2.Value);
                /*
                 * 0 - L
                 * 1 - ⍙
                 * 2 - I
                 * 3 - ⊞
                 * 4 - ⅃
                 * 5 - S
                 * 6 - Z
                 */

                vyska = 1;
                zobrazeni();
                padani = false;
                kontrola();

                switch (AktTvar)
                {
                    case 0:
                        if (!(misto[spawnmisto + vyska, spawnmisto2] == Color.Black && misto[spawnmisto + 1 + vyska, spawnmisto2] == Color.Black && misto[spawnmisto + 2 + vyska, spawnmisto2] == Color.Black && misto[spawnmisto + 2 + vyska, spawnmisto2 + 1] == Color.Black))
                            konec();
                        break;
                    case 1:
                        if (!(misto[spawnmisto + vyska, spawnmisto2] == Color.Black && misto[(spawnmisto + 1 + vyska), spawnmisto2] == Color.Black && misto[(spawnmisto + 1 + vyska), spawnmisto2 - 1] == Color.Black && misto[(spawnmisto + 1 + vyska), spawnmisto2 + 1] == Color.Black))
                            konec();
                        break;
                    case 2:
                        if (!(misto[spawnmisto + vyska, spawnmisto2] == Color.Black && misto[(spawnmisto + 1 + vyska), spawnmisto2] == Color.Black && misto[(spawnmisto + 2 + vyska), spawnmisto2] == Color.Black && misto[(spawnmisto + 3 + vyska), spawnmisto2] == Color.Black))
                            konec();
                        break;
                    case 3:
                        if (!(misto[spawnmisto + vyska, spawnmisto2] == Color.Black && misto[spawnmisto + vyska, spawnmisto2 + 1] == Color.Black && misto[spawnmisto + 1 + vyska, spawnmisto2] == Color.Black && misto[spawnmisto + 1 + vyska, spawnmisto2 + 1] == Color.Black))
                            konec();
                        break;
                    case 4:
                        if (!(misto[spawnmisto + vyska, spawnmisto2] == Color.Black && misto[spawnmisto + 1 + vyska, spawnmisto2] == Color.Black && misto[spawnmisto + 2 + vyska, spawnmisto2] == Color.Black && misto[spawnmisto + 2 + vyska, spawnmisto2 - 1] == Color.Black))
                            konec();
                        break;
                    case 5:
                        if (!(misto[spawnmisto + vyska, spawnmisto2] == Color.Black && misto[spawnmisto - 1 + vyska, spawnmisto2] == Color.Black && misto[spawnmisto - 1 + vyska, spawnmisto2 + 1] == Color.Black && misto[spawnmisto + vyska, spawnmisto2 - 1] == Color.Black))
                            konec();
                        break;
                    case 6:
                        if (!(misto[spawnmisto + vyska, spawnmisto2] == Color.Black && misto[spawnmisto - 1 + vyska, spawnmisto2] == Color.Black && misto[spawnmisto - 1 + vyska, spawnmisto2 - 1] == Color.Black && misto[spawnmisto + vyska, spawnmisto2 + 1] == Color.Black))
                            konec();
                        break;
                }

                padani = true;
                for (int i = 1; padani == true && spusteno == true; i++)
                {
                    vyska = i;
                    try
                    {
                        switch(AktTvar)
                        { 
                            case 0:
                        //tvar 0
                                switch (otoceni)
                                {
                                    case 0:                        
                                        if (misto[spawnmisto + 2 + i, spawnmisto2] == Color.Black && misto[spawnmisto + 2 + i, spawnmisto2 + 1] == Color.Black)
                                        {
                                            misto[spawnmisto + (i - 1), spawnmisto2] = Color.Black;
                                            misto[(spawnmisto + 1 + (i - 1)), spawnmisto2] = Color.Black;
                                            misto[(spawnmisto + 2 + (i - 1)), spawnmisto2] = Color.Black;
                                            misto[(spawnmisto + 2 + (i - 1)), spawnmisto2 + 1] = Color.Black;

                                            misto[spawnmisto + i, spawnmisto2] = randomColor;
                                            misto[spawnmisto + 1 + i, spawnmisto2] = randomColor;
                                            misto[spawnmisto + 2 + i, spawnmisto2] = randomColor;
                                            misto[spawnmisto + 2 + i, spawnmisto2 + 1] = randomColor;
                                        }
                                        else
                                        {
                                            padani = false;
                                        }  
                                        break;
                                    case 1:
                                        if(misto[spawnmisto + i, spawnmisto2] == Color.Black && misto[spawnmisto + i, spawnmisto2+1] == Color.Black && misto[spawnmisto + i, spawnmisto2 + 2] == Color.Black)
                                        {
                                            misto[spawnmisto + vyska-1, spawnmisto2] = Color.Black;
                                            misto[spawnmisto + vyska-1, spawnmisto2 + 1] = Color.Black;
                                            misto[spawnmisto + vyska-1, spawnmisto2 + 2] = Color.Black;
                                            misto[spawnmisto - 2 + vyska, spawnmisto2 + 2] = Color.Black;

                                            misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                            misto[spawnmisto + vyska, spawnmisto2 + 1] = randomColor;
                                            misto[spawnmisto + vyska, spawnmisto2 + 2] = randomColor;
                                            misto[spawnmisto - 1 + vyska, spawnmisto2 + 2] = randomColor;
                                        }
                                        else
                                        {
                                            padani = false;
                                        }
                                        break;
                                    case 2:
                                        if(misto[spawnmisto + vyska, spawnmisto2] == Color.Black && misto[spawnmisto + vyska - 2, spawnmisto2 - 1] == Color.Black)
                                        {
                                            misto[spawnmisto + vyska - 1, spawnmisto2] = Color.Black;
                                            misto[spawnmisto + vyska - 2, spawnmisto2] = Color.Black;
                                            misto[spawnmisto + vyska - 3, spawnmisto2] = Color.Black;
                                            misto[spawnmisto + vyska - 3, spawnmisto2 - 1] = Color.Black;

                                            misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                            misto[spawnmisto + vyska - 1, spawnmisto2] = randomColor;
                                            misto[spawnmisto + vyska - 2, spawnmisto2] = randomColor;
                                            misto[spawnmisto + vyska - 2, spawnmisto2 - 1] = randomColor;
                                        }
                                        else
                                        {
                                            padani = false;
                                        }
                                        break;
                                    case 3:
                                        if(misto[spawnmisto + 1 + vyska, spawnmisto2 - 2] == Color.Black && misto[spawnmisto + vyska, spawnmisto2 - 1] == Color.Black && misto[spawnmisto + vyska, spawnmisto2] == Color.Black)
                                        {
                                            misto[spawnmisto + vyska-1, spawnmisto2] = Color.Black;
                                            misto[spawnmisto + vyska-1, spawnmisto2 - 1] = Color.Black;
                                            misto[spawnmisto + vyska-1, spawnmisto2 - 2] = Color.Black;
                                            misto[spawnmisto + vyska, spawnmisto2 - 2] = Color.Black;

                                            misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                            misto[spawnmisto + vyska, spawnmisto2 - 1] = randomColor;
                                            misto[spawnmisto + vyska, spawnmisto2 - 2] = randomColor;
                                            misto[spawnmisto + 1 + vyska, spawnmisto2 - 2] = randomColor;
                                        }
                                        else
                                        {
                                            padani = false;
                                        }
                                        break;
                                }
                                
                                zobrazeni();
                                wait(cas);
                               break;
                            case 1:
                        //tvar 1
                                switch (otoceni)
                                {
                                    case 0:
                                        if (misto[spawnmisto + 1 + vyska, spawnmisto2] == Color.Black && misto[spawnmisto + 1 + vyska, spawnmisto2 + 1] == Color.Black && misto[spawnmisto + 1 + vyska, spawnmisto2 - 1] == Color.Black)
                                        {
                                            misto[spawnmisto + (i - 1), spawnmisto2] = Color.Black;
                                            misto[(spawnmisto + 1 + (i - 1)), spawnmisto2] = Color.Black;
                                            misto[(spawnmisto + 1 + (i - 1)), spawnmisto2 - 1] = Color.Black;
                                            misto[(spawnmisto + 1 + (i - 1)), spawnmisto2 + 1] = Color.Black;

                                            misto[spawnmisto + i, spawnmisto2] = randomColor;
                                            misto[(spawnmisto + 1 + i), spawnmisto2] = randomColor;
                                            misto[(spawnmisto + 1 + i), spawnmisto2 - 1] = randomColor;
                                            misto[(spawnmisto + 1 + i), spawnmisto2 + 1] = randomColor;
                                        }
                                        else
                                        {
                                            padani = false;
                                        }
                                        break;
                                    case 1:
                                        if(misto[spawnmisto + vyska, spawnmisto2] == Color.Black && misto[(spawnmisto + 1 + vyska), spawnmisto2 + 1] == Color.Black)
                                        {
                                            misto[spawnmisto + vyska-1, spawnmisto2] = Color.Black;
                                            misto[(spawnmisto + vyska-1), spawnmisto2 + 1] = Color.Black;
                                            misto[(spawnmisto + 1 + vyska-1), spawnmisto2 + 1] = Color.Black;
                                            misto[(spawnmisto - 1 + vyska-1), spawnmisto2 + 1] = Color.Black;

                                            misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                            misto[(spawnmisto + vyska), spawnmisto2 + 1] = randomColor;
                                            misto[(spawnmisto + 1 + vyska), spawnmisto2 + 1] = randomColor;
                                            misto[(spawnmisto - 1 + vyska), spawnmisto2 + 1] = randomColor;
                                        }
                                        else
                                        {
                                            padani = false;
                                        }
                                        break;
                                    case 2:
                                        if (misto[spawnmisto + vyska, spawnmisto2] == Color.Black && misto[(spawnmisto - 1 + vyska), spawnmisto2 + 1] == Color.Black && misto[(spawnmisto - 1 + vyska), spawnmisto2 - 1] == Color.Black)
                                        {
                                            misto[spawnmisto + vyska-1, spawnmisto2] = Color.Black;
                                            misto[(spawnmisto + vyska - 2), spawnmisto2] = Color.Black;
                                            misto[(spawnmisto - 2 + vyska), spawnmisto2 + 1] = Color.Black;
                                            misto[(spawnmisto - 2 + vyska), spawnmisto2 - 1] = Color.Black;

                                            misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                            misto[(spawnmisto + vyska - 1), spawnmisto2] = randomColor;
                                            misto[(spawnmisto - 1 + vyska), spawnmisto2 + 1] = randomColor;
                                            misto[(spawnmisto - 1 + vyska), spawnmisto2 - 1] = randomColor;
                                        }
                                        else
                                        {
                                            padani = false;
                                        }
                                        break;
                                    case 3:
                                        if (misto[spawnmisto + vyska, spawnmisto2] == Color.Black && misto[(spawnmisto + 1 + vyska), spawnmisto2 - 1] == Color.Black)
                                        {
                                            misto[spawnmisto + vyska-1, spawnmisto2] = Color.Black;
                                            misto[(spawnmisto + vyska-1), spawnmisto2 - 1] = Color.Black;
                                            misto[(spawnmisto - 1 + vyska-1), spawnmisto2 - 1] = Color.Black;
                                            misto[(spawnmisto + 1 + vyska-1), spawnmisto2 - 1] = Color.Black;

                                            misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                            misto[(spawnmisto + vyska), spawnmisto2 - 1] = randomColor;
                                            misto[(spawnmisto - 1 + vyska), spawnmisto2 - 1] = randomColor;
                                            misto[(spawnmisto + 1 + vyska), spawnmisto2 - 1] = randomColor;
                                        }
                                        else
                                        {
                                            padani = false;
                                        }
                                        break;
                                }
                               
                                zobrazeni();
                                wait(cas);

                                break;
                            case 2:
                        //tvar 2
                                switch (otoceni)
                                {
                                    case 0:
                                        if (misto[spawnmisto + 3 + vyska, spawnmisto2] == Color.Black )
                                        {
                                            misto[spawnmisto + (i - 1), spawnmisto2] = Color.Black;
                                            misto[(spawnmisto + 1 + (i - 1)), spawnmisto2] = Color.Black;
                                            misto[(spawnmisto + 2 + (i - 1)), spawnmisto2] = Color.Black;
                                            misto[(spawnmisto + 3 + (i - 1)), spawnmisto2] = Color.Black;

                                            misto[spawnmisto + i, spawnmisto2] = randomColor;
                                            misto[(spawnmisto + 1 + i), spawnmisto2] = randomColor;
                                            misto[(spawnmisto + 2 + i), spawnmisto2] = randomColor;
                                            misto[(spawnmisto + 3 + i), spawnmisto2] = randomColor;
                                        }
                                        else
                                        {
                                            padani = false;
                                        }
                                        break;
                                    case 1:
                                        if (misto[spawnmisto + vyska, spawnmisto2] == Color.Black && misto[spawnmisto + vyska, spawnmisto2-1] == Color.Black && misto[spawnmisto + vyska, spawnmisto2 + 1] == Color.Black && misto[spawnmisto + vyska, spawnmisto2 + 2] == Color.Black/*misto[spawnmisto + 2 + i, spawnmisto2] == Color.Black || misto[spawnmisto + 2 + i, spawnmisto2 + 1] == Color.Black || misto[spawnmisto + 2 + i, spawnmisto2 - 1] == Color.Black*/)
                                        {
                                            misto[spawnmisto + (i - 1), spawnmisto2] = Color.Black;
                                            misto[(spawnmisto + (i - 1)), spawnmisto2-1] = Color.Black;
                                            misto[(spawnmisto + (i - 1)), spawnmisto2+1]= Color.Black;
                                            misto[(spawnmisto + (i - 1)), spawnmisto2+2] = Color.Black;

                                            misto[spawnmisto + i, spawnmisto2] = randomColor;
                                            misto[(spawnmisto + i), spawnmisto2-1] = randomColor;
                                            misto[(spawnmisto + i), spawnmisto2+1] = randomColor;
                                            misto[(spawnmisto + i), spawnmisto2+2] = randomColor;

                                        }
                                        else
                                        {
                                            padani = false;
                                        }
                                        break;
                                }
            
                                zobrazeni();
                                wait(cas);
                                break;
                            case 3:
                        //tvar3
                                if (misto[spawnmisto + 1 + i, spawnmisto2 + 1] == Color.Black && misto[spawnmisto + 1 + i, spawnmisto2] == Color.Black)
                                {
                                    misto[spawnmisto + i-1, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + i-1, spawnmisto2 + 1] = Color.Black;
                                    misto[spawnmisto + 1 + i-1, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + 1 + i-1, spawnmisto2 + 1] = Color.Black;

                                    misto[spawnmisto + i, spawnmisto2] = randomColor;
                                    misto[spawnmisto + i, spawnmisto2+1] = randomColor;
                                    misto[spawnmisto + 1 + i, spawnmisto2] = randomColor;
                                    misto[spawnmisto + 1 + i, spawnmisto2 + 1] = randomColor;

                                    zobrazeni();
                                    wait(cas);
                                }
                                else
                                {
                                    padani = false;
                                }
                                break;
                            case 4:
                        //tvar 4
                                switch (otoceni)
                                {
                                    case 0:
                                        if (misto[spawnmisto + 2 + i, spawnmisto2] == Color.Black && misto[spawnmisto + 2 + i, spawnmisto2 - 1] == Color.Black)
                                        {
                                            misto[spawnmisto + (i - 1), spawnmisto2] = Color.Black;
                                            misto[(spawnmisto + 1 + (i - 1)), spawnmisto2] = Color.Black;
                                            misto[(spawnmisto + 2 + (i - 1)), spawnmisto2] = Color.Black;
                                            misto[(spawnmisto + 2 + (i - 1)), spawnmisto2 - 1] = Color.Black;

                                            misto[spawnmisto + i, spawnmisto2] = randomColor;
                                            misto[spawnmisto + 1 + i, spawnmisto2] = randomColor;
                                            misto[spawnmisto + 2 + i, spawnmisto2] = randomColor;
                                            misto[spawnmisto + 2 + i, spawnmisto2 - 1] = randomColor;
                                        }
                                        else
                                        {
                                            padani = false;
                                        }
                                        break;
                                    case 1:
                                        if (misto[spawnmisto + i, spawnmisto2] == Color.Black && misto[spawnmisto + i, spawnmisto2 + 1] == Color.Black && misto[spawnmisto + i+1, spawnmisto2 + 2] == Color.Black)
                                        {
                                            misto[spawnmisto + vyska - 1, spawnmisto2] = Color.Black;
                                            misto[spawnmisto + vyska - 1, spawnmisto2 + 1] = Color.Black;
                                            misto[spawnmisto + vyska - 1, spawnmisto2 + 2] = Color.Black;
                                            misto[spawnmisto + 1 + vyska - 1, spawnmisto2 + 2] = Color.Black;

                                            misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                            misto[spawnmisto + vyska, spawnmisto2 + 1] = randomColor;
                                            misto[spawnmisto + vyska, spawnmisto2 + 2] = randomColor;
                                            misto[spawnmisto + 1 + vyska, spawnmisto2 + 2] = randomColor;
                                        }
                                        else
                                        {
                                            padani = false;
                                        }
                                        break;
                                    case 2:
                                        if (misto[spawnmisto + vyska, spawnmisto2] == Color.Black && misto[spawnmisto + vyska - 2, spawnmisto2 + 1] == Color.Black)
                                        {
                                            misto[spawnmisto + vyska - 1, spawnmisto2] = Color.Black;
                                            misto[spawnmisto + vyska - 2, spawnmisto2] = Color.Black;
                                            misto[spawnmisto + vyska - 3, spawnmisto2] = Color.Black;
                                            misto[spawnmisto + vyska - 3, spawnmisto2 + 1] = Color.Black;

                                            misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                            misto[spawnmisto + vyska - 1, spawnmisto2] = randomColor;
                                            misto[spawnmisto + vyska - 2, spawnmisto2] = randomColor;
                                            misto[spawnmisto + vyska - 2, spawnmisto2 + 1] = randomColor;
                                        }
                                        else
                                        {
                                            padani = false;
                                        }
                                        break;
                                    case 3:
                                        if (misto[spawnmisto + vyska, spawnmisto2 - 2] == Color.Black && misto[spawnmisto + vyska, spawnmisto2 - 1] == Color.Black && misto[spawnmisto + vyska, spawnmisto2] == Color.Black)
                                        {
                                            misto[spawnmisto + vyska - 1, spawnmisto2] = Color.Black;
                                            misto[spawnmisto + vyska - 1, spawnmisto2 - 1] = Color.Black;
                                            misto[spawnmisto + vyska - 1, spawnmisto2 - 2] = Color.Black;
                                            misto[spawnmisto + vyska -2, spawnmisto2 - 2] = Color.Black;

                                            misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                            misto[spawnmisto + vyska, spawnmisto2 - 1] = randomColor;
                                            misto[spawnmisto + vyska, spawnmisto2 - 2] = randomColor;
                                            misto[spawnmisto - 1 + vyska, spawnmisto2 - 2] = randomColor;
                                        }
                                        else
                                        {
                                            padani = false;
                                        }
                                        break;
                                }
                                zobrazeni();
                                wait(cas);
                                break;
                            case 5:
                         //tvar 5
                                switch (otoceni)
                                {
                                    case 0:
                                        if (misto[spawnmisto + i, spawnmisto2] == Color.Black && misto[spawnmisto + i, spawnmisto2 - 1] == Color.Black && misto[spawnmisto - 1 + i, spawnmisto2 + 1] == Color.Black)
                                        {
                                            if(vyska!=1)
                                            {
                                                misto[spawnmisto + i-1, spawnmisto2] = Color.Black;
                                                misto[spawnmisto - 1 + i-1, spawnmisto2] = Color.Black;
                                                misto[spawnmisto - 1 + i-1, spawnmisto2 + 1] = Color.Black;
                                                misto[spawnmisto + i-1, spawnmisto2 - 1] = Color.Black;
                                            }
                                            

                                            misto[spawnmisto + i, spawnmisto2] = randomColor;
                                            misto[spawnmisto - 1 + i, spawnmisto2] = randomColor;
                                            misto[spawnmisto - 1 + i, spawnmisto2 + 1] = randomColor;
                                            misto[spawnmisto + i, spawnmisto2 - 1] = randomColor;
                                        }
                                        else
                                        {
                                            padani = false;
                                        }
                                        break;
                                    case 1:
                                        if (misto[spawnmisto + 1 + vyska, spawnmisto2] == Color.Black && misto[spawnmisto + vyska, spawnmisto2 - 1] == Color.Black)
                                        {
                                            misto[spawnmisto + vyska - 2, spawnmisto2 - 1] = Color.Black;
                                            misto[spawnmisto + vyska-1, spawnmisto2 - 1] = Color.Black;
                                            misto[spawnmisto + vyska-1, spawnmisto2] = Color.Black;
                                            misto[spawnmisto + vyska, spawnmisto2] = Color.Black;

                                            misto[spawnmisto + vyska-1, spawnmisto2-1] = randomColor;
                                            misto[spawnmisto + vyska, spawnmisto2-1] = randomColor;
                                            misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                            misto[spawnmisto + 1 + vyska, spawnmisto2] = randomColor;
                                        }
                                        else
                                        {
                                            padani = false;
                                        }
                                        break;
                                }

                                zobrazeni();
                                wait(cas);
                                break;
                            case 6:
                        //tvar 6
                                switch (otoceni)
                                {
                                    case 0:
                                        if (misto[spawnmisto + i, spawnmisto2] == Color.Black && misto[spawnmisto + i, spawnmisto2 + 1] == Color.Black && misto[spawnmisto - 1 + i, spawnmisto2 - 1] == Color.Black)
                                        {

                                            if (vyska != 1)
                                            {
                                                misto[spawnmisto + i - 1, spawnmisto2] = Color.Black;
                                                misto[spawnmisto - 1 + i - 1, spawnmisto2] = Color.Black;
                                                misto[spawnmisto - 1 + i - 1, spawnmisto2 - 1] = Color.Black;
                                                misto[spawnmisto + i - 1, spawnmisto2 + 1] = Color.Black;
                                            }


                                            misto[spawnmisto + i, spawnmisto2] = randomColor;
                                            misto[spawnmisto - 1 + i, spawnmisto2] = randomColor;
                                            misto[spawnmisto - 1 + i, spawnmisto2 - 1] = randomColor;
                                            misto[spawnmisto + i, spawnmisto2 + 1] = randomColor;
                                        }
                                        else
                                        {
                                            padani = false;
                                        }
                                        break;
                                    case 1:
                                        if (misto[spawnmisto + 1 + vyska, spawnmisto2] == Color.Black && misto[spawnmisto + vyska, spawnmisto2 + 1] == Color.Black)
                                        {
                                            misto[spawnmisto + vyska - 2, spawnmisto2 + 1] = Color.Black;
                                            misto[spawnmisto + vyska - 1, spawnmisto2 + 1] = Color.Black;
                                            misto[spawnmisto + vyska - 1, spawnmisto2] = Color.Black;
                                            misto[spawnmisto + vyska, spawnmisto2] = Color.Black;

                                            misto[spawnmisto + vyska - 1, spawnmisto2 + 1] = randomColor;
                                            misto[spawnmisto + vyska, spawnmisto2 + 1] = randomColor;
                                            misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                            misto[spawnmisto + 1 + vyska, spawnmisto2] = randomColor;
                                        }
                                        else
                                        {
                                            padani = false;
                                        }
                                        break;
                                }

                                zobrazeni();
                                wait(cas);
                                break;
                        }
                    }
                    catch
                    {
                        padani = false;
                        
                    }
                }
            }

            start.Enabled = true;

        }


        private void otocit()
        {
            switch(AktTvar)
            {
                case 0:
                    switch(otoceni)
                    {
                        case 0:
                            try
                            {
                                if (misto[spawnmisto + vyska, spawnmisto2 + 1] == Color.Black && misto[spawnmisto + vyska, spawnmisto2 + 2] == Color.Black && misto[spawnmisto - 1 + vyska, spawnmisto2 + 2] == Color.Black)
                                {
                                    misto[spawnmisto + 1 + (vyska - 1), spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + 2 + (vyska - 1)), spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + 3 + (vyska - 1)), spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + 3 + (vyska - 1)), spawnmisto2 + 1] = Color.Black;

                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2+1] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2+2] = randomColor;
                                    misto[spawnmisto - 1 + vyska, spawnmisto2+2] = randomColor;
                                    otoceni = 1;

                                    zobrazeni();
                                }
                            }
                            catch (IndexOutOfRangeException)
                            {
                                label201.Text = "out of index - 0";
                            }
                            break;
                        case 1:
                            try
                            {
                                if(misto[spawnmisto + vyska - 1, spawnmisto2] == Color.Black && misto[spawnmisto + vyska - 2, spawnmisto2] == Color.Black && misto[spawnmisto + vyska - 2, spawnmisto2 - 1] == Color.Black)
                                {
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2 + 1] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2 + 2] = Color.Black;
                                    misto[spawnmisto - 1 + vyska, spawnmisto2 + 2] = Color.Black;

                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto + vyska - 1, spawnmisto2] = randomColor;
                                    misto[spawnmisto + vyska - 2, spawnmisto2] = randomColor;
                                    misto[spawnmisto + vyska - 2, spawnmisto2 - 1] = randomColor;

                                    otoceni = 2;
                                    zobrazeni();
                                }
                            }
                            catch (IndexOutOfRangeException)
                            {
                                label201.Text = "out of index - 1";
                            }
                            break;
                        case 2:
                            try
                            {
                                if(misto[spawnmisto + vyska, spawnmisto2 - 1] == Color.Black && misto[spawnmisto + vyska, spawnmisto2 - 2] == Color.Black && misto[spawnmisto + 1 + vyska, spawnmisto2 - 2] == Color.Black)
                                {
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + vyska - 1, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + vyska - 2, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + vyska - 2, spawnmisto2 - 1] = Color.Black;

                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2 - 1] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2 - 2] = randomColor;
                                    misto[spawnmisto + 1 + vyska, spawnmisto2 - 2] = randomColor;
                                    otoceni = 3;
                                    zobrazeni();
                                }
                            }
                            catch(IndexOutOfRangeException)
                            {
                                label201.Text = "out of index - 2";
                            }
                            
                            break;
                        case 3:
                            try
                            {
                                if (misto[(spawnmisto + 3 + (vyska - 1)), spawnmisto2 + 1] == Color.Black && misto[(spawnmisto + 2 + (vyska - 1)), spawnmisto2] == Color.Black && misto[(spawnmisto + 3 + (vyska - 1)), spawnmisto2] == Color.Black)
                                {
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2 - 1] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2 - 2] = Color.Black;
                                    misto[spawnmisto + 1 + vyska, spawnmisto2 - 2] = Color.Black;

                                    misto[spawnmisto + 1 + (vyska - 1), spawnmisto2] = randomColor;
                                    misto[(spawnmisto + 2 + (vyska - 1)), spawnmisto2] = randomColor;
                                    misto[(spawnmisto + 3 + (vyska - 1)), spawnmisto2] = randomColor;
                                    misto[(spawnmisto + 3 + (vyska - 1)), spawnmisto2 + 1] = randomColor;

                                    otoceni = 0;
                                    zobrazeni();
                                }
                            }
                            catch(IndexOutOfRangeException)
                            {
                                label201.Text = "out of index - 3";
                            }

                            
                            break;
                    }
                    break;
                case 1:
                    switch (otoceni)
                    {
                        case 0:

                            try
                            {
                                if (misto[(spawnmisto + vyska), spawnmisto2 + 1] == Color.Black && misto[(spawnmisto - 1 + vyska), spawnmisto2 + 1] == Color.Black)
                                {
                                    misto[spawnmisto + (vyska), spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + 1 + (vyska)), spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + 1 + (vyska )), spawnmisto2 - 1] = Color.Black;
                                    misto[(spawnmisto + 1 + (vyska)), spawnmisto2 + 1] = Color.Black;
                                    
                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[(spawnmisto + vyska), spawnmisto2+1] = randomColor;
                                    misto[(spawnmisto + 1 + vyska), spawnmisto2 + 1] = randomColor;
                                    misto[(spawnmisto - 1 + vyska), spawnmisto2 + 1] = randomColor;

                                    otoceni = 1;
                                    zobrazeni();
                                }
                            }
                            catch (IndexOutOfRangeException)
                            {
                                label201.Text = "out of index - 0";
                            }
                            break;
                        case 1:
                            try
                            {
                                if (misto[(spawnmisto + vyska - 1), spawnmisto2] == Color.Black && misto[(spawnmisto + vyska - 1), spawnmisto2-1] == Color.Black)//&& misto[(spawnmisto + vyska - 1), spawnmisto2] == Color.Black)
                                {
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + vyska), spawnmisto2 + 1] = Color.Black;
                                    misto[(spawnmisto + 1 + vyska), spawnmisto2 + 1] = Color.Black;
                                    misto[(spawnmisto - 1 + vyska), spawnmisto2 + 1] = Color.Black;

                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[(spawnmisto + vyska - 1), spawnmisto2] = randomColor;
                                    misto[(spawnmisto - 1 + vyska), spawnmisto2 + 1] = randomColor;
                                    misto[(spawnmisto - 1 + vyska), spawnmisto2 - 1] = randomColor;

                                    otoceni = 2;
                                    zobrazeni();
                                }
                            }
                            catch (IndexOutOfRangeException)
                            {
                                label201.Text = "out of index - 0";
                            }
                            break;
                        case 2:
                            try
                            {
                                if (misto[(spawnmisto + vyska), spawnmisto2 - 1] == Color.Black && misto[(spawnmisto + 1 + vyska), spawnmisto2 - 1] == Color.Black)
                                {
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + vyska - 1), spawnmisto2] = Color.Black;
                                    misto[(spawnmisto - 1 + vyska), spawnmisto2 + 1] = Color.Black;
                                    misto[(spawnmisto - 1 + vyska), spawnmisto2 - 1] = Color.Black;

                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[(spawnmisto + vyska), spawnmisto2-1] = randomColor;
                                    misto[(spawnmisto - 1 + vyska), spawnmisto2 - 1] = randomColor;
                                    misto[(spawnmisto + 1 + vyska), spawnmisto2 - 1] = randomColor;

                                    otoceni = 3;
                                    zobrazeni();
                                }
                            }
                            catch (IndexOutOfRangeException)
                            {
                                label201.Text = "out of index - 0";
                            }
                            break;
                        case 3:
                            try
                            {
                                if ( misto[spawnmisto + vyska+1, spawnmisto2] == Color.Black && misto[spawnmisto + vyska + 1, spawnmisto2+1] == Color.Black)
                                {
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + vyska), spawnmisto2 - 1] = Color.Black;
                                    misto[(spawnmisto - 1 + vyska), spawnmisto2 - 1] = Color.Black;
                                    misto[(spawnmisto + 1 + vyska), spawnmisto2 - 1] = Color.Black;

                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[(spawnmisto + 1 + vyska), spawnmisto2] = randomColor;
                                    misto[(spawnmisto + 1 + vyska), spawnmisto2 - 1] = randomColor;
                                    misto[(spawnmisto + 1 + vyska), spawnmisto2 + 1] = randomColor;

                                    otoceni = 0;
                                    zobrazeni();
                                }
                            }
                            catch (IndexOutOfRangeException)
                            {
                                label201.Text = "out of index - 0";
                            }
                            break;
                    }
                    break;
                case 2:
                    switch (otoceni)
                    {
                        case 0:
                            if (misto[spawnmisto + vyska, spawnmisto2 - 1] == Color.Black && misto[spawnmisto + vyska, spawnmisto2 + 1] == Color.Black && misto[spawnmisto + vyska, spawnmisto2 + 2] == Color.Black)
                            {
                                misto[spawnmisto + 1 + (vyska - 1), spawnmisto2] = Color.Black;
                                misto[(spawnmisto + 2 + (vyska - 1)), spawnmisto2] = Color.Black;
                                misto[(spawnmisto + 3 + (vyska - 1)), spawnmisto2] = Color.Black;
                                misto[(spawnmisto + 4 + (vyska - 1)), spawnmisto2] = Color.Black;

                                misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                misto[(spawnmisto + vyska), spawnmisto2-1] = randomColor;
                                misto[(spawnmisto + vyska), spawnmisto2+1] = randomColor;
                                misto[(spawnmisto + vyska), spawnmisto2+2] = randomColor;
                                zobrazeni();
                                otoceni = 1;
                            }
                            break;
                        case 1:
                            if (misto[spawnmisto + vyska+1, spawnmisto2] == Color.Black && misto[spawnmisto + vyska+2, spawnmisto2] == Color.Black && misto[spawnmisto + vyska+3, spawnmisto2] == Color.Black)
                            {
                                misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                misto[(spawnmisto + vyska), spawnmisto2 - 1] = Color.Black;
                                misto[(spawnmisto + vyska), spawnmisto2 + 1] = Color.Black;
                                misto[(spawnmisto + vyska), spawnmisto2 + 2] = Color.Black;

                                misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                misto[(spawnmisto + 1 + vyska), spawnmisto2] = randomColor;
                                misto[(spawnmisto + 2 + vyska), spawnmisto2] = randomColor;
                                misto[(spawnmisto + 3 + vyska), spawnmisto2] = randomColor;

                                otoceni = 0;
                                zobrazeni();
                            }
                            break;
                    }
                    break;
                case 4:
                    switch (otoceni)
                    {
                        case 0:
                            try
                            {
                                if (misto[spawnmisto + vyska, spawnmisto2 + 1] == Color.Black && misto[spawnmisto + vyska, spawnmisto2 + 2] == Color.Black && misto[spawnmisto + 1 + vyska, spawnmisto2 + 2] == Color.Black)
                                {
                                    misto[spawnmisto + 1 + (vyska - 1), spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + 2 + (vyska - 1)), spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + 3 + (vyska - 1)), spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + 3 + (vyska - 1)), spawnmisto2 - 1] = Color.Black;

                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2 + 1] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2 + 2] = randomColor;
                                    misto[spawnmisto + 1 + vyska, spawnmisto2 + 2] = randomColor;
                                    otoceni = 1;

                                    zobrazeni();
                                }
                            }
                            catch (IndexOutOfRangeException)
                            {
                                label201.Text = "out of index - 0";
                            }
                            break;
                        case 1:
                            try
                            {
                                if (misto[spawnmisto + vyska - 1, spawnmisto2] == Color.Black && misto[spawnmisto + vyska - 2, spawnmisto2] == Color.Black && misto[spawnmisto + vyska - 2, spawnmisto2 + 1] == Color.Black)
                                {
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2 + 1] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2 + 2] = Color.Black;
                                    misto[spawnmisto + 1 + vyska, spawnmisto2 + 2] = Color.Black;
                                    
                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto + vyska - 1, spawnmisto2] = randomColor;
                                    misto[spawnmisto + vyska - 2, spawnmisto2] = randomColor;
                                    misto[spawnmisto + vyska - 2, spawnmisto2 + 1] = randomColor;

                                    otoceni = 2;
                                    zobrazeni();
                                }
                            }
                            catch (IndexOutOfRangeException)
                            {
                                label201.Text = "out of index - 1";
                            }
                            break;
                        case 2:
                            try
                            {
                                if (misto[spawnmisto + vyska, spawnmisto2 - 1] == Color.Black && misto[spawnmisto + vyska, spawnmisto2 - 2] == Color.Black && misto[spawnmisto - 1 + vyska, spawnmisto2 - 2] == Color.Black)
                                {
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + vyska - 1, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + vyska - 2, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + vyska - 2, spawnmisto2 + 1] = Color.Black;

                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2 - 1] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2 - 2] = randomColor;
                                    misto[spawnmisto - 1 + vyska, spawnmisto2 - 2] = randomColor;
                                    otoceni = 3;
                                    zobrazeni();
                                }
                            }
                            catch (IndexOutOfRangeException)
                            {
                                label201.Text = "out of index - 2";
                            }

                            break;
                        case 3:
                            try
                            {
                                if (misto[(spawnmisto + 3 + (vyska - 1)), spawnmisto2 - 1] == Color.Black && misto[(spawnmisto + 2 + (vyska - 1)), spawnmisto2] == Color.Black && misto[(spawnmisto + 3 + (vyska - 1)), spawnmisto2] == Color.Black)
                                {
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2 - 1] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2 - 2] = Color.Black;
                                    misto[spawnmisto - 1 + vyska, spawnmisto2 - 2] = Color.Black;

                                    misto[spawnmisto + 1 + (vyska - 1), spawnmisto2] = randomColor;
                                    misto[(spawnmisto + 2 + (vyska - 1)), spawnmisto2] = randomColor;
                                    misto[(spawnmisto + 3 + (vyska - 1)), spawnmisto2] = randomColor;
                                    misto[(spawnmisto + 3 + (vyska - 1)), spawnmisto2 - 1] = randomColor;

                                    otoceni = 0;
                                    zobrazeni();
                                }
                            }
                            catch (IndexOutOfRangeException)
                            {
                                label201.Text = "out of index - 3";
                            }


                            break;
                    }
                    break;
                case 5:
                    switch (otoceni)
                    {
                        case 0:
                            try
                            {
                                if (misto[spawnmisto + vyska - 1, spawnmisto2 - 1] == Color.Black && misto[spawnmisto + vyska + 1, spawnmisto2] == Color.Black)
                                {
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto - 1 + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto - 1 + vyska, spawnmisto2 + 1] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2 - 1] = Color.Black;

                                    misto[spawnmisto + vyska - 1, spawnmisto2 - 1] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2 - 1] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto + 1 + vyska, spawnmisto2] = randomColor;

                                    zobrazeni();
                                    otoceni = 1;
                                }
                            }
                            catch (IndexOutOfRangeException)
                            {
                                label201.Text = "out of index - 3";
                            }
                            break;
                        case 1:
                            try
                            {
                                if (misto[spawnmisto + vyska+1, spawnmisto2 - 1] == Color.Black && misto[spawnmisto + vyska, spawnmisto2 + 1] == Color.Black)
                                {
                                    misto[spawnmisto + vyska - 1, spawnmisto2 - 1] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2 - 1] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + 1 + vyska, spawnmisto2] = Color.Black;

                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto - 1 + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto - 1 + vyska, spawnmisto2 + 1] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2 - 1] = randomColor;

                                    zobrazeni();
                                    otoceni = 0;
                                }
                            }
                            catch (IndexOutOfRangeException)
                            {
                                label201.Text = "out of index - 3";
                            }
                            break;
                    }
                    break;
                case 6:
                    switch (otoceni)
                    {
                        case 0:
                            try
                            {
                                if (misto[spawnmisto + vyska - 1, spawnmisto2 + 1] == Color.Black && misto[spawnmisto + vyska + 1, spawnmisto2] == Color.Black)
                                {
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto - 1 + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto - 1 + vyska, spawnmisto2 - 1] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2 + 1] = Color.Black;

                                    misto[spawnmisto + vyska - 1, spawnmisto2 + 1] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2 + 1] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto + 1 + vyska, spawnmisto2] = randomColor;

                                    zobrazeni();
                                    otoceni = 1;
                                }
                            }
                            catch (IndexOutOfRangeException)
                            {
                                label201.Text = "out of index - 3";
                            }
                            break;
                        case 1:
                            try
                            {
                                if (misto[spawnmisto + vyska + 1, spawnmisto2 + 1] == Color.Black && misto[spawnmisto + vyska, spawnmisto2 - 1] == Color.Black)
                                {
                                    misto[spawnmisto + vyska - 1, spawnmisto2 + 1] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2 + 1] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + 1 + vyska, spawnmisto2] = Color.Black;

                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto - 1 + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto - 1 + vyska, spawnmisto2 - 1] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2 + 1] = randomColor;

                                    zobrazeni();
                                    otoceni = 0;
                                }
                            }
                            catch (IndexOutOfRangeException)
                            {
                                label201.Text = "out of index - 3";
                            }
                            break;
                    }
                    break;
            }
        }

        private void Doleva()
        {
            if (spusteno)
            {
                switch (AktTvar)
                {
                    case 0:
                        switch (otoceni)
                        {
                            case 0:
                                if (misto[spawnmisto + 1 + (vyska - 1), spawnmisto2 - 1] == Color.Black && misto[(spawnmisto + 2 + (vyska - 1)), spawnmisto2 - 1] == Color.Black && misto[(spawnmisto + 3 + (vyska - 1)), spawnmisto2 - 1] == Color.Black)
                                {
                                    misto[spawnmisto + 1 + (vyska - 1), spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + 2 + (vyska - 1)), spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + 3 + (vyska - 1)), spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + 3 + (vyska - 1)), spawnmisto2 + 1] = Color.Black;

                                    spawnmisto2 = spawnmisto2 - 1;

                                    misto[spawnmisto + 1 + (vyska - 1), spawnmisto2] = randomColor;
                                    misto[(spawnmisto + 2 + (vyska - 1)), spawnmisto2] = randomColor;
                                    misto[(spawnmisto + 3 + (vyska - 1)), spawnmisto2] = randomColor;
                                    misto[(spawnmisto + 3 + (vyska - 1)), spawnmisto2 + 1] = randomColor;
                                    zobrazeni();
                                }
                                break;
                            case 1:
                                if (misto[spawnmisto + vyska, spawnmisto2 - 1] == Color.Black && misto[spawnmisto - 1 + vyska, spawnmisto2 + 1] == Color.Black)
                                {
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2 + 1] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2 + 2] = Color.Black;
                                    misto[spawnmisto - 1 + vyska, spawnmisto2 + 2] = Color.Black;

                                    spawnmisto2 = spawnmisto2 - 1;

                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2 + 1] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2 + 2] = randomColor;
                                    misto[spawnmisto - 1 + vyska, spawnmisto2 + 2] = randomColor;
                                    zobrazeni();
                                }
                                break;
                            case 2:
                                if (misto[spawnmisto + vyska - 2, spawnmisto2 - 2] == Color.Black && misto[spawnmisto + vyska - 1, spawnmisto2 - 1] == Color.Black && misto[spawnmisto + vyska, spawnmisto2 - 1] == Color.Black)
                                {
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + vyska - 1, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + vyska - 2, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + vyska - 2, spawnmisto2 - 1] = Color.Black;

                                    spawnmisto2 = spawnmisto2 - 1;

                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto + vyska - 1, spawnmisto2] = randomColor;
                                    misto[spawnmisto + vyska - 2, spawnmisto2] = randomColor;
                                    misto[spawnmisto + vyska - 2, spawnmisto2 - 1] = randomColor;
                                    zobrazeni();
                                }
                                break;
                            case 3:
                                if (misto[spawnmisto + 1 + vyska, spawnmisto2 - 3] == Color.Black && misto[spawnmisto + vyska, spawnmisto2 - 3] == Color.Black)
                                {
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2 - 1] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2 - 2] = Color.Black;
                                    misto[spawnmisto + 1 + vyska, spawnmisto2 - 2] = Color.Black;

                                    spawnmisto2 = spawnmisto2 - 1;

                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2 - 1] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2 - 2] = randomColor;
                                    misto[spawnmisto + 1 + vyska, spawnmisto2 - 2] = randomColor;
                                    zobrazeni();
                                }
                                break;
                        }

                        break;
                    case 1:
                        switch (otoceni)
                        {
                            case 0:
                                if (misto[spawnmisto + 1 + (vyska - 1), spawnmisto2 - 1] == Color.Black && misto[(spawnmisto + 2 + (vyska - 1)), spawnmisto2 - 2] == Color.Black)
                                {
                                    misto[spawnmisto + 1 + (vyska - 1), spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + 2 + (vyska - 1)), spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + 2 + (vyska - 1)), spawnmisto2 - 1] = Color.Black;
                                    misto[(spawnmisto + 2 + (vyska - 1)), spawnmisto2 + 1] = Color.Black;

                                    spawnmisto2 = spawnmisto2 - 1;

                                    misto[spawnmisto + 1 + (vyska - 1), spawnmisto2] = randomColor;
                                    misto[(spawnmisto + 2 + (vyska - 1)), spawnmisto2] = randomColor;
                                    misto[(spawnmisto + 2 + (vyska - 1)), spawnmisto2 - 1] = randomColor;
                                    misto[(spawnmisto + 2 + (vyska - 1)), spawnmisto2 + 1] = randomColor;
                                    zobrazeni();
                                }
                                break;
                            case 1:
                                if (misto[spawnmisto + vyska, spawnmisto2 - 1] == Color.Black && misto[(spawnmisto + 1 + vyska), spawnmisto2] == Color.Black && misto[(spawnmisto - 1 + vyska), spawnmisto2] == Color.Black)
                                {
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + vyska), spawnmisto2 + 1] = Color.Black;
                                    misto[(spawnmisto + 1 + vyska), spawnmisto2 + 1] = Color.Black;
                                    misto[(spawnmisto - 1 + vyska), spawnmisto2 + 1] = Color.Black;

                                    spawnmisto2 = spawnmisto2 - 1;

                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[(spawnmisto + vyska), spawnmisto2 + 1] = randomColor;
                                    misto[(spawnmisto + 1 + vyska), spawnmisto2 + 1] = randomColor;
                                    misto[(spawnmisto - 1 + vyska), spawnmisto2 + 1] = randomColor;
                                    zobrazeni();
                                }
                                break;
                            case 2:
                                if (misto[spawnmisto + vyska, spawnmisto2 - 1] == Color.Black && misto[(spawnmisto - 1 + vyska), spawnmisto2 - 2] == Color.Black)
                                {
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + vyska - 1), spawnmisto2] = Color.Black;
                                    misto[(spawnmisto - 1 + vyska), spawnmisto2 + 1] = Color.Black;
                                    misto[(spawnmisto - 1 + vyska), spawnmisto2 - 1] = Color.Black;

                                    spawnmisto2 = spawnmisto2 - 1;

                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[(spawnmisto + vyska - 1), spawnmisto2] = randomColor;
                                    misto[(spawnmisto - 1 + vyska), spawnmisto2 + 1] = randomColor;
                                    misto[(spawnmisto - 1 + vyska), spawnmisto2 - 1] = randomColor;
                                    zobrazeni();
                                }
                                break;
                            case 3:
                                if (misto[spawnmisto + vyska, spawnmisto2 - 2] == Color.Black && misto[spawnmisto + vyska - 1, spawnmisto2 - 2] == Color.Black && misto[spawnmisto + vyska + 1, spawnmisto2 - 2] == Color.Black)
                                {
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + vyska), spawnmisto2 - 1] = Color.Black;
                                    misto[(spawnmisto - 1 + vyska), spawnmisto2 - 1] = Color.Black;
                                    misto[(spawnmisto + 1 + vyska), spawnmisto2 - 1] = Color.Black;

                                    spawnmisto2 = spawnmisto2 - 1;

                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[(spawnmisto + vyska), spawnmisto2 - 1] = randomColor;
                                    misto[(spawnmisto - 1 + vyska), spawnmisto2 - 1] = randomColor;
                                    misto[(spawnmisto + 1 + vyska), spawnmisto2 - 1] = randomColor;
                                    zobrazeni();
                                }
                                break;
                        }
                        break;
                    case 2:
                        switch (otoceni)
                        {
                            case 0:
                                if (misto[spawnmisto + 1 + (vyska - 1), spawnmisto2 - 1] == Color.Black && misto[(spawnmisto + 2 + (vyska - 1)), spawnmisto2 - 1] == Color.Black && misto[(spawnmisto + 3 + (vyska - 1)), spawnmisto2 - 1] == Color.Black && misto[spawnmisto + 4 + (vyska - 1), spawnmisto2 - 1] == Color.Black)
                                {
                                    misto[spawnmisto + 1 + (vyska - 1), spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + 2 + (vyska - 1)), spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + 3 + (vyska - 1)), spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + 4 + (vyska - 1)), spawnmisto2] = Color.Black;

                                    spawnmisto2 = spawnmisto2 - 1;

                                    misto[spawnmisto + 1 + (vyska - 1), spawnmisto2] = randomColor;
                                    misto[(spawnmisto + 2 + (vyska - 1)), spawnmisto2] = randomColor;
                                    misto[(spawnmisto + 3 + (vyska - 1)), spawnmisto2] = randomColor;
                                    misto[(spawnmisto + 4 + (vyska - 1)), spawnmisto2] = randomColor;
                                    zobrazeni();
                                }
                                break;
                            case 1:
                                if (misto[(spawnmisto + vyska), spawnmisto2 - 2] == Color.Black)
                                {
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + vyska), spawnmisto2 - 1] = Color.Black;
                                    misto[(spawnmisto + vyska), spawnmisto2 + 1] = Color.Black;
                                    misto[(spawnmisto + vyska), spawnmisto2 + 2] = Color.Black;

                                    spawnmisto2 = spawnmisto2 - 1;

                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[(spawnmisto + vyska), spawnmisto2 - 1] = randomColor;
                                    misto[(spawnmisto + vyska), spawnmisto2 + 1] = randomColor;
                                    misto[(spawnmisto + vyska), spawnmisto2 + 2] = randomColor;
                                    zobrazeni();
                                }
                                break;
                        }
                        break;
                    case 3:
                        if (misto[spawnmisto + vyska, spawnmisto2 - 1] == Color.Black && misto[spawnmisto + 1 + vyska, spawnmisto2 - 1] == Color.Black)
                        {
                            misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                            misto[spawnmisto + vyska, spawnmisto2 + 1] = Color.Black;
                            misto[spawnmisto + 1 + vyska, spawnmisto2] = Color.Black;
                            misto[spawnmisto + 1 + vyska, spawnmisto2 + 1] = Color.Black;

                            spawnmisto2 = spawnmisto2 - 1;

                            misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                            misto[spawnmisto + vyska, spawnmisto2 + 1] = randomColor;
                            misto[spawnmisto + 1 + vyska, spawnmisto2] = randomColor;
                            misto[spawnmisto + 1 + vyska, spawnmisto2 + 1] = randomColor;
                            zobrazeni();
                        }
                        break;
                    case 4:
                        switch (otoceni)
                        {
                            case 0:
                                if (misto[spawnmisto + 1 + (vyska - 1), spawnmisto2 - 1] == Color.Black && misto[(spawnmisto + 2 + (vyska - 1)), spawnmisto2 - 1] == Color.Black && misto[(spawnmisto + 3 + (vyska - 1)), spawnmisto2 - 2] == Color.Black)
                                {
                                    misto[spawnmisto + 1 + (vyska - 1), spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + 2 + (vyska - 1)), spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + 3 + (vyska - 1)), spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + 3 + (vyska - 1)), spawnmisto2 - 1] = Color.Black;

                                    spawnmisto2 = spawnmisto2 - 1;

                                    misto[spawnmisto + 1 + (vyska - 1), spawnmisto2] = randomColor;
                                    misto[(spawnmisto + 2 + (vyska - 1)), spawnmisto2] = randomColor;
                                    misto[(spawnmisto + 3 + (vyska - 1)), spawnmisto2] = randomColor;
                                    misto[(spawnmisto + 3 + (vyska - 1)), spawnmisto2 - 1] = randomColor;
                                    zobrazeni();
                                }
                                break;
                            case 1:
                                if (misto[spawnmisto + vyska, spawnmisto2 - 1] == Color.Black && misto[spawnmisto + vyska + 1, spawnmisto2 + 1] == Color.Black)
                                {
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2 + 1] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2 + 2] = Color.Black;
                                    misto[spawnmisto + 1 + vyska, spawnmisto2 + 2] = Color.Black;

                                    spawnmisto2 = spawnmisto2 - 1;

                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2 + 1] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2 + 2] = randomColor;
                                    misto[spawnmisto + 1 + vyska, spawnmisto2 + 2] = randomColor;
                                    zobrazeni();
                                }
                                break;
                            case 2:
                                if (misto[spawnmisto + vyska, spawnmisto2 - 1] == Color.Black && misto[spawnmisto + vyska - 1, spawnmisto2 - 1] == Color.Black && misto[spawnmisto + vyska - 2, spawnmisto2 - 1] == Color.Black)
                                {
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + vyska - 1, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + vyska - 2, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + vyska - 2, spawnmisto2 + 1] = Color.Black;

                                    spawnmisto2 = spawnmisto2 - 1;

                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto + vyska - 1, spawnmisto2] = randomColor;
                                    misto[spawnmisto + vyska - 2, spawnmisto2] = randomColor;
                                    misto[spawnmisto + vyska - 2, spawnmisto2 + 1] = randomColor;
                                    zobrazeni();
                                }
                                break;
                            case 3:
                                if (misto[spawnmisto + vyska, spawnmisto2 - 3] == Color.Black && misto[spawnmisto - 1 + vyska, spawnmisto2 - 3] == Color.Black)
                                {
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2 - 1] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2 - 2] = Color.Black;
                                    misto[spawnmisto - 1 + vyska, spawnmisto2 - 2] = Color.Black;

                                    spawnmisto2 = spawnmisto2 - 1;

                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2 - 1] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2 - 2] = randomColor;
                                    misto[spawnmisto - 1 + vyska, spawnmisto2 - 2] = randomColor;
                                    zobrazeni();
                                }
                                break;
                        }
                        break;
                    case 5:
                        switch (otoceni)
                        {
                            case 0:
                                if (misto[spawnmisto - 1 + vyska, spawnmisto2-1] == Color.Black && misto[spawnmisto + vyska, spawnmisto2 - 2] == Color.Black)
                                {
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto - 1 + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto - 1 + vyska, spawnmisto2 + 1] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2 - 1] = Color.Black;

                                    spawnmisto2 = spawnmisto2 - 1;

                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto - 1 + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto - 1 + vyska, spawnmisto2 + 1] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2 - 1] = randomColor;
                                    zobrazeni();
                                }
                                break;
                            case 1:
                                if (misto[spawnmisto + vyska - 1, spawnmisto2 - 2] == Color.Black && misto[spawnmisto + vyska, spawnmisto2 - 2] == Color.Black && misto[spawnmisto + 1 + vyska, spawnmisto2-1] == Color.Black)
                                {
                                    misto[spawnmisto + vyska - 1, spawnmisto2 - 1] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2 - 1] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + 1 + vyska, spawnmisto2] = Color.Black;

                                    spawnmisto2 = spawnmisto2 - 1;

                                    misto[spawnmisto + vyska - 1, spawnmisto2 - 1] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2 - 1] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto + 1 + vyska, spawnmisto2] = randomColor;
                                    zobrazeni();
                                }
                                break;
                        }
                        break;
                    case 6:
                        switch (otoceni)
                        {
                            case 0:
                                if (misto[spawnmisto - 1 + vyska, spawnmisto2 - 2] == Color.Black && misto[spawnmisto + vyska, spawnmisto2 - 1] == Color.Black)
                                {
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto - 1 + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto - 1 + vyska, spawnmisto2 - 1] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2 + 1] = Color.Black;

                                    spawnmisto2 = spawnmisto2 - 1;

                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto - 1 + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto - 1 + vyska, spawnmisto2 - 1] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2 + 1] = randomColor;
                                    zobrazeni();
                                }
                                break;
                            case 1:
                                if (misto[spawnmisto + vyska - 1, spawnmisto2] == Color.Black && misto[spawnmisto + vyska, spawnmisto2 - 1] == Color.Black && misto[spawnmisto + 1 + vyska, spawnmisto2 - 1] == Color.Black)
                                {
                                    misto[spawnmisto + vyska - 1, spawnmisto2 + 1] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2 + 1] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + 1 + vyska, spawnmisto2] = Color.Black;

                                    spawnmisto2 = spawnmisto2 - 1;

                                    misto[spawnmisto + vyska - 1, spawnmisto2 + 1] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2 + 1] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto + 1 + vyska, spawnmisto2] = randomColor;
                                    zobrazeni();
                                }
                                break;
                        }
                        break;
                }
            }
        }
        private void Doprava()
        {
            if(spusteno)
            {
                switch (AktTvar)
                {
                    case 0:
                        switch(otoceni)
                        {
                            case 0:
                                if (misto[spawnmisto + 1 + (vyska - 1), spawnmisto2 + 1] == Color.Black && misto[(spawnmisto + 2 + (vyska - 1)), spawnmisto2+1] == Color.Black && misto[(spawnmisto + 3 + (vyska - 1)), spawnmisto2 + 2] == Color.Black)
                                { 
                                    misto[spawnmisto + 1 + (vyska - 1), spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + 2 + (vyska - 1)), spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + 3 + (vyska - 1)), spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + 3 + (vyska - 1)), spawnmisto2 + 1] = Color.Black;

                                    spawnmisto2 = spawnmisto2 + 1;

                                    misto[spawnmisto + 1 + (vyska - 1), spawnmisto2] = randomColor;
                                    misto[(spawnmisto + 2 + (vyska - 1)), spawnmisto2] = randomColor;
                                    misto[(spawnmisto + 3 + (vyska - 1)), spawnmisto2] = randomColor;
                                    misto[(spawnmisto + 3 + (vyska - 1)), spawnmisto2 + 1] = randomColor;
                                    zobrazeni();   
                                }
                                break;
                            case 1:
                                if (misto[spawnmisto + vyska, spawnmisto2+3] == Color.Black && misto[spawnmisto + vyska - 1, spawnmisto2 + 3] == Color.Black)
                                {
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2 + 1] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2 + 2] = Color.Black;
                                    misto[spawnmisto - 1 + vyska, spawnmisto2 + 2] = Color.Black;

                                    spawnmisto2 = spawnmisto2 + 1;

                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2 + 1] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2 + 2] = randomColor;
                                    misto[spawnmisto - 1 + vyska, spawnmisto2 + 2] = randomColor;
                                    zobrazeni();
                                }
                                break;
                            case 2:
                                if (misto[spawnmisto + vyska, spawnmisto2 + 1] == Color.Black && misto[spawnmisto + vyska - 1, spawnmisto2 + 1] == Color.Black && misto[spawnmisto + vyska - 2, spawnmisto2 + 1] == Color.Black)
                                {
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + vyska - 1, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + vyska - 2, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + vyska - 2, spawnmisto2 - 1] = Color.Black;

                                    spawnmisto2 = spawnmisto2 + 1;

                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto + vyska - 1, spawnmisto2] = randomColor;
                                    misto[spawnmisto + vyska - 2, spawnmisto2] = randomColor;
                                    misto[spawnmisto + vyska - 2, spawnmisto2 - 1] = randomColor;
                                zobrazeni();
                                }
                                break;
                            case 3:
                                if ( misto[spawnmisto + vyska, spawnmisto2+1] == Color.Black && misto[spawnmisto + 1 + vyska, spawnmisto2 - 1] == Color.Black)
                                {
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2 - 1] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2 - 2] = Color.Black;
                                    misto[spawnmisto + 1 + vyska, spawnmisto2 - 2] = Color.Black;

                                    spawnmisto2 = spawnmisto2 + 1;

                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2 - 1] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2 - 2] = randomColor;
                                    misto[spawnmisto + 1 + vyska, spawnmisto2 - 2] = randomColor;
                                    zobrazeni();
                                }
                                break;
                        }
                        break;
                    case 1:
                    //tvar 1
                        switch (otoceni)
                        {
                            case 0:
                                if (misto[spawnmisto + vyska, spawnmisto2 + 1] == Color.Black && misto[(spawnmisto + 2 + (vyska - 1)), spawnmisto2 + 2] == Color.Black)
                                {
                                    misto[spawnmisto + 1 + (vyska - 1), spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + 2 + (vyska - 1)), spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + 2 + (vyska - 1)), spawnmisto2 - 1] = Color.Black;
                                    misto[(spawnmisto + 2 + (vyska - 1)), spawnmisto2 + 1] = Color.Black;

                                    spawnmisto2 = spawnmisto2 + 1;

                                    misto[spawnmisto + 1 + (vyska - 1), spawnmisto2] = randomColor;
                                    misto[(spawnmisto + 2 + (vyska - 1)), spawnmisto2] = randomColor;
                                    misto[(spawnmisto + 2 + (vyska - 1)), spawnmisto2 - 1] = randomColor;
                                    misto[(spawnmisto + 2 + (vyska - 1)), spawnmisto2 + 1] = randomColor;
                                    zobrazeni();
                                }
                                break;
                            case 1:
                                if (misto[(spawnmisto + vyska), spawnmisto2 + 2] == Color.Black && misto[(spawnmisto + 1 + vyska), spawnmisto2 + 2] == Color.Black && misto[(spawnmisto - 1 + vyska), spawnmisto2 + 2] == Color.Black)
                                {
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + vyska), spawnmisto2 + 1] = Color.Black;
                                    misto[(spawnmisto + 1 + vyska), spawnmisto2 + 1] = Color.Black;
                                    misto[(spawnmisto - 1 + vyska), spawnmisto2 + 1] = Color.Black;

                                    spawnmisto2 = spawnmisto2 + 1;

                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[(spawnmisto + vyska), spawnmisto2 + 1] = randomColor;
                                    misto[(spawnmisto + 1 + vyska), spawnmisto2 + 1] = randomColor;
                                    misto[(spawnmisto - 1 + vyska), spawnmisto2 + 1] = randomColor;
                                    zobrazeni();
                                }
                                break;
                            case 2:
                                if (misto[spawnmisto + vyska, spawnmisto2 + 1] == Color.Black && misto[(spawnmisto - 1 + vyska), spawnmisto2 + 2] == Color.Black)
                                {
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + vyska - 1), spawnmisto2] = Color.Black;
                                    misto[(spawnmisto - 1 + vyska), spawnmisto2 + 1] = Color.Black;
                                    misto[(spawnmisto - 1 + vyska), spawnmisto2 - 1] = Color.Black;

                                    spawnmisto2 = spawnmisto2 + 1;

                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[(spawnmisto + vyska - 1), spawnmisto2] = randomColor;
                                    misto[(spawnmisto - 1 + vyska), spawnmisto2 + 1] = randomColor;
                                    misto[(spawnmisto - 1 + vyska), spawnmisto2 - 1] = randomColor;
                                    zobrazeni();
                                }
                                break;
                            case 3:
                                if (misto[spawnmisto + vyska, spawnmisto2+1] == Color.Black && misto[(spawnmisto - 1 + vyska), spawnmisto2] == Color.Black && misto[(spawnmisto + 1 + vyska), spawnmisto2 ] == Color.Black)
                                {
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + vyska), spawnmisto2 - 1] = Color.Black;
                                    misto[(spawnmisto - 1 + vyska), spawnmisto2 - 1] = Color.Black;
                                    misto[(spawnmisto + 1 + vyska), spawnmisto2 - 1] = Color.Black;

                                    spawnmisto2 = spawnmisto2 + 1;

                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[(spawnmisto + vyska), spawnmisto2 - 1] = randomColor;
                                    misto[(spawnmisto - 1 + vyska), spawnmisto2 - 1] = randomColor;
                                    misto[(spawnmisto + 1 + vyska), spawnmisto2 - 1] = randomColor;
                                    zobrazeni();
                                }
                                break;
                        }
                        break;
                    case 2:
                        switch(otoceni)
                        {
                            case 0:
                                if (misto[spawnmisto + 1 + (vyska - 1), spawnmisto2 + 1] == Color.Black && misto[(spawnmisto + 2 + (vyska - 1)), spawnmisto2+1] == Color.Black && misto[(spawnmisto + 3 + (vyska - 1)), spawnmisto2 + 1] == Color.Black && misto[spawnmisto + 4 + (vyska - 1), spawnmisto2 + 1] == Color.Black)
                                {
                                    misto[spawnmisto + 1 + (vyska - 1), spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + 2 + (vyska - 1)), spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + 3 + (vyska - 1)), spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + 4 + (vyska - 1)), spawnmisto2] = Color.Black;

                                    spawnmisto2 = spawnmisto2 + 1;

                                    misto[spawnmisto + 1 + (vyska - 1), spawnmisto2] = randomColor;
                                    misto[(spawnmisto + 2 + (vyska - 1)), spawnmisto2] = randomColor;
                                    misto[(spawnmisto + 3 + (vyska - 1)), spawnmisto2] = randomColor;
                                    misto[(spawnmisto + 4 + (vyska - 1)), spawnmisto2] = randomColor;
                                    zobrazeni();
                                }
                                break;
                            case 1:
                                if (misto[(spawnmisto + vyska), spawnmisto2 + 3] == Color.Black)
                                {
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + vyska), spawnmisto2 - 1] = Color.Black;
                                    misto[(spawnmisto + vyska), spawnmisto2 + 1] = Color.Black;
                                    misto[(spawnmisto + vyska), spawnmisto2 + 2] = Color.Black;

                                    spawnmisto2 = spawnmisto2 + 1;

                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[(spawnmisto + vyska), spawnmisto2 - 1] = randomColor;
                                    misto[(spawnmisto + vyska), spawnmisto2 + 1] = randomColor;
                                    misto[(spawnmisto + vyska), spawnmisto2 + 2] = randomColor;
                                    zobrazeni();
                                }
                                break;
                        }
                        break;
                    case 3:
                        if(misto[spawnmisto + vyska, spawnmisto2 + 2] == Color.Black && misto[spawnmisto + 1 + vyska, spawnmisto2 + 2] == Color.Black)
                        {
                            misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                            misto[spawnmisto + vyska, spawnmisto2 + 1] = Color.Black;
                            misto[spawnmisto + 1 + vyska, spawnmisto2] = Color.Black;
                            misto[spawnmisto + 1 + vyska, spawnmisto2 + 1] = Color.Black;

                            spawnmisto2 = spawnmisto2 + 1;

                            misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                            misto[spawnmisto + vyska, spawnmisto2 + 1] = randomColor;
                            misto[spawnmisto + 1 + vyska, spawnmisto2] = randomColor;
                            misto[spawnmisto + 1 + vyska, spawnmisto2 + 1] = randomColor;
                            zobrazeni();
                        }
                        break;
                    case 4:
                        switch (otoceni)
                        {
                            case 0:
                                if (misto[spawnmisto + 1 + (vyska - 1), spawnmisto2+1] == Color.Black && misto[(spawnmisto + 2 + (vyska - 1)), spawnmisto2+1] == Color.Black && misto[(spawnmisto + 3 + (vyska - 1)), spawnmisto2+1] == Color.Black)
                                {
                                    misto[spawnmisto + 1 + (vyska - 1), spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + 2 + (vyska - 1)), spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + 3 + (vyska - 1)), spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + 3 + (vyska - 1)), spawnmisto2 - 1] = Color.Black;

                                    spawnmisto2 = spawnmisto2 + 1;

                                    misto[spawnmisto + 1 + (vyska - 1), spawnmisto2] = randomColor;
                                    misto[(spawnmisto + 2 + (vyska - 1)), spawnmisto2] = randomColor;
                                    misto[(spawnmisto + 3 + (vyska - 1)), spawnmisto2] = randomColor;
                                    misto[(spawnmisto + 3 + (vyska - 1)), spawnmisto2 - 1] = randomColor;
                                    zobrazeni();
                                }
                                break;
                            case 1:
                                if (misto[spawnmisto + vyska, spawnmisto2 + 3] == Color.Black && misto[spawnmisto + vyska + 1, spawnmisto2 + 3] == Color.Black)
                                {
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2 + 1] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2 + 2] = Color.Black;
                                    misto[spawnmisto + 1 + vyska, spawnmisto2 + 2] = Color.Black;

                                    spawnmisto2 = spawnmisto2 + 1;

                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2 + 1] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2 + 2] = randomColor;
                                    misto[spawnmisto + 1 + vyska, spawnmisto2 + 2] = randomColor;
                                    zobrazeni();
                                }
                                break;
                            case 2:
                                if (misto[spawnmisto + vyska, spawnmisto2+1] == Color.Black && misto[spawnmisto + vyska - 1, spawnmisto2 + 1] == Color.Black && misto[spawnmisto + vyska - 2, spawnmisto2 + 2] == Color.Black)
                                {
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + vyska - 1, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + vyska - 2, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + vyska - 2, spawnmisto2 + 1] = Color.Black;

                                    spawnmisto2 = spawnmisto2 + 1;

                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto + vyska - 1, spawnmisto2] = randomColor;
                                    misto[spawnmisto + vyska - 2, spawnmisto2] = randomColor;
                                    misto[spawnmisto + vyska - 2, spawnmisto2 + 1] = randomColor;
                                    zobrazeni();
                                }
                                break;
                            case 3:
                                if (misto[spawnmisto + vyska, spawnmisto2 + 1] == Color.Black && misto[spawnmisto - 1 + vyska, spawnmisto2 - 1] == Color.Black)
                                {
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2 - 1] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2 - 2] = Color.Black;
                                    misto[spawnmisto - 1 + vyska, spawnmisto2 - 2] = Color.Black;

                                    spawnmisto2 = spawnmisto2 + 1;

                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2 - 1] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2 - 2] = randomColor;
                                    misto[spawnmisto - 1 + vyska, spawnmisto2 - 2] = randomColor;
                                    zobrazeni();
                                }
                                break;
                        }
                        break;
                    case 5:
                        switch (otoceni)
                        {
                            case 0:
                                if (misto[spawnmisto - 1 + vyska, spawnmisto2 + 2] == Color.Black && misto[spawnmisto + vyska, spawnmisto2+1] == Color.Black)
                                {
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto - 1 + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto - 1 + vyska, spawnmisto2 + 1] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2 - 1] = Color.Black;

                                    spawnmisto2 = spawnmisto2 + 1;

                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto - 1 + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto - 1 + vyska, spawnmisto2 + 1] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2 - 1] = randomColor;
                                    zobrazeni();
                                }
                                break;
                            case 1:
                                if (misto[spawnmisto + vyska - 1, spawnmisto2] == Color.Black && misto[spawnmisto + vyska, spawnmisto2+1] == Color.Black && misto[spawnmisto + vyska+1, spawnmisto2 + 1] == Color.Black)
                                {
                                    misto[spawnmisto + vyska - 1, spawnmisto2 - 1] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2 - 1] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + 1 + vyska, spawnmisto2] = Color.Black;

                                    spawnmisto2 = spawnmisto2 + 1;

                                    misto[spawnmisto + vyska - 1, spawnmisto2 - 1] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2 - 1] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto + 1 + vyska, spawnmisto2] = randomColor;
                                    zobrazeni();
                                }
                                break;
                        }
                        break;
                    case 6:
                        switch (otoceni)
                        {
                            case 0:
                                if (misto[spawnmisto - 1 + vyska, spawnmisto2 + 1] == Color.Black && misto[spawnmisto + vyska, spawnmisto2 + 2] == Color.Black)
                                {
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto - 1 + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto - 1 + vyska, spawnmisto2 - 1] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2 + 1] = Color.Black;

                                    spawnmisto2 = spawnmisto2 + 1;

                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto - 1 + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto - 1 + vyska, spawnmisto2 - 1] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2 + 1] = randomColor;
                                    zobrazeni();
                                }
                                break;
                            case 1:
                                if (misto[spawnmisto + vyska - 1, spawnmisto2+2] == Color.Black && misto[spawnmisto + vyska, spawnmisto2 + 2] == Color.Black && misto[spawnmisto + vyska + 1, spawnmisto2 + 1] == Color.Black)
                                {
                                    misto[spawnmisto + vyska - 1, spawnmisto2 + 1] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2 + 1] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + 1 + vyska, spawnmisto2] = Color.Black;

                                    spawnmisto2 = spawnmisto2 + 1;

                                    misto[spawnmisto + vyska - 1, spawnmisto2 + 1] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2 + 1] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto + 1 + vyska, spawnmisto2] = randomColor;
                                    zobrazeni();
                                }
                                break;
                        }
                        break;
                }
            }

        }
                                    
        private void Dolu()
        {
            if (padani)
            {
                switch (AktTvar)
                {
                    case 0:
                        switch (otoceni)
                        {
                            case 0:
                                if (misto[spawnmisto + 3 + vyska, spawnmisto2] == Color.Black && misto[spawnmisto + 3 + vyska, spawnmisto2 + 1] == Color.Black)
                                {
                                    misto[spawnmisto + 1 + (vyska - 1), spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + 2 + (vyska - 1)), spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + 3 + (vyska - 1)), spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + 3 + (vyska - 1)), spawnmisto2 + 1] = Color.Black;

                                    spawnmisto = spawnmisto + 1;

                                    misto[spawnmisto + 1 + (vyska - 1), spawnmisto2] = randomColor;
                                    misto[(spawnmisto + 2 + (vyska - 1)), spawnmisto2] = randomColor;
                                    misto[(spawnmisto + 3 + (vyska - 1)), spawnmisto2] = randomColor;
                                    misto[(spawnmisto + 3 + (vyska - 1)), spawnmisto2 + 1] = randomColor;
                                    zobrazeni();
                                }
                                break;
                            case 1:
                                if (misto[spawnmisto + vyska+1, spawnmisto2] == Color.Black && misto[spawnmisto + vyska+1, spawnmisto2 + 1] == Color.Black && misto[spawnmisto + vyska+1, spawnmisto2 + 2] == Color.Black)
                                {
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2 + 1] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2 + 2] = Color.Black;
                                    misto[spawnmisto - 1 + vyska, spawnmisto2 + 2] = Color.Black;

                                    spawnmisto++;

                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2 + 1] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2 + 2] = randomColor;
                                    misto[spawnmisto - 1 + vyska, spawnmisto2 + 2] = randomColor;
                                    zobrazeni();
                                }
                                break;
                            case 2:
                                if (misto[spawnmisto + vyska+1, spawnmisto2] == Color.Black && misto[spawnmisto + vyska - 1, spawnmisto2 - 1] == Color.Black)
                                {
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + vyska - 1, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + vyska - 2, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + vyska - 2, spawnmisto2 - 1] = Color.Black;

                                    spawnmisto++;

                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto + vyska - 1, spawnmisto2] = randomColor;
                                    misto[spawnmisto + vyska - 2, spawnmisto2] = randomColor;
                                    misto[spawnmisto + vyska - 2, spawnmisto2 - 1] = randomColor;
                                    zobrazeni();
                                }
                                break;
                            case 3:
                                if (misto[spawnmisto + 1 + vyska+1, spawnmisto2 - 2] == Color.Black && misto[spawnmisto + vyska+1, spawnmisto2 - 1] == Color.Black && misto[spawnmisto + vyska+1, spawnmisto2] == Color.Black)
                                {
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2 - 1] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2 - 2] = Color.Black;
                                    misto[spawnmisto + 1 + vyska, spawnmisto2 - 2] = Color.Black;

                                    spawnmisto++;

                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2 - 1] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2 - 2] = randomColor;
                                    misto[spawnmisto + 1 + vyska, spawnmisto2 - 2] = randomColor;
                                    zobrazeni();
                                }
                                break;
                        }
                        break;
                    case 1:
                        switch (otoceni)
                        {
                            case 0:
                                if (misto[spawnmisto + 2 + vyska, spawnmisto2] == Color.Black && misto[spawnmisto + 2 + vyska, spawnmisto2 + 1] == Color.Black && misto[spawnmisto + 2 + vyska, spawnmisto2 - 1] == Color.Black)
                                {
                                    misto[spawnmisto + 1 + (vyska - 1), spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + 2 + (vyska - 1)), spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + 2 + (vyska - 1)), spawnmisto2 - 1] = Color.Black;
                                    misto[(spawnmisto + 2 + (vyska - 1)), spawnmisto2 + 1] = Color.Black;

                                    spawnmisto = spawnmisto + 1;

                                    misto[spawnmisto + 1 + (vyska - 1), spawnmisto2] = randomColor;
                                    misto[(spawnmisto + 2 + (vyska - 1)), spawnmisto2] = randomColor;
                                    misto[(spawnmisto + 2 + (vyska - 1)), spawnmisto2 - 1] = randomColor;
                                    misto[(spawnmisto + 2 + (vyska - 1)), spawnmisto2 + 1] = randomColor;
                                    zobrazeni();
                                }
                                break;
                            case 1:
                                if (misto[spawnmisto + vyska+1, spawnmisto2] == Color.Black && misto[(spawnmisto + 1 + vyska+1), spawnmisto2 + 1] == Color.Black)
                                {
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + vyska), spawnmisto2 + 1] = Color.Black;
                                    misto[(spawnmisto + 1 + vyska), spawnmisto2 + 1] = Color.Black;
                                    misto[(spawnmisto - 1 + vyska), spawnmisto2 + 1] = Color.Black;

                                    spawnmisto = spawnmisto + 1;

                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[(spawnmisto + vyska), spawnmisto2 + 1] = randomColor;
                                    misto[(spawnmisto + 1 + vyska), spawnmisto2 + 1] = randomColor;
                                    misto[(spawnmisto - 1 + vyska), spawnmisto2 + 1] = randomColor;
                                    zobrazeni();
                                }
                                break;
                            case 2:
                                if (misto[spawnmisto + vyska+1, spawnmisto2] == Color.Black && misto[(spawnmisto - 1 + vyska+1), spawnmisto2 + 1] == Color.Black && misto[(spawnmisto - 1 + vyska+1), spawnmisto2 - 1] == Color.Black)
                                {
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + vyska - 1), spawnmisto2] = Color.Black;
                                    misto[(spawnmisto - 1 + vyska), spawnmisto2 + 1] = Color.Black;
                                    misto[(spawnmisto - 1 + vyska), spawnmisto2 - 1] = Color.Black;

                                    spawnmisto = spawnmisto + 1;

                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[(spawnmisto + vyska - 1), spawnmisto2] = randomColor;
                                    misto[(spawnmisto - 1 + vyska), spawnmisto2 + 1] = randomColor;
                                    misto[(spawnmisto - 1 + vyska), spawnmisto2 - 1] = randomColor;
                                    zobrazeni();
                                }
                                break;
                            case 3:
                                if (misto[spawnmisto + vyska+1, spawnmisto2] == Color.Black && misto[(spawnmisto + 1 + vyska+1), spawnmisto2 - 1] == Color.Black)
                                {
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + vyska), spawnmisto2 - 1] = Color.Black;
                                    misto[(spawnmisto - 1 + vyska), spawnmisto2 - 1] = Color.Black;
                                    misto[(spawnmisto + 1 + vyska), spawnmisto2 - 1] = Color.Black;

                                    spawnmisto = spawnmisto + 1;

                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[(spawnmisto + vyska), spawnmisto2 - 1] = randomColor;
                                    misto[(spawnmisto - 1 + vyska), spawnmisto2 - 1] = randomColor;
                                    misto[(spawnmisto + 1 + vyska), spawnmisto2 - 1] = randomColor;
                                    zobrazeni();
                                }
                                break;
                        }
                        break;
                    case 2:
                        switch (otoceni)
                        {
                            case 0:
                                if (misto[spawnmisto + 4 + vyska, spawnmisto2] == Color.Black)
                                {
                                    misto[spawnmisto + 1 + (vyska - 1), spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + 2 + (vyska - 1)), spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + 3 + (vyska - 1)), spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + 4 + (vyska - 1)), spawnmisto2] = Color.Black;

                                    spawnmisto = spawnmisto + 1;

                                    misto[spawnmisto + 1 + (vyska - 1), spawnmisto2] = randomColor;
                                    misto[(spawnmisto + 2 + (vyska - 1)), spawnmisto2] = randomColor;
                                    misto[(spawnmisto + 3 + (vyska - 1)), spawnmisto2] = randomColor;
                                    misto[(spawnmisto + 4 + (vyska - 1)), spawnmisto2] = randomColor;
                                    zobrazeni();
                                }
                                break;
                            case 1:
                                if (misto[spawnmisto + vyska+1, spawnmisto2] == Color.Black && misto[spawnmisto + vyska+1, spawnmisto2 - 1] == Color.Black && misto[spawnmisto + vyska+1, spawnmisto2 + 1] == Color.Black && misto[spawnmisto + vyska+1, spawnmisto2 + 2] == Color.Black)
                                {
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[(spawnmisto + vyska), spawnmisto2 - 1] = Color.Black;
                                    misto[(spawnmisto + vyska), spawnmisto2 + 1] = Color.Black;
                                    misto[(spawnmisto + vyska), spawnmisto2 + 2] = Color.Black;

                                    spawnmisto++;

                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[(spawnmisto + vyska), spawnmisto2 - 1] = randomColor;
                                    misto[(spawnmisto + vyska), spawnmisto2 + 1] = randomColor;
                                    misto[(spawnmisto + vyska), spawnmisto2 + 2] = randomColor;
                                    zobrazeni();
                                }
                                break;
                        }
                        break;
                    case 3:
                        if (misto[spawnmisto + 1 + vyska+1, spawnmisto2 + 1] == Color.Black && misto[spawnmisto + 1 + vyska+1, spawnmisto2] == Color.Black)
                        {
                            misto[spawnmisto + vyska - 1, spawnmisto2] = Color.Black;
                            misto[spawnmisto + vyska - 1, spawnmisto2 + 1] = Color.Black;
                            misto[spawnmisto + 1 + vyska - 1, spawnmisto2] = Color.Black;
                            misto[spawnmisto + 1 + vyska - 1, spawnmisto2 + 1] = Color.Black;

                            spawnmisto = spawnmisto + 1;

                            misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                            misto[spawnmisto + vyska, spawnmisto2 + 1] = randomColor;
                            misto[spawnmisto + 1 + vyska, spawnmisto2] = randomColor;
                            misto[spawnmisto + 1 + vyska, spawnmisto2 + 1] = randomColor;

                            zobrazeni();
                        }
                        break;
                    case 4:
                        switch (otoceni)
                        {
                            case 0:
                                if (misto[spawnmisto + 2 + vyska + 1, spawnmisto2] == Color.Black && misto[spawnmisto + 2 + vyska + 1, spawnmisto2 - 1] == Color.Black)
                                {
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + 1 + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + 2 + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + 2 + vyska, spawnmisto2 - 1] = Color.Black;

                                    spawnmisto++;

                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto + 1 + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto + 2 + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto + 2 + vyska, spawnmisto2 - 1] = randomColor;

                                    zobrazeni();
                                }
                                break;
                            case 1:
                                if (misto[spawnmisto + vyska+1, spawnmisto2] == Color.Black && misto[spawnmisto + vyska+1, spawnmisto2 + 1] == Color.Black && misto[spawnmisto + vyska+1 + 1, spawnmisto2 + 2] == Color.Black)
                                {
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2 + 1] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2 + 2] = Color.Black;
                                    misto[spawnmisto + 1 + vyska, spawnmisto2 + 2] = Color.Black;

                                    spawnmisto++;

                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2 + 1] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2 + 2] = randomColor;
                                    misto[spawnmisto + 1 + vyska, spawnmisto2 + 2] = randomColor;
                                    zobrazeni();
                                }
                                break;
                            case 2:
                                if (misto[spawnmisto + vyska+1, spawnmisto2] == Color.Black && misto[spawnmisto + vyska+1 - 2, spawnmisto2 + 1] == Color.Black)
                                {
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + vyska - 1, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + vyska - 2, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + vyska - 2, spawnmisto2 + 1] = Color.Black;

                                    spawnmisto++;

                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto + vyska - 1, spawnmisto2] = randomColor;
                                    misto[spawnmisto + vyska - 2, spawnmisto2] = randomColor;
                                    misto[spawnmisto + vyska - 2, spawnmisto2 + 1] = randomColor;
                                    zobrazeni();
                                }
                                break;
                            case 3:
                                if (misto[spawnmisto + vyska+1, spawnmisto2 - 2] == Color.Black && misto[spawnmisto + vyska+1, spawnmisto2 - 1] == Color.Black && misto[spawnmisto + vyska+1, spawnmisto2] == Color.Black)
                                {
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2 - 1] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2 - 2] = Color.Black;
                                    misto[spawnmisto - 1 + vyska, spawnmisto2 - 2] = Color.Black;

                                    spawnmisto++;

                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2 - 1] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2 - 2] = randomColor;
                                    misto[spawnmisto - 1 + vyska, spawnmisto2 - 2] = randomColor;
                                    zobrazeni();
                                }
                                break;
                        }
                        break;
                    case 5:
                        switch (otoceni)
                        {
                            case 0:
                                if (misto[spawnmisto + vyska+1, spawnmisto2] == Color.Black && misto[spawnmisto + vyska+1, spawnmisto2 - 1] == Color.Black && misto[spawnmisto - 1 + vyska + 1, spawnmisto2 + 1] == Color.Black)
                                {
                                   misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto - 1 + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto - 1 + vyska, spawnmisto2 + 1] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2 - 1] = Color.Black;

                                    spawnmisto++;

                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto - 1 + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto - 1 + vyska, spawnmisto2 + 1] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2 - 1] = randomColor;
                                    zobrazeni();
                                }
                                break;
                            case 1:
                                if (misto[spawnmisto + 1 + vyska+1, spawnmisto2] == Color.Black && misto[spawnmisto + vyska+1, spawnmisto2 - 1] == Color.Black)
                                {
                                    misto[spawnmisto + vyska - 1, spawnmisto2 - 1] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2 - 1] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + 1 + vyska, spawnmisto2] = Color.Black;

                                    spawnmisto++;

                                    misto[spawnmisto + vyska - 1, spawnmisto2 - 1] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2 - 1] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto + 1 + vyska, spawnmisto2] = randomColor;
                                    zobrazeni();
                                }
                                break;
                        }
                        break;
                    case 6:
                        switch (otoceni)
                        {
                            case 0:
                                if (misto[spawnmisto + vyska+1, spawnmisto2] == Color.Black && misto[spawnmisto + vyska+1, spawnmisto2 + 1] == Color.Black && misto[spawnmisto - 1 + vyska+1, spawnmisto2 - 1] == Color.Black)
                                {
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto - 1 + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto - 1 + vyska, spawnmisto2 - 1] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2 + 1] = Color.Black;

                                    spawnmisto++;

                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto - 1 + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto - 1 + vyska, spawnmisto2 - 1] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2 + 1] = randomColor;
                                    zobrazeni();
                                }
                                break;
                            case 1:
                                if (misto[spawnmisto + 1 + vyska+1, spawnmisto2] == Color.Black && misto[spawnmisto + vyska+1, spawnmisto2 + 1] == Color.Black)
                                {
                                    misto[spawnmisto + vyska - 1, spawnmisto2 + 1] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2 + 1] = Color.Black;
                                    misto[spawnmisto + vyska, spawnmisto2] = Color.Black;
                                    misto[spawnmisto + 1 + vyska, spawnmisto2] = Color.Black;

                                    spawnmisto++;

                                    misto[spawnmisto + vyska - 1, spawnmisto2 + 1] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2 + 1] = randomColor;
                                    misto[spawnmisto + vyska, spawnmisto2] = randomColor;
                                    misto[spawnmisto + 1 + vyska, spawnmisto2] = randomColor;
                                    zobrazeni();
                                }
                                break;
                        }
                        break;
                }
            }
        }
        private void kontrola()
        {
            int kontrola = 0;
            for (int i = 0; i < (labely.GetLength(0)); i++)
            {
                kontrola = 0;
                for (int x = 0; x < labely.GetLength(1); x++)
                {
                    if (labely[i, x].BackColor != Color.Black)
                        kontrola++;
                }
                if(kontrola==10)
                {
                    if(checkBox2.Checked == true)
                    {
                        var zvuky = new WMPLib.WindowsMediaPlayer();
                        zvuky.URL = @"Tetris Clear.wav";
                    }
                    
                    for (int x = 0; x < labely.GetLength(1); x++)
                    {
                        misto[i, x] = Color.Gray;
                        
                    }
                    zobrazeni();
                    wait(250);

                    Color[,] mistodocasne = new Color[20, 10];
                    for (int z = 0; z < i; z++)
                    {
                        for (int x = 0; x < labely.GetLength(1); x++)
                        {
                            mistodocasne[z + 1, x] = misto[z, x];
                        }

                    }
                    for (int z = i + 1; z < (labely.GetLength(0)); z++)
                    {
                        for (int x = 0; x < labely.GetLength(1); x++)
                        {
                            mistodocasne[z, x] = misto[z, x];
                        }
                    }

                    for (int x = 0; x < labely.GetLength(1); x++)
                    {
                        mistodocasne[0, x] = Color.Black;
                    }

                    for (int z = 0; z < (labely.GetLength(0)); z++)
                    {
                        for (int x = 0; x < labely.GetLength(1); x++)
                        {
                            labely[z, x].BackColor = mistodocasne[z, x];
                        }
                    }

                    for (int z = 0; z < (labely.GetLength(0)); z++)
                    {
                        for (int x = 0; x < labely.GetLength(1); x++)
                        {
                            misto[z,x] = mistodocasne[z, x];
                        }
                    }
                    skore++;
                    label200.Text = "SKÓRE: " + skore;
                }

            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Doleva();
            zobrazeni();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            kontrola();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            nastavení();
        }

        private void nastavení()
        {
            if (VN == true)
            {
                label202.Visible = false;
                label203.Visible = false;
                numericUpDown2.Enabled = false;
                numericUpDown2.Visible = false;
                this.Width = 360;
                numericUpDown1.Enabled = false;
                numericUpDown1.Visible = false;
                label201.Visible = false;
                button1.Enabled = false;
                button1.Visible = false;
                button2.Enabled = false;
                button2.Visible = false;
                VN = false;
                checkBox1.Enabled = false;
                checkBox1.Visible = false;
                checkBox2.Enabled = false;
                checkBox2.Visible = false;
            }
            else if (VN == false)
            {
                label202.Visible = true;
                label203.Visible = true;
                numericUpDown2.Enabled = true;
                numericUpDown2.Visible = true;
                this.Width = 440;
                numericUpDown1.Enabled = true;
                numericUpDown1.Visible = true;
                label201.Visible = true;
                button1.Enabled = true;
                button1.Visible = true;
                button2.Enabled = true;
                button2.Visible = true;
                VN = true;
                checkBox1.Enabled = true;
                checkBox1.Visible = true;
                checkBox2.Enabled = true;
                checkBox2.Visible = true;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 0)
                cas = Convert.ToInt32(numericUpDown1.Value);
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
            if (padani)
            {
                try
                {
                    switch (e.KeyCode)
                    {
                        case Keys.A:
                            {   
                                Doleva();
                            }
                            break;
                        case Keys.D:
                            {
                                Doprava();
                            }
                            break;
                        case Keys.S:
                            {
                                Dolu();
                            }
                            break;
                        case Keys.W:
                            {
                                if(StisknutiW == false)
                                {
                                    StisknutiW = true;
                                    otocit();
                                }
                                
                            }
                            break;
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    label201.Text = "Index out of range - KeyDown";
                }
            }
        }

        private void Form1_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
                StisknutiW = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                hudba.PlayLooping();
            else
                hudba.Stop();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            Environment.Exit(0);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
           Environment.Exit(0);
        }
    }
}
