while True:
    x = input("Give me a number: ")
    if x.isdigit():
        if int(x)%2==0:
            print("It's a số chẵn")
            break   
        else:
            print("It's not a số chẵn")
            break