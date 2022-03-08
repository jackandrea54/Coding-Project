/*
s = 0
11 % 2 = 1 -> 1 * 0 + 1 = 1
 5 % 2 = 1 -> 10 * 1 + 1 = 11
 2 % 2 = 0 -> 100 * 0 + 11 = 011
 1 % 2 = 1 -> 1000 * 1 + 011 = 1011
 
11 % 2 = 1 -> [1] 
 5 % 2 = 1 -> [1, 1]
 2 % 2 = 0 -> [1, 1, 0]
 1 % 2 = 1 -> [1, 1, 0, 1] -> 1011
*/

#include <stdio.h>

int main()
{
    long n;
    unsigned char bin[64], len = 0;
    
    scanf("%ld", &n);
    
    do
    {
        bin[len++] = n % 2;
        n /= 2;    
    } while (n);
    
    while (len--)
        printf("%d", bin[len]);

    return 0;
}

