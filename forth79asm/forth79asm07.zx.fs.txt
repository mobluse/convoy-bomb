( ASSEMBLER 5              )                                    
ASSEMBLER DEFINITIONS HEX                                       
NEXT 1 - CONSTANT HPUSH                                         
NEXT 2 - CONSTANT DPUSH                                         
: END-CODE [COMPILE] C; ;                                       
 D9 1MI EXX                                                     
: BITAD <BUILDS C, DOES> CB                                     
  C, C@ SWAP 8* + + C, ;                                        
 40 BITAD BIT                                                   
 80 BITAD RES                                                   
 C0 BITAD SET                                                   
: 2BYTE <BUILDS C, DOES> ED C, C@ C, ;                          
67 2BYTE RRD  6F 2BYTE RLD      A0 2BYTE LDI  A1 2BYTE CPII     
A2 2BYTE INI  A3 2BYTE OUTI     A8 2BYTE LDD  A9 2BYTE CPD      
AA 2BYTE IND  AB 2BYTE OUTD     B0 2BYTE LDIR B1 2BYTE CPIR     
FORTH DEFINITIONS DECIMAL       -->                             