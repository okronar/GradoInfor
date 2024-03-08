package com.ruben.examen2dual.database

import androidx.room.Database
import androidx.room.RoomDatabase
import com.ruben.examen2dual.MovieEntity

@Database(entities = [MovieEntity::class], version = 1)
abstract class MovieDatabase: RoomDatabase() {
    abstract fun getMovieDao(): MovieDao
}