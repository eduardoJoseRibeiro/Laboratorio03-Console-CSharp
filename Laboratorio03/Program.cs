using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Estacionamento e = new Estacionamento();

            Console.Clear();
            Console.WriteLine("Cadastro de veículos");

            Estacionamento e1 = new Estacionamento();
            e1.solicitaDados();


            Estacionamento e2 = new Estacionamento();
            e2.solicitaDados();


            Estacionamento e3 = new Estacionamento();
            e3.solicitaDados();


            Estacionamento e4 = new Estacionamento();
            e4.solicitaDados();


            Estacionamento e5 = new Estacionamento();
            e5.solicitaDados();

            e.setListaCarros(e1);
            e.setListaCarros(e2);
            e.setListaCarros(e3);
            e.setListaCarros(e4);
            e.setListaCarros(e5);

            Console.Clear();

            e.imprimeLista();

            Console.Read();
        }
    }
}
