using System;
using System.Drawing;
using System.Windows.Forms;

namespace ElrahmaHR
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Elrahma HR - Employee Management";
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            
            // Add basic controls for employee management
            var titleLabel = new Label();
            titleLabel.Text = "Elrahma HR - Employee Management System";
            titleLabel.Font = new Font("Arial", 16, FontStyle.Bold);
            titleLabel.Dock = DockStyle.Top;
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            
            this.Controls.Add(titleLabel);
        }
    }
}