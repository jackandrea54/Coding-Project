from turtle import*
while True:
    R = input("Bán kính của đường tròn: ")
    if R.isdigit():
        speed(0)
        circle(float(R)*2*3.14)
        mainloop()
        break
    else:
        print("Invalid")



