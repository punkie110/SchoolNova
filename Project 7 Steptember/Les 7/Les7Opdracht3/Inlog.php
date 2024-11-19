<?php
class Inlog{
public int $id;
public string $username;
public string $password;
public static function gebruikersInlog($username, $password)
    {
        require "Les7Opdracht3.php";
        $username = mysqli_real_escape_string($conn, $username);
        $password = mysqli_real_escape_string($conn, $password);
        $sql = "SELECT * FROM users WHERE user_username = '$username' AND user_password = '$password'";
        $resultaat = $conn->query($sql);
        $users = [];
        if ($resultaat->num_rows > 0) {
            while ($row = $resultaat->fetch_assoc()) {
                $user = new Inlog();
                $user->id = $row["user_id"];
                $user->username = $row["user_username"];
                $user->password = $row["user_password"];
                $users[] = $user;
            }
        }
        return $users;
    }
}
?>