# Test-covid-19-super-masivo
Es la mejora del ya publicado proyecto de multiplicación de test

## Introducción:
A la pregunta de si se podría testear a toda una población, pensando un país con millones de habitantes, la respuesta sale sin pensar con un contundente no, y ese no, se basaría en varios factores, uno el tiempo que lleva testear, por más que existan test rápidos, otro factor es el costo del testeo.
Sin embargo con el presente proyecto, se podría llegar a una cifra elevadísima de testeos en muy poco tiempo y a un costo muy bajo. Muy cerca de testear una población entera hasta en un solo día.
Es la mejora del proyecto publicado hace unos días, en el cual se podría multiplicar un test por 100:
https://github.com/diegolarrosa/test-multiplier-for-covid-19
En el anterior proyecto aconsejaba dos etapas de multiplicación, basado en que mezclar una gran cantidad de test podría reducir la eficacia del testeo, sin embargo al utilizar redundancia se reduce el riesgo de errores.
Es decir con tres etapas y aplicando redundancia a las dos primeras etapas no solo se mejora la eficiencia de ahorro de test, sino que también aumenta la eficacia en la detección de casos positivos.



## Descripción del método de testeo


El método consiste en tres etapas de multiplicación con redundancia en las dos primeras etapas.
Por ejemplo teniendo tres etapas de 10 elementos cada una, se necesita una mezcla de 1000 hisopos  en la primera etapa,  ese procedimiento se realiza dos veces, y necesita al menos dos test. Si al menos uno da positivo, se divide la muestra de 1000 hisopos en 10 muestras de 100 hisopos cada una, a cada una de esas 10 muestras se realiza un testeo y mezcla doble.  Por cada una de los pares de muestras de 100, si se llegara a encontrar un resultado positivo, se lo vuelve a dividir en 10 muestras de 10, pero sin redundancia, y se realiza un testeo por cada muestra mezclada. Por último si en alguna mezcla de 10 da un resultado positivo, se tiene que realizar un testeo individual.
Con éste procedimiento es posible detectar en forma individual todos los casos positivos, con una buena eficacia, ya que las etapas de mezcla con elevada cantidad de elementos se realiza con redundancia, y ahorrando una cantidad muy significativa de testeos.
No solo se puede multiplicar 10 x 10 x 10, sino también es posible por ejemplo 15 x 15 x 15, o también 5 x 5 x 5. La diferencia está en la cantidad de infectados (contando los asintomáticos) que posee la población a testear.



## Descripción del procedimiento de testeo súper masivo


Desde la toma de muestras hasta el testeo en el laboratorio se requieren una serie de pasos. Lo primero es saber la estrategia de multiplicación de etapas, para ello se requiere calcular cuántos casos pueden llegar a existir en la población con respecto a un millón de habitantes, ese número podría rondar entre los 50 hasta los 300 en la república argentina, que hasta la fecha (18/04/2020) reporta 2700 casos. Para determinar las etapas de multiplicación, se puede utilizar el software de simulación, el cual está publicado en el actual repositorio y se describirá el funcionamiento más adelante.
En la toma de muestras, que sería el procedimiento de mayor despliegue en todo el territorio, se necesita un gran número de personas encargadas de realizarlo,  a cada persona se le toman seis muestras (hisopos independientes), con su identificación correspondiente, para luego poder hacer más testeos o simplemente comunicarle el resultado, y poder tomar las medidas correspondientes en caso de dar positivo. Si a cada persona se necesitan seis hisopos, podemos imaginar la cantidad de hisopos requeridos para testear a millones de habitantes, sin embargo el costo sigue siendo mucho menor del costo actual de un testeo, ya que en buenas condiciones se utilizaría un solo test para encontrar 500 personas con una muy buena eficacia, como se describirá en la simulación.
Una vez recolectadas todas las muestras, se las traslada a un laboratorio de mezclado, el cual realiza justamente el mezclado de un grupo de muestras, explicado en “Descripción del método de testeo”, el laboratorio de mezclado no necesariamente tiene que ser capaz de realizar testeos,  si tiene que contar con un procedimiento adecuado de seguridad, si se realiza correctamente aumenta la eficacia del resultado final, también cada laboratorio puede dividir la tarea en varios operarios, para que el tiempo de mezclado sea el correcto, y no se generen cuellos de botella.
De cada laboratorio de mezclado se trasladan todos los test requeridos, hacia el laboratorio de detección estándar. El resultado de los test vuelven al laboratorio de mezclado, y se toman las diferentes decisiones, dependiendo de los resultados obtenidos, los tiempos tienen que estar coordinados para que no se pierdan las muestras almacenadas.
Por ejemplo se mezclan una determinada cantidad de muestras, cuando se llega a un número de muestras mezcladas determinadas, se las traslada al laboratorio de análisis.



