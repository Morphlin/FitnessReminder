using System;
using System.Windows.Forms;

namespace Fitness_Minder
{
    internal partial class FormRemind : Form
    {
        internal FormRemind()
        {
            InitializeComponent();
        }

        private void FormRemind_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        internal void ShowIt(string ActivityName)
        {
            LabelActivity.Text = ActivityName;
            Show();
        }
    }
}
