<?php

require_once "../Helper.php";

$helper = new Helper();

if (isset($_GET["id"]) && isset($_GET["idAmi"]) && isset($_GET["type"])) {
    $id = $_GET["id"];
    $idAmi = $_GET["idAmi"];
    $type = $_GET["type"];
    echo $helper->TransfertActionSocialeEnBase($id, $idAmi, $type);
}
else {
    echo json_encode(array(
        "result" => false,
        "msg" => "Champ id non renseigné"
    ));
}