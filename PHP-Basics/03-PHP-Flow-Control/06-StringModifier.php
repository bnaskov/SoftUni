<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <title>Modify Strings</title>
</head>
<body>
<form method="post">
    <input type="text" name="inpStr"/>
    <input type="radio" name="radioStr" id="palindrome" value="palindrome" required="required" />
    <label for="palindrome">Check Palindrome</label>
    <input type="radio" name="radioStr" id="revString" value="revString" required="required"/>
    <label for="revString">Reverse String</label>
    <input type="radio" name="radioStr" id="splitStr" value="splitStr" required="required"/>
    <label for="splitStr">Split</label>
    <input type="radio" name="radioStr" id="hashStr" value="hashStr" required="required"/>
    <label for="splitStr">Hash String</label>
    <input type="radio" name="radioStr" id="shuffleStr" value="shuffleStr" required="required"/>
    <label for="shuffleStr">Shuffle String</label>
    <input type="submit" value="Submit"/>
</form>
<?php
    if(isset($_POST['inpStr']) && !empty($_POST['inpStr'])){
        $inputString = $_POST['inpStr'];
        $selectedRadio = $_POST['radioStr'];
        // case 1: Palindrome
        if($selectedRadio === 'palindrome'){
            if(strtolower(strrev($inputString)) ===
               strtolower($inputString)){
                echo htmlentities($inputString) . ' is a palindrome!';
            } else {
                echo htmlentities($inputString) . ' is not a palindrome!';
            }
        }
        // case 2: Reverse String
        if ($selectedRadio === 'revString'){
            $arrayWords = explode(' ', $inputString);
            for($i = (count($arrayWords)-1); $i>=0; $i-- ){
                echo htmlentities(strrev($arrayWords[$i])) . ' ';
            }
        }
        // case 3: Split
        if ($selectedRadio === 'splitStr'){
            $connectedWords = str_replace(' ', '', $inputString);
            for ($i = 0; $i < strlen($connectedWords)-1; $i++){
                echo htmlentities($connectedWords[$i]) . ' ';
            }
            echo htmlentities($connectedWords[strlen($connectedWords)-1]);
        }
        // case 4: Hash String
        if ($selectedRadio === 'hashStr'){
            echo htmlentities(crypt($inputString));
        }
        // case 5: Shuffle String
        if ($selectedRadio === 'shuffleStr'){
            echo htmlentities(str_shuffle($inputString));
        }
    }
?>

</body>
</html>