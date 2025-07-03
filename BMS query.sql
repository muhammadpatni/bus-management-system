use BMS;
alter table Users drop column Role;
select*from Users;
insert into	Users(Name, Phone_No,CNIC, Gmail, Username, Password)values
('haram zainab','03152958789','	4240170756572','haramzainab@gmail.com','haram zainab','user123')
,('arwa','03152958789','	4240170756572','haramzainab@gmail.com','haram zainab','user123')
;
delete from Users ;