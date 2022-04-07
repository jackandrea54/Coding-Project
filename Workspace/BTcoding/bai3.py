alist = []
while True:
    x = int(input("Enter your number:"))
    check = input("Do you want to continue (Yes/No): ")
    checkconfirm = check.lower()
    
    alist.append(x)
    last = len(alist) - 1
    if checkconfirm == "no":
        if alist[0] == alist[last]:
            print("Bằng nhau")
        break