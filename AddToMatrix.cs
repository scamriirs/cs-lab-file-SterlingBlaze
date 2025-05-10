using System;

class Add2Matrix {
    static void Main() {
        int[,] matrix1 = {{1, 2}, {3, 4}};
        int[,] matrix2 = {{5, 6}, {7, 8}};
        int[,] result = new int[2, 2];
        
        Console.WriteLine("Matrix Addition:");
        for(int i=0; i<2; i++) {
            for(int j=0; j<2; j++) {
                result[i,j] = matrix1[i,j] + matrix2[i,j];
                Console.Write(result[i,j] + " ");
            }
            Console.WriteLine();
        }
    }
}
