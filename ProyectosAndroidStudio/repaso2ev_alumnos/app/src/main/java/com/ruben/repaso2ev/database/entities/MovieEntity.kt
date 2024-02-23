package com.ruben.repaso2ev.database.entities

import androidx.room.ColumnInfo
import androidx.room.Entity
import androidx.room.PrimaryKey
import com.ruben.repaso2ev.Movie

@Entity(tableName = "Movie_table")
data class MovieEntity(
    @PrimaryKey(autoGenerate = true)
    @ColumnInfo(name = "id") val id: Int = 0,
    @ColumnInfo(name = "title") val title: String,
    @ColumnInfo(name = "releaseDate") val releaseDate: String,
    @ColumnInfo(name = "duration") val duration: String,
    @ColumnInfo(name = "image") val image: String,
    @ColumnInfo(name = "synopsis") val synopsis: String,
    @ColumnInfo(name = "genre") val genre: String,
    @ColumnInfo(name = "director") val director: String,
    @ColumnInfo(name = "leadActor") val leadActor: String,
    @ColumnInfo(name = "writer1") val writer1: String,
    @ColumnInfo(name = "writer2") val writer2: String,
    @ColumnInfo(name = "writer3") val writer3: String,
    @ColumnInfo(name = "writer4") val writer4: String
)


// Hay que especificarle los campos porque también existe el campo "id"
fun Movie.toDatabase() = MovieEntity(title = title, releaseDate =  releaseDate, duration = duration, image = image,synopsis = synopsis, genre = genre,
    director = director, leadActor = leadActor, writer1= writer1, writer2 = writer2, writer3= writer3, writer4 = writer4)