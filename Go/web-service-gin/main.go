package main

import (
	"database/sql"
	"encoding/json"
	"fmt"
	"net/http"
   	"strconv"


	"github.com/gin-gonic/gin"
	"github.com/go-jet/jet/v2/postgres"
	_ "github.com/lib/pq"

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

// album represents data about a record album.
// type album struct {
// 	ID     string  `json:"id"`
// 	Title  string  `json:"title"`
// 	Artist string  `json:"artist"`
// 	Price  float64 `json:"price"`
// }

// albums slice to seed record album data.
// var albums = []album{
// 	{ID: "1", Title: "Blue Train", Artist: "John Coltrane", Price: 56.99},
// 	{ID: "2", Title: "Jeru", Artist: "Gerry Mulligan", Price: 17.99},
// 	{ID: "3", Title: "Sarah Vaughan and Clifford Brown", Artist: "Sarah Vaughan", Price: 39.99},
// }

func main() {
	// Connect to database
	var connectString = fmt.Sprintf("host=%s port=%d user=%s password=%s dbname=%s sslmode=disable", host, port, user, password, dbName)

	db, err := sql.Open("postgres", connectString)
	panicOnError(err)
	defer db.Close()

	router := gin.Default()
	router.GET("/albums", getAlbums(db))
	router.GET("/albums/:id", getAlbumByID(db)) //The colon before the id signifies that the item is a path parameter.
	//The value of the parameter is stored in c.Param("id").
	router.POST("/albums", postAlbums(db))

	router.Run("localhost:8080")
}

// getAlbums responds with the list of all albums as JSON.
func getAlbums(db *sql.DB) gin.HandlerFunc {
	//Build the query to select all albums
	stmt := postgres.SELECT(table.Album.AllColumns).FROM(table.Album).ORDER_BY(table.Album.ID)

	var dest []model.Album

	//Execute the query and store the result in a new album slice
	var err error = stmt.Query(db, &dest)
	panicOnError(err)

	//Return a handler function which knows how to write the albums slice to the response body
	return func(c *gin.Context) {
		jsonText, _ := json.MarshalIndent(dest, "", "\t")
		fmt.Println(string(jsonText))
		c.JSON(http.StatusOK, dest)
	}
}

// postAlbums adds an album from JSON received in the request body.
func postAlbums(db *sql.DB) gin.HandlerFunc {
	var newAlbum model.Album

	return func(c *gin.Context) {

		// Call BindJSON to bind the received JSON to newAlbum.
		if err := c.BindJSON(&newAlbum); err != nil {
			c.JSON(http.StatusBadRequest, gin.H{"error": "Invalid JSON"})
			return
		}

		// Add the new album to the slice.
		// albums = append(albums, newAlbum)
		insertSm := table.Album.INSERT(table.Album.MutableColumns).MODEL(newAlbum)

		result, err := insertSm.Exec(db)
		panicOnError(err)
		fmt.Println(result)

		// Return a pointer to the response object.
		c.JSON(http.StatusCreated, newAlbum)
	}
}

// getAlbumByID locates the album whose ID value matches the id
// parameter sent by the client, then returns that album as a response.
func getAlbumByID(db *sql.DB) gin.HandlerFunc {
	return func(c *gin.Context) {
		id, err := strconv.ParseInt((c.Param("id")),10,64) //The Param method returns a string, so it needs to be converted to an integer.
		if err != nil {
			c.JSON(http.StatusBadRequest, gin.H{"error": "Invalid ID"})
			return
		}

		// Build the query to select the album whose ID value matches the parameter.
		stmt := postgres.SELECT(table.Album.AllColumns).FROM(table.Album).WHERE(table.Album.ID.EQ(postgres.Int(id)))

		// Loop over the list of albums, looking for
		// an album whose ID value matches the parameter.
		// for _, a := range albums {
		// 	if a.ID == id {
		// 		c.JSON(http.StatusOK, a)
		// 		return
		// 	}
		// }

		var dest model.Album
		//Execute the query and store the result in a new album variable
		err = stmt.Query(db, &dest)
		panicOnError(err)

		jsonText, _ := json.MarshalIndent(dest, "", "\t")
		fmt.Println(string(jsonText))
		c.JSON(http.StatusOK, dest)
			
	}
}

func panicOnError(err error) {
	if err != nil {
		panic(err)
	}
}
