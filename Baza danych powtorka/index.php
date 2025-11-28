<?php

class db {
    private $mysqli;

    public function __construct() {
        $this->mysqli = new mysqli("localhost", "root", "", "baza");
        if ($this->mysqli->connect_error) {
            die("błąd połączenia: " . $this->mysqli->connect_error);
        }
    }

    public function get_all() {
        $sql = "select * from testowa";
        return $this->mysqli->query($sql);
    }

    public function get_count() {
        $sql = "select count(*) as liczba from testowa";
        return $this->mysqli->query($sql)->fetch_assoc();
    }

    public function get_avg_age() {
        $sql = "select round(avg(wiek)) as srednia from testowa";
        return $this->mysqli->query($sql)->fetch_assoc();
    }

    public function get_youngest() {
        $sql = "select * from testowa order by wiek asc limit 1";
        return $this->mysqli->query($sql)->fetch_assoc();
    }

    public function get_oldest() {
        $sql = "select * from testowa order by wiek desc limit 1";
        return $this->mysqli->query($sql)->fetch_assoc();
    }
}

$db = new db();

$all = $db->get_all();
$count = $db->get_count();
$avg = $db->get_avg_age();
$young = $db->get_youngest();
$old = $db->get_oldest();

?>

<!doctype html>
<html lang="pl">
<head>
<meta charset="utf-8">
<title>dane z bazy</title>
</head>
<body>

<h2>wszystkie rekordy</h2>
<table border="1" cellpadding="5">
<tr>
    <th>imię</th>
    <th>nazwisko</th>
    <th>wiek</th>
</tr>

<?php while ($row = $all->fetch_assoc()): ?>
<tr>
    <td><?php echo $row["imie"]; ?></td>
    <td><?php echo $row["nazwisko"]; ?></td>
    <td><?php echo $row["wiek"]; ?></td>
</tr>
<?php endwhile; ?>
</table>

<h2>statystyki</h2>
<p>łączna liczba osób: <?php echo $count["liczba"]; ?></p>
<p>średnia wieku: <?php echo $avg["srednia"]; ?></p>

<h3>najmłodsza osoba</h3>
<p><?php echo $young["imie"] . " " . $young["nazwisko"] . ", wiek: " . $young["wiek"]; ?></p>

<h3>najstarsza osoba</h3>
<p><?php echo $old["imie"] . " " . $old["nazwisko"] . ", wiek: " . $old["wiek"]; ?></p>

</body>
</html>
