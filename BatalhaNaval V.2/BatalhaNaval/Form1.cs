using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatalhaNaval
{
    public partial class Form1 : Form
    {
        int i1 = 0;
        int i2 = 0;
        int i3 = 0;
        int i4 = 0;
        int i5 = 0;

        int vezes5 = 0;
        int vezes4 = 0;
        int vezes3 = 0;
        int vezes2 = 0;
        int vezes1 = 0;

        int trinca = 0;

        int quantidade = 0;
        int n1 = 0;
        int vez = 0;


        int tiro_inteligenteint = 0;

        int cornenada = 0;

        int horizotal = 30;
        int vertical = 30;

        int cadeado = 0;

        

        Button[] buttonArray = new Button[100];
        Button[] buttonArray2 = new Button[100];

        int barco1 = 1;
        int barco2 = 1;
        int barco3 = 1;
        int barco4 = 1;
        int barco5 = 1;

        int falta1 = 17;
        int falta2 = 17;

        int dificuldade = 0;
        int dificuldadedifi = 0;

        List<int> valores_ver1 = new List<int>(new int[] { 04, 14, 24, 34, 44, 54, 64, 74, 84, 94, 05, 15, 25, 35, 45, 55, 56, 57, 58, 59 });
        List<int> valores_ver2 = new List<int>(new int[] { 04, 14, 24, 34, 44, 54, 64, 74, 84, 94, 05, 15, 25, 35, 45, 55, 56, 57, 58, 59, 03, 13, 23, 33, 43, 53, 63, 73, 83, 93, 06, 16, 26, 36, 46, 56, 66, 76, 86, 96 });
        List<int> valores_ver3 = new List<int>(new int[] { 04, 14, 24, 34, 44, 54, 64, 74, 84, 94, 05, 15, 25, 35, 45, 55, 56, 57, 58, 59, 03, 13, 23, 33, 43, 53, 63, 73, 83, 93, 06, 16, 26, 36, 46, 56, 66, 76, 86, 96, 07, 17, 27, 37, 47, 57, 67, 77, 87, 97, 02, 12, 22, 32, 42, 52, 62, 72, 82, 92 });
        List<int> valores_ver4 = new List<int>(new int[] { 04, 14, 24, 34, 44, 54, 64, 74, 84, 94, 05, 15, 25, 35, 45, 55, 56, 57, 58, 59, 03, 13, 23, 33, 43, 53, 63, 73, 83, 93, 06, 16, 26, 36, 46, 56, 66, 76, 86, 96, 07, 17, 27, 37, 47, 57, 67, 77, 87, 97, 02, 12, 22, 32, 42, 52, 62, 72, 82, 92 });
        List<int> valores_ver5 = new List<int>(new int[] { 04, 14, 24, 34, 44, 54, 64, 74, 84, 94, 05, 15, 25, 35, 45, 55, 56, 57, 58, 59, 03, 13, 23, 33, 43, 53, 63, 73, 83, 93, 06, 16, 26, 36, 46, 56, 66, 76, 86, 96, 07, 17, 27, 37, 47, 57, 67, 77, 87, 97, 02, 12, 22, 32, 42, 52, 62, 72, 82, 92, 01, 11, 21, 31, 41, 51, 61, 71, 81, 91, 08, 18, 28, 38, 48, 58, 68, 78, 88, 98 });



        List<int> manual = new List<int>();
        List<int> tiro_inteligente = new List<int>();

        Random random = new Random();
        Random random1 = new Random();

    

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < buttonArray.Length; i++)
            {
                buttonArray[i] = new Button();
                buttonArray[i].Size = new Size(30, 30);
                buttonArray[i].Location = new Point(horizotal, vertical);
                buttonArray[i].Name = string.Format("{0}{1}{2}{3}", "X", i / 10, "Y", i % 10);  // Cria a primeira grid
                buttonArray[i].BackColor = Color.Transparent;
                buttonArray[i].Text = string.Format("{0}", i);
                buttonArray[i].ForeColor = Color.Transparent;

                if ((i + 1) % 10 == 0)
                {
                    horizotal += 30;
                    vertical -= 270;
                }
                else
                {
                    vertical += 30;

                }
                buttonArray[i].Click += new System.EventHandler(evento_click);

                this.Controls.Add(buttonArray[i]);

                bstart.Visible = false;
                lfalta1.Visible = false;
                lfalta2.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                brestart.Visible = false;
                bdificil.Visible = false;
                bfacil.Visible = false;
                bmedio.Visible = false;
                bgrid.Visible = false;

                //porta_aviões.Visible = false;
                //bcouraçado.Visible = false;
                //bcruzador.Visible = false;
                //bsubmarino.Visible = false;
                //bcontratorpedeiro.Visible = false;
                //bstart.Visible = true;


            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void evento_click(object sender, EventArgs e)
        {

            Button b = (Button)sender;

            if (barco1 == 1 && quantidade == 0 && b.BackColor != Color.Red)
            {
                if (n1 == 1)
                {

                    quantidade = 5;
                    Lunidades.Text = "Numero de unidades : " + quantidade.ToString();  // Criação manual porta avião
                    barco1 = 0;
                }
            }

            if (barco2 == 1 && quantidade == 0 && b.BackColor != Color.Red)
            {
                if (n1 == 2)
                {

                    quantidade = 4;
                    Lunidades.Text = "Numero de unidades : " + quantidade.ToString();  // Criação manual Couraçado
                    barco2 = 0;
                }
            }

            if (barco3 == 1 && quantidade == 0 && b.BackColor != Color.Red)
            {

                if (n1 == 3)
                {

                    quantidade = 3;
                    Lunidades.Text = "Numero de unidades : " + quantidade.ToString();    // Criação manual Cruzador
                    barco3 = 0;
                }
            }

            if (barco4 == 1 && quantidade == 0 && b.BackColor != Color.Red)
            {

                if (n1 == 4)
                {

                    quantidade = 3;
                    Lunidades.Text = "Numero de unidades : " + quantidade.ToString();    // Criação manual Submarino
                    barco4 = 0;
                }
            }

            if (barco5 == 1 && quantidade == 0 && b.BackColor != Color.Red)
            {

                if (n1 == 5)
                {

                    quantidade = 2;
                    Lunidades.Text = "Numero de unidades : " + quantidade.ToString();   // Criação manual Contratorpedeiro
                    barco5 = 0;
                }
            }

            if (quantidade >= 1)      // Sistema que limita o usuario a só por seus barcos em linha reta
            {

                if (manual.Count > 0)
                {
                    int name = Convert.ToInt32(b.Text);
                    manual.Add(name);
                    if (manual[cornenada] == manual[cornenada + 1] - 10 || manual[cornenada] == manual[cornenada + 1] - 1 || manual[cornenada] == manual[cornenada + 1] + 1 || manual[cornenada] == manual[cornenada + 1] + 10)
                    {
                        b.BackColor = Color.Red;
                        quantidade -= 1;
                        Lunidades.Text = "Numero de unidades : " + quantidade.ToString();
                        cornenada++;
                    }
                    else
                    {
                        manual.Remove(manual[cornenada + 1]);
                    }
                }
                else
                {
                    if (b.BackColor != Color.Red)
                    {
                        int name = Convert.ToInt32(b.Text);

                        manual.Add(name);

                        b.BackColor = Color.Red;
                        quantidade -= 1;
                        Lunidades.Text = "Numero de unidades : " + quantidade.ToString();
                    }
                }
                if (quantidade == 0)
                {
                    manual.Clear();
                    cornenada = 0;
                }
            }


            if (barco1 == 0 && barco2 == 0 && barco3 == 0 && barco4 == 0 && barco5 == 0 && quantidade == 0)
            {
                porta_aviões.Visible = false;
                bcouraçado.Visible = false;
                bcruzador.Visible = false;                   // Some com os botoes dos barcos
                bsubmarino.Visible = false;                  // Quando tudo for colocado
                bcontratorpedeiro.Visible = false;

                if (dificuldade == 0 && dificuldadedifi == 0)
                {
                    bdificil.Visible = true;
                    bfacil.Visible = true;
                    bmedio.Visible = true;
                }




            }


        }

        private void Bstart_Click(object sender, EventArgs e)
        {
            trinca = 1;
            if (cadeado == 0)
            {
                bstart.Visible = false;

                i1 = 0;
                i2 = 0;
                i3 = 0;
                i4 = 0;
                i5 = 0;

                for (int i = 0; i <= 99; i++)
                {
                    buttonArray2[i].ForeColor = Color.Black;
                }

                vezes1 = random1.Next(0, 100);
                int segurança17 = 0;
                for (int i = 0; i < buttonArray.Length; i++)
                {

                    if (buttonArray2[i].ForeColor == Color.Yellow)
                    {
                        segurança17++;
                    }
                }
                if (segurança17 == 17)
                {

                    cadeado = 1;
                    return;

                }
                if (vezes1 <= 50)
                {

                    int num1 = random1.Next(0, 19);
                    int valor1 = valores_ver1[num1];
                    for (i1 = 0; i1 < 5; i1++)
                    {
                        if (valor1 <= 99)
                        {

                            if (buttonArray2[valor1].ForeColor != Color.Yellow && valor1 % 10 != 9)
                            {

                                buttonArray2[valor1].ForeColor = Color.Yellow;    // Criação Altomatica do porta Avião 
                                valor1++;
                            }

                            else
                            {


                                for (int i = 0; i <= 99; i++)
                                {

                                    buttonArray2[i].BackColor = Color.Transparent;
                                }
                                Bstart_Click(sender, e);
                            }
                        }
                        else
                        {
                            ;

                            for (int i = 0; i <= 99; i++)
                            {
                                buttonArray2[i].ForeColor = Color.Black;
                            }
                            Bstart_Click(sender, e);
                        }
                    }
                }
                int segurança16 = 0;
                for (int i = 0; i < buttonArray.Length; i++)
                {

                    if (buttonArray2[i].ForeColor == Color.Yellow)
                    {
                        segurança16++;
                    }


                }
                if (segurança16 == 17)
                {

                    cadeado = 1;
                    return;

                }
                if (vezes1 > 50)
                {

                    int num1 = random1.Next(0, 59);

                    for (i1 = 0; i1 < 5; i1++)
                    {
                        if (num1 <= 100)
                        {

                            if (buttonArray2[num1].ForeColor != Color.Yellow)
                            {

                                buttonArray2[num1].ForeColor = Color.Yellow;
                                num1 += 10;
                            }
                            else
                            {

                                for (int i = 0; i <= 99; i++)
                                {
                                    buttonArray2[i].ForeColor = Color.Black;
                                }
                                Bstart_Click(sender, e);
                            }
                        }
                        else
                        {

                            i1 = 0;
                            for (int i = 0; i <= 99; i++)
                            {

                                buttonArray2[i].ForeColor = Color.Black;
                            }
                            Bstart_Click(sender, e);
                        }
                    }
                }
                int segurança15 = 0;
                for (int i = 0; i < buttonArray.Length; i++)
                {

                    if (buttonArray2[i].ForeColor == Color.Yellow)
                    {
                        segurança15++;
                    }


                }
                if (segurança15 == 17)
                {

                    cadeado = 1;
                    return;

                }
                vezes2 = random1.Next(0, 100);
                if (vezes2 > 50)
                {

                    int num2 = random1.Next(0, 39);

                    int valor2 = valores_ver2[num2];
                    for (i2 = 0; i2 < 4; i2++)
                    {
                        if (valor2 <= 99)
                        {

                            if (buttonArray2[valor2].ForeColor != Color.Yellow && valor2 % 10 != 9)
                            {

                                buttonArray2[valor2].ForeColor = Color.Yellow;

                                valor2++;
                            }

                            else
                            {

                                for (int i = 0; i <= 99; i++)
                                {
                                    buttonArray2[i].ForeColor = Color.Black;
                                }
                                Bstart_Click(sender, e);
                            }
                        }
                        else
                        {

                            for (int i = 0; i <= 99; i++)
                            {
                                buttonArray2[i].ForeColor = Color.Black;
                            }
                            Bstart_Click(sender, e);
                        }
                    }
                }
                int segurança0 = 0;
                for (int i = 0; i < buttonArray.Length; i++)
                {

                    if (buttonArray2[i].ForeColor == Color.Yellow)
                    {
                        segurança0++;
                    }


                }
                if (segurança0 == 17)
                {

                    cadeado = 1;
                    return;

                }
                if (vezes2 <= 50)
                {

                    int num2 = random1.Next(0, 69);

                    for (i2 = 0; i2 < 4; i2++)
                    {
                        if (num2 <= 100)
                        {

                            if (buttonArray2[num2].ForeColor != Color.Yellow)
                            {

                                buttonArray2[num2].ForeColor = Color.Yellow;     // Criação Altomatica do Coraçado

                                num2 += 10;
                            }
                            else
                            {

                                for (int i = 0; i <= 99; i++)
                                {
                                    buttonArray2[i].ForeColor = Color.Black;
                                }
                                Bstart_Click(sender, e);
                            }

                        }
                        else
                        {

                            for (int i = 0; i <= 99; i++)
                            {
                                buttonArray2[i].ForeColor = Color.Black;
                            }
                            Bstart_Click(sender, e);
                        }
                    }
                }


                int segurança1 = 0;

                for (int i = 0; i < buttonArray.Length; i++)
                {
                    if (buttonArray2[i].ForeColor == Color.Yellow)
                    {
                        segurança1++;
                    }


                }
                if (segurança1 == 17)
                {

                    cadeado = 1;
                    return;
                }

                vezes3 = random1.Next(0, 100); ;
                if (vezes3 <= 50)
                {

                    int num3 = random1.Next(0, 59);

                    int valor3 = valores_ver3[num3];
                    for (i3 = 0; i3 < 3; i3++)
                    {
                        if (valor3 <= 99)
                        {

                            if (buttonArray2[valor3].ForeColor != Color.Yellow && valor3 % 10 != 9)
                            {

                                buttonArray2[valor3].ForeColor = Color.Yellow;
                                valor3++;
                            }
                            else
                            {

                                for (int i = 0; i <= 99; i++)
                                {
                                    buttonArray2[i].ForeColor = Color.Black;
                                }
                                Bstart_Click(sender, e);
                            }
                        }
                        else
                        {

                            for (int i = 0; i <= 99; i++)
                            {
                                buttonArray2[i].ForeColor = Color.Black;
                            }
                            Bstart_Click(sender, e);
                        }
                    }
                }
                int segurança14 = 0;
                for (int i = 0; i < buttonArray.Length; i++)
                {

                    if (buttonArray2[i].ForeColor == Color.Yellow)
                    {
                        segurança14++;
                    }
                }
                if (segurança14 == 17)
                {

                    cadeado = 1;
                    return;

                }
                if (vezes3 > 50)
                {

                    int num3 = random1.Next(0, 79);

                    for (i3 = 0; i3 < 3; i3++)
                    {
                        if (num3 <= 100)
                        {

                            if (buttonArray2[num3].ForeColor != Color.Yellow)
                            {

                                buttonArray2[num3].ForeColor = Color.Yellow;           //Criação altomatica do Cruzador
                                num3 += 10;
                            }
                            else
                            {

                                for (int i = 0; i <= 99; i++)
                                {
                                    buttonArray2[i].ForeColor = Color.Black;
                                }
                                Bstart_Click(sender, e);
                            }
                        }
                        else
                        {

                            for (int i = 0; i <= 99; i++)
                            {
                                buttonArray2[i].ForeColor = Color.Black;
                            }
                            bstart.PerformClick();
                        }
                    }
                }
                int segurança2 = 0;
                for (int i = 0; i < buttonArray.Length; i++)
                {
                    if (buttonArray2[i].ForeColor == Color.Yellow)
                    {
                        segurança2++;
                    }
                }
                if (segurança2 == 17)
                {

                    cadeado = 1;
                    return;

                }
                vezes4 = random1.Next(0, 100); ;
                if (vezes4 > 50)
                {

                    int num4 = random1.Next(0, 59);

                    int valor4 = valores_ver4[num4];
                    for (i4 = 0; i4 < 3; i4++)
                    {

                        if (valor4 <= 99)
                        {

                            if (buttonArray2[valor4].ForeColor != Color.Yellow && valor4 % 10 != 9)
                            {

                                buttonArray2[valor4].ForeColor = Color.Yellow;                 // Criação Altomatica do Submarino
                                valor4++;
                            }
                            else
                            {

                                for (int i = 0; i <= 99; i++)
                                {
                                    buttonArray2[i].ForeColor = Color.Black;
                                }
                                Bstart_Click(sender, e);
                            }
                        }
                        else
                        {

                            for (int i = 0; i <= 99; i++)
                            {
                                buttonArray2[i].ForeColor = Color.Black;
                            }
                            Bstart_Click(sender, e);
                        }
                    }
                }

                int segurança3 = 0;

                for (int i = 0; i < buttonArray.Length; i++)
                {
                    if (buttonArray2[i].ForeColor == Color.Yellow)
                    {
                        segurança3++;
                    }
                }
                if (segurança3 == 17)
                {

                    cadeado = 1;
                    return;
                }
                int segurança11 = 0;
                for (int i = 0; i < buttonArray.Length; i++)
                {

                    if (buttonArray2[i].ForeColor == Color.Yellow)
                    {
                        segurança11++;
                    }
                }
                if (segurança11 == 17)
                {

                    cadeado = 1;
                    return;

                }

                if (vezes4 <= 50)
                {
                    int num4 = random1.Next(0, 79);

                    for (i4 = 0; i4 < 3; i4++)
                    {
                        if (num4 <= 100)
                        {

                            if (buttonArray2[num4].ForeColor != Color.Yellow)
                            {

                                buttonArray2[num4].ForeColor = Color.Yellow;
                                num4 += 10;
                            }
                            else
                            {

                                for (int i = 0; i <= 99; i++)
                                {
                                    buttonArray2[i].ForeColor = Color.Black;
                                }
                                Bstart_Click(sender, e);
                            }
                        }
                        else
                        {


                            for (int i = 0; i <= 99; i++)
                            {
                                buttonArray2[i].ForeColor = Color.Black;
                            }
                            Bstart_Click(sender, e);
                        }
                    }
                }


                int segurança10 = 0;
                for (int i = 0; i < buttonArray.Length; i++)
                {

                    if (buttonArray2[i].ForeColor == Color.Yellow)
                    {
                        segurança10++;
                    }
                }
                if (segurança10 == 17)
                {
                    cadeado = 1;
                    return;
                }
                vezes5 = random1.Next(0, 100);
                if (vezes5 <= 50)
                {

                    int num5 = random1.Next(0, 79);
                    int valor5 = valores_ver5[num5];
                    for (i5 = 0; i5 < 2; i5++)
                    {
                        if (valor5 <= 99)
                        {

                            if (buttonArray2[valor5].ForeColor != Color.Yellow && valor5 % 10 != 9)          // Criação Altomatica do Contratorpedeiro
                            {
                                buttonArray2[valor5].ForeColor = Color.Yellow;
                                valor5++;
                            }
                            else
                            {


                                for (int i = 0; i <= 99; i++)
                                {
                                    buttonArray2[i].ForeColor = Color.Black;
                                }
                                Bstart_Click(sender, e);
                            }
                        }
                        else
                        {

                            for (int i = 0; i <= 99; i++)
                            {
                                buttonArray2[i].ForeColor = Color.Black;
                            }
                            Bstart_Click(sender, e);
                        }
                    }
                }
                int segurança4 = 0;
                for (int i = 0; i < buttonArray.Length; i++)
                {

                    if (buttonArray2[i].ForeColor == Color.Yellow)
                    {
                        segurança4++;
                    }
                }
                if (segurança4 == 17)
                {

                    cadeado = 1;
                    return;

                }
                if (vezes5 > 50)
                {

                    int num5 = random1.Next(0, 89);
                    for (i5 = 0; i5 < 2; i5++)
                    {
                        if (num5 <= 90)
                        {

                            if (buttonArray2[num5].ForeColor != Color.Yellow)
                            {

                                buttonArray2[num5].ForeColor = Color.Yellow;
                                num5 += 10;
                            }
                            else
                            {
                                for (int i = 0; i <= 99; i++)
                                {
                                    buttonArray2[i].ForeColor = Color.Black;
                                }
                                Bstart_Click(sender, e);
                            }
                        }
                        else
                        {

                            for (int i = 0; i <= 99; i++)
                            {
                                buttonArray2[i].ForeColor = Color.Black;
                            }
                            Bstart_Click(sender, e);
                        }
                    }
                }

            }
        }

        private void Porta_aviões_Click(object sender, EventArgs e)
        {
            n1 = 1;
            Lunidades.Text = "Numero de unidades : " + quantidade.ToString();
        }

        private void Bcouraçado_Click(object sender, EventArgs e)
        {
            n1 = 2;
            Lunidades.Text = "Numero de unidades : " + quantidade.ToString();
        }

        private void Bcruzador_Click(object sender, EventArgs e)
        {
            n1 = 3;
            Lunidades.Text = "Numero de unidades : " + quantidade.ToString();
        }

        private void Bsubmarino_Click(object sender, EventArgs e)
        {
            n1 = 4;
            Lunidades.Text = "Numero de unidades : " + quantidade.ToString();
        }

        private void Bcontratorpedeiro_Click(object sender, EventArgs e)
        {
            n1 = 5;
            Lunidades.Text = "Numero de unidades : " + quantidade.ToString();
        }

        private void Lunidades_Click(object sender, EventArgs e)
        {

        }
        public void evento_clickAD(object sender, EventArgs e)
        {
            if (trinca == 1)
            {
                int num = random.Next(0, 100);
                Button ba = (Button)sender;
                if (dificuldade == 1)
                {
                    if (vez == 0)
                    {
                        if (ba.BackColor == Color.Transparent && ba.ForeColor == Color.Black)
                        {
                            ba.BackColor = Color.Blue;
                            vez = 1;
                        }

                        if (ba.BackColor == Color.Transparent && ba.ForeColor == Color.Yellow)   // Sistema para tiro Manual
                        {
                            ba.BackColor = Color.Red;
                            vez = 1;
                            falta2 -= 1;
                            lfalta2.Text = "Falta : " + falta2.ToString();
                            if (falta2 == 0)
                            {
                                label1.Visible = true;
                                brestart.Visible = true;
                            }
                        }
                    }

                    if (vez == 1)  // Sistema de tiro Automatico e Inteligente
                    {
                        if (buttonArray[num].BackColor == Color.Red)
                        {
                            tiro_inteligenteint = 0;
                            tiro_inteligente.Add(Convert.ToInt32(buttonArray[num].Text));

                            // MessageBox.Show(num.ToString());

                            buttonArray[num].BackColor = Color.Yellow;

                            vez = 0;
                            falta1 -= 1;
                            lfalta1.Text = "Falta : " + falta1.ToString();
                            if (falta1 == 0)
                            {
                                label2.Visible = true;
                                brestart.Visible = true;
                            }
                        }

                        if (buttonArray[num].BackColor == Color.Transparent)
                        {
                            buttonArray[num].BackColor = Color.Blue;
                            vez = 0;
                        }
                        if (buttonArray[num].BackColor == Color.Blue)
                        {
                            ba.PerformClick();
                        }
                        if (buttonArray[num].BackColor == Color.Yellow)
                        {
                            ba.PerformClick();
                        }
                    }
                }
                if (dificuldade == 2)
                {

                    sistema_de_tiro(num, ba);
                }
                if (dificuldadedifi == 1)
                {
                    
                    for (int i = 0; i < 1; i++)
                    {

                        sistema_de_tiro(num, ba);
                    }

                }
            }
        }

        private void Brestart_Click(object sender, EventArgs e)
        {
            Application.Restart();

        }

        private void Bfacil_Click(object sender, EventArgs e)
        {
            bdificil.Visible = false;
            bfacil.Visible = false;
            bmedio.Visible = false;
            bgrid.Visible = true;
            dificuldade = 1;
            
        }

        private void Bdificil_Click(object sender, EventArgs e)
        {
            
            bdificil.Visible = false;
            bfacil.Visible = false;
            bmedio.Visible = false;
            bgrid.Visible = true;
            
            dificuldadedifi = 1;
            MessageBox.Show("Você vai perder !!!");
        }

        private void Bmedio_Click(object sender, EventArgs e)
        {
            
            bdificil.Visible = false;
            bfacil.Visible = false;
            bmedio.Visible = false;
            bgrid.Visible = true;
          
            
            dificuldade = 2;
        }

        private void Bgrid_Click(object sender, EventArgs e)
        {
            bstart.Visible = false;
            Lunidades.Visible = false;
            lfalta1.Visible = true;
            lfalta2.Visible = true;

            int horizotal = 400;
            for (int i = 0; i < buttonArray2.Length; i++)
            {


                buttonArray2[i] = new Button();
                buttonArray2[i].Size = new Size(30, 30);
                buttonArray2[i].Location = new Point(horizotal, vertical);
                buttonArray2[i].Name = string.Format("{0}{1}{2}{3}{4}", "X", i / 10, "Y", i % 10, "i");
                buttonArray2[i].BackColor = Color.Transparent;
                buttonArray2[i].ForeColor = Color.Black;                  //Criação da segunda Grid
                
                //buttonArray2[i].Text = string.Format("{0}", i);



                if ((i + 1) % 10 == 0)
                {
                    horizotal += 30;
                    vertical -= 270;
                }
                else
                {
                    vertical += 30;

                }
                buttonArray2[i].Click += new System.EventHandler(evento_clickAD);

                this.Controls.Add(buttonArray2[i]);

                bstart.Visible = true;
                bgrid.Visible = false;
            }
        }

        void sistema_de_tiro(int num,Button ba)
        {
            if (vez == 0)
            {
                if (ba.BackColor == Color.Transparent && ba.ForeColor == Color.Black)
                {
                    ba.BackColor = Color.Blue;
                    vez = 1;
                    
                }

                if (ba.BackColor == Color.Transparent && ba.ForeColor == Color.Yellow)   // Sistema para tiro Manual
                {
                    ba.BackColor = Color.Red;
                    vez = 1;
                    falta2 -= 1;
                    lfalta2.Text = "Falta : " + falta2.ToString();
                    if (falta2 == 0)
                    {
                        label1.Visible = true;
                        brestart.Visible = true;
                        trinca = 0;
                    }
                }
            }

            if (vez == 1)  // Sistema de tiro Automatico e Inteligente
            {
                if (tiro_inteligente.Count == 2)
                {
                    tiro_inteligente.RemoveAt(0);
                }
                if (tiro_inteligente.Count == 1)
                {
                    if (tiro_inteligenteint == 3)
                    {
                        if (tiro_inteligente[0] < 100)
                        {
                            if (buttonArray[tiro_inteligente[0] + 1].BackColor == Color.Transparent || buttonArray[tiro_inteligente[0] + 1].BackColor == Color.Red)
                            {
                                tiro_inteligenteint = 3;
                                num = tiro_inteligente[0] + 1;
                            }
                        }
                        else
                        {
                            tiro_inteligenteint = 3;
                        }
                    }
                    if (tiro_inteligenteint == 2)
                    {
                        if (tiro_inteligente[0] <= 90)
                        {
                            if (buttonArray[tiro_inteligente[0] + 10].BackColor == Color.Transparent || buttonArray[tiro_inteligente[0] + 10].BackColor == Color.Red)
                            {
                                num = tiro_inteligente[0] + 10;
                                tiro_inteligente.Clear();
                            }
                            else
                            {
                                tiro_inteligente.Clear();
                            }
                        }
                    }

                    if (tiro_inteligenteint == 1)
                    {

                        if (tiro_inteligente[0] >= 10)
                        {
                            if (buttonArray[tiro_inteligente[0] - 10].BackColor == Color.Transparent || buttonArray[tiro_inteligente[0] - 10].BackColor == Color.Red)
                            {
                                tiro_inteligenteint = 2;
                                num = tiro_inteligente[0] - 10;

                            }
                        }
                        else
                        {
                            tiro_inteligenteint = 2;
                        }

                    }

                    if (tiro_inteligenteint == 0)
                    {

                        if (tiro_inteligente[0] >= 1)
                        {

                            if (buttonArray[tiro_inteligente[0] - 1].BackColor == Color.Transparent || buttonArray[tiro_inteligente[0] - 1].BackColor == Color.Red)
                            {
                                tiro_inteligenteint = 1;
                                num = tiro_inteligente[0] - 1;
                            }
                        }
                        else
                        {
                            tiro_inteligenteint = 1;
                        }

                    }
                }

                if (buttonArray[num].BackColor == Color.Red)
                {
                    tiro_inteligenteint = 0;
                    tiro_inteligente.Add(Convert.ToInt32(buttonArray[num].Text));

                    // MessageBox.Show(num.ToString());

                    buttonArray[num].BackColor = Color.Yellow;

                    vez = 0;
                    falta1 -= 1;
                    lfalta1.Text = "Falta : " + falta1.ToString();
                    if (falta1 == 0)
                    {
                        label2.Visible = true;
                        brestart.Visible = true;
                        trinca = 0;
                    }
                }


                if (buttonArray[num].BackColor == Color.Transparent)
                {
                    buttonArray[num].BackColor = Color.Blue;
                    if (dificuldadedifi == 0) {
                        vez = 0;
                    }
                    
                    
                }
                if (buttonArray[num].BackColor == Color.Blue)
                {
                    ba.PerformClick();
                }
                if (buttonArray[num].BackColor == Color.Yellow)
                {
                    ba.PerformClick();
                }
            }
        }

    }
        
    
  
}
