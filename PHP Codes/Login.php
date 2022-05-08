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
$passwrod =$_POST['Paswe'];
$checkName=$makeConnection->prepare("SELECT username,password FROM UserAccount WHERE username=? AND password=? LIMIT 1");
$checkName->bind_param("ss",$Usename,$Pass);
  $checkName->execute();
   $result = $checkName->get_result();
        $num_rows = $result->num_rows;
        if( $num_rows==1)
        {
            echo("0");
        }


mysqli_close($makeConnection);

?>

