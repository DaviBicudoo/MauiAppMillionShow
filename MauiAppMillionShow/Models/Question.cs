using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppMillionShow.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Statement { get; set; }
        public List<Alternative> Alternatives { get; set; }

        void getRandomEasyQuestion()
        {

        }
    }
}
