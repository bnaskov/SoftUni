<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <title>Rich People’s Problems</title>
</head>
<style>
    table, th, td{
        border: 1px solid black;
    }
</style>
<body>
    <form method="post">
        <label for="cars">Enter cars</label>
        <input type="text" name="cars" id="cars" placeholder="Cars"/>
        <input type="submit" value="Show results"/>
    </form>
    <?php
        $colors = array('black', 'white', 'red', 'gold');
    if(isset($_POST['cars'])  && !empty($_POST['cars'])){
        $cars = $_POST['cars'];
        $carsAsArray = explode(', ', $cars);
        // $carsAsArray = preg_split('/[ ,;]+/', $cars);
        $colors = array('black', 'white', 'red', 'gold');
        ?>
        <table>
            <thead>
                <tr>
                    <th>Cars</th>
                    <th>Color</th>
                    <th>Count</th>
                </tr>
            </thead>
        <tbody>
        <?php
        for($i = 0; $i < count($carsAsArray); $i++){
            echo '<tr><td>' . htmlentities($carsAsArray[$i]) . '</td><td>' . $colors[rand(0,3)] . '</td><td>' . rand(1,5) . '</td></tr>';
        }
        ?>
        </tbody>
            </table>
    <?php } ?>
</body>
</html>