
; NGUYEN DINH NGHIA-HE172579


include "emu8086.inc"
org 100h
    print "Enter a number: " ; get an input from user
    call scan_num    
    mov num, cx    ; store input in a variable
    cmp cx, 2      ; compare input with 2
    jbe prime      ; if input <= 2 then input is prime 
                   ; else find square root of input 

; Find the square root of input
findSqrt:
    mov ax, sqrt   ; store current sqrt to ax
    mul ax         ; ax = ax*ax
    cmp dx, 0      ; compare dx with 0 to know if number is ax is bigger than input limit (2 bytes)
    jne checkPrime ; if dx is not 0 then sqrt is the square root--> check Prime 
                   ; else continue to check ax
    cmp ax , num   ; check ax and input
    jae checkPrime ; if ax >= num then sqrt is the square root of input
    
    inc sqrt       ; increase sqrt to 1 then check again
    jmp findSqrt


; Check if input can be divided by any number other than 1 and itself 
checkPrime:
    mov ax, 0      ; clear ax
    mov dx, 0      ; clear dx
    mov bx, sqrt   ; store sqrt to bx to check
    cmp i, bx    ; compare current i and input's square root
    ja prime       ; if i > square root then input is a prime
    mov ax, num    ; store num in ax to divide
    div i          ; divide dxax by i, remainder is stored in dx
    cmp dx, 0      ; compare dx with 0
    je notPrime    ; if remainder = 0 then input is not a prime, else continue to check    
    
    inc i          ; increase i to 1 check prime.
    jmp checkPrime    
    
    


; If input is not a prime    
notPrime:
    printn
    mov ax, num    ; store num to ax to print
    call print_num ; print out the num
    print " is not a prime." 
    jmp exit    


; If input is a prime
prime:   
    printn 
    mov ax, num    ; store num to ax to print
    call print_num ; print out the num
    print " is a prime." 

exit:
ret
num dw 0
i dw 2
sqrt dw 1
DEFINE_SCAN_NUM
DEFINE_PRINT_NUM
DEFINE_PRINT_NUM_UNS


