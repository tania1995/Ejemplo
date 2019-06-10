<!DOCTYPE html>
<html>
<head>
	<title></title>
</head>
<body>
	<?php
   include ("config.php");
	?>
<a href="login.php" target="_self">REGISTRARSE</a>

<form action="agregardb.php" method="post">
		<input type="text" name="login" placeholder="Ingrese login"></input>
		<br>
		<input type="text" name="password" placeholder="Ingrese su password"></input>
		<br>
		<input type="text" name="password" placeholder="Ingrese nuevamente password"></input>
		<br>
		<button type="submit">REGISTRAR</button>
</form>
 <?php             
                        $sql="SELECT password , password2 FROM usuarios WHERE password2>=5";
                        $execonsulta=$mysqli->query($sql);
                        $indice=1;
                        while($row=mysqli_fetch_array($execonsulta))
                        {
                           ?>
                        


</body>
</html>