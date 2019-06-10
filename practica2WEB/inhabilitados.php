<!DOCTYPE html>
<html>
<head>
   <title></title>
</head>
<body>
<?php
   include ("config.php");
?>
<a href="agregar.php" target="_self">AGREGAR USUARIO</a>
<a href="lista.php" target="_self">Habilitar</a>

                     <table border="1">
                           <thead>
                              <tr>
                                 <th>No</th>
                                 <th>Login</th>
                                 <th>Password</th>
                                 <th>login</th>
                              </tr>
                           </thead>
                           <tbody> 
                    <?php             
                        $sql="SELECT * FROM usuarios WHERE password2>=5";
                        $execonsulta=$mysqli->query($sql);
                        $indice=1;
                        while($row=mysqli_fetch_array($execonsulta))
                        {
                           ?>
                        <tr>
                         <td><?php echo $indice; ?></td>
                                 <td><?php echo $row['login']; ?></td>
                                 <td><?php echo $row['password']; ?></td>
                                 <td><?php echo $row['password2']; ?></td>

               
                                 <td>
                                    <form action="habilitar.php" method="post">
                                       <input type="hidden" name="idusuario" value="<?php echo $row['idusuario']; ?>">
                                       <button type="submit">habilitar</button>
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