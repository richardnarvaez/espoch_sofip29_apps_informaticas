using System;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Windows.Forms;
using Newtonsoft.Json;
using IronXL;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;

namespace synapse
{
    public partial class GenerarForm : Form
    {
        public GenerarForm()
        {
            InitializeComponent();
        }

        List<string> forAll = new List<string>();

        public List<List<string>> ReadExcel(string fileName, string fileExt)
        {
            string conn = string.Empty;

            List<string> aux = new List<string>();
            List<List<string>> horario = new List<List<string>>();
            var items = this.checkedListBox1.Items;

            DataTable dtexcel = new DataTable();
            if (fileExt.CompareTo(".xls") == 0)
                conn = @"provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fileName + ";Extended Properties='Excel 8.0;HRD=Yes;IMEX=1';"; //for below excel 2007  
            else
                conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties='Excel 12.0;HDR=NO';"; //for above excel 2007  
            using (OleDbConnection con = new OleDbConnection(conn))
            {
                try
                {
                    OleDbCommand oleAdpt = new OleDbCommand("select * from [rptHorarioAcademico$]", con); //here we read data from sheet1  
                    using (OleDbDataAdapter da = new OleDbDataAdapter(oleAdpt))
                    {
                        DataTable HeaderColumns = new DataTable();
                        da.SelectCommand = oleAdpt;
                        da.Fill(HeaderColumns);


                        foreach (DataColumn column in HeaderColumns.Columns)
                        {
                            string prueba = HeaderColumns.Rows[18][column.ColumnName].ToString();
                            int num = 0;

                            if (prueba != "" && prueba != "Hora")
                            {

                                for (int i = 19; i <= 38; i++)
                                {

                                   // aux.Clear();
                                    try
                                    {
                                        string valueRow = HeaderColumns.Rows[i][column.ColumnName].ToString();

                                        if (valueRow != "")
                                        {
                                            Debug.WriteLine(items.IndexOf(valueRow) + "--- >>>> " + valueRow);
                                            aux.Add(valueRow);
                                            forAll.Add(valueRow);
                                        }
                                        else
                                        {
                                            aux.Add("Na");
                                        }

                                    }
                                    catch {}
                                }

                                Debug.WriteLine("TAMANO>>>> " + aux.Count());
                                Debug.WriteLine("T>>>> " + aux[0]);
                                horario.Add(aux);
                                aux = new List<string>();
                                //aux = aux.Distinct().ToList();
                                //aux.Clear();
                                num++;
                            }
                            
                        }
                        forAll = forAll.Distinct().ToList();
                        forAll.ForEach(delegate (string a)
                        {
                            items.Add(a);
                        });
                    }
                } catch { }
            }
            
            return horario;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = string.Empty;
            string fileExt = string.Empty;
            OpenFileDialog file = new OpenFileDialog(); //open dialog to choose file  
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK) //if there is a file choosen by the user  
            {
                filePath = file.FileName; //get the path of the file  
                fileExt = System.IO.Path.GetExtension(filePath); //get the file extension  
                if (fileExt.CompareTo(".xls") == 0 || fileExt.CompareTo(".xlsx") == 0)
                {
                    try
                    {
                        
                        List<List<string>> ax = ReadExcel(filePath, fileExt);

                        var bindingList = new System.ComponentModel.BindingList<List<string>>(ax);
                        var source = new BindingSource(bindingList, null);

                        DataTable table = new DataTable();

                        table.Columns.Add("Hora", typeof(string));
                        table.Columns.Add("Lunes", typeof(string));
                        table.Columns.Add("Martes", typeof(string));
                        table.Columns.Add("Miercoles", typeof(string));
                        table.Columns.Add("Jueves", typeof(string));
                        table.Columns.Add("Viernes", typeof(string));
                        table.Columns.Add("Sabado", typeof(string));
                        table.Columns.Add("Domingo", typeof(string));

                        var items = this.checkedListBox1.Items;
                        Debug.WriteLine("Llego>>>>>>>>" +  ax.Count());

                        DataRow dr = table.NewRow();


                        int mm = 0;
                        int mme = 0;
                        ax.ForEach(delegate (List<string> v)
                        {
                            
                            //table.Columns[0].Add(v[0]);
                            //Debug.WriteLine("DENTRO:" + v.Count());
                            v.ForEach(delegate (string a) { 
                                Debug.WriteLine("A: " + a);
                                dr[mm] = a;
                                mm++;
                            });

                            mm = 0;
                            //table.Rows(dr);
                            table.Rows.InsertAt(dr, mme);
                            dr = table.NewRow();
                            mme++;

                        });

                        //table.Rows.Add(v[0]);



                        this.dataGridView1.DataSource = table;

                        //read excel file  
                        //dataGridView1.Visible = true;
                        // dataGridView1.DataSource = dtExcel;
                    }
                    catch (Exception ex) {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Please choose .xls or .xlsx file only.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error); //custom messageBox to show error  
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Acceso main = new Acceso();
            this.Hide();
            main.Show();
        }
    }
}
