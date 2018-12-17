using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Deployment;
using System.Data;
using System.Windows.Forms;

namespace Factor
{
    class Database
    {
        SQLiteConnection con1;

        public Database()
        {
            con1 = new SQLiteConnection("Data Source=" + System.Windows.Forms.Application.StartupPath + "\\factor.db");
            con1.Open();
        }

        public void NewProduct(string sName, string sCount, string sPrice,string sCode)
        {
            string sql = String.Format("INSERT INTO tbl_product(sID,sName,sPrice,sCount) VALUES({0},'{1}','{2}','{3}')",sCode,sName,sPrice,sCount);
            SQLiteCommand c1 = new SQLiteCommand();
            c1.CommandText = sql;
            c1.Connection = con1;
            c1.ExecuteNonQuery();
        }

        public void NewProduct2(string sProductID,string sFactorID)
        {
            string sql = String.Format("INSERT INTO tbl_factorlist(sProductID,sFactorID) VALUES('{0}','{1}');", sProductID, sFactorID);
            SQLiteCommand c1 = new SQLiteCommand();
            c1.CommandText = sql;
            c1.Connection = con1;
            c1.ExecuteNonQuery();
        }

        public void DeleteRecord(string sFieldName,string sFieldValue)
        {
            string sql = String.Format("DELETE FROM tbl_product WHERE {0} = '{1}'", sFieldName,sFieldValue);
            SQLiteCommand c1 = new SQLiteCommand();
            c1.CommandText = sql;
            c1.Connection = con1;
            c1.ExecuteNonQuery();
        }

        public void DeleteRecord(string sFieldName, string sFieldValue,string sTableName)
        {
            string sql = String.Format("DELETE FROM {2} WHERE {0} = '{1}'", sFieldName, sFieldValue,sTableName);
            SQLiteCommand c1 = new SQLiteCommand();
            c1.CommandText = sql;
            c1.Connection = con1;
            c1.ExecuteNonQuery();
        }

        public void ModifyProduct(string sCount, string sPrice,string sOldName)
        {
            string sql = String.Format("UPDATE tbl_product set sCount='{0}' WHERE sName='{1}'",sCount,sOldName);
            SQLiteCommand c1 = new SQLiteCommand();
            c1.CommandText = sql;
            c1.Connection = con1;
            c1.ExecuteNonQuery();
        }

        public void ExecuteQuery(string sql)
        {
            SQLiteCommand c1 = new SQLiteCommand();
            c1.CommandText = sql;
            c1.Connection = con1;
            c1.ExecuteNonQuery();
        }

        public void CloseDatabase()
        {
            con1.Close();
        }

        public DataTable SelectRecord(string sql)
        {
            DataTable tb1 = new DataTable();
            SQLiteDataAdapter sda1;
            sda1 = new SQLiteDataAdapter(sql,con1);
            sda1.Fill(tb1);
            return tb1;
        }

        public void GetSourceText(string Sql, TextBox t1, string columname)
        {
            try
            {
                DataTable d1 = SelectRecord(Sql);
                t1.AutoCompleteMode = AutoCompleteMode.Suggest;
                t1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                foreach (DataRow r1 in d1.Rows)
                    t1.AutoCompleteCustomSource.Add(r1[columname].ToString());
            }
            catch (SQLiteException)
            {
            }
        }
        public void GetSourceComboBox(string Sql, ComboBox t1, string columname)
        {
            try
            {
                DataTable d1 = SelectRecord(Sql);
                foreach (DataRow r1 in d1.Rows)
                    t1.Items.Add(r1[columname].ToString());
            }
            catch (SQLiteException)
            {
            }
        }
        public int RecordCount(string sFieldName,string sFieldValue)
        {
            string sql = String.Format("SELECT COUNT(*) FROM tbl_product WHERE {0} = '{1}'",sFieldName,sFieldValue);
            SQLiteCommand c1 = new SQLiteCommand();
            c1.CommandText = sql;
            c1.Connection = con1;
            object res = c1.ExecuteScalar();
            return Convert.ToInt16(res.ToString());
        }
        
        public int FactorCount()
        {
            string sql = String.Format("SELECT COUNT(*) FROM tbl_factor");
            SQLiteCommand c1 = new SQLiteCommand();
            c1.CommandText = sql;
            c1.Connection = con1;
            object res = c1.ExecuteScalar();
            return Convert.ToInt16(res.ToString());
        }

        public string NewFactor(string sPhone)
        {
            string code = myLibrary.myUsername + FactorCount();
            string sql = String.Format("INSERT INTO tbl_factor(sID,sDate,sShopName,sPhone,sType) VALUES('{0}','{1}','{2}','{3}','0')", code, myLibrary.getDate(), "فروشگاه صنايع آراد", sPhone);
            SQLiteCommand c1 = new SQLiteCommand();
            c1.CommandText = sql;
            c1.Connection = con1;
            c1.ExecuteNonQuery();
            sql = "";

            string update = "";
            //string last_id = last_insert_id();
            DataTable rows = myLibrary.factorList.List2Table();

            for (int i = 0 ; i < rows.Rows.Count ; i++)
            {
                sql += String.Format("INSERT INTO tbl_factorlist(sProductID,sFactorID) VALUES('{0}','{1}');", rows.Rows[i]["sID"].ToString(), code);
                update += String.Format("UPDATE tbl_product SET sCount = sCount - {0} WHERE sID = {1} ;", rows.Rows[i]["sCount"].ToString(), rows.Rows[i]["sID"].ToString());
            }
            c1.CommandText = sql;
            c1.ExecuteNonQuery();
            c1.CommandText = update;
            c1.ExecuteNonQuery();
            return code;
        }

        public string last_insert_id()
        {
            try
            {
                SQLiteCommand s1 = new SQLiteCommand();
                s1.CommandText = "SELECT last_insert_rowid()";
                s1.Connection = con1;
                object ret = s1.ExecuteScalar();
                return Convert.ToString(ret);

            }
            catch (Exception e1)
            {
                return "0";
            }
        }
    }
}
