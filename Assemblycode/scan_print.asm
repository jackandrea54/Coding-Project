include "emu8086.inc"

org 100h

printn "What's your name?" ; 
                              
; let user input name from keyboard
mov dx,20         ; store buffer size in dx
lea di, buffer    ; lea = Load Effective Address
call get_string   ; call get_string procedure to input name from keyboard

printn
print "Hello "
lea si, di        ; load buffer address from di to si
call print_string ; call print_string to print user's name

printn
printn "How old are you?"
call scan_num     ; call scan_num to input age, the age will be stored in CX

printn
print "Your age is "   
mov ax, cx
call print_num

ret
DEFINE_PRINT_NUM
DEFINE_PRINT_NUM_UNS              
DEFINE_SCAN_NUM              
DEFINE_GET_STRING
DEFINE_PRINT_STRING

buffer db 20 dup<0> ; buffer array used to store name