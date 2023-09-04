package repository

import (
	"database/sql"
	"to-do-app/dbmodel/todoapp/public/model"
	"to-do-app/dbmodel/todoapp/public/table"

	"github.com/go-jet/jet/v2/postgres"
)

func CheckAuthentication(db *sql.DB, username string, password string) (model.Users, error) {
	var dest model.Users
	stmt := postgres.SELECT(table.Users.AllColumns).FROM(table.Users).
		WHERE(table.Users.Username.EQ(postgres.String(username)).
			AND(table.Users.Password.EQ(postgres.String(password))))
	err := stmt.Query(db, &dest)
	return dest, err
}
