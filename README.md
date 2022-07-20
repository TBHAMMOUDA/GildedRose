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

- [Commit 4](https://github.com/TBHAMMOUDA/GildedRose/commit/142480d2f51f46250dc922982736d8bd51e4d154) : Describe rules to check as a Class
- [Commit 5](https://github.com/TBHAMMOUDA/GildedRose/commit/7b060fc0e21930d7aa0156648b8f0af45465709e) : Decouple database access using design patterns "Singleton" and extract Categories in an Enum (`NormalItem, AgedBrie, BackstagePasses, LegendaryItem, ConjuredItem`)

- [Commit 6](https://github.com/TBHAMMOUDA/GildedRose/commit/0ee72cb20868980dcf46d9bd1ae5adf576e1a8e8) : Add the business logic for each Category
- [Commit 7](https://github.com/TBHAMMOUDA/GildedRose/commit/af0056286d6e538b4b5f40608d6bc85b84932296) : Rmove the business logic from GildedRose class

- [Commit 8](https://github.com/TBHAMMOUDA/GildedRose/commit/be9ef82b131e3297b44fab67aa61014a65edd702) : Make the Console output more readable
- [Commit 9](https://github.com/TBHAMMOUDA/GildedRose/commit/d9be55e326efb623bb88bdecfde4104a1a0575a9) : Adapt the testing methods for new logic

## Spécification de la Rose dorée (Gilded Rose)
[![N|Solid](https://github.githubassets.com/images/mona-loading-default.gif)](https://github.com/emilybache/GildedRose-Refactoring-Kata/blob/main/GildedRoseRequirements_fr.md)



