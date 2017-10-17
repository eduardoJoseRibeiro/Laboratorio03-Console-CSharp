
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio03
{
    public class Tempo
    {
        private int hora, min, seg;

        //Construtores
        public Tempo()
        {
            this.hora = 0;
            this.min = 0;
            this.seg = 0;
        }
        public Tempo(int hora, int min, int seg)
        {
            this.hora = hora;
            this.min = min;
            this.seg = seg;
        }

        //Getters
        public int getHora()
        {
            return this.hora;
        }
        public int getMin()
        {
            return this.min;
        }
        public int getSeg()
        {
            return this.seg;
        }

        //Setters
        public void setHora(int hora)
        {
            this.hora = hora;
        }
        public void setMin(int min)
        {
            this.min = min;
        }
        public void setSeg(int seg)
        {
            this.seg = seg;
        }

        //Métodos
        public void solicitaHorario()
        {
            Console.WriteLine("Hora: ");
            this.setHora(
                    Convert.ToInt32(
                        Console.ReadLine()));
            Console.WriteLine("Minutos: ");
            this.setMin(
                    Convert.ToInt32(
                        Console.ReadLine()));
            Console.WriteLine("Segundos: ");
            this.setSeg(
                    Convert.ToInt32(
                        Console.ReadLine()));
        }
        public void organizaTempo()
        {
            int seg, min, hora;

            seg = this.getSeg();
            min = this.getMin();
            hora = this.getHora();

            if(seg >= 60)
            {
                seg -= 60;
                min++;
            }
            if(min >= 60)
            {
                min -= 60;
                hora++;
            }
            if(seg < 0)
            {
                min--;
                seg+= 60;
            }
            if(min < 0)
            {
                hora--;
                min += 60;
            }

            this.setSeg(seg);
            this.setMin(min);
            this.setHora(hora);
        }
        public void adicionaTempo(Tempo t1)
        {
            int seg, min, hora;

            seg = t1.getSeg() + this.getSeg();
            min = t1.getMin() + this.getMin();
            hora = t1.getHora() + this.getHora();

            this.setSeg(seg);
            this.setMin(min);
            this.setHora(hora);

            this.organizaTempo();
        }
        public void subtraiTempo(Tempo t1)
        {
            int seg, min, hora;

            seg = this.getSeg() - t1.getSeg();
            min = this.getMin() - t1.getMin();
            hora = this.getHora() - t1.getHora();

            this.setSeg(seg);
            this.setMin(min);
            this.setHora(hora);

            this.organizaTempo();
        }
        public void imprimirHorario()
        {
            Console.WriteLine(this.getHora() +
                                               ":" + this.getMin() +
                                                        ":" + this.getSeg());    
        }
    }
}
