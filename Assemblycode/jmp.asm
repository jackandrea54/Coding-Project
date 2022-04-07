
org 100h

    mov ax, 8
    mov bx, 3
    
    jmp calc

back:
    jmp exit    
    
calc: 
    add ax, bx
    jmp back             

exit:

ret




