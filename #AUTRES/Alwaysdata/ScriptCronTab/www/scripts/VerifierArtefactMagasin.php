<?php

require_once "Helper.php";

$helper = new Helper();

if (isset($_GET["id"])) {
    $id = $_GET["id"];
    echo $helper->VerifierArtefactMagasin($id);
}
else {
    echo json_encode(array(
        "result" => false,
        "msg" => "Champs id non renseigné"
    ));
}