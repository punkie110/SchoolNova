<?php
class Blog
{
    public $id;
    public $titel;
    public $foto;
    public $content;
    public $autheur;

    //Een functie die alle blogs ophaalt uit de database.
    public static function findAll()
    {
        $blogs = [];

        $conn = Database::Start();

        $query = "SELECT * FROM blogs";
        $resultaat = $conn->query($query);

        if ($resultaat->num_rows > 0) {
            while ($row = $resultaat->fetch_assoc()) {
                $blog = new Blog();
                $blog->id = $row["blog_id"];
                $blog->titel = $row["blog_title"];
                $blog->foto = $row["blog_image"];
                $blog->content = $row["blog_content"];
                $blog->autheur = $row["blog_author"];
                $blogs[] = $blog;

            }
        }
        $conn->close();

        return $blogs;
    }

    //een functie die een blog ophaalt op basis van een ID
    public static function getOne($id)
    {
        $blog = null;

        $conn = Database::Start();

        $query = "SELECT * FROM blogs WHERE blog_id = '$id'";
        $resultaat = $conn->query($query);

        if ($resultaat->num_rows > 0) {
            while ($row = $resultaat->fetch_assoc()) {
                $blog = new Blog();
                $blog->id = $row["blog_id"];
                $blog->titel = $row["blog_title"];
                $blog->foto = $row["blog_image"];
                $blog->content = $row["blog_content"];
                $blog->autheur = $row["blog_author"];

            }
        }
        $conn->close();

        return $blog;
    }

    //een Insert functie die een blog aan de database toevoegd
    public function insert()
    {
        $conn = Database::Start();

        $titel = mysqli_real_escape_string($conn, $this->titel);
        $foto = mysqli_real_escape_string($conn, $this->foto);
        $content = mysqli_real_escape_string($conn, $this->content);
        $autheur = mysqli_real_escape_string($conn, $this->autheur);

        $sql = "INSERT INTO blogs (blog_title, blog_image, blog_content, blog_author) 
        VALUES ( '" . $titel . "' , '" . $foto . "', '" . $content. "', '" . $autheur . "')";

        $conn->query($sql);
        $conn->close();
    }
    //een update functie die een blog met nieuwe waardes update.
    public function update()
    {
        $blog = null;

        $conn = Database::Start();
        $blog = new Blog();

        $id = mysqli_real_escape_string($conn, $this->id);
        $titel = mysqli_real_escape_string($conn, $this->titel);
        $foto = mysqli_real_escape_string($conn, $this->foto);
        $content = mysqli_real_escape_string($conn, $this->content);
        $autheur = mysqli_real_escape_string($conn, $this->autheur);

        $query = "UPDATE blogs SET blog_title = '" . $titel . "', 
        blog_image = '" . $foto . "', blog_content = '" . $content . "', 
        blog_author = '" . $autheur . "'
        WHERE blog_id = '" . $id . "'";

        $conn->query($query);
        $conn->close();
    }
    //een delete functie die een blog uit de database verwijderd.
    public function delete()
    {
        $conn = Database::Start();

        $id = mysqli_real_escape_string($conn, $this->id);
        $query = "DELETE FROM blogs WHERE blog_id = '" . $id . "'";

        $conn->query($query);
        $conn->close();
    }
}
