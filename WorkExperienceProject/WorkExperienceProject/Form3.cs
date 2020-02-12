using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl;
using Flurl.Http;
using Newtonsoft.Json;
using System.Diagnostics;

namespace WorkExperienceProject
{
    public partial class Form3 : Form
    {
        public string SearchURL = "";
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 temp1 = new Form1();
            temp1.Region = this.Region;
            temp1.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public async Task<Rootobject> testget2(string classA)
        {
            try
            {
                var getClassesObject = await $"http://dnd5eapi.co/api/classes/{classA}".GetAsync();
                var jsonOfClases = JsonConvert.DeserializeObject<Rootobject>(getClassesObject.Content.ReadAsStringAsync().Result);

                return jsonOfClases;
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                return null;
            }

        }

        private void Barbarian_Click(object sender, EventArgs e)
        {
            string Barbarian = "Barbarian";
            string BarbarianHP = @"Hit Points
Hit Dice: 1d12 per Barbarian level
Hit Points at 1st Level: 12 + your Constitution modifier
Hit Points at Higher Levels: 1d12(or 7) + your Constitution modifier per Barbarian level after 1st";

            string BarbarianProficiencies = @"Proficiencies
Armor: Light Armor, Medium Armor, Shields Weapons: Simple Weapons, Martial Weapons Tools: None
Saving Throws: Strength, Constitution
Skills: Choose two from Animal Handling, Athletics, Intimidation, Nature, Perception, and Survival";

            string BarbarianEquipment = @"Equipment
You start with the following Equipment, in addition to the Equipment granted by your background:
(a) a Greataxe or (b) any martial melee weapon
(a) two handaxes or (b) any simple weapon
An explorer’s pack and four javelins.";




            NameTag.Text = Barbarian;
            HitPoints.Text = BarbarianHP;
            Proficencies.Text = BarbarianProficiencies;
            Equipment.Text = BarbarianEquipment;
        }

        private void Bard_Click(object sender, EventArgs e)
        {

        }

        private void Cleric_Click(object sender, EventArgs e)
        {

        }

        private void Druid_Click(object sender, EventArgs e)
        {

        }

        private void Fighter_Click(object sender, EventArgs e)
        {

        }

        private void Monk_Click(object sender, EventArgs e)
        {

        }

        private void Paladin_Click(object sender, EventArgs e)
        {

        }

        private void Ranger_Click(object sender, EventArgs e)
        {

        }

        private void Rogue_Click(object sender, EventArgs e)
        {

        }

        private void Sorcerer_Click(object sender, EventArgs e)
        {

        }

        private void Warlock_Click(object sender, EventArgs e)
        {

        }

        private void Wizard_Click(object sender, EventArgs e)
        {

        }

        private async void Levels_Click(object sender, EventArgs e)
        {
            var barb = await testget2("cleric");

            string ProfNames = string.Empty;

            for (int i = 0; i < barb.proficiency_choices.Length; i++)
            {
                for (int j = 0; j < barb.proficiency_choices[i].from.Length; j++)
                {
                    ProfNames += barb.proficiency_choices[i].from[j].name;
                    ProfNames += Environment.NewLine;
                }
            }
            MessageBox.Show(ProfNames + "test");

        }
        static void SearchGOOGLE(string term)
        {
            Process.Start("https://www.google.com/search?q=" + term);
        }
        static void SearchDND(string term)
        {
            Process.Start("https://www.dndbeyond.com/search?q=" + term);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string UserInput = textBox1.Text;
           
        }

        private void GOOGLE_Click(object sender, EventArgs e)
        {
            SearchGOOGLE("test");
        }

        private void DND_Click(object sender, EventArgs e)
        {
            SearchDND("test");
        }
    }
}

