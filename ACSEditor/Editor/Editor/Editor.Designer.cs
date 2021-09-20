namespace ACSEditor
{
    partial class Editor
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
			this.tabMain = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.cmsHtml = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiTable = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiTableModify = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiTableInsertRow = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiTableDeleteRow = new System.Windows.Forms.ToolStripMenuItem();
			this.resetColumnWidthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiSelectAll = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiCut = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiPaste = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiFind = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiRemoveFormat = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
			this.tsTopToolBar = new System.Windows.Forms.ToolStrip();
			this.fontComboBox = new System.Windows.Forms.ToolStripComboBox();
			this.fontSizeComboBox = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbBold = new System.Windows.Forms.ToolStripButton();
			this.tsbItalic = new System.Windows.Forms.ToolStripButton();
			this.tsbUnderline = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.colorButton = new System.Windows.Forms.ToolStripButton();
			this.backColorButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.UndoButton = new System.Windows.Forms.ToolStripButton();
			this.RedoButton = new System.Windows.Forms.ToolStripButton();
			this.CutButton = new System.Windows.Forms.ToolStripButton();
			this.CopyButton = new System.Windows.Forms.ToolStripButton();
			this.PasteButton = new System.Windows.Forms.ToolStripButton();
			this.linkButton = new System.Windows.Forms.ToolStripButton();
			this.imageButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbJustifyLeft = new System.Windows.Forms.ToolStripButton();
			this.tsbJustifyCenter = new System.Windows.Forms.ToolStripButton();
			this.tsbJustifyRight = new System.Windows.Forms.ToolStripButton();
			this.tsbJustifyFull = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbInsertOrderedList = new System.Windows.Forms.ToolStripButton();
			this.tsbInsertUnorderedList = new System.Windows.Forms.ToolStripButton();
			this.outdentButton = new System.Windows.Forms.ToolStripButton();
			this.indentButton = new System.Windows.Forms.ToolStripButton();
			this.tsddbInsertTable = new System.Windows.Forms.ToolStripDropDownButton();
			this.tsbSuperscript = new System.Windows.Forms.ToolStripButton();
			this.tsbSubscript = new System.Windows.Forms.ToolStripButton();
			this.tsbPreview = new System.Windows.Forms.ToolStripButton();
			this.spellCheck = new System.Windows.Forms.ToolStripButton();
			this.btnExportPDF = new System.Windows.Forms.ToolStripButton();
			this._cmdSelectField = new System.Windows.Forms.ToolStripButton();
			this.tsbInsertHorizontalRule = new System.Windows.Forms.ToolStripButton();
			this.tsbDate = new System.Windows.Forms.ToolStripButton();
			this.tsbTime = new System.Windows.Forms.ToolStripButton();
			this.tsbClearWord = new System.Windows.Forms.ToolStripButton();
			this.HTML = new System.Windows.Forms.TabPage();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.spelling = new NetSpell.SpellChecker.Spelling(this.components);
			this.wordDictionary = new NetSpell.SpellChecker.Dictionary.WordDictionary(this.components);
			this.ssHtml = new System.Windows.Forms.StatusStrip();
			this.tsslWordCount = new System.Windows.Forms.ToolStripStatusLabel();
			this.tabMain.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.cmsHtml.SuspendLayout();
			this.tsTopToolBar.SuspendLayout();
			this.HTML.SuspendLayout();
			this.ssHtml.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabMain
			// 
			this.tabMain.Controls.Add(this.tabPage1);
			this.tabMain.Controls.Add(this.HTML);
			this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabMain.Location = new System.Drawing.Point(0, 0);
			this.tabMain.Name = "tabMain";
			this.tabMain.SelectedIndex = 0;
			this.tabMain.Size = new System.Drawing.Size(1010, 572);
			this.tabMain.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.webBrowser1);
			this.tabPage1.Controls.Add(this.tsTopToolBar);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1002, 546);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Preview";
			this.tabPage1.ToolTipText = "Preview";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// webBrowser1
			// 
			this.webBrowser1.ContextMenuStrip = this.cmsHtml;
			this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser1.Location = new System.Drawing.Point(3, 28);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.ScriptErrorsSuppressed = true;
			this.webBrowser1.Size = new System.Drawing.Size(996, 515);
			this.webBrowser1.TabIndex = 16;
			this.webBrowser1.Url = new System.Uri("http://-", System.UriKind.Absolute);
			this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
			// 
			// cmsHtml
			// 
			this.cmsHtml.AllowDrop = true;
			this.cmsHtml.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTable,
            this.tsmiSelectAll,
            this.tsmiCopy,
            this.tsmiCut,
            this.tsmiPaste,
            this.tsmiDelete,
            this.tsmiFind,
            this.tsmiRemoveFormat,
            this.toolStripSeparator6,
            this.tsmiSave});
			this.cmsHtml.Name = "contextMenuWeb";
			this.cmsHtml.Size = new System.Drawing.Size(164, 208);
			// 
			// tsmiTable
			// 
			this.tsmiTable.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTableModify,
            this.tsmiTableInsertRow,
            this.tsmiTableDeleteRow,
            this.resetColumnWidthToolStripMenuItem});
			this.tsmiTable.Name = "tsmiTable";
			this.tsmiTable.Size = new System.Drawing.Size(163, 22);
			this.tsmiTable.Tag = "Table";
			this.tsmiTable.Text = "Table";
			// 
			// tsmiTableModify
			// 
			this.tsmiTableModify.Name = "tsmiTableModify";
			this.tsmiTableModify.Size = new System.Drawing.Size(181, 22);
			this.tsmiTableModify.Tag = "TableModify";
			this.tsmiTableModify.Text = "Edit table properties";
			this.tsmiTableModify.Click += new System.EventHandler(this.tsmiInsertTable_Click);
			// 
			// tsmiTableInsertRow
			// 
			this.tsmiTableInsertRow.Name = "tsmiTableInsertRow";
			this.tsmiTableInsertRow.Size = new System.Drawing.Size(181, 22);
			this.tsmiTableInsertRow.Tag = "TableInsertRow";
			this.tsmiTableInsertRow.Text = "Insert Row";
			// 
			// tsmiTableDeleteRow
			// 
			this.tsmiTableDeleteRow.Name = "tsmiTableDeleteRow";
			this.tsmiTableDeleteRow.Size = new System.Drawing.Size(181, 22);
			this.tsmiTableDeleteRow.Tag = "TableDeleteRow";
			this.tsmiTableDeleteRow.Text = "Remove row";
			// 
			// resetColumnWidthToolStripMenuItem
			// 
			this.resetColumnWidthToolStripMenuItem.Name = "resetColumnWidthToolStripMenuItem";
			this.resetColumnWidthToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.resetColumnWidthToolStripMenuItem.Tag = "Resetcolumn ";
			this.resetColumnWidthToolStripMenuItem.Text = "Reset column Width";
			this.resetColumnWidthToolStripMenuItem.ToolTipText = "Resetcolumn ";
			// 
			// tsmiSelectAll
			// 
			this.tsmiSelectAll.Name = "tsmiSelectAll";
			this.tsmiSelectAll.Size = new System.Drawing.Size(163, 22);
			this.tsmiSelectAll.Tag = "SelectAll";
			this.tsmiSelectAll.Text = "select all";
			// 
			// tsmiCopy
			// 
			this.tsmiCopy.Name = "tsmiCopy";
			this.tsmiCopy.Size = new System.Drawing.Size(163, 22);
			this.tsmiCopy.Tag = "Copy";
			this.tsmiCopy.Text = "Copy";
			// 
			// tsmiCut
			// 
			this.tsmiCut.Name = "tsmiCut";
			this.tsmiCut.Size = new System.Drawing.Size(163, 22);
			this.tsmiCut.Tag = "Cut";
			this.tsmiCut.Text = "Cut";
			// 
			// tsmiPaste
			// 
			this.tsmiPaste.Name = "tsmiPaste";
			this.tsmiPaste.Size = new System.Drawing.Size(163, 22);
			this.tsmiPaste.Tag = "Paste";
			this.tsmiPaste.Text = "Paste";
			// 
			// tsmiDelete
			// 
			this.tsmiDelete.Name = "tsmiDelete";
			this.tsmiDelete.Size = new System.Drawing.Size(163, 22);
			this.tsmiDelete.Tag = "Delete";
			this.tsmiDelete.Text = "Delete";
			// 
			// tsmiFind
			// 
			this.tsmiFind.Name = "tsmiFind";
			this.tsmiFind.Size = new System.Drawing.Size(163, 22);
			this.tsmiFind.Tag = "Find";
			this.tsmiFind.Text = "Find";
			// 
			// tsmiRemoveFormat
			// 
			this.tsmiRemoveFormat.Name = "tsmiRemoveFormat";
			this.tsmiRemoveFormat.Size = new System.Drawing.Size(163, 22);
			this.tsmiRemoveFormat.Tag = "RemoveFormat";
			this.tsmiRemoveFormat.Text = "Clear Formatting";
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(160, 6);
			// 
			// tsmiSave
			// 
			this.tsmiSave.Name = "tsmiSave";
			this.tsmiSave.Size = new System.Drawing.Size(163, 22);
			this.tsmiSave.Tag = "Save";
			this.tsmiSave.Text = "Save";
			// 
			// tsTopToolBar
			// 
			this.tsTopToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.tsTopToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontComboBox,
            this.fontSizeComboBox,
            this.toolStripSeparator1,
            this.tsbBold,
            this.tsbItalic,
            this.tsbUnderline,
            this.toolStripSeparator4,
            this.colorButton,
            this.backColorButton,
            this.toolStripSeparator2,
            this.UndoButton,
            this.RedoButton,
            this.CutButton,
            this.CopyButton,
            this.PasteButton,
            this.linkButton,
            this.imageButton,
            this.toolStripSeparator3,
            this.tsbJustifyLeft,
            this.tsbJustifyCenter,
            this.tsbJustifyRight,
            this.tsbJustifyFull,
            this.toolStripSeparator5,
            this.tsbInsertOrderedList,
            this.tsbInsertUnorderedList,
            this.outdentButton,
            this.indentButton,
            this.tsddbInsertTable,
            this.tsbSuperscript,
            this.tsbSubscript,
            this.tsbPreview,
            this.spellCheck,
            this.btnExportPDF,
            this._cmdSelectField,
            this.tsbInsertHorizontalRule,
            this.tsbDate,
            this.tsbTime,
            this.tsbClearWord});
			this.tsTopToolBar.Location = new System.Drawing.Point(3, 3);
			this.tsTopToolBar.Name = "tsTopToolBar";
			this.tsTopToolBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.tsTopToolBar.Size = new System.Drawing.Size(996, 25);
			this.tsTopToolBar.TabIndex = 2;
			this.tsTopToolBar.Text = "toolStrip1";
			// 
			// fontComboBox
			// 
			this.fontComboBox.Name = "fontComboBox";
			this.fontComboBox.Size = new System.Drawing.Size(140, 25);
			this.fontComboBox.ToolTipText = "Font";
			// 
			// fontSizeComboBox
			// 
			this.fontSizeComboBox.Name = "fontSizeComboBox";
			this.fontSizeComboBox.Size = new System.Drawing.Size(75, 25);
			this.fontSizeComboBox.ToolTipText = "Font Size";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// tsbBold
			// 
			this.tsbBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbBold.Image = global::ACSEditor.Properties.Resources.bold;
			this.tsbBold.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbBold.Name = "tsbBold";
			this.tsbBold.Size = new System.Drawing.Size(23, 22);
			this.tsbBold.Text = "toolStripButton1";
			this.tsbBold.ToolTipText = "Bold";
			this.tsbBold.Click += new System.EventHandler(this.tsbBold_Click);
			// 
			// tsbItalic
			// 
			this.tsbItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbItalic.Image = global::ACSEditor.Properties.Resources.italic;
			this.tsbItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbItalic.Name = "tsbItalic";
			this.tsbItalic.Size = new System.Drawing.Size(23, 22);
			this.tsbItalic.Text = "toolStripButton2";
			this.tsbItalic.ToolTipText = "Italic";
			this.tsbItalic.Click += new System.EventHandler(this.tsbItalic_Click);
			// 
			// tsbUnderline
			// 
			this.tsbUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbUnderline.Image = global::ACSEditor.Properties.Resources.underscore;
			this.tsbUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbUnderline.Name = "tsbUnderline";
			this.tsbUnderline.Size = new System.Drawing.Size(23, 22);
			this.tsbUnderline.Text = "toolStripButton3";
			this.tsbUnderline.ToolTipText = "Underline";
			this.tsbUnderline.Click += new System.EventHandler(this.tsbUnderline_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
			// 
			// colorButton
			// 
			this.colorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.colorButton.Image = global::ACSEditor.Properties.Resources.color;
			this.colorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.colorButton.Name = "colorButton";
			this.colorButton.Size = new System.Drawing.Size(23, 22);
			this.colorButton.Text = "toolStripButton3";
			this.colorButton.ToolTipText = "Font Color";
			this.colorButton.Click += new System.EventHandler(this.colorButton_Click_1);
			// 
			// backColorButton
			// 
			this.backColorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.backColorButton.Image = global::ACSEditor.Properties.Resources.backcolor;
			this.backColorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.backColorButton.Name = "backColorButton";
			this.backColorButton.Size = new System.Drawing.Size(23, 22);
			this.backColorButton.Text = "toolStripButton3";
			this.backColorButton.ToolTipText = "Back Color";
			this.backColorButton.Click += new System.EventHandler(this.backColorButton_Click_1);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// UndoButton
			// 
			this.UndoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.UndoButton.Image = global::ACSEditor.Properties.Resources.Undo;
			this.UndoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.UndoButton.Name = "UndoButton";
			this.UndoButton.Size = new System.Drawing.Size(23, 22);
			this.UndoButton.Text = "Undo";
			this.UndoButton.Click += new System.EventHandler(this.UndoButton_Click);
			// 
			// RedoButton
			// 
			this.RedoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.RedoButton.Image = global::ACSEditor.Properties.Resources.Redo;
			this.RedoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.RedoButton.Name = "RedoButton";
			this.RedoButton.Size = new System.Drawing.Size(23, 22);
			this.RedoButton.Text = "Redo";
			this.RedoButton.Click += new System.EventHandler(this.RedoButton_Click);
			// 
			// CutButton
			// 
			this.CutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.CutButton.Image = global::ACSEditor.Properties.Resources.Cut;
			this.CutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.CutButton.Name = "CutButton";
			this.CutButton.Size = new System.Drawing.Size(23, 22);
			this.CutButton.Text = "Cut";
			this.CutButton.Click += new System.EventHandler(this.CutButton_Click);
			// 
			// CopyButton
			// 
			this.CopyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.CopyButton.Image = global::ACSEditor.Properties.Resources.Copy;
			this.CopyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.CopyButton.Name = "CopyButton";
			this.CopyButton.Size = new System.Drawing.Size(23, 22);
			this.CopyButton.Text = "CopyButton";
			this.CopyButton.ToolTipText = "Copy";
			this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
			// 
			// PasteButton
			// 
			this.PasteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.PasteButton.Image = global::ACSEditor.Properties.Resources.Paste;
			this.PasteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.PasteButton.Name = "PasteButton";
			this.PasteButton.Size = new System.Drawing.Size(23, 22);
			this.PasteButton.Text = "Paste";
			this.PasteButton.Click += new System.EventHandler(this.PasteButton_Click);
			// 
			// linkButton
			// 
			this.linkButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.linkButton.Image = global::ACSEditor.Properties.Resources.link;
			this.linkButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.linkButton.Name = "linkButton";
			this.linkButton.Size = new System.Drawing.Size(23, 22);
			this.linkButton.Text = "toolStripButton3";
			this.linkButton.ToolTipText = "Hyperlink";
			this.linkButton.Click += new System.EventHandler(this.linkButton_Click_1);
			// 
			// imageButton
			// 
			this.imageButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.imageButton.Image = global::ACSEditor.Properties.Resources.image;
			this.imageButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.imageButton.Name = "imageButton";
			this.imageButton.Size = new System.Drawing.Size(23, 22);
			this.imageButton.Text = "toolStripButton3";
			this.imageButton.ToolTipText = "Image";
			this.imageButton.Click += new System.EventHandler(this.imageButton_Click_1);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// tsbJustifyLeft
			// 
			this.tsbJustifyLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbJustifyLeft.Image = global::ACSEditor.Properties.Resources.lj;
			this.tsbJustifyLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbJustifyLeft.Name = "tsbJustifyLeft";
			this.tsbJustifyLeft.Size = new System.Drawing.Size(23, 22);
			this.tsbJustifyLeft.Tag = "JustifyLeft";
			this.tsbJustifyLeft.Text = "Left-aligned";
			this.tsbJustifyLeft.ToolTipText = "Justify Left";
			this.tsbJustifyLeft.Click += new System.EventHandler(this.tsbJustifyLeft_Click);
			// 
			// tsbJustifyCenter
			// 
			this.tsbJustifyCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbJustifyCenter.Image = global::ACSEditor.Properties.Resources.cj;
			this.tsbJustifyCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbJustifyCenter.Name = "tsbJustifyCenter";
			this.tsbJustifyCenter.Size = new System.Drawing.Size(23, 22);
			this.tsbJustifyCenter.Tag = "JustifyCenter";
			this.tsbJustifyCenter.Text = "Center";
			this.tsbJustifyCenter.ToolTipText = "Align 0";
			this.tsbJustifyCenter.Click += new System.EventHandler(this.tsbJustifyCenter_Click);
			// 
			// tsbJustifyRight
			// 
			this.tsbJustifyRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbJustifyRight.Image = global::ACSEditor.Properties.Resources.rj;
			this.tsbJustifyRight.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbJustifyRight.Name = "tsbJustifyRight";
			this.tsbJustifyRight.Size = new System.Drawing.Size(23, 22);
			this.tsbJustifyRight.Tag = "JustifyRight";
			this.tsbJustifyRight.Text = "Align Right";
			this.tsbJustifyRight.ToolTipText = "Justify Right";
			this.tsbJustifyRight.Click += new System.EventHandler(this.tsbJustifyRight_Click);
			// 
			// tsbJustifyFull
			// 
			this.tsbJustifyFull.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbJustifyFull.Image = global::ACSEditor.Properties.Resources.fj;
			this.tsbJustifyFull.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbJustifyFull.Name = "tsbJustifyFull";
			this.tsbJustifyFull.Size = new System.Drawing.Size(23, 22);
			this.tsbJustifyFull.Tag = "JustifyFull";
			this.tsbJustifyFull.Text = "Justify";
			this.tsbJustifyFull.ToolTipText = "Justify";
			this.tsbJustifyFull.Click += new System.EventHandler(this.tsbJustifyFull_Click);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
			// 
			// tsbInsertOrderedList
			// 
			this.tsbInsertOrderedList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbInsertOrderedList.Image = global::ACSEditor.Properties.Resources.ol;
			this.tsbInsertOrderedList.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbInsertOrderedList.Name = "tsbInsertOrderedList";
			this.tsbInsertOrderedList.Size = new System.Drawing.Size(23, 22);
			this.tsbInsertOrderedList.Tag = "InsertOrderedList";
			this.tsbInsertOrderedList.Text = "Insert an ordered list";
			this.tsbInsertOrderedList.ToolTipText = "Ordered List";
			this.tsbInsertOrderedList.Click += new System.EventHandler(this.tsbInsertOrderedList_Click);
			// 
			// tsbInsertUnorderedList
			// 
			this.tsbInsertUnorderedList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbInsertUnorderedList.Image = global::ACSEditor.Properties.Resources.uol;
			this.tsbInsertUnorderedList.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbInsertUnorderedList.Name = "tsbInsertUnorderedList";
			this.tsbInsertUnorderedList.Size = new System.Drawing.Size(23, 22);
			this.tsbInsertUnorderedList.Tag = "InsertUnorderedList";
			this.tsbInsertUnorderedList.Text = "Insert an unordered list";
			this.tsbInsertUnorderedList.ToolTipText = "Unordered List";
			this.tsbInsertUnorderedList.Click += new System.EventHandler(this.tsbInsertUnorderedList_Click);
			// 
			// outdentButton
			// 
			this.outdentButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.outdentButton.Image = global::ACSEditor.Properties.Resources.Outdent1;
			this.outdentButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.outdentButton.Name = "outdentButton";
			this.outdentButton.Size = new System.Drawing.Size(23, 22);
			this.outdentButton.Text = "toolStripButton3";
			this.outdentButton.ToolTipText = "Outdent";
			this.outdentButton.Click += new System.EventHandler(this.outdentButton_Click_1);
			// 
			// indentButton
			// 
			this.indentButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.indentButton.Image = global::ACSEditor.Properties.Resources.Indent1;
			this.indentButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.indentButton.Name = "indentButton";
			this.indentButton.Size = new System.Drawing.Size(23, 22);
			this.indentButton.Text = "toolStripButton4";
			this.indentButton.ToolTipText = "Indent";
			this.indentButton.Click += new System.EventHandler(this.indentButton_Click_1);
			// 
			// tsddbInsertTable
			// 
			this.tsddbInsertTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsddbInsertTable.Image = global::ACSEditor.Properties.Resources.InsertTable;
			this.tsddbInsertTable.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsddbInsertTable.Name = "tsddbInsertTable";
			this.tsddbInsertTable.Size = new System.Drawing.Size(29, 22);
			this.tsddbInsertTable.Text = "Insert Table";
			// 
			// tsbSuperscript
			// 
			this.tsbSuperscript.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbSuperscript.Image = global::ACSEditor.Properties.Resources.Superscript_;
			this.tsbSuperscript.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbSuperscript.Name = "tsbSuperscript";
			this.tsbSuperscript.Size = new System.Drawing.Size(23, 22);
			this.tsbSuperscript.Tag = "Superscript";
			this.tsbSuperscript.Text = "Superscript";
			this.tsbSuperscript.Click += new System.EventHandler(this.tsbSuperscript_Click_1);
			// 
			// tsbSubscript
			// 
			this.tsbSubscript.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbSubscript.Image = global::ACSEditor.Properties.Resources.Subscript_;
			this.tsbSubscript.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbSubscript.Name = "tsbSubscript";
			this.tsbSubscript.Size = new System.Drawing.Size(23, 22);
			this.tsbSubscript.Tag = "Subscript";
			this.tsbSubscript.Text = "Subscript";
			this.tsbSubscript.Click += new System.EventHandler(this.tsbSubscript_Click_1);
			// 
			// tsbPreview
			// 
			this.tsbPreview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbPreview.Image = global::ACSEditor.Properties.Resources.Preview;
			this.tsbPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbPreview.Name = "tsbPreview";
			this.tsbPreview.Size = new System.Drawing.Size(23, 22);
			this.tsbPreview.Tag = "Preview";
			this.tsbPreview.Text = "Preview";
			this.tsbPreview.Click += new System.EventHandler(this.tsbPreview_Click_1);
			// 
			// spellCheck
			// 
			this.spellCheck.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.spellCheck.Image = global::ACSEditor.Properties.Resources.SpellCheck;
			this.spellCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.spellCheck.Name = "spellCheck";
			this.spellCheck.Size = new System.Drawing.Size(23, 22);
			this.spellCheck.Tag = "SpellCheck";
			this.spellCheck.Text = "Spell Check";
			this.spellCheck.ToolTipText = "Spell Check";
			this.spellCheck.Click += new System.EventHandler(this.tsbSpellCheck_Click);
			// 
			// btnExportPDF
			// 
			this.btnExportPDF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnExportPDF.Image = global::ACSEditor.Properties.Resources.pdf;
			this.btnExportPDF.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnExportPDF.Name = "btnExportPDF";
			this.btnExportPDF.Size = new System.Drawing.Size(23, 22);
			this.btnExportPDF.Tag = "Export PDF";
			this.btnExportPDF.Text = "Export PDF";
			this.btnExportPDF.Click += new System.EventHandler(this.btnExportPDF_Click);
			// 
			// _cmdSelectField
			// 
			this._cmdSelectField.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._cmdSelectField.Image = ((System.Drawing.Image)(resources.GetObject("_cmdSelectField.Image")));
			this._cmdSelectField.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._cmdSelectField.Name = "_cmdSelectField";
			this._cmdSelectField.Size = new System.Drawing.Size(23, 22);
			this._cmdSelectField.Text = "Insert Field";
			this._cmdSelectField.Click += new System.EventHandler(this._cmdSelectField_Click);
			// 
			// tsbInsertHorizontalRule
			// 
			this.tsbInsertHorizontalRule.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbInsertHorizontalRule.Image = ((System.Drawing.Image)(resources.GetObject("tsbInsertHorizontalRule.Image")));
			this.tsbInsertHorizontalRule.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbInsertHorizontalRule.Name = "tsbInsertHorizontalRule";
			this.tsbInsertHorizontalRule.Size = new System.Drawing.Size(23, 22);
			this.tsbInsertHorizontalRule.Text = "Insert Horz Line";
			this.tsbInsertHorizontalRule.Click += new System.EventHandler(this.tsbInsertHorizontalRule_Click);
			// 
			// tsbDate
			// 
			this.tsbDate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbDate.Image = ((System.Drawing.Image)(resources.GetObject("tsbDate.Image")));
			this.tsbDate.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbDate.Name = "tsbDate";
			this.tsbDate.Size = new System.Drawing.Size(23, 22);
			this.tsbDate.Text = "InsertDate";
			this.tsbDate.Click += new System.EventHandler(this.tsbDate_Click);
			// 
			// tsbTime
			// 
			this.tsbTime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbTime.Image = ((System.Drawing.Image)(resources.GetObject("tsbTime.Image")));
			this.tsbTime.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbTime.Name = "tsbTime";
			this.tsbTime.Size = new System.Drawing.Size(23, 22);
			this.tsbTime.Text = "InsertTime";
			this.tsbTime.Click += new System.EventHandler(this.tsbTime_Click);
			// 
			// tsbClearWord
			// 
			this.tsbClearWord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbClearWord.Image = global::ACSEditor.Properties.Resources.Wordclean;
			this.tsbClearWord.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbClearWord.Name = "tsbClearWord";
			this.tsbClearWord.Size = new System.Drawing.Size(23, 22);
			this.tsbClearWord.Text = "Clear Word";
			this.tsbClearWord.Click += new System.EventHandler(this.tsbClearWord_Click);
			// 
			// HTML
			// 
			this.HTML.Controls.Add(this.richTextBox2);
			this.HTML.Location = new System.Drawing.Point(4, 22);
			this.HTML.Name = "HTML";
			this.HTML.Padding = new System.Windows.Forms.Padding(3);
			this.HTML.Size = new System.Drawing.Size(1002, 546);
			this.HTML.TabIndex = 1;
			this.HTML.Text = "HTML";
			this.HTML.ToolTipText = "HTML";
			this.HTML.UseVisualStyleBackColor = true;
			// 
			// richTextBox2
			// 
			this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox2.Location = new System.Drawing.Point(3, 3);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new System.Drawing.Size(996, 540);
			this.richTextBox2.TabIndex = 0;
			this.richTextBox2.Text = "";
			// 
			// spelling
			// 
			this.spelling.Dictionary = null;
			// 
			// ssHtml
			// 
			this.ssHtml.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslWordCount});
			this.ssHtml.Location = new System.Drawing.Point(0, 550);
			this.ssHtml.Name = "ssHtml";
			this.ssHtml.Size = new System.Drawing.Size(1010, 22);
			this.ssHtml.TabIndex = 2;
			this.ssHtml.Text = "statusStrip1";
			// 
			// tsslWordCount
			// 
			this.tsslWordCount.Name = "tsslWordCount";
			this.tsslWordCount.Size = new System.Drawing.Size(72, 17);
			this.tsslWordCount.Text = "Word Count";
			// 
			// Editor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ssHtml);
			this.Controls.Add(this.tabMain);
			this.Name = "Editor";
			this.Size = new System.Drawing.Size(1010, 572);
			this.tabMain.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.cmsHtml.ResumeLayout(false);
			this.tsTopToolBar.ResumeLayout(false);
			this.tsTopToolBar.PerformLayout();
			this.HTML.ResumeLayout(false);
			this.ssHtml.ResumeLayout(false);
			this.ssHtml.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.TabControl tabMain;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage HTML;
		public System.Windows.Forms.ToolStrip tsTopToolBar;
		public System.Windows.Forms.ToolStripComboBox fontComboBox;
		private System.Windows.Forms.ToolStripComboBox fontSizeComboBox;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton tsbBold;
		private System.Windows.Forms.ToolStripButton tsbItalic;
		private System.Windows.Forms.ToolStripButton tsbUnderline;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripButton colorButton;
		private System.Windows.Forms.ToolStripButton backColorButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton linkButton;
		private System.Windows.Forms.ToolStripButton imageButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton tsbJustifyLeft;
		private System.Windows.Forms.ToolStripButton tsbJustifyCenter;
		private System.Windows.Forms.ToolStripButton tsbJustifyRight;
		private System.Windows.Forms.ToolStripButton tsbJustifyFull;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripButton tsbInsertOrderedList;
		private System.Windows.Forms.ToolStripButton tsbInsertUnorderedList;
		private System.Windows.Forms.ToolStripButton outdentButton;
		private System.Windows.Forms.ToolStripButton indentButton;
		private System.Windows.Forms.ToolStripDropDownButton tsddbInsertTable;
		private System.Windows.Forms.ToolStripButton tsbSuperscript;
		private System.Windows.Forms.ToolStripButton tsbSubscript;
		private System.Windows.Forms.ToolStripButton tsbPreview;
		private System.Windows.Forms.ToolStripButton spellCheck;
		private System.Windows.Forms.ToolStripButton btnExportPDF;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.ContextMenuStrip cmsHtml;
		private System.Windows.Forms.ToolStripMenuItem tsmiTable;
		private System.Windows.Forms.ToolStripMenuItem tsmiTableModify;
		private System.Windows.Forms.ToolStripMenuItem tsmiTableInsertRow;
		private System.Windows.Forms.ToolStripMenuItem tsmiTableDeleteRow;
		private System.Windows.Forms.ToolStripMenuItem resetColumnWidthToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmiSelectAll;
		private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
		private System.Windows.Forms.ToolStripMenuItem tsmiCut;
		private System.Windows.Forms.ToolStripMenuItem tsmiPaste;
		private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
		private System.Windows.Forms.ToolStripMenuItem tsmiFind;
		private System.Windows.Forms.ToolStripMenuItem tsmiRemoveFormat;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripMenuItem tsmiSave;
		public System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.ToolStripButton CopyButton;
		private System.Windows.Forms.ToolStripButton UndoButton;
		private System.Windows.Forms.ToolStripButton RedoButton;
		private System.Windows.Forms.ToolStripButton CutButton;
		private System.Windows.Forms.ToolStripButton PasteButton;
		private System.Windows.Forms.ToolStripButton _cmdSelectField;
		private System.Windows.Forms.RichTextBox richTextBox2;
		private NetSpell.SpellChecker.Spelling spelling;
		private NetSpell.SpellChecker.Dictionary.WordDictionary wordDictionary;
		private System.Windows.Forms.ToolStripButton tsbInsertHorizontalRule;
		private System.Windows.Forms.ToolStripButton tsbDate;
		private System.Windows.Forms.ToolStripButton tsbTime;
		private System.Windows.Forms.ToolStripButton tsbClearWord;
		private System.Windows.Forms.StatusStrip ssHtml;
		private System.Windows.Forms.ToolStripStatusLabel tsslWordCount;

	}
}

 