using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVienClass
{
    public class OQuan_BanCo
    {
        private int viTri; //vi trí của ô
        private int value; // gia tri tại ô đó
        private bool isQuan; // xét xem vị trí đó có phải là quan ko

        public OQuan_BanCo(int viTri, int value, bool isQuan)
        {
            this.viTri = viTri;
            this.value = value;
            this.isQuan = isQuan;
        }

        public int GetValue()
        {
            return value;
        }

        public void SetValue(int value)
        {
            this.value = value;
        }

        public bool IsQuan()
        {
            return isQuan;
        }

        public void SetQuan(bool isQuan)
        {
            this.isQuan = isQuan;
        }

        public int GetViTri()
        {
            return viTri;
        }

        public void SetViTri(int viTri)
        {
            this.viTri = viTri;
        }

        public String ToString()
        {
            String quan = "";
            if (isQuan)
            {
                quan = " là quan";
            }
            else
            {
                quan = " là dân";
            }
            return "Vị trí: " + viTri + quan;
        }
    }
}
