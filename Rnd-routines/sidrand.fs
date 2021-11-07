  
\ Random number routines 
\ JK  2021 , v 0.3

\ Ref: https://www.atarimagazines.com/compute/issue72/random_numbers.php

\ sidrnd uses voice 3 noise generator,
\ may conflict with music playing routines 
\ fast, can't be seeded. 

\ code sidini
\    $ff lda,#    ( maximum frequency )
\    $d40e sta, ( v3 frequency low byte )
\    $d40f sta, ( v3 frequency high byte )
\    $80 lda,#  ( noise wavef, gate off )
\    $d412 sta, ( voice 3 control register )
\    ;code 

: sidini ( -- )  ( voice 3 max freq noise )
   $ffff $d40e !
   $80  $d412 c!  ;

: sidrnd ( -- c ) ( return random byte )
   $D41B c@  ;
   


$400 constant screen

: testy page
  10 0 do -1 0 do sidrnd 2* screen + 
    dup  @ 1+ swap ! loop loop
  14 0 do cr loop    
;

: testy2 page
  10 0 do -1 0 do rnd $ff and 2* screen + 
    dup  @ 1+ swap ! loop loop
  14 0 do cr loop    
;


hex
: testy3 200 0 do rnd $0f and . loop ; 
decimal 

hex
: testy4 200 0 do sidrnd $3f and . loop ; 
decimal 

hex
: testy5 200 0 do rnd 100/ $f and . loop ; 
decimal 

\ LFSR comes later..  
