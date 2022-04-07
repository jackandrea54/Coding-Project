person = {
    "name": "Spiderman",
    "description": "Out of date",
    "Status": "Not belongs to Marvel"
}
key = input("Give me a key: ")
value = input("Give me a value: ")
person[key]= value
print(person)

print(person["name"])

for key, value in person.items():
    if key != "Status":
        print(key, ":", value)