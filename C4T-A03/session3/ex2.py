a = [4,5,1,8,9,10,5,6,4,3]
ask = input("Chon cau tra loi:")
if ask == "a":
    lista = list[0:3]
    print(lista)    
if ask == "b":
    listb = list[-3:]
    print(listb)
if ask == "c":
    list.sort()
    listc = list
    print(listc)
if ask == "d":
    list.sort(reverse=True)
    listd = list
    print(listd)

