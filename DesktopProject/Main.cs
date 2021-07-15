using DesktopProject.DbContext;
using DesktopProject.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopProject
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            IMongoCollection<WordsToLearn> elements = 
                Connection.CreateConnection().GetCollection<WordsToLearn>("WordsToLearn");

            WordsToLearn wl = new WordsToLearn()
            {
                Id = 3030,
                WordsToLearnList = new List<string>() { "Bike", "Ball" }
            };

            elements.InsertOne(wl);
            

            var realElements = elements.AsQueryable().ToList();
        }

        private void addANewWord_Click(object sender, EventArgs e)
        {
            var valueBox = txtToTranslate.Text;

            lstWordsToLearn.Items.Add(valueBox);
        }

        private void btnBtn_Click(object sender, EventArgs e)
        {
            var toDelete = lstWordsToLearn.SelectedIndex;

            lstWordsToLearn.Items.RemoveAt(toDelete);
        }
    }
}
