(function (d, s, id) {
    var js, fjs = d.getElementsByTagName(s)[0];
    if (d.getElementById(id)) return;
    js = d.createElement(s); js.id = id;
    js.src = "//connect.facebook.net/en_US/sdk.js";
    fjs.parentNode.insertBefore(js, fjs);
}(document, 'script', 'facebook-jssdk'));

window.fbAsyncInit = function () {
    FB.init({
        appId: '678128462374354',
        cookie: true,  // enable cookies to allow the server to access the session
        xfbml: true,  // parse social plugins on this page
        version: 'v2.8' // use graph api version 2.8
    });

    FB.getLoginStatus(function (response) {
        statusChangeCallback(response);
    });

};

function statusChangeCallback(response) {
    console.log(response);
    if (response.status === 'connected') {
        connectToDB();
    } else {
        document.getElementById('status').innerHTML = 'Você foi deslogado com sucesso!';
    }
}

function checkLoginState() {
    FB.getLoginStatus(function (response) {
        statusChangeCallback(response);
    });
}

function connectToDB() {
    FB.api('/me?fields=education,name', function (response) {
        //document.getElementById('status').innerHTML = 'Bem vindo ' + response.name + '!';
        $("#tituloUsuario").text(response.name);
        $.ajax({
            async: false,
            url: '/webservice/WebService1.asmx/CheckIfUserAlreadyLoggedAndAddEducation',
            contentType: "application/json",
            data: { result: JSON.stringify(response) },
            success: getEducationSuccess,
            error: function (result) {
                alert(result);
            }
        });

        response.education.forEach(function (obj, idx) {
            {
                var tipoEnsino = obj.type === 'High School' ? 'Ensino Médio' : 'Faculdade';
                $.ajax({
                    async: false,
                    url: '/webservice/WebService1.asmx/addEducation',
                    contentType: "application/json",
                    data: {
                        nomeInstituicao: JSON.stringify(obj.school.name),
                        inicio: JSON.stringify(obj.year.name),
                        tipoEnsino: JSON.stringify(tipoEnsino)
                    },
                    success: getEducationSuccess,
                    error: function (result) {
                        alert(result);
                    }
                })
            }
        })

        $('#visualization').fadeIn(1500);
        $('#btFacebook').fadeOut(1500);
        var divVisualization = $('#visualization');
        var timeline = new vis.Timeline(divVisualization[0], new vis.DataSet(timelineItems), {});

        //response.education.forEach(function (obj, idx) {
        //    {
        //        var tipoEnsino = obj.type === 'High School' ? 'Ensino Médio' : 'Faculdade';
        //        $.ajax({
        //            async: false,
        //            url: '/webservice/WebService1.asmx/addEducation',
        //            contentType: "application/json",
        //            data: {
        //                nomeInstituicao: JSON.stringify(obj.school.name),
        //                inicio: JSON.stringify(obj.year.name),
        //                tipoEnsino: JSON.stringify(tipoEnsino)
        //            },
        //            success: getEducationSuccess,
        //            error: function (result) {
        //                alert(result);
        //            }
        //        })
        //    }
        //})
    });
}

var timelineItems = new Array();
var idx = 0;
function getEducationSuccess(result) {
    if (result.d.sucesso) {
        var item = { id: result.d.id, tipo: result.d.tipoEnsino, content: '<div onclick=\'show(' + idx + ')\'><b>' + result.d.tipoEnsino + '</b><br></div>' + result.d.nomeInstituicao, start: result.d.strDtInicio };
        idx++;
        timelineItems.push(item);
    } else {
        alert(result.d.mensagem);
    }
}

function show(obj) {
    var obj = timelineItems[obj];
}