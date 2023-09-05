using System.Text;

namespace MNIST_Core;

public class DigitImage
{
    private const int DIM_SIZE = 28;
    public static int SIZE = DIM_SIZE * DIM_SIZE;

    public byte Label;

    public byte[,] Pixels;

    public double[] RawImage
    {
        get 
        {
            var value = new double[SIZE];

            for(int i = 0; i < DIM_SIZE; i++)
            {
                for(int j = 0; j < DIM_SIZE; j++)
                {
                    value[i * DIM_SIZE + j] = Pixels[j,i]/127.0 - 1.0;
                }
            }

            return value;
        }
    }

    public DigitImage(byte[,] _pixels, byte _label)
    {
        Pixels = new byte[28,28];

        for (int i = 0; i < 28; i++)
            for (int j = 0; j < 28; j++)
                Pixels[i, j] = _pixels[i, j];

        this.Label = _label;
    }

    public override string ToString()
    {
        var builder = new StringBuilder();
        for (int i = 0; i < 28; i++)
        {
            for (int j = 0; j < 28; j++)
            {
                if (Pixels[i, j] == 0)
                    builder.Append(' '); //white
                else if (Pixels[i, j] == 255)
                    builder.Append('0'); //black
                else
                    builder.Append('.'); //gray
            }
            builder.AppendLine();
        }
        builder.Append(this.Label);
        return builder.ToString();
    }
}
