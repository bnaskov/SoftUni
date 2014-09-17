<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <title>Sidebar Builder</title>
<style>
    aside{
        border: 1px solid black;
        border-radius: 10px;
        background-color: #C2D3EA;
        width: 150px;
        padding: 10px;
        margin-top: 10px;;
    }
    h3, hr{
        margin: 0px;
        padding: 0px;
        border-color: black;
    }
</style>
</head>
<body>
<form method="post">
    <label for="categories">Categories: </label>
    <input type="text" name="categories" id="categories"/>
    <label for="tags">Tags: </label>
    <input type="text" name="tags" id="tags"/>
    <label for="months">Months: </label>
    <input type="text" name="months" id="months"/>
    <input type="submit" value="Generate"/>
</form>
<?php
if(isset($_POST['categories'])  && !empty($_POST['categories']) && isset($_POST['tags']) && !empty($_POST['tags']) && isset($_POST['months']) && !empty($_POST['months'])){
    $categories = preg_split('/[, ]{2}+/', $_POST['categories']);
    $tags = preg_split('/[, ]{2}+/', $_POST['tags']);
    $months = preg_split('/[, ]{2}+/', $_POST['months']);
?>
<aside class="categories">
    <h3>Categories</h3>
    <hr/>
    <ul type="circle">
        <?php
        foreach($categories as $category):
            ?>
            <li><a href=""><?= htmlentities($category) ?></a></li>
        <?php endforeach; ?>
    </ul>
</aside>
<aside class="tags">
    <h3>Tags</h3>
    <hr/>
    <ul type="circle">
        <?php
        foreach($tags as $tag):
        ?>
        <li><a href=""><?= htmlentities($tag) ?></a></li>
        <?php endforeach; ?>
    </ul>
</aside>
<aside class="months">
    <h3>Months</h3>
    <hr/>
    <ul type="circle">
        <?php
        foreach($months as $month):
            ?>
            <li><a href=""><?= htmlentities($month) ?></a></li>
        <?php endforeach; ?>
    </ul>
</aside>
<?php
}
?>
</body>
</html>