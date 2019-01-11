<?php

    require_once "Helper.php";

    $helper = new Helper();

    if (isset($_GET["ip"]) && isset($_GET["playerId"])) {
        $id = $_GET["ip"];
        $playerId = $_GET["playerId"];
        echo $helper->addIP($id, $playerId);
    }
    else {
        echo json_encode(array(
            "result" => false,
            "msg" => "Champs ip et playerId non renseignés"
        ));
    }