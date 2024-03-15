﻿using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class driverForm : Form
    {
        public int driver_id;
        public driverForm(int driver_id_get)
        {
            InitializeComponent();
            driver_id = driver_id_get;
        }

        MySqlConnection conn = new MySqlConnection("server=90.156.226.116;port=3306;username=cygvincev;" +
                                    "password=flamingo74@@;database=lionfish;");
        private void driverForm_Load(object sender, EventArgs e)
        {
            try
            {
                string queryString = "SELECT * FROM clients " +
                     "INNER JOIN orders ON clients.client_id = orders.client_id  AND orders.status_id = 4 " +
                     "LEFT JOIN drivers ON orders.driver_id = drivers.driver_id;";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(queryString);
                cmd.Connection = conn;
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader["order_id"], (string)reader["client_sname"],
                            (string)reader["client_fname"], (string)reader["client_pnum"], (DateTime)reader["order_acctime"],
                            (string)reader["order_badress"], (string)reader["order_eadress"]);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { conn.Close(); }

            try
            {
                string queryString = "SELECT * FROM clients " +
                     "INNER JOIN orders ON clients.client_id = orders.client_id  AND (orders.status_id = 1 OR orders.status_id = 2) " +
                     "LEFT JOIN drivers ON orders.driver_id = drivers.driver_id;";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(queryString);
                cmd.Connection = conn;
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dataGridView2.Rows.Add(reader["order_id"], (string)reader["client_sname"],
                            (string)reader["client_fname"], (string)reader["client_pnum"], (DateTime)reader["order_acctime"],
                            (string)reader["order_badress"], (string)reader["order_eadress"]);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { conn.Close(); }
        }

        private void btnDeny_Click(object sender, EventArgs e)
        {
            try
            {
                string queryString = "INSERT INTO drivers_orders(driver_id, order_id, status_id) VALUES (@d_id, @idStr, 3);"; //последнее изменение
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(queryString);
                cmd.Parameters.Add("@d_id", MySqlDbType.Int32).Value = driver_id;
                cmd.Parameters.Add("@idStr", MySqlDbType.Int32).Value = dataGridView1.CurrentRow.Cells[0].Value;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Заказ принят.");
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { conn.Close(); }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                string queryString = "INSERT INTO drivers_orders(driver_id, order_id, status_id) VALUES (@d_id, @idStr, 1);"; //последнее изменение
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(queryString);
                cmd.Parameters.Add("@d_id", MySqlDbType.Int32).Value = driver_id;
                cmd.Parameters.Add("@idStr", MySqlDbType.Int32).Value = dataGridView1.CurrentRow.Cells[0].Value;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Заказ принят.");
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { conn.Close(); }
        }

        private void Orders_Click(object sender, EventArgs e)
        {

        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string queryString = "INSERT INTO docs(doc_image1, doc_image2, doc_image3, doc_image4, doc_sharetime, driver_id) " +
                    "VALUES (@image1, @image2, @image3, @image4, @time, @d_id);"; //последнее изменение
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(queryString);
                cmd.Parameters.Add("@d_id", MySqlDbType.Int32).Value = driver_id;
                cmd.Parameters.Add("@time", MySqlDbType.DateTime).Value = DateTime.Now;
                
                // Преобразовать изображение в байты
                byte[] imageData;
                using (MemoryStream ms = new MemoryStream())
                {
                    docImage1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    imageData = ms.ToArray();
                }
                cmd.Parameters.Add("@image1", MySqlDbType.LongBlob).Value = imageData;
                using (MemoryStream ms = new MemoryStream())
                {
                    docImage2.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    imageData = ms.ToArray();
                }
                cmd.Parameters.Add("@image2", MySqlDbType.LongBlob).Value = imageData;
                using (MemoryStream ms = new MemoryStream())
                {
                    docImage3.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    imageData = ms.ToArray();
                }
                cmd.Parameters.Add("@image3", MySqlDbType.LongBlob).Value = imageData;
                using (MemoryStream ms = new MemoryStream())
                {
                    docImage4.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    imageData = ms.ToArray();
                }
                cmd.Parameters.Add("@image4", MySqlDbType.LongBlob).Value = imageData;

                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Изображение загружено.");
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { conn.Close(); }
        }
        private bool IsImageFile(string filePath)
        {
            // Проверить расширение файла, чтобы определить, является ли он изображением
            string extension = Path.GetExtension(filePath);
            string[] imageExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };
            return Array.Exists(imageExtensions, ext => ext.Equals(extension, StringComparison.OrdinalIgnoreCase));
        }

        private void docImage1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All files (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Открыть выбранный файл изображения
                    string selectedFilePath = openFileDialog.FileName;

                    // Проверить, является ли выбранный файл изображением
                    if (IsImageFile(selectedFilePath))
                    {
                        // Загрузить изображение в PictureBox
                        docImage1.Image = new System.Drawing.Bitmap(selectedFilePath);
                    }
                    else
                    {
                        MessageBox.Show("Выбранный файл не является изображением.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при открытии файла: " + ex.Message);
                }
            }
        }

        private void docImage2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All files (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Открыть выбранный файл изображения
                    string selectedFilePath = openFileDialog.FileName;

                    // Проверить, является ли выбранный файл изображением
                    if (IsImageFile(selectedFilePath))
                    {
                        // Загрузить изображение в PictureBox
                        docImage2.Image = new System.Drawing.Bitmap(selectedFilePath);
                    }
                    else
                    {
                        MessageBox.Show("Выбранный файл не является изображением.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при открытии файла: " + ex.Message);
                }
            }
        }

        private void docImage3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All files (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Открыть выбранный файл изображения
                    string selectedFilePath = openFileDialog.FileName;

                    // Проверить, является ли выбранный файл изображением
                    if (IsImageFile(selectedFilePath))
                    {
                        // Загрузить изображение в PictureBox
                        docImage3.Image = new System.Drawing.Bitmap(selectedFilePath);
                    }
                    else
                    {
                        MessageBox.Show("Выбранный файл не является изображением.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при открытии файла: " + ex.Message);
                }
            }
        }

        private void docImage4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All files (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Открыть выбранный файл изображения
                    string selectedFilePath = openFileDialog.FileName;

                    // Проверить, является ли выбранный файл изображением
                    if (IsImageFile(selectedFilePath))
                    {
                        // Загрузить изображение в PictureBox
                        docImage4.Image = new System.Drawing.Bitmap(selectedFilePath);
                    }
                    else
                    {
                        MessageBox.Show("Выбранный файл не является изображением.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при открытии файла: " + ex.Message);
                }
            }
        }
    }
}
