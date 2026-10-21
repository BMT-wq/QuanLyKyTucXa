using System;

namespace QuanLyKyTucXa.Domain
{
    /// <summary>
    /// Đại diện cho tòa nhà (dãy nhà/khu nhà) trong ký túc xá.
    /// </summary>
    public class ToaNha
    {
        public string MaToaNha { get; set; }
        public string TenToaNha { get; set; }
        public int SoTang { get; set; }
        public string GhiChu { get; set; }

        public ToaNha()
        {
        }

        public ToaNha(string maToaNha, string tenToaNha, int soTang, string ghiChu = "")
        {
            MaToaNha = maToaNha;
            TenToaNha = tenToaNha;
            SoTang = soTang;
            GhiChu = ghiChu;
        }

        public override string ToString()
        {
            return $"{TenToaNha} ({MaToaNha})";
        }
    }
}
