using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace MinimumLauncher
{
	// Token: 0x02000002 RID: 2
	public partial class LauncherWindow : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public LauncherWindow()
		{
			this.MapNames = new LauncherWindow.Info[10];
			this.MapNames[0].RealName = "CIT01_Base.tgm";
			this.MapNames[0].FriendlyName = "Courtyard";
			this.MapNames[0].Type = 0;
			this.MapNames[1].RealName = "CIT03_base.tgm";
			this.MapNames[1].FriendlyName = "Disaster Zone";
			this.MapNames[1].Type = 1;
			this.MapNames[2].RealName = "DES01_Base.tgm";
			this.MapNames[2].FriendlyName = "Canyon";
			this.MapNames[2].Type = 1;
			this.MapNames[3].RealName = "IND04_Base.tgm";
			this.MapNames[3].FriendlyName = "Recyclotron";
			this.MapNames[3].Type = 0;
			this.MapNames[4].RealName = "JUN03_Base.tgm";
			this.MapNames[4].FriendlyName = "Altar of the Ancients";
			this.MapNames[4].Type = 0;
			this.MapNames[5].RealName = "SPA01_Base.tgm";
			this.MapNames[5].FriendlyName = "Space Station";
			this.MapNames[5].Type = 0;
			this.MapNames[6].RealName = "TER01_Base.tgm";
			this.MapNames[6].FriendlyName = "Zen Garden";
			this.MapNames[6].Type = 0;
			this.MapNames[7].RealName = "TER03_base.tgm";
			this.MapNames[7].FriendlyName = "Path of Lanterns";
			this.MapNames[7].Type = 1;
			this.MapNames[8].RealName = "IND01_Base.tgm";
			this.MapNames[8].FriendlyName = "Factory 03";
			this.MapNames[8].Type = 1;
			this.MapNames[9].RealName = "JUN04_Base.tgm";
			this.MapNames[9].FriendlyName = "Primeval Mist";
			this.MapNames[9].Type = 1;
			this.GameModes = new LauncherWindow.Info[3];
			this.GameModes[0].RealName = "MinGameModeTGM";
			this.GameModes[0].FriendlyName = "Team Death Match";
			this.GameModes[1].RealName = "MinGameModeTitan";
			this.GameModes[1].FriendlyName = "Titan";
			this.GameModes[2].RealName = "MinGameModeDC";
			this.GameModes[2].FriendlyName = "Horde";
			this.BotDifficulties = new string[5];
			this.BotDifficulties[0] = "Trivial";
			this.BotDifficulties[1] = "Easy";
			this.BotDifficulties[2] = "Medium";
			this.BotDifficulties[3] = "Hard";
			this.BotDifficulties[4] = "Insane";
			this.ServerTypes = new string[3];
			this.ServerTypes[0] = "Dedicated";
			this.ServerTypes[1] = "Listen";
			this.ServerTypes[2] = "Lan";
			this.InitializeComponent();
			if (!this.TryOpenFile())
			{
				this.CreateNewFile();
			}
			this.InitializeInfo();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000023D0 File Offset: 0x000005D0
		private bool TryOpenFile()
		{
			bool flag = File.Exists(this.SAVEFILE);
			Debug.WriteLine("TryOpenFile: " + flag);
			return flag;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002400 File Offset: 0x00000600
		private void CreateNewFile()
		{
			Debug.WriteLine("Create New File Called");
			using (StreamWriter streamWriter = new StreamWriter(this.SAVEFILE))
			{
				streamWriter.WriteLine("[Server Settings]");
				streamWriter.WriteLine("ServerName=");
				streamWriter.WriteLine("MOTD=");
				streamWriter.WriteLine("AdminPassword=");
				streamWriter.WriteLine("MaxPlayers=8");
				streamWriter.WriteLine("GoalLimit=50");
				streamWriter.WriteLine("TimeLimit=10");
				streamWriter.WriteLine("FF=False");
				streamWriter.WriteLine("AutoBalance=True");
				streamWriter.WriteLine("WarmUpMode=False");
				streamWriter.WriteLine("BotsAllowed=True");
				streamWriter.WriteLine("BotDifficulty=2");
				streamWriter.WriteLine("GameMode=0");
				streamWriter.WriteLine("ServerType=0");
				streamWriter.WriteLine("Port=7777");
				streamWriter.WriteLine("QueryPort=27015");
				streamWriter.WriteLine("SessionPort=8105");
				streamWriter.WriteLine("");
				streamWriter.WriteLine("[AvailiableMaps]");
				for (int i = 0; i < this.MapNames.Length; i++)
				{
					if (this.MapNames[i].RealName != "")
					{
						streamWriter.WriteLine(this.MapNames[i].FriendlyName);
					}
				}
				streamWriter.WriteLine("[AvailiableMapRealNames]");
				for (int i = 0; i < this.MapNames.Length; i++)
				{
					if (this.MapNames[i].FriendlyName != "")
					{
						streamWriter.WriteLine(this.MapNames[i].RealName);
					}
				}
				streamWriter.WriteLine("[AvailiableMapTypeInts]");
				for (int i = 0; i < this.MapNames.Length; i++)
				{
					if (this.MapNames[i].RealName != "")
					{
						streamWriter.WriteLine(this.MapNames[i].Type);
					}
				}
				streamWriter.WriteLine("");
				streamWriter.WriteLine("[Map Cycle]");
				if (this.MapNames.Length > 0 && this.MapNames[0].FriendlyName != "")
				{
					streamWriter.WriteLine(this.MapNames[0].FriendlyName);
				}
				streamWriter.WriteLine("");
				streamWriter.Close();
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000025CC File Offset: 0x000007CC
		private void LoadFiles()
		{
			this.LoadedSaveFile = new List<string>();
			this.LoadedIniFile = new List<string>();
			using (StreamReader streamReader = new StreamReader(this.SAVEFILE))
			{
				string item;
				while ((item = streamReader.ReadLine()) != null)
				{
					this.LoadedSaveFile.Add(item);
				}
			}
			Console.WriteLine("Loadedsavefile " + this.LoadedSaveFile.Count);
			if (this.GetConfigPath() != "")
			{
				foreach (string item2 in File.ReadAllLines(this.CONFIGFILE))
				{
					this.LoadedIniFile.Add(item2);
				}
			}
			Console.WriteLine("LoadedInifile " + this.LoadedIniFile.Count);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000026B4 File Offset: 0x000008B4
		private void InitializeInfo()
		{
			this.LoadFiles();
			this.PreferredGameMode.Items.Add(this.GameModes[0].FriendlyName);
			this.PreferredGameMode.Items.Add(this.GameModes[1].FriendlyName);
			this.PreferredGameMode.Items.Add(this.GameModes[2].FriendlyName);
			this.BotDifficulty.Items.AddRange(this.BotDifficulties);
			this.ServerType.Items.AddRange(this.ServerTypes);
			this.ServerNameTB.Text = this.GetStringFromFile("ServerName");
			this.MOTDTB.Text = this.GetStringFromFile("MOTD");
			this.PasswordTB.Text = this.GetStringFromFile("AdminPassword");
			this.bFF.Checked = this.GetBoolFromFile("FF");
			this.PlayersTB.Text = this.GetStringFromFile("MaxPlayers");
			this.ScoreTB.Text = this.GetStringFromFile("GoalLimit");
			this.TimeTB.Text = this.GetStringFromFile("TimeLimit");
			this.bBalance.Checked = this.GetBoolFromFile("AutoBalance");
			this.bWarmUp.Checked = this.GetBoolFromFile("WarmUpMode");
			this.bBots.Checked = this.GetBoolFromFile("BotsAllowed");
			this.BotDifficulty.SelectedIndex = this.GetIntFromFile("BotDifficulty");
			this.PreferredGameMode.SelectedIndex = this.GetIntFromFile("GameMode");
			this.ServerType.SelectedIndex = this.GetIntFromFile("ServerType");
			this.bPort.Text = this.GetStringFromFile("Port");
			this.bQueryPort.Text = this.GetStringFromFile("QueryPort");
			this.bSessionPort.Text = this.GetStringFromFile("SessionPort");
			this.AddAllToListBox(this.bMapListing, "[AvailiableMaps]", 0);
			this.AddAllToListBox(this.bSelectedMapList, "[Map Cycle]", 0);
			this.LastHoverIndex = -1;
			this.bMapListing.MouseMove += new MouseEventHandler(this.MapListing_MouseHover);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000028FC File Offset: 0x00000AFC
		private string GetStringFromFile(string ConfigValue)
		{
			string text = "";
			int num = this.GetIndex(ConfigValue);
			if (num > 0)
			{
				text = this.LoadedSaveFile[num];
				text.Trim();
				num = text.IndexOf("=") + 1;
				if (num < text.Length)
				{
					text = text.Substring(num);
				}
				else
				{
					text = "";
				}
			}
			return text;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002958 File Offset: 0x00000B58
		private int GetIndex(string value)
		{
			for (int i = 0; i < this.LoadedSaveFile.Count; i++)
			{
				if (this.LoadedSaveFile[i].Contains(value))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002994 File Offset: 0x00000B94
		private void SetStringToFile(string OurString, string Value)
		{
			int index = this.GetIndex(OurString);
			if (index > 0)
			{
				this.LoadedSaveFile[index] = OurString + "=" + Value;
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000029C5 File Offset: 0x00000BC5
		private bool GetBoolFromFile(string ConfigValue)
		{
			return this.GetStringFromFile(ConfigValue).ToUpper() == "TRUE";
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000029E0 File Offset: 0x00000BE0
		private int GetIntFromFile(string ConfigValue)
		{
			string stringFromFile = this.GetStringFromFile(ConfigValue);
			int result;
			if (stringFromFile != "" && int.TryParse(stringFromFile, out result))
			{
				return result;
			}
			return 0;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002A28 File Offset: 0x00000C28
		private void AddAllToListBox(ListBox OurBox, string ConfigValue, int EndTrim = 0)
		{
			int num = this.LoadedSaveFile.FindIndex((string item) => item == ConfigValue);
			if (num != -1)
			{
				for (int i = num + 1; i < this.LoadedSaveFile.Count; i++)
				{
					string text = this.LoadedSaveFile[i];
					if (text.Contains("["))
					{
						break;
					}
					if (text.Length <= 1)
					{
						return;
					}
					OurBox.Items.Add(text.Substring(0, text.Length - EndTrim));
				}
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002AC0 File Offset: 0x00000CC0
		private string FriendlyToMapName(string Friendly, LauncherWindow.Info[] Array)
		{
			for (int i = 0; i < Array.Length; i++)
			{
				if (Array[i].FriendlyName.ToUpper() == Friendly.ToUpper())
				{
					return Array[i].RealName;
				}
			}
			return "";
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002B0C File Offset: 0x00000D0C
		private string FriendlyToType(string Friendly)
		{
			int i = 0;
			while (i < this.MapNames.Length)
			{
				if (this.MapNames[i].FriendlyName.ToUpper() == Friendly.ToUpper())
				{
					if (this.MapNames[i].Type == 0)
					{
						return "TDM/HORDE";
					}
					return "TITAN";
				}
				else
				{
					i++;
				}
			}
			return "";
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002B74 File Offset: 0x00000D74
		private void SaveInfo()
		{
			File.Delete(this.SAVEFILE);
			using (StreamWriter streamWriter = new StreamWriter(this.SAVEFILE))
			{
				streamWriter.WriteLine("[Server Settings]");
				streamWriter.WriteLine("ServerName=" + this.ServerNameTB.Text);
				streamWriter.WriteLine("MOTD=" + this.MOTDTB.Text);
				streamWriter.WriteLine("AdminPassword=" + this.PasswordTB.Text);
				streamWriter.WriteLine("FF=" + (this.bFF.Checked ? "True" : "False"));
				streamWriter.WriteLine("MaxPlayers=" + this.PlayersTB.Text);
				streamWriter.WriteLine("GoalLimit=" + this.ScoreTB.Text);
				streamWriter.WriteLine("TimeLimit=" + this.TimeTB.Text);
				streamWriter.WriteLine("AutoBalance=" + (this.bBalance.Checked ? "True" : "False"));
				streamWriter.WriteLine("WarmUpMode=" + (this.bWarmUp.Checked ? "True" : "False"));
				streamWriter.WriteLine("BotsAllowed=" + (this.bBots.Checked ? "True" : "False"));
				streamWriter.WriteLine("BotDifficulty=" + this.BotDifficulty.SelectedIndex);
				streamWriter.WriteLine("GameMode=" + this.PreferredGameMode.SelectedIndex);
				streamWriter.WriteLine("ServerType=" + this.ServerType.SelectedIndex);
				streamWriter.WriteLine("Port=" + this.bPort.Text);
				streamWriter.WriteLine("QueryPort=" + this.bQueryPort.Text);
				streamWriter.WriteLine("SessionPort=" + this.bSessionPort.Text);
				streamWriter.WriteLine("");
				streamWriter.WriteLine("[AvailiableMaps]");
				for (int i = 0; i < this.bMapListing.Items.Count; i++)
				{
					streamWriter.WriteLine(this.bMapListing.Items[i]);
				}
				streamWriter.WriteLine("");
				streamWriter.WriteLine("[Map Cycle]");
				for (int i = 0; i < this.bSelectedMapList.Items.Count; i++)
				{
					streamWriter.WriteLine(this.bSelectedMapList.Items[i]);
				}
				streamWriter.WriteLine("");
				streamWriter.Close();
			}
			this.SaveIniInfo();
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002E6C File Offset: 0x0000106C
		private void SaveIniInfo()
		{
			this.SetMapCycle();
			this.SetIniValue("ServerName", this.ServerNameTB.Text);
			this.SetIniValue("MessageOfTheDay", this.MOTDTB.Text);
			this.SetIniValue("AdminPassword", this.PasswordTB.Text);
			this.SetIniValue("MaxPlayers", this.PlayersTB.Text);
			this.SetIniValue("GoalScore", this.ScoreTB.Text);
			this.SetIniValue("TimeLimit", this.TimeTB.Text);
			this.SetIniValue("GameDifficulty", "+" + this.BotDifficulty.SelectedIndex);
			this.SetIniValue("PreferredGameMode", this.FriendlyToMapName(this.PreferredGameMode.Text, this.GameModes));
			if (this.GetConfigPath() != "")
			{
				using (StreamWriter streamWriter = new StreamWriter(File.Create(this.CONFIGFILE)))
				{
					for (int i = 0; i < this.LoadedIniFile.Count; i++)
					{
						streamWriter.WriteLine(this.LoadedIniFile[i]);
					}
					streamWriter.Close();
				}
			}
			this.LoadedIniFile.Clear();
			this.LoadedSaveFile.Clear();
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002FD8 File Offset: 0x000011D8
		private void BuildURL()
		{
			this.URL = "server " + this.FriendlyToMapName(this.bSelectedMapList.Items[0].ToString(), this.MapNames);
			switch (this.ServerType.SelectedIndex)
			{
			case 0:
				this.URL += "?Dedicated?Official=1";
				break;
			case 1:
				this.URL += "?Listen=True?Official=1";
				break;
			default:
				this.URL += "?listen=True?bIsLanMatch=True";
				break;
			}
			this.URL = this.URL + "?FF=" + (this.bFF.Checked ? "ON" : "OFF");
			this.URL = this.URL + "?Autobalance=" + (this.bBalance.Checked ? "?ON" : "OFF");
			this.URL = this.URL + "?bots=" + (this.bBots.Checked ? "ON" : "OFF");
			this.URL += (this.bWarmUp.Checked ? "?WarmpUpMode" : "");
			this.URL = this.URL + " -Port=" + ((this.bPort.Text != "") ? this.bPort.Text : "7777");
			this.URL = this.URL + " -QueryPort=" + ((this.bQueryPort.Text != "") ? this.bQueryPort.Text : "27015");
			this.URL = this.URL + " -GameSessionPort=" + ((this.bSessionPort.Text != "") ? this.bSessionPort.Text : "8105");
			this.URL += " -seekfreeloading";
			this.URL += " -Ranked";
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00003219 File Offset: 0x00001419
		private string GetConfigPath()
		{
			if (File.Exists(this.CONFIGFILE))
			{
				return this.CONFIGFILE;
			}
			return "";
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00003234 File Offset: 0x00001434
		private bool SetIniValue(string LookForValue, string NewValue)
		{
			bool flag = false;
			if (this.LoadedIniFile.Count > 0)
			{
				for (int i = 0; i < this.LoadedIniFile.Count; i++)
				{
					if (this.LoadedIniFile[i].Contains(LookForValue))
					{
						if (!flag)
						{
							flag = true;
							this.LoadedIniFile[i] = LookForValue + "=" + NewValue;
						}
						else
						{
							this.LoadedIniFile.RemoveAt(i);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000032A8 File Offset: 0x000014A8
		private bool SetMapCycle()
		{
			bool flag = false;
			int num = 0;
			if (this.LoadedIniFile.Count > 0)
			{
				for (int i = 0; i < this.LoadedIniFile.Count; i++)
				{
					string text = this.LoadedIniFile[i];
					if (!flag && text.Contains("[TGEngine.TGGameSettings]"))
					{
						flag = true;
					}
					else if (flag)
					{
						if (text.Trim() == "")
						{
							for (int j = num; j < this.bSelectedMapList.Items.Count; j++)
							{
								text = this.FriendlyToMapName(this.bSelectedMapList.Items[j].ToString(), this.MapNames);
								text = text.Replace(".tgm", "");
								this.LoadedIniFile.Insert(i + j, "+CustomMapRotation=" + text);
							}
							return true;
						}
						if (text.Contains("CustomMapRotation="))
						{
							this.LoadedIniFile.RemoveAt(i);
							i--;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000033B0 File Offset: 0x000015B0
		private void bClearCycle_Click(object sender, EventArgs e)
		{
			this.bSelectedMapList.Items.Clear();
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000033C4 File Offset: 0x000015C4
		private void bLaunchServer_Click(object sender, EventArgs e)
		{
			if (this.bSelectedMapList.Items.Count > 0)
			{
				this.SaveInfo();
				this.BuildURL();
				Console.WriteLine("OUR URL " + this.URL);
				if (File.Exists(Application.StartupPath + "\\Win32\\MinGame.exe"))
				{
					Process.Start(Application.StartupPath + "\\Win32\\MinGame.exe", this.URL);
				}
				else if (File.Exists(Application.StartupPath + "\\Win32\\Minimum.exe"))
				{
					Process.Start(Application.StartupPath + "\\Win32\\Minimum.exe", this.URL);
				}
				Thread.Sleep(5000);
				Application.Exit();
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000347B File Offset: 0x0000167B
		private void bMapListing_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.bSelectedMapList.Items.Add(this.bMapListing.SelectedItem);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000349C File Offset: 0x0000169C
		private void MapListing_MouseHover(object sender, EventArgs e)
		{
			Point p = this.bMapListing.PointToClient(Cursor.Position);
			int num = this.bMapListing.IndexFromPoint(p);
			if (num < 0 || num == this.LastHoverIndex)
			{
				return;
			}
			this.LastHoverIndex = num;
			this.MapType.Text = "Type: " + this.FriendlyToType(this.bMapListing.Items[num].ToString());
			Console.WriteLine(this.bMapListing.Items[num].ToString());
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00003528 File Offset: 0x00001728
		private void DigitOnlyOnKeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		// Token: 0x04000001 RID: 1
		private string SAVEFILE = Application.StartupPath + "\\LauncherData.txt";

		// Token: 0x04000002 RID: 2
		private string CONFIGFILE = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\\")) + "MinGame\\Config\\DefaultGame.ini";

		// Token: 0x04000003 RID: 3
		private string URL = "";

		// Token: 0x04000004 RID: 4
		private int LastHoverIndex;

		// Token: 0x04000005 RID: 5
		private LauncherWindow.Info[] MapNames;

		// Token: 0x04000006 RID: 6
		private LauncherWindow.Info[] GameModes;

		// Token: 0x04000007 RID: 7
		private string[] BotDifficulties;

		// Token: 0x04000008 RID: 8
		private string[] ServerTypes;

		// Token: 0x04000009 RID: 9
		private List<string> LoadedSaveFile;

		// Token: 0x0400000A RID: 10
		private List<string> LoadedIniFile;

		// Token: 0x02000003 RID: 3
		private struct Info
		{
			// Token: 0x04000036 RID: 54
			public string RealName;

			// Token: 0x04000037 RID: 55
			public string FriendlyName;

			// Token: 0x04000038 RID: 56
			public int Type;
		}
	}
}
