$(function () {
    $('.change_image').change(function () {
        var input = this;
        if (input.files) {
            var rdr = new FileReader();
            rdr.onload = function (e) {
                $('.change_edit').attr('src', e.target.result);
            }
            rdr.readAsDataURL(input.files[0]);
        }
    })
});
