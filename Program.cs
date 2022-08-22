int[,] CreateMatrix(int length, int width, int minimum, int maximum)
{
    int[,] matrix = new int[length, width];
    Random random = new Random();
    for(int i=0;i<matrix.GetLength(0);i++)
        for(int j=0;j<matrix.GetLength(1);j++)
            matrix[i,j] = random.Next(minimum,maximum);
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for(int i=0;i<matrix.GetLength(0);i++)
    {
        for(int j=0;j<matrix.GetLength(1);j++)
            Console.Write($"{matrix[i,j]} ");
        Console.WriteLine();
    }
    
}
int[] FindPosition(int[,] matrix, int value)
{
    for(int i=0;i<matrix.GetLength(0);i++)
        for(int j=0;j<matrix.GetLength(1);j++)
            if(matrix[i,j]==value)
                return new int[]{i,j};
    return new int[] {-1,-1};
}
int[,] matrix = CreateMatrix(3,3,0,20);
PrintMatrix(matrix);
Console.Write("Enter element to find: ");
int value = int.Parse(Console.ReadLine() ?? "0");
int[] position = FindPosition(matrix,value);
Console.WriteLine(position[0]< 0 || position[1]< 0 
    ? "Element not found" 
    : $"Position of element: ({position[0]},{position[1]})");