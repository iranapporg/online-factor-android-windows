<?php
if (isset($_POST['username']) && isset($_POST['action'])) 
 if ($_POST['action'] == 'verify') {
  include('config.php');
  $username = mysql_real_escape_string($_POST['username']);
  $factor_id = mysql_real_escape_string($_POST['factor_id']);
  $sql = "UPDATE tbl_factor SET sVerify = 1 WHERE sFactorID = " . $factor_id . " AND sPhone = '" . $username ."'";
  file_put_contents('a.txt',$sql);
  $res = mysql_query($sql);
  echo '1';
}
else
 echo '0';
?>