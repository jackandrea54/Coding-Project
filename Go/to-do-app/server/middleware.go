package main

import (
	"database/sql"
	"fmt"
	"net/http"
	"to-do-app/core/repository"
	"to-do-app/dbmodel/todoapp/public/model"

	"github.com/gin-gonic/gin"
)

func checkAuthentication(db *sql.DB) gin.HandlerFunc {
	return func(c *gin.Context) {
		var userLogin model.Users

		if err := c.ShouldBindJSON(&userLogin); err != nil {
			c.JSON(http.StatusBadRequest, gin.H{"error": "Invalid JSON login"})
			return
		}

		fmt.Println(userLogin.Username, userLogin.Password)

		user, err := repository.CheckAuthentication(db, userLogin.Username, userLogin.Password)

		if err != nil {
			c.JSON(http.StatusBadRequest, gin.H{"error": "Unable to login, false login credential"})
			return
		}
		c.Writer.Header().Set("userId", string(user.ID))
	}
}

func requireAuthenticatedUser() gin.HandlerFunc {
	return func(c *gin.Context) {
		authorizationHeader := c.GetHeader("userId")
		if authorizationHeader != "" {
			c.Next()
		} else {
			c.AbortWithStatus(401)
		}
	}
}
