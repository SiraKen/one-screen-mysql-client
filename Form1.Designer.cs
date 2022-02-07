
namespace OneScreenMySQLClient
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ConnectButton = new System.Windows.Forms.Button();
            this.HostnameLabel = new System.Windows.Forms.Label();
            this.MainDataGridView = new System.Windows.Forms.DataGridView();
            this.HostnameTextbox = new System.Windows.Forms.TextBox();
            this.PortTextbox = new System.Windows.Forms.TextBox();
            this.PortLabel = new System.Windows.Forms.Label();
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DatabaseNameTextbox = new System.Windows.Forms.TextBox();
            this.DatabaseNameLabel = new System.Windows.Forms.Label();
            this.QueryTextbox = new System.Windows.Forms.TextBox();
            this.QueryLabel = new System.Windows.Forms.Label();
            this.ExecuteQueryButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(70, 192);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 11;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // HostnameLabel
            // 
            this.HostnameLabel.AutoSize = true;
            this.HostnameLabel.Location = new System.Drawing.Point(21, 45);
            this.HostnameLabel.Name = "HostnameLabel";
            this.HostnameLabel.Size = new System.Drawing.Size(62, 15);
            this.HostnameLabel.TabIndex = 1;
            this.HostnameLabel.Text = "Hostname";
            // 
            // MainDataGridView
            // 
            this.MainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainDataGridView.Location = new System.Drawing.Point(12, 269);
            this.MainDataGridView.Name = "MainDataGridView";
            this.MainDataGridView.RowTemplate.Height = 25;
            this.MainDataGridView.Size = new System.Drawing.Size(966, 296);
            this.MainDataGridView.TabIndex = 12;
            // 
            // HostnameTextbox
            // 
            this.HostnameTextbox.Location = new System.Drawing.Point(123, 42);
            this.HostnameTextbox.Name = "HostnameTextbox";
            this.HostnameTextbox.Size = new System.Drawing.Size(100, 23);
            this.HostnameTextbox.TabIndex = 2;
            this.HostnameTextbox.Text = "localhost";
            // 
            // PortTextbox
            // 
            this.PortTextbox.Location = new System.Drawing.Point(123, 71);
            this.PortTextbox.Name = "PortTextbox";
            this.PortTextbox.Size = new System.Drawing.Size(100, 23);
            this.PortTextbox.TabIndex = 4;
            this.PortTextbox.Text = "3307";
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Location = new System.Drawing.Point(21, 74);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(29, 15);
            this.PortLabel.TabIndex = 3;
            this.PortLabel.Text = "Port";
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Location = new System.Drawing.Point(123, 100);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(100, 23);
            this.UsernameTextbox.TabIndex = 6;
            this.UsernameTextbox.Text = "example";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(21, 103);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(60, 15);
            this.UsernameLabel.TabIndex = 5;
            this.UsernameLabel.Text = "Username";
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Location = new System.Drawing.Point(123, 129);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.PasswordChar = '●';
            this.PasswordTextbox.Size = new System.Drawing.Size(100, 23);
            this.PasswordTextbox.TabIndex = 8;
            this.PasswordTextbox.Text = "example";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(21, 132);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(57, 15);
            this.PasswordLabel.TabIndex = 7;
            this.PasswordLabel.Text = "Password";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 568);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(990, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(990, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // DatabaseNameTextbox
            // 
            this.DatabaseNameTextbox.Location = new System.Drawing.Point(123, 158);
            this.DatabaseNameTextbox.Name = "DatabaseNameTextbox";
            this.DatabaseNameTextbox.Size = new System.Drawing.Size(100, 23);
            this.DatabaseNameTextbox.TabIndex = 10;
            this.DatabaseNameTextbox.Text = "example";
            // 
            // DatabaseNameLabel
            // 
            this.DatabaseNameLabel.AutoSize = true;
            this.DatabaseNameLabel.Location = new System.Drawing.Point(21, 161);
            this.DatabaseNameLabel.Name = "DatabaseNameLabel";
            this.DatabaseNameLabel.Size = new System.Drawing.Size(55, 15);
            this.DatabaseNameLabel.TabIndex = 9;
            this.DatabaseNameLabel.Text = "Database";
            // 
            // QueryTextbox
            // 
            this.QueryTextbox.Location = new System.Drawing.Point(443, 88);
            this.QueryTextbox.Multiline = true;
            this.QueryTextbox.Name = "QueryTextbox";
            this.QueryTextbox.Size = new System.Drawing.Size(387, 88);
            this.QueryTextbox.TabIndex = 13;
            // 
            // QueryLabel
            // 
            this.QueryLabel.AutoSize = true;
            this.QueryLabel.Location = new System.Drawing.Point(443, 67);
            this.QueryLabel.Name = "QueryLabel";
            this.QueryLabel.Size = new System.Drawing.Size(39, 15);
            this.QueryLabel.TabIndex = 14;
            this.QueryLabel.Text = "Query";
            // 
            // ExecuteQueryButton
            // 
            this.ExecuteQueryButton.Location = new System.Drawing.Point(443, 183);
            this.ExecuteQueryButton.Name = "ExecuteQueryButton";
            this.ExecuteQueryButton.Size = new System.Drawing.Size(75, 23);
            this.ExecuteQueryButton.TabIndex = 15;
            this.ExecuteQueryButton.Text = "Execute";
            this.ExecuteQueryButton.UseVisualStyleBackColor = true;
            this.ExecuteQueryButton.Click += new System.EventHandler(this.ExecuteQueryButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 590);
            this.Controls.Add(this.ExecuteQueryButton);
            this.Controls.Add(this.QueryLabel);
            this.Controls.Add(this.QueryTextbox);
            this.Controls.Add(this.DatabaseNameTextbox);
            this.Controls.Add(this.DatabaseNameLabel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.UsernameTextbox);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PortTextbox);
            this.Controls.Add(this.PortLabel);
            this.Controls.Add(this.HostnameTextbox);
            this.Controls.Add(this.MainDataGridView);
            this.Controls.Add(this.HostnameLabel);
            this.Controls.Add(this.ConnectButton);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "OneScreenMySQLClient";
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Label HostnameLabel;
        private System.Windows.Forms.DataGridView MainDataGridView;
        private System.Windows.Forms.TextBox HostnameTextbox;
        private System.Windows.Forms.TextBox PortTextbox;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.TextBox UsernameTextbox;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.TextBox DatabaseNameTextbox;
        private System.Windows.Forms.Label DatabaseNameLabel;
        private System.Windows.Forms.TextBox QueryTextbox;
        private System.Windows.Forms.Label QueryLabel;
        private System.Windows.Forms.Button ExecuteQueryButton;
    }
}

