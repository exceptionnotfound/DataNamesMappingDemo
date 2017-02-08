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
        public static DataSet Priests()
        {
            DataTable priestsDataTable = new DataTable();
            priestsDataTable.Columns.Add(new DataColumn()
            {
                ColumnName = "first_name",
                DataType = typeof(string)
            });
            priestsDataTable.Columns.Add(new DataColumn()
            {
                ColumnName = "last_name",
                DataType = typeof(string)
            });
            priestsDataTable.Columns.Add(new DataColumn()
            {
                ColumnName = "dob",
                DataType = typeof(DateTime)
            });
            priestsDataTable.Columns.Add(new DataColumn()
            {
                ColumnName = "job_title",
                DataType = typeof(string)
            });
            priestsDataTable.Columns.Add(new DataColumn()
            {
                ColumnName = "taken_name",
                DataType = typeof(string)
            });

            priestsDataTable.Rows.Add(new object[] { "Lenny", "Belardo", new DateTime(1971, 3, 24), "Pontiff", "Pius XIII" });
            priestsDataTable.Rows.Add(new object[] { "Angelo", "Voiello", new DateTime(1952, 11, 18), "Cardinal Secretary of State", "" });
            priestsDataTable.Rows.Add(new object[] { "Michael", "Spencer", new DateTime(1942, 5, 12), "Archbishop of New York", "" });
            priestsDataTable.Rows.Add(new object[] { "Sofia", "(Unknown)", new DateTime(1974, 7, 2), "Director of Marketing", "" });
            priestsDataTable.Rows.Add(new object[] { "Bernardo", "Gutierrez", new DateTime(1966, 9, 16), "Master of Ceremonies", "" });

            DataSet priestsDataSet = new DataSet();
            priestsDataSet.Tables.Add(priestsDataTable);

            return priestsDataSet;
        }

        public static DataSet Ranchers()
        {
            DataTable ranchersTable = new DataTable();
            ranchersTable.Columns.Add(new DataColumn()
            {
                ColumnName = "firstName",
                DataType = typeof(string)
            });
            ranchersTable.Columns.Add(new DataColumn()
            {
                ColumnName = "lastName",
                DataType = typeof(string)
            });
            ranchersTable.Columns.Add(new DataColumn()
            {
                ColumnName = "dateOfBirth",
                DataType = typeof(DateTime)
            });
            ranchersTable.Columns.Add(new DataColumn()
            {
                ColumnName = "jobTitle",
                DataType = typeof(string)
            });
            ranchersTable.Columns.Add(new DataColumn()
            {
                ColumnName = "nickName",
                DataType = typeof(string)
            });

            ranchersTable.Rows.Add(new object[] { "Colt", "Bennett", new DateTime(1987, 1, 15), "Ranchhand", "" });
            ranchersTable.Rows.Add(new object[] { "Jameson", "Bennett", new DateTime(1984, 10, 10), "Ranchhand", "Rooster" });
            ranchersTable.Rows.Add(new object[] { "Beau", "Bennett", new DateTime(1944, 8, 9), "Rancher", "" });
            ranchersTable.Rows.Add(new object[] { "Margaret", "Bennett", new DateTime(1974, 7, 2), "Bar Owner", "Maggie" });
            ranchersTable.Rows.Add(new object[] { "Abigail", "Phillips", new DateTime(1987, 4, 24), "Teacher", "Abby" });

            DataSet ranchersDataSet = new DataSet();
            ranchersDataSet.Tables.Add(ranchersTable);

            return ranchersDataSet;
        }
    }
}
