var highestBox = 0;
$('.skill').each(function () {

    if ($(this).height() > highestBox)
        highestBox = $(this).height();
})

$('.skill').each(function () {
    $(this).height(highestBox);
})