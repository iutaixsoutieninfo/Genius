<?php

require_once "Helper.php";

$helper = new Helper();

if (isset($_GET["id"]) && isset($_GET["idArt"])) {
    $id = $_GET["id"];
    $idArt = $_GET["idArt"];
    echo $helper->ArtefactUtilise($id, $idArt);
}
else {
    echo json_encode(array(
        "result" => false,
        "msg" => "Champs id et idArt non renseignés"
    ));
}