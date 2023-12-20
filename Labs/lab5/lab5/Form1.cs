using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        private List<string> wordList;
        private Stopwatch stopwatch;
        
        public Form1()
        {
            InitializeComponent();
            wordList = new List<string>();
            stopwatch = new Stopwatch();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Текстовый|*.txt",
                Title = "Выберете текстовый файл"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                LoadFile(filePath);
            }
        }

        private void LoadFile(string filePath)
        {
            try
            {
                stopwatch.Start();
                string fileContent = File.ReadAllText(filePath);
                wordList = fileContent.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                stopwatch.Stop();
                loadTimeTextBox.Text = $"{stopwatch.ElapsedMilliseconds} ms";
                stopwatch.Reset();
                UpdateWordListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = searchTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(searchTerm))
            {
                SearchWord(searchTerm);
            }
        }

        private void SearchWord(string searchTerm)
        {
            try
            {
                stopwatch.Start();
                List<string> foundWords = wordList.Where(word => word.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
                stopwatch.Stop();
                searchTimeTextBox.Text = $"{stopwatch.ElapsedMilliseconds} ms";
                stopwatch.Reset();
                resultsListBox.BeginUpdate();
                resultsListBox.Items.Clear();
                foundWords.ForEach(word => resultsListBox.Items.Add(word));
                resultsListBox.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка поиска: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateWordListBox()
        {
            wordListBox.BeginUpdate();
            wordListBox.Items.Clear();
            wordList.ForEach(word => wordListBox.Items.Add(word));
            wordListBox.EndUpdate();
        }
    }
}