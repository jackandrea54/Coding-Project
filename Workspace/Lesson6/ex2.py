while True: 
    x = input("Your password: ")
    if x.isalpha():
        print("invalid")
    else:
        print("Ok")
        break    