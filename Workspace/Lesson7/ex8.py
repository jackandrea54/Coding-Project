x = input("A number:")
while True:
    if x.isdigit():
        if int(x)>13:
            print("It's bigger than 13")
            break
        else:
            print("It's not bigger than 13")
            break
    else:
        print("Invalid")
