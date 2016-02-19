( RANDOM NUMBER GENERATOR --                                    
  HIGH LEVEL )                                                  
                                                                
0 VARIABLE RND    HERE RND !                                    
: RANDOM  RND @ 31421 *                                         
    6927 + DUP RND ! ;                                          
: CHOOSE  ( U1 --- U2 )                                         
    RANDOM U* SWAP DROP ;                                       
                                                                
( WHERE  CHOOSE  RETURNS A                                      
  RANDOM INTEGER WITHIN THE                                     
  RANGE 0 = OR < U2 < U1. )                                     
                                                                
;S                                                              
                                                                
                                                                