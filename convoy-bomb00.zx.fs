( GRAFISKA KOMMANDON:PLOT                            UNPLOT)    
                                                                
FORTH DEFINITIONS HEX                                           
: PIT ;CODE E1 C, D1 C, C5 C, 4D C, 43 C, CD C, 0BB2 , C1 C,    
 C3 C, NEXT , SMUDGE PIT                                        
: PIT1 4030 C! PIT ;                                            
: PLOT1 ( Y X --- ) 9B PIT1 ;                                   
: UNPLOT1  ( Y X --- ) A0 PIT1 ;                                
DECIMAL                                                         
: ?UTANF0R OVER OVER >R >R R -1 > R 44 < AND R> DROP R -1 >     
R 64 < AND R> DROP AND ;                                        
: 2DROP DROP DROP ;                                             
: PLOT ?UTANF0R IF PLOT1 ELSE 2DROP ENDIF ;                     
: UNPLOT ?UTANF0R IF UNPLOT1 ELSE 2DROP ENDIF ;                 
                                                                
;S                                                              