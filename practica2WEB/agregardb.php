<!DOCTYPE html>
<html>
<head>
	<title></title>
</head>
<body>
<?php
include("config.php");
$nombres=$_POST['login'];
$apellidos=$_POST['password'];
$apellidos2=$_POST['password2'];


$sql="insert into usuarios set login='$nombres', password='$apellidos', password2='$apellidos2'";
$mysqli->query($sql);
header("Location: login.php");
		/*echo '<script type="text/javascript">
		window.location.assign("lista.php");
		</script>';*/
?>
</body>
</html>