<!DOCTYPE html>
<html>
<head>
	<title></title>
</head>
<body>
<?php
include("config.php");
$idempleado=$_POST['idusuario'];
$sql="update usuarios SET habilitado=0 where idusuario=$idempleado";

$mysqli->query($sql);
header("Location: lista.php");
		/*echo '<script type="text/javascript">
		window.location.assign("lista.php");
		</script>';*/
?>
</body>
</html>