<!DOCTYPE html>
<html>
<head>
	<title></title>
</head>
<body>
<?php
include("config.php");
$idempleado=$_POST['idempleado'];
$nombres=$_POST['nombres'];
$apellidos=$_POST['apellidos'];
$edad=$_POST['edad'];
echo $idempleado.$nombres.$apellidos.$edad;
$sql="update empleados set nombres='$nombres', apellidos='$apellidos', edad='$edad' where idempleado=$idempleado";
$mysqli->query($sql);
header("Location: lista.php");
		/*echo '<script type="text/javascript">
		window.location.assign("lista.php");
		</script>';*/
?>
</body>
</html>