( -- INPUT RUTINER --      )                                    
                                                                
FORTH DEFINITIONS DECIMAL                                       
                                                                
: INPUT ( --- N ) PAD 1+ 64                                     
  EXPECT .0 PAD (NUMBER)                                        
  DROP DROP ;                                                   
                                                                
: INPUT. ( --- D ) PAD 1+ 64                                    
  EXPECT .0 PAD (NUMBER)                                        
  DROP ;                                                        
                                                                
;S                                                              
                                                                
                                                                
                                                                