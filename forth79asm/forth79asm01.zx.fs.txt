( FORTH-79 DEFINITIONS     )                                    
FORTH DEFINITIONS DECIMAL                                       
: 1- 1 - ;                                                      
: 2- 2 - ;                                                      
: <> = 0= ;                                                     
: DEPTH ( -- N )                                                
  SP@ S0 @ SWAP - 2 / ;                                         
: PICK ( N1 -- N2 )                                             
( IF N1 >0, GET THE N1TH. NUMBER FROM THE STACK, AND RETURN     
  IT ON TOP OF THE STACK )                                      
 DEPTH 1- OVER < OVER 1 < OR                                    
( CHECK FOR BAD INDEX: LEAVE TRUE IF BAD, FALSE IF OK )         
  IF ." INDEX OUTSIDE LIMITS"                                   
     7 EMIT QUIT                                                
  ELSE DUP + SP@ + @                                            
  THEN ;                 -->                                    