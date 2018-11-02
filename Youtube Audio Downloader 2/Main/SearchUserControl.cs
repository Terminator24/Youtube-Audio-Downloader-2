﻿using System;
using System.Windows.Forms;

namespace YoutubeAudioDownloader2.Main
{
    public partial class SearchUserControl : UserControl
    {
        private static SearchUserControl instance;
        public static SearchUserControl Instance { get { if (instance == null) { instance = new SearchUserControl(); } return instance; } }

        private SearchUserControl()
        {
            InitializeComponent();

            Dock = DockStyle.Fill;
        }

        private void optimizedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                button1.PerformClick();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Ricerca in corso...");
        }
    }
}
