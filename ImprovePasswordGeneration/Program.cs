using System.Security.Cryptography;

string GeneratePasswordHashUsingSalt(string passwordText, byte[] salt)
{
    var iterate = 10000;

    return Convert.ToBase64String(Rfc2898DeriveBytes.Pbkdf2(passwordText, salt, iterate, HashAlgorithmName.SHA1, 36));
}

byte[] salt = new byte[16];
Random rand = new Random();
rand.NextBytes(salt);

Console.WriteLine(GeneratePasswordHashUsingSalt("password", salt));
Console.ReadKey();
