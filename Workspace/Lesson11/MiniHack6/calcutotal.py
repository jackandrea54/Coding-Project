shop1={
    "HP": 20,
    "DELL": 50,
    "MACBOOK": 12,
    "ASUS": 30,
}
shop1["TOSHIBA"]=10
shop1["FUJITSU"]=15
shop1["ALIENWARE"]=5
shop2={
    "HP": 600,
    "DELL": 650,
    "MACBOOK": 12000,
    "ASUS": 400,
    "ACER": 350,
    "TOSHIBA": 600,
    "FUJITSU": 900,
    "ALIENWARE": 1000,
}
i=0
for k in shop1.keys():
    i+=shop1[k]*shop2[k]
print("Total price of all:",i)