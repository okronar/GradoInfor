package com.sergio.tarea3sergio.database.entities

import androidx.room.ColumnInfo
import androidx.room.Entity
import androidx.room.PrimaryKey
import com.sergio.tarea3sergio.SuperheroItemResponse


@Entity(tableName = "Recycler_table")
data class RecyclerEntity(
    @PrimaryKey(autoGenerate = true)
    @ColumnInfo(name = "id") val id: Int = 0,
    @ColumnInfo(name = "name") val name: String,
    @ColumnInfo(name = "image") val image: String)

// Hay que especificarle los campos porque también existe el campo "id"
fun SuperheroItemResponse.toDatabase() = RecyclerEntity(name = name, image =  superheroImage.url)