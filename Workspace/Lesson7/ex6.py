i = 0
while True:
    x = input("How many number: ")
    if int(x)>0:
        for i in range(0, int(x)+1):
         print(i)
        break 
    else:
        print("Invalid")     