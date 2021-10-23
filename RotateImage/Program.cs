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
            /*var matrix = new[,] {{5, 1, 9, 11}, {2, 4, 8, 10}, {13, 3, 6, 7}, {15, 14, 12, 16}};

            Console.WriteLine(Solution.Rotate(matrix)==new[,]{{15,13,2,5},{14,3,4,1},{12,6,8,9},{16,7,10,11}});
            */
            //


            //Console.WriteLine("Hello World!");
        }
    }
}