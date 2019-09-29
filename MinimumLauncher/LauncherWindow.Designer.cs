namespace MinimumLauncher
{
	// Token: 0x02000002 RID: 2
	public partial class LauncherWindow : System.Windows.Forms.Form
	{
		// Token: 0x0400000B RID: 11
		private System.ComponentModel.IContainer components = null;
		
		// Token: 0x06000019 RID: 25 RVA: 0x0000353E File Offset: 0x0000173E
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00003560 File Offset: 0x00001760
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LauncherWindow));
			this.bSelectedMapList = new System.Windows.Forms.ListBox();
			this.MC_ClearCycleBtn = new System.Windows.Forms.Button();
			this.bMapListing = new System.Windows.Forms.ListBox();
			this.bPort = new System.Windows.Forms.TextBox();
			this.bQueryPort = new System.Windows.Forms.TextBox();
			this.bSessionPort = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.bLaunchServer = new System.Windows.Forms.Button();
			this.MapType = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.PreferredGameMode = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.MapCyclePanel = new System.Windows.Forms.Panel();
			this.ServerType = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.SettingsPanel = new System.Windows.Forms.Panel();
			this.PasswordTB = new System.Windows.Forms.TextBox();
			this.ServerNameTB = new System.Windows.Forms.TextBox();
			this.MOTDTB = new System.Windows.Forms.TextBox();
			this.BotDifficulty = new System.Windows.Forms.ComboBox();
			this.TimeTB = new System.Windows.Forms.TextBox();
			this.ScoreTB = new System.Windows.Forms.TextBox();
			this.PlayersTB = new System.Windows.Forms.TextBox();
			this.bBots = new System.Windows.Forms.CheckBox();
			this.bWarmUp = new System.Windows.Forms.CheckBox();
			this.bBalance = new System.Windows.Forms.CheckBox();
			this.bFF = new System.Windows.Forms.CheckBox();
			this.label18 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.MapCyclePanel.SuspendLayout();
			this.SettingsPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// bSelectedMapList
			// 
			this.bSelectedMapList.FormattingEnabled = true;
			this.bSelectedMapList.Location = new System.Drawing.Point(175, 19);
			this.bSelectedMapList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.bSelectedMapList.Name = "bSelectedMapList";
			this.bSelectedMapList.Size = new System.Drawing.Size(136, 186);
			this.bSelectedMapList.TabIndex = 1;
			// 
			// MC_ClearCycleBtn
			// 
			this.MC_ClearCycleBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.MC_ClearCycleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MC_ClearCycleBtn.Location = new System.Drawing.Point(181, 219);
			this.MC_ClearCycleBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.MC_ClearCycleBtn.Name = "MC_ClearCycleBtn";
			this.MC_ClearCycleBtn.Size = new System.Drawing.Size(139, 22);
			this.MC_ClearCycleBtn.TabIndex = 2;
			this.MC_ClearCycleBtn.Text = "Clear Map Cycle";
			this.MC_ClearCycleBtn.UseVisualStyleBackColor = false;
			this.MC_ClearCycleBtn.Click += new System.EventHandler(this.bClearCycle_Click);
			// 
			// bMapListing
			// 
			this.bMapListing.FormattingEnabled = true;
			this.bMapListing.Location = new System.Drawing.Point(22, 19);
			this.bMapListing.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.bMapListing.Name = "bMapListing";
			this.bMapListing.Size = new System.Drawing.Size(136, 186);
			this.bMapListing.TabIndex = 3;
			this.bMapListing.SelectedIndexChanged += new System.EventHandler(this.bMapListing_SelectedIndexChanged);
			// 
			// bPort
			// 
			this.bPort.Location = new System.Drawing.Point(36, 337);
			this.bPort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.bPort.MaxLength = 5;
			this.bPort.Name = "bPort";
			this.bPort.Size = new System.Drawing.Size(69, 20);
			this.bPort.TabIndex = 5;
			this.bPort.Text = "7777";
			this.bPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// bQueryPort
			// 
			this.bQueryPort.Location = new System.Drawing.Point(109, 337);
			this.bQueryPort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.bQueryPort.MaxLength = 5;
			this.bQueryPort.Name = "bQueryPort";
			this.bQueryPort.Size = new System.Drawing.Size(69, 20);
			this.bQueryPort.TabIndex = 6;
			this.bQueryPort.Text = "27015";
			this.bQueryPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// bSessionPort
			// 
			this.bSessionPort.Location = new System.Drawing.Point(182, 337);
			this.bSessionPort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.bSessionPort.MaxLength = 5;
			this.bSessionPort.Name = "bSessionPort";
			this.bSessionPort.Size = new System.Drawing.Size(69, 20);
			this.bSessionPort.TabIndex = 7;
			this.bSessionPort.Text = "8101";
			this.bSessionPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(38, 321);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Listen Port";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(110, 321);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "Steam Port";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(184, 321);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Game Port";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(19, 4);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(99, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "Supported Maps";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(175, 3);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(66, 13);
			this.label5.TabIndex = 12;
			this.label5.Text = "Map Cycle";
			// 
			// bLaunchServer
			// 
			this.bLaunchServer.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.bLaunchServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bLaunchServer.Location = new System.Drawing.Point(303, 283);
			this.bLaunchServer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.bLaunchServer.Name = "bLaunchServer";
			this.bLaunchServer.Size = new System.Drawing.Size(311, 52);
			this.bLaunchServer.TabIndex = 13;
			this.bLaunchServer.Text = "Launch Server";
			this.bLaunchServer.UseVisualStyleBackColor = false;
			this.bLaunchServer.Click += new System.EventHandler(this.bLaunchServer_Click);
			// 
			// MapType
			// 
			this.MapType.AutoSize = true;
			this.MapType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MapType.Location = new System.Drawing.Point(5, 224);
			this.MapType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.MapType.Name = "MapType";
			this.MapType.Size = new System.Drawing.Size(43, 13);
			this.MapType.TabIndex = 14;
			this.MapType.Text = "Type: ";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(4, 271);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(134, 13);
			this.label6.TabIndex = 15;
			this.label6.Text = "Preferred Game Mode:";
			// 
			// PreferredGameMode
			// 
			this.PreferredGameMode.BackColor = System.Drawing.SystemColors.Menu;
			this.PreferredGameMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.PreferredGameMode.FormattingEnabled = true;
			this.PreferredGameMode.Location = new System.Drawing.Point(143, 271);
			this.PreferredGameMode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.PreferredGameMode.Name = "PreferredGameMode";
			this.PreferredGameMode.Size = new System.Drawing.Size(140, 21);
			this.PreferredGameMode.TabIndex = 17;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(4, 5);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(84, 13);
			this.label7.TabIndex = 18;
			this.label7.Text = "Server Name:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(4, 28);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(47, 13);
			this.label8.TabIndex = 19;
			this.label8.Text = "MOTD:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(2, 80);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(103, 13);
			this.label9.TabIndex = 20;
			this.label9.Text = "Admin Password:";
			// 
			// MapCyclePanel
			// 
			this.MapCyclePanel.Controls.Add(this.label3);
			this.MapCyclePanel.Controls.Add(this.bSelectedMapList);
			this.MapCyclePanel.Controls.Add(this.MC_ClearCycleBtn);
			this.MapCyclePanel.Controls.Add(this.MapType);
			this.MapCyclePanel.Controls.Add(this.bMapListing);
			this.MapCyclePanel.Controls.Add(this.label5);
			this.MapCyclePanel.Location = new System.Drawing.Point(294, 1);
			this.MapCyclePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.MapCyclePanel.Name = "MapCyclePanel";
			this.MapCyclePanel.Size = new System.Drawing.Size(331, 248);
			this.MapCyclePanel.TabIndex = 21;
			// 
			// ServerType
			// 
			this.ServerType.BackColor = System.Drawing.SystemColors.Menu;
			this.ServerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ServerType.FormattingEnabled = true;
			this.ServerType.Location = new System.Drawing.Point(143, 296);
			this.ServerType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ServerType.Name = "ServerType";
			this.ServerType.Size = new System.Drawing.Size(140, 21);
			this.ServerType.TabIndex = 19;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(4, 296);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(80, 13);
			this.label10.TabIndex = 18;
			this.label10.Text = "Server Type:";
			// 
			// SettingsPanel
			// 
			this.SettingsPanel.Controls.Add(this.PasswordTB);
			this.SettingsPanel.Controls.Add(this.ServerType);
			this.SettingsPanel.Controls.Add(this.ServerNameTB);
			this.SettingsPanel.Controls.Add(this.MOTDTB);
			this.SettingsPanel.Controls.Add(this.BotDifficulty);
			this.SettingsPanel.Controls.Add(this.label10);
			this.SettingsPanel.Controls.Add(this.TimeTB);
			this.SettingsPanel.Controls.Add(this.ScoreTB);
			this.SettingsPanel.Controls.Add(this.label9);
			this.SettingsPanel.Controls.Add(this.label4);
			this.SettingsPanel.Controls.Add(this.PlayersTB);
			this.SettingsPanel.Controls.Add(this.bSessionPort);
			this.SettingsPanel.Controls.Add(this.label8);
			this.SettingsPanel.Controls.Add(this.label6);
			this.SettingsPanel.Controls.Add(this.bBots);
			this.SettingsPanel.Controls.Add(this.label2);
			this.SettingsPanel.Controls.Add(this.label7);
			this.SettingsPanel.Controls.Add(this.bQueryPort);
			this.SettingsPanel.Controls.Add(this.bWarmUp);
			this.SettingsPanel.Controls.Add(this.bPort);
			this.SettingsPanel.Controls.Add(this.bBalance);
			this.SettingsPanel.Controls.Add(this.label1);
			this.SettingsPanel.Controls.Add(this.bFF);
			this.SettingsPanel.Controls.Add(this.PreferredGameMode);
			this.SettingsPanel.Controls.Add(this.label18);
			this.SettingsPanel.Controls.Add(this.label17);
			this.SettingsPanel.Controls.Add(this.label16);
			this.SettingsPanel.Controls.Add(this.label15);
			this.SettingsPanel.Controls.Add(this.label14);
			this.SettingsPanel.Controls.Add(this.label13);
			this.SettingsPanel.Controls.Add(this.label12);
			this.SettingsPanel.Controls.Add(this.label11);
			this.SettingsPanel.Location = new System.Drawing.Point(0, 1);
			this.SettingsPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.SettingsPanel.Name = "SettingsPanel";
			this.SettingsPanel.Size = new System.Drawing.Size(287, 359);
			this.SettingsPanel.TabIndex = 23;
			// 
			// PasswordTB
			// 
			this.PasswordTB.Location = new System.Drawing.Point(143, 80);
			this.PasswordTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.PasswordTB.MaxLength = 30;
			this.PasswordTB.Name = "PasswordTB";
			this.PasswordTB.Size = new System.Drawing.Size(140, 20);
			this.PasswordTB.TabIndex = 23;
			this.PasswordTB.UseSystemPasswordChar = true;
			// 
			// ServerNameTB
			// 
			this.ServerNameTB.Location = new System.Drawing.Point(143, 5);
			this.ServerNameTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ServerNameTB.MaxLength = 50;
			this.ServerNameTB.Name = "ServerNameTB";
			this.ServerNameTB.Size = new System.Drawing.Size(140, 20);
			this.ServerNameTB.TabIndex = 22;
			// 
			// MOTDTB
			// 
			this.MOTDTB.AcceptsReturn = true;
			this.MOTDTB.Location = new System.Drawing.Point(51, 28);
			this.MOTDTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.MOTDTB.MaxLength = 200;
			this.MOTDTB.Multiline = true;
			this.MOTDTB.Name = "MOTDTB";
			this.MOTDTB.Size = new System.Drawing.Size(232, 48);
			this.MOTDTB.TabIndex = 21;
			// 
			// BotDifficulty
			// 
			this.BotDifficulty.BackColor = System.Drawing.SystemColors.Menu;
			this.BotDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.BotDifficulty.FormattingEnabled = true;
			this.BotDifficulty.Location = new System.Drawing.Point(143, 247);
			this.BotDifficulty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.BotDifficulty.Name = "BotDifficulty";
			this.BotDifficulty.Size = new System.Drawing.Size(140, 21);
			this.BotDifficulty.TabIndex = 20;
			// 
			// TimeTB
			// 
			this.TimeTB.Location = new System.Drawing.Point(143, 147);
			this.TimeTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.TimeTB.MaxLength = 2;
			this.TimeTB.Name = "TimeTB";
			this.TimeTB.Size = new System.Drawing.Size(52, 20);
			this.TimeTB.TabIndex = 14;
			this.TimeTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.TimeTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitOnlyOnKeyPress);
			// 
			// ScoreTB
			// 
			this.ScoreTB.Location = new System.Drawing.Point(143, 125);
			this.ScoreTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ScoreTB.MaxLength = 2;
			this.ScoreTB.Name = "ScoreTB";
			this.ScoreTB.Size = new System.Drawing.Size(52, 20);
			this.ScoreTB.TabIndex = 13;
			this.ScoreTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ScoreTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitOnlyOnKeyPress);
			// 
			// PlayersTB
			// 
			this.PlayersTB.Location = new System.Drawing.Point(143, 102);
			this.PlayersTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.PlayersTB.MaxLength = 2;
			this.PlayersTB.Name = "PlayersTB";
			this.PlayersTB.Size = new System.Drawing.Size(52, 20);
			this.PlayersTB.TabIndex = 12;
			this.PlayersTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.PlayersTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitOnlyOnKeyPress);
			// 
			// bBots
			// 
			this.bBots.AutoSize = true;
			this.bBots.Location = new System.Drawing.Point(143, 228);
			this.bBots.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.bBots.Name = "bBots";
			this.bBots.Size = new System.Drawing.Size(15, 14);
			this.bBots.TabIndex = 11;
			this.bBots.UseVisualStyleBackColor = true;
			// 
			// bWarmUp
			// 
			this.bWarmUp.AutoSize = true;
			this.bWarmUp.Location = new System.Drawing.Point(143, 210);
			this.bWarmUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.bWarmUp.Name = "bWarmUp";
			this.bWarmUp.Size = new System.Drawing.Size(15, 14);
			this.bWarmUp.TabIndex = 10;
			this.bWarmUp.UseVisualStyleBackColor = true;
			// 
			// bBalance
			// 
			this.bBalance.AutoSize = true;
			this.bBalance.Location = new System.Drawing.Point(143, 191);
			this.bBalance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.bBalance.Name = "bBalance";
			this.bBalance.Size = new System.Drawing.Size(15, 14);
			this.bBalance.TabIndex = 9;
			this.bBalance.UseVisualStyleBackColor = true;
			// 
			// bFF
			// 
			this.bFF.AutoSize = true;
			this.bFF.Location = new System.Drawing.Point(143, 171);
			this.bFF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.bFF.Name = "bFF";
			this.bFF.Size = new System.Drawing.Size(15, 14);
			this.bFF.TabIndex = 8;
			this.bFF.UseVisualStyleBackColor = true;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.Location = new System.Drawing.Point(3, 171);
			this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(80, 13);
			this.label18.TabIndex = 7;
			this.label18.Text = "Friendly Fire:";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(2, 148);
			this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(106, 13);
			this.label17.TabIndex = 6;
			this.label17.Text = "Time Limit: (Mins)";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(4, 125);
			this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(74, 13);
			this.label16.TabIndex = 5;
			this.label16.Text = "Goal Score:";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(4, 247);
			this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(84, 13);
			this.label15.TabIndex = 4;
			this.label15.Text = "Bot Difficulty:";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(4, 228);
			this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(84, 13);
			this.label14.TabIndex = 3;
			this.label14.Text = "Bots Allowed:";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(3, 105);
			this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(79, 13);
			this.label13.TabIndex = 2;
			this.label13.Text = "Max Players:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(4, 210);
			this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(98, 13);
			this.label12.TabIndex = 1;
			this.label12.Text = "Warm Up Mode:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(4, 191);
			this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(128, 13);
			this.label11.TabIndex = 0;
			this.label11.Text = "Auto Balance Teams:";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(334, 251);
			this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(234, 13);
			this.label19.TabIndex = 24;
			this.label19.Text = "*Use of UserGame.ini will overwrite these values";
			// 
			// LauncherWindow
			// 
			this.AcceptButton = this.bLaunchServer;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(625, 363);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.SettingsPanel);
			this.Controls.Add(this.MapCyclePanel);
			this.Controls.Add(this.bLaunchServer);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LauncherWindow";
			this.Text = "Minimum Server Launcher";
			this.MapCyclePanel.ResumeLayout(false);
			this.MapCyclePanel.PerformLayout();
			this.SettingsPanel.ResumeLayout(false);
			this.SettingsPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		// Token: 0x0400000C RID: 12
		public System.Windows.Forms.ListBox bSelectedMapList;

		// Token: 0x0400000D RID: 13
		public System.Windows.Forms.Button MC_ClearCycleBtn;

		// Token: 0x0400000E RID: 14
		public System.Windows.Forms.ListBox bMapListing;

		// Token: 0x0400000F RID: 15
		public System.Windows.Forms.TextBox bPort;

		// Token: 0x04000010 RID: 16
		public System.Windows.Forms.TextBox bQueryPort;

		// Token: 0x04000011 RID: 17
		public System.Windows.Forms.TextBox bSessionPort;

		// Token: 0x04000012 RID: 18
		public System.Windows.Forms.Label label1;

		// Token: 0x04000013 RID: 19
		public System.Windows.Forms.Label label2;

		// Token: 0x04000014 RID: 20
		public System.Windows.Forms.Label label4;

		// Token: 0x04000015 RID: 21
		public System.Windows.Forms.Label label3;

		// Token: 0x04000016 RID: 22
		public System.Windows.Forms.Label label5;

		// Token: 0x04000017 RID: 23
		public System.Windows.Forms.Button bLaunchServer;

		// Token: 0x04000018 RID: 24
		private System.Windows.Forms.Label MapType;

		// Token: 0x04000019 RID: 25
		private System.Windows.Forms.Label label6;

		// Token: 0x0400001A RID: 26
		private System.Windows.Forms.ComboBox PreferredGameMode;

		// Token: 0x0400001B RID: 27
		private System.Windows.Forms.Label label7;

		// Token: 0x0400001C RID: 28
		private System.Windows.Forms.Label label8;

		// Token: 0x0400001D RID: 29
		private System.Windows.Forms.Label label9;

		// Token: 0x0400001E RID: 30
		private System.Windows.Forms.Panel MapCyclePanel;

		// Token: 0x0400001F RID: 31
		private System.Windows.Forms.ComboBox ServerType;

		// Token: 0x04000020 RID: 32
		private System.Windows.Forms.Label label10;

		// Token: 0x04000021 RID: 33
		private System.Windows.Forms.Panel SettingsPanel;

		// Token: 0x04000022 RID: 34
		private System.Windows.Forms.Label label16;

		// Token: 0x04000023 RID: 35
		private System.Windows.Forms.Label label15;

		// Token: 0x04000024 RID: 36
		private System.Windows.Forms.Label label14;

		// Token: 0x04000025 RID: 37
		private System.Windows.Forms.Label label13;

		// Token: 0x04000026 RID: 38
		private System.Windows.Forms.Label label12;

		// Token: 0x04000027 RID: 39
		private System.Windows.Forms.Label label11;

		// Token: 0x04000028 RID: 40
		private System.Windows.Forms.Label label18;

		// Token: 0x04000029 RID: 41
		private System.Windows.Forms.Label label17;

		// Token: 0x0400002A RID: 42
		private System.Windows.Forms.CheckBox bFF;

		// Token: 0x0400002B RID: 43
		private System.Windows.Forms.TextBox MOTDTB;

		// Token: 0x0400002C RID: 44
		private System.Windows.Forms.ComboBox BotDifficulty;

		// Token: 0x0400002D RID: 45
		private System.Windows.Forms.TextBox TimeTB;

		// Token: 0x0400002E RID: 46
		private System.Windows.Forms.TextBox ScoreTB;

		// Token: 0x0400002F RID: 47
		private System.Windows.Forms.TextBox PlayersTB;

		// Token: 0x04000030 RID: 48
		private System.Windows.Forms.CheckBox bBots;

		// Token: 0x04000031 RID: 49
		private System.Windows.Forms.CheckBox bWarmUp;

		// Token: 0x04000032 RID: 50
		private System.Windows.Forms.CheckBox bBalance;

		// Token: 0x04000033 RID: 51
		private System.Windows.Forms.TextBox PasswordTB;

		// Token: 0x04000034 RID: 52
		private System.Windows.Forms.TextBox ServerNameTB;

		// Token: 0x04000035 RID: 53
		private System.Windows.Forms.Label label19;
	}
}
