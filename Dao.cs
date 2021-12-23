using System.Data;
using MySql.Data.MySqlClient;

namespace App2
{
    class Dao
    {

        MySqlConnection sc;
        public MySqlConnection connect()
        {
            //布置在服务器上的数据库，可能会有点慢
            //string str = "server=121.199.173.91;User Id=root;password=123456;Database=app";//数据库链接字符串
            
            string str = "server=localhost;User Id=root;password=zlj20011030;Database=app";//数据库链接字符串
            sc = new MySqlConnection(str);//创建数据库链接对象
            sc.Open();//打开数据库
            return sc;//返回数据库链接对象
        }
        public MySqlCommand command(string mysql)
        {
            MySqlCommand cmd = new MySqlCommand(mysql, connect());//生成对数据库操作对象
            return cmd;
        }
        public int Execute(string mysql)//更新操作
        {
            return command(mysql).ExecuteNonQuery();
        }
        public MySqlDataReader read(string mysql)//读取操作
        {
            return command(mysql).ExecuteReader();
        }
        public void DaoClose()
        {
            sc.Close();//关闭数据库连接
        }
    }
}
