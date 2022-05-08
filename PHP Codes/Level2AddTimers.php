<?php 
$servername = "localhost";
$username = "root";
$password = "password";
$database="asylumDB";
$makeConnection = new mysqli($servername,$username,$password,$database);


$playername =$_POST['userName'];
$start =$_POST['gamestart'];
$puz1S =$_POST['puzzle1start'];
$puz1E =$_POST['puzzle1end'];
$puz2S =$_POST['puzzle2start'];
$puz2E =$_POST['puzzle2end'];
$puz3S =$_POST['puzzle3start'];
$puz3E =$_POST['puzzle3end'];
$end=$_POST['endtime'];//gameend

$addTime =$makeConnection->prepare("UPDATE Level2 SET gamestart='" . $start . "',level2puzzle1start='" . $puz1S . "',level2puzzle1end='" . $puz1E . "',level2puzzle2start='" . $puz2S . "',level2puzzle2end='" . $puz2E . "',level2puzzle3start='" . $puz3S . "',level2puzzle3end='" . $puz3E . "',level2endtime='" . $end . "' WHERE username ='" . $playername . "';");
$addTime->bind_param("sssssssss",$start,$puz1S,$puz1E,$puz2S,$puz2E,$puz3S,$puz3E,$end,$playername);
$addTime->execute();

$addTime->close();
$makeConnection->close();
?>
