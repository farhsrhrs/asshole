using asshole.Properties;
using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asshole
{
    public partial class auth : Form
    {
        public auth()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)//гость
        {
            this.Hide();
            Main form2 = new Main("Гость", "Гость");
            form2.Show();

        }

        public void UserAut()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(Resources.connectionDB))
            {
                connection.Open();
                string query = $@"SELECT   fio, ""Role"".role_name, login, password
	FROM public.""User""
        Join ""Role"" on ""Role"".id = ""User"".role_name
        WHERE login = @login AND password = @password";


                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("login", TextBoxLogin.Text);
                    command.Parameters.AddWithValue("password", TextBoxPassword.Text);


                    {
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                if (!reader.IsDBNull(0))
                                {
                                    MessageBox.Show("Авторизация успешна!", "Информация", MessageBoxButtons.OK);
                                    this.Hide();
                                    Main form2 = new Main(reader.GetString(0), reader.GetString(1));
                                    form2.Show();
                                    return;
                                }

                            }
                            MessageBox.Show("Не верные данные", "Информация", MessageBoxButtons.OK);
                            return;

                        }
                    }


                }
            }
        }
        private void button1_Click(object sender, EventArgs e)//войти
        {
            UserAut();

        }
    }
}
