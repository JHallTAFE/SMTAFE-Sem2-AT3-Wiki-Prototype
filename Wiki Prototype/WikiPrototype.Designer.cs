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
            StatusStrip = new StatusStrip();
            StatusBar = new ToolStripStatusLabel();
            ButtonLoad = new Button();
            ButtonSave = new Button();
            TextBoxSearch = new TextBox();
            ButtonSearch = new Button();
            TextBoxName = new TextBox();
            TextBoxCategory = new TextBox();
            TextBoxStructure = new TextBox();
            LabelName = new Label();
            LabelCategory = new Label();
            LabelStructure = new Label();
            TextBoxDefinition = new TextBox();
            LabelDefinition = new Label();
            ButtonAdd = new Button();
            ButtonEdit = new Button();
            ButtonDelete = new Button();
            ListViewWiki = new ListView();
            ColumnName = new ColumnHeader();
            ColumnCategory = new ColumnHeader();
            ColumnStructure = new ColumnHeader();
            ButtonDemo = new Button();
            ButtonSort = new Button();
            StatusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // StatusStrip
            // 
            StatusStrip.Items.AddRange(new ToolStripItem[] { StatusBar });
            StatusStrip.Location = new Point(0, 389);
            StatusStrip.Name = "StatusStrip";
            StatusStrip.Size = new Size(784, 22);
            StatusStrip.TabIndex = 1;
            StatusStrip.Text = "statusStrip1";
            // 
            // StatusBar
            // 
            StatusBar.Name = "StatusBar";
            StatusBar.Size = new Size(0, 17);
            // 
            // ButtonLoad
            // 
            ButtonLoad.Location = new Point(355, 251);
            ButtonLoad.Name = "ButtonLoad";
            ButtonLoad.Size = new Size(75, 23);
            ButtonLoad.TabIndex = 2;
            ButtonLoad.Text = "Load";
            ButtonLoad.UseVisualStyleBackColor = true;
            // 
            // ButtonSave
            // 
            ButtonSave.Location = new Point(436, 251);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(75, 23);
            ButtonSave.TabIndex = 3;
            ButtonSave.Text = "Save";
            ButtonSave.UseVisualStyleBackColor = true;
            // 
            // TextBoxSearch
            // 
            TextBoxSearch.Location = new Point(355, 12);
            TextBoxSearch.Name = "TextBoxSearch";
            TextBoxSearch.Size = new Size(149, 23);
            TextBoxSearch.TabIndex = 4;
            // 
            // ButtonSearch
            // 
            ButtonSearch.Location = new Point(510, 11);
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new Size(62, 23);
            ButtonSearch.TabIndex = 5;
            ButtonSearch.Text = "Search";
            ButtonSearch.UseVisualStyleBackColor = true;
            // 
            // TextBoxName
            // 
            TextBoxName.Location = new Point(74, 11);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.Size = new Size(100, 23);
            TextBoxName.TabIndex = 6;
            TextBoxName.MouseDoubleClick += TextBoxName_MouseDoubleClick;
            // 
            // TextBoxCategory
            // 
            TextBoxCategory.Location = new Point(74, 40);
            TextBoxCategory.Name = "TextBoxCategory";
            TextBoxCategory.Size = new Size(100, 23);
            TextBoxCategory.TabIndex = 7;
            // 
            // TextBoxStructure
            // 
            TextBoxStructure.Location = new Point(74, 69);
            TextBoxStructure.Name = "TextBoxStructure";
            TextBoxStructure.Size = new Size(100, 23);
            TextBoxStructure.TabIndex = 8;
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
            // TextBoxDefinition
            // 
            TextBoxDefinition.Location = new Point(12, 116);
            TextBoxDefinition.Multiline = true;
            TextBoxDefinition.Name = "TextBoxDefinition";
            TextBoxDefinition.Size = new Size(296, 129);
            TextBoxDefinition.TabIndex = 12;
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
            // ButtonAdd
            // 
            ButtonAdd.Location = new Point(194, 12);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(75, 23);
            ButtonAdd.TabIndex = 14;
            ButtonAdd.Text = "ADD";
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
            ButtonDelete.UseVisualStyleBackColor = true;
            ButtonDelete.Click += ButtonDelete_Click;
            // 
            // ListViewWiki
            // 
            ListViewWiki.Columns.AddRange(new ColumnHeader[] { ColumnName, ColumnCategory, ColumnStructure });
            ListViewWiki.FullRowSelect = true;
            ListViewWiki.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ListViewWiki.Location = new Point(355, 41);
            ListViewWiki.MultiSelect = false;
            ListViewWiki.Name = "ListViewWiki";
            ListViewWiki.Size = new Size(286, 204);
            ListViewWiki.TabIndex = 17;
            ListViewWiki.UseCompatibleStateImageBehavior = false;
            ListViewWiki.View = View.Details;
            ListViewWiki.SelectedIndexChanged += ListViewWiki_SelectedIndexChanged;
            ListViewWiki.Click += ListViewWiki_Click;
            ListViewWiki.MouseDoubleClick += ListViewWiki_MouseDoubleClick;
            // 
            // ColumnName
            // 
            ColumnName.Text = "Name";
            ColumnName.Width = 122;
            // 
            // ColumnCategory
            // 
            ColumnCategory.Text = "Category";
            ColumnCategory.Width = 80;
            // 
            // ColumnStructure
            // 
            ColumnStructure.Text = "Structure";
            ColumnStructure.Width = 80;
            // 
            // ButtonDemo
            // 
            ButtonDemo.Location = new Point(566, 251);
            ButtonDemo.Name = "ButtonDemo";
            ButtonDemo.Size = new Size(75, 23);
            ButtonDemo.TabIndex = 18;
            ButtonDemo.Text = "Demo";
            ButtonDemo.UseVisualStyleBackColor = true;
            ButtonDemo.Click += ButtonDemo_Click;
            // 
            // ButtonSort
            // 
            ButtonSort.Location = new Point(566, 280);
            ButtonSort.Name = "ButtonSort";
            ButtonSort.Size = new Size(75, 23);
            ButtonSort.TabIndex = 19;
            ButtonSort.Text = "Sort";
            ButtonSort.UseVisualStyleBackColor = true;
            ButtonSort.Click += ButtonSort_Click;
            // 
            // WikiPrototype
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
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
        private ColumnHeader ColumnStructure;
        private ToolStripStatusLabel StatusBar;
        private Button ButtonDemo;
        private Button ButtonSort;
    }
}