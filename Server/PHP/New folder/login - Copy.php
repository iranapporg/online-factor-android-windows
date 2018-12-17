<?php
if (isset($_POST['username']) && isset($_POST['password'])) {
 include('config.php');
 $username = mysql_real_escape_string($_POST['username']);
 $password = mysql_real_escape_string($_POST['password']);
 $res = mysql_query("SELECT * FROM tbl_user WHERE sUsername='$username' AND sPassword = '$password'");
 if (mysql_num_rows($res) == 0)
  echo 'false';
 else
  echo 'true';
}
?>