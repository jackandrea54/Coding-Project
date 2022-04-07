shop={
    "HP": 20,
    "DELL": 50,
    "MACBOOK": 12,
    "ASUS": 30,
}
shop["TOSHIBA"]=10
shop["FUJITSU"]=15
shop["ALIENWARE"]=5
pro=input("What product:")
numb=int(input("How many:"))
shop[pro]-=numb
for k,v in shop.items():
    print(k,v,sep=":")