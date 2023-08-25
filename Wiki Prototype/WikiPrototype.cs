namespace Wiki_Prototype
{
    public partial class WikiPrototype : Form
    {
        const int rowSize = 12;
        const int colSize = 4;
        string[,] recordArray = new string[rowSize, colSize];
        public WikiPrototype()
        {
            InitializeComponent();
        }

        private void WikiPrototype_Load(object sender, EventArgs e)
        {

        }
    }
}