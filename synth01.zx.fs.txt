( SYNTHESISER CTRL-PROGRAM )                                    
: REG  159 P! ;   : READ  223 P@ ;   : WRITE  223 P! ;          
: RW  REG WRITE ;                                               
: FRQ  DUP 1+ REG SWAP 256 /MOD WRITE SWAP RW ;                 
: DEC  DECIMAL ; : BIN 2 BASE ! ;                               
: A-FRQ  0 FRQ ;   : B-FRQ  2 FRQ ;   : C-FRQ  4 FRQ ;          
: N-FRQ  6 RW ;                                                 
: ENABLE  7 RW ;                                                
16 CONSTANT EC                                                  
: A-AMP  8 RW ;   : B-AMP  9 RW ;   : C-AMP  10 RW ;            
: EP  11 FRQ ;                                                  
: ES  13 RW ;                                                   
: PORT-A  14 REG ;   : PORT-B  15 REG ;                         
                                                                
;S                                                              
                                                                