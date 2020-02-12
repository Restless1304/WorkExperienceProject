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

namespace WorkExperienceProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 temp = new Form2();
            temp.Region = this.Region;
            temp.Show(this);
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form3 temp = new Form3();
            temp.Region = this.Region;
            temp.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            testget(string.Empty);
        }
        public async Task<string> testget(string classA)
        {
            try
            {
                var getClassesObject = await $"http://dnd5eapi.co/api/classes/{classA}".GetAsync();
                var jsonOfClases = JsonConvert.DeserializeObject<Classlist>(getClassesObject.Content.ReadAsStringAsync().Result);

                return "";
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                return "";
            }

        }
        public async Task <Rootobject> testget2(string classA)
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            testget(string.Empty);

        }

        private async void button5_Click(object sender, EventArgs e)
        {
            var barb = await testget2("bard");

            string ProfNames = string.Empty;

            for (int i = 0; i < barb.proficiency_choices.Length; i++)
            {
                for (int j = 0; j < barb.proficiency_choices[i].from.Length; j++)
                {
                    ProfNames += barb.proficiency_choices[i].from[j].name;
                    ProfNames += Environment.NewLine;
                }
            }
            Label1.Text = ProfNames;
            pictureBox1.Image = Image.FromFile(@"C:\Users\WILL.LAPSLEY\Desktop\WorkExperienceProject\WorkExperienceProject\Resources\Bardpic.png");
        }
        private async void button6_Click(object sender, EventArgs e)
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
            Label1.Text = ProfNames;
            pictureBox1.Image = Image.FromFile(@"C:\Users\WILL.LAPSLEY\Desktop\WorkExperienceProject\WorkExperienceProject\Resources\Clericpic.png");
        }
        private async void Druid_Click(object sender, EventArgs e)
        {
            var barb = await testget2("druid");

            string ProfNames = string.Empty;

            for (int i = 0; i < barb.proficiency_choices.Length; i++)
            {
                for (int j = 0; j < barb.proficiency_choices[i].from.Length; j++)
                {
                    ProfNames += barb.proficiency_choices[i].from[j].name;
                    ProfNames += Environment.NewLine;
                }
            }
            Label1.Text = ProfNames;
            pictureBox1.Image = Image.FromFile(@"C:\Users\WILL.LAPSLEY\Desktop\WorkExperienceProject\WorkExperienceProject\Resources\Druid.png");
        }
        private async void Fighter_Click(object sender, EventArgs e)
        {
            var barb = await testget2("fighter");

            string ProfNames = string.Empty;

            for (int i = 0; i < barb.proficiency_choices.Length; i++)
            {
                for (int j = 0; j < barb.proficiency_choices[i].from.Length; j++)
                {
                    ProfNames += barb.proficiency_choices[i].from[j].name;
                    ProfNames += Environment.NewLine;
                }
            }
            Label1.Text = ProfNames;
            pictureBox1.Image = Image.FromFile(@"C:\Users\WILL.LAPSLEY\Desktop\WorkExperienceProject\WorkExperienceProject\Resources\Fighter.png");
        }
        private async void Monk_Click(object sender, EventArgs e)
        {
            var barb = await testget2("monk");

            string ProfNames = string.Empty;

            for (int i = 0; i < barb.proficiency_choices.Length; i++)
            {
                for (int j = 0; j < barb.proficiency_choices[i].from.Length; j++)
                {
                    ProfNames += barb.proficiency_choices[i].from[j].name;
                    ProfNames += Environment.NewLine;
                }
            }
            Label1.Text = ProfNames;
            pictureBox1.Image = Image.FromFile(@"C:\Users\WILL.LAPSLEY\Desktop\WorkExperienceProject\WorkExperienceProject\Resources\Monk.png");
        }
        private async void Paladin_Click(object sender, EventArgs e)
        {
            var barb = await testget2("paladin");

            string ProfNames = string.Empty;

            for (int i = 0; i < barb.proficiency_choices.Length; i++)
            {
                for (int j = 0; j < barb.proficiency_choices[i].from.Length; j++)
                {
                    ProfNames += barb.proficiency_choices[i].from[j].name;
                    ProfNames += Environment.NewLine;
                }
            }
            Label1.Text = ProfNames;
            pictureBox1.Image = Image.FromFile(@"C:\Users\WILL.LAPSLEY\Desktop\WorkExperienceProject\WorkExperienceProject\Resources\Paladin.png");
        }
        private async void Ranger_Click(object sender, EventArgs e)
        {
            var barb = await testget2("ranger");

            string ProfNames = string.Empty;

            for (int i = 0; i < barb.proficiency_choices.Length; i++)
            {
                for (int j = 0; j < barb.proficiency_choices[i].from.Length; j++)
                {
                    ProfNames += barb.proficiency_choices[i].from[j].name;
                    ProfNames += Environment.NewLine;
                }
            }
            Label1.Text = ProfNames;
            pictureBox1.Image = Image.FromFile(@"C:\Users\WILL.LAPSLEY\Desktop\WorkExperienceProject\WorkExperienceProject\Resources\Ranger.png");
        }
        private async void Rogue_Click(object sender, EventArgs e)
        {
            var barb = await testget2("rogue");

            string ProfNames = string.Empty;

            for (int i = 0; i < barb.proficiency_choices.Length; i++)
            {
                for (int j = 0; j < barb.proficiency_choices[i].from.Length; j++)
                {
                    ProfNames += barb.proficiency_choices[i].from[j].name;
                    ProfNames += Environment.NewLine;
                }
            }
            Label1.Text = ProfNames;
            pictureBox1.Image = Image.FromFile(@"C:\Users\WILL.LAPSLEY\Desktop\WorkExperienceProject\WorkExperienceProject\Resources\Rogue.png");
        }
        private async void Sorcerer_Click(object sender, EventArgs e)
        {
            var barb = await testget2("sorcerer");

            string ProfNames = string.Empty;

            for (int i = 0; i < barb.proficiency_choices.Length; i++)
            {
                for (int j = 0; j < barb.proficiency_choices[i].from.Length; j++)
                {
                    ProfNames += barb.proficiency_choices[i].from[j].name;
                    ProfNames += Environment.NewLine;
                }
            }
            Label1.Text = ProfNames;
            pictureBox1.Image = Image.FromFile(@"C:\Users\WILL.LAPSLEY\Desktop\WorkExperienceProject\WorkExperienceProject\Resources\Sorcerer.png");
        }
        private async void Warlock_Click(object sender, EventArgs e)
        {
            var barb = await testget2("warlock");

            string ProfNames = string.Empty;

            for (int i = 0; i < barb.proficiency_choices.Length; i++)
            {
                for (int j = 0; j < barb.proficiency_choices[i].from.Length; j++)
                {
                    ProfNames += barb.proficiency_choices[i].from[j].name;
                    ProfNames += Environment.NewLine;
                }
            }
            Label1.Text = ProfNames;
            pictureBox1.Image = Image.FromFile(@"C:\Users\WILL.LAPSLEY\Desktop\WorkExperienceProject\WorkExperienceProject\Resources\Warlock.png");
        }
        private async void Wizard_Click(object sender, EventArgs e)
        {
            var barb = await testget2("wizard");

            string ProfNames = string.Empty;

            for (int i = 0; i < barb.proficiency_choices.Length; i++)
            {
                for (int j = 0; j < barb.proficiency_choices[i].from.Length; j++)
                {
                    ProfNames += barb.proficiency_choices[i].from[j].name;
                    ProfNames += Environment.NewLine;
                }
            }
            Label1.Text = ProfNames;
            pictureBox1.Image = Image.FromFile(@"C:\Users\WILL.LAPSLEY\Desktop\WorkExperienceProject\WorkExperienceProject\Resources\Wizard.png");
        }

        private async void Barbarian_Click(object sender, EventArgs e)
        {
           getBarbarianImage();
        }
        private async void getBarbarianImage() 
        {
            var barb = await testget2("barbarian");

            string ProfNames = string.Empty;

            for (int i = 0; i < barb.proficiency_choices.Length; i++)
            {
                for (int j = 0; j < barb.proficiency_choices[i].from.Length; j++)
                {
                    ProfNames += barb.proficiency_choices[i].from[j].name;
                    ProfNames += Environment.NewLine;
                }
            }
            Label1.Text = ProfNames;
            DisplayImage(@"C:\Users\WILL.LAPSLEY\Desktop\WorkExperienceProject\WorkExperienceProject\Resources\Barbarian1.png");
        }
        private async void DisplayImage(string ImageFile)
        {
            pictureBox1.Image = Image.FromFile(ImageFile);


        }
    }

    public class Classlist
        {
            public int Count
            {
                get;
                set;
            }
            public List<DNDClass> results { get; set; } = new List<DNDClass>();
            public Classlist(int count, List<DNDClass> dND)
            {
                Count = count;
                results = dND;
            }
        }
        public class DNDClass
        {
            public string index { get; set; }
            public string name { get; set; }
            public string URL { get; set; }
        }

        public class Rootobject
        {
            public string _id { get; set; }
            public string index { get; set; }
            public string name { get; set; }
            public int hit_die { get; set; }
            public Proficiency_Choices[] proficiency_choices { get; set; }
            public Proficiency[] proficiencies { get; set; }
            public Saving_Throws[] saving_throws { get; set; }
            public Starting_Equipment starting_equipment { get; set; }
            public Class_Levels class_levels { get; set; }
            public Subclass[] subclasses { get; set; }
            public SpellCasting spellcasting { get; set; }
            public string url { get; set; }
        }

        public class Starting_Equipment
        {
            public string url { get; set; }
            public string _class { get; set; }
        }

        public class Class_Levels
        {
            public string url { get; set; }
            public string _class { get; set; }
        }

        public class Proficiency_Choices
        {
            public int choose { get; set; }
            public string type { get; set; }
            public From[] from { get; set; }
        }

        public class From
        {
            public string url { get; set; }
            public string name { get; set; }
        }

        public class Proficiency
        {
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Saving_Throws
        {
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Subclass
        {
            public string url { get; set; }
            public string name { get; set; }
            public From[] from { get; set; }
        }
        public class SpellCasting
        {
            public string url { get; set; }
            public string _class { get; set; }

        }

}
