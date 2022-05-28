nod(X,0,X):-!.
nod(X,Y,N):-X1 is X mod Y, nod(Y,X1,N).

prime(N):-I is N - 1, prime(N,I).
prime(N,1):-!.
prime(N,I):-N mod I =\= 0,I1 is I - 1, prime(N,I1),!.

%task 11
spdu(N,1,0):-!.
spdu(N,I,S):-I1 is I - 1, 0 is N mod I, prime(I), spdu(N,I1,S1), S is S1 + I,!.
spdu(N,I,S):-I1 is I - 1, spdu(N,I1,S).
