// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

    using FactoryMethod;

    BebidaEmbriagante bebida = Creador.CreadorBebida(Creador.CERVEZA);
    Console.WriteLine(bebida.cuantomeembriagaPorHora());
