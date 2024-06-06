using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;



namespace WebApplication3
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ShowData();

            }
        }


        public void btnLogin_Click(object obj, EventArgs args)
        {
            try
            {
                string ab = "server=localhost;Database=loggin;User ID=root;Password=;";
                using (MySqlConnection con = new MySqlConnection(ab))
                {
                    con.Open();
                    string query = "Insert into loggin(user, pass) values(@name, @pass)";
                    using (MySqlCommand command = new MySqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@name", txtUser.Text);
                        command.Parameters.AddWithValue("@pass", txtPass.Text);

                        command.ExecuteNonQuery();
                        ShowData();

                    }
                }
            }
            catch (Exception ex)
            {
            }
        }

        public void ShowData()
        {
            string ab = "server=localhost;Database=loggin;User ID=root;Password=;";
            using (MySqlConnection con = new MySqlConnection(ab))
            {
                con.Open();
                string query = "select * from loggin";
                using (MySqlCommand command = new MySqlCommand(query, con))
                {
                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                    dataAdapter.Fill(dataTable);
                    gridView.DataSource = dataTable;
                    gridView.DataBind();
                }
            }
        }

        public void UpdateData(object obj, EventArgs evg)
        {
            string ab = "server=localhost;Database=loggin;User ID=root;Password=;";
            using (MySqlConnection con = new MySqlConnection(ab))
            {
                con.Open();
                string query = "Update loggin Set user = @name, pass = @pass where id = @id";
                using (MySqlCommand command = new MySqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@name", txtUser.Text);
                    command.Parameters.AddWithValue("@pass", txtPass.Text);

                    command.ExecuteNonQuery();
                    ShowData();
                }
            }
        }

        public void DeleteData(object obj, EventArgs args)
        {
            string ab = "server=localhost;Database=loggin;User ID=root;Password=;";
            using (MySqlConnection con = new MySqlConnection(ab))
            {
                con.Open();
                string query = "Delete from loggin where id = @id";
                using (MySqlCommand command = new MySqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                    ShowData();
                }
            }
        }

        public void btnSearch_Click(object obj, EventArgs args)
        {
            string ab = "server=localhost;Database=loggin;User ID=root;Password=;";
            using (MySqlConnection con = new MySqlConnection(ab))
            {
                con.Open();
                string query = "select * from loggin where user like @name";
                using (MySqlCommand command = new MySqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@name", "%" + txtSearch.Text + "%");
                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                    dataAdapter.Fill(dataTable);
                    gridView.DataSource = dataTable;
                    gridView.DataBind();
                }
            }
        }

    }
}