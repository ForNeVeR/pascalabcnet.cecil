﻿begin
  var s := Seq(('Умнова',16),('Иванов',23),
               ('Попова',17),('Козлов',24));
  Println('Совершеннолетние:');
  s.Where(\(name,age) -> age >= 18).Println;
  Println('Сортировка по фамилии:');
  s.OrderBy(\(name,age) -> name).Println;
end.
