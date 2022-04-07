
org 100h

mov ax, 11
mov bx, 3
         
;mul x             ; ax = al * x = 11 * 20 = 220
;imul y            ; dxax = ax * y = 220 * -500 = -110.000
                  ; dxax = FFFE5250 
div bx


ret

x db 20
y dw -500



