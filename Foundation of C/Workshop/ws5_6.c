#include <stdio.h>

void append(long a[], int *n, long x)
{
    a[(*n)++] = x;
}

int delete(long a[], int *n, int y)
{
    if (y < 1 || y > *n)
        return 1;
    int i;
    for (i = y - 1; i < *n - 1; i++)
        a[i] = a[i+1];
    (*n)--;
    return 0;
}

int insert(long a[], int *n, long x, int y)
{
    if (y < 1 || y > *n + 1)
        return 1;
    int i;
    for (i = *n; i >= y; i--)
        a[i] = a[i - 1];
    a[y - 1] = x;
    (*n)++;
    return 0;
}

int main()
{
    long a[150], x;
    int n, y, i, error = 0;
    char op;
    
    scanf("%d", &n);
    for (i = 0; i < n; i++)
        scanf("%ld", &a[i]);
    
    do
    {
        scanf("%c", &op);
        switch (op)
        {
            case 'A':
                scanf("%ld", &x);
                append(a, &n, x);
                break;
            case 'D':
                scanf("%d", &y);
                error = delete(a, &n, y);
                break;
            case 'I':
                scanf("%ld%d", &x, &y);
                error = insert(a, &n, x, y);
        } 
    } while (!error && op != 'E');
    
    if (error)
        printf("error");
    else
        for (i = 0; i < n; i++)
            printf("%ld ", a[i]);
    
    return 0;
}
