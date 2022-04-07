numb = int(input("Nhập vào một số: "))
check = False
if numb < 2:
    print(numb,"không phải số nguyên tố")
elif numb >= 2:
    for i in range(2,numb):
        if numb % i == 0:
            print(i)
            check = True
            break
if check == True:
    print("{} không là một số nguyên tố".format(numb))
elif check == False:
    print("{} là một số nguyên tố".format(numb))