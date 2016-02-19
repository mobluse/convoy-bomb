( ASSEMBLER 2              )                                    
ASSEMBLER DEFINITIONS HEX                                       
: 2MI <BUILDS C, DOES> C@ + C, ;                                
: 3MI <BUILDS C, DOES> C@                                       
  SWAP 8* + C, ;                                                
: 4MI <BUILDS C, DOES> C@ C, C, ;                               
: 5MI <BUILDS C, DOES> C@ C, , ;                                
00 1MI NOP  76 1MI HLT          F3 1MI DI   FB 1MI EI           
07 1MI RLC  0F 1MI RRC          17 1MI RAL  1F 1MI RAR          
E9 1MI PCHL F9 1MI SPHL         E3 1MI XTHL EB 1MI XCHG         
27 1MI DAA  2F 1MI CMA          37 1MI STC  3F 1MI CMC          
80 2MI ADD  88 2MI ADC          90 2MI SUB  98 2MI SBB          
A0 2MI ANA  A8 2MI XRA          B0 2MI ORA  B8 2MI CMP          
09 3MI DAD  C1 3MI POP          C5 3MI PUSH 02 3MI STAX         
0A 3MI LDAX 04 3MI INR          05 3MI DCR  03 3MI INX          
DECIMAL                  -->                                    