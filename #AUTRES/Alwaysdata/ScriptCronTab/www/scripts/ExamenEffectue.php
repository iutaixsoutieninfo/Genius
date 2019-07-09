<?php

require_once "Helper.php";

$helper = new Helper();

if (isset($_GET["idJoueur"]) && isset($_GET["idExamen"])) {
    $idJoueur = $_GET["idJoueur"];
    $idExamen = $_GET["idExamen"];
    echo $helper->ExamenEffectue($idJoueur, $idExamen);
}
else {
    echo json_encode(array(
        "result" => false,
        "msg" => "Champs id et idExamen non renseignés"
    ));
}