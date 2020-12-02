# Aplicació Ciberpunk
---------
# Instal·lació
Per instal·lar el programa, tan sols hem de descarregar l'[executable](-/blob/master/CiberpunkDana.exe).
# Utilització
### Connexió amb base de dades
Aquest programa fa servir una connexió a la base de dades '*persones*'. Per tal de fer aquesta connexió:

- Descarreguem la base de dades [persones](https://gitlab.com/dam2-dana/aplicaciociberpunkdana/-/blob/master/persones.sql).
- Executem XAMPP (o el seu equivalent) i activem els serveis d'Apache i MySQL.
- Anem a l'enllaç [/localhost/phpmyadmin/](http://localhost/phpmyadmin/) per accedir a les nostres bases de dades.
- IMPORTANT: Si ja existeix una base de dades anomenada 'persones' haurem de canviar-li el nom (per tal de que funcioni correctament el programa descarregat).
    - Fem clic a la BBDD 'persones'.
    - A la barra superior, fem clic a *Operations*.
    - En la secció '*Rename database to*' posem el nou nom de la BBDD, i fem clic a *Go*.
    - Per retornar al nom anterior seguim els mateixos passos.
- Creem una nova BBDD anomenada 'persones', i a la barra superior fem clic a '*Import*'.
- Fem clic a *Choose File* i escollim el fitxer descarregat. Un cop escollit, fem clic a *Go* i esperem a que acabi.