using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ThuVienClass
{
    public class BanCo
    {
        List<Result> results = new List<Result>();
        public OQuan_BanCo[] OQuanBanCo = new OQuan_BanCo[100];
        public int OQuan_BanCoCount = 0;
        public BanCo()
        {

            for (int i = 0; i < 12; i++)
            {
                // tại vị trí 0 và 6 là 2 ô quan nên gán value = 10
                if (i == 0)
                { 
                    OQuanBanCo[i] = new OQuan_BanCo(i, 10, true); // True là quan
                    OQuan_BanCoCount++;
                }
                else if (i == 6)
                {
                    OQuanBanCo[i] = new OQuan_BanCo(i, 10, true);
                    OQuan_BanCoCount++;
                }
                // các ô còn lại có value mặc định = 5
                else
                {
                    OQuanBanCo[i] = new OQuan_BanCo(i, 5, false); // False là dân
                    OQuan_BanCoCount++;
                }
            }
            OQuanBanCo[12] = new OQuan_BanCo(12, 0, false); // vị trí 12 là ô tổng điểm của máy
            OQuanBanCo[13] = new OQuan_BanCo(13, 0, false); // vị trí 13 là ô tổng điểm của người
        }

        
        public int action(int action, int viTri)
        {
            if (action == 1)
            {
                return left(viTri);
            }
            else
            {
                return right(viTri);
            }
        }

        public int eatting(int action, int viTri)
        {
            if (action == 1)
            {
                return eatLeft(viTri);
            }
            else
            {
                return eatRight(viTri);
            }
        }

        public OQuan_BanCo[] adapter(OQuan_BanCo[] OQuanBanCo)
        {
            // tạo 1 mảng s có 12 phần tử 
            OQuan_BanCo[] s = new OQuan_BanCo[OQuan_BanCoCount];
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = new OQuan_BanCo(i, OQuanBanCo[i].GetValue(), OQuanBanCo[i].IsQuan());
            }
            return s;
        }

        // trả về vị trí sau khi đi qua trái
        public int left(int viTri)
        {
            int giaTri = OQuanBanCo[viTri].GetValue();
            OQuanBanCo[viTri].SetValue(0);
            Result r = new Result(adapter(OQuanBanCo));
            results.Add(r);
            while (giaTri != 0)
            {
                viTri++;
                if (viTri == 12)
                {
                    viTri = 0;
                }
                // tiến hành +1 vào vị trí tiếp theo khi di chuyển về trái
                OQuanBanCo[viTri].SetValue(OQuanBanCo[viTri].GetValue() + 1);
                giaTri--;
                Result result = new Result(adapter(OQuanBanCo));
                results.Add(result);
            }
            viTri++;
            if (viTri == 12)
            {
                viTri = 0;
            }
            if (OQuanBanCo[viTri].GetValue() != 0 && viTri % 6 != 0)
            {
                return left(viTri);
            }
            else
            {
                return viTri--;
            }
        }

        
        public bool Check_ViTriEat(int viTri)
        {
            if (OQuanBanCo[viTri].GetValue() == 0 && (viTri != 0 || viTri != 6))
            {
                return true;
            }
            return false;
        }

        // trả về vị trí sau khi đi qua phải
        public int right(int viTri)
        {
            int giaTri = OQuanBanCo[viTri].GetValue();
            OQuanBanCo[viTri].SetValue(0);
            Result r = new Result(adapter(OQuanBanCo));
            results.Add(r);
            while (giaTri != 0)
            {
                viTri--;
                if (viTri == -1)
                {
                    viTri = 11;
                }
                OQuanBanCo[viTri].SetValue(OQuanBanCo[viTri].GetValue() + 1);
                giaTri--;
                Result result = new Result(adapter(OQuanBanCo));
                results.Add(result);
            }
            viTri--;
            if (viTri == -1)
            {
                viTri = 11;
            }
            if (OQuanBanCo[viTri].GetValue() != 0 && viTri % 6 != 0)
            {
                return right(viTri);
            }
            else
            {
                return viTri--;
            }
        }

        public int eatLeft(int viTri)
        {
            if (OQuanBanCo[viTri].GetValue() == 0 && viTri % 6 != 0)
            {
                viTri++;
                if (viTri == 12)
                {
                    viTri = 0;
                }
                if (OQuanBanCo[viTri].GetValue() != 0)
                {
                    Console.WriteLine("[Left]Ăn tại vị trí: " + viTri);
                    int score = OQuanBanCo[viTri].GetValue();
                    Console.WriteLine(score);
                    OQuanBanCo[viTri].SetValue(0);
                    Result result = new Result(adapter(OQuanBanCo));
                    results.Add(result);
                    viTri++;
                    if (viTri == 12)
                    {
                        viTri = 0;
                    }
                    if (OQuanBanCo[viTri].GetValue() == 0 && viTri % 6 != 0)
                    {
                        return score + eatLeft(viTri);
                    }
                    else
                    {
                        return score;
                    }
                }
            }
            return 0;
        }

        public int eatRight(int viTri)
        {
            if (OQuanBanCo[viTri].GetValue() == 0 && viTri % 6 != 0)
            {
                viTri--;
                if (viTri == -1)
                {
                    viTri = 11;
                }
                if (OQuanBanCo[viTri].GetValue() != 0)
                {
                    Console.WriteLine("[Right]Ăn tại vị trí: " + viTri);
                    int score = OQuanBanCo[viTri].GetValue();
                    Console.WriteLine(score);
                    OQuanBanCo[viTri].SetValue(0);
                    Result result = new Result(adapter(OQuanBanCo));
                    results.Add(result);
                    viTri--;
                    if (viTri == -1)
                    {
                        viTri = 11;
                    }
                    if (OQuanBanCo[viTri].GetValue() == 0 && viTri % 6 != 0)
                    {
                        return score + eatRight(viTri);
                    }
                    else
                    {
                        return score;
                    }
                }
            }
            return 0;
        }

        public bool finish()
        {
            // kiểm tra nếu 2 ô quan đều = 0 thì tiến hành dừng
            if (OQuanBanCo[0].GetValue() == 0 && OQuanBanCo[6].GetValue() == 0)
            {
                
                Console.WriteLine("Game over");
                return true;
            }
            if (OQuanBanCo[12].GetValue() == 0)
            {
                if (kiemTraHetQuan(1))
                {
                    return true;

                }
            }
            if (OQuanBanCo[13].GetValue() == 0)
            {
                if (kiemTraHetQuan(2))
                {
                    return true;
                }
            }
            return false;
        }

        
        public bool kiemTra(int viTri, int player)
        {
            if (player == 1)
            {
                if (viTri != 1 && viTri != 2 && viTri != 3 && viTri != 4 && viTri != 5)
                {
                    return false;
                }
                if (OQuanBanCo[viTri].GetValue() == 0 || viTri % 6 == 0)
                {
                    return false;
                }
            }
            else
            {
                if (viTri == 1 || viTri == 2 || viTri == 3 || viTri == 4 || viTri == 5)
                {
                    return false;
                }
                if (OQuanBanCo[viTri].GetValue() == 0 || viTri % 6 == 0)
                {
                    return false;
                }
            }
            return true;
        }

        
        public int addScore(int player)
        {
            int score = 0;
            if (player == 1)
            {
                for (int i = 1; i < 6; i++)
                {
                    score += OQuanBanCo[i].GetValue();
                    OQuanBanCo[i].SetValue(0);
                }
                setScoreComputer(score);
            }
            else
            {
                for (int i = 7; i < 12; i++)
                {
                    score += OQuanBanCo[i].GetValue();
                    OQuanBanCo[i].SetValue(0);
                }
                setScorePlayer(score);
            }
            return score;
        }

        public bool kiemTraHetQuan(int player)
        {
            if (player == 1)
            {
                int score = 0;
                // chạy từ 1 -> vì đây là các ô của máy
                for (int i = 1; i < 6; i++)
                {
                    score += OQuanBanCo[i].GetValue();
                }
                if (score == 0)
                {
                    return true;
                }
            }
            else
            {
                int score = 0;
                for (int i = 7; i < 12; i++)
                {
                    score += OQuanBanCo[i].GetValue();
                }
                if (score == 0)
                {
                    return true;
                }
            }
            return false;
        }

        
        public int raiQuan(int player)
        {
            if (player == 1)
            {
                int score = OQuanBanCo[12].GetValue();
                if (score <= 5)
                {
                    for (int i = 1; i <= score; i++)
                    {
                        OQuanBanCo[i].SetValue(1);
                    }
                    OQuanBanCo[12].SetValue(0);
                    Result r = new Result(adapter(OQuanBanCo));
                    results.Add(r);
                    return score;
                }
                else
                {
                    for (int i = 1; i < 6; i++)
                    {
                        OQuanBanCo[i].SetValue(1);
                    }
                    OQuanBanCo[12].SetValue(score - 5);
                    Result r = new Result(adapter(OQuanBanCo));
                    results.Add(r);
                    return 5;
                }
            }
            else
            {
                int score = OQuanBanCo[13].GetValue();
                if (score <= 5)
                {
                    for (int i = 7; i < 7 + score; i++)
                    {
                        OQuanBanCo[i].SetValue(1);
                    }
                    OQuanBanCo[13].SetValue(0);
                    Result r = new Result(adapter(OQuanBanCo));
                    results.Add(r);
                    return score;
                }
                else
                {
                    for (int i = 7; i < 12; i++)
                    {
                        OQuanBanCo[i].SetValue(1);
                    }
                    OQuanBanCo[13].SetValue(score - 5);
                    Result r = new Result(adapter(OQuanBanCo));
                    results.Add(r);
                    return 5;
                }
            }
        }

        public void setScoreComputer(int score)
        {
            int a = OQuanBanCo[12].GetValue();
            OQuanBanCo[12].SetValue(score + a);
            Result result = new Result(OQuanBanCo);
            results.Add(result);
        }

        public void setScorePlayer(int score)
        {
            // nếu ăn được điểm tiến hành cộng vào ô tổng điểm của player
            int a = OQuanBanCo[13].GetValue();
            OQuanBanCo[13].SetValue(score + a); // ô 13 chính là ô điểm của player
            Result result = new Result(OQuanBanCo);
            results.Add(result);
        }

        public OQuan_BanCo[] GetOQuanBanCo()
        {
            return OQuanBanCo;
        }

        public void SetOQuanBanCo(OQuan_BanCo[] OQuanBanCo)
        {
            this.OQuanBanCo = OQuanBanCo;
        }

        public List<Result> GetResults()
        {
            return results;
        }

        public void setResults(List<Result> results)
        {
            this.results = results;
        }



        //////////////////////////////// player 2
        public void setScorePlayer2(int score)
        {
            int a = OQuanBanCo[12].GetValue();
            OQuanBanCo[12].SetValue(score + a);
            Result result = new Result(OQuanBanCo);
            results.Add(result);
        }
        public int action2(int action, int viTri)
        {
            if (action == 1)
            {
                return left2(viTri);
            }
            else
            {
                return right2(viTri);
            }
        }

        public int eatting2(int action, int viTri)
        {
            if (action == 1)
            {
                return eatLeft2(viTri);
            }
            else
            {
                return eatRight2(viTri);
            }
        }

        public OQuan_BanCo[] adapter2(OQuan_BanCo[] OQuanBanCo)
        {
            OQuan_BanCo[] s = new OQuan_BanCo[OQuan_BanCoCount];
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = new OQuan_BanCo(i, OQuanBanCo[i].GetValue(), OQuanBanCo[i].IsQuan());
            }
            return s;
        }

        // trả về vị trí sau khi đi qua trái
        public int left2(int viTri)
        {
            int giaTri = OQuanBanCo[viTri].GetValue();
            OQuanBanCo[viTri].SetValue(0);
            Result r = new Result(adapter2(OQuanBanCo));
            results.Add(r);
            while (giaTri != 0)
            {
                viTri--;
                if (viTri == -1)
                {
                    viTri = 0;
                }
                OQuanBanCo[viTri].SetValue(OQuanBanCo[viTri].GetValue() + 1);
                giaTri--;
                Console.WriteLine("Vitri: " + viTri);
                Console.WriteLine("Di chuyển sang trái");
                Result result = new Result(adapter2(OQuanBanCo));
                results.Add(result);
            }
            viTri--;
            if (viTri == -1)
            {
                viTri = 0;
            }
            if (OQuanBanCo[viTri].GetValue() != 0 && viTri % 6 != 0)
            {
                return left2(viTri);
            }
            else
            {
                return viTri++;
            }
        }


        // trả về vị trí sau khi đi qua phải
        public int right2(int viTri)
        {
            int giaTri = OQuanBanCo[viTri].GetValue();
            OQuanBanCo[viTri].SetValue(0);
            Result r = new Result(adapter2(OQuanBanCo));
            results.Add(r);
            while (giaTri != 0)
            {
                viTri++;
                if (viTri == 12)
                {
                    viTri = 1;
                }
                OQuanBanCo[viTri].SetValue(OQuanBanCo[viTri].GetValue() + 1);
                giaTri--;
                Console.WriteLine("Vitri: " + viTri);
                Console.WriteLine("Di chuyển sang phải");
                Result result = new Result(adapter2(OQuanBanCo));
                results.Add(result);
            }
            viTri++;
            if (viTri == 12)
            {
                viTri = 1;
            }
            if (OQuanBanCo[viTri].GetValue() != 0 && viTri % 6 != 0)
            {
                return right2(viTri);
            }
            else
            {
                return viTri++;
            }
        }

        public int eatLeft2(int viTri)
        {
            if (OQuanBanCo[viTri].GetValue() == 0 && viTri % 6 != 0)
            {
                viTri--;
                if (viTri == -1)
                {
                    viTri = 0;
                }
                if (OQuanBanCo[viTri].GetValue() != 0)
                {
                    Console.WriteLine("[Left]Ăn tại vị trí: " + viTri);
                    int score = OQuanBanCo[viTri].GetValue();
                    Console.WriteLine(score);
                    OQuanBanCo[viTri].SetValue(0);
                    Result result = new Result(adapter2(OQuanBanCo));
                    results.Add(result);
                    viTri--;
                    if (viTri == -1)
                    {
                        viTri = 0;
                    }
                    if (OQuanBanCo[viTri].GetValue() == 0 && viTri % 6 != 0)
                    {
                        return score + eatLeft2(viTri);
                    }
                    else
                    {
                        return score;
                    }
                }
            }
            return 0;
        }

        public int eatRight2(int viTri)
        {
            if (OQuanBanCo[viTri].GetValue() == 0 && viTri % 6 != 0)
            {
                viTri++;
                if (viTri == 12)
                {
                    viTri = 1;
                }
                if (OQuanBanCo[viTri].GetValue() != 0)
                {
                    Console.WriteLine("[Right]Ăn tại vị trí: " + viTri);
                    int score = OQuanBanCo[viTri].GetValue();
                    Console.WriteLine(score);
                    OQuanBanCo[viTri].SetValue(0);
                    Result result = new Result(adapter2(OQuanBanCo));
                    results.Add(result);
                    viTri++;
                    if (viTri == 12)
                    {
                        viTri = 1;
                    }
                    if (OQuanBanCo[viTri].GetValue() == 0 && viTri % 6 != 0)
                    {
                        return score + eatRight2(viTri);
                    }
                    else
                    {
                        return score;
                    }
                }
            }
            return 0;
        }
    }
}

