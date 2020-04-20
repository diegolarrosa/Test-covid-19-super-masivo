using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Programa mejorado de tres etapas
 * 
 * El programa realiza una serie de simulaciones, por ejemplo 1000.
 * En cada simulación toma una lista de personas y le asigna un valor aleatótio booleano, el cual indica si está infectado o no.
 * Luego realiza el proceso de búsqueda por test, para determinar cada persona si está infectada o no.
 * Devolviendo por cada simulación el número de test que fueron necesarios hacer para obtener el resultado.
 * En el resultado se indican cuantos test promedio se necesitaron en comparación con la muestra. También devuelve la eficiencia lograda.
 */
namespace SimulacionSuperMasiva
{
    public partial class SimSuperMasiva : Form
    {
        struct DSimulacionTest
        {
            public int multA;
            public int multB;
            public int multC;
            public int nSim;
            public double nInfectadosPorMillon;
            //Agregado
            public int repeticiones_primera_etapa;
            public int repeticiones_segunda_etapa;
            public double efectividad_de_test_estandar;
            public double efectividad_de_mezcla_primera_etapa;
            public double efectividad_de_mexcla_segunda_etapa;

            public bool[] listaDePersonas;//por cada elemento en la lista, true -> infectado, false -> no infectado
        }

        private Random rmd;
        double promedio_casos_no_detectados;
        double promedio_casos_reales;

        public SimSuperMasiva()
        {
            InitializeComponent();
            rmd = new Random();
        }

        private void button_iniciar_simulacion_Click(object sender, EventArgs e)
        {
            button_iniciar_simulacion.Enabled = false;
            progressBar1.Visible = true;
            button_cancelar.Visible = true;
            progressBar1.Value = 0;

            DSimulacionTest st = new DSimulacionTest();
            st.multA = (int)numericUpDown_primera_etapa.Value;
            st.multB = (int)numericUpDown_segunda_etapa.Value;
            st.multC = (int)numericUpDown_tercera_etapa.Value;
            st.nSim = (int)numericUpDown_numero_de_simulaciones.Value;
            st.nInfectadosPorMillon = (double)numericUpDown_infectados_por_millon_supuesto.Value;

            st.repeticiones_primera_etapa = (int)numericUpDown_repeticiones_primera_etapa.Value;
            st.repeticiones_segunda_etapa = (int)numericUpDown_repeticiones_segunda_etapa.Value;
            st.efectividad_de_test_estandar = (double)numericUpDown_efectividad_de_test_estandar.Value;
            st.efectividad_de_mezcla_primera_etapa = (double)numericUpDown_efectividad_de_mezcla_primera_etapa.Value;
            st.efectividad_de_mexcla_segunda_etapa = (double)numericUpDown_efectividad_de_mezcla_segunda_etapa.Value;

            st.listaDePersonas = new bool[st.multA * st.multB * st.multC];
            textBox1_resultado.Text = "";
            backgroundWorker1.RunWorkerAsync(st);
        }

