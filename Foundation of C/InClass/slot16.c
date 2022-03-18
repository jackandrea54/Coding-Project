/*  masv    diem_toan   diem_ly     diem_hoa
    12          4.5       8.7        9.8
    34          8.6       7.5        8.2
    ...
*/

#include <stdio.h>
#include <stdlib.h>

int main()
{
    int *masv, n, i;
    double *dt, *dl, *dh;
    
    printf("Nhap so sinh vien: ");
    scanf("%d", &n);
    
    masv = (int*)calloc(n, sizeof(int));
    dt = (double*)calloc(n, sizeof(double));
    dl = (double*)calloc(n, sizeof(double));
    dh = (double*)calloc(n, sizeof(double));
    
    printf("Nhap danh sach sinh vien:\n");
    for (i = 0; i < n; i++)
    {
        printf("Sinh vien %d: ", i+1);
        scanf("%d%lf%lf%lf", &masv[i], &dt[i], &dl[i], &dh[i]);
    }
    
    printf("\nDanh sach sinh vien:\n");
    printf("Ma SV  Diem Toan  Diem Ly  Diem Hoa\n");
    printf("===================================\n");
    for (i = 0; i < n; i++)
        printf("%5d  %9.1lf  %7.1lf  %8.1lf\n", masv[i], dt[i], dl[i], dh[i]);

    return 0;
}
