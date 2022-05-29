#include <stdio.h>
#include <stdlib.h>

void get_SIN(int *SIN_arr);
int get_sum(int *SIN_arr, int is_odd_pos);
int diff(int sum);

int main() {
    int 
        *SIN_arr = (int *) malloc(9 * sizeof(int)),
        check_digit, odd_sum, even_sum, total_sum;

    if (SIN_arr != NULL) {
        get_SIN(SIN_arr);
        check_digit = SIN_arr[0];

        odd_sum = get_sum(SIN_arr, 1);
        even_sum = get_sum(SIN_arr, 0);
        total_sum = odd_sum + even_sum;

        if (diff(total_sum) == check_digit) {
            printf("Valid SIN");
        } else {
            printf("Invalid SIN");
        }

        free(SIN_arr);
    }

}

void get_SIN(int *SIN_arr) {
    int SIN, i = 0;

    printf("Input SIN : "); scanf("%d", &SIN);
    while (SIN) {
        SIN_arr[i] = SIN % 10;
        SIN /= 10;
        i++;
    }
}

int get_sum(int *SIN_arr, int is_odd_pos) {
    int i, temp, multiplier, sum = 0;
    
    if (is_odd_pos) {
        i = 1;
        multiplier = 2;
    } else {
        i = 2;
        multiplier = 1;
    }

    for (i; i < 9; i += 2) {
        temp = SIN_arr[i] * multiplier;
        sum += temp % 10 + temp / 10;
    }

    return sum;
}

int diff(int sum) {
    int temp;

    if (sum % 10) {
        temp = (sum / 10 + 1) * 10;
        return temp - sum;
    } else {
        return 0;
    }
}
