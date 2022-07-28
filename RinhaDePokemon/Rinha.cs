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
            
            labelName1.Text=listPokemon[0].Name;
            labelCategory1.Text = listPokemon[0].Category;
            labelWeakness1.Text = listPokemon[0].Weakness;
            labelWeight1.Text =Convert.ToString(listPokemon[0].Weight);
            labelHeight1.Text =Convert.ToString(listPokemon[0].Height);
            labelName2.Text = listPokemon[1].Name;
            labelCategory2.Text = listPokemon[1].Category;
            labelWeakness2.Text = listPokemon[1].Weakness;
            labelWeight2.Text = Convert.ToString(listPokemon[1].Weight);
            labelHeight2.Text = Convert.ToString(listPokemon[1].Height);

            //Carregar Imagens
            //Bulbasaur
            if (listPokemon[0].Name == "Bulbasaur")
            {
                pictureBox1.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath
                                                       (System.Environment.SpecialFolder.MyPictures)
                                                        + @"\Bulbasaur.png");
            }
            else if (listPokemon[1].Name == "Bulbasaur")
            {
                pictureBox2.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath
                                                       (System.Environment.SpecialFolder.MyPictures)
                                                        + @"\Bulbasaur.png");
            }
            if (listPokemon[0].Name == "Charmander")
            {
                pictureBox1.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath
                                                       (System.Environment.SpecialFolder.MyPictures)
                                                        + @"\Charmander.png");
            }
            else if (listPokemon[1].Name == "Charmander")
            {
                pictureBox2.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath
                                                       (System.Environment.SpecialFolder.MyPictures)
                                                        + @"\Charmander.png");
            }
            if (listPokemon[0].Name == "Squirtle")
            {
                pictureBox1.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath
                                                       (System.Environment.SpecialFolder.MyPictures)
                                                        + @"\Squirtle.png");
            }
            else if (listPokemon[1].Name == "Squirtle")
            {
                pictureBox2.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath
                                                       (System.Environment.SpecialFolder.MyPictures)
                                                        + @"\Squirtle.png");
            }
            if (listPokemon[0].Name == "Caterpie")
            {
                pictureBox1.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath
                                                       (System.Environment.SpecialFolder.MyPictures)
                                                        + @"\Caterpie.png");
            }
            else if (listPokemon[1].Name == "Caterpie")
            {
                pictureBox2.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath
                                                       (System.Environment.SpecialFolder.MyPictures)
                                                        + @"\Caterpie.png");
            }
            if (listPokemon[0].Name == "Pidgey")
            {
                pictureBox1.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath
                                                       (System.Environment.SpecialFolder.MyPictures)
                                                        + @"\Pidgey.png");
            }
            else if (listPokemon[1].Name == "Pidgey")
            {
                pictureBox2.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath
                                                       (System.Environment.SpecialFolder.MyPictures)
                                                        + @"\Pidgey.png");
            }
            if (listPokemon[0].Name == "Rattata")
            {
                pictureBox1.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath
                                                       (System.Environment.SpecialFolder.MyPictures)
                                                        + @"\Rattata.png");
            }
            else if (listPokemon[1].Name == "Rattata")
            {
                pictureBox2.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath
                                                       (System.Environment.SpecialFolder.MyPictures)
                                                        + @"\Rattata.png");
            }
            if (listPokemon[0].Name == "Ekans")
            {
                pictureBox1.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath
                                                       (System.Environment.SpecialFolder.MyPictures)
                                                        + @"\Ekans.png");
            }
            else if (listPokemon[1].Name == "Ekans")
            {
                pictureBox2.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath
                                                       (System.Environment.SpecialFolder.MyPictures)
                                                        + @"\Ekans.png");
            }
            if (listPokemon[0].Name == "Pikachu")
            {
                pictureBox1.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath
                                                       (System.Environment.SpecialFolder.MyPictures)
                                                        + @"\Pikachu.png");
            }
            else if (listPokemon[1].Name == "Pikachu")
            {
                pictureBox2.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath
                                                       (System.Environment.SpecialFolder.MyPictures)
                                                        + @"\Pikachu.png");
            }
            if (listPokemon[0].Name == "Sandshrew")
            {
                pictureBox1.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath
                                                       (System.Environment.SpecialFolder.MyPictures)
                                                        + @"\Sandshrew.png");
            }
            else if (listPokemon[1].Name == "Sandshrew")
            {
                pictureBox2.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath
                                                       (System.Environment.SpecialFolder.MyPictures)
                                                        + @"\Sandshrew.png");
            }

        }



        private void buttonResult_Click(object sender, EventArgs e)
        {
            //Categorias
            var categoria1 = listPokemon[0].Category;
            var categoria2 = listPokemon[1].Category;

            //Verificação do tipo Normal
            if (categoria1 == "Normal")
            {
                MessageBox.Show($"O {listPokemon[1].Name} é o vencedor");
            }
            else if (categoria2 == "Normal")
            {
                MessageBox.Show($"O {listPokemon[0].Name} é o vencedor");
            }

            //Verificação do tipo Mato
            else if (categoria1 == "Mato")
            {
                if(categoria2 == "Fogo")//Fraqueza
                {
                    MessageBox.Show($"O {listPokemon[1].Name} é o vencedor");

                }else if(categoria2== "Água")//Força
                {
                    MessageBox.Show($"O {listPokemon[0].Name} é o vencedor");
                }
                else
                {
                    MessageBox.Show($"Houve empate");
                }
            }else if (categoria2 == "Mato")
            {
                if (categoria1 == "Fogo")//Fraqueza
                {
                    MessageBox.Show($"O {listPokemon[0].Name} é o vencedor");

                }
                else if (categoria1 == "Água")//Força
                {
                    MessageBox.Show($"O {listPokemon[1].Name} é o vencedor");
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
                    MessageBox.Show($"O {listPokemon[1].Name} é o vencedor");

                }
                else if (categoria2 == "Inseto")//Força
                {
                    MessageBox.Show($"O {listPokemon[0].Name} é o vencedor");
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
                    MessageBox.Show($"O {listPokemon[0].Name} é o vencedor");

                }
                else if (categoria1 == "Inseto")//Força
                {
                    MessageBox.Show($"O {listPokemon[1].Name} é o vencedor");
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
                    MessageBox.Show($"O {listPokemon[1].Name} é o vencedor");

                }
                else if (categoria2 == "Mato")//Força
                {
                    MessageBox.Show($"O {listPokemon[0].Name} é o vencedor");
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
                    MessageBox.Show($"O {listPokemon[0].Name} é o vencedor");

                }
                else if (categoria1 == "Fogo")//Força
                {
                    MessageBox.Show($"O {listPokemon[1].Name} é o vencedor");
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
                    MessageBox.Show($"O {listPokemon[1].Name} é o vencedor");

                }else
                {
                    MessageBox.Show($"Houve empate");
                }
            }
            else if (categoria2 == "Inseto")
            {
                if (categoria1 == "Fogo")//Fraqueza
                {
                    MessageBox.Show($"O {listPokemon[0].Name} é o vencedor");

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
                    MessageBox.Show($"O {listPokemon[1].Name} é o vencedor");

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
                    MessageBox.Show($"O {listPokemon[0].Name} é o vencedor");

                }
                else
                {
                    MessageBox.Show($"Houve empate");
                }
            }

            

            //Verificação do tipo Venenoso
            else if (categoria1 == "Venenoso")
            {
                if (categoria2 == "Terra")//Fraqueza
                {
                    MessageBox.Show($"O {listPokemon[1].Name} é o vencedor");

                }else
                {
                    MessageBox.Show($"Houve empate");
                }
            }
            else if (categoria2 == "Venenoso")
            {
                if (categoria1 == "Terra")//Fraqueza
                {
                    MessageBox.Show($"O {listPokemon[0].Name} é o vencedor");

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
                    MessageBox.Show($"O {listPokemon[1].Name} é o vencedor");

                }
                else if (categoria2 == "Voador")//Força
                {
                    MessageBox.Show($"O {listPokemon[0].Name} é o vencedor");
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
                    MessageBox.Show($"O {listPokemon[0].Name} é o vencedor");

                }
                else if (categoria1 == "Voador")//Força
                {
                    MessageBox.Show($"O {listPokemon[1].Name} é o vencedor");
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
                    MessageBox.Show($"O {listPokemon[1].Name} é o vencedor");

                }
                else if (categoria2 == "Elétrico" || categoria2=="Venenoso")//Força
                {
                    MessageBox.Show($"O {listPokemon[0].Name} é o vencedor");
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
                    MessageBox.Show($"O {listPokemon[0].Name} é o vencedor");

                }
                else if (categoria1 == "Elétrico" || categoria1 == "Venenoso")//Força
                {
                    MessageBox.Show($"O {listPokemon[1].Name} é o vencedor");
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
