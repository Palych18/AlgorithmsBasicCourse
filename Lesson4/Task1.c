#include <stdio.h>
#include <locale.h>
#define N 3
#define M 3

//Павел Егоров
//Количество маршрутов с препятствиями.Реализовать чтение массива с препятствием и
//нахождение количество маршрутов.


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

void task1() {
    int A[N][M];
    int map[N][M];
    initMap(map);
    int i, j;
    for (j = 0; j < M; j++) {
        if (map[0][j] == 0) {
            A[0][j] = 0;
        }
        else if (j == 0) {
            A[0][j] = 1;
        }
        else {
            A[0][j] = A[0][j - 1];
        }
    }
    for (i = 1; i < N; i++)
    {
        if (map[i][0] == 0) {
            A[i][0] = 0;
        }
        else if (i == 0) {
            A[i][0] = 1;
        }
        else {
            A[i][0] = A[i - 1][0];
        }

        for (j = 1; j < M; j++) {
            if (map[i][j] == 0) {
                A[i][j] = 0;
            }
            else {
                A[i][j] = A[i][j - 1] + A[i - 1][j];
            }
        }
    }
    Print2(N, M, A);
}

const int m_length = 10;
const int n_length = 10;
const char* m = "geekbrains";
const char* n = "geekmainds";

void Print3(int n, int m, int a[10][10]) {
    int i, j;
    for (i = 0; i < n; i++)
    {
        for (j = 0; j < m; j++)
            printf("%4d", a[i][j]);
        printf("\n");
    }
}

int main(void) 
{
	char* locale = setlocale(LC_ALL, "");
    task1();
	getchar();
	return 0;
}