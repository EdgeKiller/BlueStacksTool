/*
 * Created by SharpDevelop.
 * User: EdgeKiller
 * Date: 03/10/2015
 */
using System;
using System.Windows.Forms;

namespace BlueStacksTool
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
