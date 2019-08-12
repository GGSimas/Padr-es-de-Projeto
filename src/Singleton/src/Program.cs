/* EXERCICIO DE SINGLETON 
    Implemente o padrão Singleton para fornecer uma conexão com banco de dados 
    (não é necessario ser uma conexão real)
 */
using System;

namespace Singleton
{
    public class DBConnection {
        private static DBConnection _dbConnection;
        private DBConnection() {}
        public static DBConnection getInstance() {
            if (_dbConnection == null) {
                _dbConnection = new DBConnection();
            }
            return _dbConnection;
        }

        public void newConnection() {
            Console.WriteLine("Nova conexão criada!");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            DBConnection connect = DBConnection.getInstance();
            connect.newConnection();
        }
    }
}
