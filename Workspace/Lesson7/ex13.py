print("Welcome to ex11.py!!! Please register!!!")
u = input("Your username:")
p = input("Your password:")
while True:
    p2 = input("Repeat your password: ")
    if p2==p:
        break
    else:
        print("Not correct")
while True:
    e = input("Your email:")    
    if len(e)>8 and "." in e and "@" in e:
        break
    else:
        print("Invalid")