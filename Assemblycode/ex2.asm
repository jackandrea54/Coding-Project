include "emu8086.inc"

org 100h

    print "Input n = "
    call scan_num
    printn
    
start_loop:
    mov ax, i
    call print_num
    print " + "
    add sum, ax
    inc i  
    cmp i, cx
    jb start_loop 

mov ax, i    
call print_num
add sum, ax     
print " = "
mov ax, sum
call print_num                   
                                    
ret

DEFINE_SCAN_NUM
DEFINE_PRINT_NUM
DEFINE_PRINT_NUM_UNS
    
i dw 1
sum dw 0 





