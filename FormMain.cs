using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace Machine_Turing {

	public partial class FormMain : Form {

		const int colWidth = 40;
		const string abc = " ";
		string[ ] direct = { "R", "N", "L" };
		int maxCols = 199;
		bool isSave;
		int selectCol, centerCol;
		string[ ] alphabet;
		string[ ] rows;

		public FormMain ( bool isNew ) {
			isSave = false;
			centerCol = maxCols / 2;
			InitializeComponent( );

			if ( isNew ) {
				buildMachine( );
			}
		}

		private void FormMain_KeyDown ( object sender, KeyEventArgs e ) {

			if ( e.Control ) {
				switch ( e.KeyCode ) {
					case Keys.N:
						buttonNew_Click( sender, e );
						break;
					case Keys.O:
						buttonOpen_Click( sender, e );
						break;
					case Keys.S:
						buttonSave_Click( sender, e );
						break;
					case Keys.R:
						buttonRun_Click( sender, e );
						break;
					case Keys.E:
						buttonClear_Click( sender, e );
						break;
					case Keys.B:
						buttonBuild_Click( sender, e );
						break;
					case Keys.M:
						buttonMinimization_Click( sender, e );
						break;
				}
			} else {

				if ( e.KeyCode == Keys.F1 ) {
					buttonHelp_Click( sender, e );
				}

			}

		}

		private void FormMain_Shown ( object sender, EventArgs e ) {
			Program.MachineIndex++;
			Text = "Машина Тьюринга " + Program.MachineIndex.ToString( );
			tabControlTabs.SelectedIndex = 0;
			tabControlMenu.SelectedIndex = 0;
			textBoxAlphabet.Focus( );
		}

		private void buttonNew_Click ( object sender, EventArgs e ) {
			FormMain formNext = new FormMain( true );
			formNext.Show( );
		}

		void addRows ( int rowCount ) {
			rowCount += 1;
			rows = new string[ rowCount ];
			rows[ 0 ] = "$";

			for ( int i = 1; i < rowCount; i++ ) {
				rows[ i ] = i.ToString( );
			}
		}

		bool open ( FormMain form ) {
			string path = openFileDialog.FileName;
			int i, j;
			int rowCount, colCount;

			listBoxResult.Items.Add( "Открытие ..." );

			try {
				using ( BinaryReader reader = new BinaryReader( File.Open( path, FileMode.Open ) ) ) {

					form.maxCols = reader.ReadInt32( );
					form.centerCol = reader.ReadInt32( );
					form.selectCol = reader.ReadInt32( );
					int textLength = reader.ReadInt32( );
					form.textBoxAlphabet.Text = reader.ReadString( );
					colCount = reader.ReadInt32( );
					form.addAlphabet( );

					for ( j = 0; j < colCount; j++ ) {

						form.dataGridViewTapeTittle.Columns.Add( new DataGridViewTextBoxColumn( ) {
							Width = colWidth,
							SortMode = DataGridViewColumnSortMode.NotSortable
						} );

						form.dataGridViewTape.Columns.Add( new DataGridViewComboBoxColumn( ) {
							Width = colWidth,
							SortMode = DataGridViewColumnSortMode.NotSortable
						} );

					}

					int col;
					form.dataGridViewTapeTittle.RowCount = 1;
					form.dataGridViewTape.RowCount = 1;
					form.dataGridViewTapeTittle.Rows[ 0 ].DefaultCellStyle.BackColor = Color.Gainsboro;
					form.dataGridViewTape.RowCount = 1;
					form.dataGridViewTapeTittle.Rows[ 0 ].ReadOnly = true;

					for ( j = 0; j < form.centerCol; j++ ) {
						col = form.centerCol + j;
						form.dataGridViewTapeTittle[ j, 0 ].Value = form.centerCol - j;
						( ( DataGridViewComboBoxColumn ) form.dataGridViewTape.Columns[ j ] ).Items.AddRange( form.alphabet );
						form.dataGridViewTapeTittle[ col, 0 ].Value = j;
						( ( DataGridViewComboBoxColumn ) form.dataGridViewTape.Columns[ col ] ).Items.AddRange( form.alphabet );
					}

					col = colCount - 1;
					form.dataGridViewTapeTittle[ col, 0 ].Value = j;
					( ( DataGridViewComboBoxColumn ) form.dataGridViewTape.Columns[ col ] ).Items.AddRange( form.alphabet );

					for ( j = 0; j < colCount; j++ ) {
						form.dataGridViewTape[ j, 0 ].Value = reader.ReadString( );
					}

					form.dataGridViewTapeTittle.CurrentCell = form.dataGridViewTapeTittle[ form.selectCol, 0 ];
					form.dataGridViewTape.CurrentCell = form.dataGridViewTape[ form.selectCol, 0 ];
					form.dataGridViewTapeTittle.Columns[ form.selectCol ].HeaderText = "";
					form.dataGridViewTapeTittle.FirstDisplayedCell = form.dataGridViewTapeTittle[ form.selectCol - 5, 0 ];
					form.dataGridViewTape.FirstDisplayedCell = form.dataGridViewTape[ form.selectCol - 5, 0 ];

					rowCount = reader.ReadInt32( );
					colCount = reader.ReadInt32( );
					form.addRows( rowCount );
					form.dataGridViewTableTittle.ColumnCount = reader.ReadInt32( );

					for ( j = col = 0; j < form.dataGridViewTableTittle.ColumnCount; j++, col += 3 ) {

						form.dataGridViewTableTittle.Columns[ j ].HeaderText = form.textBoxAlphabet.Text.Substring( j, 1 );
						form.dataGridViewTableTittle.Columns[ j ].Width = colWidth * 3;
						form.dataGridViewTableTittle.Columns[ j ].SortMode = DataGridViewColumnSortMode.NotSortable;
						form.dataGridViewTableTittle.Columns[ j ].HeaderText = reader.ReadString( );

						for ( i = 0; i < 3; i++ ) {

							form.dataGridViewTable.Columns.Add( new DataGridViewComboBoxColumn( ) {
								Width = colWidth,
								SortMode = DataGridViewColumnSortMode.NotSortable
							} );

						}

						( ( DataGridViewComboBoxColumn ) form.dataGridViewTable.Columns[ col ] ).Items.AddRange( form.alphabet );
						form.dataGridViewTable.Columns[ col ].HeaderText = "A";
						( ( DataGridViewComboBoxColumn ) form.dataGridViewTable.Columns[ col + 1 ] ).Items.AddRange( form.direct );
						form.dataGridViewTable.Columns[ col + 1 ].HeaderText = "D";
						( ( DataGridViewComboBoxColumn ) form.dataGridViewTable.Columns[ col + 2 ] ).Items.AddRange( form.rows );
						form.dataGridViewTable.Columns[ col + 2 ].HeaderText = "Q";

					}

					form.dataGridViewTable.RowCount = rowCount;

					for ( i = 0; i < rowCount; i++ ) {
						for ( j = 0; j < colCount; j++ ) {
							form.dataGridViewTable[ j, i ].Value = reader.ReadString( );
						}
						form.dataGridViewTable.Rows[ i ].HeaderCell.Value = ( i + 1 ).ToString( );
					}

					form.dataGridViewTable.Rows[ rowCount ].HeaderCell.Value = ( i + 1 ).ToString( );

					int itemsCount = reader.ReadInt32( );
					for ( i = 0; i < itemsCount; i++ ) {
						form.listBoxResult.Items.Add( reader.ReadString( ) );
					}

				}

				listBoxResult.Items.Add( " ОК" );
			} catch ( Exception e ) {
				listBoxResult.Items.Add( " Ошибка : " + e.Message );
			}

			listBoxResult.Items.Add( "" );
			form.textBoxAlphabet.Focus( );
			return true;
		}

		private void buttonOpen_Click ( object sender, EventArgs e ) {
			openFileDialog.InitialDirectory = Application.StartupPath;
			openFileDialog.FileName = Text;

			if ( openFileDialog.ShowDialog( ) == DialogResult.OK ) {
				FormMain formNext = new FormMain( false );

				if ( open( formNext ) ) {
					formNext.Show( );
				}
			}
		}

		void save ( ) {

			Text = saveFileDialog.FileName;
			string path = saveFileDialog.FileName;
			isSave = true;
			int i, j;

			listBoxResult.Items.Add( "Сохранение ..." );

			try {
				// создаем объект BinaryWriter
				using ( BinaryWriter writer = new BinaryWriter( File.Open( path, FileMode.OpenOrCreate ) ) ) {
					// записываем в файл значение каждого поля структуры

					writer.Write( maxCols );
					writer.Write( centerCol );
					writer.Write( selectCol );
					writer.Write( textBoxAlphabet.TextLength );
					writer.Write( textBoxAlphabet.Text );
					writer.Write( dataGridViewTape.ColumnCount );

					for ( j = 0; j < dataGridViewTape.ColumnCount; j++ ) {
						writer.Write( dataGridViewTape[ j, 0 ].Value.ToString( ) );
					}

					writer.Write( dataGridViewTable.RowCount );
					writer.Write( dataGridViewTable.ColumnCount );
					writer.Write( dataGridViewTableTittle.ColumnCount );

					for ( j = 0; j < dataGridViewTableTittle.ColumnCount; j++ ) {
						writer.Write( dataGridViewTableTittle.Columns[ j ].HeaderText );
					}

					for ( i = 0; i < dataGridViewTable.RowCount; i++ ) {
						for ( j = 0; j < dataGridViewTable.ColumnCount; j++ ) {
							writer.Write( dataGridViewTable[ j, i ].Value.ToString( ) );
						}
					}

					writer.Write( listBoxResult.Items.Count );

					for ( i = 0; i < listBoxResult.Items.Count; i++ ) {
						writer.Write( listBoxResult.Items[ i ].ToString( ) );
					}

					listBoxResult.Items.Add( " ОК" );

				}
			} catch ( Exception e ) {
				listBoxResult.Items.Add( " Ошибка : " + e.Message );
			}

			listBoxResult.Items.Add( "" );

		}

		private void buttonSave_Click ( object sender, EventArgs e ) {
			if ( !isSave ) {

				saveFileDialog.InitialDirectory = Application.StartupPath;
				saveFileDialog.FileName = Text;

				if ( saveFileDialog.ShowDialog( ) == DialogResult.OK ) {
					save( );
				}

			} else {
				save( );
			}
		}

		private void buttonRun_Click ( object sender, EventArgs e ) {
			int col, row;
			string A = "";
			string D = "";
			string Q = "";
			string T = "";

			tabControlTabs.SelectedIndex = 1;
			int c = selectCol;
			dataGridViewTapeTittle.Columns[ selectCol ].HeaderText = "";
			string text;

			listBoxResult.Items.Add( " Машина начала работать \n" );
			listBoxResult.Items.Add( "╔═════════╦═══╦═══╦═══╦═══╗" );
			listBoxResult.Items.Add( "║    №    ║[T]║ A ║ D ║ Q ║" );
			listBoxResult.Items.Add( "╠═════════╬═══╬═══╬═══╬═══╣" );

			for ( int i = row = col = 0; ; i++ ) {

				T = dataGridViewTape[ c, 0 ].Value.ToString( );

				for ( col = 0; col < dataGridViewTableTittle.ColumnCount; col++ ) {
					if ( dataGridViewTableTittle.Columns[ col ].HeaderText.CompareTo( T ) == 0 ) {
						break;
					}
				}

				col *= 3;
				A = ( dataGridViewTable[ col, row ].Value != null ) ? ( dataGridViewTable[ col, row ].Value.ToString( ) ) : ( " " );
				D = ( dataGridViewTable[ col + 1, row ].Value != null ) ? ( dataGridViewTable[ col + 1, row ].Value.ToString( ) ) : ( " " );
				Q = ( dataGridViewTable[ col + 2, row ].Value != null ) ? ( dataGridViewTable[ col + 2, row ].Value.ToString( ) ) : ( " " );

				dataGridViewTape[ c, 0 ].Value = A.ToString( );

				switch ( D ) {
					case "L":
						c--;

						break;
					case "R":
						c++;
						break;
				}

				text = string.Format( "║{0,9}║ {1,1} │ {2,1} │ {3,1} │ {4,1} ║",  ( i + 1 ).ToString() , T, A, D, Q );
				listBoxResult.Items.Add( text );

				if ( Q == "$" ) {
					break;
				} else {
					row = Convert.ToInt32( Q ) - 1;
				}

				listBoxResult.Items.Add( "╠═════════╬───┼───┼───┼───╣" );

			}

			listBoxResult.Items.Add( "╚═════════╩═══╩═══╩═══╩═══╝" );
			listBoxResult.Items.Add( "\n Машина остановилась" );

			selectCol = c;
			dataGridViewTapeTittle.Columns[ selectCol ].HeaderText = "";
			dataGridViewTapeTittle.CurrentCell = dataGridViewTapeTittle[ selectCol, 0 ];
			dataGridViewTape.CurrentCell = dataGridViewTape[ selectCol, 0 ];
			listBoxResult.Items.Add( "" );

		}

		int findSate ( List<List<int>> listStates, int value ) {
			int i, j;

			for ( i = 0; i < listStates.Count; i++ ) {
				for ( j = 0; j < listStates[ i ].Count; j++ ) {
					if ( listStates[ i ][ j ] == value ) {
						return value;
					}
				}
			}

			return -1;
		}

		private void buttonClear_Click ( object sender, EventArgs e ) {
			if ( MessageBox.Show( "Очистить машину?", "Очистка машины", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == System.Windows.Forms.DialogResult.Yes ) {
				clearMachine( );
				buildMachine( );
			}
		}

		private void clearMachine ( ) {
			textBoxAlphabet.Text = abc;
			dataGridViewTapeTittle.Rows.Clear( );
			dataGridViewTapeTittle.Columns.Clear( );
			dataGridViewTape.Rows.Clear( );
			dataGridViewTape.Columns.Clear( );
			dataGridViewTableTittle.Rows.Clear( );
			dataGridViewTableTittle.Columns.Clear( );
			dataGridViewTable.Rows.Clear( );
			dataGridViewTable.Columns.Clear( );
			listBoxResult.Items.Clear( );
			textBoxAlphabet.Focus( );
		}

		private void buttonHelp_Click ( object sender, EventArgs e ) {
			System.Diagnostics.Process.Start( "Help.chm" );
		}

		private void buttonAbout_Click ( object sender, EventArgs e ) {
			FormAbout formAbout = new FormAbout( );
			formAbout.Show( );
		}

		private void FormMain_FormClosing ( object sender, FormClosingEventArgs e ) {
			if ( !isSave ) {
				switch ( MessageBox.Show( "Сохранить машину?", Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question ) ) {
					case System.Windows.Forms.DialogResult.Yes:
						buttonSave_Click( sender, e );
						break;
					case System.Windows.Forms.DialogResult.Cancel:
						e.Cancel = true;
						break;
				}
			}
		}

		private void buildMachine ( ) {

			int i, j;
			int col;

			addAlphabet( );

			for ( j = 0; j < maxCols; j++ ) {
				dataGridViewTapeTittle.Columns.Add( new DataGridViewTextBoxColumn( ) {
					Width = colWidth,
					SortMode = DataGridViewColumnSortMode.NotSortable
				} );
				dataGridViewTape.Columns.Add( new DataGridViewComboBoxColumn( ) {
					Width = colWidth,
					SortMode = DataGridViewColumnSortMode.NotSortable
				} );
			}

			dataGridViewTapeTittle.RowCount = 1;
			dataGridViewTapeTittle.Rows[ 0 ].DefaultCellStyle.BackColor = Color.Gainsboro;
			dataGridViewTape.RowCount = 1;
			dataGridViewTapeTittle.Rows[ 0 ].ReadOnly = true;
			selectCol = centerCol;

			for ( j = 0; j < centerCol; j++ ) {
				col = centerCol + j;
				dataGridViewTapeTittle[ j, 0 ].Value = centerCol - j;
				( ( DataGridViewComboBoxColumn ) dataGridViewTape.Columns[ j ] ).Items.AddRange( alphabet );
				dataGridViewTape[ j, 0 ].Value = " ";

				dataGridViewTapeTittle[ col, 0 ].Value = j;
				( ( DataGridViewComboBoxColumn ) dataGridViewTape.Columns[ col ] ).Items.AddRange( alphabet );
				dataGridViewTape[ col, 0 ].Value = " ";
			}

			col = dataGridViewTapeTittle.ColumnCount - 1;
			dataGridViewTapeTittle[ col, 0 ].Value = j;
			( ( DataGridViewComboBoxColumn ) dataGridViewTape.Columns[ col ] ).Items.AddRange( alphabet );
			dataGridViewTape[ col, 0 ].Value = " ";

			dataGridViewTapeTittle.CurrentCell = dataGridViewTapeTittle[ selectCol, 0 ];
			dataGridViewTape.CurrentCell = dataGridViewTape[ selectCol, 0 ];
			dataGridViewTapeTittle.Columns[ selectCol ].HeaderText = "";
			dataGridViewTableTittle.ColumnCount = textBoxAlphabet.TextLength;
			dataGridViewTapeTittle.FirstDisplayedCell = dataGridViewTapeTittle[ selectCol - 5, 0 ];
			dataGridViewTape.FirstDisplayedCell = dataGridViewTape[ selectCol - 5, 0 ];
			
			addRows( 1 );

			for ( j = col = 0; j < dataGridViewTableTittle.ColumnCount; j++, col += 3 ) {

				dataGridViewTableTittle.Columns[ j ].HeaderText = textBoxAlphabet.Text.Substring( j, 1 );
				dataGridViewTableTittle.Columns[ j ].Width = colWidth * 3;
				dataGridViewTableTittle.Columns[ j ].SortMode = DataGridViewColumnSortMode.NotSortable;

				for ( i = 0; i < 3; i++ ) {

					dataGridViewTable.Columns.Add( new DataGridViewComboBoxColumn( ) {
						Width = colWidth,
						SortMode = DataGridViewColumnSortMode.NotSortable
					} );

				}

				( ( DataGridViewComboBoxColumn ) dataGridViewTable.Columns[ col ] ).Items.AddRange( alphabet );
				dataGridViewTable.Columns[ col ].HeaderText = "A";
				( ( DataGridViewComboBoxColumn ) dataGridViewTable.Columns[ col + 1 ] ).Items.AddRange( direct );
				dataGridViewTable.Columns[ col + 1 ].HeaderText = "D";
				( ( DataGridViewComboBoxColumn ) dataGridViewTable.Columns[ col + 2 ] ).Items.AddRange( rows );
				dataGridViewTable.Columns[ col + 2 ].HeaderText = "Q";

			}

			dataGridViewTable.RowCount = 1;
			dataGridViewTable.Rows[ 0 ].HeaderCell.Value = "1";

			for ( j = 0; j < dataGridViewTable.ColumnCount; j += 3 ) {
				dataGridViewTable[ j, 0 ].Value = " ";
				dataGridViewTable[ j + 1, 0 ].Value = "N";
				dataGridViewTable[ j + 2, 0 ].Value = "$";
			}

		}

		void addAlphabet ( ) {
			alphabet = new string[ textBoxAlphabet.TextLength ];

			for ( int i = 0; i < alphabet.Length; i++ ) {
				alphabet[ i ] = textBoxAlphabet.Text.Substring( i, 1 );
			}
		}

		private void buttonBuild_Click ( object sender, EventArgs e ) {
			int i, j;
			int col;

			addAlphabet( );

			dataGridViewTableTittle.Rows.Clear( );
			dataGridViewTableTittle.Columns.Clear( );
			dataGridViewTable.Rows.Clear( );
			dataGridViewTable.Columns.Clear( );

			for ( j = 0; j <= centerCol; j++ ) {
				col = centerCol + j;
				( ( DataGridViewComboBoxColumn ) dataGridViewTape.Columns[ j ] ).Items.Clear( );
				( ( DataGridViewComboBoxColumn ) dataGridViewTape.Columns[ j ] ).Items.AddRange( alphabet );
				( ( DataGridViewComboBoxColumn ) dataGridViewTape.Columns[ col ] ).Items.Clear( );
				( ( DataGridViewComboBoxColumn ) dataGridViewTape.Columns[ col ] ).Items.AddRange( alphabet );
			}

			dataGridViewTableTittle.ColumnCount = textBoxAlphabet.TextLength;
			addRows( 1 );

			for ( j = col = 0; j < dataGridViewTableTittle.ColumnCount; j++, col += 3 ) {

				dataGridViewTableTittle.Columns[ j ].HeaderText = textBoxAlphabet.Text.Substring( j, 1 );
				dataGridViewTableTittle.Columns[ j ].Width = colWidth * 3;
				dataGridViewTableTittle.Columns[ j ].SortMode = DataGridViewColumnSortMode.NotSortable;

				for ( i = 0; i < 3; i++ ) {

					dataGridViewTable.Columns.Add( new DataGridViewComboBoxColumn( ) {
						Width = colWidth,
						SortMode = DataGridViewColumnSortMode.NotSortable
					} );

				}

				( ( DataGridViewComboBoxColumn ) dataGridViewTable.Columns[ col ] ).Items.AddRange( alphabet );
				dataGridViewTable.Columns[ col ].HeaderText = "A";
				( ( DataGridViewComboBoxColumn ) dataGridViewTable.Columns[ col + 1 ] ).Items.AddRange( direct );
				dataGridViewTable.Columns[ col + 1 ].HeaderText = "D";
				( ( DataGridViewComboBoxColumn ) dataGridViewTable.Columns[ col + 2 ] ).Items.AddRange( rows );
				dataGridViewTable.Columns[ col + 2 ].HeaderText = "Q";

			}

			dataGridViewTable.RowCount = 1;
			dataGridViewTable.Rows[ 0 ].HeaderCell.Value = "1";

			for ( j = 0; j < dataGridViewTable.ColumnCount; j += 3 ) {
				dataGridViewTable[ j, 0 ].Value = " ";
				dataGridViewTable[ j + 1, 0 ].Value = "N";
				dataGridViewTable[ j + 2, 0 ].Value = "$";
			}

		}

		private void dataGridViewTable_Scroll ( object sender, ScrollEventArgs e ) {
			dataGridViewTableTittle.HorizontalScrollingOffset = e.NewValue;
		}

		private void dataGridViewTape_Scroll ( object sender, ScrollEventArgs e ) {
			dataGridViewTapeTittle.HorizontalScrollingOffset = e.NewValue;
		}

		private void dataGridViewTable_RowsAdded ( object sender, DataGridViewRowsAddedEventArgs e ) {
			int r = dataGridViewTable.RowCount - 1;
			dataGridViewTable.Rows[ r ].HeaderCell.Value = ( r + 1 ).ToString( );
			addRows( r );

			for ( int j = 2; j < dataGridViewTable.ColumnCount; j += 3 ) {
				( ( DataGridViewComboBoxColumn ) dataGridViewTable.Columns[ j ] ).Items.Clear( );
				( ( DataGridViewComboBoxColumn ) dataGridViewTable.Columns[ j ] ).Items.AddRange( rows );
				dataGridViewTable[ j - 2, r ].Value = " ";
				dataGridViewTable[ j - 1, r ].Value = "N";
				dataGridViewTable[ j, r ].Value = "$";
			}
		}

		private void dataGridViewTapeTittle_ColumnHeaderMouseClick ( object sender, DataGridViewCellMouseEventArgs e ) {
			dataGridViewTapeTittle.Columns[ selectCol ].HeaderText = "";
			selectCol = e.ColumnIndex;
			dataGridViewTapeTittle.Columns[ selectCol ].HeaderText = "";
			dataGridViewTapeTittle.CurrentCell = dataGridViewTapeTittle[ selectCol, 0 ];
			dataGridViewTape.CurrentCell = dataGridViewTape[ selectCol, 0 ];
		}

		private void toolStripButtonClear_Click ( object sender, EventArgs e ) {
			listBoxResult.Items.Clear( );
		}

		private void FormMain_Resize ( object sender, EventArgs e ) {
			dataGridViewTape.FirstDisplayedCell = dataGridViewTape[ selectCol - 5, 0 ];
			dataGridViewTapeTittle.FirstDisplayedCell = dataGridViewTapeTittle[ selectCol - 5, 0 ];
			dataGridViewTable.FirstDisplayedCell = dataGridViewTable.CurrentCell;
			dataGridViewTableTittle.FirstDisplayedCell = dataGridViewTableTittle.CurrentCell;
		}

		private void textBoxAlphabet_Leave ( object sender, EventArgs e ) {
			char[ ] chArr = textBoxAlphabet.Text.ToCharArray( );
			Array.Sort( chArr );
			textBoxAlphabet.Text = new string( chArr );
		}

		private void buttonMinimization_Click ( object sender, EventArgs e ) {

			bool[ ] isUsedStates = new bool[ dataGridViewTable.RowCount - 1 ];
			bool[ ] isUsedSymbols = new bool[ textBoxAlphabet.TextLength ];
			int i, j;
			int index;
			int value;
			int countStates, countSymbols;

			listBoxResult.Items.Add( "Мнимизация начата" );

			for ( i = 0; i < dataGridViewTable.RowCount - 1; i++ ) {
				for ( j = 0; j < dataGridViewTable.ColumnCount; j += 3 ) {

					if ( Int32.TryParse( dataGridViewTable[ j + 2, i ].Value.ToString( ), out value ) ) {
						isUsedStates[ value - 1 ] = true;
					}

					index = textBoxAlphabet.Text.IndexOf( dataGridViewTable[ j, i ].Value.ToString( ) );
					isUsedSymbols[ index ] = true;
				}
			}

			for ( i = countStates = 0; i < isUsedStates.Length; i++ ) {
				if ( !isUsedStates[ i ] ) {
					dataGridViewTable.Rows.RemoveAt( i );
					countStates ++;
				}
			}

			for ( j = countSymbols = 0; j < isUsedSymbols.Length; j++ ) {
				if ( !isUsedSymbols[ j ] ) {
					dataGridViewTableTittle.Columns.RemoveAt( j );
					index = j * 3;
					dataGridViewTable.Columns.RemoveAt( j );
					dataGridViewTable.Columns.RemoveAt( j );
					dataGridViewTable.Columns.RemoveAt( j );
					countSymbols ++;
				}
			}

			listBoxResult.Items.Add( "Состояний удалено: " + countStates );
			listBoxResult.Items.Add( "Символов удалено: " + countSymbols );
			listBoxResult.Items.Add( "Минимизация завершена" );
			listBoxResult.Items.Add( "" );

		}

	}

}