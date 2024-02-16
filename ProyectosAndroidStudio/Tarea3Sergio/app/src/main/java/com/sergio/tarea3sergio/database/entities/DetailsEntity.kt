package com.sergio.tarea3sergio.database.entities

import androidx.room.ColumnInfo
import androidx.room.Entity
import androidx.room.PrimaryKey
import com.sergio.tarea3sergio.DetailSuperheroActivity
import com.sergio.tarea3sergio.SuperHeroDetailResponse
import com.sergio.tarea3sergio.SuperheroItemResponse

@Entity(tableName = "Details_table")
data class DetailsEntity(
    @PrimaryKey(autoGenerate = true)
    @ColumnInfo(name = "id") val id: Int = 0,
    @ColumnInfo(name = "intelligence") val intelligence: String,
    @ColumnInfo(name = "strength") val strength: String,
    @ColumnInfo(name = "speed") val speed: String,
    @ColumnInfo(name = "durability") val durability: String,
    @ColumnInfo(name = "power") val power: String,
    @ColumnInfo(name = "combat") val combat: String,
    @ColumnInfo(name = "fullName") val fullName: String,
    @ColumnInfo(name = "publisher") val publisher: String
)

// Hay que especificarle los campos porque también existe el campo "id"
fun SuperHeroDetailResponse.toDatabase() = DetailsEntity(intelligence = powerstats.intelligence, strength = powerstats.strength,
    speed = powerstats.speed, durability = powerstats.durability, power = powerstats.power, combat = powerstats.combat, fullName = biography.fullName,
    publisher = biography.publisher)
