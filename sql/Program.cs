using System.Text;
using MySql.Data.MySqlClient;

string constring = "Server=localhost; database=test; uid=root; pwd=root";

using (MySqlConnection con = new (constring))
{

    con.Open();

    while (true)
    {

        Console.Write("Введите логин: ");
        string? login = Console.ReadLine();
        Console.Write("Введите пароль: ");
        string? pass = Console.ReadLine();

        string req = $"select * from users where login = '{login}' and pass = '{pass}'";

        using (MySqlCommand cmd = new MySqlCommand(req, con))
        {

            MySqlDataReader reader = cmd.ExecuteReader();
            StringBuilder bu = new();
            while (reader.Read())
            {
                bu.Append($"{reader.GetInt32(0)}. login: {reader.GetString(1)}; pass: {reader.GetString(2)}\n");
            }

            Console.WriteLine(bu.ToString());

        }
    
    }

}