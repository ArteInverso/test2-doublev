# Prueba de Código para Generar una Wallet Ethereum


### Requisitos Previos
Antes de probar el código, asegúrate de tener instalado lo siguiente ya que es un codigo en C#:

Microsoft .NET Core SDK: [Descargar e instalar .NET Core SDK](https://dotnet.microsoft.com/es-es/download)

### Probar el Código
Para probar el código, sigue estos pasos:

Clona el repositorio o descarga los archivos del proyecto en tu sistema.

Abre una terminal o línea de comandos y navega hasta la ubicación donde se encuentran los archivos del proyecto.

### Ejecuta el siguiente comando para compilar el proyecto:
```
dotnet build
```

### Una vez compilado con éxito, ejecuta el siguiente comando para ejecutar el programa:
```
dotnet run
```

Esto generará una llave privada aleatoria, mostrará la llave privada generada y el conjunto de palabras correspondiente, y finalmente mostrará la dirección de la wallet Ethereum generada.

# Decisiones de Diseño

- Se utilizó el lenguaje de programación C# y el entorno .NET Core para implementar el código.
- Se utilizó la biblioteca NBitcoin para generar la llave privada aleatoria y mostrarla en formato hexadecimal.
- Se utilizó la biblioteca Nethereum para crear la wallet Ethereum a partir del conjunto de palabras del mnemónico y mostrar la dirección resultante.
- Se utilizó el estándar BIP39 para generar un conjunto de palabras mnemónicas a partir de una llave privada aleatoria y poder recrearla en el futuro.
- Se utilizó una lista de palabras en inglés como el wordlist para generar las palabras mnemónicas.
- Se implementaron dos funciones principales: GeneratePrivateKeyAndMnemonic para generar la llave privada aleatoria y el conjunto de palabras mnemónicas, y CreateEthereumWallet para crear la wallet Ethereum a partir de las palabras mnemónicas y mostrar la dirección resultante.
- Se utilizó la consola para mostrar los resultados por simplicidad, pero se puede adaptar el código para integrarlo en otras aplicaciones según sea necesario.

