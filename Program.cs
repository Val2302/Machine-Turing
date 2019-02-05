using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Machine_Turing {

	static class Program {

		public static int MachineIndex { get; set; }

		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main ( ) {
			MachineIndex = 0;
			Application.EnableVisualStyles( );
			Application.SetCompatibleTextRenderingDefault( false );
			Application.Run( new FormMain( true ) );
		}

	}

}
