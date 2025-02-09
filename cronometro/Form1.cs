using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cronometro
{
    public partial class Form1 : Form
    {
        int hh, mm, ss;
        string m, s, mostrar;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblXronos.Text = "00:00:00";
        }

        public void reiniciar()
        {
            hh =0; mm = 0; ss = 0;
            lblXronos.Text = "00:00:00";
            tmrCrono.Stop();
           
        }

        private void btnPausa_Click(object sender, EventArgs e)
        {
            tmrCrono.Stop();
        }

        private void tmrCrono_Tick(object sender, EventArgs e)
        {
            ss += 1;
            s = Convert.ToString( ss);
            m = Convert.ToString(mm);


            if (ss <10)
            {
                s = Convert.ToString("0" + ss);
            }
            if (mm < 10)
            {
                m = Convert.ToString("0" + mm);
            }

            lblXronos.Text = Convert.ToString(hh + " : " + m + " : " + s);

            if (ss >= 59)
            {
                mm += 1;
                ss = 0;

                if (mm >= 59)
                {
                    hh += 1;
                    mm = 0;
                }
            }

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            tmrCrono.Start();

        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            
            reiniciar();
            
        }
    }
}
