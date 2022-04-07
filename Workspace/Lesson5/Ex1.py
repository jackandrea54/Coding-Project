while True:
    txt = input("Give me a number: ")
    if txt.isdigit():
        print("A number")
        break
    else:
        print("Not a number") 
print(2019 - int(txt))        