$('.form-signin').on('submit', function () {
    $.ajax({
        url: "/Home/Login"
        ,
        type: "POST"
        ,
        data: JSON.stringify({
            Usuario: {
                Nome: $("#username").val()
                ,
                Senha: $("#password").val()
            }
        })
        ,
        contentType: 'application/json; charset=utf-8'
        ,
        success: function () {
            window.location = "/Tarefas"
        }
        ,
        error: function (e) {
            console.log(e)
            showError(e.responseText)
        }
    })
})

function showError(errorMessage) {
    var container = $('.alert');
    container.removeClass('d-none');
    container.html(errorMessage);
}