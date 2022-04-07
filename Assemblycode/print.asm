include "emu8086.inc"
org 100h

putc 'h'
putc 'e'
putc 06ch
putc 'l'
putc 'o'     

gotoxy 37, 12   
putc 'w'
putc 'o'
putc 'r'
putc 'l'
putc 'd'  

printn "How are you man?"
print " I'm fine!"
print "And you?"

ret             

arr db "hello",0




