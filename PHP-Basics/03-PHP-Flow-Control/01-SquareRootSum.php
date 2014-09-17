<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <title>Square Root Sum</title>
    <style>
        table, th, td, tr {
            border: 1px solid black;
        }
    </style>
</head>
<body>
    <table>
        <thead>
            <tr>
                <th>Number</th>
                <th>Square Root</th>
            </tr>
        </thead>
        <?php
        $sum = 0;
        for( $i = 0; $i <=100; $i+=2):
        $sqrtRounded = round(sqrt($i), 2);
        $sum += $sqrtRounded;
        ?>
        <tr>
            <td><?= $i ?></td>
            <td><?= $sqrtRounded ?></td>
        </tr>
        <?php endfor; ?>
        <tfoot>
        <tr>
            <td><strong>Total:</strong></td>
            <td><?= $sum ?></td>
        </tr>
        </tfoot>
    </table>
</body>
</html>