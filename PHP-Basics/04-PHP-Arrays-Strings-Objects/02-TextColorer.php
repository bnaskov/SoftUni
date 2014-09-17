<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <title>Coloring Texts</title>
</head>
<style>
    textarea{
        display: block;
    }
</style>
<body>
<form method="post">
    <textarea rows="4" cols="50" name="textColor"></textarea>
    <input type="submit" value="Color Text"/>
</form>
<?php
if(isset($_POST['textColor'])  && !empty($_POST['textColor'])){
    $inputString = $_POST['textColor'];
    $connected = str_replace(' ', '', $inputString);
    for ($i = 0; $i < strlen($connected); $i++){
        $char = $connected[$i];
        if(ord($char)%2 != 0){
            echo '<span style="color: #0000ff;">' . $char . '</span>' . ' ';
        } else {
            echo '<span style="color: #ff0000;">' . $char . '</span>' . ' ';
        }
    }
}
?>
</body>
</html>