<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Repository Pattern Demo - Read Me</title>
</head>
<body>
<p>
    Ok, here's the steps I took to create this demo.
</p>
<p>
    <i>Please note, I've not created any actual databases for this project as it's wasn't needed for the demonstration.</i>
    <br />
    <i>To add database stuff, use your normal method for connecting and create database entities (essentially classes which map to your database tables).</i>
</p>
<div>
    <ol>
        <li>Right-click on your Models folder and choose "Add -> Class"</li>
        <li>Call that class Product and give it the following public properties:
            <ul>
                <li>ID (data type = int)</li>
                <li>Name (data type = string)</li>
                <li>QuantityInStock (data type = int)</li>
            </ul>           
        </li>
        <li>Now we need to create a folder in our solution called ViewModels. This will hold our business entities, in this case we are calling a business entity a ViewModel</li>
        <li>Right-click on this folder and select "Add -> Class", and call the class ProductModel</li>
        <li>Give this class the following properties:
            <ul>
                <li>ID (data type int)</li>
                <li>Name (data type string)</li>
                <li>StockQuantity (data type int) <i>I know there is a new property, I'll explain later</i></li>
            </ul>
        </li>
        <li>Next, create a folder in your solution for holding your interface classes. In this case we'll call it, you guessed it, Interfaces</li>
        <li>Now we're going to create the interface for the repository class
            <ul>
                <li><i>Interfaces aren't a requirement of the repository pattern, although I highly recommend this approach as it aids in things like unit testing and dependency injection</i></li>
            </ul>
        </li>
        <li>Right-click on the Interfaces folder and select "Add -> New Item", then select Interface as the item type and call it IProductRepository</li>
        <li>Make this interface public (so we can use it in our application), add the "using" statement to include the ViewModel namespace and add the following methods:
            <ul>
                <li>ProductModel GetProduct(string name);</li>
                <li>ProductModel CreateProduct(ProductModel product);</li>
                <li>ProductModel UpdateProduct(ProductModel product);</li>
            </ul>
        </li>
        <li>Now add a new folder to your solution to hold your repository classes, in this case we'll call it Repositories (bet ya didn't see that coming!)</li>
        <li>Right-click on the Repositories folder and select "Add -> Class", and call the class ProductRepository</li>
        <li>Make the class public if it isn't already, so we can use it throughout our application</li>
        <li>In this class, add the "using" statements to include the namespaces for the following folders:
            <ul>
                <li>Interfaces</li>
                <li>Models</li>
                <li>ViewModels</li>
            </ul>
        </li>
        <li>Make this class inherit from the interface we just created (by adding : IProductRepository after the class name)</li>
        <li>Implement the interface by right-clicking on the interface name after the class name and selecting "Implement Interface -> Implement Interface"</li>
        <li>In each of the methods, implement code for retrieving or updating the product data and mapping the fields to the ProductModel objects <i>See the code examples</i></li>
        <li>Now we're going to use these in our application <i>Yay!!</i></li>
        <li>Right-click on the "Controllers" folder and select "Add -> Controller", and in this case we'll just call it HomeController as this is the default for MVC3 <i>Leave the template as Empty Controller</i></li>
        <li>In the controller, add the "using" statements to include the Repositories and ViewModels namespaces</li>
        <li>In the Index action (created automatically by Visual Studio), create a new ProductRepository instance called productRepo</li>
        <li>Now create a new instance of ProductModel called product for a product called "My Product" by calling the GetProduct method of the repository, as follows:
            <ul>
                <li>ProductModel product = productRepo.GetProduct("My Product");</li>
            </ul>
        </li>
        <li>Return the product to your view</li>
        <li>Right-click on the Index method name and select "Add View", and create a strongly typed view for the ProductModel class, and select the scaffolding for Details</li>
        <li>You should now be able to run your project and see the information for the product displayed on the page</li>
    </ol>
    <p>
        This should, hopefully, show you how to use the repository pattern in your code.
        <br /> can expand on this example to see use the other repository methods you created.
    </p>
    <p>
        I'd suggest creating more controllers which make use of the ProductModel and ProductRepository classes, so you've got a bunch of places in your application using them, then try changing the property name in Product from QuantityInStock to something else, like StockAmount, and see where you need to change it.
        <br />I hope you'll see that, rather than changing it everywhere in your controllers, you simply need to change it in your repository and that's that.
    </p>
    <p>
        Anyway, if you think this demo has been useful then please let me know, or if you think it can be expanded on then I'm open to useful suggestions too!
    </p>
</div>
</body>
</html>
