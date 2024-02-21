using DAL;
using DTL;
using System.Collections.Generic;

namespace BLL {
    public class NHANSU_BLL {
        public static List<NHANSU_DTL> HRM_Sheet_Load() { return NHANSU_DAL.HRM_Sheet_Load(); }

        public static bool ThemNhanVien(NHANSU_DTL NHANSU) { return NHANSU_DAL.ThemNhanVien(NHANSU); }

        public static bool SuaNhanVien(NHANSU_DTL NHANSU) { return NHANSU_DAL.SuaNhanVien(NHANSU); }

        public static bool XoaNhanVien(string MSNV) { return NHANSU_DAL.XoaNhanVien(MSNV); }

        public static List<NHANSU_DTL> TimNhanVien(string Key) { return NHANSU_DAL.TimNhanVien(Key); }
    }
}