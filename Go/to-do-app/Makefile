createdb:
	docker exec -it g2fina-postgres-1 createdb --username=encapital --owner=encapital todoapp

dropdb:
	docker exec -it g2fina-postgres-1 dropdb --username=encapital --owner=encapital todoapp

.PHONY: createdb	

# For data migration run:  
# Use this command: migrate -path migration -database "postgresql://encapital:Encap@1234@localhost:5433/todoapp?sslmode=disable" -verbose up 