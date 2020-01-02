namespace eMaking
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.results = new System.Windows.Forms.ListBox();
            this.addResult = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.answers = new System.Windows.Forms.ListBox();
            this.addAnswer = new System.Windows.Forms.Button();
            this.excelView = new System.Windows.Forms.DataGridView();
            this.exit = new System.Windows.Forms.Button();
            this.saveExcel = new System.Windows.Forms.Button();
            this.marking = new System.Windows.Forms.Button();
            this.resultView = new System.Windows.Forms.DataGridView();
            this.answerView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.excelView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đáp án";
            // 
            // results
            // 
            this.results.FormattingEnabled = true;
            this.results.ItemHeight = 16;
            this.results.Location = new System.Drawing.Point(18, 45);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(264, 196);
            this.results.TabIndex = 1;
            this.results.SelectedIndexChanged += new System.EventHandler(this.results_SelectedIndexChanged);
            // 
            // addResult
            // 
            this.addResult.Location = new System.Drawing.Point(18, 248);
            this.addResult.Name = "addResult";
            this.addResult.Size = new System.Drawing.Size(264, 40);
            this.addResult.TabIndex = 2;
            this.addResult.Text = "Thêm";
            this.addResult.UseVisualStyleBackColor = true;
            this.addResult.Click += new System.EventHandler(this.addResult_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bài thi";
            // 
            // answers
            // 
            this.answers.FormattingEnabled = true;
            this.answers.ItemHeight = 16;
            this.answers.Location = new System.Drawing.Point(18, 336);
            this.answers.Name = "answers";
            this.answers.Size = new System.Drawing.Size(264, 324);
            this.answers.TabIndex = 5;
            this.answers.SelectedIndexChanged += new System.EventHandler(this.answers_SelectedIndexChanged);
            // 
            // addAnswer
            // 
            this.addAnswer.Location = new System.Drawing.Point(18, 666);
            this.addAnswer.Name = "addAnswer";
            this.addAnswer.Size = new System.Drawing.Size(264, 40);
            this.addAnswer.TabIndex = 6;
            this.addAnswer.Text = "Thêm";
            this.addAnswer.UseVisualStyleBackColor = true;
            this.addAnswer.Click += new System.EventHandler(this.addAnswer_Click);
            // 
            // excelView
            // 
            this.excelView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.excelView.Location = new System.Drawing.Point(287, 45);
            this.excelView.Name = "excelView";
            this.excelView.RowHeadersWidth = 51;
            this.excelView.RowTemplate.Height = 24;
            this.excelView.Size = new System.Drawing.Size(1067, 799);
            this.excelView.TabIndex = 8;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(18, 804);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(264, 40);
            this.exit.TabIndex = 9;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // saveExcel
            // 
            this.saveExcel.Location = new System.Drawing.Point(18, 758);
            this.saveExcel.Name = "saveExcel";
            this.saveExcel.Size = new System.Drawing.Size(264, 40);
            this.saveExcel.TabIndex = 10;
            this.saveExcel.Text = "Lưu bảng điểm";
            this.saveExcel.UseVisualStyleBackColor = true;
            this.saveExcel.Click += new System.EventHandler(this.saveExcel_Click);
            // 
            // marking
            // 
            this.marking.Location = new System.Drawing.Point(18, 712);
            this.marking.Name = "marking";
            this.marking.Size = new System.Drawing.Size(264, 40);
            this.marking.TabIndex = 11;
            this.marking.Text = "Chấm điểm";
            this.marking.UseVisualStyleBackColor = true;
            this.marking.Click += new System.EventHandler(this.marking_Click);
            // 
            // resultView
            // 
            this.resultView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultView.Enabled = false;
            this.resultView.Location = new System.Drawing.Point(1328, 850);
            this.resultView.Name = "resultView";
            this.resultView.RowHeadersWidth = 51;
            this.resultView.RowTemplate.Height = 24;
            this.resultView.Size = new System.Drawing.Size(10, 10);
            this.resultView.TabIndex = 12;
            // 
            // answerView
            // 
            this.answerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.answerView.Enabled = false;
            this.answerView.Location = new System.Drawing.Point(1344, 850);
            this.answerView.Name = "answerView";
            this.answerView.RowHeadersWidth = 51;
            this.answerView.Size = new System.Drawing.Size(10, 10);
            this.answerView.TabIndex = 13;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 877);
            this.Controls.Add(this.answerView);
            this.Controls.Add(this.resultView);
            this.Controls.Add(this.marking);
            this.Controls.Add(this.saveExcel);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.excelView);
            this.Controls.Add(this.addAnswer);
            this.Controls.Add(this.answers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addResult);
            this.Controls.Add(this.results);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.excelView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox results;
        private System.Windows.Forms.Button addResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox answers;
        private System.Windows.Forms.Button addAnswer;
        private System.Windows.Forms.DataGridView excelView;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button saveExcel;
        private System.Windows.Forms.Button marking;
        private System.Windows.Forms.DataGridView resultView;
        private System.Windows.Forms.DataGridView answerView;
    }
}

