while True:
    name = input("Whats your name: ")
    if name.isalpha() or len(name) <= 8:
        print("invalid")
    else:
        print("OK")
        break    
