<?php

require_once "Helper.php";

$helper = new Helper();

if (isset($_GET["idJoueur"]) && isset($_GET["idArt"])) {
    $idJoueur = $_GET["idJoueur"];
    $idArt = $_GET["idArt"];
    echo $helper->PNJEffectue($idJoueur, $idArt);
}
else {
    echo json_encode(array(
        "result" => false,
        "msg" => "Champs id et idExamen non renseignés"
    ));
}