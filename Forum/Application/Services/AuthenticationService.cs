using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Services
{
    public class AuthenticationService
    {
        
        // private static bool VerifyPassword(string password, string salt, string hashedPassword)
        // {
        //     var saltBytes = Convert.FromBase64String(salt);

        //     // Configurar Argon2 com os mesmos parâmetros
        //     using (var hasher = new Argon2id(Encoding.UTF8.GetBytes(password)))
        //     {
        //         hasher.Salt = saltBytes;
        //         hasher.MemorySize = MemoryCost;
        //         hasher.Iterations = TimeCost;
        //         hasher.DegreeOfParallelism = DegreeOfParallelism;

        //         var hashBytes = hasher.GetBytes(HashSize);
        //         string computedHash = Convert.ToBase64String(hashBytes);

        //         // Comparar hashes (use comparação em tempo constante se possível)
        //         return CryptographicOperations.FixedTimeEquals(
        //             Encoding.UTF8.GetBytes(computedHash),
        //             Encoding.UTF8.GetBytes(hashedPassword)
        //         );
        //     }
        // }
    }
}