#include <stdio.h>

int main()
{
    FILE *fp = NULL;
    int a;
    double b;
    char s[100];

    fp = fopen("out.txt", "r");

    if (fp != NULL)
    {
        fscanf(fp, "%[^\n]%*c", s);
        fscanf(fp, "%d%lf", &a, &b);

        printf("s = %s\na = %d\nb = %.1lf", s, a, b);
    }
    else
        printf("Failed to open file!");

    return 0;
}
