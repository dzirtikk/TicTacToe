namespace TicTacToe

{
    public partial class Form1 : Form
    {
        public string[] Pole = new string[26];
        public int hod=1;
        public Form1()
        {
            InitializeComponent();
            panel1.Hide();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "3x3":
                    #region
                    button4.Hide();
                    button5.Hide();
                    button9.Hide();
                    button10.Hide();
                    button14.Hide();
                    button15.Hide();
                    button16.Hide();
                    button17.Hide();
                    button18.Hide();
                    button19.Hide();
                    button20.Hide();
                    button21.Hide();
                    button22.Hide();
                    button23.Hide();
                    button24.Hide();
                    button25.Hide();
                    break;
                #endregion
                case "4x4":
                    #region
                    button4.Show();
                    button5.Hide();
                    button9.Show();
                    button10.Hide();
                    button14.Show();
                    button15.Hide();
                    button19.Show();
                    button18.Show();
                    button17.Show();
                    button16.Show();
                    button20.Hide();
                    button21.Hide();
                    button22.Hide();
                    button23.Hide();
                    button24.Hide();
                    button25.Hide();
                    break;
                #endregion
                case "5x5":
                    #region
                    button4.Show();
                    button5.Show();
                    button9.Show();
                    button10.Show();
                    button14.Show();
                    button15.Show();
                    button16.Show();
                    button17.Show();
                    button18.Show();
                    button19.Show();
                    button20.Show();
                    button21.Show();
                    button22.Show();
                    button23.Show();
                    button24.Show();
                    button25.Show();
                    break;
                    #endregion

            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Game.Start(comboBox1.Text, comboBox2.Text);
            for (int i = 0; i < Pole.Length; i++)
            {
                Pole[i] = i.ToString();
            }
            hod = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Pole[1] != "X" && Pole[1] != "O") //проверка можно ли здесь ходить
            {
                Pole = Game.Hod(Pole, hod, comboBox1.Text, 1); //Делаем ход и меняем поле
                if (hod % 2 == 0) button1.Text = "X"; else button1.Text = "O"; //Меняем вид кнопки взависимости от того кто ходит
                hod++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Pole[2] != "X" && Pole[2] != "O")
            {
                Pole = Game.Hod(Pole, hod, comboBox1.Text, 2);
                if (hod % 2 == 0) button2.Text = "X"; else button2.Text = "O";
                hod++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Pole[3] != "X" && Pole[3] != "O")
            {
                Pole = Game.Hod(Pole, hod, comboBox1.Text, 3);
                if (hod % 2 == 0) button3.Text = "X"; else button3.Text = "O";
                hod++;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Pole[6] != "X" && Pole[6] != "O")
            {
                Pole = Game.Hod(Pole, hod, comboBox1.Text, 6);
                if (hod % 2 == 0) button6.Text = "X"; else button6.Text = "O";
                hod++;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Pole[7] != "X" && Pole[7] != "O")
            {
                Pole = Game.Hod(Pole, hod, comboBox1.Text, 7);
                if (hod % 2 == 0) button7.Text = "X"; else button7.Text = "O";
                hod++;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Pole[8] != "X" && Pole[8] != "O")
            {
                Pole = Game.Hod(Pole, hod, comboBox1.Text, 8);
                if (hod % 2 == 0) button8.Text = "X"; else button8.Text = "O";
                hod++;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Pole[11] != "X" && Pole[11] != "O")
            {
                Pole = Game.Hod(Pole, hod, comboBox1.Text, 11);
                if (hod % 2 == 0) button11.Text = "X"; else button11.Text = "O";
                hod++;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (Pole[12] != "X" && Pole[12] != "O")
            {
                Pole = Game.Hod(Pole, hod, comboBox1.Text, 12);
                if (hod % 2 == 0) button12.Text = "X"; else button12.Text = "O";
                hod++;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (Pole[13] != "X" && Pole[13] != "O")
            {
                Pole = Game.Hod(Pole, hod, comboBox1.Text, 13);
                if (hod % 2 == 0) button13.Text = "X"; else button13.Text = "O";
                hod++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Pole[4] != "X" && Pole[4] != "O")
            {
                Pole = Game.Hod(Pole, hod, comboBox1.Text, 4);
                if (hod % 2 == 0) button4.Text = "X"; else button4.Text = "O";
                hod++;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Pole[9] != "X" && Pole[9] != "O")
            {
                Pole = Game.Hod(Pole, hod, comboBox1.Text, 9);
                if (hod % 2 == 0) button9.Text = "X"; else button9.Text = "O";
                hod++;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (Pole[14] != "X" && Pole[14] != "O")
            {
                Pole = Game.Hod(Pole, hod, comboBox1.Text, 14);
                if (hod % 2 == 0) button14.Text = "X"; else button14.Text = "O";
                hod++;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (Pole[19] != "X" && Pole[19] != "O")
            {
                Pole = Game.Hod(Pole, hod, comboBox1.Text, 19);
                if (hod % 2 == 0) button19.Text = "X"; else button19.Text = "O";
                hod++;
            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (Pole[18] != "X" && Pole[18] != "O")
            {

                if (hod % 2 == 0) button18.Text = "X"; else button18.Text = "O";

                Pole = Game.Hod(Pole, hod, comboBox1.Text, 18);
                hod++;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (Pole[17] != "X" && Pole[17] != "O")
            {
                Pole = Game.Hod(Pole, hod, comboBox1.Text, 17);
                if (hod % 2 == 0) button17.Text = "X"; else button17.Text = "O";
                hod++;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (Pole[16] != "X" && Pole[16] != "O")
            {
                Pole = Game.Hod(Pole, hod, comboBox1.Text, 16);
                if (hod % 2 == 0) button16.Text = "X"; else button16.Text = "O";
                hod++;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Pole[5] != "X" && Pole[5] != "O")
            {
                Pole = Game.Hod(Pole, hod, comboBox1.Text, 5);
                if (hod % 2 == 0) button5.Text = "X"; else button5.Text = "O";
                hod++;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Pole[10] != "X" && Pole[10] != "O")
            {
                Pole = Game.Hod(Pole, hod, comboBox1.Text, 10);
                if (hod % 2 == 0) button10.Text = "X"; else button10.Text = "O";
                hod++;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (Pole[15] != "X" && Pole[15] != "O")
            {
                Pole = Game.Hod(Pole, hod, comboBox1.Text, 15);
                if (hod % 2 == 0) button15.Text = "X"; else button15.Text = "O";
                hod++;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (Pole[20] != "X" && Pole[20] != "O")
            {
                Pole = Game.Hod(Pole, hod, comboBox1.Text, 20);
                if (hod % 2 == 0) button20.Text = "X"; else button20.Text = "O";
                hod++;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (Pole[25] != "X" && Pole[25] != "O")
            {
                Pole = Game.Hod(Pole, hod, comboBox1.Text, 25);
                if (hod % 2 == 0) button25.Text = "X"; else button25.Text = "O";
                hod++;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (Pole[24] != "X" && Pole[24] != "O")
            {
                Pole = Game.Hod(Pole, hod, comboBox1.Text, 24);
                if (hod % 2 == 0) button24.Text = "X"; else button24.Text = "O";
                hod++;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (Pole[23] != "X" && Pole[23] != "O")
            {
                Pole = Game.Hod(Pole, hod, comboBox1.Text, 23);
                if (hod % 2 == 0) button23.Text = "X"; else button23.Text = "O";
                hod++;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (Pole[22] != "X" && Pole[22] != "O")
            {
                Pole = Game.Hod(Pole, hod, comboBox1.Text, 22);
                if (hod % 2 == 0) button22.Text = "X"; else button22.Text = "O";
                hod++;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (Pole[21] != "X" && Pole[21] != "O")
            {
                Pole = Game.Hod(Pole, hod, comboBox1.Text, 21);
                if (hod % 2 == 0) button21.Text = "X"; else button21.Text = "O";
                hod++;
            }
        }
    }
}