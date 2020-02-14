using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Flurl;
using Flurl.Http;
using Newtonsoft.Json;






namespace WorkExperienceProject
{
    public partial class Form4 : Form
    {
        public Form4()
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
        public void TestGetRequest_Click(object sender, EventArgs e)
        {
           testget(string.Empty);
        }
        public async Task<string> testget(string classA)
        {
            try
            {
                var getRacesObject = await $"http://dnd5eapi.co/api/races/{classA}".GetAsync();
                var jsonOfRaces = JsonConvert.DeserializeObject<ListRaces>(getRacesObject.Content.ReadAsStringAsync().Result);

                return "";
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                return "";
            }

        }
        public async Task<RacesINFO> TestGetRequest2(string classA)
        {
            try
            {
                var getRacesObject = await $"http://dnd5eapi.co/api/races/{classA}".GetAsync();
                var jsonOfRaces = JsonConvert.DeserializeObject<RacesINFO>(getRacesObject.Content.ReadAsStringAsync().Result);

                return jsonOfRaces;
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                return null;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DragonBorn_Click(object sender, EventArgs e)
        {
            if (Lingo.Checked)
            {
                Lang("dragonborn");
            }
            if (Size.Checked)
            {
                SizeDesc("dragonborn");
            }
            if (alignment.Checked)
            {
                Aligment("dragonborn");
            }
            Namess("Dragonborn");
        }

        private void Dwarf_Click(object sender, EventArgs e)
        {
            if (Lingo.Checked)
            {
                Lang("dwarf");
            }
            if (Size.Checked)
            {
                SizeDesc("dwarf");
            }
            if (alignment.Checked)
            {
                Aligment("dwarf");
            }
            Namess("Dwarf");
        }

        private void Elf_Click(object sender, EventArgs e)
        {
            if (Lingo.Checked)
            {
                Lang("elf");
            }
            if (Size.Checked)
            {
                SizeDesc("elf");
            }
            if (alignment.Checked)
            {
                Aligment("elf");
            }
            Namess("Elf");
        }

        private void Gnome_Click(object sender, EventArgs e)
        {
            if (Lingo.Checked)
            {
                Lang("gnome");
            }
            if (Size.Checked)
            {
                SizeDesc("gnome");
            }
            if (alignment.Checked)
            {
                Aligment("gnome");
            }
            Namess("Gnome");
        }

        private void HalfElf_Click(object sender, EventArgs e)
        {
            if (Lingo.Checked)
            {
                Lang("half-elf");
            }
            if (Size.Checked)
            {
                SizeDesc("half-elf");
            }
            if (alignment.Checked)
            {
                Aligment("half-elf");
            }
            Namess("Half-Elf");
        }

        private void HalfOrc_Click(object sender, EventArgs e)
        {
            if (Lingo.Checked)
            {
                Lang("half-orc");
            }
            if (Size.Checked)
            {
                SizeDesc("half-orc");
            }
            if (alignment.Checked)
            {
                Aligment("half-orc");
            }
            Namess("Half-Orc");
        }

        private void Halfling_Click(object sender, EventArgs e)
        {
            if (Lingo.Checked)
            {
                Lang("halfling");
            }
            if (Size.Checked)
            {
                SizeDesc("halfling");
            }
            if (alignment.Checked)
            {
                Aligment("halfling");
            }
            Namess("Halfing");
        }

        private void Human_Click(object sender, EventArgs e)
        {
            if (Lingo.Checked)
            {
                Lang("human");
            }
            if (Size.Checked)
            {
                SizeDesc("human");
            }
            if (alignment.Checked)
            {
                Aligment("human");
            }
            Namess("Human");
        }

        private void Tiefling_Click(object sender, EventArgs e)
        {
            if (Lingo.Checked)
            {
                Lang("tiefling");
            }
            if (Size.Checked)
            {
                SizeDesc("tiefling");
            }
            if (alignment.Checked)
            {
                Aligment("tiefling");
            }
            Namess("Tiefling");
        }
        private void Namess(string input2)
        {
            string name1 = string.Empty;
            name1 += input2;
            Nametxt.Text = name1;


        }
        private async void Lang (string input)
        {
            var test = await TestGetRequest2(input);
            string test2 = string.Empty;

            test.language_desc += test2;
            Testing10.Text = test.language_desc;

        }
        private async void Aligment(string input)
        {
            var test = await TestGetRequest2(input);
            string test2 = string.Empty;

            test.alignment += test2;
            Testing10.Text = test.alignment;

        }
        private async void SizeDesc (string input)
        {
            var test = await TestGetRequest2(input);
            string test2 = string.Empty;

            test.size_description += test2;
            Testing10.Text = test.size_description;

        }
        private async void Lag(string input)
        {
            var test = await TestGetRequest2(input);
            string test2 = string.Empty;

            test.language_desc += test2;
            Testing10.Text = test.language_desc;

        }

            private void Lingo_CheckedChanged(object sender, EventArgs e)
        {
            Size.Checked=(false);
            alignment.Checked = (false);
        }
        private void alignment_CheckedChanged(object sender, EventArgs e)
        {
            Size.Checked = (false);
            Lingo.Checked = (false);
        }

        private void Size_CheckedChanged(object sender, EventArgs e)
        {
            Lingo.Checked = (false);
            alignment.Checked = (false);
        }

        public class ListRaces
        {
            public int Count
            {
                get;
                set;
            }

            public List<Races> results { get; set; } = new List<Races>();
            public ListRaces(int count, List<Races> rACES)
            {
                Count = count;
                results = rACES;

            }

        }
        public class Races
        {
            public string index { get; set; }
            public string name { get; set; }
            public string URL { get; set; }
        }
        public class Rootobject2
        {
            public int count { get; set; }
            public Result[] results { get; set; }
        }

        public class Result
        {
            public string index { get; set; }
            public string name { get; set; }
            public string url { get; set; }
            public From[] from { get; set; }
        }

        public class RacesINFO
        {
            public string _id { get; set; }
            public string index { get; set; }
            public string name { get; set; }
            public int speed { get; set; }
            public Ability_Bonuses[] ability_bonuses { get; set; }
            public string age { get; set; }
            public string alignment { get; set; }
            public string size { get; set; }
            public string size_description { get; set; }
            public object[] starting_proficiencies { get; set; }
            public Language[] languages { get; set; }
            public Language_Options language_options { get; set; }
            public string language_desc { get; set; }
            public object[] traits { get; set; }
            public object[] subraces { get; set; }
            public string url { get; set; }
        }

        public class Language_Options
        {
            public int choose { get; set; }
            public string type { get; set; }
            public From2[] from { get; set; }
        }

        public class From2
        {
            public string url { get; set; }
            public string name { get; set; }
        }

        public class Ability_Bonuses
        {
            public string name { get; set; }
            public string url { get; set; }
            public int bonus { get; set; }
        }

        public class Language
        {
            public string url { get; set; }
            public string name { get; set; }
        }
    }

}

