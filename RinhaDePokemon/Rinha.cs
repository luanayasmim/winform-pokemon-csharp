using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RinhaDePokemon;
using RinhaDePokemon.Properties;

namespace RinhaDePokemon
{
    public partial class Rinha : Form
    {
        List<Pokemon> listPokemon = new List<Pokemon>();
        public Rinha(List<Pokemon> list)
        {
            InitializeComponent();
            this.listPokemon = list;
        }

        private void Rinha_Load(object sender, EventArgs e)
        {
            labelName1.Text=listPokemon[0].GetName();
            labelCategory1.Text = listPokemon[0].GetCategory();
            labelWeakness1.Text = listPokemon[0].GetWeakness();
            labelWeight1.Text =Convert.ToString(listPokemon[0].GetWeight());
            labelHeight1.Text =Convert.ToString(listPokemon[0].GetHeight());
            labelName2.Text = listPokemon[1].GetName();
            labelCategory2.Text = listPokemon[1].GetCategory();
            labelWeakness2.Text = listPokemon[1].GetWeakness();
            labelWeight2.Text = Convert.ToString(listPokemon[1].GetWeight());
            labelHeight2.Text = Convert.ToString(listPokemon[1].GetHeight());
        }



        private void buttonResult_Click(object sender, EventArgs e)
        {
            //Categorias
            var categoria1 = listPokemon[0].GetCategory();
            var categoria2 = listPokemon[1].GetCategory();

            //Verificação do tipo Mato
            if (categoria1 == "Mato")
            {
                if(categoria2 == "Fogo")//Fraqueza
                {
                    MessageBox.Show($"O {listPokemon[1].GetName()} é o vencedor");

                }else if(categoria2== "Água")//Força
                {
                    MessageBox.Show($"O {listPokemon[0].GetName()} é o vencedor");
                }
                else
                {
                    MessageBox.Show($"Houve empate");
                }
            }else if (categoria2 == "Mato")
            {
                if (categoria1 == "Fogo")//Fraqueza
                {
                    MessageBox.Show($"O {listPokemon[0].GetName()} é o vencedor");

                }
                else if (categoria1 == "Água")//Força
                {
                    MessageBox.Show($"O {listPokemon[1].GetName()} é o vencedor");
                }
                else
                {
                    MessageBox.Show($"Houve empate");
                }
            }

            //Verificação do tipo Fogo
            else if (categoria1 == "Fogo")
            {
                if (categoria2 == "Água")//Fraqueza
                {
                    MessageBox.Show($"O {listPokemon[1].GetName()} é o vencedor");

                }
                else if (categoria2 == "Inseto")//Força
                {
                    MessageBox.Show($"O {listPokemon[0].GetName()} é o vencedor");
                }
                else
                {
                    MessageBox.Show($"Houve empate");
                }
            }
            else if (categoria2 == "Fogo")
            {
                if (categoria1 == "Água")//Fraqueza
                {
                    MessageBox.Show($"O {listPokemon[0].GetName()} é o vencedor");

                }
                else if (categoria1 == "Inseto")//Força
                {
                    MessageBox.Show($"O {listPokemon[1].GetName()} é o vencedor");
                }
                else
                {
                    MessageBox.Show($"Houve empate");
                }
            }

            //Verificação do tipo Água
            else if (categoria1 == "Água")
            {
                if (categoria2 == "Fogo")//Fraqueza
                {
                    MessageBox.Show($"O {listPokemon[1].GetName()} é o vencedor");

                }
                else if (categoria2 == "Mato")//Força
                {
                    MessageBox.Show($"O {listPokemon[0].GetName()} é o vencedor");
                }
                else
                {
                    MessageBox.Show($"Houve empate");
                }
            }
            else if (categoria2 == "Água")
            {
                if (categoria1 == "Mato")//Fraqueza
                {
                    MessageBox.Show($"O {listPokemon[0].GetName()} é o vencedor");

                }
                else if (categoria1 == "Fogo")//Força
                {
                    MessageBox.Show($"O {listPokemon[1].GetName()} é o vencedor");
                }
                else
                {
                    MessageBox.Show($"Houve empate");
                }
            }

            //Verificação do tipo Inseto
            else if (categoria1 == "Inseto")
            {
                if (categoria2 == "Fogo")//Fraqueza
                {
                    MessageBox.Show($"O {listPokemon[1].GetName()} é o vencedor");

                }else
                {
                    MessageBox.Show($"Houve empate");
                }
            }
            else if (categoria2 == "Inseto")
            {
                if (categoria1 == "Fogo")//Fraqueza
                {
                    MessageBox.Show($"O {listPokemon[0].GetName()} é o vencedor");

                }
                else
                {
                    MessageBox.Show($"Houve empate");
                }
            }

            //Verificação do tipo Voador
            else if (categoria1 == "Voador")
            {
                if (categoria2 == "Elétrico")//Fraqueza
                {
                    MessageBox.Show($"O {listPokemon[1].GetName()} é o vencedor");

                }
                else
                {
                    MessageBox.Show($"Houve empate");
                }
            }
            else if (categoria2 == "Voador")
            {
                if (categoria1 == "Elétrico")//Fraqueza
                {
                    MessageBox.Show($"O {listPokemon[0].GetName()} é o vencedor");

                }
                else
                {
                    MessageBox.Show($"Houve empate");
                }
            }

            //Verificação do tipo Normal
            else if (categoria1 == "Normal")
            {
                MessageBox.Show($"O {listPokemon[1].GetName()} é o vencedor");
            }
            else if (categoria2 == "Normal")
            {
                MessageBox.Show($"O {listPokemon[0].GetName()} é o vencedor");
            }

            //Verificação do tipo Venenoso
            else if (categoria1 == "Venenoso")
            {
                if (categoria2 == "Terra")//Fraqueza
                {
                    MessageBox.Show($"O {listPokemon[1].GetName()} é o vencedor");

                }else
                {
                    MessageBox.Show($"Houve empate");
                }
            }
            else if (categoria2 == "Venenoso")
            {
                if (categoria1 == "Terra")//Fraqueza
                {
                    MessageBox.Show($"O {listPokemon[0].GetName()} é o vencedor");

                }else
                {
                    MessageBox.Show($"Houve empate");
                }
            }

            //Verificação do tipo Elétrico
            else if (categoria1 == "Elétrico")
            {
                if (categoria2 == "Terra")//Fraqueza
                {
                    MessageBox.Show($"O {listPokemon[1].GetName()} é o vencedor");

                }
                else if (categoria2 == "Voador")//Força
                {
                    MessageBox.Show($"O {listPokemon[0].GetName()} é o vencedor");
                }
                else
                {
                    MessageBox.Show($"Houve empate");
                }
            }
            else if (categoria2 == "Elétrico")
            {
                if (categoria1 == "Terra")//Fraqueza
                {
                    MessageBox.Show($"O {listPokemon[0].GetName()} é o vencedor");

                }
                else if (categoria1 == "Voador")//Força
                {
                    MessageBox.Show($"O {listPokemon[1].GetName()} é o vencedor");
                }
                else
                {
                    MessageBox.Show($"Houve empate");
                }
            }

            //Verificação do tipo Terra
            else if (categoria1 == "Terra")
            {
                if (categoria2 == "Água")//Fraqueza
                {
                    MessageBox.Show($"O {listPokemon[1].GetName()} é o vencedor");

                }
                else if (categoria2 == "Elétrico" || categoria2=="Venenoso")//Força
                {
                    MessageBox.Show($"O {listPokemon[0].GetName()} é o vencedor");
                }
                else
                {
                    MessageBox.Show($"Houve empate");
                }
            }
            else if (categoria2 == "Terra")
            {
                if (categoria1 == "Água")//Fraqueza
                {
                    MessageBox.Show($"O {listPokemon[0].GetName()} é o vencedor");

                }
                else if (categoria1 == "Elétrico" || categoria1 == "Venenoso")//Força
                {
                    MessageBox.Show($"O {listPokemon[1].GetName()} é o vencedor");
                }
                else
                {
                    MessageBox.Show($"Houve empate");
                }
            }


            /*Mato - Fogo
              Fogo - Agua
              Agua - Mato
              Inseto - Fogo
              Voador - Eletrico
              Normal - Lutar
              Vanenoso - Terra
              eletrico - Terra
              Terra - Agua
             * 
             */
        }

    }
}
