#include<stdio.h>
#include<stdlib.h>

int main(){
    int n, a[100], b[100], total = 0;
    scanf("%d", &n);
    for(int i = 1; i <= n; i++)
    scanf("%d", &a[i]);
    for(int i = 1; i <= n; i++)
    scanf("%d", &b[i]);
    for(int i = 1;i <= n; i++)
    total += a[i]*b[i];
    printf("%d", total);

}