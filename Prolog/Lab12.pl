%task 11
spdu(N,0,0):-!.
spdu(N,I,S):-I1 is I - 1, 0 is N mod I, nod(N,I,X), 1 is X, spdu(N,I1,S1), S is S1 + I.
spdu(N,I,S):-I1 is I - 1, spdu(N,I1,S).
