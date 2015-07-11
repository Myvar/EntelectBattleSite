<?php include('_header.php'); ?>


<h1><a href="index.php">Entelect Challenge Battle Site</a></h1>
		Links:<br>
		<a href="index.php?p=setup">Set up your bot</a><br>
		<a href="index.php?p=matchdb">View all matches ever played</a><br>
		<a href="index.php?p=lb">Leader bords</a><br>



<?php
// if you need the user's information, just put them into the $_SESSION variable and output them here
echo WORDING_YOU_ARE_LOGGED_IN_AS . $_SESSION['user_name'] . "<br /><hr>";
if(isset($_GET['p']))
{
	include('./pages/' . $_GET['p'] . '.php' );
	
}
else
{
	include('./pages/home.php' );
}

?>
<hr>
<div>
    <a href="index.php?logout"><?php echo WORDING_LOGOUT; ?></a>
    <a href="edit.php"><?php echo WORDING_EDIT_USER_DATA; ?></a>
</div>

<?php include('_footer.php'); ?>
