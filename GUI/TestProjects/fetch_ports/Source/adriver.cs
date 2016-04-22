//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using NSCSGen;
using NSRiskManager;

namespace NSFetchPorts {

    public class fetch_portsDriver {
        const string CONN_STR_RISK_MGR = @"Data Source=HOUDB50\sqlsvr10,1440;Initial Catalog=DEV_riskmgr_trade;Integrated Security=True";
        const string CONN_STR = @"Data Source=(localdb)\ProjectsV12;Initial Catalog=Test;Integrated Security=True";

        [STAThread()]
        public static void Main(string[] args) {
            new fetch_portsDriver(CONN_STR_RISK_MGR).fetchData();
        }

        bool connected;
        SqlConnection connection;

        fetch_portsDriver(string cstr) {
            connection = new SqlConnection(cstr);
            connection.InfoMessage += sc_InfoMessage;
            try {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                    connected = true;
            } catch (SqlException sex) {
                Util.show(MethodBase.GetCurrentMethod(),sex);
            } catch (Exception ex) {
                Util.show(MethodBase.GetCurrentMethod(),ex);
            }
            if (!connected) {
                connection.InfoMessage -= sc_InfoMessage;
                connection.Dispose();
                connection = null;
            }
        }

        void sc_InfoMessage(object sender,SqlInfoMessageEventArgs e) {
            Util.show(MethodBase.GetCurrentMethod());
        }

        void fetchData() {
            const string QUERY = "SELECT * FROM portfolio WHERE port_type='IW'";

            if (connection == null)
                throw new InvalidOperationException("no connection");

            CSGenerator.generateClasses(connection,new string[] { "portfolio","portfolio_group" });

            using (SqlCommand cmd = new SqlCommand(QUERY,connection)) {
                var blah = Portfolio.fetch(cmd);
            }
        }
    }
}
