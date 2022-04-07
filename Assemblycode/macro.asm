include "emu8086.inc"
org 100h
    mov ax, 19
    
    call mulProc
    printn
    
    divMacro x, y

ret

DEFINE_PRINT_NUM
DEFINE_PRINT_NUM_UNS

x db 5
y db 7


mulProc PROC    ; procedure declare
    push ax ; push ax to stack to save ax data
    mov al, x
    mul y
    
    print "x * y = "
    call print_num    
    pop ax  ; take back the value of ax on stack
ret
ENDP            ; end procedure  


divMacro MACRO a, b  ; macro declare
    push ax  ; push ax to stack to save ax data
    
    mov al , b  ; mov y to ax
    div a       ; call div x to divide y by x
    print "y / x = "
    mov bh, ah  ; mov remainder from ah to bh to save remainder 
    mov ah, 0   ; clear ah, so ax is quotient
    call print_num
    print " - remainder = "
    mov al, bh  ; mov remainder from bh to al to print 
    call print_num
                    
    pop ax
ENDM