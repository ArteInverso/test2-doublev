using System;
using NBitcoin;
using Nethereum.Hex.HexConvertors.Extensions;
using Nethereum.HdWallet;
using Nethereum.Signer;
using Nethereum.Util;

namespace GeneradorEthereumWallet
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generar las palabras mnemotécnicas y crear una wallet de Ethereum
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

            // Generar conjunto de palabras mnemotécnicas para recrear la llave privada
            var mnemonic = new Mnemonic(Wordlist.English);
            var mnemonicWords = mnemonic.ToString();

            Console.WriteLine("\nConjunto de palabras generadas:");
            Console.WriteLine(mnemonicWords);

            return mnemonicWords;
        }

        static void CreateEthereumWallet(string mnemonicWords)
        {
            // Crear una wallet de Ethereum a partir de las palabras mnemotécnicas
            var mnemonic = new Mnemonic(mnemonicWords, Wordlist.English);
            var seed = mnemonic.DeriveSeed();

            // Derivar una cuenta de Ethereum de la wallet
            var hdWallet = new Wallet(seed, "m/44'/60'/0'/0/0");
            var account = hdWallet.GetAccount(0);

            // Obtener la dirección de ethereum
            var address = account.Address.ToLower();
            Console.WriteLine("\nDirección de la wallet Ethereum:");
            Console.WriteLine(address);
        }
    }
}