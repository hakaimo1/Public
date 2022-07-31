using Ampersand.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace Ampersand
{
    public class DataAccess
    {
        public List<Batteries> GetBattery()
        {
            using(IDbConnection connection=new System.Data.SqlClient.SqlConnection(Helper.cnnval("ConnString")))
            {
                var output= connection.Query<Batteries>("dbo.GetBatteries").ToList();
                return output;
            }
        }
    }
}
