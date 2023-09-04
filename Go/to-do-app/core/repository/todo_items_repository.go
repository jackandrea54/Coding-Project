package repository

import (
	"database/sql"
	"time"
	"to-do-app/dbmodel/todoapp/public/model"
	"to-do-app/dbmodel/todoapp/public/table"

	"github.com/go-jet/jet/v2/postgres"
)

func GetAllItemsDB(db *sql.DB, userID int64) ([]model.TodoItems, error) {
	var dest []model.TodoItems
	stmt := postgres.SELECT(table.TodoItems.AllColumns).FROM(table.TodoItems).WHERE(table.TodoItems.UserID.EQ(postgres.Int(userID)))
	err := stmt.Query(db, &dest)
	return dest, err
}

func GetItemsByUserIdDB(db *sql.DB, ID int64) ([]model.TodoItems, error) {
	var dest []model.TodoItems
	stmt := postgres.SELECT(table.TodoItems.AllColumns).
		FROM(table.TodoItems).
		WHERE(table.TodoItems.UserID.EQ(postgres.Int(ID)))
	err := stmt.Query(db, &dest)
	return dest, err
}

func CreateItemDB(db *sql.DB, item model.TodoItemsInsert) (sql.Result, error) {
	stmt := table.TodoItems.
		INSERT(table.TodoItems.Title, table.TodoItems.UserID).
		MODEL(item)

	return stmt.Exec(db)
}

func UpdateItemDB(db *sql.DB, item model.TodoItemsUpdate) (sql.Result, error) {
	itemId := int64(item.ID)
	itemUserId := int64(item.UserID)
	item.UpdatedAt = time.Now()
	stmt := table.TodoItems.
		UPDATE(table.TodoItems.Title, table.TodoItems.Status, table.TodoItems.UpdatedAt).MODEL(item).WHERE(
		table.TodoItems.ID.EQ(postgres.Int(itemId)).
			AND(table.TodoItems.UserID.EQ(postgres.Int(itemUserId))),
	)

	return stmt.Exec(db)
}

func DeleteItem(db *sql.DB, itemId int64, userId int64) (sql.Result, error) {
	stmt := table.TodoItems.DELETE().
		WHERE(table.TodoItems.ID.EQ(postgres.Int(itemId)).AND(table.TodoItems.UserID.EQ(postgres.Int(userId))))

	return stmt.Exec(db)
}
