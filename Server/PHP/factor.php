<?php
if (isset($_POST['action']) && isset($_POST['phone']) && isset($_POST['username']) && isset($_POST['date']) && isset($_POST['factor_id'])) {
 if ($_POST['action'] == 'newfactor') {
  include('config.php');
  $phone = $_POST['phone'];
  $date  = $_POST['date'];
  $shop  = getShopName($_POST['username']);
  $id    = $_POST['factor_id'];
  mysql_query("INSERT INTO tbl_factor VALUES('',$id,'$date','$phone','$shop','0')");

  
  $products = json_decode($_POST['factor']);
  $sql = "";
  foreach($products as $product) {
  
     $id1   = $product->sID;
	 $name  = $product->sName;
	 $price = str_replace(",","",$product->sPrice);
	 $count = $product->sCount;
	 
	 $sql = "INSERT INTO tbl_product(sProductID,sName,sPrice,sCount,sFactorID) VALUES($id1,'$name',$price,$count,'$id');";
	 //file_put_contents('a.txt',$sql,FILE_APPEND);
	 mysql_query($sql);
	}
 }
}

function getShopName($username)
 {
  $s1 = "SELECT sShopName FROM tbl_user WHERE sUsername = '$username'";
  $res = mysql_query($s1);
  $row = mysql_fetch_array($res);
  return $row['sShopName'];
 }
?>