<head>

</head>

<body>
    <table>
        <tr>
            <td><strong>Welkom, dit zijn je gegevens:</strong></td><br />
            <td><strong>Gebruikersnaam:</strong></td>
            <td><strong>wachtwoord:</strong></td>
        </tr>
        <?php
        require "Inlog.php";
        
        $username = $_POST["gebruikersnaam"];
        $password = $_POST["wachtwoord"];
        $users = Inlog::gebruikersInlog($username, $password);
        foreach($users as $user)
        {
        echo "<tr>";
        echo "<td>" . $user->id . "</td>";
        echo "<td>" . $user->username . "</td>";
        echo "<td>" . $user->password . "</td>";
        echo "</tr>";
        }
        ?>
    </table>
</body>