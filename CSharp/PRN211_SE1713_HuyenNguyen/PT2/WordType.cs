namespace PT2
{
    public class WordType
    {
        public string Id { get; set; }
        public string TypeName { get; set; }

        public WordType()
        {

        }

        public WordType(string id, string typeName)
        {
            Id = id;
            TypeName = typeName;
        }
    }
}