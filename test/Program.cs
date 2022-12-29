int[,] pic = new int[6, 6]
{
{1, 1, 1, 1, 1, 1},
{1, 0, 0, 0, 0, 1},
{1, 0, 0, 0, 0, 1},
{1, 0, 0, 0, 0, 1},
{1, 0, 0, 0, 0, 1},
{1, 1, 1, 1, 1, 1}
};

void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            Console.Write($"{image[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillImage(int row, int col)
{
    if (pic[row, col] == 0 && row < pic.GetLength(0) && col < pic.GetLength(1))
    {
        pic[row, col]++;
        FillImage(row, col + 1);
        pic[row, col]++;
        FillImage(row + 1, col);
        pic[row, col]++;
        FillImage(row, col - 1);
        pic[row, col]++;
        FillImage(row - 1, col);
        pic[row, col]++;
    }
}
PrintImage(pic);
FillImage(1, 1);
PrintImage(pic);