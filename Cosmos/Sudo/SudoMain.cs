using Cosmos.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cosmos.Sudo
{
    public partial class SudoMain : Form
    {
        // TODO:
        // - Have custom competitors, can be used to simulate a competition
        // - Create and manage own course, used those to simulate
        // - Manually edit stats
        private Cosmos cosmos = new Cosmos();

        private List<Obstacle> _obstacles = new List<Obstacle>();

        private bool _isExitingApp = false;
        private (bool, DialogResult) _exitMode;

        public SudoMain(List<Obstacle> obstacles)
        {
            InitializeComponent();

            _obstacles = obstacles;
        }

        private void tsmiManageObstacles_Click(object sender, EventArgs e)
        {
            ManageObstacles manageObstaclesForm = new ManageObstacles(_obstacles);
            manageObstaclesForm.ShowDialog();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close(); // Let FormClosing handle the confirmation
        }

        private void CloseForm(object sender, FormClosingEventArgs e)
        {
            /// <summary>
            /// No need to save data before closing, as we let Cosmos handle that
            /// 
            /// Context:
            /// * You have a main application form (hidden, but still alive) and a sub application form (visible).
            /// * If you call `Application.Exit()` from the sub application:
            /// 1.The WinForms message loop begins shutting down.
            /// 2. Every open form (both the sub and the main form) will receive `FormClosing` and `FormClosed` events.
            /// 3.After all forms close, the message loop exits and the process ends.
            /// So yes — even though your main form is hidden, its `FormClosing` (and then `FormClosed`) events will be called before exit.

            if (_isExitingApp)
            {
                // If we are already exiting, don’t show dialog again
                return;
            }

            _exitMode = ExitApplication();
            if (_exitMode == (false, DialogResult.Yes)) {
                cosmos.Show();
            }
            else if (_exitMode == (false, DialogResult.No)) {
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
                "Yes - Exit Sudo Mode and return to main application\n" +
                "No - Exit the entire application\n" +
                "Cancel - Cancel this operation", "Exit Sudo Mode",
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
