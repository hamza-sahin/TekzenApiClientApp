<b>API Client App For Tekzen Company</b>

When you run the program, you will see two different options as Store List and Order List. After selecting any of them, the program pulls the necessary data from the API and uploads it to the relevant models (classes) and reflects them in a tabular form to the user.

Models:

Inside the models folder I created 5 different models, these are:

- MagazaModel: The class in which the data (Success, Message, MekanResponse []) received from the store query is kept.
- MekanResponseModel: The class where the information about the places is kept.
- OrderModel: The class in which the data (Success, Message, OrderResponse []) received from the order query is kept.
- SiparisResponseModel: The class in which data about orders are kept.
- BelgeSatirlariModel: The class in which the data in the document lines in the orders are kept.

Pages:

- MagazaData.razor: The page that creates a new http client for a new store query and pulls the store information from the API and reflects it to the user.
- OrderData.razor: The page that creates a new http client for a new order query and pulls the order information from the API and reflects it to the user.

Changes I Made in Auxiliary Files:

- In the Startup.cs file, when creating a new http client, I used a function where you can change the necessary configuration parameters directly via appsettings.json. Thus, you can change information such as email and password that may change in the future in one place and make it easier.
