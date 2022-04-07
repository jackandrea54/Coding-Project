month = int(input("What month of year: "))
if month <= 0 or month >= 13:
    print("Không hợp lệ")

if month >= 2 and month <= 4:
    print("It's Xuân")
elif month >= 5 and month <= 7:
    print("It's Hạ")
elif month >= 8 and month <= 10:
    print("It's Thu")
elif month == 11 or month == 12 or month ==1:
    print("It's Đông")