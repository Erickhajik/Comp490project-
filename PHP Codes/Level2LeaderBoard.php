<?php 
$servername = "localhost";
$username = "root";
$password = "password";
$database="asylumDB";
$makeConnection = new mysqli($servername,$username,$password,$database);


$Display=$makeConnection->prepare("SELECT * FROM Level2");
// check query
$Display->execute();
$result =$Display->get_result();
$numRow =$result->num_rows;
if ($numRow > 0) {
  // output data of each row
 
 
     while($row=$result->fetch_assoc())
           {
    echo "Username:" . $row["username"]. "|gamestart:" . $row["level2gamestart"]. "|puzzle1start:" . $row["level2puzzle1start"]. "|puzzle1end:" . $row["level2puzzle1end"]. "|puzzle2start:" . $row["level2puzzle2start"]. "|puzzle2end:" . $row["level2puzzle2end"]. "|puzzle3start:" . $row["level2puzzle3start"]. "|puzzle3end:" . $row["level2puzzle3end"]. "|endtime:" . $row["level2endtime"]. ";";
  }
} 

$makeConnection->close();
$Display->close();
 ?>

