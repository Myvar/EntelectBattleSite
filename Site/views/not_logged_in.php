<?php include('_header.php'); ?>


<h1><a href="index.php">Entelect Challenge Battle Site</a></h1>
		Links:<br>
		<a href="index.php?p=setup">Set up your bot</a><br>
		<a href="index.php?p=matchdb">View all matches ever played</a><br>
		<a href="index.php?p=lb">Leader bords</a><br>

<hr>

<?php 
if(isset($_GET['p']))
{
	include('./pages/' . $_GET['p'] . '.php' );
	
}
else
{
	include('./pages/home.php' );
}

?>


<form method="post" action="index.php" name="loginform">
    <label for="user_name"><?php echo WORDING_USERNAME; ?></label>
    <input id="user_name" type="text" name="user_name" required />
    <label for="user_password"><?php echo WORDING_PASSWORD; ?></label>
    <input id="user_password" type="password" name="user_password" autocomplete="off" required />
    <input type="checkbox" id="user_rememberme" name="user_rememberme" value="1" />
    <label for="user_rememberme"><?php echo WORDING_REMEMBER_ME; ?></label>
    <input type="submit" name="login" value="<?php echo WORDING_LOGIN; ?>" />
</form>

<a href="register.php"><?php echo WORDING_REGISTER_NEW_ACCOUNT; ?></a>
<a href="password_reset.php"><?php echo WORDING_FORGOT_MY_PASSWORD; ?></a>



<?php include('_footer.php'); ?>
