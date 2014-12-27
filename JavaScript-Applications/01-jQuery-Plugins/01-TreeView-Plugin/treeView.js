(function() {
    var isHide = true;

    $(function () {
        $('.item').click(function () {
            $('.sub-items').toggle('fold', 1000);
        });

        $('.sub-item').click(function () {
            $('.in-sub-items').toggle('fold', 1000);
        });
    });

}());