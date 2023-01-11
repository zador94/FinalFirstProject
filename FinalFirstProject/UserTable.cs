using System;
using System.Collections.Generic;
using System.Windows;
using MySql.Data.MySqlClient;

namespace FinalFirstProject;


public class UserTable
{
    public MySqlConnection Connection;
    public Dictionary<string, string> loginPassword;

    public UserTable()
    {
        this.Connection = DataBaseConnection.getConnection();
        this.loginPassword = new Dictionary<string, string>();
    }

    public void getAllUsers()
    {
        MySqlCommand mysql_query = Connection.CreateCommand();
        mysql_query.CommandText = "SELECT login, password FROM users;";
        try
        {
            Connection.Open();
        }
        catch (Exception e)
        {
            string readError = "errors";
            LogErrors.ErrorFileRead("readError", $"[{DateTime.Now}]: {e.Message}");
            MessageBox.Show("Ой, что то пошло не так");
        }
        MySqlDataReader mysql_result = mysql_query.ExecuteReader();

        while (mysql_result.Read())
        {
            this.loginPassword.Add(mysql_result.GetString(0), mysql_result.GetString(1));
        }
        Connection.Close();
    }

    public bool compareLoginPassword(string login, string password)
    {
        bool result = false;
        this.getAllUsers();
        foreach (var item in this.loginPassword)
        {
            if (item.Key == login && item.Value == password)
            {
                result = true;
                break;
            }
        }
        return result;
    }

    public bool compareLogin(string login)
    {
        bool result = false;
        this.getAllUsers();
        foreach (var item in this.loginPassword)
        {
            if (item.Key == login)
            {
                result = true;
                break;
            }
        }
        return result;
    }

    public void registrationUsers(string login, string password)
    {
        MySqlCommand command = Connection.CreateCommand();
        command.CommandText = $"INSERT INTO users (`login`, `password`) VALUES ('{login}','{password}')";
        try
        {
            Connection.Open();
        }
        catch (Exception e)
        {
            string readError = "errors";
            LogErrors.ErrorFileRead("readError", e.Message + DateTime.Now);
            MessageBox.Show("Ой, что то пошло не так");
        }
        
        command.ExecuteNonQuery();
        Connection.Close();
    }
}