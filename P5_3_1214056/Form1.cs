using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_3_1214056
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rbMouse_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMouse.Checked == true)
            {
                tslKetGambar.Text = "Cocok! Ini adalah gambar Mouse";
            }
            else
            {
                tslKetGambar.Text = "Tidak Cocok! Anda memilih gambar yang salah\nIni adalah gambar Mouse";
            }
        }

        private void tsbMouse_Click(object sender, EventArgs e)
        {
            if (rbMouse.Checked == true)
             {
                tslKetGambar.Text = "Cocok! Ini adalah gambar Mouse";
            }
            else
            {
                tslKetGambar.Text = "Tidak Cocok! Anda memilih gambar yang salah\nIni adalah gambar Mouse";
            }
        }

        private void tsbMonitor_Click(object sender, EventArgs e)
        {
            if (rbMonitor.Checked == true)
            {
                tslKetGambar.Text = "Cocok! Ini adalah gambar Monitor";
            }
            else
            {
                tslKetGambar.Text = "Tidak Cocok! Anda memilih gambar yang salah\nIni adalah gambar Monitor";
            }
        }

        private void tsbPrinter_Click(object sender, EventArgs e)
        {
            if (rbPrinter.Checked == true)
            {
                tslKetGambar.Text = "Cocok! Ini adalah gambar Printer";
            }
            else
            {
                tslKetGambar.Text = "Tidak Cocok! Anda memilih gambar yang salah\nIni adalah gambar Printer";
            }
        }

        private void tsbKeyboard_Click(object sender, EventArgs e)
        {
            if (rbKeyboard.Checked == true)
            {
                tslKetGambar.Text = "Cocok! Ini adalah gambar Keyboard";
            }
            else
            {
                tslKetGambar.Text = "Tidak Cocok! Anda memilih gambar yang salah\nIni adalah gambar keyboard";
            }
        }

        private void tsbScanner_Click(object sender, EventArgs e)
        {
            if (rbScanner.Checked == true)
            {
                tslKetGambar.Text = "Cocok! Ini adalah gambar Scanner";
            }
            else
            {
                tslKetGambar.Text = "Tidak Cocok! Anda memilih gambar yang salah\nIni adalah gambar Scanner";
            }
        }

        private void rbMonitor_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMonitor.Checked == true)
            {
                tslKetGambar.Text = "Cocok! Ini adalah gambar Monitor";
            }
            else
            {
                tslKetGambar.Text = "Tidak Cocok! Anda memilih gambar yang salah\nIni adalah gambar Monitor";
            }
        }

        private void rbKeyboard_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKeyboard.Checked == true)
            {
                tslKetGambar.Text = "Cocok! Ini adalah gambar Keyboard";
            }
            else
            {
                tslKetGambar.Text = "Tidak Cocok! Anda memilih gambar yang salah\nIni adalah gambar keyboard";
            }
        }

        private void rbPrinter_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPrinter.Checked == true)
            {
                tslKetGambar.Text = "Cocok! Ini adalah gambar Printer";
            }
            else
            {
                tslKetGambar.Text = "Tidak Cocok! Anda memilih gambar yang salah\nIni adalah gambar Printer";
            }
        }

        private void rbScanner_CheckedChanged(object sender, EventArgs e)
        {
            if (rbScanner.Checked == true)
            {
                tslKetGambar.Text = "Cocok! Ini adalah gambar Scanner";
            }
            else
            {
                tslKetGambar.Text = "Tidak Cocok! Anda memilih gambar yang salah\nIni adalah gambar Scanner";
            }
        }
    }
}
