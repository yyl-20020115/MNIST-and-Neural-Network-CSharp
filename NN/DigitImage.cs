namespace MNIST_Core;

public class DigitImage
{
    private const int DIM_SIZE = 28;
    public static int SIZE = DIM_SIZE * DIM_SIZE;

    public byte Label;

    public byte[][] Pixels;

    public double[] RawImage
    {
        get 
        {
            double[] res = new double[SIZE];

            for(int i = 0; i < DIM_SIZE; i++)
            {
                for(int j = 0; j < DIM_SIZE; j++)
                {
                    res[i * DIM_SIZE + j] = Pixels[j][i]/127.0 - 1.0;
                }
            }

            return res;
        }
    }

    public DigitImage(byte[][] _pixels, byte _label)
    {
        Pixels = new byte[28][];
        for (int i = 0; i < Pixels.Length; i++)
            Pixels[i] = new byte[28];

        for (int i = 0; i < 28; i++)
            for (int j = 0; j < 28; j++)
                Pixels[i][j] = _pixels[i][j];

        Label = _label;
    }

    public override string ToString()
    {
        string s = "";
        for (int i = 0; i < 28; i++)
        {
            for (int j = 0; j < 28; j++)
            {
                if (Pixels[i][j] == 0)
                    s += " "; //white
                else if (Pixels[i][j] == 255)
                    s += "0"; //black
                else
                    s += "."; //gray
            }
            s += "\n";
        }
        s += Label.ToString();
        return s;
    }
}
