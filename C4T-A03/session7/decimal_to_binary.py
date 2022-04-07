numprint=[]
def decimal_to_binary(number):
    so_nguyen = number//2
    so_du = number%2
    numprint.append(so_du)
    if so_nguyen == 0 and so_du == 1:
        return 
    else:
        decimal_to_binary(so_nguyen)
number = int(input("Nhập một số thập phân: "))
decimal_to_binary(number)
for i in range(len(numprint)-1,-1,-1):
    print(numprint[i], end='')