

create table Uslugi (
id_uslugi int not null IDENTITY(1,1),
Title nvarchar(40) not null,
Stoimost decimal not null,
Discont decimal not null,
photo varbinary(max)
)

alter table Uslugi
add Primary key (id_uslugi)


INSERT INTO  Uslugi(Title,Stoimost,Discont,photo)
SELECT 'Ремонт подвески','1000','10', BulkColumn
FROM Openrowset( Bulk 'C:\Users\Курсовые проекты\Desktop\DataService\1.png', Single_Blob) as EmployeePicture


INSERT INTO  Uslugi(Title,Stoimost,Discont,photo)
SELECT 'Ремонт ремонта','2000','0', BulkColumn
FROM Openrowset( Bulk 'C:\Users\Курсовые проекты\Desktop\DataService\2.png', Single_Blob) as EmployeePicture



INSERT INTO  Uslugi(Title,Stoimost,Discont,photo)
SELECT 'Замена ремня ГРМ','3000','20', BulkColumn
FROM Openrowset( Bulk 'C:\Users\Курсовые проекты\Desktop\DataService\3.png', Single_Blob) as EmployeePicture




INSERT INTO  Uslugi(Title,Stoimost,Discont,photo)
SELECT 'Замена масла двигателя','5000','30', BulkColumn
FROM Openrowset( Bulk 'C:\Users\Курсовые проекты\Desktop\DataService\4.png', Single_Blob) as EmployeePicture


INSERT INTO  Uslugi(Title,Stoimost,Discont,photo)
SELECT 'Замена маслянного фильтра','1000','50', BulkColumn
FROM Openrowset( Bulk 'C:\Users\Курсовые проекты\Desktop\DataService\5.png', Single_Blob) as EmployeePicture

