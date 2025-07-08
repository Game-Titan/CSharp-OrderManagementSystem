# C# Order Management System

This is a simple console-based application implemented in C# to manage basic customer order information. It demonstrates Object-Oriented Programming (OOP) principles, including the use of **static members**.

## Features

* **Order Creation:** Define customer orders with an ID, customer name, and amount.
* **Display Order Information:** Show details for individual orders.
* **Track Total Orders:** Utilizes a static member to keep a running count of all orders created during the application's runtime.

## Code Structure

The application primarily consists of an `Order` class.

### `Order` Class

* **Properties:** `OrderId` (int), `CustomerName` (string), `Amount` (decimal).
* **Static Property:** `TotalOrders` (int) - Tracks the count of all `Order` objects created.
* **Constructor:** Initializes `Order` objects and increments the `TotalOrders` static counter.
* **Methods:**
    * `DisplayOrderInfo()`: Prints details of a specific order to the console.
    * `DisplayTotalOrdersCreated()` (Static Method): Prints the total number of orders created across all instances of the `Order` class.

## Future Enhancements (Ideas)

* Add a collection (e.g., `List<Order>`) to store and manage multiple orders dynamically.
* Implement functionalities for adding new orders via user input.
* Add options to search for orders, modify order details, or delete orders.
* Implement error handling for invalid input data.
* Separate classes into different files for larger projects.

## Contributing

Feel free to suggest improvements or enhancements by opening issues or submitting pull requests.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

