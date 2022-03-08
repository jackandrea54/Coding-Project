// 0 1 2 3 4 5 (index)
// 5 1 2 6 4 3 (card)
// 4 | 1 2 6 5 3
// 4 6 | 2 1 5 3

// cardsLeft = 6
// i = 0
// j = i + rand() % cardsLeft = 0 + rand() % 6 -> [0, 5] = 4

// cardsLeft = 5
// i = 1                        1 +  [0, 4]
// j = i + rand() % cardsLeft = 1 + rand() % 5 -> [1, 5] = 3

// cardsLeft = 4
// i = 2                        2 +  [0, 3]
// j = i + rand() % cardsLeft = 2 + rand() % 4 -> [2, 5] = 

#include <stdio.h>
#include <stdlib.h>
#include <time.h>

void linear_shuffle(char card[], int n)
{
    int i, cardsLeft, j;
    char temp;

    cardsLeft = n;
    for (i = 0; i < n; i++)
    {
        j = i + rand() % cardsLeft;
        temp = card[i];
        card[i] = card[j];
        card[j] = temp;
        cardsLeft--;
    }
}

int main()
{
    srand(time(NULL));
    int i;
    char cards[] = {'3', '4', 'Q', 'K', '9', 'J'};
    linear_shuffle(cards, 6);
    for (i = 0; i < 6; i++)
        printf("%c ", cards[i]);
    
    return 0;
}
