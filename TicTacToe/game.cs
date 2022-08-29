using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Game
    {
        public static void Start(string size, string mode)
        {
            MessageBox.Show($"Начнём игру! Размер поля равен {size}, режим игры {mode} ");
        }

        public static string CheckWin(string[] Pole, string size)
        {
            switch (size)
            {
                case "3x3":
                    #region
                    if (Pole[1] == Pole[2] && Pole[2] == Pole[3])
                    {
                        return Pole[1];
                    }
                    else if (Pole[6] == Pole[7] && Pole[7] == Pole[8])
                    {
                        return Pole[6];
                    }
                    else if (Pole[11] == Pole[12] && Pole[12] == Pole[13])
                    {
                        return Pole[11];
                    } //Вертикальные
                    else if (Pole[1] == Pole[6] && Pole[6] == Pole[11])
                    {
                        return Pole[1];
                    }
                    else if (Pole[2] == Pole[7] && Pole[7] == Pole[12])
                    {
                        return Pole[2];
                    }
                    else if (Pole[3] == Pole[8] && Pole[8] == Pole[13])
                    {
                        return Pole[3];
                    }//Косые линии
                    else if (Pole[1] == Pole[7] && Pole[7] == Pole[13])
                    {
                        return Pole[1];
                    }
                    else if (Pole[11] == Pole[7] && Pole[7] == Pole[3])
                    {
                        return Pole[21];
                    }
                    else return Pole[0];
                #endregion
                case "4x4":
                    #region
                    if (Pole[1] == Pole[2] && Pole[2] == Pole[3] && Pole[3] == Pole[4])
                    {
                        return Pole[1];
                    }
                    else if (Pole[6] == Pole[7] && Pole[7] == Pole[8] && Pole[8] == Pole[9])
                    {
                        return Pole[6];
                    }
                    else if (Pole[11] == Pole[12] && Pole[12] == Pole[13] && Pole[13] == Pole[14])
                    {
                        return Pole[11];
                    }
                    else if (Pole[16] == Pole[17] && Pole[17] == Pole[18] && Pole[18] == Pole[19])
                    {
                        return Pole[16];
                    } //Вертикальные
                    else if (Pole[1] == Pole[6] && Pole[6] == Pole[11] && Pole[11] == Pole[16])
                    {
                        return Pole[1];
                    }
                    else if (Pole[2] == Pole[7] && Pole[7] == Pole[12] && Pole[12] == Pole[17])
                    {
                        return Pole[2];
                    }
                    else if (Pole[3] == Pole[8] && Pole[8] == Pole[13] && Pole[13] == Pole[18])
                    {
                        return Pole[3];
                    }
                    else if (Pole[4] == Pole[9] && Pole[9] == Pole[14] && Pole[14] == Pole[19])
                    {
                        return Pole[4];
                    }//Косые линии
                    else if (Pole[1] == Pole[7] && Pole[7] == Pole[13] && Pole[13] == Pole[19])
                    {
                        return Pole[1];
                    }
                    else if (Pole[16] == Pole[12] && Pole[12] == Pole[8] && Pole[8] == Pole[4])
                    {
                        return Pole[21];
                    }
                    else return Pole[0];
                #endregion
                case "5x5":
                    #region
                    //горизонтали
                    if (Pole[1] == Pole[2] && Pole[2] == Pole[3] && Pole[3] == Pole[4] && Pole[4] == Pole[5])
                    {
                        return Pole[1];
                    }
                    else if (Pole[6] == Pole[7] && Pole[7] == Pole[8] && Pole[8] == Pole[9] && Pole[9] == Pole[10])
                    {
                        return Pole[6];
                    }
                    else if (Pole[11] == Pole[12] && Pole[12] == Pole[13] && Pole[13] == Pole[14] && Pole[14] == Pole[15])
                    {
                        return Pole[11];
                    }
                    else if (Pole[16] == Pole[17] && Pole[17] == Pole[18] && Pole[18] == Pole[19] && Pole[19] == Pole[20])
                    {
                        return Pole[16];
                    }
                    else if (Pole[21] == Pole[22] && Pole[22] == Pole[23] && Pole[23] == Pole[24] && Pole[24] == Pole[25])
                    {
                        return Pole[21];
                    }//Вертикальные
                    else if (Pole[1] == Pole[6] && Pole[6] == Pole[11] && Pole[11] == Pole[16] && Pole[16] == Pole[21])
                    {
                        return Pole[1];
                    }
                    else if (Pole[2] == Pole[7] && Pole[7] == Pole[12] && Pole[12] == Pole[17] && Pole[17] == Pole[22])
                    {
                        return Pole[2];
                    }
                    else if (Pole[3] == Pole[8] && Pole[8] == Pole[13] && Pole[13] == Pole[18] && Pole[18] == Pole[23])
                    {
                        return Pole[3];
                    }
                    else if (Pole[4] == Pole[9] && Pole[9] == Pole[14] && Pole[14] == Pole[19] && Pole[19] == Pole[24])
                    {
                        return Pole[4];
                    }
                    else if (Pole[5] == Pole[10] && Pole[10] == Pole[15] && Pole[15] == Pole[20] && Pole[20] == Pole[25])
                    {
                        return Pole[5];
                    }//Косые линии
                    else if (Pole[1] == Pole[7] && Pole[7] == Pole[13] && Pole[13] == Pole[19] && Pole[19] == Pole[25])
                    {
                        return Pole[1];
                    }
                    else if (Pole[21] == Pole[17] && Pole[17] == Pole[13] && Pole[13] == Pole[9] && Pole[9] == Pole[5])
                    {
                        return Pole[21];
                    }
                    else return Pole[0];
                #endregion
                default: return Pole[0];
            }
        }

        public static string[] Hod(string[] Pole, int hod, string size, int ButtonNumber)
        {
                
                string HodZnak;
                if (hod % 2 == 0) HodZnak = "O";
                else HodZnak = "X";//если ход нечётный то O ставится, если чётный то X
                Pole[ButtonNumber] = HodZnak;//изменяем ячейку поля
                if (CheckWin(Pole, size) == "X")//проверяем есть ли победы
                {
                    MessageBox.Show($"Победил игрок 1, количество ходов: {hod}");
                }
                else if (CheckWin(Pole, size) == "O")
                {
                    MessageBox.Show($"Победил игрок 2, количество ходов: {hod}");
                }
            return Pole;// возращаем изменённое поле
        }
    }
}
