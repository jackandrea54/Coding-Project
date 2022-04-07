include 'emu8086.inc'
org 100h

    print "nhap a = "
    call scan_num 
    printn
    mov a, cx
    print "nhap b = "
    call scan_num
start:    
    cmp a, cx
    je ketthuc
    jg lonhon
    jb behon
lonhon:
    sub a, cx
    jmp start
behon:
    sub cx, a
    jmp start

ketthuc:
    printn
    print "uoc chung lon nhat la: "
    mov ax, a
    call print_num    

ret
DEFINE_SCAN_NUM
DEFINE_PRINT_NUM
DEFINE_PRINT_NUM_UNS
a dw 1

