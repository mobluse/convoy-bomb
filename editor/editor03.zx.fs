( SCR 3 OF EDITOR - CLEVER ONES)                                
FORTH DEFINITIONS                                               
: 2DROP DROP DROP ;                                             
: 2SWAP ROT >R ROT R> ;                                         
EDITOR DEFINITIONS                                              
: -TEXT SWAP -DUP IF OVER + SWAP DO DUP C@ FORTH I C@           
- IF 0= LEAVE ELSE 1+ THEN LOOP ELSE DROP 0= THEN ;             
: MATCH >R >R 2DUP R> R> 2SWAP OVER + SWAP DO 2DUP FORTH I      
-TEXT IF >R 2DROP R> - I SWAP - 0 SWAP 0 0 LEAVE THEN LOOP      
2DROP SWAP 0= SWAP ;                                            
: 1LINE #LAG PAD COUNT MATCH R# +! ;                            
: FIND BEGIN 3FF R# @ < IF TOP PAD HERE C/L 1+ CMOVE 0          
ERROR ENDIF 1LINE UNTIL ;                                       
: DELETE >R #LAG + FORTH R - #LAG R MINUS R# +! #LEAD + SWAP    
CMOVE R> BLANKS ; : N FIND 0 M ;                                
: F 1 TEXT N ;  -->                                             