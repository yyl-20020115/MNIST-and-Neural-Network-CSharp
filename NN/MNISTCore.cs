using System.Collections.Generic;
using System.IO;

namespace MNIST_Core;

public class MNISTCore
{
    private MNISTDatabase TrainingDB;
    private MNISTDatabase TestDB;

    public MNISTCore() { }

    public List<DigitImage> TrainingImages 
        => TrainingDB.Images;
    public List<DigitImage> TestImages
        => TestDB.Images;

    public bool Load(string filesPath, int trainSize, int testSize)
    {
        try
        {
            var testImagesPath = Path.Combine(filesPath , "t10k-images.idx3-ubyte");
            var testLabelsPath = Path.Combine(filesPath , "t10k-labels.idx1-ubyte");
            var trainingImagesPath = Path.Combine(filesPath, "train-images.idx3-ubyte");
            var trainingLabelsPath = Path.Combine(filesPath, "train-labels.idx1-ubyte");

            TrainingDB = new (trainingLabelsPath, trainingImagesPath, trainSize);
            TestDB = new (testLabelsPath, testImagesPath, testSize);
            return true;
        }
        catch
        { 
            return false;
        }
    }
}
