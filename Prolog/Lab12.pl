nod(X,0,X):-!.
nod(X,Y,N):-X1 is X mod Y, nod(Y,X1,N).

prime(N):-I is N - 1, prime(N,I).
prime(N,1):-!.
prime(N,I):-N mod I =\= 0,I1 is I - 1, prime(N,I1),!.

%task 11
spdu(N,1,0):-!.
spdu(N,I,S):-I1 is I - 1, 0 is N mod I, prime(I), spdu(N,I1,S1), S is S1 + I,!.
spdu(N,I,S):-I1 is I - 1, spdu(N,I1,S).

spdd(N,S):-spdd(N,N,S,0).
spdd(N,1,S,S):-!.
spdd(N,I,S,C):-I1 is I - 1, 0 is N mod I, prime(I), C1 is C + I, spdd(N,I1,S,C1),!.
spdd(N,I,S,C):-I1 is I - 1, spdd(N,I1,S,C),!.

%task 12
digit_sum(N,S):-digit_sum(N,S,0).
digit_sum(0,S,S):-!.
digit_sum(N,S,C):-D is N mod 10, N1 is N div 10, C1 is C + D, digit_sum(N1,S,C1),!.

mpdu(N,1,1):-!.
mpdu(N,I,S):-I1 is I - 1, 0 is N mod I, digit_sum(N,SS1), digit_sum(I,SS2), SS2 < SS1, mpdu(N,I1,S1), S is S1 * I,!.
mpdu(N,I,S):-I1 is I - 1, mpdu(N,I1,S).

mpdd(N,S):-mpdd(N,N,S,1).
mpdd(N,1,S,S):-!.
mpdd(N,I,S,C):-I1 is I - 1, 0 is N mod I, digit_sum(N,SS1), digit_sum(I,SS2), SS2 < SS1, C1 is C * I, mpdd(N,I1,S,C1),!.
mpdd(N,I,S,C):-I1 is I - 1, mpdd(N,I1,S,C),!.