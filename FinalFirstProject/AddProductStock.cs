using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace FinalFirstProject;

public class AddProductStock
{
    public MySqlConnection Connection;
    public List<Product> listProduct;
    

    public AddProductStock()
    {
        this.Connection = DataBaseConnection.getConnection();
        this.listProduct = new List<Product>();
        
    }

    public List<Product> readFromBase()
    {
        MySqlCommand mysql_query = Connection.CreateCommand();
        mysql_query.CommandText = "SELECT product, price, quantity FROM product;";

        Connection.Open();

        MySqlDataReader mysql_result = mysql_query.ExecuteReader();

        while (mysql_result.Read())
        {
            listProduct.Add(new Product(mysql_result.GetString(0), mysql_result.GetFloat(1), mysql_result.GetInt32(2)));
        }
        Connection.Close();
        return listProduct;
    }

    public void addProduct(string product, float price, int quantity)
    {
        MySqlCommand command = Connection.CreateCommand();
        command.CommandText = $"INSERT INTO product (`product`, `price`, `quantity`) VALUES ('{product}', '{price}', '{quantity}')";
        
        Connection.Open();
            
        command.ExecuteNonQuery();
        Connection.Close();
    }

}