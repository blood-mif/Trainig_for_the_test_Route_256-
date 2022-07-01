using System;
using System.Collections.Generic;
using System.Linq;

namespace H.Г_образный_моской_бой
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] mask1 = new int[3][];

            mask1[0] = new int[] { 0, 0, 0 };
            mask1[1] = new int[] { 0, 1, 0 };
            mask1[2] = new int[] { 0, 0, 0 };

            int[][] mask2 = new int[4][];

            mask2[0] = new int[] { 0, 0, 0, 0 };
            mask2[1] = new int[] { 0, 1, 1, 0 };
            mask2[2] = new int[] { 0, 1, 0, 0 };
            mask2[3] = new int[] { 0, 0, 0, -1 };

            int[][] mask3 = new int[5][];

            mask3[0] = new int[] { 0, 0, 0, 0, 0 };
            mask3[1] = new int[] { 0, 1, 1, 1, 0 };
            mask3[2] = new int[] { 0, 1, 0, 0, 0 };
            mask3[3] = new int[] { 0, 1, 0, -1, -1 };
            mask3[4] = new int[] { 0, 0, 0, -1, -1 };

            int[][] mask4 = new int[6][];

            mask4[0] = new int[] { 0, 0, 0, 0, 0, 0 };
            mask4[1] = new int[] { 0, 1, 1, 1, 1, 0 };
            mask4[2] = new int[] { 0, 1, 0, 0, 0, 0 };
            mask4[3] = new int[] { 0, 1, 0, -1, -1, -1 };
            mask4[4] = new int[] { 0, 1, 0, -1, -1, -1 };
            mask4[5] = new int[] { 0, 0, 0, -1, -1, -1 };

            List<int[][]> allMasks = new List<int[][]>();
            allMasks.Add(mask1);

            for (int i = 0; i < 4; ++i)
            {
                allMasks.Add(mask2);
                allMasks.Add(mask3);
                allMasks.Add(mask4);

                mask2 = rotate(mask2);
                mask3 = rotate(mask3);
                mask4 = rotate(mask4);
            }

            // foreach (var mask in allMasks)
            // {
            //     for (int j = 0; j < mask.Length; ++j)
            //     {
            //         for (int k = 0; k < mask[0].Length; ++k)
            //             Console.Write(mask[j][k]);
            //         Console.WriteLine();
            //     }
            //     Console.WriteLine();
            // }

            int t = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < t; ++i)
            {
                var dim = Console.ReadLine().Split(' ').Select(it => int.Parse(it)).ToArray();
                int y = dim[0];
                int x = dim[1];

                int[][] field = new int[y + 2][];

                for (int j = 0; j < y + 2; ++j)
                    field[j] = new int[x + 2];

                for (int j = 0; j < y; ++j)
                {
                    String row = Console.ReadLine();

                    for (int k = 0; k < row.Length; ++k)
                        if (row[k] == '*')
                            field[j + 1][k + 1] = 1;
                }

                List<int> sizes = new List<int>();

                compare(field, allMasks, sizes);

                sizes.Sort();

                bool flag = true;

                for (int j = 0; j < field.Length; ++j)
                {
                    for (int k = 0; k < field[0].Length; ++k)
                        if (field[j][k] == 1)
                            flag = false;
                }

                if (flag)
                {
                    Console.WriteLine("YES");
                    foreach (var size in sizes)
                    {
                        Console.Write(size + " ");
                    }
                }
                else
                {
                    Console.WriteLine("NO");
                    // for (int j = 0; j < field.Length; ++j)
                    // {
                    //     for (int k = 0; k < field[0].Length; ++k)
                    //         Console.Write(field[j][k]);
                    //     Console.WriteLine();
                    // }
                }

                Console.WriteLine();
            }
        }

        static int[][] rotate(int[][] mask)
        {
            int[][] newMask = new int[mask.Length][];

            for (int i = 0; i < mask.Length; ++i)
            {
                newMask[i] = new int[mask.Length];
            }


            for (int i = 0; i < mask.Length; ++i)
            {
                for (int j = 0; j < mask.Length; ++j)
                {
                    newMask[j][mask.Length - 1 - i] = mask[i][j];
                }
            }

            return newMask;
        }

        static void compare(int[][] field, List<int[][]> masks, List<int> sizes)
        {
            for (int i = 0; i < field.Length; ++i)
            {
                for (int j = 0; j < field[0].Length; ++j)
                {
                    foreach (var mask in masks)
                    {
                        bool flag = true;

                        if (!(i + mask.Length <= field.Length) || !(j + mask.Length <= field[0].Length))
                            continue;

                        for (int ii = 0; ii < mask.Length; ++ii)
                        {
                            for (int jj = 0; jj < mask.Length; ++jj)
                            {
                                if (mask[ii][jj] != field[i + ii][j + jj] && mask[ii][jj] != -1)
                                    flag = false;
                            }
                        }

                        if (flag)
                        {
                            sizes.Add(2 * (mask.Length - 2) - 1);

                            for (int ii = 0; ii < mask.Length; ++ii)
                            {
                                for (int jj = 0; jj < mask.Length; ++jj)
                                {
                                    if (mask[ii][jj] != -1)
                                        field[i + ii][j + jj] = 0;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
