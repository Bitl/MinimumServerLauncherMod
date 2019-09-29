using System;
using System.Windows.Forms;

namespace MinimumLauncher
{
	// Token: 0x02000004 RID: 4
	internal static class Program
	{
		// Token: 0x0600001B RID: 27 RVA: 0x00004FD4 File Offset: 0x000031D4
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new LauncherWindow());
		}
	}
}
