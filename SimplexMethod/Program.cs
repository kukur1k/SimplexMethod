using SimplexMethod;


double[,] matrix = {
    { 3, 1, 2, -1, 0, 6},
    { 1, 1, 1, 0, 0, 4},
    { 1, -3, 1, 0, 1, -4 }
};
    
double[] targetF = { -1, 8, 3, 0, 0};

SimplexMethod.SimplexMethod.SimplexCalculateMax(matrix, targetF);