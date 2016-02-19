( ASSEMBLER 6              )                                    
ASSEMBLER DEFINITIONS HEX                                       
 B2 2BYTE INIR B3 2BYTE OTIR                                    
 B8 2BYTE LDDR B9 2BYTE CPDR                                    
 BA 2BYTE INDR BB 2BYTE OTDR                                    
: 2BZ80 <BUILDS C, DOES>                                        
  CB C, C@ + C, ;                                               
 00 2BZ80 RLCZ 08 2BZ80 RRCZ                                    
 10 2BZ80 RL   18 2BZ80 RR                                      
 20 2BZ80 SLA  28 2BZ80 SRA                                     
               38 2BZ80 SRL                                     
FORTH DEFINITIONS DECIMAL ;S                                    
Z80 MNEMONICS   FORTH MNEMON                                    
    CPI               CPII                                      
    RLC               RLCZ                                      
    RRC               RRCZ                                      