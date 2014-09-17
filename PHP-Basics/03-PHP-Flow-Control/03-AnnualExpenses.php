<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <title>Annual Expenses</title>
</head>
<style>
    table, th, td{
        border: 1px solid black;
    }
</style>
<body>
<form method="post">
    <label for="numYears">Enter Number of Years</label>
    <input type="text" name="numYears" id="numYears" placeholder="Enter Number of Years"/>
    <input type="submit" value="Show costs"/>
</form>
<?php
if(isset($_POST['numYears'])  && !empty($_POST['numYears'])){
    $numYears = htmlentities($_POST['numYears']);
    ?>
    <table>
        <thead>
            <tr>
                <th>Year</th>
                <th>January</th>
                <th>February</th>
                <th>March</th>
                <th>April</th>
                <th>May</th>
                <th>June</th>
                <th>July</th>
                <th>August</th>
                <th>September</th>
                <th>October</th>
                <th>November</th>
                <th>December</th>
                <th>Total:</th>
            </tr>
        </thead>
        <tbody>
        <?php
        function randNum() {
            $randNumber = rand(0, 999);
            return $randNumber;
        };
        for($i = 0; $i < $numYears; $i++):
            $year = 2014 - $i;
            $jan = randNum();
            $feb = randNum();
            $march = randNum();
            $april = randNum();
            $may = randNum();
            $june = randNum();
            $july = randNum();
            $august = randNum();
            $september = randNum();
            $october = randNum();
            $november = randNum();
            $december = randNum();
            $total = $jan + $feb +$march + $april + $may + $june + $july + $august + $september + $november + $december;
            ?>
        <tr>
            <td><?= $year ?></td>
            <td><?= $jan ?></td>
            <td><?= $feb ?></td>
            <td><?= $march ?></td>
            <td><?= $april ?></td>
            <td><?= $may ?></td>
            <td><?= $june ?></td>
            <td><?= $july ?></td>
            <td><?= $august ?></td>
            <td><?= $september ?></td>
            <td><?= $october ?></td>
            <td><?= $november ?></td>
            <td><?= $december ?></td>
            <td><?= $total ?></td>
        </tr>
        <?php
        endfor;
        }
        ?>
        </tbody>
    </table>
</body>
</html>