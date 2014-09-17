<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <title>URL Replacer</title>
</head>
<body>
<form method="post">
    <textarea rows="4" cols="50" name="text" id="text" required="required"></textarea>
    <input type="submit" value="Replace"/>
</form>
<?php
if(isset($_POST['text'])  && !empty($_POST['text'])){
    $text = $_POST['text'];
    // echo $text;
    $text = preg_replace('/<a\s+href\s*=\s*[\'"]/', '[URL=', $text);
    $text = preg_replace('/<\s*\/\s*a\s*>/', '[/URL]', $text);
    $text = preg_replace('/["\']\s*>/', ']', $text);
    echo $text;
}
?>
</body>
</html>