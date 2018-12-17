<?php
if (isset($_POST['btnnew'])) {
echo '1';
 include('config.php');
 if (strlen($_POST['txtu']) == 11 && strlen($_POST['txtp']) > 3 && $_POST['txtp1'] == 'omid1234') {
 $username = $_POST['txtu'];
 $password = md5($_POST['txtp']);
 $shopName = $_POST['shop'];
 $res = mysql_query("INSERT INTO tbl_user VALUES('$username','$password','$shopName')");
 echo 'کاربر جدید ایجاد شد';
 }
}
?>
<html>
<body>
<form id="form1" name="form1" method="post" action="#">
  <p>
    <label for="txtu">
      <input type="text" name="txtu" id="txtu" />
    لطفا شماره تماس 11 رقمی را وارد کنید</label></p>
  <p>
    <input type="text" name="txtp" id="txtp" />
  رمز ورود را نیز وارذ کنید &nbsp;&nbsp;&nbsp;&nbsp;</p>
  <p>
    <input type="text" name="shop" id="shop" />
  لطفا نام فروشگاه را وارد کنید</p>
  <p>
    <input type="text" name="txtp1" id="txtp1" />
  رمز عبور برای ساخت کاربر جدید را وارد کنید</p>
  <p>
    <input type="submit" name="btnnew" id="btnnew" value="Insert" />
  </p>
</form>
</body>
</html>