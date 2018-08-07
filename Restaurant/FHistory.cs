using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class FHistory : Form
    {
        public string HistoryDir { get; }


        public FHistory(string historyDir)
        {
            if (String.IsNullOrWhiteSpace(historyDir))
                throw new ArgumentNullException("historyDir", "FHistory");

            InitializeComponent();
            this.HistoryDir = historyDir;
        }


        private void FHistory_Load(object sender, EventArgs e)
        {
            LoadHistoryFiles();
        }


        private void LoadHistoryFiles()
        {
            if (!Directory.Exists(HistoryDir))
                Directory.CreateDirectory(HistoryDir);

            var files = Directory.GetFiles(HistoryDir);
            foreach (var file in files)
                dgFiles.Rows.Add(Path.GetFileName(file));
        }


        private void dgFiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            string fileName = dgFiles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            string filePath = Path.Combine(HistoryDir, fileName);
            LoadFileContent(filePath);
        }


        private void LoadFileContent(string filePath)
        {
            IHistoryManagement history = new HistoryXML(filePath);
            eText.Text = history.Load();
        }
    }
}
