﻿// See https://aka.ms/new-console-template for more information


int n = Convert.ToInt32(Console.ReadLine().Trim());

List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

Result.plusMinus(arr);

Console.WriteLine();

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        int count = arr.Count;

        decimal positiveVal = 0, negativeVal = 0, zeroVal = 0;

        for (int i = 0; i < count; i++)
        {
            if (arr[i] < 0)
                negativeVal++;
            else if (arr[i] > 0)
                positiveVal++;
            else
                zeroVal++;
        }
        positiveVal /= count; negativeVal /= count; zeroVal /= count;
        Console.WriteLine($"{positiveVal:F6}\n{negativeVal:F6}\n{zeroVal:F6}");
    }
}