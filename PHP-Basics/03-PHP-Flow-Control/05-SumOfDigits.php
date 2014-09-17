<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <title>Sum of Digits</title>
    <style>
        table, td {
            border: 1px solid black;
        }
    </style>
</head>
<body>
<form method="post">
    <label for="inpStr">Input String:</label>
    <input type="text" name="inpStr" id="inpStr"/>
    <input type="submit" value="Submit"/>
</form>
<?php
if(isset($_POST['inpStr'])  && !empty($_POST['inpStr'])){
    $inputString = $_POST['inpStr'];
    $inputAsArray = preg_split('/[ ,;]+/', $inputString);
?>

<table>

<?php
    foreach($inputAsArray as $value){
        if(is_numeric($value)){
        $sum = 0;
        for($j = 0; $j < strlen($value); $j++){
            $sum += intval($value[$j]);
        }
?>
            <tr><td><?= htmlentities($value) ?></td><td><?= $sum ?></td></tr>
<?php
        } else {
?>
            <tr><td><?= htmlentities($value) ?></td><td><?= 'I cannot sum that' ?></td></tr>
<?php
        }
    }
?>
</table>
<?php
}
?>
</body>
</html>