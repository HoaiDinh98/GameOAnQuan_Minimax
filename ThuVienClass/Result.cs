using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ThuVienClass
{
    public class Result
    {
        private OQuan_BanCo[] OQuanBanCo;
        public int[] X, Y;



        public Result(OQuan_BanCo[] OQuanBanCo)
        {
            this.OQuanBanCo = OQuanBanCo;
            X = new int[50];
            Y = new int[50];
            Random r = new Random();
            for (int i = 0; i < X.Length; i++)
            {
                X[i] = r.Next(30) + 10;
            }
            for (int i = 0; i < Y.Length; i++)
            {
                Y[i] = r.Next(30) + 10;
            }
        }

        // trả về bàn cờ hiện tại
        public OQuan_BanCo[] getOQuanBanCo()
        {
            return OQuanBanCo;
        }

        public void setOQuanBanCo(OQuan_BanCo[] OQuanBanCo)
        {
            this.OQuanBanCo = OQuanBanCo;
        }

    }
}
