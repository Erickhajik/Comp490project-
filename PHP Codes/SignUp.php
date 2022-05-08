<?php 
$servername = "localhost";
$username = "root";
$password = "password";
$database="asylumDB";
$makeConnection = new mysqli($servername,$username,$password,$database);
if(mysqli_connect_errno())//if retrun true then the connection between server is 
{
echo ("Cannot connect to Database");

}

$playername =$_POST['userName'];
$checkName="SELECT username FROM Level1 WHERE username= '" . $playername . "';";
// check query

$check = mysqli_query($makeConnection,$checkName);
if(mysqli_num_rows($check)>0)//if there is an input with same name,it wont add the name
{
        echo("0");
}

$addname ="INSERT INTO Level1(username) VALUES ('" . $playername . "');";
mysqli_query($makeConnection,$addname);

mysqli_close($makeConnection);

?>

