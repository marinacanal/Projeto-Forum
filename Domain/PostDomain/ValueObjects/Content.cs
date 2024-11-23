namespace Domain.PostDomain.ValueObjects
{
    public class Content
    {
        public string Value { get; private set; }

        public Content(string value) => Value = value ?? throw new ArgumentNullException("Conteúdo não pode ser vazio!");
    }
}