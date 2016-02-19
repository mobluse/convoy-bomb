( A DEFINITION OF NUMBER,                                       
  STARTING FORTH, PAGE 279 )                                    
: WITHIN  >R 1 - OVER < SWAP                                    
    R> < AND ;                                                  
0 VARIABLE PUNCT                                                
: NUMBER ( ADR -- N OR D )                                      
    ( PUNCTUATIONS:  ,:-./ )                                    
    0 PUNCT ! DUP 1+ C@ 45 =                                    
    DUP >R + 0. ROT BEGIN                                       
    (NUMBER) DUP C@ 32 -                                        
    WHILE DUP C@ DUP 58 =                                       
    SWAP 44 48 WITHIN + DUP                                     
    PUNCT ! 0= 0 ?ERROR                                         
    REPEAT DROP R> IF DMINUS                                    
    THEN PUNCT @ 0= IF DROP                                     
    THEN ;                ;S                                    