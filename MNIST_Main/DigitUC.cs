using System;
using System.Drawing;
using System.Windows.Forms;

namespace MNIST_Main;

public partial class DigitUC : UserControl
{

    private byte[,] m_Pixels;

    public byte[,] Pixels
    {
        get => m_Pixels;
        set
        {
            if ((m_Pixels = value) != null)
                UpdateDigit();
        }
    }

    private void UpdateDigit()
    {
        var g = panel1.CreateGraphics();

        for (int i = 0; i < Pixels.GetLength(0); i++)
        {
            for (int j = 0; j < Pixels.GetLength(1); j++)
            {
                var p = Pixels[i, j];
                switch (p)
                {
                    case 0:
                        g.FillRectangle(Brushes.White, j, i, 1, 1);
                        break;
                    case 255:
                        g.FillRectangle(Brushes.Black, j, i, 1, 1);
                        break;
                    default:
                        g.FillRectangle(Brushes.Gray, j, i, 1, 1);
                        break;
                }
            }
        }
    }

    public DigitUC()
    {
        InitializeComponent();
    }

    private void DigitUC_Load(object sender, EventArgs e)
    {

    }

    private void DigitUC_Resize(object sender, EventArgs e)
    {
        this.Width = 28;
        this.Height = 28;
    }
}
