( AI-COMMANDS FOR FORTH )                                       
: AI ;                                                          
: ATOM ( -- ) <BUILDS 0. , ,                                    
  DOES> 0 ( -- A 0 ) ;                                          
: ATOMS ( C --- ) 0 DO ATOM LOOP ;                              
: SYMBOL ( A A A C --- ) <BUILDS DUP 1+ 0 DO , LOOP             
  DOES> 1 ( -- A 1 ) ;                                          
: (DOWN) ( A --- A A A C ) DUP @ DUP                            
   IF 2 * OVER + SWAP 2 - SWAP                                  
    DO I @ -2 +LOOP THEN ;                                      
: SYMTYPE ( A A A N -- )                                        
  REVERSE 0 DO 2- NFA ID. LOOP ;                                
                                                                
                                                                
                                                                
                                                                