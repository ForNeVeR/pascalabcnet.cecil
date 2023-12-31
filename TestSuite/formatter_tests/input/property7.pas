﻿type
  I1 = interface
    property X: integer read;
  end;
  
  T1 = record(I1)
    property X: integer read 1;
    property I1<T1, T2>.X: integer read 2;
  end;

begin
  var r: T1;
  assert(r.X = 1);
  var r1: I1 := r;
  writeln(r1.X);
  assert(r1.X = 2);
end.