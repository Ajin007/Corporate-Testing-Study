************************************************************Cake study*****************************

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Cake Shop</title>
    <style>
        header{
            background-color: rgb(37, 37, 37);
            padding: 30px 0px;
        }
        header h1{
            margin: 0px;
            color: rgb(255, 255, 255);
        }
        img{
            max-width: 20%;
        }
        button{
            cursor: pointer;
        }
        body{
            text-align: center;
            font-family: Arial, sans-serif;
        }
    </style>
</head>
<body>
    <!-- Write your structure here -->
    <header>
        <h1>Welcome to Our Cake Shop</h1>
    </header>
    <main>
        <section class="menu">
            <h3>Menu</h3>
            <table>
                <tr>
                    <th>Cake Name</th>
                    <th>Description</th>
                    <th>Price</th>
                </tr>
                <tr>
                    <td>Chocolate Cake</td>
                    <td>A rich and moist chocolate cake</td>
                    <td>$20</td>
                </tr>
                <tr>
                    <td>Strawberry Shortcake</td>
                    <td>Fresh strawberries and whipped cream</td>
                    <td>$18</td>
                </tr>
                <tr>
                    <td>Vanilla Cake</td>
                    <td>Classic vanilla cake with buttercream frosting</td>
                    <td>$22</td>
                </tr>
                <tr>
                    <td>Red Velvet Cake</td>
                    <td>Delicious red velvet cake with cream cheese icing</td>
                    <td>$24</td>
                </tr>
                <tr>
                    <td>Lemon Cake</td>
                    <td>Tangy lemon-flavored cake with lemon glaze</td>
                    <td>$23</td>
                </tr>
                <tr>
                    <td>Carrot Cake</td>
                    <td>Moist carrot cake with cream cheese frosting</td>
                    <td>$25</td>
                </tr>
                <tr>
                    <td>Black Forest Cake</td>
                    <td>Chocolate sponge cake with cherries and whipped cream</td>
                    <td>$26</td>
                </tr>
            </table>
        </section>
        <section class="order-form">
            <h3>Place an Order</h3>
            <form>
                <label for="cake-type">Select Cake:</label><br/>
                <select name="cake_select" id="cake-type">
                    <option value="select cake" disabled>Select Cake</option>
                    <option value="select cake">Select Cake</option>
                    <option value="select cake">Select Cake</option>
                    <option value="select cake">Select Cake</option>
                    <option value="select cake">Select Cake</option>
                    <option value="select cake">Select Cake</option>
                    <option value="select cake">Select Cake</option>
                    <option value="select cake">Select Cake</option>
                </select>
                <label for="quantity">Select Cake:</label><br/>
                <input type="text" id="quantity"/>
                <button type="submit" id="submit-button">Place Order</button>
            </form>
        </section>
        <section class="graphics">

        </section>
        <section class="images">
            <img src="" alt="">
        </section>
        <section class="accessibility">

        </section>
    </main>
</body>
</html>
