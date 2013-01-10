Przykłady do prezentacji "Garbage Collector w środowisku .NET - czy powinienem coś o nim wiedzieć?"
===========

Autorem prezentacji i kodu jest <b>Przemysław Nowicki</b> - starszy programista w firmie <b>JITSolutions Sp. z o.o.</b>.

Zestaw prezentowanych projektów może otworzyć można poprzez plik "Garbage Collector.sln" w Visual Studio 2010.
Podczas prezentacji były one kompilowane i uruchamiane w trybie 32 bitowym na frameworku w wersji 4.0.

GCPresentation1
-----------
Projekt zawiera przykład polegający na alokowaniu tablic o pewnych zbliżonych do siebie rozmiarach. Różnice pomiędzy dwoma rozpatrywanymi przypadkami w kodzie są niewielkie, a czy różnice w czasie działania również?

GCPresentation2
-----------
Projekt zawiera przykład polegający na alokowaniu "dużych" obiektów. W jednym z przypadków alokowana jest seria takich samych obiektów, do których referencje utrzymywane są w liście. W drugim alokowane są tymczasowo bardzo duże obiekty o rosnącym rozmiarze, do których referencje nie są nigdzie utrzymywane. Czy ma ta dodatkowa tymczasowa alokacja wpływ na to, ile pamięci uda się wykorzystać na potrzeby działania programu? 

GCPresentation2on3.5
-----------
Projekt jest kopią GCPresentation2 z konfiguracji na framework .NET 3.5, na której można zaobserwować pewne różnice w szybkości działania wcześniejszych mechanizmów GC.

FastDataProcessor
-----------
Projekt zawiera przykład prezentujący wpływ przetrzymywania referencji do obiektów na utrzymanie wyznaczonego pierwotnie na 10ms SLA. Wpływ można obserwować zmieniając wielkość listy LRU (wartości 1,10,100).

SolGCPresentation1A + SolGCPresentation1B + SolGCPresentation2A + SolGCPresentation2B
-----------
Projekty zawieraja wcześniejsze przykłady w podziale na wersje i uruchamiane w pętli. Dzięki temu można obserwować działanie programu poprzez użycie narzędzi do monitorowania takich jak "Monitor wydajności" dostępny w systemie Windows. Należy oczywiście uzupełnić go o zestaw odpowiednich wskaźników z grupy "Pamięć .NET CLR".
