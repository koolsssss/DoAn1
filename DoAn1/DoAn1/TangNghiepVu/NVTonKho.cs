using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DoAn1.TangDuLieu;
namespace DoAn1.TangNghiepVu
{

    class NVTonKho
    {
        DuLieu dl = null;
        public NVTonKho()
        {
            dl = new DuLieu();
        }
        public DataSet LayTon()
        {
            return dl.ExecuteQueryDataSet("select * from TonKho", CommandType.Text);
        }
    }
}
