/*
Implemente o padrão Abstract Factory para a criação de um gerador de objetos que herdem
da classa abstrata Animais ( Gato, Cachorro, Peixe, Papagaio) e classifique os animais em
grupos de animais (Aquatico, Terrestre, Voador).
 */
using System;

abstract class Animal {}

abstract class GrupoAnimais {}



namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
