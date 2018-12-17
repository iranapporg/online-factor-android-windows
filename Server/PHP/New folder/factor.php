<?php
if (isset($_POST['action']) && isset($_POST['phone']) && isset($_POST['shop']) && isset($_POST['date']) && isset($_POST['factor_id'])) {
 if ($_POST['action'] == 'newfactor') {
  $phone = mysql_real_escape_string($_POST['phone']);
  $date  = mysql_real_escape_string($_POST['date']);
  $shop  = mysql_real_escape_string($_POST['shop']);
  $id    = mysql_real_escape_string($_POST['factor_id']);
  include('config.php');
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
?>