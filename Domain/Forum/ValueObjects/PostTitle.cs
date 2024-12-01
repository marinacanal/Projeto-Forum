namespace Domain.Forum.ValueObjects
{   
    public class Title
    {
        public string Value { get; private set; }

        public Title(string value) => Value = value ?? throw new ArgumentNullException("Título não pode ser vazio!");
    }
}