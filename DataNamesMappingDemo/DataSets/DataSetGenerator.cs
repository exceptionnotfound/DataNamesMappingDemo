using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNamesMappingDemo.DataSets
{
    public static class DataSetGenerator
    {
        public static DataSet SampleDataSet()
        {
            DataTable exampleTable = new DataTable();
            exampleTable.Columns.Add(new DataColumn()
            {
                ColumnName = "FirstName",
                DataType = typeof(string)
            });
            exampleTable.Columns.Add(new DataColumn()
            {
                ColumnName = "LastName",
                DataType = typeof(string)
            });
            exampleTable.Columns.Add(new DataColumn()
            {
                ColumnName = "DateOfBirth",
                DataType = typeof(DateTime)
            });
            exampleTable.Columns.Add(new DataColumn()
            {
                ColumnName = "JobTitle",
                DataType = typeof(string)
            });
            exampleTable.Columns.Add(new DataColumn()
            {
                ColumnName = "TakenName",
                DataType = typeof(string)
            });

            exampleTable.Rows.Add(new object[] { "Lenny", "Belardo", new DateTime(1971, 3, 24), "Pontiff", "Pius XIII" });
            exampleTable.Rows.Add(new object[] { "Angelo", "Voiello", new DateTime(1952, 11, 18), "Cardinal Secretary of State", "" });
            exampleTable.Rows.Add(new object[] { "Michael", "Spencer", new DateTime(1942, 5, 12), "Archbishop of New York", "" });

            DataSet exampleDataSet = new DataSet();
            exampleDataSet.Tables.Add(exampleTable);

            return exampleDataSet;
        }
    }
}
