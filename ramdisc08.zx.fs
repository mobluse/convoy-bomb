( STACKMANEUVERS COMMAND: REVERSE )                             
: 2*  DUP + ;                                                   
: REVERSE ( STACK N -- REVERSED STACK N )                       
   >R R 0 DO PAD I 2* + ! LOOP                                  
      R 0 DO PAD I 2* + @ LOOP R> ;                             
                                                                
                                                                
                                                                
                                                                
                                                                
                                                                
                                                                
                                                                
                                                                
                                                                
                                                                