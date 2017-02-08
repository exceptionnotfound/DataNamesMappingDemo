using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNamesMappingDemo.Mapping
{
    public interface IDataNamesMapper<TEntity> where TEntity : class, new()
    {
        TEntity Map(DataRow row);
        TEntity Map(DataRow row, TEntity entity);
        List<TEntity> Map(DataTable table);
    }
}
