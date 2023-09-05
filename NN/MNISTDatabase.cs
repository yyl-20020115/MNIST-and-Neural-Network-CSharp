using System;
using System.Collections.Generic;
using System.IO;

namespace MNIST_Core;


public class MNISTDatabase
{
    private byte[,] pixles;
    private byte label;
    public readonly string labelsPath;
    public readonly string imagesPath;

    public readonly int DBSize;

    public List<DigitImage> Images { get; set; } = new();

    public MNISTDatabase(string labelsPath, string imagesPath, int size)
    {
        this.labelsPath = labelsPath;
        this.imagesPath = imagesPath;
        this.DBSize = size;
        this.Reload();
    }

    public void Reload()
    {
        try
        {
            using var fsLabels = new FileStream(labelsPath, FileMode.Open);
            using var fsImages = new FileStream(imagesPath, FileMode.Open);
            using var brLabels = new BinaryReader(fsLabels);
            using var brImages = new BinaryReader(fsImages);

            //parse images
            int magic1 = brImages.ReadInt32();
            int numImages = brImages.ReadInt32();
            int numRows = brImages.ReadInt32();
            int nubCols = brImages.ReadInt32();

            //parse labels
            int magic2 = brLabels.ReadInt32();
            int numLabels = brLabels.ReadInt32();

            Images.Clear();

            pixles = new byte[28,28];

            //for imgaes
            for (int di = 0; di < DBSize; di++)
            {
                for (int i = 0; i < 28; i++)
                {
                    for (int j = 0; j < 28; j++)
                    {
                        var b = (byte)brImages.ReadByte();

                        if (b > 30)
                        {
                            pixles[i,j] = 254;
                        }
                        else
                        {
                            pixles[i, j] = 0;
                        }
                    }

                }
                label = brLabels.ReadByte();
                var dImage = new DigitImage(pixles, label);
                Images.Add(dImage);
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine($"problem parsing MNIST DB:{ex.Message}");
        }
    }
}
