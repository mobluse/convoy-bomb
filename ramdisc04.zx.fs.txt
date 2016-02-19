( << CURSOR ROUTINES >>    )                                    
( WORKS ON MAPPED SCREEN   )                                    
                                                                
: MCLS ( MEMORY MAPS SCREEN)                                    
  HOME 704 SPACES HOME ;                                        
                                                                
: D ( DOWN ) 16442 C@ 3 > IF      16442 C@ 1 - 16442 C! 33      
  16398 +! ENDIF ;                                              
: U ( UP ) 16442 C@ 24 < IF                                     
  16442 C@ 1+ 16442 C! -33                                      
  16398 +! ENDIF ;                                              
: F ( FORWARD ) 16441 C@ 1 >                                    
  IF 16441 C@ 1 - 16441 C!        1 16398 +! ENDIF ;            
: B ( BACKWARD ) 16441 C@ 33                                    
  < IF 16441 C@ 1+ 16441 C!                                     
  -1 16398 +! ENDIF ;     ;S                                    