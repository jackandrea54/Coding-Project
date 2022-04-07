
; NGUYEN DINH NGHIA - HE172579

include "emu8086.inc"
org 100h
    print "Input n: " 
    call scan_num     ; Get input from user
    mov ax, cx        ; Store input in ax to convert to hex 
    printn
    print "Convert "
    call print_num
    print " to hexadecimal: " 
    cmp cx, 0         ; Check if input is 0
    je print0         ; If input = 0 then print 0
    jmp convert       ; else convert input to hexadecimal

; Convert all input to hexadecimal digits and push into stack    
convert:
    cmp ax, 0         ; Check if ax is now 0
    je printHex       ; If ax is 0 then print out the number
                      ; else continue
    div hex           ; divide dxax by 16, remainder store in dx
    push dx           ; push remainder to stack
    mov dx, 0         ; reset remainder (dx) to 0
    inc i             ; increase i by 1 to count number of digits 
    jmp convert       ; loop over again


; Print all the hexadecimal digits on stack
printHex:
    cmp i, 0          ; check if there is any digits left in stack
    je exit           ; If there is none then exit
    pop ax            ; Take from stack then store in ax
    cmp ax, 10        ; Compare ax with 10
    jae printChar     ; If ax >= 10 then print characters                
    call print_num    ; else print the digit                 
    dec i             ; decrease i by 1
    jmp printHex      ; loop over
    
; Print character     
printChar:
   cmp ax, 10         ; check if ax is 10
   je printA          ; ax = 10 then print A
   cmp ax, 11         ; check if ax is 11
   je printB          ; ax = 11 then print B
   cmp ax, 12         ; check if ax is 12
   je printC          ; ax = 12 then print C
   cmp ax, 13         ; check if ax is 13
   je printD          ; ax = 13 then print D
   cmp ax, 14         ; check if ax is 14
   je printE          ; ax = 14 then print E
   cmp ax, 15         ; check if ax is 15
   je printF          ; ax = 15 then print F
        
   jmp printHex       ; loop over
  
printA:
    print "A"         ; print A
    dec i             ; decrease i by 1
    jmp printHex    
printB:
    print "B"         ; print B
    dec i             ; decrease i by 1
    jmp printHex
printC:
    print "C"         ; print A
    dec i             ; decrease i by 1
    jmp printHex
printD:
    print "D"         ; print A
    dec i             ; decrease i by 1
    jmp printHex
printE:
    print "E"         ; print A
    dec i             ; decrease i by 1
    jmp printHex
printF:
    print "F"         ; print A
    dec i             ; decrease i by 1
    jmp printHex    

print0:
    print "0"    
exit:
ret

DEFINE_SCAN_NUM
DEFINE_PRINT_NUM
DEFINE_PRINT_NUM_UNS

hex dw 16     ; hold the number to convert
i db 0        ; count number of digit in stack
