namespace Wiki_Prototype
{
    public partial class WikiPrototype : Form
    {
        const int rowSize = 12;
        const int colSize = 4;
        string[,] recordArray = new string[rowSize, colSize];
        int wikiPointer = 0; // Points to the last 'empty' entry
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
            for (int i = 0;i < rowSize;i++)
            {
                if (recordArray[i,0] != "~")
                {
                    addRow(i);
                }
            }
        }
        /// <summary>
        /// Adds the specified row to the ListView.
        /// </summary>
        /// <param name="row">Row of the record array to add to the ListView.</param>
        private void addRow(int row)
        {
            ListViewItem item = new ListViewItem(recordArray[row, 0]);
            item.SubItems.Add(recordArray[row, 1]);
            item.SubItems.Add(recordArray[row, 2]);
            ListViewWiki.Items.Add(item);
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            recordArray[wikiPointer, 0] = TextBoxName.Text;
            recordArray[wikiPointer, 1] = TextBoxCategory.Text;
            recordArray[wikiPointer, 2] = TextBoxStructure.Text;
            recordArray[wikiPointer, 3] = TextBoxDefinition.Text;
            wikiPointer++;
            DisplayWiki();
        }
    }
}