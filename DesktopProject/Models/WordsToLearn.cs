using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopProject.Models
{
    public class WordsToLearn
    {
        [BsonId]
        public int Id { get; set; }


        public List<string> WordsToLearnList { get; set; }

    }
}
