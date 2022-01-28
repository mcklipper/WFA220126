namespace AutoKolcsonzo
{
    public partial class MainForm : Form
    {
        private readonly ApplicationDbContext _context;

        public MainForm()
        {
            InitializeComponent();
            _context = new();

            LoadAllCars();
        }

        private void LoadAllCars()
        {
            dgvMain.Rows.Clear();
            CreateColumnsForCars();
            foreach (var car in _context.Cars)
            {
                dgvMain.Rows.Add(new object[]
                {
                    car.Make,
                    car.Type,
                    car.Year,
                    car.Fuel
                });
            }

            lblHeader.Text = "Összes Autó";
        }

        private void LoadCarsByMake()
        {
            dgvMain.Rows.Clear();
            CreateColumnsForCars();
            foreach (var car in _context.Cars.Where(x => x.Make == "Renault"))
            {
                dgvMain.Rows.Add(new object[]
                {
                    car.Make,
                    car.Type,
                    car.Year,
                    car.Fuel
                });
            }

            lblHeader.Text = "Autók Gyártmány Szerint";
        }

        private void CreateColumnsForCars()
        {
            dgvMain.Columns.Clear();
            dgvMain.Columns.AddRange(new DataGridViewColumn[]
            {
                new(new DataGridViewTextBoxCell()) { Name = "Make", HeaderText = "Gyártmány" },
                new(new DataGridViewTextBoxCell()) { Name = "Type", HeaderText = "Típus" },
                new(new DataGridViewTextBoxCell()) { Name = "Year", HeaderText = "Évjárat" },
                new(new DataGridViewTextBoxCell()) { Name = "Fuel", HeaderText = "Üzemanyag" }
            });
        }

        private void AllCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadAllCars();
        }

        private void CarsByMakeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadCarsByMake();
        }
    }
}