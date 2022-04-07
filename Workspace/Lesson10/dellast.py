person1 = {
    "Name":"Huy",
    "Role":"Waiter",
    "Hours": 12,
    "Salary per Hour": 0.8,
}

person2 = {
    "Name":"Tung",
    "Role":"Cook",
    "Hours": 24,
    "Salary per Hour": 1.5,
}
person3 = {
    "Name":"M.Duc",
    "Role": "Manager",
    "Hours": 20,
    "Salary per Hour": 2
}

person_list= [person1,person2,person3]
person_list.pop(2)
print(person_list)