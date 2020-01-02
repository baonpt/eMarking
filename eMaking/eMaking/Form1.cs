using System;
using ExcelDataReader;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace eMaking
{
    public partial class Home : Form
    {
        List<string> resultFileName = new List<string>();
        List<string> answerFileName = new List<string>();
        public Home()
        {
            InitializeComponent();
        }

        private void addResult_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel Workbook 97-2003|*.xls", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    results.Items.Add(formatFileName(ofd.FileName));
                    resultFileName.Add(ofd.FileName);
                }
            }
        }

        private string formatFileName(string fileName)
        {
            string slash = @"\";
            int lastSlash = fileName.LastIndexOf(slash);
            int dot = fileName.LastIndexOf(".");
            string newName = fileName.Substring(lastSlash + 1).Replace(".xlsx", "").Replace(".xls","");
            return newName;
        }

        private void addAnswer_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel Workbook 97-2003|*.xls", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    answers.Items.Add(formatFileName(ofd.FileName));
                    answerFileName.Add(ofd.FileName);
                }
            }
        }

        private void results_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = results.SelectedIndex;
            if (index >= 0)
            {
                string fileName = resultFileName[index];
                displayExcelFile(fileName);
            }
        }

        private void displayExcelFile(string fileName)
        {
            using (var stream = File.Open(fileName, FileMode.Open, FileAccess.Read))
            {
                IExcelDataReader reader;
                reader = ExcelReaderFactory.CreateOpenXmlReader(stream);

                DataSet ds = reader.AsDataSet(new ExcelDataSetConfiguration()
                {
                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                    {
                        UseHeaderRow = true
                    }
                });
                
                excelView.DataSource = ds.Tables[0];
                label1.Text = excelView.Rows.Count.ToString();
            }
        }

        private DataGridView readExcelFile(string fileName)
        {
            DataGridView dgv = new DataGridView();
            using (var stream = File.Open(fileName, FileMode.Open, FileAccess.Read))
            {
                IExcelDataReader reader;
                reader = ExcelReaderFactory.CreateOpenXmlReader(stream);

                DataSet ds = reader.AsDataSet(new ExcelDataSetConfiguration()
                {
                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                    {
                        UseHeaderRow = true
                    }
                });

                dgv.DataSource = ds.Tables[0];
                
            }
            return dgv;
        }

        private void answers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = answers.SelectedIndex;
            if (index >= 0)
            {
                string fileName = answerFileName[index];
                displayExcelFile(fileName);
            }
        }

        private string formatStudentID(string fileName)
        {
            string slash = @"\";
            int lastSlash = fileName.LastIndexOf(slash);
            int dash = fileName.LastIndexOf("-");
            string newName = fileName.Substring(lastSlash + 1);
            newName = newName.Substring(0, countCharacter(newName, '-'));
            return newName;
        }

        private string formatExamID(string fileName)
        {
            string dash = "-";
            int lastSlash = fileName.LastIndexOf(dash);
            string newName = fileName.Substring(lastSlash + 1).Replace(".xlsx", "").Replace(".xls", "");
            return newName;
        }

        private int countCharacter(string fileName, char lastCharacter)
        {
            int count = 0;
            foreach ( char str in fileName)
            {
                if (str == lastCharacter) { break; }
                count++;
            }
            return count;
        }

        private double MARKING(string fileName)
        {
            string resultName = "";
            foreach (string name in resultFileName)
            {
                if (name.Contains(formatExamID(fileName)))
                {
                    resultName = name;
                }
            }

            int countWrong = 0;

            using (var stream = File.Open(fileName, FileMode.Open, FileAccess.Read))
            {
                IExcelDataReader reader;
                reader = ExcelReaderFactory.CreateOpenXmlReader(stream);

                DataSet ds = reader.AsDataSet(new ExcelDataSetConfiguration()
                {
                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                    {
                        UseHeaderRow = true
                    }
                });

                answerView.DataSource = ds.Tables[0];
            }

            using (var stream = File.Open(resultName, FileMode.Open, FileAccess.Read))
            {
                IExcelDataReader reader;
                reader = ExcelReaderFactory.CreateOpenXmlReader(stream);

                DataSet ds = reader.AsDataSet(new ExcelDataSetConfiguration()
                {
                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                    {
                        UseHeaderRow = true
                    }
                });

                resultView.DataSource = ds.Tables[0];
            }
            
            int rows = resultView.Rows.Count;
            int columns = resultView.Columns.Count;

            for(int i=0;i<rows-1;i++)
            {
                for(int j=0;j<columns;j++)
                {
                    if ( !answerView.Rows[i].Cells[j].Value.ToString().Equals(resultView.Rows[i].Cells[j].Value.ToString()))
                    {
                        countWrong++;
                    }
                }
            }
            double score = (double)(rows - 1 - countWrong)*10 / (double)(rows-1);
            return score;
        }

        private void marking_Click(object sender, EventArgs e)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add("MÃ SINH VIÊN");
            dt.Columns.Add("MÃ ĐỀ");
            dt.Columns.Add("ĐIỂM");
            dt.Columns.Add("GHI CHÚ");

            List<Marking> markings = new List<Marking>();

            foreach ( string fileName in answerFileName)
            {
                Marking marking = new Marking();
                marking.studentID = formatStudentID(fileName);
                marking.examID = formatExamID(fileName);
                marking.note = "";
                marking.score = MARKING(fileName);
                markings.Add(marking);
            }

            foreach ( Marking mark in markings)
            {
                dt.Rows.Add(mark.studentID, mark.examID, mark.score, mark.note);
            }

            excelView.DataSource = dt.DefaultView;
        }

        private void saveExcel_Click(object sender, EventArgs e)
        {
            string fileName = "";
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel Workbook 97-2003|*.xls", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    fileName = sfd.FileName;
                }

                Application app = new Application();
                app.Application.Workbooks.Add(Type.Missing);
                app.Columns.ColumnWidth = 15;

                for (int i = 1; i < excelView.Columns.Count + 1; i++) { app.Cells[1, i] = excelView.Columns[i - 1].HeaderText; }
                for (int i = 0; i < excelView.Rows.Count; i++)
                {
                    for (int j = 0; j < excelView.Columns.Count; j++)
                    {
                        if (excelView.Rows[i].Cells[j].Value != null) { app.Cells[i + 2, j + 1] = excelView.Rows[i].Cells[j].Value.ToString(); }
                    }
                }

                app.ActiveWorkbook.SaveCopyAs(fileName);
                app.ActiveWorkbook.Saved = true;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
