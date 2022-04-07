items = ["dota", "lol","csgo","Apex","Excel"]
while True:    
    choice = input("Bạn chọn  thao tác nào trong 4 thao tác (C, R, U, D): ")
    if choice == "C":
        create = input("Bạn thích thêm gì: ")
        items.append(create)
        print(items)
    if choice == "R":
        if len(items) == 0:
            print("Danh sách rỗng")
        elif len(items) != 0:    
            for i in range(0, len(items)):
                print(items[i])    
    if choice == "U":
        update = int(input("Vị trí muốn thay đổi: "))
        replace_item = input("Muốn thay bằng gì: ")
        items[update] = replace_item
        print(items)
    if choice == "D":
        delete = int(input("Xóa vị trí nào: "))
        items.pop(delete)
        print(items)