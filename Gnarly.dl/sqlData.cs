using System.Data.Common;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using Gnarly.dl;

namespace Gnarly.dl
{
    class sqlData
    {
        static string connectionString = "Data Source=DESKTOP-36N9A4V;Initial Catalog = Gnarly; Integrated Security = True";
        static SqlConnection sqlConnection = new SqlConnection(connectionString);
    }
}
