numbs = [2,5,92,84,-99]
choice = int(input("What number: "))
if choice in numbs:
    print("Found,","Position:",numbs.index(choice)+1)
else:
    print("Not found in list")    
