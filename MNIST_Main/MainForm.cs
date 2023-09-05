using MNIST_Core;
using System;
using System.Windows.Forms;

namespace MNIST_Main;

public partial class MainForm : Form
{
    private int _CurrentIndex = 0;


    private MNISTCore _DB;

    public MainForm()
    {
        InitializeComponent();
    }

    private void UpdateDigitImage(int index)
    {
        try
        {
            var img = _DB.TrainingImages[index].Pixels;
            digitUC1.Pixels = img;
        }
        catch 
        {
            
            
        }
        
    }

    private void ButtonLoad_Click(object sender, EventArgs e)
    {
        try
        {
            int trainSize = int.Parse(txtTrainSize.Text);
            int testSize = int.Parse(txtTestSize.Text);

            _DB = new MNISTCore();

            var path = txtFilesPath.Text;

            if (_DB.Load(path,trainSize,testSize) )
            {
                //MessageBox.Show("DB Load succefully!");
                (sender as Button).Enabled = false;



            }
            else
            {
                MessageBox.Show("Error while loading DB!","MNIST",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error:" + ex.Message);
        }
        
    }

    private void ButtonTrain_Click(object sender, EventArgs e)
    {
        var bp = new BackPropagation();

        bp.Start(_DB, _DB.TrainingImages.Count, _DB.TestImages.Count);
    }

    private void btnNextDigit_Click(object sender, EventArgs e)
    {
        UpdateDigitImage(++_CurrentIndex);
    }

    private void btnPrevDigit_Click(object sender, EventArgs e)
    {
        UpdateDigitImage(--_CurrentIndex);
    }
}
