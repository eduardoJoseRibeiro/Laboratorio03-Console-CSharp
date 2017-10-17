using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio03
{
    public class Estacionamento
    {
        private int chapa, posLista = 0;
        private string marca;
        private Tempo entrada = new Tempo();
        private Tempo saida = new Tempo();
        private Estacionamento[] listaCarros = new Estacionamento[100];

        //Construtores
        public Estacionamento()
        {

        }
        public Estacionamento(int chapa, string marca, Tempo entrada, Tempo saida)
        {
            this.chapa = chapa;
            this.marca = marca;
            this.entrada = entrada;
            this.saida = saida;
        }
        
        //Getters
        public int getChapa()
        {
            return this.chapa;
        }
        public int getPosLista()
        {
            return this.posLista;
        }
        public string getMarca()
        {
            return this.marca;
        }
        public Tempo getEntrada()
        {
            return this.entrada;
        }
        public Tempo getSaida()
        {
            return this.saida;
        }
        public Estacionamento getListaCarros(int pos)
        {
            return this.listaCarros[pos];
        }

        //Setters
        public void setChapa(int chapa)
        {
            this.chapa = chapa;
        }
        public void setPosLista()
        {
            this.posLista++;
        }
        public void setMarca(string marca)
        {
            this.marca = marca;
        }
        public void setEntrada(Tempo entrada)
        {
            this.entrada = entrada;
        }
        public void setSaida(Tempo saida)
        {
            this.saida = saida;
        }
        public void setListaCarros(Estacionamento e)
        {
            int pos = this.getPosLista();
            this.listaCarros[pos] = e;
            this.setPosLista();
        }

        //Métodos
        public void solicitaDados()
        {
            Console.Write("Por favor informe os dados a seguir\n");

            Console.Write("Chapa do Carro: ");
            this.setChapa(
                Convert.ToInt32(
                    Console.ReadLine()));

            Console.Write("Marca: ");
            this.setMarca(
                Convert.ToString(
                    Console.ReadLine()));

            Console.Write("\nHorário de Entrada\n");
            this.getEntrada().solicitaHorario();

            Console.Write("\nHorário de Saída\n");
            this.getSaida().solicitaHorario();
        }
        public void imprimeDados()
        {
            Console.Write("Dados do Veículo\n");
            Console.Write("Chapa: " + this.getChapa() +
                "\nMarca: " + this.getMarca());

            Console.Write("\nHorário de Entrada: ");
            this.getEntrada().imprimirHorario();

            Console.Write("Horário de Saída: ");
            this.getSaida().imprimirHorario();

            Console.Write("\nValor a ser cobrado: R$ " + this.calculaPreco() + ",00\n\n");
        }
        public void imprimeLista()
        {
            int pos = 0;

            Console.Write("Veículos Cadastrados\n\n");

            for (; pos < this.getPosLista(); pos++)
            {
                this.getListaCarros(pos).imprimeDados();
            }
        }
        public int calculaPreco()
        {
            int valor, horas;

            Tempo entrada = this.getEntrada();
            Tempo saida = this.getSaida();
            
            saida.subtraiTempo(entrada);

            horas = saida.getHora();

            valor = horas + 1;

            return valor;
        }
    }
}
