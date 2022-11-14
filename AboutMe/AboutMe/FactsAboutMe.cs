using System;
using System.Collections.Generic;
using System.Text;

namespace AboutMe
{
    public class FactsAboutMe
    {
        public FactsAboutMe()
        { }

        public static IEnumerable<FactsAboutMe> Facts { private set; get; }

        public string TheFact { get; set; }
        public string ShortFact { get; set; }
        public string ImageSource { get; set; }

        static FactsAboutMe()
        {
            List<FactsAboutMe> facts = new List<FactsAboutMe>();
            facts.Add(new FactsAboutMe() { TheFact = "Sunflowers are my favorite flower", ShortFact = "Sunflowers", ImageSource = "sunflower.png"});
            facts.Add(new FactsAboutMe() { TheFact = "I have 8 siblings", ShortFact = "Siblings", ImageSource = "siblings.png" });
            facts.Add(new FactsAboutMe() { TheFact = "I was born and raised in California", ShortFact = "California", ImageSource = "california.png" });
            facts.Add(new FactsAboutMe() { TheFact = "Autumn is my favorite season", ShortFact = "Autumn", ImageSource = "leaves.png" });
            facts.Add(new FactsAboutMe() { TheFact = "I like to play video games", ShortFact = "Spare Time", ImageSource = "videogames.png" });
            facts.Add(new FactsAboutMe() { TheFact = "I enjoy crocheting because it keeps my hands busy", ShortFact = "Hobby", ImageSource = "crochet.png" });
            Facts = facts;
        }

    }
}
