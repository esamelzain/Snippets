using System;
using System.Net;	
using Microsoft.AspNetCore.Identity;

public class Program
{
	public static void Main()
	{
		string plainJson = "{\"JsonProp\": \"JsonValue\"}";
		string hashed =CryptoHelper.HashString(plainJson);
		Console.WriteLine(hashed);
		Console.WriteLine(CryptoHelper.VerifyHashedString(hashed,plainJson));
	}
}
public sealed class CryptoHelper{
	
	public static bool VerifyHashedString(string hashedValue, string value)
        {
            PasswordHasher<CryptoHelper> passwordHasher = new PasswordHasher<CryptoHelper>();
            PasswordVerificationResult verifyRes = passwordHasher.VerifyHashedPassword(null, hashedValue, value);
            return verifyRes != PasswordVerificationResult.Failed;
        }

        public static string HashString(string value)
        {
            PasswordHasher<CryptoHelper> passwordHasher = new PasswordHasher<CryptoHelper>();
            return passwordHasher.HashPassword(null, value);
        }	
}
