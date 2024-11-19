<?php
class Sessie
{
    public $id;
    public $userId;
    public $key;
    public $start;
    public $end;
    public static function vindSessies()
    {
        $sessie = null;
        if (isset($_COOKIE["steptember-session"])) {
            require "Connectie.php";
            $key = mysqli_real_escape_string($conn, $_COOKIE["steptember-session"]);
            $query = "SELECT * FROM sessions WHERE session_key = '$key' AND session_end > '" . date("Y-m-d H:i:s") . "'";
            $resultaat = $conn->query($query);
            if ($resultaat->num_rows > 0) {
                $row = $resultaat->fetch_assoc();
                $sessie = new Sessie();
                $sessie->id = $row["session_id"];
                $sessie->userId = $row["session_user_id"];
                $sessie->key = $row["session_key"];
                $sessie->start = $row["session_start"];
                $sessie->end = $row["session_end"];
            }
            $conn->close();
        }
        return $sessie;
    }
    public function newSessie()
    {
        require "Connectie.php";
        $userId = mysqli_real_escape_string($conn, $this->userId);
        $key = mysqli_real_escape_string($conn, $this->key);
        $start = mysqli_real_escape_string($conn, $this->start);
        $end = mysqli_real_escape_string($conn, $this->end);
        $sql = "INSERT INTO sessions (session_user_id, session_key, session_start, session_end) VALUES ( '$userId', '$key', '$start', '$end')";
        $resultaat = $conn->query($sql);
        return $resultaat;
    }
}
