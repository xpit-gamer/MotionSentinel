namespace MotionSentinel
{
    partial class AboutForm
    {
        private Label lblTitle;
        private Label lblDescription;
        private Label lblVersion;
        private LinkLabel linkGitHub;
        private Button btnClose;

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.lblDescription = new Label();
            this.lblVersion = new Label();
            this.linkGitHub = new LinkLabel();
            this.btnClose = new Button();

            this.SuspendLayout();

            // Title
            this.lblTitle.Text = "MotionSentinel";
            this.lblTitle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            this.lblTitle.Location = new Point(20, 20);
            this.lblTitle.AutoSize = true;

            // Description
            this.lblDescription.Text =
                "MotionSentinel prevents idle mode by simulating subtle, human-like mouse activity.\n" +
                "Designed for stability, low resource usage, and full user control.";
            this.lblDescription.Location = new Point(20, 60);
            this.lblDescription.Size = new Size(360, 60);

            // Version
            this.lblVersion.Text = "Version: 1.0.0";
            this.lblVersion.Location = new Point(20, 130);
            this.lblVersion.AutoSize = true;

            // GitHub link
            this.linkGitHub.Text = "GitHub Repository";
            this.linkGitHub.Location = new Point(20, 160);
            this.linkGitHub.AutoSize = true;
            this.linkGitHub.LinkClicked += linkGitHub_LinkClicked;

            // Close button
            this.btnClose.Text = "Close";
            this.btnClose.Location = new Point(280, 200);
            this.btnClose.Click += btnClose_Click;

            // Form
            this.ClientSize = new Size(380, 250);
            this.Text = "About MotionSentinel";
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.linkGitHub);
            this.Controls.Add(this.btnClose);

            this.ResumeLayout(false);
        }
    }
}
