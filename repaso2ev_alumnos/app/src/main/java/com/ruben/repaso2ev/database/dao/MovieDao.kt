package com.ruben.repaso2ev.database.dao

import androidx.room.Dao
import androidx.room.Insert
import androidx.room.OnConflictStrategy
import androidx.room.Query
import com.ruben.repaso2ev.Movie
import com.ruben.repaso2ev.database.entities.MovieEntity

@Dao
interface MovieDao {
    @Query("SELECT * FROM MovieTable WHERE title LIKE :query")
    suspend fun getMovies(query: String): List<MovieEntity>

    @Insert(onConflict = OnConflictStrategy.REPLACE)
    suspend fun insertAllMovies(superheroes: List<MovieEntity>)

    @Query("DELETE FROM MovieTable")
    suspend fun deleteAllMovies()

}