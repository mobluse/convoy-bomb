( CONVOY BOMB      83.05.07)                                    
FORTH DEFINITIONS DECIMAL                                       
( SCR # 21 <GRAFIK> LOADAD.)                                    
: TASK ;                                                        
0 VARIABLE VB                                                   
0 VARIABLE N  0 VARIABLE AB                                     
: VISA-P HOME ." CONVOY BOMB" 10 SPACES ." POANG:" N @ 5 .R ;   
0 VARIABLE XF  0 VARIABLE YF                                    
: FLYGPLAN YF @ 1+ XF @ PLOT YF @ XF @ PLOT YF @ XF @ 1+ PLOT   
YF @ XF @ 2+ PLOT YF @ XF @ 3 + PLOT YF @ XF @ 4 + PLOT         
YF @ XF @ 5 + PLOT YF @ XF @ 6 + PLOT ;                         
                                                                
: FLYG YF @ 1+ XF @ 1 - UNPLOT YF @ XF @ 1 - UNPLOT FLYGPLAN 1  
XF +! XF @ 65 = IF -7 XF ! 16436 C@ 9 / 12 + YF ! VB @ IF -117 N
 +! N @ 0< IF 0 N ! THEN VISA-P THEN THEN ;                     
-->                                                             