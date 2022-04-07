include "emu8086.inc"
org 100h
    mov ax, 19
    
    call mulProc
    

ret

DEFINE_PRINT_NUM
DEFINE_PRINT_NUM_UNS

x db 5
y db 7


mulProc PROC    ; procedure declare
    push ax ; push ax into stack to preserve value in ax
    mov al, x
    mul y
    
    print "x * y = "
    call print_num    
    pop ax  ; take back the value of ax on stack
ret
ENDP            ; end procedure