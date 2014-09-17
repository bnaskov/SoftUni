<?php
// Write a PHP script NonRepeatingDigits.php that declares an integer variable N, and then finds all 3-digit numbers
// that are less or equal than N (<= N) and consist of unique digits. Print "no" if no such numbers exist.

$n = 247;
$str = '';
if($n < 102){
    echo 'no';
}else{
    for($i = 1; $i<=9; $i++){
        for($k = 0; $k<=9; $k++){
            for($l = 0; $l<=9; $l++){
                if($i*100 + $k*10 + $l > $n){
                    break;
                }
                if($i !== $k && $i !== $l && $l !== $k){
                    $str = $str . $i . $k . $l . ', ';
                }
            }
        }
    }
}
echo rtrim($str, ", ");

?>