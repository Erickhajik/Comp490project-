<?php 
$servername = "localhost";
$username = "root";
$password = "password";
$database="asylumDB";
$makeConnection = new mysqli($servername,$username,$password,$database);


$Display=$makeConnection->prepare("SELECT * FROM Level1");
// check query
$Display->execute();
$result =$Display->get_result();
$numRow =$result->num_rows;
if ($numRow > 0) {
  // output data of each row
 
 
     while($row=$result->fetch_assoc())
           {
    echo "Username:" . $row["username"]. "|gamestart:" . $row["gamestart"]. "|puzzle1start:" . $row["puzzle1start"]. "|puzzle1end:" . $row["puzzle1end"]. "|puzzle2start:" . $row["puzzle2start"]. "|puzzle2end:" . $row["puzzle2end"]. "|puzzle3start:" . $row["puzzle3start"]. "|puzzle3end:" . $row["puzzle3end"]. "|endtime:" . $row["endtime"]. ";";
  }
} 

$makeConnection->close();
$Display->close();
 ?>

