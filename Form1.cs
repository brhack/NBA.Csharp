using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        DataTable t = new DataTable();
        DataTable a = new DataTable();
        DataTable r = new DataTable();
        DataTable f = new DataTable();

        bool existe = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            puntos();
            asistencias();
            rebotes();
            faltas();
            limpiar();
            suma();
           gvpuntos.Sort(gvpuntos.Columns[5], ListSortDirection.Descending);
           gvasisten.Sort(gvasisten.Columns[5], ListSortDirection.Descending);
           gvfaltas.Sort(gvfaltas.Columns[5], ListSortDirection.Descending);
           gvrebotes.Sort(gvrebotes.Columns[5], ListSortDirection.Descending);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t.Columns.Add("nombre", typeof(string));
            t.Columns.Add("1° cuarto", typeof(string));
            t.Columns.Add("2° cuarto", typeof(string));
            t.Columns.Add("3° cuarto", typeof(string));
            t.Columns.Add("4° cuarto", typeof(string));
            t.Columns.Add("total puntos", typeof(Int32));
            a.Columns.Add("nombre", typeof(string));
            a.Columns.Add("1° cuarto", typeof(string));
            a.Columns.Add("2° cuarto", typeof(string));
            a.Columns.Add("3° cuarto", typeof(string));
            a.Columns.Add("4° cuarto", typeof(string));
            a.Columns.Add("total asistencias", typeof(Int32));
            r.Columns.Add("nombre", typeof(string));
            r.Columns.Add("1° cuarto", typeof(string));
            r.Columns.Add("2° cuarto", typeof(string));
            r.Columns.Add("3° cuarto", typeof(string));
            r.Columns.Add("4° cuarto", typeof(string));
            r.Columns.Add("total rebotes", typeof(Int32));
            f.Columns.Add("nombre", typeof(string));
            f.Columns.Add("1° cuarto", typeof(string));
            f.Columns.Add("2° cuarto", typeof(string));
            f.Columns.Add("3° cuarto", typeof(string));
            f.Columns.Add("4° cuarto", typeof(string));
            f.Columns.Add("total faltas", typeof(Int32));
            


        }
        
        public void puntos()
        {
            if (nom.Text == "" || pun1.Text == "" || pun2.Text == "" || pun3.Text == "" || pun4.Text == "")
            {
                MessageBox.Show(" llena los campos puntos ");

            }
            else
            {
                if (t.Rows.Count > 0)
                {
                    for (int i = 0; i < t.Rows.Count; i++)
                    {
                        string Nombre;
                        Nombre = gvpuntos[1, i].Value.ToString();
                        if (Nombre == nom.Text)
                        {
                            existe = true;
                        }
                    }
                }
                if (existe == false)
                {
                    DataRow r = t.NewRow();
                    r[0] = nom.Text;
                    r[1] = pun1.Text;
                    r[2] = pun2.Text;
                    r[3] = pun3.Text;
                    r[4] = pun4.Text;
                    r[5] = Convert.ToInt32(pun1.Text) + Convert.ToInt32(pun2.Text) + Convert.ToInt32(pun3.Text) + Convert.ToInt32(pun4.Text);
                    t.Rows.Add(r);
                }
                else
                {
                    MessageBox.Show("USUARIO EXISTENTE");
                    existe = false;
                }
            }
            gvpuntos.DataSource = t;
        }
        
        public void asistencias()
        {
            if (nom.Text == "" || asis1.Text == "" || asis2.Text == "" || asis3.Text == "" || asis4.Text == "")
            {
                MessageBox.Show("llenar los campos de asistencia ");

            }
            else
            {
                if (a.Rows.Count > 0)
                {
                    for (int i = 0; i < a.Rows.Count; i++)
                    {
                        string Asistencia;
                        Asistencia = gvasisten[1, i].Value.ToString();
                        if (Asistencia == nom.Text)
                        {
                            existe = true;
                        }

                    }
                }
            }
            if (existe == false)
            {
                DataRow r2 = a.NewRow();
                r2[0] = nom.Text;
                r2[1] = asis1.Text;
                r2[2] = asis2.Text;
                r2[3] = asis3.Text;
                r2[4] = asis4.Text;
                r2[5] = Convert.ToInt32(asis1.Text) + Convert.ToInt32(asis2.Text) + Convert.ToInt32(asis3.Text) + Convert.ToInt32(asis4.Text);
                a.Rows.Add(r2);


                
            }
            else
            {
                MessageBox.Show("repetido");
                existe = false;
            }
            gvasisten.DataSource = a;
        }
        
        public void rebotes()
        {
            if (nom.Text == "" || Rebo1.Text == "" || rebo2.Text == "" || rebo3.Text == "" || rebo4.Text == "")
            {
                MessageBox.Show("llenar los campos de rebote ");

            }
            else
            {
                if (r.Rows.Count > 0)
                {
                    for (int p = 0; p < r.Rows.Count; p++)
                    {
                        string Rebote;
                        Rebote = gvrebotes[1, p].Value.ToString();
                        if (Rebote == nom.Text)
                        {
                            existe = true;
                        }

                    }
                }
            }
            if (existe == false)
            {
                DataRow r3 = r.NewRow();
                r3[0] = nom.Text;
                r3[1] = Rebo1.Text;
                r3[2] = rebo2.Text;
                r3[3] = rebo3.Text;
                r3[4] = rebo4.Text;
                r3[5] = Convert.ToInt32(Rebo1.Text) + Convert.ToInt32(rebo2.Text) + Convert.ToInt32(rebo3.Text) + Convert.ToInt32(rebo4.Text);
                r.Rows.Add(r3);
            }
            else
            {
                MessageBox.Show("repetido");
                existe = false;
            }
            gvrebotes.DataSource = r;
        }
        
        public void faltas()
        {
            if (nom.Text == "" || fal1.Text == "" || fal2.Text == "" || fal3.Text == "" || fal4.Text == "")
            {
                MessageBox.Show("llenar los campos de faltas ");

            }
            else
            {
                if (f.Rows.Count > 0)
                {
                    for (int l = 0; l < f.Rows.Count; l++)
                    {
                        string Falta;
                        Falta = gvfaltas[1, l].Value.ToString();
                        if (Falta == nom.Text)
                        {
                            existe = true;
                        }
                    }
                }
            }
            if (existe == false)
            {
                DataRow r4 = f.NewRow();
                r4[0] = nom.Text;
                r4[1] = fal1.Text;
                r4[2] = fal2.Text;
                r4[3] = fal3.Text;
                r4[4] = fal4.Text;
                r4[5] = Convert.ToInt32(fal1.Text) + Convert.ToInt32(fal2.Text) + Convert.ToInt32(fal3.Text) + Convert.ToInt32(fal4.Text);
                f.Rows.Add(r4);
            }
            else
            {
                MessageBox.Show("repetido");
                existe = false;
            }
            gvfaltas.DataSource = f;
        }
        
        public void limpiar()
        {
            nom.Clear();
            pun1.Clear();
            pun2.Clear();
            pun3.Clear();
            pun4.Clear();
            Rebo1.Clear();
            rebo2.Clear();
            rebo3.Clear();
            rebo4.Clear();
            asis1.Clear();
            asis2.Clear();
            asis3.Clear();
            asis4.Clear();
            fal1.Clear();
            fal2.Clear();
            fal3.Clear();
            fal4.Clear();
            nom.Focus();
        }
        
        public void promedipuntos()
        {
            int ppuntos = gvpuntos.RowCount;
            double suma = 0, prom = 0;
            for (int i = 0; i < ppuntos; i++)
            {
                suma = suma + Convert.ToDouble(gvpuntos[5, i].Value.ToString());
            }
            prom = suma / 5;

            txtppuntos.Text = prom.ToString();
        }
        
        public void promrebote()
        {
            int prebote = gvrebotes.RowCount;
            double suma = 0;
            for (int i = 0; i < prebote; i++)
            {
                suma = suma + Convert.ToDouble(gvrebotes[5, i].Value.ToString());
            }
            suma = suma / 5;
            txtrebote.Text = suma.ToString();
        }
        
        public void promasistencia()
        {
            int pasistencia = gvasisten.RowCount;
            double suma = 0;
            for (int i = 0; i < pasistencia; i++)
            {
                suma = suma + Convert.ToDouble(gvasisten[5, i].Value.ToString());
            }
            suma = suma / 5;
            txtasistencia.Text = suma.ToString();
        }
        
        public void jugadorpuntos()
        {
            DataGridViewRow row = gvpuntos.Rows[0];
            mpuntos.Text = Convert.ToString(row.Cells[0].Value);
            
        }
        
        public void jugadorrebotes()
        {
            DataGridViewRow row = gvrebotes.Rows[0];
            mrebotes.Text = Convert.ToString(row.Cells[0].Value);
        
        }
        
        public void jugadorasis()
        {
            DataGridViewRow row = gvasisten.Rows[0];
            masis.Text = Convert.ToString(row.Cells[0].Value);
        }

        public void faltero()
        {
            DataGridViewRow row = gvfaltas.Rows[0];
            mfal.Text = Convert.ToString(row.Cells[0].Value);
        }

        public void suma()
        { 
        //sumatoria de la columna total llendo renglon por renglon
            int ppuntos = gvpuntos.RowCount;
                double suma = 0;
            for (int i = 0; i < ppuntos; i++)
            {
                suma = suma + Convert.ToDouble(gvpuntos[5, i].Value.ToString());
            }
            txttotalp.Text = suma.ToString();
}

        private void button2_Click(object sender, EventArgs e)
        {
            jugadorpuntos();
            jugadorrebotes();
            jugadorasis();
            faltero();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            promedipuntos();
            promrebote();
            promasistencia();
        }
        
        private void button3_MouseHover(object sender, EventArgs e)
        {
            Button TB = (Button)sender;
            int VisibleTime = 1000;  //in milliseconds

            ToolTip tt = new ToolTip();
            tt.Show("el promedio se calculo para 5 jugadores si hay mas la suma se va a dividir entre 5 ", TB, 0, 0, VisibleTime);
        }

        private void groupBox1_MouseHover(object sender, EventArgs e)
        {
            GroupBox tb = (GroupBox)sender;
            int VisibleTime = 1000;  //in milliseconds

            ToolTip tt = new ToolTip();
            tt.Show("no dejes cuadros vacios poner 0 ", tb, 410, 10, VisibleTime);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            Button tb = (Button)sender;
            int VisibleTime = 1000;  //in milliseconds

            ToolTip tt = new ToolTip();
            tt.Show(" no aplastar hasta tener datos en la tabla ", tb, 0, 0, VisibleTime);

        }
        }
    }
