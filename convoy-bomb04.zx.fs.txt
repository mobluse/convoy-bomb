( CONVOY BOMB      83.05.07)                                    
0 VARIABLE XB  4 VARIABLE RB    0 VARIABLE ?BOMB -1 VARIABLE ?S 
: BOM 2 XB @ 1 - PLOT 2 XB @ 1+ PLOT 3 XB @ PLOT 3 XB @ 2+      
PLOT 4 XB @ 1+ PLOT ;                                           
: SUDDA HOME 17 0 DO CR LOOP 128 SPACES ;                       
: EXPLODERA SUDDA 13 5 12 4 13 4 10 3 9 5 2 4 4 6 6 6 6 5 0 3   
0 1 15 3 14 0 8 3 6 3 4 3 3 2 3 1 2 1 3 0 13 1 12 2 12 1        
11 1 11 0 4 1 5 2 6 2 7 2 8 1 6 1 5 0 9 0 8 0 6 0 7 0 36 0      
DO YS @ + SWAP XS @ + PLOT LOOP 1 AB +! ; 0 VARIABLE YB         
: ?TRAFF YB @ RB @ - 3 < IF XB @ XS @ 3 + > XB @ XS @ 14 + <    
AND IF EXPLODERA 375 N +! VISA-P 72 XS ! ELSE BOM THEN VATTEN 0 
?BOMB ! 6 ?S ! THEN ; : FALL YB @ RB @ - XB @ UNPLOT YB @ RB @  
13 * 10 / DUP RB ! - XB @ 1+ DUP XB ! PLOT ?TRAFF ;             
: BOMBINIT 16421 @ -8321 =  IF 1 ?BOMB ! XF @ 4 + XB ! 4 RB !   
YF @ 3 + YB ! THEN ;                                            
-->                                                             