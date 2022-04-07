
org 100h

mov ax, 2
mov bx, 3
mov cx, 4
mov dx, 5

push ax ; push value of ax to stack
push bx
push cx
push dx

pop ax  ; pop a 16bits value from stack and store in ax
pop bx
pop cx 
pop dx

ret




