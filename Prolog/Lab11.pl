man(uriel_septim_vii).
man(martin_septim).
man(ebel_septim).
man(enman_septim).
man(geldall_septim).
man(calaxes_septim).
man(pelagius_septim_iv).
man(ulfe_gersen).
man(uriel_septim_vi).
man(uriel_septim_v).
man(cephorus_septim_ii).
man(unknown_eloisas_husband).
%additional bruh
man(remus_voria).

woman(caula_voria).
woman(eloisa_septim).
woman(morihatha_septim).
woman(thonica).
woman(unknown_cephoruses_wife).
woman(unknown_uriels_v_wife).
woman(unknown_pelagiuses_iv_wife).
woman(unknown_1_uriels_vii_wife).
woman(unknown_2_uriels_vii_wife).
%additional bruh
woman(orenicia_voria).

parent(cephorus_septim_ii,uriel_septim_v).
parent(unknown_cephoruses_wife,uriel_septim_v).
parent(uriel_septim_v,morihatha_septim).
parent(uriel_septim_v,eloisa_septim).
parent(unknown_uriels_v_wife,morihatha_septim).
parent(unknown_uriels_v_wife,eloisa_septim).
parent(uriel_septim_v,uriel_septim_vi).
parent(thonica,uriel_septim_vi).
parent(eloisa_septim,pelagius_septim_iv).
parent(unknown_eloisas_husband,pelagius_septim_iv).
parent(pelagius_septim_iv,uriel_septim_vii).
parent(unknown_pelagiuses_iv_wife,uriel_septim_vii).
parent(uriel_septim_vii,calaxes_septim).
parent(uriel_septim_vii,geldall_septim).
parent(uriel_septim_vii,enman_septim).
parent(uriel_septim_vii,ebel_septim).
parent(uriel_septim_vii,martin_septim).
parent(unknown_1_uriels_vii_wife,calaxes_septim).
parent(caula_voria,geldall_septim).
parent(caula_voria,enman_septim).
parent(caula_voria,ebel_septim).
parent(unknown_2_uriels_vii_wife,martin_septim).
%additional bruh
parent(remus_voria,caula_voria).
parent(orenicia_voria,caula_voria).

men:-man(X),write(X),nl,fail.
women:-woman(X),write(X),nl,fail.

children(X):-parent(X,Y),write(Y),nl,fail.

mother(X,Y):-parent(X,Y),woman(X).
mother(X):-parent(Y,X),woman(Y),write(Y),nl.

father(X,Y):-parent(X,Y), man(X).
father(X):-parent(Y,X),man(Y),write(Y),nl.

brothers_l(X):-father(F,X),mother(M,X),father(F,Y),mother(M,Y),man(Y),not(X==Y),write(Y),nl,fail.
brothers_f(X):-father(F,X),mother(M,X),father(F,Y),mother(N,Y),man(Y),not(X==Y),not(M==N),write(Y),nl,fail.
brothers_m(X):-father(F,X),mother(M,X),father(N,Y),mother(M,Y),man(Y),not(X==Y),not(F==N),write(Y),nl,fail.
brother(X,Y):-parent(Z,X),parent(Z,Y),man(X).
brothers(X):-brothers_l(X);brothers_f(X);brothers_m(X).

b_s(X,Y):-mother(Z,X),mother(Z,Y),father(N,X),father(N,Y).
b_s_l(X):-father(F,X),mother(M,X),father(F,Y),mother(M,Y),not(X==Y),write(Y),nl,fail.
b_s_f(X):-father(F,X),mother(M,X),father(F,Y),mother(N,Y),not(X==Y),not(M==N),write(Y),nl,fail.
b_s_m(X):-father(F,X),mother(M,X),father(N,Y),mother(M,Y),not(X==Y),not(F==N),write(Y),nl,fail.
b_s(X):-b_s_f(X);b_s_l(X);b_s_m(X).

grand_pa(X,Y):-parent(X,Z),parent(Z,Y).
grand_pas(X):-parent(Y,X),parent(Z,Y),write(Z),nl,fail.
grand_pa_and_son(X,Y):-parent(A,B),parent(B,C),((A==X,C==Y);(A==Y,C==X)).