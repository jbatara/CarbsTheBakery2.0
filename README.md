# _Carbs: The Bakery 2.0_

#### _A Basic Online Order Fulfillment system for a bakery, October 11th, 2019_

#### _By **Jennifer Batara**_

## Description

This application is a ASP.Net MVC web application rthat is able to track transactions for a bakery with certain discount schemes.

The user is able to add a new vendors, see a list of vendors, add orders, and see a list of all orders/or orders by vendor. Currently the transactions are stored locally, and are not saved between run istances of the local web application.

## Specifications: Pricing

|Spec | Input | Output|
|:---:|:------|:------|
|Bread is $5 each|Add 2 Bread Items| Total: $10|
|Bread is 3 for $10|Add 3 Bread Items|Total: $10|
|Pastries are $2 per pastry|Add 2 Pastry Items| Total: $4|
|Pastries are 3 for $5|Add 7 pastries| Total: $12|

## Specifications: User Interface
For all of these situations, the sample Transaction list is only 1 transaction long.

|Spec | Input | Output|
|:---:|:------|:------|
|If there are no vendros added, a message is displayed to the user when trying to view all vendors|"/vendor"| I'm sorry, it seems like you don't have any vendors. If you'd like to add one, please click on the button below|
|New Vendor Button directs the user to create a new Vendor| click "New Vendor" | Gets form asking for new vendor name|
|New Vendor forms are required to input a name| Attempts to submit a new vendor form that is empty will cause a popup.|"A name is required to submit the form"|


## Setup/Installation Requirements

-   Internet Connection
-   Internet browser
-   Bash Terminal
-   .NET Core 2.2

If you do not have the .NET Core installed on your computer, please install it by following the directions for your operating system [here](https://dotnet.microsoft.com/download). The .NET Core version used for this project is 2.2.

To view locally please copy the link to [this repo](https://github.com/jbatara/CarbsTheBakery2.0) and type the following command into your Bash terminal:
```
$git clone repo_url
```

with repo_url being the url that was just copied. To open the console app, navigate to the local directory which the online repository was cloned to using the command

```
$cd CarbsTheBakery/
```

Once in the correct repository, and confirming that you have .NET core installed (version 2.2), run the app with the command
```
$dotnet run
```
and enjoy!

This project is currently not hosted online.

## Known Bugs

_None. All previously reported bugs have been resolved._

## Support and contact details

Please feel free to contact the developer by raising a new [issue](https://github.com/jbatara/CarbsTheBakery2.0/issues/new) on the github repo. You can browse the current issues [here](https://github.com/jbatara/CarbsTheBakery2.0/issues).

## Technologies Used

* C#
* .NET Core 2.2

## Design Considerations

- All items Pastry and Bread items in the bakery have a class type built for them that are extended from the Baked Goods class (which is extended from Merchandise class). This class tree was developed to give flexibility in the future if the bakery decides to sell items other than baked goods (such as T-shirts, gift cards, etc.). This way, another class can be branched from the main Merchandise class to more easily check for item types when applying discounts, pricing, and printing to console methods.

```
Merchandise
  |_BakedGoods
    |_Bread
    |_Pastry
  |_(Additional Merchandise Cats)
    |_(Additional Sub Cats)
```

- Vendors and the Order class itself have Pending and Fulfilled order lists to make it easier for users to check orders that still need to go out.

### License

_MIT_

Copyright (c) 2019 **_Jennifer Batara_**
