using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace memberlist
{
    public partial class Form1 : Form
    {
        string address = string.Format("SERVER = LOCALHOST; DATABASE = member; Uid = root; Pwd = dlwjdals12!");
        int number = 0;

        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            Time.Text = date.ToString("f");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void Add_B_Click(object sender, EventArgs e)
        {
            try
            {
                number++;
                MySqlConnection conn = new MySqlConnection(address);
                

                conn.Open();

                string insertQuery = string.Format("INSERT INTO account_table (Number, Name, Phone) VALUES ('" + Convert.ToString(number) + "', '" + NameText.Text + "', '" + PhoneText.Text + "')");
                MySqlCommand cmd = new MySqlCommand(insertQuery, conn);

                if (cmd.ExecuteNonQuery() != 1)
                    MessageBox.Show("Failed to insert data.");

                NameText.Text = "";
                PhoneText.Text = "";

                selectTable();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Modify_B_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(address))
                {
                    conn.Open();

                    int pos = listView1.SelectedItems[0].Index; //  account_table 에서 특정 number 선택
                    int index = Convert.ToInt32(listView1.Items[pos].Text); //  account_table 에서 특정 number 선택

                    string updateQuery = string.Format("UPDATE account_table SET Name = '" + NameText.Text + "', Phone = '" + PhoneText.Text + "' WHERE Number = '" + index + "'");
                    MySqlCommand cmd = new MySqlCommand(updateQuery, conn);

                    if (cmd.ExecuteNonQuery() != 1)
                        MessageBox.Show("Failed to update data.");

                    NameText.Text = "";
                    PhoneText.Text = "";

                    selectTable();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Delete_B_Click(object sender, EventArgs e)
        {
            try
            {
                number--;
                if(number <= 0)
                    number = 0;
                using (MySqlConnection conn = new MySqlConnection(address))
                {
                    conn.Open();

                    int pos = listView1.SelectedItems[0].Index;
                    int index = Convert.ToInt32(listView1.Items[pos].Text);

                    string deleteQuery = string.Format("DELETE FROM account_table WHERE Number = {0}", index);
                    MySqlCommand cmd = new MySqlCommand(deleteQuery, conn);

                    if (cmd.ExecuteNonQuery() != 1)
                        MessageBox.Show("Failed to delete data.");

                    NameText.Text = "";
                    PhoneText.Text = "";

                    selectTable();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Check_B_Click(object sender, EventArgs e)
        {
            selectTable();
        }

        private void selectTable()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(address))
                {
                    conn.Open();

                    string selectQuery = string.Format("SELECT * FROM account_table");
                    MySqlCommand cmd = new MySqlCommand(selectQuery, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    listView1.Items.Clear();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem();

                        item.Text = reader["Number"].ToString();
                        item.SubItems.Add(reader["Name"].ToString());
                        item.SubItems.Add(reader["Phone"].ToString());

                        listView1.Items.Add(item);
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            NameText.Text = listView1.FocusedItem.SubItems[1].Text;
            PhoneText.Text = listView1.FocusedItem.SubItems[2].Text;
        }
    }
}
