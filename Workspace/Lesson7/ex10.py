while True:
    x = input("A month: ")
    if x.isdigit() and 0<int(x)<13:
        if int(x)==1 or int(x)==3 or int(x)==5 or int(x)==7 or int(x)==8 or int(x)==10 or int(x)==12:
            print("Tháng",x,"có 31 ngày")
            break
        elif int(x)==4 or int(x)==6 or int(x)==9 or int(x)==11:
            print("Tháng",x,"có 30 ngày")
            break   
        else:
            print("Tháng",x,"có 28 hoặc 29 ngày tùy năm") 
            break
    else:
        print("Invalid")