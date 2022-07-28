using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RinhaDePokemon.Properties;

namespace RinhaDePokemon
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public List<Pokemon> ListPokemons = new List<Pokemon>();
        //Pokemons
            /*List<Pokemon> ListPokemon = new List<Pokemon> {
                    new Pokemon("Bulbasaur", "Mato", "Fogo", 0.7, 6.9),
                    new Pokemon("Charmander", "Fogo", "Água", 0.6, 8.5),
                    new Pokemon("Squirtle", "Água", "Mato", 0.5, 9.0),
                    new Pokemon("Caterpie", "Inseto", "Fogo", 0.3, 2.9),
                    new Pokemon("Pidgey", "Voador", "Elétrico", 0.3, 1.8),
                    new Pokemon("Rattata", "Normal", "Lutar", 0.3, 3.5),
                    new Pokemon("Ekans", "Venenoso", "Terra", 2, 6.9),
                    new Pokemon("Pikachu", "Elétrico", "Terra", 0.4, 6.0),
                    new Pokemon("Sandshrew", "Terra", "Água", 0.6, 12.0)
            };

        Pokemon SearchPokemon(Pokemon pokemon)
        {

            for (int i = 0; i < ListPokemon.Count; i++)
            {
                if (ListPokemon[i] == pokemon)
                {
                    return ListPokemon[i];
                }
                else
                {
                    return new Pokemon(" ", " ", " ", 0, 0);
                }
            }
        }*/

        private void buttonBulbasaur_Click(object sender, EventArgs e)
        {
            Pokemon bulbasaur = new Pokemon("Bulbasaur", "Mato", "Fogo", 0.7, 6.9 /*"\Bulbasaur.png"*/) ;
            //Pokemon pokemon = SearchPokemon(bulbasaur);
            label_setName.Text = bulbasaur.Name;
            label_setHeight.Text =Convert.ToString(bulbasaur.Height);
            label_setWeight.Text = Convert.ToString(bulbasaur.Weight);
            label_setCategory.Text = bulbasaur.Category;
            label_setWeakness.Text = bulbasaur.Weakness;
            //pictureBox_setPokemon.BackgroundImage = bulbasaur.GetImage();
            pictureBox_setPokemon.BackgroundImage= Image.FromFile(System.Environment.GetFolderPath
                                                       (System.Environment.SpecialFolder.MyPictures)
                                                        + @"\Bulbasaur.png");
            
        }

        private void buttonCharmander_Click(object sender, EventArgs e)
        {
            Pokemon charmander = new Pokemon("Charmander", "Fogo", "Água", 0.6, 8.5);
            //Pokemon pokemon = SearchPokemon(charmander);
            label_setName.Text = charmander.Name;
            label_setHeight.Text = Convert.ToString(charmander.Height);
            label_setWeight.Text = Convert.ToString(charmander.Weight);
            label_setCategory.Text = charmander.Category;
            label_setWeakness.Text = charmander.Weakness;

            pictureBox_setPokemon.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath
                                                       (System.Environment.SpecialFolder.MyPictures)
                                                        + @"\Charmander.png");
        }

        private void buttonSquirtle_Click(object sender, EventArgs e)
        {
            Pokemon squirtle = new Pokemon("Squirtle", "Água", "Mato", 0.5, 9.0);
            
            label_setName.Text = squirtle.Name;
            label_setHeight.Text = Convert.ToString(squirtle.Height);
            label_setWeight.Text = Convert.ToString(squirtle.Weight);
            label_setCategory.Text = squirtle.Category;
            label_setWeakness.Text = squirtle.Weakness;

            pictureBox_setPokemon.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath
                                                       (System.Environment.SpecialFolder.MyPictures)
                                                        + @"\Squirtle.png");
        }

        private void buttonCaterpie_Click(object sender, EventArgs e)
        {
            Pokemon cartepie = new Pokemon("Caterpie", "Inseto", "Fogo", 0.3, 2.9);
            //Pokemon pokemon = SearchPokemon(cartepie);
            label_setName.Text = cartepie.Name;
            label_setHeight.Text = Convert.ToString(cartepie.Height);
            label_setWeight.Text = Convert.ToString(cartepie.Weight);
            label_setCategory.Text = cartepie.Category;
            label_setWeakness.Text = cartepie.Weakness;

            pictureBox_setPokemon.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath
                                                        (System.Environment.SpecialFolder.MyPictures)
                                                        + @"\Caterpie.png");
        }

        private void buttonPidgey_Click(object sender, EventArgs e)
        {
            Pokemon pidgey = new Pokemon("Pidgey", "Voador", "Elétrico", 0.3, 1.8);
            //Pokemon pokemon = SearchPokemon(pidgey);
            label_setName.Text = pidgey.Name;
            label_setHeight.Text = Convert.ToString(pidgey.Height);
            label_setWeight.Text = Convert.ToString(pidgey.Weight);
            label_setCategory.Text = pidgey.Category;
            label_setWeakness.Text = pidgey.Weakness;

            pictureBox_setPokemon.BackgroundImage =Image.FromFile(System.Environment.GetFolderPath
                                                      (System.Environment.SpecialFolder.MyPictures)
                                                      + @"\Pidgey.png");
        }

        private void buttonRattata_Click(object sender, EventArgs e)
        {
            Pokemon rattata = new Pokemon("Rattata", "Normal", "Lutar", 0.3, 3.5);
            //Pokemon pokemon = SearchPokemon(rattata);
            label_setName.Text = rattata.Name;
            label_setHeight.Text = Convert.ToString(rattata.Height);
            label_setWeight.Text = Convert.ToString(rattata.Weight);
            label_setCategory.Text = rattata.Category;
            label_setWeakness.Text = rattata.Weakness;

            pictureBox_setPokemon.BackgroundImage =Image.FromFile(System.Environment.GetFolderPath
                                                      (System.Environment.SpecialFolder.MyPictures)
                                                      + @"\Rattata.png");
        }

        private void buttonEkans_Click(object sender, EventArgs e)
        {
            Pokemon ekans = new Pokemon("Ekans", "Venenoso", "Terra", 2, 6.9);
            //Pokemon pokemon = SearchPokemon(ekans);
            label_setName.Text = ekans.Name;
            label_setHeight.Text = Convert.ToString(ekans.Height);
            label_setWeight.Text = Convert.ToString(ekans.Weight);
            label_setCategory.Text = ekans.Category;
            label_setWeakness.Text = ekans.Weakness;

            pictureBox_setPokemon.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath
                                                        (System.Environment.SpecialFolder.MyPictures)
                                                        + @"\Ekans.png");
        }

        private void buttonPikachu_Click(object sender, EventArgs e)
        {
            Pokemon pikachu = new Pokemon("Pikachu", "Elétrico", "Terra", 0.4, 6.0);
            //Pokemon pokemon = SearchPokemon(pikachu);
            label_setName.Text = pikachu.Name;
            label_setHeight.Text = Convert.ToString(pikachu.Height);
            label_setWeight.Text = Convert.ToString(pikachu.Weight);
            label_setCategory.Text = pikachu.Category;
            label_setWeakness.Text = pikachu.Weakness;

            pictureBox_setPokemon.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath
                                                        (System.Environment.SpecialFolder.MyPictures)
                                                        + @"\Pikachu.png");
        }

        private void buttonSandshrew_Click(object sender, EventArgs e)
        {
            Pokemon sandshrew = new Pokemon("Sandshrew", "Terra", "Água", 0.6, 12.0);
            //Pokemon pokemon = SearchPokemon(sandshrew);
            label_setName.Text = sandshrew.Name;
            label_setHeight.Text = Convert.ToString(sandshrew.Height);
            label_setWeight.Text = Convert.ToString(sandshrew.Weight);
            label_setCategory.Text = sandshrew.Category;
            label_setWeakness.Text = sandshrew.Weakness;

            pictureBox_setPokemon.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath
                                                        (System.Environment.SpecialFolder.MyPictures)
                                                        + @"\Sandshrew.png");
        }

        private void button_choicePokemon_Click(object sender, EventArgs e)
        {
            Pokemon pokemon = new Pokemon(label_setName.Text,
                                          label_setCategory.Text,
                                          label_setWeakness.Text,
                                          double.Parse(label_setHeight.Text),
                                          double.Parse(label_setWeight.Text));
            ListPokemons.Add(pokemon);


        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            var Rinha = new Rinha(ListPokemons);
            var result = Rinha.ShowDialog();

         

            this.Close();
        }
    }
}
