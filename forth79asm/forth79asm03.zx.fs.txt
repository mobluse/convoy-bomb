( ASSEMBLER 1              )                                    
HEX VOCABULARY ASSEMBLER IMMEDIATE   ' ASSEMBLER CFA            
' ;CODE 08 + !                                                  
: CODE ?EXEC CREATE [COMPILE] ASSEMBLER !CSP ; IMMEDIATE        
: C; CURRENT @ CONTEXT ! ?EXEC ?CSP SMUDGE ; IMMEDIATE          
: LABEL ?EXEC 0 VARIABLE SMUDGE -2 ALLOT [COMPILE] ASSEMBLER    
  !CSP ; IMMEDIATE                                              
: 8* DUP + DUP + DUP + ;                                        
ASSEMBLER DEFINITIONS                                           
4 CONSTANT H  5 CONSTANT L                                      
2 CONSTANT D  3 CONSTANT E                                      
6 CONSTANT M  6 CONSTANT SP                                     
7 CONSTANT A  6 CONSTANT PSW                                    
0 CONSTANT B  1 CONSTANT C                                      
: 1MI <BUILDS C, DOES> C@ C, ;                                  
DECIMAL            ;S                                           