using SimplexMethod;


double[,] matrixMax = {
    { 4, 7, 1, 0, 0, 49},
    { 8, 3, 0, 1, 0, 51},
    { 9, 5, 0, 0, 1, 45 },
    { -6, -5, 0, 0, 0, 0}
};
    
double[] targetFMax = { -6, -5, 0, 0, 0, 0};


double[,] matrixMin = {
    {2, -1, 1, 1, 0, 0, 1},
    {-4, 2, -1, 0, 1, 0, 2},
    {3, 0, 1, 0, 0, 1, 5},
    { -1, 1, 3, 0, 0, 0, 0}
};
    
double[] targetFMin = { -1, 1, 3, 0, 0, 0};


SimplexMethod.SimplexMethod.SimplexCalculateMax(matrixMax, targetFMax);
SimplexMethod.SimplexMethod.SimplexCalculateMin(matrixMin, targetFMin);