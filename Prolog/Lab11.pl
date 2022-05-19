man(uriel_septim_vii).
man(martin_septim).
man(ebel_septim).
man(enman_septim).
man(geldall_septim).
man(calaxes_septim).
man(pelagius_septim_vi).
man(ulfe_gersen).
man(uriel_septim_vi).
man(uriel_septim_v).
man(cephorus_septim_ii).
man(unknown_eloisas_husband).

woman(caula_voria).
woman(eloisa_septim).
woman(morihatha_septim).
woman(thonica).
woman(unknown_cephoruses_wife).
woman(unknown_uriels_v_wife).
woman(unknown_pelagiuses_iv_wife).
woman(unknown_1_uriels_vii_wife).
woman(unknown_2_uriels_vii_wife).

parent(cephorus_septim_ii,uriel_septim_v).
parent(unknown_cephoruses_wife,uriel_septim_v).
parent(uriel_septim_v,morihatha_septim).
parent(uriel_septim_v,eloisa_septim).
parent(unknown_uriels_v_wife,morihatha_septim).
parent(unknown_uriels_v_wife,eloisa_septim).
parent(uriel_septim_v,uriel_septim_vi).
parent(thonica,uriel_septim_vi).
parent(eloisa_septim,pelagius_septim_vi).
parent(unknown_eloisas_husband,pelagius_septim_vi).
parent(pelagius_septim_vi,uriel_septim_vii).
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

men:-man(X),write(X),nl,fail.
women:-woman(X),write(X),nl,fail.

children(X):-parent(X,Y),write(Y),nl,fail.

mother(X,Y):-parent(X,Y),woman(X).
mother(X):-parent(Y,X),woman(Y),write(Y),nl.