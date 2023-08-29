namespace Wiki_Prototype
{
    partial class WikiPrototype
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ToolTip = new ToolTip(components);
            ButtonLoad = new Button();
            ButtonSave = new Button();
            TextBoxSearch = new TextBox();
            ButtonSearch = new Button();
            TextBoxName = new TextBox();
            TextBoxCategory = new TextBox();
            TextBoxStructure = new TextBox();
            TextBoxDefinition = new TextBox();
            ListViewWiki = new ListView();
            ColumnName = new ColumnHeader();
            ColumnCategory = new ColumnHeader();
            ButtonDemo = new Button();
            ButtonSort = new Button();
            ButtonAdd = new Button();
            ButtonEdit = new Button();
            ButtonDelete = new Button();
            StatusStrip = new StatusStrip();
            StatusBar = new ToolStripStatusLabel();
            LabelName = new Label();
            LabelCategory = new Label();
            LabelStructure = new Label();
            LabelDefinition = new Label();
            StatusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // ButtonLoad
            // 
            ButtonLoad.Location = new Point(355, 302);
            ButtonLoad.Name = "ButtonLoad";
            ButtonLoad.Size = new Size(75, 23);
            ButtonLoad.TabIndex = 2;
            ButtonLoad.Text = "Load";
            ToolTip.SetToolTip(ButtonLoad, "Load a file to pull record from.");
            ButtonLoad.UseVisualStyleBackColor = true;
            ButtonLoad.Click += ButtonLoad_Click;
            // 
            // ButtonSave
            // 
            ButtonSave.Location = new Point(436, 302);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(75, 23);
            ButtonSave.TabIndex = 3;
            ButtonSave.Text = "Save";
            ToolTip.SetToolTip(ButtonSave, "Save records to a file.");
            ButtonSave.UseVisualStyleBackColor = true;
            ButtonSave.Click += ButtonSave_Click;
            // 
            // TextBoxSearch
            // 
            TextBoxSearch.Location = new Point(423, 13);
            TextBoxSearch.Name = "TextBoxSearch";
            TextBoxSearch.Size = new Size(143, 23);
            TextBoxSearch.TabIndex = 4;
            ToolTip.SetToolTip(TextBoxSearch, "Search term to search the records with.");
            TextBoxSearch.KeyDown += TextBoxSearch_KeyDown;
            // 
            // ButtonSearch
            // 
            ButtonSearch.Location = new Point(355, 12);
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new Size(62, 23);
            ButtonSearch.TabIndex = 5;
            ButtonSearch.Text = "Search";
            ToolTip.SetToolTip(ButtonSearch, "Search the records for the given entry.");
            ButtonSearch.UseVisualStyleBackColor = true;
            ButtonSearch.Click += ButtonSearch_Click;
            // 
            // TextBoxName
            // 
            TextBoxName.Location = new Point(74, 11);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.Size = new Size(100, 23);
            TextBoxName.TabIndex = 6;
            ToolTip.SetToolTip(TextBoxName, "Name of the record. Double clicking here will clear the record boxes.");
            TextBoxName.MouseDoubleClick += TextBoxName_MouseDoubleClick;
            // 
            // TextBoxCategory
            // 
            TextBoxCategory.Location = new Point(74, 40);
            TextBoxCategory.Name = "TextBoxCategory";
            TextBoxCategory.Size = new Size(100, 23);
            TextBoxCategory.TabIndex = 7;
            ToolTip.SetToolTip(TextBoxCategory, "The category the record falls under.");
            // 
            // TextBoxStructure
            // 
            TextBoxStructure.Location = new Point(74, 69);
            TextBoxStructure.Name = "TextBoxStructure";
            TextBoxStructure.Size = new Size(100, 23);
            TextBoxStructure.TabIndex = 8;
            ToolTip.SetToolTip(TextBoxStructure, "The type of structure the record is.");
            // 
            // TextBoxDefinition
            // 
            TextBoxDefinition.Location = new Point(12, 116);
            TextBoxDefinition.Multiline = true;
            TextBoxDefinition.Name = "TextBoxDefinition";
            TextBoxDefinition.Size = new Size(296, 166);
            TextBoxDefinition.TabIndex = 12;
            ToolTip.SetToolTip(TextBoxDefinition, "The definition of the record.");
            // 
            // ListViewWiki
            // 
            ListViewWiki.Columns.AddRange(new ColumnHeader[] { ColumnName, ColumnCategory });
            ListViewWiki.FullRowSelect = true;
            ListViewWiki.GridLines = true;
            ListViewWiki.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ListViewWiki.Location = new Point(355, 40);
            ListViewWiki.MultiSelect = false;
            ListViewWiki.Name = "ListViewWiki";
            ListViewWiki.Size = new Size(286, 256);
            ListViewWiki.TabIndex = 17;
            ToolTip.SetToolTip(ListViewWiki, "List of records.");
            ListViewWiki.UseCompatibleStateImageBehavior = false;
            ListViewWiki.View = View.Details;
            ListViewWiki.SelectedIndexChanged += ListViewWiki_SelectedIndexChanged;
            ListViewWiki.Click += ListViewWiki_Click;
            ListViewWiki.MouseDoubleClick += ListViewWiki_MouseDoubleClick;
            // 
            // ColumnName
            // 
            ColumnName.Text = "Name";
            ColumnName.Width = 141;
            // 
            // ColumnCategory
            // 
            ColumnCategory.Text = "Category";
            ColumnCategory.Width = 141;
            // 
            // ButtonDemo
            // 
            ButtonDemo.Location = new Point(274, 302);
            ButtonDemo.Name = "ButtonDemo";
            ButtonDemo.Size = new Size(75, 23);
            ButtonDemo.TabIndex = 18;
            ButtonDemo.Text = "Demo";
            ToolTip.SetToolTip(ButtonDemo, "Load in demo records.");
            ButtonDemo.UseVisualStyleBackColor = true;
            ButtonDemo.Click += ButtonDemo_Click;
            // 
            // ButtonSort
            // 
            ButtonSort.Location = new Point(566, 302);
            ButtonSort.Name = "ButtonSort";
            ButtonSort.Size = new Size(75, 23);
            ButtonSort.TabIndex = 19;
            ButtonSort.Text = "Sort";
            ToolTip.SetToolTip(ButtonSort, "Sort the records.");
            ButtonSort.UseVisualStyleBackColor = true;
            ButtonSort.Click += ButtonSort_Click;
            // 
            // ButtonAdd
            // 
            ButtonAdd.Location = new Point(194, 12);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(75, 23);
            ButtonAdd.TabIndex = 14;
            ButtonAdd.Text = "ADD";
            ToolTip.SetToolTip(ButtonAdd, "Adds an entry to the wiki with the text boxes.");
            ButtonAdd.UseVisualStyleBackColor = true;
            ButtonAdd.Click += ButtonAdd_Click;
            // 
            // ButtonEdit
            // 
            ButtonEdit.Location = new Point(194, 40);
            ButtonEdit.Name = "ButtonEdit";
            ButtonEdit.Size = new Size(75, 23);
            ButtonEdit.TabIndex = 15;
            ButtonEdit.Text = "EDIT";
            ToolTip.SetToolTip(ButtonEdit, "Overwrites an existing entry with the user's changes.");
            ButtonEdit.UseVisualStyleBackColor = true;
            ButtonEdit.Click += ButtonEdit_Click;
            // 
            // ButtonDelete
            // 
            ButtonDelete.Location = new Point(194, 69);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(75, 23);
            ButtonDelete.TabIndex = 16;
            ButtonDelete.Text = "DELETE";
            ToolTip.SetToolTip(ButtonDelete, "Deletes the selected entry from the records.");
            ButtonDelete.UseVisualStyleBackColor = true;
            ButtonDelete.Click += ButtonDelete_Click;
            // 
            // StatusStrip
            // 
            StatusStrip.Items.AddRange(new ToolStripItem[] { StatusBar });
            StatusStrip.Location = new Point(0, 326);
            StatusStrip.Name = "StatusStrip";
            StatusStrip.Size = new Size(672, 22);
            StatusStrip.SizingGrip = false;
            StatusStrip.TabIndex = 1;
            StatusStrip.Text = "statusStrip1";
            // 
            // StatusBar
            // 
            StatusBar.Name = "StatusBar";
            StatusBar.Size = new Size(0, 17);
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Location = new Point(12, 11);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(39, 15);
            LabelName.TabIndex = 9;
            LabelName.Text = "Name";
            // 
            // LabelCategory
            // 
            LabelCategory.AutoSize = true;
            LabelCategory.Location = new Point(12, 40);
            LabelCategory.Name = "LabelCategory";
            LabelCategory.Size = new Size(55, 15);
            LabelCategory.TabIndex = 10;
            LabelCategory.Text = "Category";
            // 
            // LabelStructure
            // 
            LabelStructure.AutoSize = true;
            LabelStructure.Location = new Point(12, 69);
            LabelStructure.Name = "LabelStructure";
            LabelStructure.Size = new Size(55, 15);
            LabelStructure.TabIndex = 11;
            LabelStructure.Text = "Structure";
            // 
            // LabelDefinition
            // 
            LabelDefinition.AutoSize = true;
            LabelDefinition.Location = new Point(12, 98);
            LabelDefinition.Name = "LabelDefinition";
            LabelDefinition.Size = new Size(59, 15);
            LabelDefinition.TabIndex = 13;
            LabelDefinition.Text = "Definition";
            // 
            // WikiPrototype
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 348);
            Controls.Add(ButtonSort);
            Controls.Add(ButtonDemo);
            Controls.Add(ListViewWiki);
            Controls.Add(ButtonDelete);
            Controls.Add(ButtonEdit);
            Controls.Add(ButtonAdd);
            Controls.Add(LabelDefinition);
            Controls.Add(TextBoxDefinition);
            Controls.Add(LabelStructure);
            Controls.Add(LabelCategory);
            Controls.Add(LabelName);
            Controls.Add(TextBoxStructure);
            Controls.Add(TextBoxCategory);
            Controls.Add(TextBoxName);
            Controls.Add(ButtonSearch);
            Controls.Add(TextBoxSearch);
            Controls.Add(ButtonSave);
            Controls.Add(ButtonLoad);
            Controls.Add(StatusStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "WikiPrototype";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "WikiPrototype";
            StatusStrip.ResumeLayout(false);
            StatusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolTip ToolTip;
        private StatusStrip StatusStrip;
        private Button ButtonLoad;
        private Button ButtonSave;
        private TextBox TextBoxSearch;
        private Button ButtonSearch;
        private TextBox TextBoxName;
        private TextBox TextBoxCategory;
        private TextBox TextBoxStructure;
        private Label LabelName;
        private Label LabelCategory;
        private Label LabelStructure;
        private TextBox TextBoxDefinition;
        private Label LabelDefinition;
        private Button ButtonAdd;
        private Button ButtonEdit;
        private Button ButtonDelete;
        private ListView ListViewWiki;
        private ColumnHeader ColumnName;
        private ColumnHeader ColumnCategory;
        private ToolStripStatusLabel StatusBar;
        private Button ButtonDemo;
        private Button ButtonSort;
    }
}