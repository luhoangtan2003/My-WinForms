using DTL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DAL {
    public class NHANSU_DAL {
        public static List<NHANSU_DTL> NHANSU_Load(DataTable Table)
        =>
        Table?.Rows.Cast<DataRow>().Select(Row => new NHANSU_DTL {
            HOVATEN = Row["HOVATEN"].ToString(),
            MSNV = Row["MSNV"].ToString(),
            GIOITINH = Row["GIOITINH"].ToString(),
            NAMSINH = (DateTime)Row["NAMSINH"],
            MSCV = Row["MSCV"].ToString(),
            QUEQUAN = Row["QUEQUAN"].ToString(),
            EMAIL = Row["EMAIL"].ToString(),
            DIENTHOAI = Row["DIENTHOAI"].ToString()
        }).ToList();

        public static List<NHANSU_DTL> TimNhanVien(string Key) => NHANSU_Load(DATAPROVIDER.TruyVanDataTable($"SELECT * FROM NHANSU WHERE HOVATEN LIKE N'%{Key}%'"));

        public static List<NHANSU_DTL> HRM_Sheet_Load() => NHANSU_Load(DATAPROVIDER.TruyVanDataTable("SELECT * FROM NHANSU"));

        public static bool XoaNhanVien(string MSNV) => DATAPROVIDER.TruyVanExecuseNonQuery($"DELETE FROM NHANSU WHERE MSNV='{MSNV}'");

        public static bool ThemNhanVien(NHANSU_DTL NHANSU) => DATAPROVIDER.TruyVanExecuseNonQuery($"INSERT INTO NHANSU(HOVATEN,MSNV,GIOITINH,NAMSINH,MSCV,QUEQUAN,EMAIL,DIENTHOAI) VALUES(N'{NHANSU.HOVATEN}','{NHANSU.MSNV}',N'{NHANSU.GIOITINH}','{NHANSU.NAMSINH:MM/dd/yyyy}','{NHANSU.MSCV}', N'{NHANSU.QUEQUAN}','{NHANSU.EMAIL}','{NHANSU.DIENTHOAI}')");

        public static bool SuaNhanVien(NHANSU_DTL NHANSU) => DATAPROVIDER.TruyVanExecuseNonQuery($"UPDATE NHANSU SET HOVATEN=N'{NHANSU.HOVATEN}',GIOITINH=N'{NHANSU.GIOITINH}',NAMSINH='{NHANSU.NAMSINH:MM/dd/yyyy}',MSCV='{NHANSU.MSCV}',QUEQUAN=N'{NHANSU.QUEQUAN}',EMAIL='{NHANSU.EMAIL}',DIENTHOAI='{NHANSU.DIENTHOAI}' WHERE MSNV='{NHANSU.MSNV}'");        
    }
}