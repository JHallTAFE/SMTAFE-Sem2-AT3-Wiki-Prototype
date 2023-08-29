using System.Diagnostics.Eventing.Reader;

namespace Wiki_Prototype
{
    public partial class WikiPrototype : Form
    {
        // Criteria 9.1
        const int rowSize = 12;
        const int colSize = 4;
        const string defaultFileName = "definitions.dat";
        string[,] recordArray = new string[rowSize, colSize];
        int wikiPointer = 0; // Points to the last 'empty' entry, also the "length" of the filled records.
        int selectPointer = -1; // The last selected item in the ListView.
        static string lastDirectory = Application.StartupPath;
        #region demo array
        bool demoLoaded = false;
        bool demoEnabled = false;
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
            if (!demoEnabled)
            {
                ButtonDemo.Visible = false;
            }
            for (var i = 0; i < rowSize; i++)
            {
                for (var j = 0; j < colSize; j++)
                    recordArray[i, j] = "~"; // ~ acts as a "blank" entry to fill the array with.
            }
            DisplayWiki();
        }

        private void WikiPrototype_Load(object sender, EventArgs e)
        {

        }
        // Criteria 9.8
        /// <summary>
        /// Refreshes the ListView to display the current wiki loaded in the record array.
        /// </summary>
        private void DisplayWiki()
        {
            ListViewWiki.Items.Clear();
            for (var i = 0; i < rowSize; i++)
            {
                if (recordArray[i, 0] != "~") // ~ acts as a "blank" entry to fill the array with.
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
            // Creates a ListViewItem and populates it with the Name and Category to add to the ListView.
            ListViewItem item = new ListViewItem(recordArray[row, 0]);
            item.SubItems.Add(recordArray[row, 1]);
            ListViewWiki.Items.Add(item);
        }
        // Criteria 9.9 Part 2
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
            // If the user says Yes.
            {
                for (var j = i; j < wikiPointer - 1; j++) // From the given row to the 2nd last filled row.
                {
                    for (var k = 0; k < colSize; k++) // For each column in the row.
                    {
                        recordArray[j, k] = recordArray[j + 1, k]; // Replace the given entry with the next row's entry.
                    }
                }
                // Fill the last (duplicate) row with ~.
                for (var j = 0; j < colSize; j++)
                {
                    recordArray[wikiPointer - 1, j] = "~";
                }
                wikiPointer--; // Shift pointer back up the list.
                DisplayWiki();
                ClearBoxes();
                // If the records are now "empty", disable the save button as there's nothing to save.
                if (wikiPointer == 0)
                {
                    ButtonSave.Enabled = false;
                }
            }
        }
        /// <summary>
        /// Swaps two entries in the record array, fails if one of the inputs is not in the filled array or if the two parameters are equivalent.
        /// </summary>
        /// <param name="entry1">The first entry to swap.</param>
        /// <param name="entry2">The second entry to swap.</param>
        private void SwapEntries(int entry1, int entry2)
        {
            // If the given values are within the filled bounds of the record array, and they're not equal to each other.
            if (entry1 >= 0 && entry1 < wikiPointer && entry2 >= 0 && entry2 < wikiPointer && entry1 != entry2)
            {
                string[] tempEntry = { recordArray[entry1, 0], recordArray[entry1, 1], recordArray[entry1, 2], recordArray[entry1, 3] };
                for (var i = 0; i < colSize; i++)
                {
                    recordArray[entry1, i] = recordArray[entry2, i];
                    recordArray[entry2, i] = tempEntry[i];
                }
            }
            else if (entry1 == entry2) // If the method is given the same entry twice.
            {
                StatusBar.Text = "Cannot swap entry with itself!";
            }
            else // If the values are out of bounds.
            {
                StatusBar.Text = "Swap failed, one of the entries was out of bounds!";
            }
        }
        // Criteria 9.6
        /// <summary>
        /// Bubble sorts the record array and refreshes the display. Does not run and gives feedback if there's less than two entries.
        /// </summary>
        private void BubbleSort()
        {
            if (wikiPointer > 1) // If there's more than one entry to sort
            {
                // Basic Bubble Sort algorithm.
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
                StatusBar.Text = "Sorted!";
            }
            else // There's 0 or 1 entries.
            {
                StatusBar.Text = "Nothing to sort in the wiki!";
            }
        }
        // Criteria 9.7
        /// <summary>
        /// Searches the record array for the given search term by name, case-insensitive.
        /// </summary>
        /// <param name="searchTerm">The name of the record to search for.</param>
        /// <returns>The index of the first matching wiki entry found, or -1 if no entry matches the search term.</returns>
        private int SearchWiki(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm)) // If there's nothing to search for.
            {
                return -1;
            }
            for (var i = 0; i < wikiPointer; i++)
            // Search record array for a name matching the search term, case-insensitive. Stop at first result.
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
        // Criteria 9.10 Part 2
        /// <summary>
        /// Opens a dialogue to save the information to a binary file.
        /// </summary>
        private void SaveFile()
        {
            try
            {
                using (SaveFileDialog saveFile = new SaveFileDialog())
                {
                    // Initialising save dialogue properties.
                    saveFile.Title = "Select a file to save to";
                    saveFile.Filter = "Binary Files|*.dat";
                    saveFile.InitialDirectory = lastDirectory;
                    saveFile.FileName = defaultFileName;
                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        string fileName = saveFile.FileName;
                        if (Path.GetDirectoryName(fileName) is not null) // Avoiding null assignment.
                        {
                            lastDirectory = Path.GetDirectoryName(fileName); // Writes to lastDirectory static var for the next time the user opens or saves a file.
                        }
                        try
                        {
                            // Writing to the file given by the user, each string from the record array at a time.
                            using (BinaryWriter bw = new BinaryWriter(new FileStream(fileName, FileMode.Create)))
                            {
                                for (var i = 0; i < recordArray.GetLength(0); i++)
                                {
                                    for (var j = 0; j < recordArray.GetLength(1); j++)
                                    {
                                        bw.Write(recordArray[i, j]);
                                    }
                                }
                                StatusBar.Text = "Successfully saved to " + fileName;
                            }
                        }
                        catch (UnauthorizedAccessException)
                        {
                            StatusBar.Text = "Access to the file " + fileName + "is unauthorised.";
                        }
                        catch (IOException e)
                        {
                            StatusBar.Text = "An error occurred during I/O: " + e.Message;
                        }
                    }
                }
            }
            catch (Exception)
            {
                StatusBar.Text = "An error occured while trying to save the file.";
            }
        }
        // Criteria 9.11 Part 2
        /// <summary>
        /// Opens a dialogue to load the information from a binary file.
        /// </summary>
        private void OpenFile()
        {
            try
            {
                using (OpenFileDialog openFile = new OpenFileDialog())
                {
                    // Initialising open dialogue properties.
                    openFile.Title = "Select a file to open";
                    openFile.Filter = "Binary Files|*.dat";
                    openFile.InitialDirectory = lastDirectory;
                    openFile.FileName = defaultFileName;
                    if (openFile.ShowDialog() == DialogResult.OK)
                    {
                        string fileName = openFile.FileName;
                        if (Path.GetDirectoryName(fileName) is not null) // Avoiding null assignment.
                        {
                            lastDirectory = Path.GetDirectoryName(fileName); // Writes to lastDirectory static var for the next time the user opens or saves a file.
                        }
                        try
                        {
                            using (BinaryReader br = new BinaryReader(new FileStream(fileName, FileMode.Open)))
                            {
                                var i = 0;
                                wikiPointer = 0;
                                while (br.BaseStream.Position < br.BaseStream.Length) // From the start until EOF, for each row
                                {
                                    try
                                    {
                                        for (var j = 0; j < colSize; j++) // Now for each column in the row
                                        {
                                            recordArray[i, j] = br.ReadString(); // Read file piece as a string
                                        }
                                        i++;
                                        wikiPointer++;
                                    }
                                    catch (Exception)
                                    {
                                        StatusBar.Text = "Cannot read from file.";
                                        return;
                                    }
                                }
                                DisplayWiki();
                                ButtonSave.Enabled = true;
                                StatusBar.Text = "Successfully opened " + fileName;
                            }
                        }
                        catch (FileNotFoundException)
                        {
                            StatusBar.Text = "File " + fileName + " not found!";
                        }
                        catch (DirectoryNotFoundException e)
                        {
                            StatusBar.Text = e.Message;
                        }
                        catch (IOException e)
                        {
                            StatusBar.Text = "An error occurred during I/O: " + e.Message;
                        }
                    }
                }
            }
            catch (Exception)
            {
                StatusBar.Text = "An error occured while trying to open the file.";
            }
        }
        // Criteria 9.2
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
                ButtonSave.Enabled = true; // There's now something to save, so enable the button.
            }
            else
            {
                StatusBar.Text = "Cannot add new entry; the wiki is full!";
            }
        }
        // Criteria 9.3
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (selectPointer >= 0) // If an item is selected from the ListView.
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
        // Criteria 9.9 Part 1 A
        private void ListViewWiki_Click(object sender, EventArgs e)
        {
            selectPointer = ListViewWiki.FocusedItem.Index;
            DisplayEntry(selectPointer);
        }
        // Criteria 9.9 Part 1 B
        private void ListViewWiki_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListViewWiki.SelectedIndices.Count > 0)
            {
                selectPointer = ListViewWiki.SelectedIndices[ListViewWiki.SelectedIndices.Count - 1]; // Gets the first selected item out of the collection (should only ever select one anyway).
                DisplayEntry(selectPointer);
            }
        }
        private void TextBoxName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // "A double mouse click in the name text box will clear all four text boxes and focus the cursor into the name text box" - Client Program Criteria
            ClearBoxes();
            TextBoxName.Focus();
            selectPointer = -1;
        }
        // Criteria 9.4
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (selectPointer >= 0) // If an item is actually selected to delete
            {
                DeleteEntry(selectPointer);
            }
            else
            {
                StatusBar.Text = "Nothing selected to delete!";
            }
        }

        private void ButtonDemo_Click(object sender, EventArgs e)
        {
            // Loads demo entries once, for testing purposes only. Button only available if demoEnabled = true.
            // Fills all records with as many demo entries are provided, and blank ~ records for the rest.
            if (demoLoaded == false) // If the demo hasn't been loaded yet.
            {
                wikiPointer = 0; // Prepare wiki pointer, as all existing entries will be overwritten.
                for (var i = 0; i < demoArray.GetLength(0) && i < rowSize; i++) // For each row in demoArray, without going over rowsize
                {
                    for (var j = 0; j < colSize; j++)
                    {
                        recordArray[wikiPointer, j] = demoArray[i, j];
                    }
                    wikiPointer++;
                }
                for (var i = demoArray.GetLength(0); i < rowSize; i++)
                {
                    for (var j = 0; j < colSize; j++)
                    {
                        recordArray[wikiPointer, j] = "~";
                    }

                }
                // Demo has been loaded, and now there's something to save.
                ButtonDemo.Enabled = false;
                ButtonSave.Enabled = true;
                demoLoaded = true;
                DisplayWiki();
            }
            else // Shouldn't be able to press the button, but here just in case.
            {
                StatusBar.Text = "Demo already loaded!";
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
            // Search result feedback is handled by the SearchWiki method.
            TextBoxSearch.Clear();
        }

        private void TextBoxSearch_KeyDown(object sender, KeyEventArgs e) // Allows searching via pressing the enter key in the Search box.
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonSearch_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        // Criteria 9.10 Part 1
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
        // Criteria 9.11 Part 1
        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            OpenFile();
        }
    }
}