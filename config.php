<?php
// Declara a URL de callback para a qual o Servidor de Autorização 
// deverá encaminhar o retorno com o código de autorização
$CALLBACK_URL = "https://trabalhotecweb.azurewebsites.net/OAuthCallback.php";

// Configuração da API do Google
$GOOGLE_API_AUTH_URL = "https://accounts.google.com/o/oauth2/auth";
$GOOGLE_API_TOKEN_URL = "https://accounts.google.com/o/oauth2/token";
$GOOGLE_API_RESOURCE_URL = "https://www.googleapis.com/oauth2/v1/userinfo";
$GOOGLE_CLIENT_ID = "COLOQUE AQUI SEU CLIENT_ID";
$GOOGLE_CLIENT_SECRET_KEY = "COLOQUE AQUI SEU SECRET_KEY";
$GOOGLE_SCOPE = "https://www.googleapis.com/auth/plus.me";
    
// Configuração da API do Facebook
$FACEBOOK_API_AUTH_URL = "https://www.facebook.com/v2.9/dialog/oauth";
$FACEBOOK_API_TOKEN_URL = "https://graph.facebook.com/v2.9/oauth/access_token";
$FACEBOOK_API_RESOURCE_URL = "https://graph.facebook.com/v2.9/me";
$FACEBOOK_CLIENT_ID = "678128462374354";
$FACEBOOK_CLIENT_SECRET_KEY = "5fe534cbc389e0d261a18f7b44ea7422";
$FACEBOOK_SCOPE = "public_profile, email";    

?>
