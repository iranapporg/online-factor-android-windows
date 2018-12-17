using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Newtonsoft.Json;

namespace Factor
{
    class FactorItem
    {
        public string sID, sName, sCount, sPrice;
    }

    class FactorItem2
    {
        public string sDate, sShopName, sFactorID;
        public FactorItem[] FI;

    }

    class FactorList
    {
        

        public FactorList()
        {

        }

        public void AddNewProduct(string name,string price,string count,string total,string ID)
        {
            FactorType ft1 = new FactorType();
            ft1.sCount = count;
            ft1.sName = name;
            ft1.sPrice = price;
            ft1.sTotal = total;
            ft1.sID = ID;
            myLibrary.l1.Add(ft1);
        }

        public double getPriceID(string sID)
        {
            for (int i = 0; i < myLibrary.l1.Count; i++)
            {
                FactorType ft1 = myLibrary.l1[i];
                if (ft1.sID == sID)
                    return Convert.ToDouble(ft1.sTotal);
            }
            return 0;
        }

        public void RemoveProduct(string ID)
        {
            for (int i = 0; i < myLibrary.l1.Count ; i++)
            {
                FactorType ft1 = myLibrary.l1[i];
                if (ft1.sID == ID)
                    myLibrary.l1.Remove(ft1);
            }
        }

        public int RowCount()
        {
            return myLibrary.l1.Count;
        }

        public double TotalFactor()
        {
            double temp = 0;
            for (int i = 0; i < myLibrary.l1.Count; i++)
            {
                FactorType ft1 = myLibrary.l1[i];
                temp += Convert.ToDouble(ft1.sCount) * Convert.ToDouble(ft1.sPrice);
            }
            return temp;
        }

        public void clear()
        {
            myLibrary.l1.Clear();
        }

        public DataTable List2Table()
        {
            DataTable d1 = new DataTable();
            d1.Columns.Add("sID");
            d1.Columns.Add("sName");
            d1.Columns.Add("sCount");
            d1.Columns.Add("sPrice");
            d1.Columns.Add("sTotal");

            for (int i = 0; i < myLibrary.l1.Count; i++)
            {
                FactorType ft1 = myLibrary.l1[i];
                DataRow dr = d1.NewRow();
                dr["sID"] = ft1.sID;
                dr["sName"] = ft1.sName;
                dr["sCount"] = ft1.sCount;
                dr["sPrice"] = ft1.sPrice.Replace(",","");
                dr["sTotal"] = Convert.ToDouble(ft1.sPrice) * Convert.ToDouble(ft1.sCount);
                d1.Rows.Add(dr);
            }
            return d1;
        }

        public string List2Json()
        {
            FactorItem[] fi1 = new FactorItem[myLibrary.l1.Count];

            for (int i = 0; i < myLibrary.l1.Count; i++)
            {
                fi1[i] = new FactorItem();
                FactorType ft1 = myLibrary.l1[i];
                fi1[i].sCount = ft1.sCount;
                fi1[i].sID = ft1.sID;
                fi1[i].sName = ft1.sName;
                fi1[i].sPrice = ft1.sPrice;
            }
            return JsonConvert.SerializeObject(fi1);
        }
    }
}
