<?php
$newYear = "2015-01-01 00:00:00";
$currentDate = date("Y-m-d H:i:s");

$seconds =(strtotime($newYear)-strtotime($currentDate));
$minutes = floor($seconds/60);
$hours = floor($minutes/60);
$days = floor($seconds/86400);
$hoursLeft = floor(($seconds - $days * 24 * 60 * 60)/60/60);
$minutesLeft = floor(($seconds - $days * 24 * 60 * 60 - $hoursLeft * 60 * 60)/60);
$secondsLeft = $seconds - $days * 86400 - $hoursLeft * 60 * 60 - $minutesLeft * 60;

echo "Hours until new year : {$hours} </br>";
echo "Minutes until new year : {$minutes} </br>";
echo "Seconds until new year : {$seconds} </br>";
echo "Days:Hours:Minutes:Seconds {$days}:{$hoursLeft}:{$minutesLeft}:{$secondsLeft}</br>";
?>