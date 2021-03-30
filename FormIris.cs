using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ML;
using Microsoft.ML.Data;
using System.IO;
using System.Globalization;

namespace Knn_Iris
{
    public partial class FormIris : Form
    {
        static readonly string _dataPath = Path.Combine(Environment.CurrentDirectory, "Data", "iris.data");
        static readonly string _modelPath = Path.Combine(Environment.CurrentDirectory, "Data", "IrisClusteringModel.zip");
        public FormIris()
        {
            InitializeComponent();
        }

        private void trackbar_cluster_Scroll(object sender, EventArgs e)
        {
            lbl_num_cluster.Text = trackbar_cluster.Value.ToString();
        }

        private void btn_cluster_Click(object sender, EventArgs e)
        {
            label1.Text = "Экземпляр данных ирисов: ";
            label6.Text = "Идентификатор прогнозируемого кластера: ";
            richTextBoxResult.Text = "";
            var mlContext = new MLContext(seed: 0);
            IDataView dataView = mlContext.Data.LoadFromTextFile<IrisData>(_dataPath, hasHeader: false, separatorChar: ',');
            string featuresColumnName = "Features";
            var pipeline = mlContext.Transforms
                .Concatenate(featuresColumnName, "SepalLength", "SepalWidth", "PetalLength", "PetalWidth")
                .Append(mlContext.Clustering.Trainers.KMeans(featuresColumnName, numberOfClusters: trackbar_cluster.Value));
            var model = pipeline.Fit(dataView);
            using (var fileStream = new FileStream(_modelPath, FileMode.Create, FileAccess.Write, FileShare.Write))
            {
                mlContext.Model.Save(model, dataView.Schema, fileStream);
            }
            var predictor = mlContext.Model.CreatePredictionEngine<IrisData, ClusterPrediction>(model);
            TestIrisData.Iris.SepalLength = float.Parse(datagridview_iris[1, datagridview_iris.CurrentRow.Index].Value.ToString(), CultureInfo.InvariantCulture.NumberFormat);
            TestIrisData.Iris.SepalWidth = float.Parse(datagridview_iris[2, datagridview_iris.CurrentRow.Index].Value.ToString(), CultureInfo.InvariantCulture.NumberFormat);
            TestIrisData.Iris.PetalLength = float.Parse(datagridview_iris[3, datagridview_iris.CurrentRow.Index].Value.ToString(), CultureInfo.InvariantCulture.NumberFormat);
            TestIrisData.Iris.PetalWidth = float.Parse(datagridview_iris[4, datagridview_iris.CurrentRow.Index].Value.ToString(), CultureInfo.InvariantCulture.NumberFormat);
            var prediction = predictor.Predict(TestIrisData.Iris);
            label1.Text += datagridview_iris[5, datagridview_iris.CurrentRow.Index].Value.ToString() + "\n" + datagridview_iris[1, datagridview_iris.CurrentRow.Index].Value.ToString() + " x " + datagridview_iris[2, datagridview_iris.CurrentRow.Index].Value.ToString() + " x " + datagridview_iris[3, datagridview_iris.CurrentRow.Index].Value.ToString() + " x " + datagridview_iris[4, datagridview_iris.CurrentRow.Index].Value.ToString();
            label6.Text += prediction.PredictedClusterId.ToString();
            richTextBoxResult.Text = string.Join("\n", prediction.Distances);
        }

        private void FormIris_Shown(object sender, EventArgs e)
        {
            int i = 0;
            string line;
            StreamReader file = new StreamReader(_dataPath);
            while ((line = file.ReadLine()) != null)
            {
                string[] split = line.Split(',');
                string[] row = new string[6];
                i++;
                row[0] = i.ToString();
                row[1] = split[0];
                row[2] = split[1];
                row[3] = split[2];
                row[4] = split[3];
                row[5] = split[4];
                datagridview_iris.Rows.Add(row);
            }
            file.Close();
        }

        private void btn_github_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/umanets-alexander/k-means-iris");
        }
    }
}
