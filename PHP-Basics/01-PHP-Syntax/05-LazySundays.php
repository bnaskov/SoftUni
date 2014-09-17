<?php
// Write a PHP script LazySundays.php which prints the dates of all Sundays in the current month.

$totalDays = date("t");
$month = date("F");
$year = date("Y");

for($i = 1; $i <= $totalDays; $i++){
    $date = strtotime("$i $month $year");
    if(date("l",$date)=="Sunday"){
        echo date("jS F, Y", $date) . "\n";
    }
}

?>