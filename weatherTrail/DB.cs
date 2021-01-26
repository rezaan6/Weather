﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace weatherTrail
{
    class DB
    {

        MySqlConnection connection = new MySqlConnection("server=localhost;port=3308;username=root;password=;database=user");

        //create a function to open the connection

        public void openConnection() 
        {
            if (connection.State == System.Data.ConnectionState.Closed) 
            {
                connection.Open();

                
            }
        
        }


        //create a function to close the connection

        public void closeConnection() 
        {

            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();


            }
        }


        public MySqlConnection getConnection() 
        {

            return connection;
        
        
        
        }
    }
}
