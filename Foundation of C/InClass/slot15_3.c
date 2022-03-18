#include <stdio.h>
#include <stdlib.h>

void get_array(int arr[], int *len)
{
    int i;
    printf("Nhap so phan tu cua array: ");
    scanf("%d", len);
    for (i = 0; i < *len; i++)
        scanf("%d", &arr[i]);
}

int find(int arr[], int len, int num)
{
    int i;
    for (i = 0; i < len; i++)
        if (arr[i] == num)
            return i;
    return -1;
}

int find_max(int arr[], int len)
{
    int i, max_pos = 0;
    for (i = 1; i < len; i++)
        if (arr[i] > arr[max_pos])
            max_pos = i;
    return max_pos;
}

int main()
{
    int a[100],n;
    get_array(a, &n);
    find_max(a, n);
    find(a, n);
    return 0;
}
