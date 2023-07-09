using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ThuVienClass
{
    public class Minimax : BanCo
    {
        public int MIN_VALUE = -2147483648, MAX_VALUE = 2147483647;

        //thực hiện đệ quy để tìm ô có giá trị tốt nhất để đi
        public int[] minimax(BanCo banCo, int depth, int player)
        {
            if (player == 1)
            {
                if (banCo.kiemTraHetQuan(player))
                {
                    banCo.raiQuan(player);
                }
            }
            else
            {
                if (banCo.kiemTraHetQuan(player))
                {
                    banCo.raiQuan(player);
                }
            }
            OQuan_BanCo[] OQuanBanCo = banCo.GetOQuanBanCo();
            int[] valueRoot = new int[14];
            // tạo 1 mảng valueRoot lưu giá trị của các ô hiện tại
            for (int i = 0; i < 14; i++)
            {
                valueRoot[i] = OQuanBanCo[i].GetValue();
            }
            // đếm số ô có thể tiến hành di chuyển
            List<int> moves = generateMoves(banCo, player);
            int bestScore = (player == 1) ? MIN_VALUE : MAX_VALUE;
            int currentScore;
            int bestLocation = -1;
            int action = 0;
            // tra ve ham danh gia
            if (depth == 0 || banCo.finish())
            {
                if (banCo.finish())
                {
                    banCo.addScore(1);
                    banCo.addScore(2);
                }
                bestScore = OQuanBanCo[12].GetValue() - OQuanBanCo[13].GetValue();
            }
            else
            {
                for (int i = 0; i < moves.Count; i++)
                {
                    // thuc hien ham left or right
                    for (int k = 1; k < 3; k++)
                    {
                        int score = 0;
                        int location = banCo.action(k, moves[i]);
                        if (banCo.Check_ViTriEat(location))
                        {
                            score = banCo.eatting(k, location);
                        }

                        if (player == 1)
                        { 
                            // tiến hành cộng điểm cho máy
                            banCo.setScoreComputer(score);
                            currentScore = minimax(banCo, depth - 1, 1)[0];
                            if (currentScore > bestScore)
                            {
                                bestScore = currentScore;
                                bestLocation = moves[i];
                                action = k;
                            }
                        }
                        else
                        { // min player
                            banCo.setScorePlayer(score);
                            currentScore = minimax(banCo, depth - 1, 2)[0];
                            if (currentScore < bestScore)
                            {
                                bestScore = currentScore;
                                bestLocation = moves[i];
                                action = k;
                            }
                        }

                        // khoi phuc trang thai ban cờ cũ và tiến hành đệ quy để tìm bestlocation
                        for (int j = 0; j < 14; j++)
                        {
                            if (j == 0 || j == 6)
                            {
                                OQuanBanCo[j] = new OQuan_BanCo(j, valueRoot[j], true);
                            }
                            else
                            {
                                OQuanBanCo[j] = new OQuan_BanCo(j, valueRoot[j], false);
                            }
                        }
                    }
                }
            }
            return new int[] { bestScore, bestLocation, action };
        }

        // so buoc tiep theo co the co
        public List<int> generateMoves(BanCo banCo, int player)
        {
            OQuan_BanCo[] OQuanBanCo = banCo.GetOQuanBanCo();
            List<int> result = new List<int>();
            if (banCo.finish())
            {
                return result;
            }
            if (player == 1)
            {
                for (int i = 1; i < 6; i++)
                {
                    if (OQuanBanCo[i].GetValue() != 0)
                    {
                        result.Add(i);
                    }
                }
            }
            else
            {
                for (int i = 7; i < 12; i++)
                {
                    if (OQuanBanCo[i].GetValue() != 0)
                    {
                        result.Add(i);
                    }
                }
            }
            return result;
        }
    }
}
