# Use the official Go base image
FROM golang:1.17 AS build

# Set the working directory inside the container
WORKDIR /app

# Copy the Go source code into the container
COPY main.go .

# Build the Go application
RUN go build -o app

# Use a minimal image to run the application
FROM alpine:latest

# Copy the built binary from the build stage
COPY --from=build /app/app /app/app

# Expose the port that the application will listen on
EXPOSE 8080

# Command to run the application
CMD ["/app/app"]
