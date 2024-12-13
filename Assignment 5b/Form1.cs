using Microsoft.EntityFrameworkCore;

namespace Assignment_5b
{
    public partial class Form1 : Form
    {
        private readonly IPersonDataSource _personDataSource;
        public Form1(IPersonDataSource pds)
        {
            InitializeComponent();
            _personDataSource = pds;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _personDataSource.SaveChanges();
            this.dataGridView1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.personBindingSource.DataSource = _personDataSource.GetPeople();
        }
    }
}
