def sumdigit(n):
    if n <10 :
        numbsum = n
    elif n>=10:
        numbsum = n%10 + sumdigit(n//10)
    return numbsum
n =int(input("Nhap so n:")) 
numbsum = sumdigit(n)
print("Tong cac chu so la {}".format(numbsum))