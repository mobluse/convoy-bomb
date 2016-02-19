( SCR 1 OF EDITOR )                                             
FORTH DEFINITIONS HEX                                           
: TEXT HERE C/L 1+ BLANKS WORD HERE PAD C/L 1+ CMOVE ;          
: LINE DUP FFF0 AND 17 ?ERROR SCR @ (LINE) DROP ;               
VOCABULARY EDITOR IMMEDIATE HEX                                 
: WHERE DUP DUP SCR ! ." SCR # " DECIMAL . SWAP C/L /MOD C/L    
* ROT BLOCK + CR C/L TYPE CR HERE C@ - SPACES 5E EMIT [COMPILE] 
EDITOR QUIT ;                                                   
EDITOR DEFINITIONS                                              
: #LOCATE R# @ C/L /MOD ;                                       
: #LEAD #LOCATE LINE SWAP ;                                     
: #LAG #LEAD DUP >R + C/L R> - ;                                
: -MOVE LINE C/L CMOVE ;                                        
                                                                
                                                                
  -->                                                           