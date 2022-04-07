#include <stdio.h>
#include <stdlib.h>

int main()
{
    int *a, n, i;
    printf("Enter #elements: ");
    scanf("%d", &n);
    a = NULL;
    a = (int*)malloc(n * sizeof(int));
    if (a == NULL)
        printf("Memory is not enough!");
    else
    {
        printf("Enter %d elements: ", n);
        for (i = 0; i < n; i++)
            scanf("%d", &a[i]);
            // scanf("%d", a + i);
        
        printf("The array you've entered: ");
        for (i = 0; i < n; i++)
        for (i = 0; i < n; i++)
            printf("%d ", a[i]);
            // printf("%d ", *(a + i));
    }
    
    return 0;
}
