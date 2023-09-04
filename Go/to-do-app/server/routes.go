package main

import (
	"database/sql"

	"to-do-app/core/transport"

	"github.com/gin-gonic/gin"
)

func routes(db *sql.DB) {
	router := gin.Default()

	router.POST("/login", checkAuthentication(db))

	v1 := router.Group("/todoapp", requireAuthenticatedUser())
	v1.GET("/tasks", transport.GetItems(db))          //Get all todos tasks of user with userId
	v1.POST("/tasks", transport.PostItem(db))         //Create a new todo task for user with userId
	v1.PATCH("/tasks/:id", transport.PatchItem(db))   //Update a todo task with itemId
	v1.DELETE("/tasks/:id", transport.DeleteItem(db)) //Delete a todo task with itemId

	router.Run("localhost:8080")
}
