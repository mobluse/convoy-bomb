( ASSEMBLER 4              )                                    
ASSEMBLER DEFINITIONS HEX                                       
: ENDIF 2 ?PAIRS HERE SWAP ! ;                                  
: THEN [COMPILE] ENDIF ;                                        
: IF C, HERE 0 , 2 ;                                            
: ELSE 2 ?PAIRS C3 IF ROT                                       
  SWAP ENDIF 2 ;                                                
: BEGIN HERE 1 ;                                                
: UNTIL SWAP 1 ?PAIRS C, , ;                                    
: AGAIN 1 ?PAIRS C3 C, , ;                                      
: WHILE IF 2+ ;                                                 
: REPEAT >R >R AGAIN R> R>                                      
  2 - ENDIF ;                                                   
FORTH DEFINITIONS DECIMAL                                       
-->   ( LOAD Z80-ADDITION )                                     
                                                                