## Simulación por computadora del procedimiento de testeo


Consiste en un programa de código abierto, el cual se encuentra publicado en el actual respositorio, el programa determina por medio de una simulación cual es el resultado de aplicar el procedimiento, devolviendo el promedio de test estándar que fueron necesario para cubrir la estrategia de multiplicación elegida, también devuelve la eficiencia, 99% significa que se necesita 1 test para determinar los infectados en una población de 100 habitantes, también devuelve la eficacia, es decir un porcentaje que describe cuan confiable es la prueba general.
El resultado varía mucho dependiendo de cuantos infectados puedan existir por millón de habitantes. Por tal motivo es muy importante aplicarlo lo más rápido posible.



## A quien se debe testear


Los testeos actualmente están dirigidos principalmente a quienes presentan síntomas, algo que dejaría afuera a los asintomáticos, los cuales pueden llegar a ser una de las principales fuentes de contagio, como el método de testeo super masivo puede lograr en muy poco tiempo testear a millones de personas, la estrategia elegida puede cambiar, hasta el punto de poder realizar testeos a absolutamente todos los que circulan por un territorio determinado, con puntos de testeos móviles cuidadosamente elegidos.



## Estrategias de agrupamiento de muestras

El método es eficiente cuanto menor sea la probabilidad de encontrar infectados por millón de habitantes, por lo tanto si se clasifica a los testeados, se puede mejorar mucho la eficiencia. Para poder clasificarlos, se podrían utilizar códigos de colores.
Código verde: para las personas que no presenten síntomas, y utilizar la multiplicación 15 x 15 x 15, por ejemplo.
Código amarillo: para los que presenten algunos síntomas, utilizando la multiplicación de testeos 5 x 5 x 5.
Código rojo: para los que presenten muchos síntomas, directamente se podría realizar el testeo individual.



## Velocidad de testeo


Si un testeo estándar  requiere un determinado tiempo para realizarse, un testeo de 500 a 1 puede realizarse en 500 veces el tiempo requerido para un solo testeo, teniendo como base que tanto la recolección de muestra como el mezclado se encuentren convenientemente distribuidos. Es decir, podría ser 500 veces más rápido.



## El enemigo invisible


El presidente de argentina Alberto Fernández, describió al coronavirus como el enemigo invisible, principalmente porque no podemos saber quién se encuentra contagiado y no presenta síntomas, pero si puede llegar a contagiar a otras personas. Al aplicar el método de test super masivo podríamos empezar a ver al enemigo, y con ello detener definitivamente la pandemia.



## Algunos resultados de la simulación


1-
Cantidad de infectados por millón de habitantes: 50
Estrategia de multiplicación: 10 x 10 x 10

Resultado:
Número de test promedio necesarios: 3,39
Número de personas testeadas: 1000
Ahorro de test: 996
Eficiencia:  99,66%
Promedio de casos positivos no encontrados:  0,006100
Efectividad del testeo general:  88,47%

2-
Cantidad de infectados por millón de habitantes: 100
Estrategia de multiplicación: 10 x 10 x 10

Resultado:
Número de test promedio necesarios: 4,65
Número de personas testeadas: 1000
Ahorro de test: 995
Eficiencia:  99,54%
Promedio de casos positivos no encontrados:  0,012900
Efectividad del testeo general:  87,43%

3- 
Cantidad de infectados por millón de habitantes: 200
Estrategia de multiplicación: 10 x 10 x 10

Resultado:
Número de test promedio necesarios: 6,99
Número de personas testeadas: 1000
Ahorro de test: 993
Eficiencia:  99,30%
Promedio de casos positivos no encontrados:  0,022100
Efectividad del testeo general:  88,79%

4- 
Cantidad de infectados por millón de habitantes: 50
Estrategia de multiplicación: 15 x 15 x 15

Resultado:
Número de test promedio necesarios: 8,41
Número de personas testeadas: 3375
Ahorro de test: 3366
Eficiencia:  99,75%
Promedio de casos positivos no encontrados:  0,018900
Efectividad del testeo general:  88,41%



## Mejoras


En poco tiempo pude realizar el actual proyecto, que incluye el software, y las pruebas de simulación, como pueden ver cuanto mayor sea el número de infectados menos eficiente será el procedimiento. Por lo tanto quedan muchas cuestiones abiertas, como el procedimiento de mezclado de muestras, la revisión del software de simulación, etc.

Se realizaron algunas correcciones en el código de software, a la fecha 30/04/2020, y cambiaron un poco los resultados de la simulación, obteniendo mayor eficiencia, pero menor eficacia, aunque la eficacia es un tema abierto.

