from math import sqrt
print("ax^2+bx+c=0")
def get_delta(a,b,c):
    delta = pow(b,2) - 4*a*c
    return delta
def quadro(a,b,c):
    if delta > 0:
        nghiem1 = (-b+sqrt(delta))/(2*a) 
        nghiem2 = (-b-sqrt(delta))/(2*a) 
        return  nghiem1, nghiem2
    if delta == 0:
        nghiem = (-b)/(2*a) 
        return nghiem
    else:
        print("Chuong trinh vo nghiem")
a = int(input("Nhap a:"))
b = int(input("Nhap b:"))
c = int(input("Nhap c:"))
delta = get_delta(a,b,c)
if delta > 0:
    nghiem1, nghiem2  = quadro(a,b,c)
    print(nghiem1,nghiem2)
if delta == 0:
    nghiem = quadro(a,b,c)
    print(nghiem)