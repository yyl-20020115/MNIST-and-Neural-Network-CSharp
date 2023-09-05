using System;
using System.Collections.Generic;

namespace MNIST_Core;

public class MNISTCore
{
    private ReadMNIST _TrainingDB;
    private ReadMNIST _TestDB;

    public MNISTCore() { }

    public List<DigitImage> TrainingImages => _TrainingDB.Images;
    public List<DigitImage> TestImages => _TestDB.Images;

    public Boolean LoadDB(string filesPath, int trainSize, int testSize)
    {
        try
        {
            var testImagesPath = filesPath + "t10k-images.idx3-ubyte";
            var testLabelsPath = filesPath + "t10k-labels.idx1-ubyte";
            var trainingImagesPath = filesPath + "train-images.idx3-ubyte";
            var trainingLabelsPath = filesPath + "train-labels.idx1-ubyte";

            _TrainingDB = new ReadMNIST(trainingLabelsPath, trainingImagesPath, trainSize);
            _TestDB = new ReadMNIST(testLabelsPath, testImagesPath, testSize);
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }
}
