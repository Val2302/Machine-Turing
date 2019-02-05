namespace Machine_Turing {
	partial class FormMain {
		/// <summary>
		/// Требуется переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose ( bool disposing ) {
			if ( disposing && ( components != null ) ) {
				components.Dispose( );
			}
			base.Dispose( disposing );
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Обязательный метод для поддержки конструктора - не изменяйте
		/// содержимое данного метода при помощи редактора кода.
		/// </summary>
		private void InitializeComponent ( ) {
			this.components = new System.ComponentModel.Container( );
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( FormMain ) );
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle( );
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle( );
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle( );
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle( );
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle( );
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle( );
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle( );
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle( );
			this.groupBoxMenu = new System.Windows.Forms.GroupBox( );
			this.imageListMenu = new System.Windows.Forms.ImageList( this.components );
			this.panelSplitterFile = new System.Windows.Forms.Panel( );
			this.buttonClear = new System.Windows.Forms.Button( );
			this.buttonRun = new System.Windows.Forms.Button( );
			this.buttonAbout = new System.Windows.Forms.Button( );
			this.buttonHelp = new System.Windows.Forms.Button( );
			this.buttonSave = new System.Windows.Forms.Button( );
			this.buttonOpen = new System.Windows.Forms.Button( );
			this.groupBoxTape = new System.Windows.Forms.GroupBox( );
			this.dataGridViewTapeTittle = new System.Windows.Forms.DataGridView( );
			this.dataGridViewTape = new System.Windows.Forms.DataGridView( );
			this.groupBoxTable = new System.Windows.Forms.GroupBox( );
			this.dataGridViewTableTittle = new System.Windows.Forms.DataGridView( );
			this.dataGridViewTable = new System.Windows.Forms.DataGridView( );
			this.tabControlTabs = new System.Windows.Forms.TabControl( );
			this.tabPageTask = new System.Windows.Forms.TabPage( );
			this.groupBoxAlphabet = new System.Windows.Forms.GroupBox( );
			this.buttonBuild = new System.Windows.Forms.Button( );
			this.imageListContext = new System.Windows.Forms.ImageList( this.components );
			this.textBoxAlphabet = new System.Windows.Forms.TextBox( );
			this.tabPageResult = new System.Windows.Forms.TabPage( );
			this.toolStripResult = new System.Windows.Forms.ToolStrip( );
			this.toolStripButtonClear = new System.Windows.Forms.ToolStripButton( );
			this.listBoxResult = new System.Windows.Forms.ListBox( );
			this.imageListTabs = new System.Windows.Forms.ImageList( this.components );
			this.toolTip = new System.Windows.Forms.ToolTip( this.components );
			this.buttonNew = new System.Windows.Forms.Button( );
			this.tabControlMenu = new System.Windows.Forms.TabControl( );
			this.tabPageFile = new System.Windows.Forms.TabPage( );
			this.tabPageMachine = new System.Windows.Forms.TabPage( );
			this.buttonMinimization = new System.Windows.Forms.Button( );
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog( );
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog( );
			this.groupBoxTape.SuspendLayout( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.dataGridViewTapeTittle ) ).BeginInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.dataGridViewTape ) ).BeginInit( );
			this.groupBoxTable.SuspendLayout( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.dataGridViewTableTittle ) ).BeginInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.dataGridViewTable ) ).BeginInit( );
			this.tabControlTabs.SuspendLayout( );
			this.tabPageTask.SuspendLayout( );
			this.groupBoxAlphabet.SuspendLayout( );
			this.tabPageResult.SuspendLayout( );
			this.toolStripResult.SuspendLayout( );
			this.tabControlMenu.SuspendLayout( );
			this.tabPageFile.SuspendLayout( );
			this.tabPageMachine.SuspendLayout( );
			this.SuspendLayout( );
			// 
			// groupBoxMenu
			// 
			resources.ApplyResources( this.groupBoxMenu, "groupBoxMenu" );
			this.groupBoxMenu.Name = "groupBoxMenu";
			this.groupBoxMenu.TabStop = false;
			this.toolTip.SetToolTip( this.groupBoxMenu, resources.GetString( "groupBoxMenu.ToolTip" ) );
			// 
			// imageListMenu
			// 
			this.imageListMenu.ImageStream = ( ( System.Windows.Forms.ImageListStreamer ) ( resources.GetObject( "imageListMenu.ImageStream" ) ) );
			this.imageListMenu.TransparentColor = System.Drawing.Color.Transparent;
			this.imageListMenu.Images.SetKeyName( 0, "document_new_32.png.ico" );
			this.imageListMenu.Images.SetKeyName( 1, "document_open_32.png" );
			this.imageListMenu.Images.SetKeyName( 2, "save_32.png" );
			this.imageListMenu.Images.SetKeyName( 3, "player_play_32.png" );
			this.imageListMenu.Images.SetKeyName( 4, "size_32.png" );
			this.imageListMenu.Images.SetKeyName( 5, "trash-can-delete_32.png" );
			this.imageListMenu.Images.SetKeyName( 6, "question.png" );
			this.imageListMenu.Images.SetKeyName( 7, "information.png" );
			this.imageListMenu.Images.SetKeyName( 8, "step_track_blue_32.png" );
			// 
			// panelSplitterFile
			// 
			resources.ApplyResources( this.panelSplitterFile, "panelSplitterFile" );
			this.panelSplitterFile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelSplitterFile.Name = "panelSplitterFile";
			this.toolTip.SetToolTip( this.panelSplitterFile, resources.GetString( "panelSplitterFile.ToolTip" ) );
			// 
			// buttonClear
			// 
			resources.ApplyResources( this.buttonClear, "buttonClear" );
			this.buttonClear.ImageList = this.imageListMenu;
			this.buttonClear.Name = "buttonClear";
			this.toolTip.SetToolTip( this.buttonClear, resources.GetString( "buttonClear.ToolTip" ) );
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler( this.buttonClear_Click );
			// 
			// buttonRun
			// 
			resources.ApplyResources( this.buttonRun, "buttonRun" );
			this.buttonRun.ImageList = this.imageListMenu;
			this.buttonRun.Name = "buttonRun";
			this.toolTip.SetToolTip( this.buttonRun, resources.GetString( "buttonRun.ToolTip" ) );
			this.buttonRun.UseVisualStyleBackColor = true;
			this.buttonRun.Click += new System.EventHandler( this.buttonRun_Click );
			// 
			// buttonAbout
			// 
			resources.ApplyResources( this.buttonAbout, "buttonAbout" );
			this.buttonAbout.ImageList = this.imageListMenu;
			this.buttonAbout.Name = "buttonAbout";
			this.toolTip.SetToolTip( this.buttonAbout, resources.GetString( "buttonAbout.ToolTip" ) );
			this.buttonAbout.UseVisualStyleBackColor = true;
			this.buttonAbout.Click += new System.EventHandler( this.buttonAbout_Click );
			// 
			// buttonHelp
			// 
			resources.ApplyResources( this.buttonHelp, "buttonHelp" );
			this.buttonHelp.ImageList = this.imageListMenu;
			this.buttonHelp.Name = "buttonHelp";
			this.toolTip.SetToolTip( this.buttonHelp, resources.GetString( "buttonHelp.ToolTip" ) );
			this.buttonHelp.UseVisualStyleBackColor = true;
			this.buttonHelp.Click += new System.EventHandler( this.buttonHelp_Click );
			// 
			// buttonSave
			// 
			resources.ApplyResources( this.buttonSave, "buttonSave" );
			this.buttonSave.ImageList = this.imageListMenu;
			this.buttonSave.Name = "buttonSave";
			this.toolTip.SetToolTip( this.buttonSave, resources.GetString( "buttonSave.ToolTip" ) );
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler( this.buttonSave_Click );
			// 
			// buttonOpen
			// 
			resources.ApplyResources( this.buttonOpen, "buttonOpen" );
			this.buttonOpen.ImageList = this.imageListMenu;
			this.buttonOpen.Name = "buttonOpen";
			this.toolTip.SetToolTip( this.buttonOpen, resources.GetString( "buttonOpen.ToolTip" ) );
			this.buttonOpen.UseVisualStyleBackColor = true;
			this.buttonOpen.Click += new System.EventHandler( this.buttonOpen_Click );
			// 
			// groupBoxTape
			// 
			resources.ApplyResources( this.groupBoxTape, "groupBoxTape" );
			this.groupBoxTape.Controls.Add( this.dataGridViewTapeTittle );
			this.groupBoxTape.Controls.Add( this.dataGridViewTape );
			this.groupBoxTape.Name = "groupBoxTape";
			this.groupBoxTape.TabStop = false;
			this.toolTip.SetToolTip( this.groupBoxTape, resources.GetString( "groupBoxTape.ToolTip" ) );
			// 
			// dataGridViewTapeTittle
			// 
			resources.ApplyResources( this.dataGridViewTapeTittle, "dataGridViewTapeTittle" );
			this.dataGridViewTapeTittle.AllowUserToAddRows = false;
			this.dataGridViewTapeTittle.AllowUserToDeleteRows = false;
			this.dataGridViewTapeTittle.AllowUserToResizeColumns = false;
			this.dataGridViewTapeTittle.AllowUserToResizeRows = false;
			this.dataGridViewTapeTittle.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridViewTapeTittle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle17.Font = new System.Drawing.Font( "Wingdings 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 2 ) ) );
			dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTapeTittle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
			this.dataGridViewTapeTittle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridViewTapeTittle.Cursor = System.Windows.Forms.Cursors.Default;
			dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle18.Font = new System.Drawing.Font( "Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 204 ) ) );
			dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewTapeTittle.DefaultCellStyle = dataGridViewCellStyle18;
			this.dataGridViewTapeTittle.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.dataGridViewTapeTittle.Name = "dataGridViewTapeTittle";
			this.dataGridViewTapeTittle.RowHeadersVisible = false;
			this.dataGridViewTapeTittle.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dataGridViewTapeTittle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dataGridViewTapeTittle.TabStop = false;
			this.toolTip.SetToolTip( this.dataGridViewTapeTittle, resources.GetString( "dataGridViewTapeTittle.ToolTip" ) );
			this.dataGridViewTapeTittle.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler( this.dataGridViewTapeTittle_ColumnHeaderMouseClick );
			// 
			// dataGridViewTape
			// 
			resources.ApplyResources( this.dataGridViewTape, "dataGridViewTape" );
			this.dataGridViewTape.AllowUserToAddRows = false;
			this.dataGridViewTape.AllowUserToDeleteRows = false;
			this.dataGridViewTape.AllowUserToResizeColumns = false;
			this.dataGridViewTape.AllowUserToResizeRows = false;
			this.dataGridViewTape.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridViewTape.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle19.Font = new System.Drawing.Font( "Wingdings 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 2 ) ) );
			dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTape.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
			this.dataGridViewTape.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridViewTape.ColumnHeadersVisible = false;
			this.dataGridViewTape.Cursor = System.Windows.Forms.Cursors.Default;
			dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle20.Font = new System.Drawing.Font( "Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 204 ) ) );
			dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewTape.DefaultCellStyle = dataGridViewCellStyle20;
			this.dataGridViewTape.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.dataGridViewTape.Name = "dataGridViewTape";
			this.dataGridViewTape.RowHeadersVisible = false;
			this.dataGridViewTape.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dataGridViewTape.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.toolTip.SetToolTip( this.dataGridViewTape, resources.GetString( "dataGridViewTape.ToolTip" ) );
			this.dataGridViewTape.Scroll += new System.Windows.Forms.ScrollEventHandler( this.dataGridViewTape_Scroll );
			// 
			// groupBoxTable
			// 
			resources.ApplyResources( this.groupBoxTable, "groupBoxTable" );
			this.groupBoxTable.Controls.Add( this.dataGridViewTableTittle );
			this.groupBoxTable.Controls.Add( this.dataGridViewTable );
			this.groupBoxTable.Name = "groupBoxTable";
			this.groupBoxTable.TabStop = false;
			this.toolTip.SetToolTip( this.groupBoxTable, resources.GetString( "groupBoxTable.ToolTip" ) );
			// 
			// dataGridViewTableTittle
			// 
			resources.ApplyResources( this.dataGridViewTableTittle, "dataGridViewTableTittle" );
			this.dataGridViewTableTittle.AllowUserToAddRows = false;
			this.dataGridViewTableTittle.AllowUserToDeleteRows = false;
			this.dataGridViewTableTittle.AllowUserToResizeColumns = false;
			this.dataGridViewTableTittle.AllowUserToResizeRows = false;
			this.dataGridViewTableTittle.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridViewTableTittle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridViewTableTittle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
			dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle21.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 204 ) ) );
			dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTableTittle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
			this.dataGridViewTableTittle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle22.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 204 ) ) );
			dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle22.NullValue = null;
			dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewTableTittle.DefaultCellStyle = dataGridViewCellStyle22;
			this.dataGridViewTableTittle.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.dataGridViewTableTittle.Name = "dataGridViewTableTittle";
			this.dataGridViewTableTittle.ReadOnly = true;
			this.dataGridViewTableTittle.TabStop = false;
			this.toolTip.SetToolTip( this.dataGridViewTableTittle, resources.GetString( "dataGridViewTableTittle.ToolTip" ) );
			// 
			// dataGridViewTable
			// 
			resources.ApplyResources( this.dataGridViewTable, "dataGridViewTable" );
			this.dataGridViewTable.AllowUserToDeleteRows = false;
			this.dataGridViewTable.AllowUserToResizeColumns = false;
			this.dataGridViewTable.AllowUserToResizeRows = false;
			this.dataGridViewTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridViewTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridViewTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
			dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle23.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 204 ) ) );
			dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
			this.dataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle24.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 204 ) ) );
			dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle24.NullValue = null;
			dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewTable.DefaultCellStyle = dataGridViewCellStyle24;
			this.dataGridViewTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.dataGridViewTable.Name = "dataGridViewTable";
			this.toolTip.SetToolTip( this.dataGridViewTable, resources.GetString( "dataGridViewTable.ToolTip" ) );
			this.dataGridViewTable.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler( this.dataGridViewTable_RowsAdded );
			this.dataGridViewTable.Scroll += new System.Windows.Forms.ScrollEventHandler( this.dataGridViewTable_Scroll );
			// 
			// tabControlTabs
			// 
			resources.ApplyResources( this.tabControlTabs, "tabControlTabs" );
			this.tabControlTabs.Controls.Add( this.tabPageTask );
			this.tabControlTabs.Controls.Add( this.tabPageResult );
			this.tabControlTabs.ImageList = this.imageListTabs;
			this.tabControlTabs.Name = "tabControlTabs";
			this.tabControlTabs.SelectedIndex = 0;
			this.toolTip.SetToolTip( this.tabControlTabs, resources.GetString( "tabControlTabs.ToolTip" ) );
			// 
			// tabPageTask
			// 
			resources.ApplyResources( this.tabPageTask, "tabPageTask" );
			this.tabPageTask.Controls.Add( this.groupBoxAlphabet );
			this.tabPageTask.Controls.Add( this.groupBoxTape );
			this.tabPageTask.Controls.Add( this.groupBoxTable );
			this.tabPageTask.Name = "tabPageTask";
			this.toolTip.SetToolTip( this.tabPageTask, resources.GetString( "tabPageTask.ToolTip" ) );
			this.tabPageTask.UseVisualStyleBackColor = true;
			// 
			// groupBoxAlphabet
			// 
			resources.ApplyResources( this.groupBoxAlphabet, "groupBoxAlphabet" );
			this.groupBoxAlphabet.Controls.Add( this.buttonBuild );
			this.groupBoxAlphabet.Controls.Add( this.textBoxAlphabet );
			this.groupBoxAlphabet.Name = "groupBoxAlphabet";
			this.groupBoxAlphabet.TabStop = false;
			this.toolTip.SetToolTip( this.groupBoxAlphabet, resources.GetString( "groupBoxAlphabet.ToolTip" ) );
			// 
			// buttonBuild
			// 
			resources.ApplyResources( this.buttonBuild, "buttonBuild" );
			this.buttonBuild.ImageList = this.imageListContext;
			this.buttonBuild.Name = "buttonBuild";
			this.toolTip.SetToolTip( this.buttonBuild, resources.GetString( "buttonBuild.ToolTip" ) );
			this.buttonBuild.UseVisualStyleBackColor = true;
			this.buttonBuild.Click += new System.EventHandler( this.buttonBuild_Click );
			// 
			// imageListContext
			// 
			this.imageListContext.ImageStream = ( ( System.Windows.Forms.ImageListStreamer ) ( resources.GetObject( "imageListContext.ImageStream" ) ) );
			this.imageListContext.TransparentColor = System.Drawing.Color.Transparent;
			this.imageListContext.Images.SetKeyName( 0, "helmet.png" );
			// 
			// textBoxAlphabet
			// 
			resources.ApplyResources( this.textBoxAlphabet, "textBoxAlphabet" );
			this.textBoxAlphabet.Name = "textBoxAlphabet";
			this.toolTip.SetToolTip( this.textBoxAlphabet, resources.GetString( "textBoxAlphabet.ToolTip" ) );
			this.textBoxAlphabet.Leave += new System.EventHandler( this.textBoxAlphabet_Leave );
			// 
			// tabPageResult
			// 
			resources.ApplyResources( this.tabPageResult, "tabPageResult" );
			this.tabPageResult.Controls.Add( this.toolStripResult );
			this.tabPageResult.Controls.Add( this.listBoxResult );
			this.tabPageResult.Name = "tabPageResult";
			this.toolTip.SetToolTip( this.tabPageResult, resources.GetString( "tabPageResult.ToolTip" ) );
			this.tabPageResult.UseVisualStyleBackColor = true;
			// 
			// toolStripResult
			// 
			resources.ApplyResources( this.toolStripResult, "toolStripResult" );
			this.toolStripResult.Items.AddRange( new System.Windows.Forms.ToolStripItem[ ] {
            this.toolStripButtonClear} );
			this.toolStripResult.Name = "toolStripResult";
			this.toolTip.SetToolTip( this.toolStripResult, resources.GetString( "toolStripResult.ToolTip" ) );
			// 
			// toolStripButtonClear
			// 
			resources.ApplyResources( this.toolStripButtonClear, "toolStripButtonClear" );
			this.toolStripButtonClear.Name = "toolStripButtonClear";
			this.toolStripButtonClear.Click += new System.EventHandler( this.toolStripButtonClear_Click );
			// 
			// listBoxResult
			// 
			resources.ApplyResources( this.listBoxResult, "listBoxResult" );
			this.listBoxResult.FormattingEnabled = true;
			this.listBoxResult.Name = "listBoxResult";
			this.listBoxResult.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.toolTip.SetToolTip( this.listBoxResult, resources.GetString( "listBoxResult.ToolTip" ) );
			// 
			// imageListTabs
			// 
			this.imageListTabs.ImageStream = ( ( System.Windows.Forms.ImageListStreamer ) ( resources.GetObject( "imageListTabs.ImageStream" ) ) );
			this.imageListTabs.TransparentColor = System.Drawing.Color.Transparent;
			this.imageListTabs.Images.SetKeyName( 0, "task_32.png" );
			this.imageListTabs.Images.SetKeyName( 1, "utilities-system-monitor.png" );
			// 
			// buttonNew
			// 
			resources.ApplyResources( this.buttonNew, "buttonNew" );
			this.buttonNew.ImageList = this.imageListMenu;
			this.buttonNew.Name = "buttonNew";
			this.toolTip.SetToolTip( this.buttonNew, resources.GetString( "buttonNew.ToolTip" ) );
			this.buttonNew.UseVisualStyleBackColor = true;
			this.buttonNew.Click += new System.EventHandler( this.buttonNew_Click );
			// 
			// tabControlMenu
			// 
			resources.ApplyResources( this.tabControlMenu, "tabControlMenu" );
			this.tabControlMenu.Controls.Add( this.tabPageFile );
			this.tabControlMenu.Controls.Add( this.tabPageMachine );
			this.tabControlMenu.Name = "tabControlMenu";
			this.tabControlMenu.SelectedIndex = 0;
			this.toolTip.SetToolTip( this.tabControlMenu, resources.GetString( "tabControlMenu.ToolTip" ) );
			// 
			// tabPageFile
			// 
			resources.ApplyResources( this.tabPageFile, "tabPageFile" );
			this.tabPageFile.Controls.Add( this.panelSplitterFile );
			this.tabPageFile.Controls.Add( this.buttonNew );
			this.tabPageFile.Controls.Add( this.buttonSave );
			this.tabPageFile.Controls.Add( this.buttonAbout );
			this.tabPageFile.Controls.Add( this.buttonOpen );
			this.tabPageFile.Controls.Add( this.buttonHelp );
			this.tabPageFile.Name = "tabPageFile";
			this.toolTip.SetToolTip( this.tabPageFile, resources.GetString( "tabPageFile.ToolTip" ) );
			this.tabPageFile.UseVisualStyleBackColor = true;
			// 
			// tabPageMachine
			// 
			resources.ApplyResources( this.tabPageMachine, "tabPageMachine" );
			this.tabPageMachine.Controls.Add( this.buttonMinimization );
			this.tabPageMachine.Controls.Add( this.buttonRun );
			this.tabPageMachine.Controls.Add( this.buttonClear );
			this.tabPageMachine.Name = "tabPageMachine";
			this.toolTip.SetToolTip( this.tabPageMachine, resources.GetString( "tabPageMachine.ToolTip" ) );
			this.tabPageMachine.UseVisualStyleBackColor = true;
			// 
			// buttonMinimization
			// 
			resources.ApplyResources( this.buttonMinimization, "buttonMinimization" );
			this.buttonMinimization.ImageList = this.imageListMenu;
			this.buttonMinimization.Name = "buttonMinimization";
			this.toolTip.SetToolTip( this.buttonMinimization, resources.GetString( "buttonMinimization.ToolTip" ) );
			this.buttonMinimization.UseVisualStyleBackColor = true;
			this.buttonMinimization.Click += new System.EventHandler( this.buttonMinimization_Click );
			// 
			// saveFileDialog
			// 
			this.saveFileDialog.DefaultExt = "tm";
			resources.ApplyResources( this.saveFileDialog, "saveFileDialog" );
			this.saveFileDialog.RestoreDirectory = true;
			// 
			// openFileDialog
			// 
			this.openFileDialog.CheckFileExists = false;
			this.openFileDialog.DefaultExt = "tm";
			resources.ApplyResources( this.openFileDialog, "openFileDialog" );
			this.openFileDialog.RestoreDirectory = true;
			// 
			// FormMain
			// 
			resources.ApplyResources( this, "$this" );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add( this.tabControlMenu );
			this.Controls.Add( this.tabControlTabs );
			this.Controls.Add( this.groupBoxMenu );
			this.DoubleBuffered = true;
			this.KeyPreview = true;
			this.Name = "FormMain";
			this.toolTip.SetToolTip( this, resources.GetString( "$this.ToolTip" ) );
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler( this.FormMain_FormClosing );
			this.Shown += new System.EventHandler( this.FormMain_Shown );
			this.KeyDown += new System.Windows.Forms.KeyEventHandler( this.FormMain_KeyDown );
			this.Resize += new System.EventHandler( this.FormMain_Resize );
			this.groupBoxTape.ResumeLayout( false );
			( ( System.ComponentModel.ISupportInitialize ) ( this.dataGridViewTapeTittle ) ).EndInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.dataGridViewTape ) ).EndInit( );
			this.groupBoxTable.ResumeLayout( false );
			( ( System.ComponentModel.ISupportInitialize ) ( this.dataGridViewTableTittle ) ).EndInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.dataGridViewTable ) ).EndInit( );
			this.tabControlTabs.ResumeLayout( false );
			this.tabPageTask.ResumeLayout( false );
			this.groupBoxAlphabet.ResumeLayout( false );
			this.groupBoxAlphabet.PerformLayout( );
			this.tabPageResult.ResumeLayout( false );
			this.tabPageResult.PerformLayout( );
			this.toolStripResult.ResumeLayout( false );
			this.toolStripResult.PerformLayout( );
			this.tabControlMenu.ResumeLayout( false );
			this.tabPageFile.ResumeLayout( false );
			this.tabPageMachine.ResumeLayout( false );
			this.ResumeLayout( false );

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxMenu;
		private System.Windows.Forms.ImageList imageListMenu;
		private System.Windows.Forms.GroupBox groupBoxTape;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.Button buttonRun;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonOpen;
		private System.Windows.Forms.DataGridView dataGridViewTape;
		private System.Windows.Forms.GroupBox groupBoxTable;
		private System.Windows.Forms.DataGridView dataGridViewTable;
		private System.Windows.Forms.TabControl tabControlTabs;
		private System.Windows.Forms.TabPage tabPageTask;
		private System.Windows.Forms.TabPage tabPageResult;
		private System.Windows.Forms.ListBox listBoxResult;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.Panel panelSplitterFile;
		private System.Windows.Forms.Button buttonAbout;
		private System.Windows.Forms.Button buttonHelp;
		private System.Windows.Forms.ImageList imageListTabs;
		private System.Windows.Forms.GroupBox groupBoxAlphabet;
		private System.Windows.Forms.TextBox textBoxAlphabet;
		private System.Windows.Forms.TabControl tabControlMenu;
		private System.Windows.Forms.TabPage tabPageFile;
		private System.Windows.Forms.TabPage tabPageMachine;
		private System.Windows.Forms.Button buttonNew;
		private System.Windows.Forms.Button buttonBuild;
		private System.Windows.Forms.ToolStrip toolStripResult;
		private System.Windows.Forms.ToolStripButton toolStripButtonClear;
		private System.Windows.Forms.ImageList imageListContext;
		private System.Windows.Forms.DataGridView dataGridViewTableTittle;
		private System.Windows.Forms.DataGridView dataGridViewTapeTittle;
		private System.Windows.Forms.Button buttonMinimization;
	}
}

