using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autosalon
{
    public static class SQLClass
    {
        //Строка подключения к БД
        public const string CONNECTION_STRING =
        "SslMode=none;Server=localhost;Database=autosalon;port=3306;Uid=root;charset=utf8";
        //Подключение к БД
        public static MySqlConnection CONN;
        //Функция SELECT-запроса
        public static List<string> mySelect(string cmdText)
        {
            List<string> list = new List<string>();
            MySqlCommand command = new MySqlCommand(cmdText, CONN);
            DbDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    list.Add(dr.GetValue(i).ToString());
                }
            }
            dr.Close();
            return list;
        }

        //Функция INSERT-запроса
        public static void myUpdate(string cmdText)
        {
            MySqlCommand command = new MySqlCommand(cmdText, CONN);
            DbDataReader dr = command.ExecuteReader();
            dr.Close();
        }
    }
}
