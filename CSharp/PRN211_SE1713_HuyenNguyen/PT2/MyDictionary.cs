namespace PT2
{
    public class MyDictionary
    {
        public string WordId { get; set; }
        public string Word { get; set; }

        public string EditDate { get; set; }
        public string Meaning { get; set; }

        public string TypeName { get; set; }


        public MyDictionary()
        {

        }

        public MyDictionary(string wordId, string word, string editDate, string meaning, string typeName)
        {
            WordId = wordId;
            Word = word;
            EditDate = editDate;
            Meaning = meaning;
            TypeName = typeName;
        }
    }
}