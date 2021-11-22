using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
      Console.WriteLine("Write your message in the next line:");
      string input = Console.ReadLine().ToLower();
      char[] secretmessage = new char[input.Length];
      char[] encryptedMessage = new char[input.Length];
      for(int i = 0; i < input.Length; i++){
        secretmessage[i] = input[i];
      }
      Console.WriteLine("Write how many shifts you want in your encryption: ");
      int alphakey = Int32. Parse(Console.ReadLine());
      encryptedMessage = Encrypt(secretmessage, alphabet, alphakey);
      string finalMessage = String.Join("", encryptedMessage);
      Console.WriteLine(finalMessage);
    }

    static char[] Encrypt(char[] secretmessage, char[] alphabet, int alphakey){
        char[] tempmessage = new char[secretmessage.Length];
        for(int i = 0; i < secretmessage.Length; i++){
        int letterPos = Array.IndexOf(alphabet, secretmessage[i]);
        if (letterPos != -1) {
            int letterAlphabet = (letterPos + alphakey) % 26;
            char newLetter = alphabet[letterAlphabet];
            tempmessage[i] = newLetter;
        } else {
          tempmessage[i] = secretmessage[i];
        }
      }
      return tempmessage;
    }
  }
}