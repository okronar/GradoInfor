package com.ruben.examen2dual.database

import androidx.room.Dao
import androidx.room.Insert
import androidx.room.OnConflictStrategy
import androidx.room.Query
import com.ruben.examen2dual.MovieEntity

@Dao
interface MovieDao {
    @Query("SELECT * FROM MovieTable")
    suspend fun getAllMovies(): List<MovieEntity>

    @Query("SELECT * FROM MovieTable WHERE genre LIKE :query")
    suspend fun getMoviesGenre(query: String): List<MovieEntity>

    @Insert(onConflict = OnConflictStrategy.REPLACE)
    suspend fun insertAllMovies(superheroes: List<MovieEntity>)

    @Query("DELETE FROM MovieTable")
    suspend fun deleteAllMovies()

}