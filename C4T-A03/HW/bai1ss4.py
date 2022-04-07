def factorial(n):
    if n == 1:
        numbfactorial = 1
    elif n>1:
        numbfactorial = n*factorial(n-1)
    return numbfactorial
n =int(input("Nhap so giai thua:")) 
numbfactorial = factorial(n)
print("Giai thua la {}".format(numbfactorial))