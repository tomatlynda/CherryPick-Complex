using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace MorseCode.UI
{
    public partial class frSettings : Form
    {
        public frSettings()
        {
            InitializeComponent();

            Properties.Settings settings = Properties.Settings.Default;

            txtDot.Text = settings.Dot.ToString();
            txtDash.Text = settings.Dash.ToString();
            txtCharSpace.Text = settings.CharSpace.ToString();
            txtWordSpace.Text = settings.WordSpace.ToString();
            txtDashSense.Text = settings.DashSense.ToString();
            txtSpaceSense.Text = settings.SpaceSense.ToString();
            chkMute.Checked = settings.IsMuted;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Properties.Settings settings = Properties.Settings.Default;

            settings.Dot = char.Parse(this.txtDot.Text);
            settings.Dash = char.Parse(this.txtDash.Text);
            settings.CharSpace = this.txtCharSpace.Text;
            settings.WordSpace = this.txtWordSpace.Text;
            settings.DashSense = int.Parse(this.txtDashSense.Text);
            settings.SpaceSense = int.Parse(this.txtSpaceSense.Text);
            settings.IsMuted = this.chkMute.Checked;
            settings.Save();

            this.Hide();
        }

        private void txtSpaceSense_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            int value = int.Parse(txtSpaceSense.Text);

            if (e.KeyCode == Keys.Up)
                value += 10;
            else if (e.KeyCode == Keys.PageUp)
                value += 100;
            else if (e.KeyCode == Keys.Down)
                value += -10;
            else if (e.KeyCode == Keys.PageDown)
                value += -100;

            txtSpaceSense.Text = value.ToString();
            
            this.Cursor = Cursors.Default;
        }

        private void txtDashSense_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            int value = int.Parse(txtDashSense.Text);

            if (e.KeyCode == Keys.Up)
                value += 10;
            else if (e.KeyCode == Keys.PageUp)
                value += 100;
            else if (e.KeyCode == Keys.Down)
                value += -10;
            else if (e.KeyCode == Keys.PageDown)
                value += -100;

            txtDashSense.Text = value.ToString();

            this.Cursor = Cursors.Default;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
