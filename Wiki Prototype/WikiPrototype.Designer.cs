﻿namespace Wiki_Prototype
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
            ListBoxWiki = new ListBox();
            StatusStrip = new StatusStrip();
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
            SuspendLayout();
            // 
            // ListBoxWiki
            // 
            ListBoxWiki.FormattingEnabled = true;
            ListBoxWiki.ItemHeight = 15;
            ListBoxWiki.Location = new Point(355, 46);
            ListBoxWiki.MultiColumn = true;
            ListBoxWiki.Name = "ListBoxWiki";
            ListBoxWiki.Size = new Size(217, 199);
            ListBoxWiki.TabIndex = 0;
            // 
            // StatusStrip
            // 
            StatusStrip.Location = new Point(0, 277);
            StatusStrip.Name = "StatusStrip";
            StatusStrip.Size = new Size(584, 22);
            StatusStrip.TabIndex = 1;
            StatusStrip.Text = "statusStrip1";
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
            // 
            // ButtonEdit
            // 
            ButtonEdit.Location = new Point(194, 40);
            ButtonEdit.Name = "ButtonEdit";
            ButtonEdit.Size = new Size(75, 23);
            ButtonEdit.TabIndex = 15;
            ButtonEdit.Text = "EDIT";
            ButtonEdit.UseVisualStyleBackColor = true;
            // 
            // ButtonDelete
            // 
            ButtonDelete.Location = new Point(194, 69);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(75, 23);
            ButtonDelete.TabIndex = 16;
            ButtonDelete.Text = "DELETE";
            ButtonDelete.UseVisualStyleBackColor = true;
            // 
            // WikiPrototype
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 299);
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
            Controls.Add(ListBoxWiki);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "WikiPrototype";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "WikiPrototype";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolTip ToolTip;
        private ListBox ListBoxWiki;
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
    }
}