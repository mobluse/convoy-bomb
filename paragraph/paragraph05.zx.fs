( -TEXT, COMPARES STRINGS )                                     
: -TEXT ( ADR1 U ADR2 -- F )                                    
     2DUP + SWAP DO DROP 1+                                     
     DUP 1 - C@ I C@ - DUP                                      
     IF 1 SWAP +- LEAVE THEN                                    
     LOOP SWAP DROP ;                                           
                                                                
;S                                                              
                                                                
                                                                
                                                                
                                                                
                                                                
                                                                
                                                                
                                                                