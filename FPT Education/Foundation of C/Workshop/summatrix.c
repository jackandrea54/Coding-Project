#include<stdio.h>
#include<stdlib.h>
#include<string.h>
#include<ctype.h>

#define max 1000
int main()
{
    long long a[max][max], b[max][max], c[max][max];
    int n, m;
    scanf("%d%d", &n, &m);
    for(int i = 1; i <= n; i++)
    	for(int j = 1; j <= m; j++)
    		scanf("%lld", &a[i][j]);

    for(int i = 1; i <= n; i++)
	    for(int j = 1; j <= m; j++)
	    	scanf("%lld", &b[i][j]);

    for(int i = 1; i <= n; i++)
	    for(int j = 1; j <= m; j++)
	    	c[i][j] = a[i][j] + b[i][j];

    for(int i = 1; i <= n; i++)
    {
    	for(int j = 1; j <= m; j++)
	    {
	        printf("%lld ", c[i][j]);
	    }
	    printf("\n");
    }
}
