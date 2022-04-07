while True:
    numb = input("Give me a number: ")
    if numb.isdigit():
        print (float(numb)**2)
        break
    else:
        print("Invalid")    