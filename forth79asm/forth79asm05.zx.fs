( ASSEMBLER 3              )                                    
ASSEMBLER DEFINITIONS HEX                                       
0B 3MI DCX  C9 3MI RST          D3 4MI OUT  DB 4MI IN           
C6 4MI ADI  CE 4MI ACI          D6 4MI SUI  DE 4MI SBI          
E6 4MI ANI  EE 4MI XRI          F6 4MI ORI  FE 4MI CPI          
22 5MI SHLD 2A 5MI LHLD         32 5MI STA  3A 5MI LDA          
C4 5MI CNZ  CC 5MI CZ           D4 5MI CNC  DC 5MI CC           
E4 5MI CPO  EC 5MI CPE          F4 5MI CP   FC 5MI CM           
CD 5MI CALL C0 1MI RNC          C8 1MI RZ   D0 1MI RNC          
D8 1MI RC   E0 1MI RPO          E8 1MI RPE  F8 1MI RM           
C9 1MI RET  C3 5MI JMP          F0 1MI RP                       
C2 CONSTANT 0=  D2 CONSTANT CS  E2 CONSTANT PE                  
F2 CONSTANT 0<                                                  
: NOT 8 + ; : MOV 8* 40 + + C, ; : MVI 8* 6 + C, C, ;           
: LXI 8* 1+ C, , ;                                              
DECIMAL                  -->                                    