( RAM DISC SIMULATION OF   )                                    
( SCR # 1000 TO SCR # 1007 )                                    
FORTH DEFINITIONS DECIMAL       8192 DUP BLANKS                 
: FLUSH FIRST @ 999 > FIRST                                     
@ 1008 < AND IF FIRST @                                         
BLOCK FIRST @ 1000 - 1024                                       
* 8192 + 1024 CMOVE ELSE                                        
FLUSH ENDIF ;                                                   
: GETSCR DUP DUP 999 > SWAP                                     
1008 < AND DUP IF SWAP DUP      FIRST                           
! 1000 - 1024 * 8192 + FIRST                                    
@ BLOCK 1024 CMOVE ENDIF ;                                      
: LOAD GETSCR IF FIRST @                                        
LOAD ELSE LOAD ENDIB ;                                          
: BACKUP 0 DO DUP I 1000 +      GETSCR DROP I + FIRST !         
FLUSH LOOP ; : LIST GETSCR  IF FIRST @ LIST ELSE LIST ENDIF ; ;S