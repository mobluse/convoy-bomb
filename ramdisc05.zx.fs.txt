( DEF-OF, SKRIVER UT DEFINITIONER )                             
: DEF-OF  CR ." : " [COMPILE] ' DUP 2 - SWAP                    
    BEGIN DUP ' LIT = IF DROP 2+ DUP @ . ELSE                   
          DUP ' (DO) = IF ." DO " DROP ELSE                     
          DUP ' (LOOP) = IF ." LOOP " DROP 2+ ELSE              
          DUP ' (+LOOP) = IF ." +LOOP " DROP 2+ ELSE            
          DUP ' (.") = IF DROP 2+ COUNT 2DUP ." ." 34 EMIT      
                          SPACE TYPE 34 EMIT SPACE + 2 - ELSE   
          DUP DUP ' BRANCH = SWAP ' 0BRANCH = OR IF NFA ID.     
            2+ DUP ." [ " @ . ." , ] " ELSE                     
                    NFA ID.                                     
ENDIF ENDIF ENDIF ENDIF ENDIF ENDIF                             
   2+ DUP @ 2+ DUP ' ;S = UNTIL ." ; " 2DROP ;                  
;S                                                              
                                                                
                                                                