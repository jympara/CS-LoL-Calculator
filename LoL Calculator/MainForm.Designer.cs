namespace LoL_Calculator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.ChampCompareButton = new System.Windows.Forms.Button();
			this.VsTeamCalcButton = new System.Windows.Forms.Button();
			this.VersusCalcButton = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.ChampOverviewButton = new System.Windows.Forms.Button();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.openMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.overviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.compareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.versusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.teamVersusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ExitButton = new System.Windows.Forms.Button();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ChampCompareButton
			// 
			this.ChampCompareButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.ChampCompareButton.BackColor = System.Drawing.Color.DarkGreen;
			this.ChampCompareButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ChampCompareButton.BackgroundImage")));
			this.ChampCompareButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ChampCompareButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ChampCompareButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ChampCompareButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ChampCompareButton.ForeColor = System.Drawing.Color.MediumSpringGreen;
			this.ChampCompareButton.Location = new System.Drawing.Point(218, 466);
			this.ChampCompareButton.Name = "ChampCompareButton";
			this.ChampCompareButton.Size = new System.Drawing.Size(200, 45);
			this.ChampCompareButton.TabIndex = 1;
			this.ChampCompareButton.Text = "Champion Compare";
			this.ChampCompareButton.UseVisualStyleBackColor = false;
			this.ChampCompareButton.Click += new System.EventHandler(this.ChampCompareButton_Click);
			// 
			// VsTeamCalcButton
			// 
			this.VsTeamCalcButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.VsTeamCalcButton.BackColor = System.Drawing.Color.DarkGreen;
			this.VsTeamCalcButton.BackgroundImage = global::LoL_Calculator.Images.VsTeamButton;
			this.VsTeamCalcButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.VsTeamCalcButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.VsTeamCalcButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.VsTeamCalcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.VsTeamCalcButton.ForeColor = System.Drawing.Color.MediumSpringGreen;
			this.VsTeamCalcButton.Location = new System.Drawing.Point(630, 466);
			this.VsTeamCalcButton.Name = "VsTeamCalcButton";
			this.VsTeamCalcButton.Size = new System.Drawing.Size(200, 45);
			this.VsTeamCalcButton.TabIndex = 2;
			this.VsTeamCalcButton.Text = "Vs Team Calculator";
			this.VsTeamCalcButton.UseVisualStyleBackColor = false;
			this.VsTeamCalcButton.Click += new System.EventHandler(this.VsTeamCalcButton_Click);
			// 
			// VersusCalcButton
			// 
			this.VersusCalcButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.VersusCalcButton.BackColor = System.Drawing.Color.DarkGreen;
			this.VersusCalcButton.BackgroundImage = global::LoL_Calculator.Images.VersusButton;
			this.VersusCalcButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.VersusCalcButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.VersusCalcButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.VersusCalcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.VersusCalcButton.ForeColor = System.Drawing.Color.MediumSpringGreen;
			this.VersusCalcButton.Location = new System.Drawing.Point(424, 466);
			this.VersusCalcButton.Name = "VersusCalcButton";
			this.VersusCalcButton.Size = new System.Drawing.Size(200, 45);
			this.VersusCalcButton.TabIndex = 3;
			this.VersusCalcButton.Text = "Versus Calculator";
			this.VersusCalcButton.UseVisualStyleBackColor = false;
			this.VersusCalcButton.Click += new System.EventHandler(this.VersusCalcButton_Click);
			// 
			// button5
			// 
			this.button5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.button5.BackColor = System.Drawing.Color.DarkGreen;
			this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.ForeColor = System.Drawing.Color.Black;
			this.button5.Location = new System.Drawing.Point(12, 415);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(200, 45);
			this.button5.TabIndex = 4;
			this.button5.UseVisualStyleBackColor = false;
			// 
			// button6
			// 
			this.button6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.button6.BackColor = System.Drawing.Color.DarkGreen;
			this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.ForeColor = System.Drawing.Color.Black;
			this.button6.Location = new System.Drawing.Point(218, 415);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(200, 45);
			this.button6.TabIndex = 5;
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button7
			// 
			this.button7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.button7.BackColor = System.Drawing.Color.DarkGreen;
			this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button7.ForeColor = System.Drawing.Color.Black;
			this.button7.Location = new System.Drawing.Point(424, 415);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(200, 45);
			this.button7.TabIndex = 6;
			this.button7.UseVisualStyleBackColor = false;
			// 
			// button8
			// 
			this.button8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.button8.BackColor = System.Drawing.Color.DarkGreen;
			this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button8.ForeColor = System.Drawing.Color.Black;
			this.button8.Location = new System.Drawing.Point(630, 415);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(200, 45);
			this.button8.TabIndex = 7;
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// ChampOverviewButton
			// 
			this.ChampOverviewButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.ChampOverviewButton.BackColor = System.Drawing.Color.DarkGreen;
			this.ChampOverviewButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ChampOverviewButton.BackgroundImage")));
			this.ChampOverviewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ChampOverviewButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ChampOverviewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ChampOverviewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ChampOverviewButton.ForeColor = System.Drawing.Color.MediumSpringGreen;
			this.ChampOverviewButton.Location = new System.Drawing.Point(12, 466);
			this.ChampOverviewButton.Name = "ChampOverviewButton";
			this.ChampOverviewButton.Size = new System.Drawing.Size(200, 45);
			this.ChampOverviewButton.TabIndex = 0;
			this.ChampOverviewButton.Text = "Champion Overview";
			this.ChampOverviewButton.UseVisualStyleBackColor = false;
			this.ChampOverviewButton.Click += new System.EventHandler(this.ChampOverviewButton_Click);
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "League Calculator";
			this.notifyIcon1.Visible = true;
			this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenuToolStripMenuItem,
            this.overviewToolStripMenuItem,
            this.compareToolStripMenuItem,
            this.versusToolStripMenuItem,
            this.teamVersusToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(140, 136);
			// 
			// openMenuToolStripMenuItem
			// 
			this.openMenuToolStripMenuItem.Name = "openMenuToolStripMenuItem";
			this.openMenuToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.openMenuToolStripMenuItem.Text = "Open Menu";
			this.openMenuToolStripMenuItem.Click += new System.EventHandler(this.openMenuToolStripMenuItem_Click);
			// 
			// overviewToolStripMenuItem
			// 
			this.overviewToolStripMenuItem.Name = "overviewToolStripMenuItem";
			this.overviewToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.overviewToolStripMenuItem.Text = "Overview";
			this.overviewToolStripMenuItem.Click += new System.EventHandler(this.overviewToolStripMenuItem_Click);
			// 
			// compareToolStripMenuItem
			// 
			this.compareToolStripMenuItem.Name = "compareToolStripMenuItem";
			this.compareToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.compareToolStripMenuItem.Text = "Compare";
			this.compareToolStripMenuItem.Click += new System.EventHandler(this.compareToolStripMenuItem_Click);
			// 
			// versusToolStripMenuItem
			// 
			this.versusToolStripMenuItem.Name = "versusToolStripMenuItem";
			this.versusToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.versusToolStripMenuItem.Text = "Versus";
			this.versusToolStripMenuItem.Click += new System.EventHandler(this.versusToolStripMenuItem_Click);
			// 
			// teamVersusToolStripMenuItem
			// 
			this.teamVersusToolStripMenuItem.Name = "teamVersusToolStripMenuItem";
			this.teamVersusToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.teamVersusToolStripMenuItem.Text = "Team Versus";
			this.teamVersusToolStripMenuItem.Click += new System.EventHandler(this.teamVersusToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// ExitButton
			// 
			this.ExitButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.ExitButton.BackColor = System.Drawing.Color.DarkGreen;
			this.ExitButton.BackgroundImage = global::LoL_Calculator.Images.OverviewBackground;
			this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ExitButton.ForeColor = System.Drawing.Color.SpringGreen;
			this.ExitButton.Location = new System.Drawing.Point(630, 12);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(200, 45);
			this.ExitButton.TabIndex = 8;
			this.ExitButton.Text = "Exit";
			this.ExitButton.UseVisualStyleBackColor = false;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.Green;
			this.BackgroundImage = global::LoL_Calculator.Images.MainMenuBackground;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(842, 523);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.VersusCalcButton);
			this.Controls.Add(this.VsTeamCalcButton);
			this.Controls.Add(this.ChampCompareButton);
			this.Controls.Add(this.ChampOverviewButton);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "League Calculator";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button ChampOverviewButton;
		private System.Windows.Forms.Button ChampCompareButton;
		private System.Windows.Forms.Button VsTeamCalcButton;
		private System.Windows.Forms.Button VersusCalcButton;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem openMenuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem compareToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem overviewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem versusToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem teamVersusToolStripMenuItem;
		private System.Windows.Forms.Button ExitButton;
	}
}

