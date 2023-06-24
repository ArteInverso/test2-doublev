// Importar los espacios de nombres necesarios
using System;
using NBitcoin;
using Nethereum.Hex.HexConvertors.Extensions;
using Nethereum.HdWallet;
using Nethereum.Signer;
using Nethereum.Util;

namespace Generador
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generar las palabras del mnemónico y llamar a la función para crear la wallet Ethereum
            var mnemonicWords = GeneratePrivateKeyAndMnemonic();
            CreateEthereumWallet(mnemonicWords);
        }

        static string GeneratePrivateKeyAndMnemonic()
        {
            // Generar una llave privada aleatoria
            var privateKey = new Key();
            var privateKeyHex = privateKey.ToHex();

            Console.WriteLine("Llave privada generada:");
            Console.WriteLine(privateKeyHex);

            // Generar conjunto de palabras para recrear la llave privada
            var mnemonic = new Mnemonic(Wordlist.English, WordCount.Twelve);
            var mnemonicWords = mnemonic.ToString();

            Console.WriteLine("\nConjunto de palabras generadas:");
            Console.WriteLine(mnemonicWords);

            return mnemonicWords;
        }

        static void CreateEthereumWallet(string mnemonicWords)
        {
            // Crear una instancia de Mnemonic utilizando las palabras generadas
            var mnemonic = new Mnemonic(mnemonicWords);

            // Derivar la semilla a partir del mnemónico
            var seed = mnemonic.DeriveSeed();

            // Crear una wallet Ethereum utilizando la semilla y una contraseña
            var hdWallet = new Wallet(seed, "password");

            // Obtener la cuenta Ethereum de la wallet en el índice 0
            var account = hdWallet.GetAccount(0);

            // Obtener la dirección de la cuenta Ethereum
            var address = account.Address.ToLower();

            Console.WriteLine("\nDirección de la wallet Ethereum:");
            Console.WriteLine(address);
        }
    }
}