
org 100h    
; this is the way to comment in assembly

mov ax, 10001b      ; ax = 1234
mov bh, al        ; bh = al
mov cx, ax        ; cx = ax
mov ax, y
mov x, cl    

mov bx, 3
mov al, arr2[bx]    ; chi co the dung register lam index cua mang, khong duoc dung variable
mov bl, arr1[2]

ret       
; int x = 0 (in C)        
;(in Assembly- name Datatype value)              
x db 0      ; int x = 0     ; db = data byte = 1 bytes
y dw 1456   ; long y = 1456 ; dw = date word = 2 bytes
arr1 db "Hello",0
arr2 db 10,11,12,13,14
                                                          
                                                         



