<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Most Frequent Tag</title>
    <style>
        div{
            display: block;
        }
    </style>
</head>
<body>
<section>
    <form method="post">
        <div>
            <label for="amount">Enter Amount</label>
            <input type="text" name="amount" id="amount"/>
        </div>
        <div>
            <input type="radio" name="currency" value="$"/>USD
            <input type="radio" name="currency" value="€"/>EUR
            <input type="radio" name="currency" value="£"/>GBP
        </div>
        <div>
            <label for="compAmount">Compound Interest Amount</label>
            <input type="text" name="compAmount" id="compAmount"/>
        </div>
        <div>
            <select name="period">
                <option value="6">6 months</option>
                <option value="12">1 year</option>
                <option value="24">2 years</option>
                <option value="60">5 years</option>
            </select>
            <input type="submit" name="submit" value="Calculate"/>
        </div>
    </form>
</section>

<?php
if(isset ($_POST['submit'])) {
    $result = htmlentities($_POST['amount']) * pow((1 + htmlentities($_POST['compAmount'])/1200), $_POST['period']);
    $currency = $_POST['currency'];
    echo $currency  . " " . round($result, 2);
}
?>
</body>
</html>