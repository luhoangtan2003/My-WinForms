using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management {
    internal class Nganh_Nghe {
        public string Ten_Nganh { get; set; }
        public string Ma_Nganh { get; set; }
        public decimal Muc_Luong { get; set; }

        public Nganh_Nghe() { }
        public Nganh_Nghe(string Ten_Nganh, string Ma_Nganh, decimal Muc_Luong) {
            this.Ten_Nganh = Ten_Nganh;
            this.Ma_Nganh = Ma_Nganh;
            this.Muc_Luong = Muc_Luong;
        }

        public static List<Nganh_Nghe> Khoi_Tao_Cong_Viec() {
            List<Nganh_Nghe> CVs = new List<Nganh_Nghe>();
            CVs.Add(new Nganh_Nghe("Công nghệ thông tin","CT100", 20000000));
            CVs.Add(new Nganh_Nghe("Khoa học máy tính", "CT101", 50000000));
            CVs.Add(new Nganh_Nghe("Hệ thống thông tin", "CT102", 15000000));
            CVs.Add(new Nganh_Nghe("Kỹ thuật phần mềm", "CT103", 25000000));
            CVs.Add(new Nganh_Nghe("An toàn thông tin", "CT104", 10000000));
            return CVs;
        }
    }
}