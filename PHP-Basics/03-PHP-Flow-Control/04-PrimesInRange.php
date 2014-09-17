<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <title>Find Primes in Range</title>
</head>
<body>
<form method="post">
    <label for="startIndex">Starting Index</label>
    <input type="text" name="startIndex" id="startIndex"/>
    <label for="endIndex">End: </label>
    <input type="text" name="endIndex" id="endIndex"/>
    <input type="submit" value="Submit"/>
</form>
<?php
    if(isset($_POST['startIndex'])  && !empty($_POST['startIndex']) && isset($_POST['endIndex']) && !empty($_POST['endIndex'])){
        $startIndex = $_POST['startIndex'];
        $endIndex = $_POST['endIndex'];
        // function that checks if a number is prime
        function isPrime($num) {
            if($num == 1)
                return false;
            if($num == 2)
                return true;
            if($num % 2 == 0) {
                return false;
            }
            for($i = 3; $i <= ceil(sqrt($num)); $i = $i + 2) {
                if($num % $i == 0)
                    return false;
            }
            return true;
        }

        $arrayNum = array();
        for($i = $startIndex; $i<=$endIndex; $i++){
            if(isPrime($i)){
                array_push($arrayNum, '<strong>' . $i . '</strong>');
            } else {
                array_push($arrayNum, $i);
            }
        }
        $comma_separated = implode(", ", $arrayNum);
        echo $comma_separated;
    }
?>
</body>
</html>