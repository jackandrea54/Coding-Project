// viet ham nhap ngay sinh
// input: 12/3/2004
// output: d = 12, m = 3, y = 2004

#include <stdio.h>

void get_dob(int *d, int *m, int *y)
{
    printf("Enter DoB: ");
    // scanf("%d%*c%d%*c%d", d, m, y);
    scanf("%d/%d/%d", d, m, y);
}

int main()
{
    int d, m, y;
    
    get_dob(&d, &m, &y);
    printf("d = %d, m = %d, y = %d", d, m, y);
    
	return 0;
}
