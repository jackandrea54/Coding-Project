/* viet chuong trinh nhap vao hai ma tran a, b va tinh a * b
+ input:
2 3
1 2 3
1 0 2
2 4
1 2 1 3
2 3 0 1
1 2 2 1
+ output:
2 4
8 x x x
x x x x
hoac in ra -1 neu phep nhan khong thuc hien duoc
+ constraints:
    - kich thuoc cua cac ma tran khong vuot qua 100
    - phan tu trong cac ma tran la cac so tu nhien nho hon 1000
*/

#include <stdio.h>

void read_matrix(int a[][100], int *ar, int *ac);
void print_matrix(int a[][100], int ar, int ac);
int multiply(int a[][100], int b[][100], int c[][100], int ar, int ac, int br, int bc);


int main()
{
    int a[100][100], b[100][100], c[100][100], ar, ac, br, bc;
    
    read_matrix(a, &ar, &ac);
    read_matrix(b, &br, &bc);
    
    if (multiply(a, b, c, ar, ac, br, bc))
    {
        printf("\n");
        print_matrix(c, ar, bc);
    }
    else
        printf("-1");

    return 0;
}


void read_matrix(int a[][100], int *ar, int *ac)
{
    int i, j;
    
    scanf("%d%d", ar, ac);
    for (i = 0; i < *ar; i++)
        for (j = 0; j < *ac; j++)
            scanf("%d", &a[i][j]);
}


void print_matrix(int a[][100], int ar, int ac)
{
    int i, j;
    
    printf("%d %d\n", ar, ac);
    for (i = 0; i < ar; i++)
    {
        for (j = 0; j < ac; j++)
            printf("%d ", a[i][j]);
        printf("\n");
    }
}


int multiply(int a[][100], int b[][100], int c[][100], int ar, int ac, int br, int bc)
{
    int i, j, k;
    
    if (ac != br)
        return 0;
    
    for (i = 0; i < ar; i++)
        for (j = 0; j < bc; j++)
            for (c[i][j] = 0, k = 0; k < ac; k++)
                c[i][j] += a[i][k] * b[k][j];
    
    return 1;
}

// a[ar, ac] x b[br, bc] -> c[ar, bc]
// i = 0: k: 0 -> 2 -> a[i][k]: a[0][0], a[0][1], a[0][2]
// j = 0: k: 0 -> 2 -> b[k][j]: b[0][0], b[1][0], b[2][0]

// ac = br
// 2 3
// 1 2 3
// 1 0 2

// 3 4
// 1 2 1 3
// 2 3 0 1
// 1 2 2 1

// 2 4
// c[0][0] = 1*1 + 2*2 + 3*1 = 8
