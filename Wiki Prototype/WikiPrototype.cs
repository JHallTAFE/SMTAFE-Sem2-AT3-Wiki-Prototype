using System.Diagnostics.Eventing.Reader;

namespace Wiki_Prototype
{
    public partial class WikiPrototype : Form
    {
        const int rowSize = 12;
        const int colSize = 4;
        string[,] recordArray = new string[rowSize, colSize];
        int wikiPointer = 0; // Points to the last 'empty' entry, also the "length" of the filled records
        int selectPointer = -1; // The last selected item in the ListView
        #region demo array
        bool demoLoaded = false;
        bool demoEnabled = true;
        string[,] demoArray =
        {
            {"Array", "Array", "Linear", "An Array." },
            {"Two Dimension Array", "Array", "Linear", "A two-dimensional array." },
            {"List", "List", "Linear", "A list." },
            {"Linked List", "List", "Linear", "A linked list." },
            {"Self-Balance Tree", "Tree", "Non-Linear", "A self-balance tree" },
            {"Heap", "Tree", "Non-Linear", "A heap." },
            {"Binary Search Tree", "Tree", "Non-Linear", "A binary search tree." },
            {"Graph", "Graphs", "Non-Linear", "A graph." },
            {"Set", "Abstract", "Non-Linear", "A set." },
            {"Queue", "Abstract", "Linear", "A queue." },
            {"Stack", "Abstract", "Linear", "A stack." },
            {"Hash Table", "Hash", "Non-Linear", "A hash table." }
        };
        #endregion
        public WikiPrototype()
        {
            InitializeComponent();
            ButtonSave.Enabled = false;
            if (demoEnabled)
            {
                ButtonDemo.Visible = true;
            }
            for (var i = 0; i < rowSize; i++)
            {
                for (var j = 0; j < colSize; j++)
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
            for (var i = 0; i < rowSize; i++)
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
        /// Displays the wiki entry given by the index in the text boxes to the left.
        /// </summary>
        /// <param name="i">Row of the record array to fill the text boxes with.</param>
        private void DisplayEntry(int i)
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
        /// <summary>
        /// Asks the user if they want to delete the given entry; deletes it if the user confirms.
        /// </summary>
        /// <param name="i">The row in the array to delete</param>
        private void DeleteEntry(int i)
        {
            if (MessageBox.Show("Do you wish to delete the entry " + recordArray[i, 0] + " from the records?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                for (var j = i; j < wikiPointer - 1; j++) // From the given row to the 2nd last filled row
                {
                    for (var k = 0; k < 4; k++) // For each element in the row
                    {
                        recordArray[j, k] = recordArray[j + 1, k]; // Replace the given row with the next row
                    }
                }
                for (var j = 0; j < 4; j++)
                {
                    recordArray[wikiPointer - 1, j] = "~"; // Fill the last row (now duplicated) with empty results
                }
                wikiPointer--; // Shift pointer back up the list
                DisplayWiki();
                ClearBoxes();
            }
        }
        /// <summary>
        /// Swaps two entries in the record array, fails if one of the inputs is not in the filled array.
        /// </summary>
        /// <param name="entry1">The first entry to swap.</param>
        /// <param name="entry2">The second entry to swap.</param>
        private void SwapEntries(int entry1, int entry2)
        {
            if (entry1 >= 0 && entry1 < wikiPointer && entry2 >= 0 && entry2 < wikiPointer) //If the given values are filled within the array
            {
                string[] tempEntry = { recordArray[entry1, 0], recordArray[entry1, 1], recordArray[entry1, 2], recordArray[entry1, 3] };
                for (var i = 0; i < 4; i++)
                {
                    recordArray[entry1, i] = recordArray[entry2, i];
                    recordArray[entry2, i] = tempEntry[i];
                }
            }
            else
            {
                StatusBar.Text = "Swap failed, one of the entries was out of bounds!";
            }
        }
        /// <summary>
        /// Bubble sorts the record array and refreshes the display. Does not run and gives feedback if there's less than two entries.
        /// </summary>
        private void BubbleSort()
        {
            if (wikiPointer > 1) // If there's more than one entry to sort
            {
                for (var i = 0; i < wikiPointer; i++)
                {
                    for (var j = 0; j < wikiPointer - i - 1; j++)
                    {
                        if (string.Compare(recordArray[j, 0], recordArray[j + 1, 0]) > 0)
                        {
                            SwapEntries(j, j + 1);
                        }
                    }
                }
                DisplayWiki();
            }
            else
            {
                StatusBar.Text = "Nothing to sort in the wiki!";
            }
        }
        /// <summary>
        /// Searches the record array for the given search term by name, case-insensitive.
        /// </summary>
        /// <param name="searchTerm">The name of the record to search for.</param>
        /// <returns>The index of the first matching wiki entry found, or -1 if no entry matches the search term.</returns>
        private int SearchWiki(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return -1;
            }
            for (var i = 0; i < wikiPointer; i++)
            {
                if (String.Equals(searchTerm, recordArray[i, 0], StringComparison.OrdinalIgnoreCase))
                {
                    StatusBar.Text = "Entry " + recordArray[i, 0] + " found at position " + (i + 1) + "!";
                    return i;
                }
            }
            StatusBar.Text = "No results matching " + searchTerm + " found!";
            return -1;
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (wikiPointer < recordArray.GetLength(0))
            {
                recordArray[wikiPointer, 0] = TextBoxName.Text;
                recordArray[wikiPointer, 1] = TextBoxCategory.Text;
                recordArray[wikiPointer, 2] = TextBoxStructure.Text;
                recordArray[wikiPointer, 3] = TextBoxDefinition.Text;
                wikiPointer++;
                DisplayWiki();
                ClearBoxes();
            }
            else
            {
                StatusBar.Text = "Cannot add new entry; the wiki is full!";
            }
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
            DisplayEntry(selectPointer);
        }
        private void ListViewWiki_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListViewWiki.SelectedIndices.Count > 0)
            {
                selectPointer = ListViewWiki.SelectedIndices[ListViewWiki.SelectedIndices.Count - 1];
                DisplayEntry(selectPointer);
            }
        }
        private void TextBoxName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ClearBoxes();
            TextBoxName.Focus();
            selectPointer = -1;
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (selectPointer >= 0)
            {
                DeleteEntry(selectPointer);
            }
        }

