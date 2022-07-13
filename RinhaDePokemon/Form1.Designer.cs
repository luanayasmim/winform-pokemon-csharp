
namespace RinhaDePokemon
{
    public partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.title1 = new System.Windows.Forms.Label();
            this.buttonBulbasaur = new System.Windows.Forms.Button();
            this.buttonCharmander = new System.Windows.Forms.Button();
            this.buttonSquirtle = new System.Windows.Forms.Button();
            this.buttonCaterpie = new System.Windows.Forms.Button();
            this.buttonPidgey = new System.Windows.Forms.Button();
            this.buttonRattata = new System.Windows.Forms.Button();
            this.buttonEkans = new System.Windows.Forms.Button();
            this.buttonPikachu = new System.Windows.Forms.Button();
            this.buttonSandshrew = new System.Windows.Forms.Button();
            this.button_choicePokemon = new System.Windows.Forms.Button();
            this.pictureBox_setPokemon = new System.Windows.Forms.PictureBox();
            this.label_setName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_setHeight = new System.Windows.Forms.Label();
            this.label_setWeight = new System.Windows.Forms.Label();
            this.label_setCategory = new System.Windows.Forms.Label();
            this.label_setWeakness = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_setPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // title1
            // 
            this.title1.AutoSize = true;
            this.title1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title1.Location = new System.Drawing.Point(91, 38);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(269, 37);
            this.title1.TabIndex = 0;
            this.title1.Text = "Escolha um Pokémon";
            // 
            // buttonBulbasaur
            // 
            this.buttonBulbasaur.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBulbasaur.BackgroundImage")));
            this.buttonBulbasaur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBulbasaur.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBulbasaur.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonBulbasaur.Location = new System.Drawing.Point(54, 106);
            this.buttonBulbasaur.Name = "buttonBulbasaur";
            this.buttonBulbasaur.Size = new System.Drawing.Size(99, 90);
            this.buttonBulbasaur.TabIndex = 1;
            this.buttonBulbasaur.Text = "Bulbasaur";
            this.buttonBulbasaur.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonBulbasaur.UseVisualStyleBackColor = true;
            this.buttonBulbasaur.Click += new System.EventHandler(this.buttonBulbasaur_Click);
            // 
            // buttonCharmander
            // 
            this.buttonCharmander.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCharmander.BackgroundImage")));
            this.buttonCharmander.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCharmander.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCharmander.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonCharmander.Location = new System.Drawing.Point(182, 109);
            this.buttonCharmander.Name = "buttonCharmander";
            this.buttonCharmander.Size = new System.Drawing.Size(99, 87);
            this.buttonCharmander.TabIndex = 2;
            this.buttonCharmander.Text = "Charmander";
            this.buttonCharmander.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCharmander.UseVisualStyleBackColor = true;
            this.buttonCharmander.Click += new System.EventHandler(this.buttonCharmander_Click);
            // 
            // buttonSquirtle
            // 
            this.buttonSquirtle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSquirtle.BackgroundImage")));
            this.buttonSquirtle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSquirtle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSquirtle.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonSquirtle.Location = new System.Drawing.Point(319, 109);
            this.buttonSquirtle.Name = "buttonSquirtle";
            this.buttonSquirtle.Size = new System.Drawing.Size(99, 87);
            this.buttonSquirtle.TabIndex = 3;
            this.buttonSquirtle.Tag = "";
            this.buttonSquirtle.Text = "Squirtle";
            this.buttonSquirtle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSquirtle.UseVisualStyleBackColor = true;
            this.buttonSquirtle.Click += new System.EventHandler(this.buttonSquirtle_Click);
            // 
            // buttonCaterpie
            // 
            this.buttonCaterpie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCaterpie.BackgroundImage")));
            this.buttonCaterpie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCaterpie.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCaterpie.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonCaterpie.Location = new System.Drawing.Point(54, 220);
            this.buttonCaterpie.Name = "buttonCaterpie";
            this.buttonCaterpie.Size = new System.Drawing.Size(99, 87);
            this.buttonCaterpie.TabIndex = 4;
            this.buttonCaterpie.Text = "Caterpie";
            this.buttonCaterpie.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCaterpie.UseVisualStyleBackColor = true;
            this.buttonCaterpie.Click += new System.EventHandler(this.buttonCaterpie_Click);
            // 
            // buttonPidgey
            // 
            this.buttonPidgey.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPidgey.BackgroundImage")));
            this.buttonPidgey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPidgey.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPidgey.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonPidgey.Location = new System.Drawing.Point(182, 220);
            this.buttonPidgey.Name = "buttonPidgey";
            this.buttonPidgey.Size = new System.Drawing.Size(99, 87);
            this.buttonPidgey.TabIndex = 5;
            this.buttonPidgey.Text = "Pidgey";
            this.buttonPidgey.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPidgey.UseVisualStyleBackColor = true;
            this.buttonPidgey.Click += new System.EventHandler(this.buttonPidgey_Click);
            // 
            // buttonRattata
            // 
            this.buttonRattata.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRattata.BackgroundImage")));
            this.buttonRattata.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRattata.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRattata.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonRattata.Location = new System.Drawing.Point(319, 220);
            this.buttonRattata.Name = "buttonRattata";
            this.buttonRattata.Size = new System.Drawing.Size(99, 87);
            this.buttonRattata.TabIndex = 6;
            this.buttonRattata.Text = "Rattata";
            this.buttonRattata.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonRattata.UseVisualStyleBackColor = true;
            this.buttonRattata.Click += new System.EventHandler(this.buttonRattata_Click);
            // 
            // buttonEkans
            // 
            this.buttonEkans.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEkans.BackgroundImage")));
            this.buttonEkans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEkans.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEkans.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonEkans.Location = new System.Drawing.Point(54, 338);
            this.buttonEkans.Name = "buttonEkans";
            this.buttonEkans.Size = new System.Drawing.Size(99, 87);
            this.buttonEkans.TabIndex = 7;
            this.buttonEkans.Text = "Ekans";
            this.buttonEkans.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEkans.UseVisualStyleBackColor = true;
            this.buttonEkans.Click += new System.EventHandler(this.buttonEkans_Click);
            // 
            // buttonPikachu
            // 
            this.buttonPikachu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPikachu.BackgroundImage")));
            this.buttonPikachu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPikachu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPikachu.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonPikachu.Location = new System.Drawing.Point(182, 338);
            this.buttonPikachu.Name = "buttonPikachu";
            this.buttonPikachu.Size = new System.Drawing.Size(99, 87);
            this.buttonPikachu.TabIndex = 8;
            this.buttonPikachu.Text = "Pikachu";
            this.buttonPikachu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPikachu.UseVisualStyleBackColor = true;
            this.buttonPikachu.Click += new System.EventHandler(this.buttonPikachu_Click);
            // 
            // buttonSandshrew
            // 
            this.buttonSandshrew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSandshrew.BackgroundImage")));
            this.buttonSandshrew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSandshrew.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSandshrew.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonSandshrew.Location = new System.Drawing.Point(319, 338);
            this.buttonSandshrew.Name = "buttonSandshrew";
            this.buttonSandshrew.Size = new System.Drawing.Size(99, 87);
            this.buttonSandshrew.TabIndex = 9;
            this.buttonSandshrew.Text = "Sandshrew";
            this.buttonSandshrew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSandshrew.UseVisualStyleBackColor = true;
            this.buttonSandshrew.Click += new System.EventHandler(this.buttonSandshrew_Click);
            // 
            // button_choicePokemon
            // 
            this.button_choicePokemon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_choicePokemon.Location = new System.Drawing.Point(586, 447);
            this.button_choicePokemon.Name = "button_choicePokemon";
            this.button_choicePokemon.Size = new System.Drawing.Size(269, 23);
            this.button_choicePokemon.TabIndex = 10;
            this.button_choicePokemon.Text = "Eu escolho você";
            this.button_choicePokemon.UseVisualStyleBackColor = true;
            this.button_choicePokemon.Click += new System.EventHandler(this.button_choicePokemon_Click);
            // 
            // pictureBox_setPokemon
            // 
            this.pictureBox_setPokemon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_setPokemon.Location = new System.Drawing.Point(586, 74);
            this.pictureBox_setPokemon.Name = "pictureBox_setPokemon";
            this.pictureBox_setPokemon.Size = new System.Drawing.Size(269, 218);
            this.pictureBox_setPokemon.TabIndex = 11;
            this.pictureBox_setPokemon.TabStop = false;
            // 
            // label_setName
            // 
            this.label_setName.AutoSize = true;
            this.label_setName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_setName.Location = new System.Drawing.Point(657, 52);
            this.label_setName.Name = "label_setName";
            this.label_setName.Size = new System.Drawing.Size(140, 19);
            this.label_setName.TabIndex = 12;
            this.label_setName.Text = "Nome do Pokémon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(583, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Altura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(583, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Peso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(737, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Categoria";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(724, 367);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Fraqueza";
            // 
            // label_setHeight
            // 
            this.label_setHeight.AutoSize = true;
            this.label_setHeight.Location = new System.Drawing.Point(594, 335);
            this.label_setHeight.Name = "label_setHeight";
            this.label_setHeight.Size = new System.Drawing.Size(10, 15);
            this.label_setHeight.TabIndex = 20;
            this.label_setHeight.Text = " ";
            // 
            // label_setWeight
            // 
            this.label_setWeight.AutoSize = true;
            this.label_setWeight.Location = new System.Drawing.Point(594, 382);
            this.label_setWeight.Name = "label_setWeight";
            this.label_setWeight.Size = new System.Drawing.Size(10, 15);
            this.label_setWeight.TabIndex = 21;
            this.label_setWeight.Text = " ";
            // 
            // label_setCategory
            // 
            this.label_setCategory.AutoSize = true;
            this.label_setCategory.Location = new System.Drawing.Point(752, 335);
            this.label_setCategory.Name = "label_setCategory";
            this.label_setCategory.Size = new System.Drawing.Size(10, 15);
            this.label_setCategory.TabIndex = 23;
            this.label_setCategory.Text = " ";
            // 
            // label_setWeakness
            // 
            this.label_setWeakness.AutoSize = true;
            this.label_setWeakness.Location = new System.Drawing.Point(757, 382);
            this.label_setWeakness.Name = "label_setWeakness";
            this.label_setWeakness.Size = new System.Drawing.Size(10, 15);
            this.label_setWeakness.TabIndex = 26;
            this.label_setWeakness.Text = " ";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(687, 491);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 27;
            this.buttonStart.Text = "Pronto";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 540);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label_setWeakness);
            this.Controls.Add(this.label_setCategory);
            this.Controls.Add(this.label_setWeight);
            this.Controls.Add(this.label_setHeight);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_setName);
            this.Controls.Add(this.pictureBox_setPokemon);
            this.Controls.Add(this.button_choicePokemon);
            this.Controls.Add(this.buttonSandshrew);
            this.Controls.Add(this.buttonPikachu);
            this.Controls.Add(this.buttonEkans);
            this.Controls.Add(this.buttonRattata);
            this.Controls.Add(this.buttonPidgey);
            this.Controls.Add(this.buttonCaterpie);
            this.Controls.Add(this.buttonSquirtle);
            this.Controls.Add(this.buttonCharmander);
            this.Controls.Add(this.buttonBulbasaur);
            this.Controls.Add(this.title1);
            this.Name = "FormMain";
            this.Text = "Rinha de Pokémon";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_setPokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title1;
        private System.Windows.Forms.Button buttonBulbasaur;
        private System.Windows.Forms.Button buttonCharmander;
        private System.Windows.Forms.Button buttonSquirtle;
        private System.Windows.Forms.Button buttonCaterpie;
        private System.Windows.Forms.Button buttonPidgey;
        private System.Windows.Forms.Button buttonRattata;
        private System.Windows.Forms.Button buttonEkans;
        private System.Windows.Forms.Button buttonPikachu;
        private System.Windows.Forms.Button buttonSandshrew;
        private System.Windows.Forms.Button button_choicePokemon;
        private System.Windows.Forms.PictureBox pictureBox_setPokemon;
        public System.Windows.Forms.Label label_setName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label_setHeight;
        public System.Windows.Forms.Label label_setWeight;
        public System.Windows.Forms.Label label_setCategory;
        public System.Windows.Forms.Label label_setWeakness;
        private System.Windows.Forms.Button buttonStart;
    }
}

