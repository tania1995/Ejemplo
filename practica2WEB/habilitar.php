!DOCTYPE html>
<html>
<head>
	<title></title>
</head>
<body>
<?php
include("config.php");
$idempleado=$_POST['idusuario'];
$sql="update usuarios SET habilitado=>5 where idusuario=$idempleado";

$mysqli->query($sql);
header("Location: inhabilitados.php");
		/*echo '<script type="text/javascript">
		window.location.assign("lista.php");
		</script>';*/
?>
</body>
</html>