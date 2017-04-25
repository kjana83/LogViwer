using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Text;

namespace LogViewer
{
    public partial class NLogViewer : Form
    {
        public DataTable logTable;   
        public NLogViewer()
        {
            InitializeComponent();
        }


        private void NLogViewer_Load(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loadFile_Click(object sender, EventArgs e)
        {
            openFile.ShowDialog();
            
            fileName.Text = openFile.FileName;
            ReadFile(fileName.Text);
            refresh.Visible = true;           
        }

        private void ReadFile(string filename)
        {
            var lines = File.ReadAllLines(filename);
            StringBuilder jsonString =new StringBuilder( "[");
            foreach (var line in lines)
            {
                jsonString.Append(line.Substring(line.IndexOf(@"{")) + ",");
            }
            
            List<Log> logList = JsonConvert.DeserializeObject<List<Log>>(jsonString.ToString().TrimEnd(new char[]{',' }) + "]");
            logTable = logList.ToDataTable<Log>();

            logGrid.DataSource = logTable;
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            ReadFile(fileName.Text);
        }
    }
}
