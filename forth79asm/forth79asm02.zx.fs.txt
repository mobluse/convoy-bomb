( FORTH-79 DEFINITIONS     )                                    
: ROLL ( N -- RE-ARRANGED STACK )                               
  >R R PICK SP@ DUP 2+ R> DUP + CMOVE DROP ;                    
: >< ( SWAP BYTES )  ( FORTH DEF. )                             
  DUP 256 / SWAP 255 AND 256 * + ;                              
VOCABULARY FORTH-79 IMMEDIATE                                   
FORTH-79 DEFINITIONS DECIMAL                                    
: CREATE ( AGREES WITH BRODIE )                                 
  0 VARIABLE -2 ALLOT ;                                         
: WORD ( -- ADDRESS )                                           
  WORD HERE ;                                                   
;S                                                              
                                                                
                                                                
                                                                
                                                                