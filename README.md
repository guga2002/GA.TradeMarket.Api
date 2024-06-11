Domain  აღწერა:
სუპერმარკეტებში იყიდება სხვადასხვა კატეგორიის საქონელი(პროდუქცია). მომხმარებელს შეუძლია იყიდოს პროდუქტი დაამატოს კალათაში, ასევე შეუძ₾ია დაამატოს სურვილების სიაში). ყიდვისას იქმნება შეკვეთა რომელსაც ებმება  (receipt) და (receiptetails) სადაც დეტალურად აღწერილია კონკრეტულ მერჩანთან შეძენილი საქონლის ჩამონათვალი.
აგრეთვე მომხარებელს (operator,manager)-ს შეუძ₾ია ნახოს სტატისტიკა , ნახოს  ისტორია .მომხმარებელს შეუძლია   დაუწეროს პროდუქციას განხილვა, შესაბამისი პრეტენზიის დროს კი მოითხოვოს თანხის უკან დაბრუნება.
რელაციიური სტრუქტურა:

![image](https://github.com/guga2002/GA.TradeMarket.Api/assets/74540934/0785a3e4-7b84-4254-ad50-5cfc92ad1b1e)


ენდპოინტები:(სერვისები:)

![image](https://github.com/guga2002/GA.TradeMarket.Api/assets/74540934/2bd7e937-db73-4fe2-90ce-009da00a3c85)

......
რეალური და სწრაფი კომუნიკაციისთვის  ვიყენებთ, SMTP- სერვერს  რისი საშუალებითაც მომხმარებელს ვატყობინებთ სიახლეს , აგრეთვე ახალი მოწყობილოის ავტორიზაციას. და ასე შემდეგ, მაგალითებს მოვიყვან ქვემოთ:

![image](https://github.com/guga2002/GA.TradeMarket.Api/assets/74540934/2c7234a2-3acf-47da-8b18-8a79035ab125)

![image](https://github.com/guga2002/GA.TradeMarket.Api/assets/74540934/b00ec45c-911b-4452-a5f7-93d3b7fdf2c6)

![image](https://github.com/guga2002/GA.TradeMarket.Api/assets/74540934/4fd3bfb6-3e0f-4406-b139-ce4cbf0f26fc)

![image](https://github.com/guga2002/GA.TradeMarket.Api/assets/74540934/d641edb6-a26d-42b9-b660-94cecde522d2)

![image](https://github.com/guga2002/GA.TradeMarket.Api/assets/74540934/dcab0351-f61d-429d-a833-0fa67a676e33)

![image](https://github.com/guga2002/GA.TradeMarket.Api/assets/74540934/58587dd4-eef5-42e0-917e-693275766856)


არქიტექტურა:
გამოყენებულია nion Architecture(Clean Architecture):

![image](https://github.com/guga2002/GA.TradeMarket.Api/assets/74540934/bb2ee8c7-9da5-4c38-8698-600d7438e31e)


აგრეთვე გამოყენებულია სხვა დიზაინ პატერებიც: unite of work, Dependency of inversion, solid პრინციპები.



