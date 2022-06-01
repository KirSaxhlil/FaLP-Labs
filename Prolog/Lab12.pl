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

%task 14
list_length(List,S):-list_length(List,S,0).
list_length([],S,S):-!.
list_length([H|T],S,C):-C1 is C + 1, list_length(T,S,C1),!.

%additional
append([],X,X).
append([H|T],X,[H|T1]):-append(T,X,T1).

read_list(0, []):-!.
read_list(N, [X|T]):- read(X), N1 is N-1, read_list(N1, T).

write_list([]):-!.
write_list([H|T]):-write(H),write(' '),write_list(T).

%task 15
find_Lmax([H|T],M,I):-find_Lmax(T,M,H,I,0,1).
find_Lmax([],M,M,I,I,U):-!.
find_Lmax([H|T],M,C,I,CI,U):-H >= C, U1 is U + 1, find_Lmax(T,M,H,I,U,U1),!.
find_Lmax([H|T],M,C,I,CI,U):-U1 is U + 1, find_Lmax(T,M,C,I,CI,U1).

qalm(List,Q):-find_Lmax(List,M,I),qalm(List,I,0,Q,0).
qalm([],M,I,Q,Q):-!.
qalm([H|T],M,I,Q,C):-I > M, C1 is C + 1, I1 is I + 1, qalm(T,M,I1,Q,C1),!.
qalm([H|T],M,I,Q,C):-I1 is I + 1, qalm(T,M,I1,Q,C).

task15(N):-read_list(N,List),qalm(List,Q),write(Q).

%task 16
find_Fmin([H|T],M,I):-find_Fmin(T,M,H,I,0,1).
find_Fmin([],M,M,I,I,U):-!.
find_Fmin([H|T],M,C,I,CI,U):-H < C, U1 is U + 1, find_Fmin(T,M,H,I,U,U1),!.
find_Fmin([H|T],M,C,I,CI,U):-U1 is U + 1, find_Fmin(T,M,C,I,CI,U1).

task16(N):-read_list(N,List),find_Fmin(List,M,I),write(I).

%task 17
rebuild(List,NewList):-find_Fmin(List,M,I),rebuild(List,I,0,P1,P2,[],[]),append(P2,P1,NewList).
rebuild([],I,C,P1,P2,P1,P2):-!.
rebuild([H|T],I,C,P1,P2,PP1,PP2):-C >= I, NewC is C + 1, append(PP2,[H],NewPP2),rebuild(T,I,NewC,P1,P2,PP1,NewPP2),!.
rebuild([H|T],I,C,P1,P2,PP1,PP2):-NewC is C + 1, append(PP1,[H],NewPP1),rebuild(T,I,NewC,P1,P2,NewPP1,PP2).

task17(N):-read_list(N,List),rebuild(List,NewList),write_list(NewList).

%task 18
isLocalMin([F,S|_],0):-F<S,!.
isLocalMin([F,S|T],Ind):-localMin(F,S,T,Ind,1).
localMin(F,S,[],Ind,Ind):-S<F,!.
localMin(F,S,[Next|_],Ind,Ind):-S<F,S<Next,!.
localMin(_,S,[Next|Tail],Ind,IndNow):-NextInd is IndNow+1,localMin(S,Next,Tail,Ind,NextInd).

task18(N):-read_list(N,List),read(I),isLocalMin(List,I).

%task 19
get(List,A,B,NewList):-get(List,A,B,NewList,0,[]).
get([],A,B,C,I,C):-!.
get([H|T],A,B,NewList,I,C):-I >= A, I =< B, append(C,[H],C1), I1 is I + 1, get(T,A,B,NewList,I1,C1),!.
get([H|T],A,B,NewList,I,C):-I1 is I + 1, get(T,A,B,NewList,I1,C),!.

task19(N):-read_list(N,List), read(A),read(B),get(List,A,B,New),find_Lmax(New,M,I),write(M).

%task 20
find_Fmax([H|T],M,I):-find_Fmax(T,M,H,I,0,1).
find_Fmax([],M,M,I,I,U):-!.
find_Fmax([H|T],M,C,I,CI,U):-H > C, U1 is U + 1, find_Fmax(T,M,H,I,U,U1),!.
find_Fmax([H|T],M,C,I,CI,U):-U1 is U + 1, find_Fmax(T,M,C,I,CI,U1).

task20(N):-read_list(N,List),find_Fmax(List,M1,A),find_Lmax(List,M2,B),get(List,A,B,New),write_list(New).