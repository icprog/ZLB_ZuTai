using System;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace ZLB_Zutai
{
    public partial class AboutDialog : Form
    {
        public AboutDialog()
        {
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.Dpi;
        }

        private void AboutDialog_Load(object sender, EventArgs e)
        {
            labelAppVersion.Text = typeof(MainForm).Assembly.GetName().Version.ToString();
            labelLibVersion.Text = typeof(DockPanel).Assembly.GetName().Version.ToString();
        }
    }
}