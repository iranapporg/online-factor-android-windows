<?php
if (isset($_POST['action']) && isset($_POST['username']))
  if ($_POST['action'] == 'check') {
   include('config.php');
   
   $username = mysql_real_escape_string($_POST['username']);
   $res = mysql_query("select * from tbl_factor where sPhone = '$username' and sVerify = 0");
   
   if (mysql_num_rows($res) == 0)
    echo '0';
   else
    {
	  if (isset($_POST['type'])) {
	   echo mysql_num_rows($res);
	   exit;
	  }
	  $factor = "";
	  $temp = "";
	  while($row = mysql_fetch_array($res))
	   {
	   
	     $date = $row['sDate'];
		 $shop = $row['sShopName'];
		 $id   = $row['sFactorID'];
		 $factor = $date.'<!!>'.$shop.'<!!>'.$id.'<!!>'.getPhone($shop).'<!!!!>';
		 
		 $res1 = mysql_query("SELECT * FROM tbl_product WHERE sFactorID = $id");
		 $products = "";
		 
		 while ($product = mysql_fetch_array($res1))
		  {
		    $name   = $product['sName'];
			$price  = $product['sPrice'];
			$count  = $product['sCount'];
			$code   = $product['sProductID'];
			$products .= $name.'!!!'.$price.'!!!'.$count.'!!!'.$code.'???';
		  }
		  
		 $temp .= $factor.$products.'<p>';
	   }
	   echo $temp;
	}
 }
 
 function getPhone($sShopName)
  {
	  $s1 = "SELECT sUsername FROM tbl_user WHERE sShopName = '$sShopName'";
	  $res = mysql_query($s1);
	  $row = mysql_fetch_array($res);
	  return $row['sUsername'];
  }
?>