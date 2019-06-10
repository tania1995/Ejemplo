<?php
error_reporting(E_ALL ^ E_DEPRECATED);
$hostname="localhost:3306";
$usuario="root";
$password="";
$basededatos="incos2019";
$mysqli = new mysqli($hostname, $usuario, $password, $basededatos);
$mysqli->set_charset("utf8");
?>