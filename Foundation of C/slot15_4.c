#include <stdio.h>
#include <stdlib.h>

int main()
{
    int a[100][50], rows, cols, r, c;
    float avg;
    
    printf("Enter #rows, #cols: ");
    scanf("%d%d", &rows, &cols);
    
    printf("Enter your matrix:\n");
    for (r = 0; r < rows; r++)
        for (c = 0; c < cols; c++)
            scanf("%d", &a[r][c]);
            
    printf("Your matrix:\n");
    for (r = 0; r < rows; r++)
    {
        for (c = 0; c < cols; c++)
            printf("%4d", a[r][c]);
        printf("\n");
    }
    
    printf("================\n");
    for (c = 0; c < cols; c++)
    {
        avg = 0;
        for (r = 0; r < rows; r++)
            avg += a[r][c];
        avg /= rows;
        printf("%4.1f", avg);
    }
    
    return 0;
}

//BAI TAP VE NHA
// nhap vao mot mang hai chieu tim phan tu lon nhat trong mang
// nhap vao mot mang hai chieu, tinh tong cac phan tu tren duong cheo chinh
// nhap vao hai ma tran, tinh tong, tich cua chung
