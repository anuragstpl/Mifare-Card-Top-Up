using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MifareTopUp
{
    public static class ConnectDB
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection sqc = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='E:\Live Projects\MifareTopUp\MifareTopUp\SelfTopup.mdf';Integrated Security=True");
            sqc.Open();
            return sqc;
        }
    }
}
