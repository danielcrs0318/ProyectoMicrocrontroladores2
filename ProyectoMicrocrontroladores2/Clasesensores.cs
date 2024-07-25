using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMicrocrontroladores2
{
    internal class Clasesensores
    {

        private int infrrrojo;
        private String color;
        private int grados;
        private static int prevInfrrrojo = 0;
        private static string prevColor = string.Empty;
        private static int prevGrados = 0;


        public Clasesensores()
        {

            infrrrojo = 0;
            color = string.Empty;
            grados = 0;

        }

        public Clasesensores(int pinfrarrojo, string pcolor, int pgrados)
        {
            this.infrrrojo = pinfrarrojo;
            this.color = pcolor;
            this.grados = pgrados;
        }


        public int INFRARROJO
        {
            get { return infrrrojo; }
            set { infrrrojo = value; }

        }
        public string COLOR
        {
            get => color;
            set => color = value;
        }
        public int GRADOS
        {
            get { return grados; }
            set { grados = value; }
        }



        public void INICIAR()
        {
            if (infrrrojo != prevInfrrrojo || color != prevColor || grados != prevGrados)
            {
                conexionsqlluca con = new conexionsqlluca();
                con.Conectar();
                string cadena = $"INSERT INTO ValoresSensores (ValorInfrarrojo, ColorDetectado, GradosServomotor)" +
                                $"VALUES ('{INFRARROJO}', '{COLOR}', '{GRADOS}');";
                con.Ejecutar(cadena);

                
                prevInfrrrojo = infrrrojo;
                prevColor = color;
                prevGrados = grados;
            }

        }



    }
}
