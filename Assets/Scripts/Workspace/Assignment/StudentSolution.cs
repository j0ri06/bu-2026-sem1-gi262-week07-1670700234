using System;

namespace Assignment
{
    public class StudentSolution : IAssignment
    {
        public int LCT01_SequentialSearch1DArray()
        {
            int[] array = new int[] { 34, 21, 56, 12, 78, 90, 11, 23 };
            int target = 90;
            int index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        public int[] LCT02_SequentialSearch2DArray()
        {
            int[,] array = new int[,]
            {
                { 34, 21, 56 },
                { 12, 78, 90 },
                { 11, 23, 45 }
            };
            int target = 23;
            int row = -1;
            int col = -1;

            for (int r = 0; r < array.GetLength(0); r++)
            {
                for (int c = 0; c < array.GetLength(1); c++)
                {
                    if (array[r, c] == target)
                    {
                        row = r;
                        col = c;
                        break;
                    }
                }
                if (row != -1) break;
            }

            return new int[] { row, col };
        }

        public int LCT03_BinarySearch()
        {
            int[] array = new int[] { 11, 12, 21, 23, 34, 45, 56, 78, 90 };
            int target = 23;
            int index = -1;

            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == target)
                {
                    index = mid;
                    break;
                }
                else if (array[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return index;
        }

        public int[] AS01_FindFirstAndLastElementOfArray(int[] array, int target)
        {
            int firstIndex = -1;
            int lastIndex = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    if (firstIndex == -1)
                    {
                        firstIndex = i;
                    }
                    lastIndex = i;
                }
            }

            if (firstIndex == -1)
            {
                return new int[] { -1 };
            }

            return new int[] { firstIndex, lastIndex };
        }

        public int AS02_FindMaxLessThan(int[] array, int target)
        {
            int maxVal = -1;
            bool found = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < target)
                {
                    if (!found || array[i] > maxVal)
                    {
                        maxVal = array[i];
                        found = true;
                    }
                }
            }

            return found ? maxVal : -1;
        }

        public int[] AS03_FindRange(int[] array, int min, int max)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= min && array[i] <= max)
                {
                    count++;
                }
            }

            int[] result = new int[count];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= min && array[i] <= max)
                {
                    result[index] = array[i];
                    index++;
                }
            }

            return result;
        }

        public int[] EX01_FindTargetEnemies(int[] enemyHPs, int mana)
        {
            int[] sortedHPs = new int[enemyHPs.Length];
            for (int i = 0; i < enemyHPs.Length; i++)
            {
                sortedHPs[i] = enemyHPs[i];
            }
            Array.Sort(sortedHPs);

            int count = 0;
            int currentMana = mana;
            for (int i = 0; i < sortedHPs.Length; i++)
            {
                if (currentMana >= sortedHPs[i])
                {
                    currentMana -= sortedHPs[i];
                    count++;
                }
                else
                {
                    break;
                }
            }

            int[] result = new int[count];
            currentMana = mana;
            int index = 0;
            for (int i = 0; i < sortedHPs.Length; i++)
            {
                if (currentMana >= sortedHPs[i])
                {
                    result[index] = sortedHPs[i];
                    currentMana -= sortedHPs[i];
                    index++;
                }
                else
                {
                    break;
                }
            }

            return result;
        }
    }
}