# WSEI-GDD-PK\

1. Nazwa gry: 10 Bouncing Balls.

2. Wysokopoziomowy opis projektu: 

        - Gra będzie o odbijaniu piłeczek platformą, która porusza się po okręgu. Musimy utrzymywać piłeczki w środku tego okręgu bo innaczej kulki zostaną zniszczone. Dodatkowo można obracać platformy wokół własnej osi.
        
        - Jest to gra zręcznościowa z gatunku arcade.
        
        - Zadaniem gracza jest utrzymanie w środku okręgu 10 piłeczek. Każda kulka pojawia się w środku i zaczyna podążać w losowym kierunku. Gracz używając platformy powinien odbijać piłki w ten sposób by utrzymywać je w środku. Jeśli piłki się ze sobą zderzą, lub wyjdą poza okręg po którym porusza się nasza platforma, to kulki ulegają dezintegracji. W przypadku gdy piłka wyjdzie poza okręg gracz traci 1 życie, których ma w sumie 5. W środku okręgu czasami pojawiają się kwadraty, które po najechaniu przez piłkę na nie znikają, a gracz zdobywa kolejną platforme do odbijania kulek.

3. Pomysł wywodzi się ze starej gry - pong.

4. PC.

5. Core:
        
        - Platforma, która się porusza po okręgu z normalną prędkością za pomocą strzałek na klawiaturze(lewo i prawo), lub szybszą po naciśnięciu spacji.
        
        - Kulki, które generowane są co 3 sekundy, chyba że w środku znajduje się inna kulka(Wtedy generowana kulka musi zaczekać 1 sekundę na swoją kolej). Każda nowo stworzona kulka porusza się w losowym kierunku.
        
        - Kwadraty generowane są w 10 sekundowym odstępie czasu. Żaden kwadrat nie może pojawić się w środku okręgu lub poza nim. Jeśli pojawi się nowy kwadrat to stary znika.
        
        - Gracz ma 5 żyć i za każdym razem jak piłka wychodzi poza okrąg, traci jedno życie. Jeśli ich liczba będzie wynosić zero to przegrywa.
        
        - Jeśli uda się utrzymać w okręgu 10 piłeczek jednocześnie, to gra zakończy się zwyciestwem.
        
        - Platforma automatycznie obraca się w stronę środka okręgu.

6. Features:

        - obrót platformy wokół własnej osi zainicjowany przez gracza za pomocą strzałek(góra, dół).

7. Estymaty: Tworzenie gry powinno zająć około 2 tygodnie.

8. Podział zadań: Projekt realizuje samodzielnie.


        
