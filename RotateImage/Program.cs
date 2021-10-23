using System;

namespace RotateImage
{
    public class Solution {
        public static int[,] Rotate(int[,] matrix) {
            int L=0;
            int R=matrix.GetLength(0)-1;
        
            while(R>L){
                
                for(int i=0;i<(R-L);i++){
                    int T=L;
                    int B=R;
                
                    int tmp = matrix[T,L+i];
                    matrix[T,L+i]=matrix[B-i,L];
                    matrix[B-i,L]=matrix[B,R-i];
                    matrix[B,R-i]=matrix[T+i,R];
                    matrix[T+i,R]=tmp;
                
                }
            
                L++;
                R--;
            }

            return matrix;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var matrix = new[,] {{5, 1, 9, 11}, {2, 4, 8, 10}, {13, 3, 6, 7}, {15, 14, 12, 16}};
            var result = Solution.Rotate(matrix);

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write($"{result[i,j]}, ");
                }
                Console.WriteLine();
            }
            
            //Console.WriteLine("Hello World!");
        }
    }
}