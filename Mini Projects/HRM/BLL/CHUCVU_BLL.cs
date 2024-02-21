using DAL;
using DTL;
using System.Collections.Generic;

namespace BLL {
    public class CHUCVU_BLL {
        public static List<CHUCVU_DTL> CHUCVU_Load() { return CHUCVU_DAL.CHUCVU_Load(); }
    }
}