from random import randint
score=0
while True:
    numb1 = randint(1,30)
    numb2 = randint(1,30)
    false_result = randint(-3, 3)
    sum = numb1 + numb2 + false_result
    print("{} + {} = {}".format(numb1, numb2, sum))

    answer = input("F or T ?")

    if false_result == 0:
        if answer == 't':
            print("Correct")
            score +=1
            print("Your score is: {}".format(score))
        if answer == 'f':
            print("Game over")
            print("Your total score is: {}".format(score))
            break
    if false_result != 0:        
        if answer == 'f':
            print("Correct")
            score +=1
            print("Your score is: {}".format(score))
        if answer == 't':
            print("Game over")
            print("Your total score is: {}".format(score))
            break