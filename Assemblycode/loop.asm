include "emu8086.inc"

org 100h

    print "Input n = "
    call scan_num
    
start_loop:
    ; loop body code here
    add sum, cx                   
    loop start_loop
    ;end of loop
    
printn
print "sum = "
mov ax, sum
call print_num                   
                                    
ret

DEFINE_SCAN_NUM
DEFINE_PRINT_NUM
DEFINE_PRINT_NUM_UNS
    
i dw 1
sum dw 0 




