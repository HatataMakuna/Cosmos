using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cosmos.Sudo
{
    public partial class SudoMain : Form
    {
        // TODO:
        // - Have custom competitors, can be used to simulate a competition
        // - Create and manage own course, used those to simulate
        // - Manually edit stats
        Cosmos _cosmos = new Cosmos();
        private bool _isExitingApp = false;

        (bool, DialogResult) _exitMode;

        public SudoMain()
        {
            InitializeComponent();
        }

        private void tsmiManageObstacles_Click(object sender, EventArgs e)
        {

        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close(); // Let FormClosing handle the confirmation
        }

        private void CloseForm(object sender, FormClosingEventArgs e)
        {
            if (_isExitingApp)
            {
                // If we are already exiting, don’t show dialog again
                return;
            }

            _exitMode = ExitApplication();
            if (_exitMode == (false, DialogResult.Yes)) {
                // show the main Cosmos window again
                _cosmos.Show();
            }
            else if (_exitMode == (false, DialogResult.No)) {
                // Exit the entire application
                _isExitingApp = true;   // prevent dialog from reopening
                Application.Exit();     // close all forms, including hidden Cosmos
            }
            else
            {
                e.Cancel = true;
            }
        }

        private (bool, DialogResult) ExitApplication()
        {
            // Do you want to exit the sudo mode or exit the entire application?
            DialogResult result = MessageBox.Show(
                "Do you want to exit the sudo mode or exit the entire application?\n" +
                "Yes - Exit Sudo Mode and return to main application\nNo - Exit the entire application" +
                "\nCancel - Cancel this operation", "Exit Sudo Mode",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.Yes:
                    // Exit Sudo Mode, return to main application
                    return (false, DialogResult.Yes);
                case DialogResult.No:
                    // Exit the entire application
                    return (false, DialogResult.No);
                default:
                    // Cancel the operation, do nothing
                    return (true, result);
            }
        }
    }
}
