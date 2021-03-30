
namespace Knn_Iris
{
    partial class FormIris
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIris));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_num_cluster = new System.Windows.Forms.Label();
            this.trackbar_cluster = new System.Windows.Forms.TrackBar();
            this.btn_cluster = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_github = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.datagridview_iris = new System.Windows.Forms.DataGridView();
            this.NumIris = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SepalLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SepalWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PetalLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PetalWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeIris = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_cluster)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_iris)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_num_cluster);
            this.panel1.Controls.Add(this.trackbar_cluster);
            this.panel1.Controls.Add(this.btn_cluster);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 54);
            this.panel1.TabIndex = 0;
            // 
            // lbl_num_cluster
            // 
            this.lbl_num_cluster.AutoSize = true;
            this.lbl_num_cluster.Location = new System.Drawing.Point(658, 16);
            this.lbl_num_cluster.Name = "lbl_num_cluster";
            this.lbl_num_cluster.Size = new System.Drawing.Size(18, 20);
            this.lbl_num_cluster.TabIndex = 6;
            this.lbl_num_cluster.Text = "1";
            // 
            // trackbar_cluster
            // 
            this.trackbar_cluster.Location = new System.Drawing.Point(206, 11);
            this.trackbar_cluster.Maximum = 59;
            this.trackbar_cluster.Minimum = 1;
            this.trackbar_cluster.Name = "trackbar_cluster";
            this.trackbar_cluster.Size = new System.Drawing.Size(446, 45);
            this.trackbar_cluster.TabIndex = 5;
            this.trackbar_cluster.Value = 1;
            this.trackbar_cluster.Scroll += new System.EventHandler(this.trackbar_cluster_Scroll);
            // 
            // btn_cluster
            // 
            this.btn_cluster.Location = new System.Drawing.Point(698, 11);
            this.btn_cluster.Name = "btn_cluster";
            this.btn_cluster.Size = new System.Drawing.Size(215, 30);
            this.btn_cluster.TabIndex = 4;
            this.btn_cluster.Text = "Кластеризовать";
            this.btn_cluster.UseVisualStyleBackColor = true;
            this.btn_cluster.Click += new System.EventHandler(this.btn_cluster_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Количество кластеров:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_github);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 568);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(931, 38);
            this.panel2.TabIndex = 1;
            // 
            // btn_github
            // 
            this.btn_github.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_github.Image = ((System.Drawing.Image)(resources.GetObject("btn_github.Image")));
            this.btn_github.Location = new System.Drawing.Point(891, 0);
            this.btn_github.Name = "btn_github";
            this.btn_github.Size = new System.Drawing.Size(38, 36);
            this.btn_github.TabIndex = 0;
            this.btn_github.UseVisualStyleBackColor = true;
            this.btn_github.Click += new System.EventHandler(this.btn_github_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.richTextBoxResult);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(498, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(433, 514);
            this.panel3.TabIndex = 2;
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.Location = new System.Drawing.Point(17, 185);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.Size = new System.Drawing.Size(398, 310);
            this.richTextBoxResult.TabIndex = 4;
            this.richTextBoxResult.Text = "";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(17, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(398, 35);
            this.label6.TabIndex = 3;
            this.label6.Text = "Идентификатор прогнозируемого кластера:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(17, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(398, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "Массив с квадратом Евклидовых расстояний до центроидов кластера:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(431, 40);
            this.panel6.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Результат:";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.datagridview_iris);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel4.Location = new System.Drawing.Point(0, 54);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(498, 514);
            this.panel4.TabIndex = 3;
            // 
            // datagridview_iris
            // 
            this.datagridview_iris.AllowUserToAddRows = false;
            this.datagridview_iris.AllowUserToDeleteRows = false;
            this.datagridview_iris.BackgroundColor = System.Drawing.SystemColors.Control;
            this.datagridview_iris.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_iris.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumIris,
            this.SepalLength,
            this.SepalWidth,
            this.PetalLength,
            this.PetalWidth,
            this.TypeIris});
            this.datagridview_iris.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridview_iris.Location = new System.Drawing.Point(0, 40);
            this.datagridview_iris.MultiSelect = false;
            this.datagridview_iris.Name = "datagridview_iris";
            this.datagridview_iris.ReadOnly = true;
            this.datagridview_iris.RowHeadersVisible = false;
            this.datagridview_iris.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridview_iris.Size = new System.Drawing.Size(496, 472);
            this.datagridview_iris.TabIndex = 1;
            // 
            // NumIris
            // 
            this.NumIris.HeaderText = "№";
            this.NumIris.Name = "NumIris";
            this.NumIris.ReadOnly = true;
            this.NumIris.Width = 30;
            // 
            // SepalLength
            // 
            this.SepalLength.HeaderText = "Длина чашелистика";
            this.SepalLength.Name = "SepalLength";
            this.SepalLength.ReadOnly = true;
            this.SepalLength.Width = 80;
            // 
            // SepalWidth
            // 
            this.SepalWidth.HeaderText = "Ширина чашелистика";
            this.SepalWidth.Name = "SepalWidth";
            this.SepalWidth.ReadOnly = true;
            this.SepalWidth.Width = 80;
            // 
            // PetalLength
            // 
            this.PetalLength.HeaderText = "Длина лепестка";
            this.PetalLength.Name = "PetalLength";
            this.PetalLength.ReadOnly = true;
            this.PetalLength.Width = 80;
            // 
            // PetalWidth
            // 
            this.PetalWidth.HeaderText = "Ширина лепестка";
            this.PetalWidth.Name = "PetalWidth";
            this.PetalWidth.ReadOnly = true;
            this.PetalWidth.Width = 80;
            // 
            // TypeIris
            // 
            this.TypeIris.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TypeIris.HeaderText = "Тип ириса";
            this.TypeIris.Name = "TypeIris";
            this.TypeIris.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(496, 40);
            this.panel5.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Данные ирисов:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(17, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 55);
            this.label1.TabIndex = 5;
            this.label1.Text = "Экземпляр данных ирисов: ";
            // 
            // FormIris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 606);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormIris";
            this.Text = "KNN Iris dataset";
            this.Shown += new System.EventHandler(this.FormIris_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_cluster)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_iris)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_num_cluster;
        private System.Windows.Forms.TrackBar trackbar_cluster;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView datagridview_iris;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_github;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumIris;
        private System.Windows.Forms.DataGridViewTextBoxColumn SepalLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn SepalWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn PetalLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn PetalWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeIris;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_cluster;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
        private System.Windows.Forms.Label label1;
    }
}

