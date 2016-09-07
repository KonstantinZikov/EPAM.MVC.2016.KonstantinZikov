function changeSideNo() {
    var $footer = $(".footer");
    $($footer.children()).remove();
    $footer.text("Cool choose BRO!");
}
function changeSideYes() {
    var id = $(".content").attr("data-id");
    $.post("Home/ChangeSide/" + id, {}, function () {
        location.reload();
    })
}