        private void ButtonDemo_Click(object sender, EventArgs e)
        {
            if (demoLoaded == false)
            {
                for (var i = 0; i < demoArray.GetLength(0); i++)
                {
                    recordArray[wikiPointer, 0] = demoArray[i, 0];
                    recordArray[wikiPointer, 1] = demoArray[i, 1];
                    recordArray[wikiPointer, 2] = demoArray[i, 2];
                    recordArray[wikiPointer, 3] = demoArray[i, 3];
                    wikiPointer++;
                }
                for (var i = demoArray.GetLength(0); i < rowSize; i++)
                {
                    recordArray[wikiPointer, 0] = "~";
                    recordArray[wikiPointer, 1] = "~";
                    recordArray[wikiPointer, 2] = "~";
                    recordArray[wikiPointer, 3] = "~";
                }
                ButtonDemo.Enabled = false;
                demoLoaded = true;
                DisplayWiki();
            }
            else
            {
                StatusBar.Text = "Demo alreadyloaded!";
            }
        }

        private void ListViewWiki_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (selectPointer >= 0)
            {
                DeleteEntry(selectPointer);
            }
        }

        private void ButtonSort_Click(object sender, EventArgs e)
        {
            BubbleSort();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            var search = SearchWiki(TextBoxSearch.Text);
            if (search > 0) // If the search is successful
            {
                DisplayEntry(search);
                this.ListViewWiki.Items[search].Selected = true;
            }
            TextBoxSearch.Clear();
        }

        private void TextBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonSearch_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}