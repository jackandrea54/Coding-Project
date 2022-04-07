include "emu8086.inc"
org 100h
                     
print "Enter the width of rectangle: "
call scan_num         
mov width, cx     

printn
print "Enter the height of rectangle: "
call scan_num         
mov height, cx      

mov ax, width
mul height
              
printn
print "The area of rectangle is: "              
call print_num_uns


ret
DEFINE_SCAN_NUM
DEFINE_PRINT_NUM_UNS 

width dw 1 
height dw 1



