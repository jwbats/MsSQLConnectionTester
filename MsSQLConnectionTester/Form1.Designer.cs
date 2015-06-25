namespace MsSQLConnectionTester
{
	partial class Form1
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
			this.lblDataSource = new System.Windows.Forms.Label();
			this.tbDataSource = new System.Windows.Forms.TextBox();
			this.tbInitialCatalog = new System.Windows.Forms.TextBox();
			this.lblInitialCatalog = new System.Windows.Forms.Label();
			this.tbUserId = new System.Windows.Forms.TextBox();
			this.lblUserId = new System.Windows.Forms.Label();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.lblPassword = new System.Windows.Forms.Label();
			this.btnTestConnection = new System.Windows.Forms.Button();
			this.tbOutput = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblDataSource
			// 
			this.lblDataSource.AutoSize = true;
			this.lblDataSource.Location = new System.Drawing.Point(12, 15);
			this.lblDataSource.Name = "lblDataSource";
			this.lblDataSource.Size = new System.Drawing.Size(70, 13);
			this.lblDataSource.TabIndex = 0;
			this.lblDataSource.Text = "Data Source:";
			// 
			// tbDataSource
			// 
			this.tbDataSource.Location = new System.Drawing.Point(88, 12);
			this.tbDataSource.Name = "tbDataSource";
			this.tbDataSource.Size = new System.Drawing.Size(261, 20);
			this.tbDataSource.TabIndex = 1;
			// 
			// tbInitialCatalog
			// 
			this.tbInitialCatalog.Location = new System.Drawing.Point(88, 38);
			this.tbInitialCatalog.Name = "tbInitialCatalog";
			this.tbInitialCatalog.Size = new System.Drawing.Size(261, 20);
			this.tbInitialCatalog.TabIndex = 3;
			// 
			// lblInitialCatalog
			// 
			this.lblInitialCatalog.AutoSize = true;
			this.lblInitialCatalog.Location = new System.Drawing.Point(12, 41);
			this.lblInitialCatalog.Name = "lblInitialCatalog";
			this.lblInitialCatalog.Size = new System.Drawing.Size(73, 13);
			this.lblInitialCatalog.TabIndex = 2;
			this.lblInitialCatalog.Text = "Initial Catalog:";
			// 
			// tbUserId
			// 
			this.tbUserId.Location = new System.Drawing.Point(88, 64);
			this.tbUserId.Name = "tbUserId";
			this.tbUserId.Size = new System.Drawing.Size(261, 20);
			this.tbUserId.TabIndex = 5;
			// 
			// lblUserId
			// 
			this.lblUserId.AutoSize = true;
			this.lblUserId.Location = new System.Drawing.Point(12, 67);
			this.lblUserId.Name = "lblUserId";
			this.lblUserId.Size = new System.Drawing.Size(44, 13);
			this.lblUserId.TabIndex = 4;
			this.lblUserId.Text = "User Id:";
			// 
			// tbPassword
			// 
			this.tbPassword.Location = new System.Drawing.Point(88, 90);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.Size = new System.Drawing.Size(261, 20);
			this.tbPassword.TabIndex = 7;
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new System.Drawing.Point(12, 93);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(56, 13);
			this.lblPassword.TabIndex = 6;
			this.lblPassword.Text = "Password:";
			// 
			// btnTestConnection
			// 
			this.btnTestConnection.Location = new System.Drawing.Point(15, 116);
			this.btnTestConnection.Name = "btnTestConnection";
			this.btnTestConnection.Size = new System.Drawing.Size(334, 23);
			this.btnTestConnection.TabIndex = 8;
			this.btnTestConnection.Text = "Test Connection";
			this.btnTestConnection.UseVisualStyleBackColor = true;
			this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
			// 
			// tbOutput
			// 
			this.tbOutput.Location = new System.Drawing.Point(15, 145);
			this.tbOutput.Multiline = true;
			this.tbOutput.Name = "tbOutput";
			this.tbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbOutput.Size = new System.Drawing.Size(334, 346);
			this.tbOutput.TabIndex = 9;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(368, 503);
			this.Controls.Add(this.tbOutput);
			this.Controls.Add(this.btnTestConnection);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.tbUserId);
			this.Controls.Add(this.lblUserId);
			this.Controls.Add(this.tbInitialCatalog);
			this.Controls.Add(this.lblInitialCatalog);
			this.Controls.Add(this.tbDataSource);
			this.Controls.Add(this.lblDataSource);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MsSQL Connection Tester";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblDataSource;
		private System.Windows.Forms.TextBox tbDataSource;
		private System.Windows.Forms.TextBox tbInitialCatalog;
		private System.Windows.Forms.Label lblInitialCatalog;
		private System.Windows.Forms.TextBox tbUserId;
		private System.Windows.Forms.Label lblUserId;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Button btnTestConnection;
		private System.Windows.Forms.TextBox tbOutput;
	}
}

