using System.Data;
using System.Data.SqlClient;

namespace DAL {
    public class DATAPROVIDER {
        public static  SqlConnection KetNoiDatabase() {
            string LienKet = "Data Source=(local);Initial Catalog=HRM;Integrated Security=True;";
            SqlConnection KetNoiDatabase = new SqlConnection(LienKet);
            KetNoiDatabase.Open();
            return KetNoiDatabase;
        }

        public static DataTable TruyVanDataTable(string TruyVan) {
            SqlConnection Database = KetNoiDatabase();
            SqlDataAdapter SDA = new SqlDataAdapter(TruyVan, Database);
            DataTable Table = new DataTable();
            SDA.Fill(Table);
            Database.Close();
            return Table;
        }

        public static bool TruyVanExecuseNonQuery(string TruyVan) {
            SqlConnection Database = KetNoiDatabase();
            SqlCommand Command = new SqlCommand(TruyVan, Database);
            int RowsAffected = Command.ExecuteNonQuery();
            Database.Close();
            return (RowsAffected == 0) ? false : true;
        }
    }
}