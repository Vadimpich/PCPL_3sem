package main

import (
	"fmt"
	"github.com/gin-gonic/gin"
	"gorm.io/driver/sqlite"
	"gorm.io/gorm"
	"net/http"
)

type Task struct {
	gorm.Model
	Title       string `json:"title"`
	Description string `json:"description"`
}

var db *gorm.DB

func main() {
	initDB()

	router := gin.Default()

	router.POST("/tasks", createTask)

	router.GET("/tasks", getTasks)

	router.GET("/tasks/:id", getTask)

	router.PUT("/tasks/:id", updateTask)

	router.DELETE("/tasks/:id", deleteTask)

	router.Run(":8000")
}

func initDB() {
	var err error
	db, err = gorm.Open(sqlite.Open("tasks.db"), &gorm.Config{})
	if err != nil {
		panic("Не удалось подключиться к базе данных")
	}
	
	db.AutoMigrate(&Task{})
}

func createTask(c *gin.Context) {
	var task Task
	if err := c.ShouldBindJSON(&task); err != nil {
		c.JSON(http.StatusBadRequest, gin.H{"error": err.Error()})
		return
	}

	db.Create(&task)
	c.JSON(http.StatusOK, task)
}

func getTasks(c *gin.Context) {
	var tasks []Task
	db.Find(&tasks)
	c.JSON(http.StatusOK, tasks)
}

func getTask(c *gin.Context) {
	id := c.Params.ByName("id")
	var task Task
	if err := db.Where("id = ?", id).First(&task).Error; err != nil {
		c.AbortWithStatus(http.StatusNotFound)
		return
	}
	c.JSON(http.StatusOK, task)
}

func updateTask(c *gin.Context) {
	id := c.Params.ByName("id")
	var task Task
	if err := db.Where("id = ?", id).First(&task).Error; err != nil {
		c.AbortWithStatus(http.StatusNotFound)
		return
	}

	var updatedTask Task
	if err := c.ShouldBindJSON(&updatedTask); err != nil {
		c.JSON(http.StatusBadRequest, gin.H{"error": err.Error()})
		return
	}

	db.Model(&task).Updates(updatedTask)
	c.JSON(http.StatusOK, task)
}

func deleteTask(c *gin.Context) {
	id := c.Params.ByName("id")
	var task Task
	if err := db.Where("id = ?", id).First(&task).Error; err != nil {
		c.AbortWithStatus(http.StatusNotFound)
		return
	}

	db.Delete(&task)
	c.JSON(http.StatusOK, gin.H{"message": fmt.Sprintf("Задача с ID %s успешно удалена", id)})
}
