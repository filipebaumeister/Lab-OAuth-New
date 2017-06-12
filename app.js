var webserviceUrl = 'http://trabalhotecweb.azurewebsites.net/';

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

var education;
function connectToDB() {
    FB.api('/me?fields=education,name', function (response) {
        $("#tituloUsuario").text(response.name);
        education = response.education;
        let lstEducations = new Array();

        response.education.forEach(function (obj, idx) {
            {
                let jsonEducation = new Object();
                jsonEducation.tipoEnsino = obj.type === 'High School' ? 'Ensino Médio' : 'Faculdade';
                jsonEducation.nomeInstituicao = obj.school.name;
                jsonEducation.inicio = obj.year.name;
                lstEducations.push(jsonEducation);
            }
        })

        $.ajax({
            async: false,
            url: '/webservice/WebService1.asmx/CheckIfUserExists',
            contentType: "application/json",
            data: { id: JSON.stringify(response.id), nome: JSON.stringify(response.name), lstEducations: JSON.stringify(lstEducations) },
            success: getEducationSuccess,
            error: function (result) {
                $('#status').html(result.responseText);
            }
        });


        $('#visualization').fadeIn(1500);
        $('#btFacebook').fadeOut(1000);
        var divVisualization = $('#visualization');
        var timeline = new vis.Timeline(divVisualization[0], new vis.DataSet(timelineItems), {});
    });
}

var timelineItems = new Array();
function getEducationSuccess(result) {
    if (!result.d.sucesso){
        $('#status').html(result.responseText);
    } else {
        //var x = education;
        result.d.lstEducations.forEach(function (obj, idx) {
            var item = { id: obj.id, tipo: obj.tipoEnsino, content: '<div onclick=\'show(' + JSON.stringify(obj) + ')\'><b>' + obj.tipoEnsino + '</b><br></div>' + obj.nomeInstituicao, start: obj.inicio, end: obj.fim };
            timelineItems.push(item);
        })
    } 
}

function show(obj) {
    id = obj.id;
    $('#formEnsino').show('slow');
    $('#iNome').val(obj.nomeInstituicao);
    $('#iTipo').val(obj.tipoEnsino);
    $('#iInicio').val(new Date(obj.inicio).toString('yyyy-MM-dd'));
    $('#iFim').val(new Date(obj.fim).toString('yyyy-MM-dd'));
}

var id;
function alterarEnsino() {
    var nome = $('#iNome').val();
    var tipo = $('#iTipo').val();
    var inicio = $('#iInicio').val();
    var fim = $('#iFim').val();

    $.ajax({
        url: '/webservice/WebService1.asmx/AlterarEnsino',
        contentType: "application/json",
        data: {
            id: JSON.stringify(id),
            nome: JSON.stringify(nome),
            tipo: JSON.stringify(tipo),
            inicio: JSON.stringify(inicio),
            fim: JSON.stringify(fim),
        },
        success: function (result) {
            if (result.d.sucesso) {
                toastr.success()
            }
        },
        error: function (result) {
            $('#status').html(result.responseText);
        }
    });
}