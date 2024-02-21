using DTL;
using System.Collections.Generic;
using System.Data;

namespace DAL {
    public class CHUCVU_DAL {
        public static List<CHUCVU_DTL> CHUCVU_Load() {
            string TruyVan = "SELECT * FROM CHUCVU";
            DataTable Table = DATAPROVIDER.TruyVanDataTable(TruyVan);
            if(Table == null || Table.Rows.Count == 0) {return null;}
            List<CHUCVU_DTL> CHUCVU_List = new List<CHUCVU_DTL> ();
            foreach (DataRow Row in Table.Rows) {
                CHUCVU_DTL CHUCVU = new CHUCVU_DTL();
                CHUCVU.MSCV = Row["MSCV"].ToString();
                CHUCVU.TENCV = Row["TENCV"].ToString();
                CHUCVU_List.Add(CHUCVU);
            }
            return CHUCVU_List;
        }
    }
}