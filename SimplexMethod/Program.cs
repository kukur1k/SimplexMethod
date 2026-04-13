using SimplexMethod;


// double[,] matrix = {
//     { -3, -1, -2, 1, 0, -6},
//     { 1, 1, 1, 0, 0, 4},
//     { 1, -3, 1, 0, 1, -4 },
//     { -1, 8, 3, 0, 0, 0}
// };

double[,] matrix = {
    { 4, 7, 1, 0, 0, 49},
    { 8, 3, 0, 1, 0, 51},
    { 9, 5, 0, 0, 1, 45 },
    { -6, -5, 0, 0, 0, 0}
};
    
double[] targetF = { -6, -5, 0, 0, 0, 0};

SimplexMethod.SimplexMethod.SimplexCalculateMax(matrix, targetF);