        /// <summary>
        /// Procesa una simulación, y devuelve el número de test que fueron necesarios
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        private int IndividualSimulacion(DSimulacionTest st, ref int contador_casos_no_detectados, ref int contador_casos_reales)
        {
            int res = 0;
            int contador_infectados = 0;
            int contador_detectados = 0;

            //Carga el arreglo de personas, con datos aleatorios
            int p = (int)(1000000.0 / st.nInfectadosPorMillon);
            int e_test_estandarX100 = (int)(st.efectividad_de_test_estandar * 100.0);
            int e_mezcla_primera_etapaX100 = (int)(st.efectividad_de_mezcla_primera_etapa * 100.0);
            int e_mezcla_segunda_etapaX100 = (int)(st.efectividad_de_mexcla_segunda_etapa * 100.0);
            for (int i = 0; i < st.multA; i++)
            {
                for (int j = 0; j < st.multB; j++)
                {
                    for (int k = 0; k < st.multC; k++)
                    {
                        st.listaDePersonas[i * st.multB * st.multC + j * st.multC + k] = rmd.Next(p) == 1;//También se puede poner "== 0", la idea es poner un número bajo que sea menor que p, donde p es probable que tome valores mayores a 1000, al menos que los infectados por millón tenga una cifra muy alta
                        //st.listaDePersonas[i * st.multB * st.multC + j * st.multC + k] = false;
                    }
                }
            }

            //st.listaDePersonas[0] = true;
            //st.listaDePersonas[999] = true;

            //código auxiliar para contar la cantidad de infectados que produjo la carga aleatoria

            //Cuenta la cantidad de infectados reales, para evaluar los casos no detectados
            for (int i = 0; i < st.multA; i++)
            {
                for (int j = 0; j < st.multB; j++)
                {
                    for (int k = 0; k < st.multC; k++)
                    {
                        if (st.listaDePersonas[i * st.multB * st.multC + j * st.multC + k])
                        {
                            contador_infectados++;
                        }
                    }
                }
            }
            //return res;

            bool q = false;
            //-------------------Test primera etapa-------------------
            for (int rep_pe = 0; rep_pe < st.repeticiones_primera_etapa; rep_pe++)
            {
                //Se prueban todos los casos al mismo tiempo, con un solo test
                res += 1;
                q = false;
                for (int i = 0; i < st.multA; i++)
                {
                    for (int j = 0; j < st.multB; j++)
                    {
                        for (int k = 0; k < st.multC; k++)
                        {
                            if (st.listaDePersonas[i * st.multB * st.multC + j * st.multC + k])
                            {
                                //Se encontró al menos un infectado

                                //Se evalúa la efectividad del resultado encontrado, con la efectividad del test
                                if (rmd.Next(10000) <= e_test_estandarX100)
                                {
                                    //Se evalúa la efectividad del resultado encontrado, con la efectividad de la primera mezcla
                                    if (rmd.Next(10000) <= e_mezcla_primera_etapaX100)
                                    {
                                        q = true;
                                        break;
                                    }
                                }
                            }
                        }
                        if (q)
                        {
                            break;
                        }
                    }
                    if (q)
                    {
                        break;
                    }
                }
                if (q)
                {
                    break;
                }
            }
            if (!q)
            {
                //No se encontró ningún caso en la simulación
                contador_casos_no_detectados = contador_infectados;
                contador_casos_reales = contador_infectados;
                return res;
            }
            
            //-------------------Test segunda etapa-------------------

            for (int i = 0; i < st.multA; i++)
            {
                for (int rep_se = 0; rep_se < st.repeticiones_segunda_etapa; rep_se++)
                {
                    res += 1;
                    q = false;
                    for (int j = 0; j < st.multB; j++)
                    {
                        for (int k = 0; k < st.multC; k++)
                        {
                            if (st.listaDePersonas[i * st.multB * st.multC + j * st.multC + k])
                            {
                                //Se encontró al menos un infectado

                                //Se evalúa la efectividad del resultado encontrado, con la efectividad del test
                                if (rmd.Next(10000) <= e_test_estandarX100)
                                {
                                    //Se evalúa la efectividad del resultado encontrado, con la efectividad de la primera mezcla
                                    if (rmd.Next(10000) <= e_mezcla_primera_etapaX100)
                                    {
                                        //Se evalúa la efectividad del resultado encontrado, con la efectividad de la segunda mezcla
                                        if (rmd.Next(10000) <= e_mezcla_segunda_etapaX100)
                                        {
                                            q = true;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        if (q)
                        {
                            break;  
                        }
                    }
                    if (q)
                    {
                        break;
                    }
                }
            }


            //------------------- Test tercera etapa ----------------------

            for (int i = 0; i < st.multA; i++)
            {
                q = false;
                for (int j = 0; j < st.multB; j++)
                {
                    q = false;
                    for (int k = 0; k < st.multC; k++)
                    {
                        if (st.listaDePersonas[i * st.multB * st.multC + j * st.multC + k])
                        {
                            //Se encontró al menos un infectado

                            //Se evalúa la efectividad del resultado encontrado, con la efectividad del test
                            if (rmd.Next(10000) <= e_test_estandarX100)
                            {
                                //Se evalúa la efectividad del resultado encontrado, con la efectividad de la primera mezcla
                                if (rmd.Next(10000) <= e_mezcla_primera_etapaX100)
                                {
                                    //Se evalúa la efectividad del resultado encontrado, con la efectividad de la segunda mezcla
                                    if (rmd.Next(10000) <= e_mezcla_segunda_etapaX100)
                                    {
                                        q = true;
                                        contador_detectados++;
                                    }
                                }
                            }
                        }
                    }
                    if (q)
                    {
                        //Se tienen que realizar todos los test de la última etapa, para poder identificar los infectados (test individuales, sin mezcla)
                        res += st.multC;
                    }
                }
            }
            
            contador_casos_no_detectados = contador_infectados - contador_detectados;
            contador_casos_reales = contador_infectados;

            return res;
        }

        private double BackgroundProcess_Simulacion(BackgroundWorker bw, DoWorkEventArgs e)
        {
            int progress;
            int sumaCompleta = 0;
            DSimulacionTest st = (DSimulacionTest)e.Argument;
            int contador_casos_no_detectados;
            int contador_casos_reales;
            int total_casos_no_detectados = 0;
            int total_casos_reales = 0;

            promedio_casos_no_detectados = 0;
            promedio_casos_reales = 0;

            for (int i = 0; i < st.nSim; i++)
            {
                //Thread.Sleep(10);
                contador_casos_no_detectados = 0;
                contador_casos_reales = 0;
                int numeroDeTest = IndividualSimulacion(st, ref contador_casos_no_detectados, ref contador_casos_reales);
                total_casos_no_detectados += contador_casos_no_detectados;
                total_casos_reales += contador_casos_reales;
                sumaCompleta += numeroDeTest;

                progress = (int)((i * 100.0) / st.nSim);
                bw.ReportProgress(progress);
                if (bw.CancellationPending)
                {
                    e.Cancel = true;
                    return 0;
                }
            }

            promedio_casos_no_detectados= (double)total_casos_no_detectados / st.nSim;
            promedio_casos_reales= (double)total_casos_reales / st.nSim;
            return (sumaCompleta * 100.0) / st.nSim;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bw = sender as BackgroundWorker;
            e.Result = BackgroundProcess_Simulacion(bw, e);
            if (bw.CancellationPending)
            {
                e.Cancel = true;
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            button_iniciar_simulacion.Enabled = true;
            progressBar1.Visible = false;
            button_cancelar.Visible = false;

            if (e.Cancelled)
            {
                MessageBox.Show("Operación cancelada");
            }
            else if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else
            {
                double nTest = (double)(e.Result) / 100.0;
                int n1 = (int)numericUpDown_primera_etapa.Value;
                int n2 = (int)numericUpDown_segunda_etapa.Value;
                int n3 = (int)numericUpDown_tercera_etapa.Value;
                int nPersonas = n1 * n2 * n3;
                int ahorro = (int)(nPersonas - nTest);
                double eficiencia = (1.0 - (double)((double)nTest / (double)nPersonas)) * 100.0;
                double efectividad = (1.0 - (double)((double)promedio_casos_no_detectados / (double)promedio_casos_reales)) * 100.0;
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Número de test promedio necesarios: " + string.Format("{0:0.00}", nTest));
                sb.AppendLine("Número de personas testeadas: " + nPersonas.ToString());
                sb.AppendLine("Ahorro de test: " + ahorro.ToString());
                sb.AppendLine("Eficiencia:  " + string.Format("{0:0.00}%", eficiencia));
                sb.AppendLine("Promedio de casos positivos no encontrados:  " + string.Format("{0:0.000000}", promedio_casos_no_detectados));
                sb.AppendLine("Efectividad del testeo general:  " + string.Format("{0:0.00}%", efectividad));

                textBox1_resultado.Text = sb.ToString();
                //MessageBox.Show(e.Result.ToString());
                MessageBox.Show("La simulación finalizó correctamente");
            }
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
        }

        private void ActualizaMultiplicacion()
        {
            int n1 = (int)numericUpDown_primera_etapa.Value;
            int n2 = (int)numericUpDown_segunda_etapa.Value;
            int n3 = (int)numericUpDown_tercera_etapa.Value;
            int mult = n1 * n2 * n3;
            label_multiplicacion.Text = mult.ToString();
        }

        private void numericUpDown_primera_etapa_ValueChanged(object sender, EventArgs e)
        {
            ActualizaMultiplicacion();
        }

        private void numericUpDown_segunda_etapa_ValueChanged(object sender, EventArgs e)
        {
            ActualizaMultiplicacion();
        }

        private void numericUpDown_tercera_etapa_ValueChanged(object sender, EventArgs e)
        {
            ActualizaMultiplicacion();
        }
    }
}
