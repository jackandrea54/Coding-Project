digit = 0
n = int(input("Nhập vào số cần tính: "))
while n != 0:
    n //= 10
    digit += 1
print(digit)    