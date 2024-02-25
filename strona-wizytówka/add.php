<?php
$host = "localhost"; // adres hosta
$username = "root"; // nazwa użytkownika bazy danych
$password = ""; // hasło użytkownika bazy danych
$database = "test_firma"; // nazwa bazy danych

// Nawiązanie połączenia z bazą danych
$connection = mysqli_connect($host, $username, $password, $database);

// Sprawdzenie czy udało się połączyć z bazą danych
if (!$connection) {
    die("Błąd połączenia z bazą danych: " . mysqli_connect_error());
}
if (isset ($_POST)){
    $name=$_POST['name'];
    $email=$_POST['email'];
    $nr_telefonu=$_POST['nr_telefonu'];
    $message=$_POST['message'];
    
    $sql = "INSERT INTO formularz (name, email, nr_telefonu, message) VALUES ('{$name}', '{$email}', '{$nr_telefonu}', '{$message}')";

    $result=mysqli_query($connection, $sql);
    if($result){
        echo 'Dodano';
    }
    else{
        echo 'Nie dodano';
    }
  mysqli_close($connection);
}