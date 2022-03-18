#include <stdio.h>
#include <stdlib.h>

void get_array(int arr[], int *len)
{
    int i;
    scanf("%d", len);
    for (i = 0; i < *len; i++)
        scanf("%d", &arr[i]);
}

void disp_array(int arr[], int len)
{
    int i;
    for (i = 0; i < len; i++)
        printf("%d ", arr[i]);
}

int main()
{
    int a[100], n;
    
    get_array(a, &n);
    disp_array(a, n);
       
    return 0;
}
