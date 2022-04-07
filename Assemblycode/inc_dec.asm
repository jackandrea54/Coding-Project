
org 100h

mov ax, 8
mov bx, 3
 
inc ax  ; ax++
dec bx  ; bx--

not ax  ; nghich dao cac bit 
        ; ax = 0009h = 0000.0000.0000.1001
        ; not ax     = 1111.1111.1111.0111 = FFF6h  
        
neg bx  ; bx = -bx

ret




