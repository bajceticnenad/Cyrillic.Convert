
using System;
using System.Collections.Generic;
using System.Text;

namespace Cyrillic.Convert.Dictionaries
{
    public class Srpski
    {
        Dictionary<string, string> srb_dictionary;
        public void SrbDictionary()
        {
            srb_dictionary = new Dictionary<string, string>();
            srb_dictionary.Add("Љ", "Lj");
            srb_dictionary.Add("Њ", "Nj");
            srb_dictionary.Add("Џ", "Dž");
            srb_dictionary.Add("љ", "lj");
            srb_dictionary.Add("њ", "nj");
            srb_dictionary.Add("џ", "dž");
            srb_dictionary.Add("а", "a");
            srb_dictionary.Add("б", "b");
            srb_dictionary.Add("в", "v");
            srb_dictionary.Add("г", "g");
            srb_dictionary.Add("д", "d");
            srb_dictionary.Add("ђ", "đ");
            srb_dictionary.Add("е", "e");
            srb_dictionary.Add("ж", "ž");
            srb_dictionary.Add("з", "z");
            srb_dictionary.Add("и", "i");
            srb_dictionary.Add("ј", "j");
            srb_dictionary.Add("к", "k");
            srb_dictionary.Add("л", "l");
            srb_dictionary.Add("м", "m");
            srb_dictionary.Add("н", "n");
            srb_dictionary.Add("о", "o");
            srb_dictionary.Add("п", "p");
            srb_dictionary.Add("р", "r");
            srb_dictionary.Add("с", "s");
            srb_dictionary.Add("т", "t");
            srb_dictionary.Add("ћ", "ć");
            srb_dictionary.Add("у", "u");
            srb_dictionary.Add("ф", "f");
            srb_dictionary.Add("х", "h");
            srb_dictionary.Add("ц", "c");
            srb_dictionary.Add("ч", "č");
            srb_dictionary.Add("ш", "š");
        }

        public Dictionary<string, string> getDictionary()
        {
            SrbDictionary();
            return this.srb_dictionary;
        }
    }
}

/*
 
  private Dictionary<string, string> srpski;
        public SrpskiDictionary { get srpski; set srpski = value; }

        public Srpski()
        {
            srpski = new Dictionary<string, string>();
                srpski.Add("Classifieds", "Kleinanzeigen");
        }  
     */
