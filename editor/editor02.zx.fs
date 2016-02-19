( SCR 2 OF EDITOR )                                             
: H LINE PAD 1+ C/L DUP PAD C! CMOVE ;                          
: E LINE C/L BLANKS ;                                           
: S DUP 1 - 0E DO I LINE I 1+ -MOVE -1 +LOOP E ;                
: D DUP H 0F DUP ROT DO I 1+ LINE I -MOVE LOOP E ;              
: M R# +! CR SPACE #LEAD TYPE 5F EMIT #LAG TYPE #LOCATE         
. DROP ; : T DUP C/L * R# ! DUP H 0 M ;                         
: L SCR @ LIST 0 M ;                                            
: R PAD 1+ SWAP -MOVE ;                                         
: P 1 TEXT R ;                                                  
: I DUP S R ;                                                   
: TOP 0 R# ! ;                                                  
: CLEAR DUP FIRST ! SCR ! 10 0 DO FORTH I EDITOR E LOOP ;       
                                                                
                                                                
 -->                                                            