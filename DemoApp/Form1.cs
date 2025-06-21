using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace DemoApp
{
    public partial class Form1 : Form
    {
        string dbPath = "Data Source=demoDB.db;Version=3;";

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadData(BaseType type)
        {
            using (var connection = new SQLiteConnection($"Data Source={dbPath}"))
            {
                connection.Open();

                string sqlCommand;

                if (type == BaseType.Products)
                {
                   sqlCommand = "SELECT * FROM products";
                }
                else if (type == BaseType.Materials)
                {
                    sqlCommand = "SELECT * FROM materials";
                }
                else
                {                
                    sqlCommand = "SELECT * FROM suppliers";
                }

                
                SQLiteCommand command = new SQLiteCommand(sqlCommand, connection);
                var adapter = new SQLiteDataAdapter(sqlCommand, dbPath);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void ViewProductionButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                LoadData(BaseType.Products);
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void ViewSuppliersButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                LoadData(BaseType.Suppliers);
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void ViewProductsButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                LoadData(BaseType.Materials);
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
        }
    }
}
