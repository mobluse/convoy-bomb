( BLANDADE NYTTIGHETER )                                        
: 1-  1 - ;                                                     
: 2-  2 - ;                                                     
: 2DROP  DROP DROP ;                                            
: <ROT  ROT ROT ;                                               
: <CMOVE  <ROT SWAP ROT 1- -1 SWAP                              
    DO 2DUP I + C@ SWAP I + C! -1 +LOOP 2DROP ;                 
: DEPTH ( -- N ) SP@ S0 @ SWAP - 2 / ;                          
: PICK ( N1 -- N2 ) DEPTH 1- OVER < OVER 1 < OR                 
   IF ." PICK OUTSIDE LIMITS" QUIT                              
   ELSE DUP + SP@ + @ THEN ;                                    
: ROLL ( N -- RE-ARRANGED STACK )                               
  >R R PICK SP@ DUP 2+ R> DUP + <CMOVE DROP ;                   
: >< ( SWAP BYTES )                                             
  DUP 256 / SWAP 255 AND 256 * + ;                              
;S                                                              