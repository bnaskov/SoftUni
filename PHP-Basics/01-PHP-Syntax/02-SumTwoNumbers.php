<?php
// Write a PHP script SumTwoNumbers.php that declares two variables, firstNumber and secondNumber.
// They should hold integer or floating-point numbers (hard-coded values). Print their sum in the output in the
// format shown in the examples below. The numbers should be rounded to the second number after the decimal point.
// Find in Internet how to round a given number in PHP.

$firstNum = 5;
$secondNum = 2;
echo '$firstNum + $secondNum = ' . "$firstNum + $secondNum = " . number_format($firstNum+$secondNum,2) . "\n";

$firstNum = 1.567808;
$secondNum = 0.356;
echo '$firstNum + $secondNum = ' . "$firstNum + $secondNum = " . number_format($firstNum+$secondNum,2) . "\n";

$firstNum = 1234.5678;
$secondNum = 333;
echo '$firstNum + $secondNum = ' . "$firstNum + $secondNum = " . round($firstNum+$secondNum,2) . "\n";
?>