alist = []
while True:
    x = int(input("Enter your number:"))
    check = input("Do you want to continue (Yes/No): ")
    checkconfirm = check.lower()
    
    alist.append(x)
    last = len(alist) - 1
    matrix = alist[0]
    if checkconfirm == "no":
        for i in range (1,last):
            if matrix == alist[i]:
                alist.pop(i)
        print("Danh sach số là:",*alist)
        break