
function Get-MySQLConnection($connectionString){
    #needs mysql-connector : choco install MySql Connector/NET

    [void][system.reflection.Assembly]::LoadWithPartialName("MySql.Data") 
    try{
        $conn = New-Object MySql.Data.MySqlClient.MySqlConnection($connectionString) 
        $conn.Open() 
    }catch{
        Write-Warning "Unable to connect to MySQL server"
        Write-Warning $_.Exception.GetType().FullName
        Write-Warning $_.Exception.Message
        exit
    }
    return $conn
}


function Get-MSSQLConnection($connectionString){
    # needs  Install-Module -Name SqlServer
    try{
        $conn = New-Object System.Data.SqlClient.SqlConnection $connectionString
        $conn.Open() 
    }catch{
        Write-Warning "Unable to connect to MSSQL server"
        Write-Warning $_.Exception.GetType().FullName
        Write-Warning $_.Exception.Message
        exit
    }
    return $conn
}


function Get-QueryReader($query, $conn){
    $cmd = $conn.CreateCommand()
    $cmd.CommandText = $query
    $reader = $cmd.ExecuteReader()  
    $cmd.Dispose()
    return $reader
}

function Get-QueryScalar($query, $conn){
    $cmd = $conn.CreateCommand()
    $cmd.CommandText = $query
    return $cmd.ExecuteScalar()
}

function Execute-NonQuery($query, $conn){
    $cmd = $conn.CreateCommand()
    $cmd.CommandText = $query
    $rowsInserted = $cmd.ExecuteNonQuery()
    return $rowsInserted
}