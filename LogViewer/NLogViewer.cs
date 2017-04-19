using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

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
            string jsonString = string.Format("[{0}]", string.Join(",", lines));
            List<Log> logList = JsonConvert.DeserializeObject<List<Log>>(jsonString);
            logTable = logList.ToDataTable<Log>();

            logGrid.DataSource = logTable;
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            ReadFile(fileName.Text);
        }
    }
}
