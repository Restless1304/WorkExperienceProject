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
            testing("dragonborn");
        }

        private void Dwarf_Click(object sender, EventArgs e)
        {
            testing("dwarf");
        }

        private void Elf_Click(object sender, EventArgs e)
        {
            testing("elf");
        }

        private void Gnome_Click(object sender, EventArgs e)
        {
            testing("gnome");
        }

        private void HalfElf_Click(object sender, EventArgs e)
        {
            testing("half-elf");
        }

        private void HalfOrc_Click(object sender, EventArgs e)
        {
            testing("half-orc");
        }

        private void Halfling_Click(object sender, EventArgs e)
        {
            testing("halfling");
        }

        private void Human_Click(object sender, EventArgs e)
        {
            testing("human");
        }

        private void Tiefling_Click(object sender, EventArgs e)
        {
            testing("tiefling");
        }
        private async void testing (string input)
        {
            var test = await TestGetRequest2(input);
            string test2 = string.Empty;

            test.language_desc += test2;
            Testing10.Text = test.language_desc;

        }
        private void Lingo_CheckedChanged(object sender, EventArgs e)
        {
        
        

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

