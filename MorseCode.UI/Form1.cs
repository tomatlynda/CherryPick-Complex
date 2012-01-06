using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace MorseCode.UI
{
    public partial class Form1 : Form
    {
        private long _startTicks;
        private long _endTicks;
        private string _keyedValues;
        private frSettings settingsForm;
        private long _idleSeconds;

        public Form1()
        {
            InitializeComponent();

            tmrMain.Start();
            settingsForm = new frSettings();
            _idleSeconds = 0;
        }

        private char StringToChar(string Str)
        {
            char Return = ' ';

            char[] Chars = Str.ToCharArray();

            if (Chars.Length > 0)
                Return = Chars[0];

            return Return;
        }

        private void commitInturpret()
        {
            if(!string.IsNullOrEmpty(_keyedValues))
                txtResults.Text += string.Format("={0}\r\n", MorseCode.Lib.MorseCode.GetCharacter(_keyedValues, Properties.Settings.Default.Dot, Properties.Settings.Default.Dash));
            _keyedValues = string.Empty;
        }

        private void inturpret()
        {
            long value = (_endTicks - _startTicks) / 10000;
            string sValue = string.Empty;

            //Text = value.ToString();
            grpKeyArea.Text = string.Format("Key Area ({0})", value);

            if (value < Properties.Settings.Default.DashSense)
                // Dot
                sValue = Properties.Settings.Default.Dot.ToString();
            else
                // Dash
                sValue = Properties.Settings.Default.Dash.ToString();

            _keyedValues += sValue;
            txtResults.Text += sValue;
        }

        #region Events

        private void tmrMain_Tick(object sender, System.EventArgs e)
        {
            _idleSeconds++;

            if (_idleSeconds > 1)
                commitInturpret();
        }

        #region KeyPad

        private void grpKeyArea_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            _startTicks = DateTime.Now.Ticks;
            if (Math.Abs(_endTicks - _startTicks) / 10000 > Properties.Settings.Default.SpaceSense)
                commitInturpret();

            if (!Properties.Settings.Default.IsMuted)
                Console.Beep(800, 200);

            _idleSeconds = 0;
        }

        private void grpKeyArea_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            _endTicks = DateTime.Now.Ticks;
            inturpret();
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            string[] Words = txtInput.Text.Split(new string[] { " ", "\r\n", "\r", "\n" }, StringSplitOptions.None);

            txtResults.Text = "";
            string Code = "";

            for (int i = 0; i < Words.GetLength(0); i++)
                if (Words[i].Length == 0)
                    txtResults.Text += "\r\n";
                else
                {
                    Code = MorseCode.Lib.MorseCode.GetCode(Words[i], Properties.Settings.Default.Dot, Properties.Settings.Default.Dash, Properties.Settings.Default.WordSpace, Properties.Settings.Default.CharSpace);
                    txtResults.Text += Words[i] + " = " + Code + "\r\n";
                }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingsForm.Show();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtResults.Text = string.Empty;
        }
        #endregion

    }
}