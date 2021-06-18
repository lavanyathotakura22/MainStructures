 CREATE TABLE OPERATORS1(id int,name varchar(50),eng int,hindi int,math int,totalmarks int,avg int ,sal int)


 insert into OPERATORS1(id,name,Eng,hindi,math)values(1,'A',65,58,49)  
insert into OPERATORS1(id,name,Eng,hindi,math)values(2,'B',45,33,41)  
insert into OPERATORS1(id,name,Eng,hindi,math)values(3,'C',65,88,35)  
insert into OPERATORS1(id,name,Eng,hindi,math)values(4,'D',61,88,62)  
insert into OPERATORS1(id,name,Eng,hindi,math)values(5,'E',41,81,81) 
insert into OPERATORS1(id,name,Eng,hindi,math)values(4,'D',61,88,62)  
insert into OPERATORS1(id,name,Eng,hindi,math)values(5,'E',41,81,81) 

 select * from OPERATORS1
 --ARTHEMATIC OPERATORS             +,-,*,/, %
   Update OPERATORS1 set Totalmarks =Eng+hindi+math  
 update OPERATORS1 set avg=Totalmarks /3 
 begin transaction rollback

  
 Select * from OPERATORS1 where id=4 

 
 CREATE TABLE OPERATORS2(id int,name varchar(50),eng int,hindi int,math int,totalmarks int,avg int)
 insert into OPERATORS2(id,name,Eng,hindi,math)values(6,'f',65,58,49)  
insert into OPERATORS2(id,name,Eng,hindi,math)values(7,'g',45,33,41)  
insert into OPERATORS2(id,name,Eng,hindi,math)values(8,'h',65,88,35)  
insert into OPERATORS2(id,name,Eng,hindi,math)values(4,'D',61,88,62)  
insert into OPERATORS2(id,name,Eng,hindi,math)values(5,'j',41,81,81) 
 select * from OPERATORS2
 Update OPERATORS2 set Totalmarks =Eng+hindi+math  
 update OPERATORS2 set avg=Totalmarks /3 
 
 --set operators--(union,unionall, intersect, except)
 Select * from OPERATORS1 Union   Select * from OPERATORS2    --prints with out duplicates
Select * from OPERATORS1 Union all Select * from OPERATORS2   --prints duplicates
Select * from OPERATORS1 intersect   Select * from OPERATORS2 
Select * from OPERATORS1 except   Select * from OPERATORS2 

--logical operators(AND , OR , NOT )

SELECT * FROM OPERATORS1 WHERE totalmarks >= 120 AND totalmarks<= 200;
SELECT * FROM OPERATORS1 WHERE name ='D'  OR name = 'E'
SELECT * FROM OPERATORS1 WHERE (totalmarks >= 120 AND totalmarks<= 200) OR NOT name='D'

--comparison operators(> ,< ,<= ,>= ,!=,!<,!>,<>)

SELECT * FROM OPERATORS1 WHERE name = 'D'
SELECT * FROM OPERATORS1 WHERE name != 'D'
SELECT * FROM OPERATORS1 WHERE name <> 'D'  --digfference is IOS standard
SELECT * FROM OPERATORS1 WHERE id !< 5

--special operators (ANY,ALL,IN ,BETWEEN,LIKE)
SELECT * FROM OPERATORS1 WHERE id BETWEEN 3 AND 7
SELECT * FROM OPERATORS1 WHERE id not BETWEEN 3 AND 7
SELECT * FROM OPERATORS1 WHERE name IN ('D','E')
create table liking operatorss