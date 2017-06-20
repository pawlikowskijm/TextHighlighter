namespace DocProspector
{
	partial class TextHighlighter
	{
		/// <summary>
		/// Wymagana zmienna projektanta.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Wyczyść wszystkie używane zasoby.
		/// </summary>
		/// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Kod generowany przez Projektanta formularzy systemu Windows

		/// <summary>
		/// Wymagana metoda obsługi projektanta — nie należy modyfikować 
		/// zawartość tej metody z edytorem kodu.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.startButton = new System.Windows.Forms.Button();
			this.console = new System.Windows.Forms.Label();
			this.browse = new System.Windows.Forms.Button();
			this.path = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.lengthOfPhrases = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.lengthOfPhrases)).BeginInit();
			this.SuspendLayout();
			// 
			// startButton
			// 
			this.startButton.Location = new System.Drawing.Point(146, 167);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(95, 31);
			this.startButton.TabIndex = 0;
			this.startButton.Text = "Start";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.prospect_Click);
			// 
			// console
			// 
			this.console.AutoSize = true;
			this.console.Location = new System.Drawing.Point(12, 9);
			this.console.Name = "console";
			this.console.Size = new System.Drawing.Size(292, 34);
			this.console.TabIndex = 2;
			this.console.Text = "Welcome to the TextHighlighter. \r\nChoose path and start highlighting your texts!";
			// 
			// browse
			// 
			this.browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.browse.Location = new System.Drawing.Point(347, 75);
			this.browse.Name = "browse";
			this.browse.Size = new System.Drawing.Size(39, 31);
			this.browse.TabIndex = 3;
			this.browse.Text = "...";
			this.browse.UseVisualStyleBackColor = true;
			this.browse.Click += new System.EventHandler(this.browse_Click);
			// 
			// path
			// 
			this.path.BackColor = System.Drawing.SystemColors.Window;
			this.path.Location = new System.Drawing.Point(12, 80);
			this.path.Name = "path";
			this.path.Size = new System.Drawing.Size(329, 22);
			this.path.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "Path";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// backgroundWorker1
			// 
			this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(15, 204);
			this.progressBar1.Maximum = 10000;
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(374, 23);
			this.progressBar1.TabIndex = 7;
			// 
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(12, 108);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(177, 21);
			this.checkBox1.TabIndex = 8;
			this.checkBox1.Text = "Differentiate letter case";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// lengthOfPhrases
			// 
			this.lengthOfPhrases.Location = new System.Drawing.Point(12, 136);
			this.lengthOfPhrases.Name = "lengthOfPhrases";
			this.lengthOfPhrases.Size = new System.Drawing.Size(120, 22);
			this.lengthOfPhrases.TabIndex = 9;
			this.lengthOfPhrases.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(138, 138);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(242, 17);
			this.label1.TabIndex = 10;
			this.label1.Text = "Minimal length of phrases to highlight";
			// 
			// TextHighlighter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(401, 239);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lengthOfPhrases);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.path);
			this.Controls.Add(this.browse);
			this.Controls.Add(this.console);
			this.Controls.Add(this.startButton);
			this.MaximizeBox = false;
			this.Name = "TextHighlighter";
			this.Text = "TextHighlighter";
			((System.ComponentModel.ISupportInitialize)(this.lengthOfPhrases)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.Label console;
		private System.Windows.Forms.Button browse;
		private System.Windows.Forms.TextBox path;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		public System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.NumericUpDown lengthOfPhrases;
		private System.Windows.Forms.Label label1;
	}
}

