import random
def greatest_division(a,b):
    if a == b:
        result= a
    elif a>b:
        result = greatest_division(b,a-b)
    else:
        result = greatest_division(a,b-a)
    return result
a = int(input("Số thứ nhất"))
b = int(input("số thứ hai"))
result = greatest_division(a,b)
print("Ước chung lớn nhất là:",result)