using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DoAn1.TangDuLieu;
namespace DoAn1.TangNghiepVu
{
    class NVLoaiSP
    {
        DuLieu dl = null;
        public NVLoaiSP()
        {
            dl = new DuLieu();
        }
        public DataSet LaySP()
        {
            return dl.ExecuteQueryDataSet("select * from LoaiSP", CommandType.Text);
        }

    }
}
