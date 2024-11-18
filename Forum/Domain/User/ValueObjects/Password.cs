using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace Forum.Domain {

    public class Password
    {
        public string Value { get; private set; } // retorna a senha

        private const int SaltSize = 16; // define o tamanho do salt, 128 bits
        private const int HashSize = 32; // define o tamanho do hash, 256 bits
        private const int MemoryCost = 65536; // memoria usada no processo de hashing, 64 MB
        private const int TimeCost = 4; // iterações do algoritmo
        private const int DegreeOfParallelism = 2; // threads usadas
                

        // construtor, garantindo que a senha sempre seja validada e depois hashada
        public Password(string value) {
            ValidatePasswordRules(value);
            
            (string hashedPassword, string salt) = HashPassword(value);
            Value = hashedPassword + "$" + salt;
        }

        // recebe um valor (password), e retorna dois (hashedPassword, salt)
        public static (string hashedPassword, string salt) HashPassword(string password)
        {
            var saltBytes = new byte[SaltSize]; // inicializa array saltBytes
            var rng = RandomNumberGenerator.Create(); // gera numeros randomicos
            rng.GetBytes(saltBytes); // popula saltBytes com random bytes gerados
            
            string salt = Convert.ToBase64String(saltBytes); // converte de byte para string

            // configurar Argon2id -- IMPLEMENTAR
            var hashedPassword = "a";

            return(hashedPassword, salt);
        }

        // valida regras para a senha ser aceita
        private static void ValidatePasswordRules(string password) 
        {
            if (string.IsNullOrWhiteSpace(password))
            throw new ArgumentException("A senha não pode ser vazia!");

            if (password.Length < 8)
                throw new ArgumentException("A senha tem que ter pelo menos 8 caracteres!");

            if (!Regex.IsMatch(password, @"[A-Za-z]"))
                throw new ArgumentException("A senha tem que ter pelo menos uma letra!");

            if (!Regex.IsMatch(password, @"\d"))
                throw new ArgumentException("A senha tem que ter pelo menos um número!");

            if (!Regex.IsMatch(password, @"[\W_]"))
                throw new ArgumentException("A senha tem que ter pelo menos um caracter especial!");
    
        }
    }
}