person = {
    "name": "Spiderman",
    "description": "Out of date",
    "Status": "Not belongs to Marvel"
}
print(person)
key = input("What key do you want to delete: ")
del person[key]
print(person)