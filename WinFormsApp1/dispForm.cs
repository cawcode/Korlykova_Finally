using MySqlConnector;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class dispForm : Form
    {
        private System.Windows.Forms.Timer timer;
        private MySqlConnection conn;

        public dispForm()
        {
            InitializeComponent();

            // Установка светлых цветов для формы и ее элементов
            this.BackColor = Color.FromArgb(240, 240, 240);
            this.ForeColor = Color.Black;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;

            //Настройка элемента DataGridView для первой вкладки
            dgvOrders.Dock = DockStyle.Fill;
            dgvOrders.BackgroundColor = Color.White;

            conn = new MySqlConnection("server=90.156.226.116;port=3306;username=cygvincev;" +
                                    "password=flamingo74@@;database=lionfish;");

            // Инициализация таймера
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 60000; // интервал в миллисекундах (1 минута)
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        public void dispForm_Load(object sender, EventArgs e)
        {
            dgvOrders_Load();
            dgvClients_Load();
        }

        private void dispForm_Leave(object sender, EventArgs e)
        {

        }

        private void dispForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm lForm = new LoginForm();
            lForm.Show();
            this.Hide();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPushClient_Click(object sender, EventArgs e)
        {
            try
            {
                string queryString = "INSERT INTO clients(client_sname, client_fname, client_ptrnmc, client_pnum) VALUES('" + txtBoxSname.Text + "', '" +
                    txtBoxFname.Text + "', '" + txtBoxPtrnmc.Text + "', '" + txtBoxPnum.Text + "');";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(queryString);
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { conn.Close(); }

            dgvClients_Load();
        }

        private void dgvClients_Load()
        {
            try
            {
                dgvClients.Rows.Clear();
                string queryString = "SELECT * FROM clients;";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(queryString);
                cmd.Connection = conn;
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dgvClients.Rows.Add(reader["client_id"], reader["client_sname"], reader["client_fname"],
                            reader["client_ptrnmc"], reader["client_pnum"]);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { conn.Close(); }
        }

        private void dgvOrders_Load()
        {
            try
            {
                dgvOrders.Rows.Clear();
                string queryString = "SELECT * FROM clients " +
                     "INNER JOIN orders ON clients.client_id = orders.client_id " +
                     "INNER JOIN order_stats ON orders.status_id = order_stats.status_id " +
                     "LEFT JOIN drivers ON orders.driver_id = drivers.driver_id;";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(queryString);
                cmd.Connection = conn;
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dgvOrders.Rows.Add((string)reader["client_sname"], (string)reader["client_fname"],
                            (string)reader["client_pnum"], (DateTime)reader["order_acctime"],
                            (string)reader["order_badress"], (string)reader["order_eadress"], (string)reader["status_name"],
                            reader["driver_sname"], reader["driver_fname"], reader["driver_pnum"]);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { conn.Close(); }
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            try
            {
                string queryString = "INSERT INTO orders(client_id, order_badress, order_eadress, order_acctime, status_id) " +
                    "VALUES (@ci, @ob, @oe, @oa, 4);";

                conn.Open();

                MySqlCommand cmd = new MySqlCommand(queryString);
                cmd.Parameters.Add("@ci", MySqlDbType.Int32).Value = dgvClients.CurrentRow.Cells[0].Value;
                cmd.Parameters.Add("@ob", MySqlDbType.String).Value = txtBoxBadress.Text;
                cmd.Parameters.Add("@oe", MySqlDbType.String).Value = txtBoxEadress.Text;
                cmd.Parameters.Add("@oa", MySqlDbType.DateTime).Value = DateTime.Now;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Заказ создан!");
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { conn.Close(); }

            dgvOrders_Load();
        }

        private void dgvOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            dgvOrders_Load();
            dgvClients_Load(); // Перезагрузка данных при срабатывании таймера

            try
            {
                // Получаем список всех водителей
                List<int> driverIds = new List<int>();
                string getDriversQuery = "SELECT driver_id FROM drivers;";
                MySqlCommand getDriversCmd = new MySqlCommand(getDriversQuery, conn);
                conn.Open();
                MySqlDataReader driverReader = getDriversCmd.ExecuteReader();

                while (driverReader.Read())
                {
                    driverIds.Add(driverReader.GetInt32(0));
                }

                driverReader.Close();

                // Запрос для выбора заказов, принятых более 15 минут назад и не закрепленных за водителем
                string queryString = "SELECT * FROM orders WHERE status_id = 4 AND TIMEDIFF(NOW(), order_acctime) > '00:15:00';";
                MySqlCommand cmd = new MySqlCommand(queryString, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                Random random = new Random();

                // Список для хранения данных для последующего обновления
                List<(int orderId, int driverId)> ordersToUpdate = new List<(int, int)>();

                while (reader.Read())
                {
                    // Выбираем случайного водителя из списка
                    int randomDriverIndex = random.Next(driverIds.Count);
                    int selectedDriverId = driverIds[randomDriverIndex];

                    // Добавляем данные в список для обновления
                    ordersToUpdate.Add((reader.GetInt32("order_id"), selectedDriverId));
                }

                reader.Close(); // Закрыть reader после использования

                // Выполнение обновления базы данных для всех заказов
                foreach (var orderToUpdate in ordersToUpdate)
                {
                    string updateOrderQuery = "UPDATE orders SET driver_id = @driverId, status_id = 2 WHERE order_id = @orderId;";
                    MySqlCommand updateOrderCmd = new MySqlCommand(updateOrderQuery, conn);
                    updateOrderCmd.Parameters.AddWithValue("@driverId", orderToUpdate.driverId);
                    updateOrderCmd.Parameters.AddWithValue("@orderId", orderToUpdate.orderId);
                    updateOrderCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { conn.Close(); }
        }
    }
}
