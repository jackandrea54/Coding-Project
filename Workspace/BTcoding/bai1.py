alist = []
while True:
    x = int(input("Enter your number:"))
    check = input("Do you want to continue (Yes/No): ")
    checkconfirm = check.lower()
    
    alist.append(x)
    if checkconfirm == "no":
        print("Danh sach số là:",alist)
        break
