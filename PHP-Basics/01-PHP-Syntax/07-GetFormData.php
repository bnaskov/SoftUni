<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Form Data</title>
</head>
<style>
    input{
        display: block;
    }
    input[type="radio"]{
        display: inline-block;
    }
</style>
<body>

<form method="post">
    <input type="text" placeholder="Name.." name="name">
    <input type="text" placeholder="Age.." name="age">
    <input type="radio" name="sex" value="male">Male
    <input type="radio" name="sex" value="female">Female
    <input type="submit" name="formData" value="Изпращане">
</form>

<?php
if(isset ($_POST['formData'])) {
    $name = $_POST['name'];
    $age = $_POST['age'];
    $sex = $_POST['sex'];
    echo "My name is {$name}. I am {$age} years old. I am {$sex}.";
}
?>
</body>
</html>