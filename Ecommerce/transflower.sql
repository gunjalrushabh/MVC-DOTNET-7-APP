show databases;
 create database if not exists transflower;
 use transflower;
 
    create table departments(
    id int,
    name varchar(20),
    location varchar(20) );

insert into departments values(1,'hr','pune'); 
insert into departments values(2,'accounts','delhi');        
insert into departments values(3,'it','sambhajinagar');      
insert into departments values(4,'management','mumbai');   
                                                                                                     mysql> select * from departments;  
