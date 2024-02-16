package com.sergio.tarea3sergio.database

import com.sergio.tarea3sergio.database.entities.DetailsEntity
import com.sergio.tarea3sergio.database.entities.RecyclerEntity
import androidx.room.Database
import androidx.room.RoomDatabase
import com.sergio.tarea3sergio.database.dao.DetailsDao
import com.sergio.tarea3sergio.database.dao.RecyclerDao

@Database(entities = [RecyclerEntity::class,DetailsEntity::class], version = 1)
abstract class SuperheroDatabase: RoomDatabase() {

    abstract fun getRecyclerDao(): RecyclerDao
    abstract fun getDetailsDao(): DetailsDao

}
