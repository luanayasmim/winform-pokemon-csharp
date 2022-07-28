﻿using System;
using System.Collections.Generic;
using System.Text;
using RinhaDePokemon;
using System.Windows.Forms;
using System.Drawing;

namespace RinhaDePokemon.Properties
{
    public class Pokemon
    {
        //Atributos
       // private string name, category, weakness, imagem;
        //private double height, weight;
        //private Image image = Image.FromFile("");
        public string Name { get; set; }
        public string Category { get; set; }
        public string Weakness { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        public string Imagem { get; set; }

        //Métodos Especiais
        //Construtor
        public Pokemon(string p_name,
                       string p_category,
                       string p_weakness,
                       double p_height,
                       double p_weight
                       //string p_imagem
                       
                      )
        {
            Name = p_name;
            Category = p_category;
            Weakness = p_weakness;
            Height = p_height;
            Weight = p_weight;
            //Imagem = p_imagem;
            /*SetName(p_name);
            SetCategory(p_category);
            SetWeakness(p_weakness);
            SetHeight(p_height);
            SetWeight(p_weight);
            SetImage(p_image);*/
        }

        /*Name
        public string GetName(){return this.name;}
        public void SetName(string p_name){this.name = p_name;}
        Category
        public string GetCategory(){return this.category;}
        public void SetCategory(string p_category){this.category = p_category;}
        //Weakness
        public string GetWeakness() { return this.weakness; }
        public void SetWeakness(string p_weakness) { this.weakness = p_weakness; }
        //Height
        public double GetHeight() { return this.height; }
        public void SetHeight(double p_height) { this.height = p_height; }
        //Weigth
        public double GetWeight() { return this.weight; }
        public void SetWeight(double p_weight) { this.weight = p_weight; }
        //Image
        //public Image GetImage() { return this.image; }
        //public void SetImage(Image p_image) { this.image = p_image; }*/

    }
}
