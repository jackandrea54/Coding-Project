#Bubble sort
a = [4,8,10,5,9,7,200]
loop = True
while loop:
    loop = False
    for i in range (len(a)-1):
        if a[i] > a[i+1]: 
            a[i],a[i+1]=a[i+1],a[i]
            loop = True
print(a)   
''' 
person = {
    "name": "duc",
    "age" : 21,
    "ex": 5
}

 NOTE: loop by key
for key in person:
    print(key)

 NOTE: loop by value
for value in person.values():
    print(value)

 NOTE: loop by key and valuea
for key,value in person.items():
    print(key,value)

 NOTE: Create or Update:
 person["gender"]= "male",
 person["ex"] = 5
 print(person)

 NOTE: Delete a key
 del person["age"]
 print(person)
 
 NOTE: change a key to other key
 person["sex"]= person.pop["gender"]
 print(person)
 '''