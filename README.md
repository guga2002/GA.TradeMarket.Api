Domain  აღწერა:
სუპერმარკეტებში იყიდება სხვადასხვა კატეგორიის საქონელი. მომხმარებელს შეუძლია იყიდოს პროდუქტი დაამატოს კალათაში. ყიდვისას იქმნება ქვითარი კონკრეტულ ბაზარზე შეძენილი საქონლის ჩამონათვალით.
აგრეთვე მომხარებელს შეუძლია ნახოს სტატისტიკა , ნახოს  ისტორია . აგრეთვე  დაუწეროს პროდუქციას განხილვა, შესაბამისი პრეტენზიის დროს კი მოითხოვოს თანხის უკან დაბრუნება.
რელაციიური სტრუქტურა:
![image](https://github.com/guga2002/GA.TradeMarket.Api/assets/74540934/d1b017fb-3ede-4a4d-89b5-a33c772fe05a)
ენდპოინტები:(სერვისები:)
GET/api/products – all products
GET/api/products/{id} – a selected products
GET/api/products?categoryId=1&minPrice=20&maxPrice=50 – search for products by filter, ffor example, goods of category with Id = 1 and price less then maxPrice=50 and more then minPrice = 20
POST/api/products – add a product
PUT/api/products/{id} – change a product
DELETE/api/products/{id} – delete a product
GET/api/products/categories - get all categories
POST/api/products/categories - add a category 
PUT/api/products/categories{id} - update a category
DELETE/api/products/categories/{id} - delete a category

GET/api/customers – all customers
GET/api/customers/products/{id} - all customers who bought specified product
GET/api/customers/{id} – a selected customer
POST/api/customers – add a customer
PUT/api/customers/{id} – change a customer
DELETE/api/customers/{id} – delete a customer

GET/api/receipts – all receipts
GET/api/receipts/{id} – a selected receipt
GET/api/receipts/{id}/details - all details 
GET/api/receipts/{id}/sum – a selected receipt sum
GET/api/receipts/period?startDate=2021-12-1&endDate=2020-12-31 – all receipts by period, for example, from 2021-12-1 to 2020-12-31
POST/api/receipts – add a receipt
PUT/api/receipts/{id} – change a receipt
PUT/api/receipts/{id}/products/add/{productId}/{quantity} – add a product to a receipt
PUT/api/receipts/{id}/products/remove/{productId}/{quantity} – remove a product from a receipt
PUT/api/receipts/{id}/checkout – change a receipt check out value to true
DELETE/api/receipts/{id} – delete a receipt

GET/api/statistic/popularProducts?productCount=2 - Gets most popular products
GET/api/statisic/customer/{id}/{productCount} - Gets the concrete number of most favourite products of customer
GET/api/statistic/activity/{customerCount}?startDate= 2020-7-21&endDate= 2020-7-22 – Gets the most active customers in a period of time, for example, from 2020-7-21 to 2020-7-22
GET/api/statistic/income/{categoryId}?startDate= 2020-7-21&endDate= 2020-7-22 – Gets the income of category in a period of time, for example, from 2020-7-21 to 2020-7-22
......

არქიტექტურა:
გამოყენებულია onion Architecture:
![image](https://github.com/guga2002/GA.TradeMarket.Api/assets/74540934/bb2ee8c7-9da5-4c38-8698-600d7438e31e)
აგრეთვე გამოყენებულია სხვა დიზაინ პატერებიც: unite of work, Dependency of inversion, solid პრინციპები.



