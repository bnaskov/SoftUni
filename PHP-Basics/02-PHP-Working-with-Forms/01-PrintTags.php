<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Print Tags</title>
</head>
<body>
<p>Enter Tags:</p>
<form method="post">
    <input type="text" placeholder="Tags" name="tags">
    <input type="submit" name="formData">
</form>

<?php
if(isset ($_POST['tags'])) {
    $tags = htmlentities($_POST['tags']);
    $tagsAsArray = explode(", ", $tags);
    $counter = 0;
    foreach($tagsAsArray as $value){
        echo "$counter : $value" . "<br>";
        $counter++;
    }
}
?>
</body>
</html>
