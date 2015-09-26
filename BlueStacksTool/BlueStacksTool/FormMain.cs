using BlueStacksTool.Utils;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BlueStacksTool
{
    public partial class FormMain : Form
    {
        private string[] processes = new string[] { "HD-Frontend", "HD-RunApp",
            "HD-BlockDevice", "HD-Network", "HD-Service" };

        public FormMain()
        {
            InitializeComponent();
            this.Text = AppSettings.App.Name + AppSettings.App.Sep + AppSettings.App.Ver;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            checkBox_fullscreen.Checked = (Read("FullScreen") == "0" ? false : true);
            comboBox_width.Text = Read("WindowWidth");
            comboBox_height.Text = Read("WindowHeight");
            timer_bluestacks.Start();
        }

        private void checkBox_fullscreen_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_fullscreen.Checked)
                Write("FullScreen", "1");
            else
                Write("FullScreen", "0");
        }

        private void comboBox_width_TextChanged(object sender, EventArgs e)
        {
            if(comboBox_width.Text.Trim() != "")
            {
                Write("WindowWidth", comboBox_width.Text.Trim());
                Write("GuestWidth", comboBox_width.Text.Trim());
            }
        }

        private void comboBox_height_TextChanged(object sender, EventArgs e)
        {
            if (comboBox_height.Text.Trim() != "")
            {
                Write("WindowHeight", comboBox_height.Text.Trim());
                Write("GuestHeight", comboBox_height.Text.Trim());
            }
        }

        private void comboBox_width_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void comboBox_height_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private string Read(string KeyName)
        {
            try
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\BlueStacks\\Guests\\Android\\FrameBuffer\\0\\"))
                {
                    if (key != null)
                    {
                        Object o = key.GetValue(KeyName);
                        if (o != null)
                            return o.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
            return null;
        }

        private void Write(string KeyName, Object Value)
        {
            try
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\BlueStacks\\Guests\\Android\\FrameBuffer\\0\\", true))
                {
                    if (key != null)
                    {
                        Object o = key.GetValue(KeyName);
                        if (o != null)
                            key.SetValue(KeyName, Value, RegistryValueKind.DWord);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void timer_bluestacks_Tick(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcessesByName("HD-Frontend");
            if (processes.Length > 0)
            {
                if (label_status.Text == "Off")
                {
                    label_status.ForeColor = Color.Green;
                    label_status.Text = "On";
                    button_close.Enabled = true;
                }
            }
            else
            {
                if (label_status.Text == "On")
                {
                    label_status.ForeColor = Color.Red;
                    label_status.Text = "Off";
                    button_close.Enabled = false;
                }
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            foreach (string pr in processes)
            {
                try
                {
                    Process[] proc = Process.GetProcessesByName(pr);
                    if (proc.Length > 0)
                        foreach (Process p in proc)
                            p.Kill();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error trying kill " + pr + " : " + ex.Message);
                }
            }
        }
    }
}
