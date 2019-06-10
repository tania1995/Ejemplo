<!DOCTYPE html>
<html>
<head>
   <title></title>
</head>
<body>
<?php
   include ("config.php");
?>
<a href="agregar.php" target="_self">Agregar Usuario</a>
<a href="inhabilitados.php" target="_self">Inhabilitados</a>

                     <table border="1">
                           <thead>
                              <tr>
                                 <th>No</th>
                                 <th>Login</th>
                                 <th>Password</th>
                                 <th>Inhabilitar</th>
                              </tr>
                           </thead>
                           <tbody> 
                    <?php             
                        $sql="SELECT * FROM usuarios WHERE habilitado=1";
                        $execonsulta=$mysqli->query($sql);
                        $indice=1;
                        while($row=mysqli_fetch_array($execonsulta))
                        {
                           ?>
                        <tr>
                         <td><?php echo $indice; ?></td>
                                 <td><?php echo $row['login']; ?></td>
                                 <td><?php echo $row['password']; ?></td>
               
                                 <td>
                                    <form action="eliminardb.php" method="post">
                                       <input type="hidden" name="idusuario" value="<?php echo $row['idusuario']; ?>">
                                       <button type="submit">Inhabilitar</button>
                                    </form>
                                 </td>
                         </tr>
                           <?php
                           $indice++;
                        }
                     ?>
                           </tbody>
                        </table>

</body>
</html>