
#Cach1:
def hanoi_tower_recursion(n):
    '''algorithm to resolve hanoi_tower problem
    - n: number of disk
    - result: count number of disk movement to solve the problem
    '''
    if n == 1:
        result1 = 1
    else: 
        result1 = 2*(hanoi_tower_recursion(n-1)) + 1
    return result
n1 = int(input("So lan:"))
result = hanoi_tower_recursion(n1)
print(result)

#Cach2:
def hanoi_tower_pow(n):
    result2 = pow(2,n) - 1
    return result2
n2 = int(input("So lan:"))
result2 = hanoi_tower_pow(n1)
print(result2)