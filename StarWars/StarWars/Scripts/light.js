function changeSideNo() {
    var $footer = $(".footer");
    $($footer.children()).remove();
    $footer.text("Cool choose BRO!");
}
function changeSideYes() {
    var id = $(".content").attr("data-id");
    $.ajax({
        type:"POST",
        url: "/Home/ChangeSide/" + id,
        success: function () {
            location.reload();
        }
    });           
}