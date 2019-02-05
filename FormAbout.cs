using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Machine_Turing {
	public partial class FormAbout : Form {
		public FormAbout ( ) {
			InitializeComponent( );
		}
				
		private void buttonOk_Click ( object sender, EventArgs e ) {
			Close( );
		}

		private void FormAbout_KeyDown ( object sender, KeyEventArgs e ) {
			if ( e.KeyCode == Keys.Escape ) {
				Close( );
			}
		}
	}
}
