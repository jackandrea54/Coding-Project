shop={
    "HP": 20,
    "DELL": 50,
    "MACBOOK": 12,
    "ASUS": 30,
}
shop["TOSHIBA"]=10
shop["FUJITSU"]=15
shop["ALIENWARE"]=5
i=0
for k in shop.values():
    i+=k
print(i)