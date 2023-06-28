using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.UI.WebControls;
using WindowsFormsApp1.Modelo;
using WindowsFormsApp1.Vista;
using System.Threading;

namespace WindowsFormsApp1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            ArrayList lista = new ArrayList();      
            ArrayList recursos = new ArrayList();
            List<string> ejec = new List<string>();
            List<string> Nuevo = new List<string>();
            List<string> Terminado = new List<string>();
            List<string> Bloqueado = new List<string>();
            string[,] Datos = new string[10, 6];
            Random num = new Random();
            String rec = "";
            int cont = 0, acum = 0, tamaño1 = 0, cont1 = 0, aux2 = 0, contrec = 0, aux1 = 0, aux5 = 0, aux6 = 0, aux7 = 0, cont2 = 0,cont3=0;
            int aux=0, aux3=0;
            string auxs = "", auxt = "", auxu = "", auxv = "", auxr = "";
            int contproc = 0;
            Recursos recur = new Recursos();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 q = new Form1();
            //Form3 u = new Form3();
            //Form4 t = new Form4();
            //Form5 v = new Form5();
            //Form6 w = new Form6();
            q.getlblproc0().Visible = false;
            q.getlblproc().Visible = false;
            q.getlblproc1().Visible = false;
            q.getlbltam0().Visible = false;
            q.getlbltam().Visible = false;
            q.getlbltam1().Visible = false;
            
            q.getRec().Enabled = false;
            q.getButton().Click += (s, e) =>
            {
                q.getProcesos().Text = "";
                Form2 r = new Form2();
                r.Show();
                r.getIdP().Enabled = false;
                r.getInfoVer().Visible = false;
                r.getButton1().Visible = false;
                cont++;
                r.getIdP().Text = "" + cont;
                r.getVerificar().Click += (_s, _e) =>
                {
                    int x = int.Parse(r.getTam().Text);
                    int y = 1000;
                    if ((x % 10 == 0) && (x <= 150))
                    {
                        r.getInfoVer().Visible = false;
                        r.getButton1().Visible = true;
                        r.getButton1().Click += (s_, e_) =>
                        {

                            q.getlbltam().Visible = true;
                            q.getlbltam0().Visible = true;
                            q.getlbltam1().Visible = true;
                            String nom = r.getNom().Text;
                            int tamaño = int.Parse(r.getTam().Text);
                            acum += tamaño;
                            tamaño1 = 1000 - acum;
                            Proceso p = new Proceso(cont, nom, tamaño, "Nuevo");
                            contproc++;
                            q.getCantP().Text = contproc + "";
                            lista.Add(p);
                            tamaño = 0;
                            q.getlbltam().Text = "" + tamaño1;
                            aux6 = r.getRec().CheckedItems.Count;
                            for (int k = 0; k < aux6; k++)
                            {
                                if (rec != "")
                                {
                                    rec += r.getRec().CheckedItems[k].ToString() + ",";
                                }
                                else
                                {
                                    rec += r.getRec().CheckedItems[k].ToString() + ",";

                                }
                            }
                            if (rec.Contains("R1"))
                            {
                                recur.R1 = 0;
                            }
                            if (rec.Contains("R2"))
                            {
                                recur.R2 = 0;
                            }
                            if (rec.Contains("R3"))
                            {
                                recur.R3 = 0;
                            }
                            if (rec.Contains("R4"))
                            {
                                recur.R4 = 0;
                            }
                            if (rec.Contains("R5"))
                            {
                                recur.R5 = 0;
                            }
                            if (rec.Contains("R6"))
                            {
                                recur.R6 = 0;

                            }

                            recursos.Add(rec);
                            Nuevo.Add(nom);
                            r.Dispose();
                            q.getProcesos().Text += " ";
                            q.getNuevo().Text = "";

                            for (int i = 0; i < lista.Count; i++)
                            {
                                Proceso pr = (Proceso)lista[i];
                                q.getProcesos().Text += pr.getId() + "\t";
                                q.getProcesos().Text += pr.getNom() + "\t" + "\t";
                                q.getProcesos().Text += pr.getTam() + " Kb" + "\t" + "\t";
                                q.getProcesos().Text += pr.getEstadoI() + "\t" + "\t";
                                q.getProcesos().Text += "       " + recursos[i];
                                q.getProcesos().Text += "\r\n";
                                q.getNuevo().Text += "\t" + Nuevo[i] + "\r\n";
                                Datos[i, 0] = pr.getId().ToString();
                                Datos[i, 1] = pr.getNom();
                                Datos[i, 2] = pr.getTam().ToString();
                                Datos[i, 3] = pr.getEstadoI();
                                Datos[i, 4] = recursos[i].ToString();
                                Datos[i, 5] = aux6.ToString();

                            }
                            string FL;
                            q.getRec().Text = "";
                            q.getRec().Text = "\r\n";
                            FL = Recursoutil(recur.R1);
                            q.getRec().Text += "\t" + "R1 ->" + FL + "\r\n";
                            FL = Recursoutil(recur.R2);
                            q.getRec().Text += "\t" + "R2 ->" + FL + "\r\n";
                            FL = Recursoutil(recur.R3);
                            q.getRec().Text += "\t" + "R3 ->" + FL + "\r\n";
                            FL = Recursoutil(recur.R4);
                            q.getRec().Text += "\t" + "R4 ->" + FL + "\r\n";
                            FL = Recursoutil(recur.R5);
                            q.getRec().Text += "\t" + "R5 ->" + FL + "\r\n";
                            FL = Recursoutil(recur.R6);
                            q.getRec().Text += "\t" + "R6 ->" + FL;
                            aux6 = 0;
                        };
                        rec = "";
                    }
                    else
                    {
                        r.getInfoVer().Visible = true;
                        r.getNom().Text = "";
                        r.getTam().Text = "";
                        for (int j = 0; j < r.getRec().Items.Count; j++)
                        {
                            r.getRec().SetItemChecked(j, false);
                        }

                    }
                };

            };
            q.getEjec().Click += (s, e) =>
            {
                //Thread.Sleep(5000);
                if (lista.Count == 0)
                {
                    MessageBox.Show("Por favor, cree un proceso antes de Continuar", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    q.getEjec().Visible = false;
                    q.getButton().Visible = false;
                    q.getProcesos().Text = "";
                    q.getListo().Text = q.getNuevo().Text;
                    q.getNuevo().Text = "";
                    for (int i = 0; i < lista.Count; i++)
                    {
                        Datos[i, 3] = "Listo";
                        //Thread.Sleep(5000);
                        q.getProcesos().Text += Datos[i, 0] + "\t";
                        q.getProcesos().Text += Datos[i, 1] + "\t" + "\t";
                        q.getProcesos().Text += Datos[i, 2] + "kb" + "\t" + "\t";
                        q.getProcesos().Text += Datos[i, 3] + "\t" + "\t";
                        q.getProcesos().Text += "\t" + "\t" + Datos[i, 4];
                        q.getProcesos().Text += "\r\n";

                    }
                    /*q.getListo().Enabled = true;
                    q.getBloq().Enabled = true;
                    q.getEjecu().Enabled = true;
                    q.getTerminado().Enabled = true;*/
                    //Thread.Sleep(2000);   
                    do
                    {
                        if (q.getEjecu().Text == null)
                        {
                            string[] vo;
                           
                            if (Nuevo.Count != 0)
                            {
                                auxs = Nuevo.ElementAt(0);
                                for (int k = 0; k < lista.Count; k++)
                                {
                                    //Thread.Sleep(1000);
                                    if (auxs.Equals(Datos[k, 1]))//este if para que es?
                                    {
                                        aux = k;

                                        auxr = Datos[aux, 4];
                                    }
                                }
                                vo = auxr.Split(',');
                                Nuevo.RemoveAt(0);
                                if (vo.Contains("R1") && recur.R1 == 0)
                                {
                                    cont2 ++;
                                }
                                if (vo.Contains("R2") && recur.R2 == 0)
                                {
                                    cont2 ++;
                                }
                                if (vo.Contains("R3") && recur.R3 == 0)
                                {
                                    cont2 ++;
                                }
                                if (vo.Contains("R4") && recur.R4 == 0)
                                {
                                    cont2 ++;
                                }
                                if (vo.Contains("R5") && recur.R5 == 0)
                                {
                                    cont2 ++;
                                }
                                if (vo.Contains("R6") && recur.R6 == 0)
                                {
                                    cont2 ++;
                                }
                                //q.getNuevo().Text = auxr;
                                
                                if (cont2.Equals(int.Parse(Datos[aux, 5])))
                                {
                                  //Thread.Sleep(1000);
                                    q.getEjecu().Text = "\t" + auxs;//limpia caja
                                    q.getlblproc0().Visible = true;
                                    q.getlblproc().Visible = true;
                                    q.getlblproc1().Visible = true;
                                    q.getlblproc().Text = auxs;
                                    q.getProcesos().Text = "";
                                    ejec.Add(auxs);
                                    MessageBox.Show("Ejecutando...", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Datos.SetValue("Ejecutando", aux, 3);
                                    cont1 = int.Parse(Datos[aux, 2]) - 10;
                                    Datos.SetValue(cont1.ToString(), aux, 2);
                                    q.getlblproc1().Text = "=" + cont1 + " kb";
                                    aux1 = tamaño1 + 10;
                                    q.getlbltam().Text = aux1 + "";
                                    aux1 = 0;
                                    //Nuevo.RemoveAt(0);
                                    q.getListo().Text = "";
                                    string[] va;
                                    va = Datos[aux, 4].Split(',');
                                    if (cont1 == 0)
                                    {
                                      Thread.Sleep(2000);
                                        Datos.SetValue("Terminado", aux, 3);
                                        Terminado.Add(auxs);

                                        if (va.Contains("R1"))
                                        {
                                            recur.R1 = 1;
                                        }
                                        if (va.Contains("R2"))
                                        {
                                            recur.R2 = 1;
                                        }
                                        if (va.Contains("R3"))
                                        {
                                            recur.R3 = 1;
                                        }
                                        if (va.Contains("R4"))
                                        {
                                            recur.R4 = 1;
                                        }
                                        if (va.Contains("R5"))
                                        {
                                            recur.R5 = 1;
                                        }
                                        if (va.Contains("R6"))
                                        {
                                            recur.R6 = 1;
                                        }
                                        string FL2;
                                        q.getRec().Text = "";
                                        q.getRec().Text = "\r\n";
                                        FL2 = Recursoutil(recur.R1);
                                        q.getRec().Text += "\t" + "R1 ->" + FL2 + "\r\n";
                                        FL2 = Recursoutil(recur.R2);
                                        q.getRec().Text += "\t" + "R2 ->" + FL2 + "\r\n";
                                        FL2 = Recursoutil(recur.R3);
                                        q.getRec().Text += "\t" + "R3 ->" + FL2 + "\r\n";
                                        FL2 = Recursoutil(recur.R4);
                                        q.getRec().Text += "\t" + "R4 ->" + FL2 + "\r\n";
                                        FL2 = Recursoutil(recur.R5);
                                        q.getRec().Text += "\t" + "R5 ->" + FL2 + "\r\n";
                                        FL2 = Recursoutil(recur.R6);
                                        q.getRec().Text += "\t" + "R6 ->" + FL2;
                                        q.getTerminado().Text = "";
                                        q.getEjecu().Text = "";
                                        for (int i = 0; i < Terminado.Count; i++)
                                        {
                                            Thread.Sleep(1000);
                                            q.getTerminado().Text += "\t" + Terminado[i] + "\n";
                                        }
                                        q.getProcesos().Text = "";
                                        cont3 = int.Parse(q.getCantP().Text) - 1;
                                        q.getCantP().Text = cont3.ToString();
                                        for (int j = 0; j < lista.Count; j++)
                                        {
                                            Thread.Sleep(1000);
                                            q.getProcesos().Text += Datos[j, 0] + "\t";
                                            q.getProcesos().Text += Datos[j, 1] + "\t" + "\t";
                                            q.getProcesos().Text += Datos[j, 2] + "kb" + "\t" + "\t";
                                            q.getProcesos().Text += Datos[j, 3] + "\t";
                                            q.getProcesos().Text += "\t" + Datos[j, 4];
                                            q.getProcesos().Text += "\r\n";
                                        }                                        
                                        
                                        MessageBox.Show("El proceso ha terminado", "PROCESO TERMINADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        contproc--;
                                        ejec.RemoveAt(0);
                                        aux3 = 0;                                        
                                        auxt = "";
                                        auxs = "";
                                    }
                                    else
                                    {
                                        //Thread.Sleep(2000);
                                        q.getRand().Text = "";
                                        int nran = num.Next(0, 1);
                                        q.getRand().Text = nran + "";
                                        if (nran == 1)
                                        {
                                            q.getEjecu().Text = "";                                            

                                            if (va.Contains("R1"))
                                            {
                                                recur.R1 = 1;
                                            }
                                            if (va.Contains("R2"))
                                            {
                                                recur.R2 = 1;
                                            }
                                            if (va.Contains("R3"))
                                            {
                                                recur.R3 = 1;
                                            }
                                            if (va.Contains("R4"))
                                            {
                                                recur.R4 = 1;
                                            }
                                            if (va.Contains("R5"))
                                            {
                                                recur.R5 = 1;
                                            }
                                            if (va.Contains("R6"))
                                            {
                                                recur.R6 = 1;
                                            }
                                            string FL1;
                                            q.getRec().Text = "";
                                            q.getRec().Text = "\r\n";
                                            FL1 = Recursoutil(recur.R1);
                                            q.getRec().Text += "\t" + "R1 ->" + FL1 + "\r\n";
                                            FL1 = Recursoutil(recur.R2);
                                            q.getRec().Text += "\t" + "R2 ->" + FL1 + "\r\n";
                                            FL1 = Recursoutil(recur.R3);
                                            q.getRec().Text += "\t" + "R3 ->" + FL1 + "\r\n";
                                            FL1 = Recursoutil(recur.R4);
                                            q.getRec().Text += "\t" + "R4 ->" + FL1 + "\r\n";
                                            FL1 = Recursoutil(recur.R5);
                                            q.getRec().Text += "\t" + "R5 ->" + FL1 + "\r\n";
                                            FL1 = Recursoutil(recur.R6);
                                            q.getRec().Text += "\t" + "R6 ->" + FL1;
                                           // Thread.Sleep(2000);
                                            q.getNuevo().Text = "";
                                            Nuevo.Add(auxs);
                                            Datos.SetValue("Listo", aux, 3);
                                            for (int i = 0; i < Nuevo.Count; i++)
                                            {
                                                q.getListo().Text = "\t" + Nuevo[i] + "\n";
                                            }
                                            //Thread.Sleep(1000);
                                            for (int i = 0; i < lista.Count; i++)
                                            {                                                                                              
                                                q.getProcesos().Text += Datos[i, 0] + "\t";
                                                q.getProcesos().Text += Datos[i, 1] + "\t" + "\t";
                                                q.getProcesos().Text += Datos[i, 2] + "kb" + "\t" + "\t";
                                                q.getProcesos().Text += Datos[i, 3] + "\t";
                                                q.getProcesos().Text += "\t" + Datos[i, 4];
                                                q.getProcesos().Text += "\r\n";
                                            }
                                            ejec.RemoveAt(0);
                                        }
                                        else
                                        {
                                            //pasa a la cola de listo
                                            q.getListo().Text = "";
                                            Nuevo.Add(auxs);
                                            q.getEjecu().Text = "";
                                            //Thread.Sleep(2000);
                                            for (int i = 0; i < Nuevo.Count; i++)
                                            {
                                               // Thread.Sleep(1000);
                                                q.getListo().Text = "\t" + Nuevo[i] + "\n";
                                            }
                                            q.getProcesos().Text = "";
                                            Datos.SetValue("Listo", aux, 3);
                                            for (int i = 0; i < lista.Count; i++)
                                            {
                                              //  Thread.Sleep(1000);
                                                q.getProcesos().Text += Datos[i, 0] + "\t";
                                                q.getProcesos().Text += Datos[i, 1] + "\t" + "\t";
                                                q.getProcesos().Text += Datos[i, 2] + "kb" + "\t" + "\t";
                                                q.getProcesos().Text += Datos[i, 3] + "\t";
                                                q.getProcesos().Text += "\t" + Datos[i, 4];
                                                q.getProcesos().Text += "\r\n";
                                            }
                                            ejec.RemoveAt(0);
                                        }
                                    }
                                    auxs = "";
                                    aux = 0;
                                }
                                else
                                {
                                    //MessageBox.Show("El Proceso requiere de recursos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    //Thread.Sleep(3000);                                     
                                    ejec.Add(auxs);
                                    Datos.SetValue("Bloqueado", aux, 3);
                                    //Nuevo.RemoveAt(0);
                                    q.getEjecu().Text = "";
                                    q.getEjecu().Text = auxs;
                                    q.getBloq().Text = "";
                                    for (int l = 0; l < Bloqueado.Count; l++)
                                    {
                                        //Thread.Sleep(2000);
                                        q.getBloq().Text += "\t" + Bloqueado[l] + "\n";
                                    }
                                    q.getEjecu().Text = "";
                                    q.getListo().Text = "";
                                    for (int l = 0; l < Nuevo.Count; l++)
                                    {
                                        //Thread.Sleep(2000);
                                        q.getListo().Text += "\t" + Nuevo[l] + "\n";
                                    }
                                    q.getProcesos().Text = "";
                                    for(int l = 0; l < lista.Count; l++)
                                    {
                                        q.getProcesos().Text += Datos[l, 0] + "\t";
                                        q.getProcesos().Text += Datos[l, 1] + "\t" + "\t";
                                        q.getProcesos().Text += Datos[l, 2] + "kb" + "\t" + "\t";
                                        q.getProcesos().Text += Datos[l, 3] + "\t";
                                        q.getProcesos().Text += "\t" + Datos[l, 4];
                                        q.getProcesos().Text += "\r\n";
                                    }
                                }
                                cont2 = 0;
                                
                            }
                        }
                        if (q.getBloq().Text!=null)
                            {
                                string[] no;
                                 auxu = Bloqueado.ElementAt(0);
                                Bloqueado.RemoveAt(0);
                            contrec = 0;
                                for (int i = 0; i < lista.Count; i++)
                                {
                                //Thread.Sleep(1000);  
                                    if (auxu.Equals(Datos[i, 1]))
                                    {
                                        aux5 = i;
                                        auxv = Datos[aux5, 4];
                                    }

                                }
                                no = auxv.Split(',');
                                
                                if (no.Contains("R1") && recur.R1 == 1)
                                {
                                    contrec++;
                                    recur.R1 = 0;
                                    // Datos.SetValue("R1", aux5, 4);
                                }
                                if (no.Contains("R2") && recur.R2 == 1)
                                {
                                    contrec++;
                                    recur.R2 = 0;
                                    // Datos.SetValue("R2", aux5, 4);
                                }
                                if (no.Contains("R3") && recur.R3 == 1)
                                {
                                    contrec++;
                                    recur.R3 = 0;
                                    // Datos.SetValue("R3", aux5, 4);
                                }
                                if (no.Contains("R4") && recur.R4 == 1)
                                {
                                    contrec++;
                                    recur.R4 = 0;
                                    // Datos.SetValue("R4", aux5, 4);
                                }
                                if (no.Contains("R5") && recur.R5 == 1)
                                {
                                    contrec++;
                                    recur.R5 = 0;
                                    // Datos.SetValue("R5", aux5, 4);
                                }
                                if (no.Contains("R6") && recur.R6 == 1)
                                {
                                    contrec++;
                                    recur.R6 = 0;
                                    //Datos.SetValue("R6", aux5, 4);
                                }
                            //Thread.Sleep(2000);
                                
                                string FL;
                                q.getRec().Text = "";
                                q.getRec().Text = "\r\n";
                                FL = Recursoutil(recur.R1);
                                q.getRec().Text += "\t" + "R1 ->" + FL + "\r\n";
                                FL = Recursoutil(recur.R2);
                                q.getRec().Text += "\t" + "R2 ->" + FL + "\r\n";
                                FL = Recursoutil(recur.R3);
                                q.getRec().Text += "\t" + "R3 ->" + FL + "\r\n";
                                FL = Recursoutil(recur.R4);
                                q.getRec().Text += "\t" + "R4 ->" + FL + "\r\n";
                                FL = Recursoutil(recur.R5);
                                q.getRec().Text += "\t" + "R5 ->" + FL + "\r\n";
                                FL = Recursoutil(recur.R6);
                                q.getRec().Text += "\t" + "R6 ->" + FL;
                                q.getNuevo().Text = contrec + "";
                                if (contrec.Equals(int.Parse(Datos[aux5, 5])))
                                    {

                                    q.getListo().Text = "";
                                    Nuevo.Add(auxu);
                                    Datos.SetValue("Listo", aux5, 3);
                                    q.getBloq().Text = "";
                                    for(int j = 0; j < Bloqueado.Count; j++)
                                    {
                                    //Thread.Sleep(1000);
                                        q.getBloq().Text += "\t" + Bloqueado[j] + "\n";
                                    }
                                    for (int i = 0; i < Nuevo.Count; i++)
                                    {
                                       // Thread.Sleep(1000);
                                        q.getListo().Text += " \t" + Nuevo[i] + "\n";
                                    }
                                    for (int i = 0; i < lista.Count; i++)
                                    {
                                        //Thread.Sleep(1000);
                                        q.getProcesos().Text += Datos[i, 0] + "\t";
                                        q.getProcesos().Text += Datos[i, 1] + "\t" + "\t";
                                        q.getProcesos().Text += Datos[i, 2] + "kb" + "\t" + "\t";
                                        q.getProcesos().Text += Datos[i, 3] + "\t";
                                        q.getProcesos().Text += "\t" + Datos[i, 4];
                                        q.getProcesos().Text += "\r\n";
                                    }
                                }
                                //Bloqueado.RemoveAt(0);
                                auxv = "";
                                
                                contrec = 0;
                            }
                            
                        
                    } while (0!=contproc);
                    MessageBox.Show("Programa terminado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Console.Write("Programa terminado");
                }

                
            };

            Application.Run(q);
        }

        /*public static void eliminarFila(string[,] info,int num)
        {
            for (int i = 0; i < num; i++)
            {
                info[i] = info[i + 1]; //movemos el resto de filas a la posición anterior
            }
            info[num - 1,0] = null; //la última posición queda vacía
        }*/

        public static String Recursoutil(int a)
        {
            string c;
            if (a == 1)
            {
                c = "Libre";
            }
            else
            {
                c = "Ocupado";
            }

            return c;
        }

    }

}

