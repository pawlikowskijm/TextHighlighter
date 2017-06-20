using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace DocProspector
{
	public partial class TextHighlighter : Form
	{
		public TextHighlighter()
		{
			InitializeComponent();
			backgroundWorker1.DoWork += backgroundWorker1_DoWork;
			backgroundWorker1.WorkerReportsProgress = true;
		}

		private void browse_Click(object sender, EventArgs e)
		{
			DialogResult result = openFileDialog1.ShowDialog();
			if (result == DialogResult.OK)
			{
				path.Text = openFileDialog1.FileName;
				path.BackColor = System.Drawing.Color.White;
			}
		}

		private void prospect_Click(object sender, EventArgs e)
		{
			if (path.Text != "")
			{
				progressBar1.Value = 0;
				startButton.Enabled = false;
				backgroundWorker1.RunWorkerAsync();		
			}

			else
			{
				MessageBox.Show("Choose your text file path.");
				path.BackColor = System.Drawing.Color.Red;
			}
		}

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			var app = new Microsoft.Office.Interop.Word.Application();
			var doc = app.Documents.Open(path.Text);

			string rangeText = doc.Content.Text;
			List<String> wordList = new List<String>() { };
			wordList = rangeText.Split(' ', '.', ':').ToList();
			List<String> multiWordList = new List<String>() { };
			List<String> keyList = new List<String>() { };

			for (int i = 0; i <= wordList.Count - lengthOfPhrases.Value; i++)
			{
				multiWordList.Add("");
				for (int j = 0; j < lengthOfPhrases.Value; j++)
				{
					multiWordList[i] += wordList[i + j] + " ";
				}
			}

			progressBar1.Maximum = multiWordList.Count() + keyList.Count();
			console.Text = "Text is being loaded. Please wait.";

			for (int i = 0; i < multiWordList.Count; i++)
			{
				for (int j = i + 1; j < multiWordList.Count; j++)
				{
					if (multiWordList[i].CompareTo(multiWordList[j]) == 0)
						keyList.Add(multiWordList[i]);

					progressBar1.Maximum = multiWordList.Count() + (10*keyList.Count());
				}
				progressBar1.Value++;
			}

			WordHighliter(doc, keyList);

			doc.Save();
			doc.Close();

			Marshal.ReleaseComObject(doc);
			Marshal.ReleaseComObject(app);
		}

		public void WordHighliter(Microsoft.Office.Interop.Word.Document doc, IEnumerable<string> phrases)
		{
			console.Text = "Highlighting started. Please wait until the MessageBox shows.";
			Microsoft.Office.Interop.Word.Range rng = doc.Content;
			foreach (string phrase in phrases)
			{
				rng = doc.Content;
				Microsoft.Office.Interop.Word.Find find = rng.Find;

				if (checkBox1.Checked)
					find.MatchCase = true;
				else
					find.MatchCase = false;
				find.ClearFormatting();
				find.Text = phrase;
				find.Forward = true;
				find.Wrap = Microsoft.Office.Interop.Word.WdFindWrap.wdFindStop;
				find.Format = false;
				find.MatchWholeWord = true;
				find.MatchWildcards = false;
				find.MatchSoundsLike = false;
				find.MatchAllWordForms = false;
				find.MatchByte = true;

				while (find.Execute())
				{
					Int32 start = rng.Start;

					// ensure that phrase does not start within another word
					if (rng.Start == rng.Words[1].Start)
					{
						rng.HighlightColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdYellow;
					}

				}
				progressBar1.Value += 10;

			}
			MessageBox.Show("Finished!");
			startButton.Enabled = true;
		}
	}
}
