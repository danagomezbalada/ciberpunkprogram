# Aplicació Ciberpunk
---------
# Instal·lació
Per instal·lar el programa, tan sols hem de descarregar l'[executable](https://gitlab.com/dam2-dana/aplicaciociberpunkdana/-/blob/master/CiberpunkDana.exe).
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

Ara podem accedir correctament a la base de dades del programa.

### Funcionament
Un cop executem l'aplicació, tenim vàries opcions a escollir de taules per modificar:
- **Persones**
- **Territoris**
- **Capacitats**
- **Gremis**

Fent clic a un dels botons obre una nova finestra on ens mostra la taula completa més els camps i les dades de la fila seleccionada. A partir d'aquí podem fer diferents accions:
- Seleccionar les dades que volem veure o modificar mitjançant els botons de direcció (**<** i **>**) o fent clic directament a una fila de la taula. 
    - Un cop hem seleccionat una fila es mostren les seves dades dins de caixes de text on podem modificar-les.
- Afegir una nova fila amb dades buides a la BBDD fent clic al botó *Afegir*. Aquesta fila obté una ID nova i un cop creada es mostra seleccionada a la taula.
- Modificar les dades de cada fila mitjançant les caixes de text (els canvis fets des de la taula directament no se sincronitzen amb la BBDD). Un cop hem escrit els nous valors, fem clic al botó *Actualitzar*. 
- Esborrar la fila seleccionada de la BBDD fent clic al botó *Esborrar*. La fila seleccionada s'elimina completament de la base de dades.

Un cop acabem de visualitzar o modificar la taula, fem clic al botó *x* en la part superior dreta per tancar aquesta finestra i tornar a la pantalla inicial. Si volem tancar el programa completament, fem clic al botó *x* des de la pantalla inicial. 
*La finestra de l'aplicació es pot moure fent clic a qualsevol part del fons i arrastrant el ratolí a la posició desitjada.*