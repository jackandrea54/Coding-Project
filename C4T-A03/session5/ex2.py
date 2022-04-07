import random

def greatest_division(num1,num2):
    listnum = []
    for i in range(1,num1+1):
        if num1%i == num2%i == 0:
           listnum.append(i) 
    max = listnum[0]
    for x in range(len(listnum)):
        if listnum[x]>max:
            max = listnum[x]
    return max

max = greatest_division(random.randint(100000000000000000000000000000000, 9999999999999999999999999999999999999999999999999999999999),random.randint(1000000000000000000000000000000000000000000000000000000, 999999999999999999999999999999999999999999999999999999999999999))
print("Ước chung lớn nhất là:",max)