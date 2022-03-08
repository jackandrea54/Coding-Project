#include <stdio.h>

int main()
{
    int n, m, num, i;
    unsigned char mark[2001001] = {0};
    
    scanf("%d%d", &n, &m);
    for (i = 0; i < n; i++)
    {
        scanf("%d", &num);
        mark[num] = 1;
    }
    
    for (i = 0; i < 20; i++)
        printf("%3d", i);
    printf("\n");
    for (i = 0; i < 20; i++)
        printf("%3d", mark[i]);
    
    while (mark[m])
        m += 2;
        
    printf("\n%d", m);

    return 0;
}
