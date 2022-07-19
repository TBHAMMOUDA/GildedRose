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

## Spécification de la Rose dorée (Gilded Rose)
[![N|Solid](https://github.githubassets.com/images/mona-loading-default.gif)](https://github.com/emilybache/GildedRose-Refactoring-Kata/blob/main/GildedRoseRequirements_fr.md)
>Bonjour et bienvenue dans l'équipe de la Rose dorée.

>Comme vous le savez, notre petite taverne située à proximité d'une cité importante est dirigée par l'amicale aubergiste Allison.

>Nous achetons et vendons uniquement les meilleurs produits.
Malheureusement, la qualité de nos marchandises se dégrade constamment à l'approche de leur date de péremption.

>Un système a été mis en place pour mettre à jour notre inventaire.
>Il a été développé par Leeroy, une personne pleine de bon sens qui est partie pour de nouvelles aventures.

>Votre mission est d'ajouter une nouvelle fonctionnalité à notre système pour que nous puissions commencer à vendre un nouveau type de produits.
Mais d'abord, laissez-moi vous présenter notre système :
>- Tous les éléments ont une valeur `sellIn` qui désigne le nombre de jours restant pour vendre l'article.
>- Tous les articles ont une valeur `quality` qui dénote combien l'article est précieux.
>- À la fin de chaque journée, notre système diminue ces deux valeurs pour chaque produit.

>Plutôt simple, non ?
Attendez, ça devient intéressant :

>- Une fois que la date de péremption est passée, la qualité se dégrade deux fois plus rapidement.
>- La qualité (`quality`) d'un produit ne peut jamais être négative.
>- "Aged Brie" augmente sa qualité (`quality`) plus le temps passe.
>- La qualité d'un produit n'est jamais de plus de 50.
>- "Sulfuras", étant un objet légendaire, n'a pas de date de péremption et ne perd jamais en qualité (`quality`)
>- "Backstage passes", comme le "Aged Brie", augmente sa qualité (`quality`) plus le temps passe (`sellIn`) ; La qualité augmente de 2 quand il reste 10 jours ou moins et de 3 quand il reste 5 jours ou moins, mais la qualité tombe à 0 après le concert.

>Nous avons récemment signé un partenariat avec un fournisseur de produit invoqué ("Conjured").
Cela nécessite une mise à jour de notre système :

>- les éléments "Conjured" voient leur qualité se dégrader de deux fois plus vite que les objets normaux.

>Vous pouvez faire les changements que vous voulez à la méthode `updateQuality` et ajouter autant de code que vous voulez, tant que tout fonctionne correctement.
Cependant, nous devons vous prévenir, vous ne devez en aucun cas modifier la classe `Item` ou ses propriétés car cette classe appartient au gobelin à l'étage qui entrerait dans une rage instantanée et vous tuerait sans délai : il ne croit pas au partage du code.
(Vous pouvez ajouter rendre la méthode `updateQuality` statique, ainsi que des propriétés dans la classe `Item` si vous voulez, nous vous couvrirons)
Juste une précision, un produit ne peut jamais voir sa qualité augmenter au-dessus de 50, cependant "Sulfuras" est un objet légendaire et comme tel sa qualité est de 80 et elle ne change jamais.



