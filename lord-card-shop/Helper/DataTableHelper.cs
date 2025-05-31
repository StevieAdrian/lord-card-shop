using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Web;

namespace lord_card_shop.Helper
{
    public class DataTableHelper
    {
        public static DataTable ToDataTable<T>(List<T> items)
        {
            Type type = typeof(T);
            PropertyInfo[] prop = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            DataTable dt = new DataTable(type.Name);

            for (int i = 0; i < prop.Length; i++)
            {
                Type columnType;
                Type propType = prop[i].PropertyType;

                if (Nullable.GetUnderlyingType(propType) != null)
                {
                    // System.Diagnostics.Debug.WriteLine("tes debgu 1");
                    columnType = Nullable.GetUnderlyingType(propType);
                }
                else
                {
                    // System.Diagnostics.Debug.WriteLine("tes debugg 2 zasda");
                    columnType = propType;
                }

                dt.Columns.Add(prop[i].Name, columnType);
            }

            for (int i = 0; i < items.Count; i++)
            {
                object[] values = new object[prop.Length];

                for (int j = 0; j < prop.Length; j++)
                {
                    values[j] = prop[j].GetValue(items[i], null);
                }

                dt.Rows.Add(values);
            }

            return dt;
        }
    }
}
