print("Welcome to ex11.py!!! Please register!!!")
u = input("Your username:")
p = input("Your password:")
while True:
    p2 = input("Repeat your password: ")
    if p2==p:
        break
    else:
        print("Not correct")
e = input("Your email:")    