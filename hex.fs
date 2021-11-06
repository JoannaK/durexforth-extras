

\ Couple utility routines, jk oct/nov 2021
\ 

: h2. ( n -- )   \ print hexbyte
base @ swap 
hex  0 
<# # # $24 hold #> type space
base ! ;

: h4. ( n -- ) \ print hexword
base @ swap 
hex  0 
<# # # # # $24 hold #> type space
base ! ;

\ hexdump , F2012 compatible, though code is a bit ugly 
: dump ( addr u  -- ) 
 swap 2dup 
 h4.  
 1- 
 begin 
 over c@ h2.  
 dup while 
 swap 1+  
 swap 1-  
 over $7 and 0= if
  cr over h4. 
 then 
 repeat 
 drop cr 1+ 
 h4. h2. ." dump " cr
 ;
 