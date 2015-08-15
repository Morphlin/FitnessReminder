using System;
using System.Windows.Forms;

namespace FitnessReminder
{
    /// <summary>
    /// 
    /// </summary>
    internal partial class FormRemind : Form
    {
        /// <summary>
        /// 
        /// </summary>
        internal FormRemind()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormRemind_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// 
        /// </summary>
        private bool _Example;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ActivityName"></param>
        /// <param name="Font"></param>
        /// <param name="BackColor"></param>
        /// <param name="Example"></param>
        internal void ShowIt(string ActivityName, System.Drawing.Font Font, System.Drawing.Color BackColor, bool Example)
        {
            LabelActivity.Text = ActivityName;
            LabelActivity.Font = Font;
            LabelActivity.BackColor = BackColor;
            _Example = Example;
            Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelActivity_Click(object sender, EventArgs e)
        {
            if (_Example) Hide();
        }
    }
}
