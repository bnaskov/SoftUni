<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>HTML Table</title>
</head>
<style>
    table {
        border-collapse: collapse;
    }
        tr td{
            border: 1px solid black;
            width: 120px;
            padding: 2px 5px;
        }
            tr td:nth-child(2){
                text-align: right;
            }
            tr td:first-child{
                background-color: #FFA100;
            }
</style>
<body>
<?php
$name = 'Gosho';
$phoneNum = '0882-321-423';
$age = 24;
$address = 'Hadji Dimitar';
?>
<table>
    <tr>
        <td><strong>Name</strong></td>
        <td><?php echo $name?></td>
    </tr>
    <tr>
        <td><strong>Phone Number</strong></td>
        <td><?php echo $phoneNum?></td>
    </tr>
    <tr>
        <td><strong>Age</strong></td>
        <td><?php echo $age?></td>
    </tr>
    <tr>
        <td><strong>Address</strong></td>
        <td><?php echo $address?></td>
    </tr>
</table>
</body>
</html>