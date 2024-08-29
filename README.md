# Orders Repository API
This is just a simple kata to practice Outside In and web Api Patterns such as CQRS

## Requirements
Our API should be able to:
* Create an order with basic data.
* Display an order as requested.

* Update basic data of and order, specified by its OrderNUmber.
* Add a product to an existent order product list as requested by user.
* Create a bill for and specified order.

## Features (Gherkin Language)
### Orders display
- Having a stored order in the system
- When the user requests it by its OrderNumber
- That orders is displayed with the following data:
>- **ID: 1**
>- **OrderNumber: OWA87643**
>- **Customer: John Doe**
>- **Address: A Simple Street, 123**
>- **Products:**
>  - **Product:**
>    - **Name: Computer Monitor**
>    - **Price: 100€**
>  - **Product:**
>    - **Name: Keyboard** 
>    - **Price: 30€**


### Orders products update
- Having a stored order in the system
- When the user adds two new products
- That orders is displayed with the following data:
>- **ID: 1**
>- **OrderNumber: OWA87643**
>- **Customer: John Doe**
>- **Address: A Simple Street, 123**
>- **Products:**
>  - **Product:**
>    - **Name: Computer Monitor**
>    - **Price: 100€**
>  - **Product:**
>    - **Name: Keyboard** 
>    - **Price: 30€**
>  - **Product:**
>    - **Name: Mouse**
>    - **Price: 15€**
>  - **Product:**
>    - **Name: Router** 
>    - **Price: 70€**
