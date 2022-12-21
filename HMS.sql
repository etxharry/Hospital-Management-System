create database hospital;
create table AddPatient
(
Name varchar(150),
Full_Address varchar(300),
Contact bigint,
Age int,
Gender varchar(10),
Blood_Group varchar(20),
Major_Disease varchar(400),
pid bigint unique,
)

select *from AddPatient;


ALTER TABLE AddPatient ADD Symptoms NVARCHAR(150) NULL;
ALTER TABLE AddPatient ADD Diagnosis NVARCHAR(150) NULL;
ALTER TABLE AddPatient ADD Medicines NVARCHAR(150) NULL;
ALTER TABLE AddPatient ADD Ward NVARCHAR(150) NULL;
ALTER TABLE AddPatient ADD Ward_type NVARCHAR(150) NULL;
