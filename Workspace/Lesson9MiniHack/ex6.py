numbs = ["2","5","92","84","-99"]
choice = int(input("What number: "))
for i in range(0,len(numbs)):
    if choice == int(numbs[i]):
        print("Found,","Position:",i+1)
        break
    elif i == len(numbs)-1:
        print("Not found")