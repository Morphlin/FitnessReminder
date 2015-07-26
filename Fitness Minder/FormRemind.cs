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

        private bool _Example;
        internal void ShowIt(string ActivityName, System.Drawing.Font Font, System.Drawing.Color BackColor, bool Example)
        {
            LabelActivity.Text = ActivityName;
            LabelActivity.Font = Font;
            LabelActivity.BackColor = BackColor;
            _Example = Example;
            Show();
        }

        private void LabelActivity_Click(object sender, EventArgs e)
        {
            if (_Example) Hide();
        }
    }
}
