<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <title>Text Filter</title>
</head>
<body>
<form method="post">
    <label for="text">Text: </label>
    <textarea rows="4" cols="50" name="text" id="text" required="required"></textarea>
    <label for="banlist">Banlist: </label>
    <input type="text" name="banlist" id="banlist" required="required"/>
    <input type="submit" value="Filter Text"/>
</form>
<?php
if(isset($_POST['text'])  && !empty($_POST['text']) && isset($_POST['banlist']) && !empty($_POST['banlist'])){
    $text = $_POST['text'];
    $banlist = preg_split('/[, ]{2}+/', $_POST['banlist']);
    $replacedText = $text;
    // echo var_dump($banlist);
    for($i = 0; $i < count($banlist); $i++){
        $banWord = $banlist[$i];
        $template = '';
        for($j = 0; $j<strlen($banWord); $j++){
            $template .= '*';
        }
        $replacedText = str_ireplace($banWord, $template, $replacedText);
    }
    echo $replacedText;
}
?>
</body>
</html>