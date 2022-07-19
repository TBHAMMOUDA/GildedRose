# GildedRose
## Steps for build & test & run
```sh
git clone https://github.com/TBHAMMOUDA/GildedRose.git
git checkout refactoring_version_01

# Step 1:dotnet test

# Step 1: dotnet run --project ./GildedRose/GildedRose.csproj

# Step 1 : dotnet build
# Step 2 : dotnet ./GildedRose/bin/Debug/net6.0/GildedRose.dll

# Step 1 : dotnet build --configuration Release
```

## Approach description
Time line commits:
- [Commit 1](https://github.com/TBHAMMOUDA/GildedRose/commit/742f18983f4e4298dbbac7737364bccb6e1d1168) : It's just a clone from  folder [GildedRose-Refactoring-Kata/csharpcore-Verify.xunit](https://github.com/emilybache/GildedRose-Refactoring-Kata/tree/main/csharpcore-Verify.xunit)

- [Commit 2](https://github.com/TBHAMMOUDA/GildedRose/commit/6280e17fb189a730deee2f977d4837d76667ec0c) , [Commit 3](https://github.com/TBHAMMOUDA/GildedRose/commit/6bbaf0414e068f56add23aed58fae75889ff7447) : Make some test methodes to check the output

- [Commit 4](https://github.com/TBHAMMOUDA/GildedRose/commit/142480d2f51f46250dc922982736d8bd51e4d154) : Describe rules to check of Items as a Class
- [Commit 5](https://github.com/TBHAMMOUDA/GildedRose/commit/7b060fc0e21930d7aa0156648b8f0af45465709e) : Decouple database access using design patterns "Singleton" and extract Categories in an Enum (`NormalItem, AgedBrie, BackstagePasses, LegendaryItem, ConjuredItem`)

- [Commit 6](https://github.com/TBHAMMOUDA/GildedRose/commit/0ee72cb20868980dcf46d9bd1ae5adf576e1a8e8) Add the business logic for each Category
- [Commit 7](https://github.com/TBHAMMOUDA/GildedRose/commit/af0056286d6e538b4b5f40608d6bc85b84932296) : Rmove the business logic from GildedRose class

- [Commit 8](https://github.com/TBHAMMOUDA/GildedRose/commit/be9ef82b131e3297b44fab67aa61014a65edd702) : Make the Console output mere readable
- [Commit 9](https://github.com/TBHAMMOUDA/GildedRose/commit/d9be55e326efb623bb88bdecfde4104a1a0575a9) : Adapt the testing methods for new logic

## Sp�cification de la Rose dor�e (Gilded Rose)
[![N|Solid](https://github.githubassets.com/images/mona-loading-default.gif)](https://github.com/emilybache/GildedRose-Refactoring-Kata/blob/main/GildedRoseRequirements_fr.md)
>Bonjour et bienvenue dans l'�quipe de la Rose dor�e.

>Comme vous le savez, notre petite taverne situ�e � proximit� d'une cit� importante est dirig�e par l'amicale aubergiste Allison.

>Nous achetons et vendons uniquement les meilleurs produits.
Malheureusement, la qualit� de nos marchandises se d�grade constamment � l'approche de leur date de p�remption.

>Un syst�me a �t� mis en place pour mettre � jour notre inventaire.
>Il a �t� d�velopp� par Leeroy, une personne pleine de bon sens qui est partie pour de nouvelles aventures.

>Votre mission est d'ajouter une nouvelle fonctionnalit� � notre syst�me pour que nous puissions commencer � vendre un nouveau type de produits.
Mais d'abord, laissez-moi vous pr�senter notre syst�me :
>- Tous les �l�ments ont une valeur `sellIn` qui d�signe le nombre de jours restant pour vendre l'article.
>- Tous les articles ont une valeur `quality` qui d�note combien l'article est pr�cieux.
>- � la fin de chaque journ�e, notre syst�me diminue ces deux valeurs pour chaque produit.

>Plut�t simple, non ?
Attendez, �a devient int�ressant :

>- Une fois que la date de p�remption est pass�e, la qualit� se d�grade deux fois plus rapidement.
>- La qualit� (`quality`) d'un produit ne peut jamais �tre n�gative.
>- "Aged Brie" augmente sa qualit� (`quality`) plus le temps passe.
>- La qualit� d'un produit n'est jamais de plus de 50.
>- "Sulfuras", �tant un objet l�gendaire, n'a pas de date de p�remption et ne perd jamais en qualit� (`quality`)
>- "Backstage passes", comme le "Aged Brie", augmente sa qualit� (`quality`) plus le temps passe (`sellIn`) ; La qualit� augmente de 2 quand il reste 10 jours ou moins et de 3 quand il reste 5 jours ou moins, mais la qualit� tombe � 0 apr�s le concert.

>Nous avons r�cemment sign� un partenariat avec un fournisseur de produit invoqu� ("Conjured").
Cela n�cessite une mise � jour de notre syst�me :

>- les �l�ments "Conjured" voient leur qualit� se d�grader de deux fois plus vite que les objets normaux.

>Vous pouvez faire les changements que vous voulez � la m�thode `updateQuality` et ajouter autant de code que vous voulez, tant que tout fonctionne correctement.
Cependant, nous devons vous pr�venir, vous ne devez en aucun cas modifier la classe `Item` ou ses propri�t�s car cette classe appartient au gobelin � l'�tage qui entrerait dans une rage instantan�e et vous tuerait sans d�lai : il ne croit pas au partage du code.
(Vous pouvez ajouter rendre la m�thode `updateQuality` statique, ainsi que des propri�t�s dans la classe `Item` si vous voulez, nous vous couvrirons)
Juste une pr�cision, un produit ne peut jamais voir sa qualit� augmenter au-dessus de 50, cependant "Sulfuras" est un objet l�gendaire et comme tel sa qualit� est de 80 et elle ne change jamais.



