book = {
    "name": "Harry Potter",
    "year": 1997,
    "characters": ["Harry Potter","Ron","Luna","Hermione"],
}
book["characters"].append("Malco")
for i,v in book.items():
    if i != "characters":
        print(i,"-",v)
    else:
        print(i,"-",*v)