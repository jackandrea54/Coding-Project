package main

import (
	"database/sql"
	"encoding/json"
	"fmt"

	"github.com/go-jet/jet/v2/postgres"
	_ "github.com/lib/pq"

	// dot import so go code would resemble as much as native SQL
	// dot import is not mandatory

	"web-service-gin/dbmodel/recordings/public/model"
	"web-service-gin/dbmodel/recordings/public/table"
)

const (
	host     = "localhost"
	port     = 5432
	user     = "postgres"
	password = "123456"
	dbName   = "recordings"
)

func main() {
	// Connect to database
	var connectString = fmt.Sprintf("host=%s port=%d user=%s password=%s dbname=%s sslmode=disable", host, port, user, password, dbName)

	db, err := sql.Open("postgres", connectString)
	panicOnError(err)
	defer db.Close()

	// GetAlbums returns all albums

	stmt := postgres.SELECT(table.Album.AllColumns).FROM(table.Album).ORDER_BY(table.Album.ID)
	// GetAlbumsByArtist returns all albums for given artist
	var dest []model.Album

	err = stmt.Query(db, &dest)
	panicOnError(err)

	printStatementInfo(stmt)

	jsonText, _ := json.MarshalIndent(dest, "", "\t")
	fmt.Println(string(jsonText))
}

func printStatementInfo(stmt postgres.SelectStatement) {
	query, args := stmt.Sql()

	fmt.Println("Parameterized query: ")
	fmt.Println("==============================")
	fmt.Println(query)
	fmt.Println("Arguments: ")
	fmt.Println(args)

	debugSQL := stmt.DebugSql()

	fmt.Println("\n\nDebug sql: ")
	fmt.Println("==============================")
	fmt.Println(debugSQL)
	fmt.Println("==============================")
}

func panicOnError(err error) {
	if err != nil {
		panic(err)
	}
}
