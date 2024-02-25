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

// Pobranie danych z bazy danych
$query = "SELECT * FROM numery_kierunkowe";
$result = mysqli_query($connection, $query);

// Sprawdzenie czy zapytanie zostało wykonane poprawnie
if ($result) {
    // Przetwarzanie wyników zapytania
    
    echo '<div>';
    echo '<select class="kierunkowy">';
    while ($row = mysqli_fetch_assoc($result)) {
        // Generowanie struktury HTML z danymi
        
        echo '<option class="kierunkowy" value =' . $row["Kierunkowy"] .'> ' . $row["Kierunkowy"] . " " . $row["Kraj"]  . '</p>';
    }
    echo '</select>';
    echo '</div>';
    
    // Zwolnienie zasobów związanych z wynikami zapytania
    mysqli_free_result($result);
} else {
    echo "Błąd zapytania: " . mysqli_error($connection);
}

// Zakończenie połączenia
mysqli_close($connection);
?>