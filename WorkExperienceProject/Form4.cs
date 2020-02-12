﻿using System;
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
                var jsonOfClases = JsonConvert.DeserializeObject<ListRaces>(getRacesObject.Content.ReadAsStringAsync().Result);

                return "";
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                return "";
            }

        }
        public async Task<Rootobject2> TestGetRequest2(string classA)
        {
            try
            {
                var getRacesObject = await $"http://dnd5eapi.co/api/races/{classA}".GetAsync();
                var jsonOfClases = JsonConvert.DeserializeObject<Rootobject2>(getRacesObject.Content.ReadAsStringAsync().Result);

                return jsonOfClases;
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

        }

        private void Dwarf_Click(object sender, EventArgs e)
        {

        }

        private void Elf_Click(object sender, EventArgs e)
        {

        }

        private void Gnome_Click(object sender, EventArgs e)
        {

        }

        private void HalfElf_Click(object sender, EventArgs e)
        {

        }

        private void HalfOrc_Click(object sender, EventArgs e)
        {

        }

        private void Halfling_Click(object sender, EventArgs e)
        {

        }

        private void Human_Click(object sender, EventArgs e)
        {

        }

        private void Tiefling_Click(object sender, EventArgs e)
        {

        }
        public class ListRaces
        {
            public int Count { get; set; }

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
            public string index { get; set; }
            public string name { get; set; }
            public string URL { get; set; }
        }
    }
}

