#include <stdio.h>
#include <locale.h>
#define N 3
#define M 3

//Павел Егоров
//2. Решить задачу о нахождении длины максимальной последовательности с помощью матрицы.


void Print2(int n, int m, int a[N][M]) {
    int i, j;
    for (i = 0; i < n; i++)
    {
        for (j = 0; j < m; j++)
            printf("%4d", a[i][j]);
        printf("\n");
    }
}

void initMap(int map[N][M]) {
    for (int i = 1; i < N; i++)
    {
        for (int j = 1; j < M; j++)
            map[i][j] = 1;
    }
    map[1][0] = 0;
    map[2][0] = 0;
}

const int m_length = 10;
const int n_length = 10;
const char* m = "PavelEgorov";
const char* n = "PavelEgorov";

void Print3(int n, int m, int a[10][10]) {
    int i, j;
    for (i = 0; i < n; i++)
    {
        for (j = 0; j < m; j++)
            printf("%4d", a[i][j]);
        printf("\n");
    }
}

void task2() {
    int lcs[10][10];

    for (int i = 1; i < m_length; ++i) {
        lcs[i][0] = 0;
    }

    for (int j = 0; j < n_length; ++j) {
        lcs[0][j] = 0;
    }

    for (int i = 1; i < m_length; ++i) {
        for (int j = 1; j < n_length; ++j) {
            if (m[i] == n[j]) {
                lcs[i][j] = lcs[i - 1][j - 1] + 1;
            }
            else if (lcs[i - 1][j] >= lcs[i][j - 1]) {
                lcs[i][j] = lcs[i - 1][j];
            }
            else {
                lcs[i][j] = lcs[i][j - 1];
            }
        }
    }
    Print3(m_length, n_length, lcs);
}

int main(void)
{
    char* locale = setlocale(LC_ALL, "");
    task2();
    getchar();
    return 0;
}