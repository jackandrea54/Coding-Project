include "emu8086.inc"

org 100h

    print "Input a = "
    call scan_num ; scan store to cx
    mov ax, cx    ; number a is stored in ax
    
    printn
    print "Input b = "
    call scan_num
    mov bx, cx    ; number b is stored in bx
    
    printn
    
    cmp ax, bx    ; compare ax(a) and bx(b)
    jg greater    ; 1st case: jump to greater and print a > b
    je equal      ; 2nd case: jump to equal and print a = b
    jl less       ; 3rd case: jump to less and print a  b
              
greater:                                     
    print "a > b"  
    jmp exit

equal:
    print "a = b"
    jmp exit
    
less:
    print "a < b"

exit:

ret

DEFINE_SCAN_NUM



