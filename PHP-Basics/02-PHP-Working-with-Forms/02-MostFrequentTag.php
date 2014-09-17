<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Most Frequent Tag</title>
</head>
<body>
<p>Enter Tags:</p>
<form method="post">
    <input type="text" placeholder="Tags" name="tags">
    <input type="submit" name="formData">
</form>

<?php
if(isset ($_POST['tags'])) {
    // "Pesho, homework, homework, exam, course, PHP, zena, PHP, wasp, PHP, doge, doge"
    $tags = htmlentities($_POST['tags']);
    $tagsAsArray = explode(", ", $tags);
    $assocArr = array();
    for($i = 0; $i < count($tagsAsArray); $i++){
        if(array_key_exists($tagsAsArray[$i],$assocArr)){
            $assocArr[$tagsAsArray[$i]]++;
        } else {
            $assocArr[$tagsAsArray[$i]] = 1;
        }
    }
    array_multisort($assocArr, SORT_DESC);
    foreach ($assocArr as $key => $value){
        echo "<br>$key : $value times";
    }
    reset($assocArr);
    $first_key = key($assocArr);
    echo "<p>Most Frequent Tag is: $first_key</p>";
}
?>
</body>
</html>