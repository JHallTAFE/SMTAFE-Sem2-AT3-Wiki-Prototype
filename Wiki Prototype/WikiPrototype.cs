namespace Wiki_Prototype
{
    public partial class WikiPrototype : Form
    {
        const int rowSize = 12;
        const int colSize = 4;
        string[,] recordArray = new string[rowSize, colSize];
        int wikiPointer = 0; // Points to the last 'empty' entry
        int selectPointer = -1; // The last selected item in the ListView
        public WikiPrototype()
        {
            InitializeComponent();
            ButtonSave.Enabled = false;
            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < colSize; j++)
                    recordArray[i, j] = "~";
            }
            DisplayWiki();
        }

        private void WikiPrototype_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Refreshes the ListView to display the current wiki loaded in the record array.
        /// </summary>
        private void DisplayWiki()
        {
            ListViewWiki.Items.Clear();
            for (int i = 0; i < rowSize; i++)
            {
                if (recordArray[i, 0] != "~")
                {
                    AddRow(i);
                }
            }
        }
        /// <summary>
        /// Adds the specified row to the ListView.
        /// </summary>
        /// <param name="row">Row of the record array to add to the ListView.</param>
        private void AddRow(int row)
        {
            ListViewItem item = new ListViewItem(recordArray[row, 0]);
            item.SubItems.Add(recordArray[row, 1]);
            item.SubItems.Add(recordArray[row, 2]);
            ListViewWiki.Items.Add(item);
        }
        /// <summary>
        /// Fills the TextBoxes with the wiki entry given by the index
        /// </summary>
        /// <param name="i">Row of the record array to fill the text boxes with.</param>
        private void FillBoxes(int i)
        {
            TextBoxName.Text = recordArray[i, 0];
            TextBoxCategory.Text = recordArray[i, 1];
            TextBoxStructure.Text = recordArray[i, 2];
            TextBoxDefinition.Text = recordArray[i, 3];
        }
        /// <summary>
        /// Clears the TextBoxes.
        /// </summary>
        private void ClearBoxes()
        {
            TextBoxName.Clear();
            TextBoxCategory.Clear();
            TextBoxStructure.Clear();
            TextBoxDefinition.Clear();
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            recordArray[wikiPointer, 0] = TextBoxName.Text;
            recordArray[wikiPointer, 1] = TextBoxCategory.Text;
            recordArray[wikiPointer, 2] = TextBoxStructure.Text;
            recordArray[wikiPointer, 3] = TextBoxDefinition.Text;
            wikiPointer++;
            DisplayWiki();
            ClearBoxes();
        }
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (selectPointer >= 0)
            {
                recordArray[selectPointer, 0] = TextBoxName.Text;
                recordArray[selectPointer, 1] = TextBoxCategory.Text;
                recordArray[selectPointer, 2] = TextBoxStructure.Text;
                recordArray[selectPointer, 3] = TextBoxDefinition.Text;
                DisplayWiki();
            }
            else
            {
                StatusBar.Text = "No item currently selected!";
            }
        }
        private void ListViewWiki_Click(object sender, EventArgs e)
        {
            selectPointer = ListViewWiki.FocusedItem.Index;
            FillBoxes(selectPointer);
        }
        private void ListViewWiki_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListViewWiki.SelectedIndices.Count > 0)
            {
                selectPointer = ListViewWiki.SelectedIndices[ListViewWiki.SelectedIndices.Count - 1];
                FillBoxes(selectPointer);
            }
        }
        private void TextBoxName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ClearBoxes();
            TextBoxName.Focus();
            selectPointer = -1;
        }
    }
}