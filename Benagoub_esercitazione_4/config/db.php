<?php
$pdo = new PDO('mysql:host=localhost;dbname=taskmanager;charset=utf8', 'root', 'bellissimo');
$pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
