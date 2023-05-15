using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp
{
    public partial class MusicApp : Form
    {
        public MusicApp()
        {
            InitializeComponent();
        }

        String[] paths, files;

        private void label1_Click(object sender, EventArgs e)
        {

        }
 
    private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;

                for(int i = 0; i < files.Length; i++)
                {
                    SongList.Items.Add(files[i]);
                }
            }

        }

        private void SongList_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = paths[SongList.SelectedIndex];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
