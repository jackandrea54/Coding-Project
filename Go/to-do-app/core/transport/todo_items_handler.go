package transport

import (
	"database/sql"
	"encoding/json"
	"fmt"
	"net/http"
	"strconv"
	"to-do-app/core/repository"
	"to-do-app/dbmodel/todoapp/public/model"

	"github.com/gin-gonic/gin"
)

func GetItems(db *sql.DB) gin.HandlerFunc {
	//Return a handler function which can get all todo items of user with id
	return func(c *gin.Context) {
		userId, err := strconv.ParseInt(c.GetHeader("userId"), 10, 64)

		if err != nil {
			c.JSON(http.StatusBadRequest, gin.H{"error": "Invalid userID"})
			return
		}

		result, err := repository.GetAllItemsDB(db, userId)

		if err != nil {
			c.JSON(http.StatusBadRequest, gin.H{"error": "Unable to get items"})
			return
		}

		jsonText, _ := json.MarshalIndent(result, "", "\t")
		fmt.Println(string(jsonText))
		c.JSON(http.StatusOK, result)
	}
}

func PostItem(db *sql.DB) gin.HandlerFunc {
	return func(c *gin.Context) {
		userId, err := strconv.ParseInt(c.GetHeader("userId"), 10, 64)

		if err != nil {
			c.JSON(http.StatusBadRequest, gin.H{"error": "Invalid userID"})
			return
		}

		var newItem model.TodoItemsInsert

		// Call BindJSON to bind the received JSON to newItem.
		if err := c.ShouldBindJSON(&newItem); err != nil || newItem.Title == "" {
			c.JSON(http.StatusBadRequest, gin.H{"error": "Invalid JSON"})
			return
		}

		newItem.UserID = int32(userId)

		_, err = repository.CreateItemDB(db, newItem)
		if err != nil {
			fmt.Println(err)
			c.JSON(http.StatusBadRequest, gin.H{"error": "Unable to create item"})
			return
		}

		c.JSON(http.StatusOK, gin.H{"status": "ok", "result": "insert successfully"})

	}
}

func PatchItem(db *sql.DB) gin.HandlerFunc {
	return func(c *gin.Context) {
		userId, err := strconv.ParseInt(c.GetHeader("userId"), 10, 64)

		if err != nil {
			c.JSON(http.StatusBadRequest, gin.H{"error": "Invalid userID"})
			return
		}

		itemId, err := strconv.ParseInt((c.Param("id")), 10, 64) //The Param method returns a string, so it needs to be converted to an integer.
		if err != nil {
			c.JSON(http.StatusBadRequest, gin.H{"error": "Invalid itemId"})
			return
		}

		var updateItem model.TodoItemsUpdate

		// Call BindJSON to bind the received JSON to updateItem.
		if err := c.ShouldBindJSON(&updateItem); err != nil {
			c.JSON(http.StatusBadRequest, gin.H{"error": "Invalid JSON"})
			return
		}

		updateItem.ID = int32(itemId)
		updateItem.UserID = int32(userId)

		_, err = repository.UpdateItemDB(db, updateItem)

		if err != nil {
			fmt.Println(err)
			c.JSON(http.StatusBadRequest, gin.H{"error": "Unable to create item"})
			return
		}

		c.JSON(http.StatusOK, gin.H{"status": "ok", "result": "update successfully"})
	}
}

func DeleteItem(db *sql.DB) gin.HandlerFunc {
	return func(c *gin.Context) {
		userId, err := strconv.ParseInt(c.GetHeader("userId"), 10, 64)

		if err != nil {
			c.JSON(http.StatusBadRequest, gin.H{"error": "Invalid userID"})
			return
		}

		itemId, err := strconv.ParseInt((c.Param("id")), 10, 64) //The Param method returns a string, so it needs to be converted to an integer.
		if err != nil {
			c.JSON(http.StatusBadRequest, gin.H{"error": "Invalid itemId"})
			return
		}

		_, err = repository.DeleteItem(db, itemId, userId)

		if err != nil {
			fmt.Println(err)
			c.JSON(http.StatusBadRequest, gin.H{"error": "Unable to delete item"})
			return
		}

		c.JSON(http.StatusOK, gin.H{"status": "ok", "result": "delete successfully"})
	}
}
