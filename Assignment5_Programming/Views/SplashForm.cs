﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Name: Gurleen Kaur 
 * Student Number 301047536
 * Description: this is an event handler for splash screen
 */

namespace Assignment5_Programming.Views
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashScreenTimer_Tick(object sender, EventArgs e)
        {
            SplashScreenTimer.Enabled = false;
            
            Program.startForm.Show();
            this.Hide();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            SplashScreenTimer.Enabled = true;
        }
    }
}
