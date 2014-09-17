<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <title>Word Mapping</title>
</head>
<style>
    table, td{
        border: 1px solid #919191;
        background-color: #D3D3D3;
    }
    textarea{
        display: block;
    }
</style>
<body>
<form method="post">
    <textarea rows="4" cols="50" name="wordsMapper"></textarea>
    <input type="submit" value="Count Words"/>
</form>
<?php
if(isset($_POST['wordsMapper'])  && !empty($_POST['wordsMapper'])){
    $inputString = strtolower($_POST['wordsMapper']);
    $pattern = '/[a-zA-Z]+/';
    preg_match_all($pattern, $inputString, $inputAsArray, PREG_SET_ORDER);
    $wordsAsArr = [];
    for($i = 0; $i<count($inputAsArray); $i++){
        $word = $inputAsArray[$i][0];
        if(isset($wordsAsArr[$word])){
            $wordsAsArr[$word]++;
        } else {
            $wordsAsArr[$word] = 1;
        }
    }
    // Sort an array in reverse order and maintain index association
    arsort($wordsAsArr);
    ?>
    <table>
        <?php
        foreach($wordsAsArr as $key => $value):
        ?>
            <tr><td><?= htmlentities($key) ?></td><td><?= $value ?></td></tr>
        <?php
        endforeach;
        ?>
    </table>
<?php
}
?>
</body>
</html>