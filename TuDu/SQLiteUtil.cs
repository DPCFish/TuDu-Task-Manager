using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace SQLiteUtil
{
    class DBHelper
    {
        public SQLiteConnection conn;
        public SQLiteDataAdapter adapter;
        public SQLiteCommand command;
        public SQLiteCommandBuilder cmdBdr;
        public string personalQueryCommand = "SELECT * FROM personalTaskdata";
        public string workgroupQueryCommand = "SELECT * FROM workgroupTaskdata";
        public string databasePath = "Data Source=" + Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\TuDuDatabase.sqlite";
        //public string databasePath = "Data Source=C:\\Users\\yzp97\\source\\repos\\TuDu\\TuDu\\database\\taskdata.sqlite";
        public string insertCommand = "";
        public Boolean IsInitialized()
        {
            if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\TuDuDatabase.sqlite"))
            {
                return true;
            }
            else
            {
                SQLiteConnection.CreateFile(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\TuDuDatabase.sqlite");
                conn = new SQLiteConnection(databasePath);
                conn.Open();
                string createTables = @"create table personalTaskdata
                                        (
                                        id       INTEGER not null
                                        constraint personalTaskdata_pk
                                        primary key autoincrement,
                                        content  TEXT    not null,
                                        priority INTEGER not null,
                                        addtime  TEXT    not null
                                        );
                                        create unique index personalTaskdata_id_uindex
                                        on personalTaskdata (id);                                        
                                        create table workgroupTaskdata
                                        (
                                        id       INTEGER not null
                                        constraint workgroupTaskdata_pk
                                        primary key autoincrement,
                                        content  TEXT    not null,
                                        priority INTEGER not null,
                                        addtime  TEXT    not null
                                        );
                                        create unique index workgroupTaskdata_id_uindex
                                        on workgroupTaskdata (id);";
                command = new SQLiteCommand(createTables, conn);
                command.ExecuteNonQuery();
                conn.Close();
                return false;
             }
        }

        public DBHelper(Boolean automaticConnect)
        {
            if (!automaticConnect) ;//空语句的构造函数，用于特定情况下不自动连接数据库使用
        }
        public DBHelper()
        {
            try
            {
                this.conn = new SQLiteConnection(databasePath);
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public DataTable GetTable(string queryCommand)
        {
            DataTable datatable = new DataTable();
            this.adapter = new SQLiteDataAdapter(queryCommand, this.conn);
            try
            {
                this.adapter.Fill(datatable);
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return datatable;
        }
        public void deleteRows(int id, string table)
        {
            string deleteCommand = "DELETE FROM " + table + " WHERE id=@id";
            this.command = new SQLiteCommand(deleteCommand, this.conn);
            this.command.Parameters.AddWithValue("@id", id);
            this.command.ExecuteNonQuery();
            //MessageBox.Show(deleteCommand);
        }

       
    }
}
