person = {
    "name": "Spiderman",
    "description": "Out of date",
    "Status": "Not belongs to Marvel"
}
print(person)
key = input("What key do you choose: ")
value = input("What to update: ")
person[key]= value
print(person)