def count_remain(choc, wrap):
    if (choc < wrap):
        return 0

    new_choc = choc // wrap

    return new_choc + count_remain(new_choc + choc%wrap, wrap)

def count_max_choco(money,price,wrap):
    choc = money // price
    return choc + count_remain(choc,wrap)

money = int(input("Nhập số tiền bạn có:"))
price = int(input("Nhập số tiền mỗi viên kẹo:"))
wrap = int(input("Nhập số kẹo được cho mỗi vỏ"))

candy = count_max_choco(money,price, wrap)
print(candy)