while True:
    surname = input("What's your surname: ")
    middlename = input("What's your middle name: ")
    forname = input("What's your first name: ")
    if surname.isalpha() and forname.isalpha():
        print("Your full name is: ",surname,middlename, forname)
        break