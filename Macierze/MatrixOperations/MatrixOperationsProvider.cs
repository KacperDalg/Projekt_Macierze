﻿using Macierze.Models;

namespace Macierze.MatrixOperations;

public class MatrixOperationsProvider
{
    public static int SumFromColumn(MatrixModel model, string column)
    {
        int size = model.MatrixSize;
        List<string> list = model.FormList;
        int sum = 0;
        for (int i = int.Parse(column) - 1; i <= size * size - size + int.Parse(column); i += size)
        {
            sum += int.Parse(list[i]);
        }
        return sum;
    }

    public static int SumFromDiagonal(MatrixModel model)
    {
        var size = model.MatrixSize;
        var list = model.FormList;
        int sum = 0;
        for (int i = 0; i < list.Count; i++)
        {
            sum += int.Parse(list[i]);
            i += size;
        }
        return sum;
    }

    public static int SumFromRow(MatrixModel model, string row)
    {
        int size = model.MatrixSize;
        List<string> list = model.FormList;
        int sum = 0;
        for (int i = (int.Parse(row) - 1) * size; i < (int.Parse(row) - 1) * size + size; i++)
        {
            sum += int.Parse(list[i]);
        }
        return sum;
    }
}