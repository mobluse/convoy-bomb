( SCR 4 OF EDITOR THE LAST ONE )                                
: B PAD C@ MINUS M ;                                            
: X 1 TEXT FIND PAD C@ DELETE 0 M ;                             
: TILL #LEAD + 1 TEXT 1LINE 0= 0 ?ERROR #LEAD + SWAP -          
DELETE 0 M ;                                                    
: C 1 TEXT PAD COUNT #LAG ROT OVER MIN >R FORTH R R# +! R -     
>R DUP HERE R CMOVE HERE #LEAD + R> CMOVE R> CMOVE 0 M ;        
;S                                                              
                                                                
                                                                
                                                                
                                                                
                                                                
                                                                
                                                                
                                                                