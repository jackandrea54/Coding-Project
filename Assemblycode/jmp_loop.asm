include "emu8086.inc"
org 100h

; in tu 1 -> 10    
start_print:
     mov ax, i
     call print_num
     print " "
     inc i
     cmp i, 10
     jle start_print              
                                    
ret
DEFINE_PRINT_NUM
DEFINE_PRINT_NUM_UNS    
i dw 1    



