package com.ruben.repaso2ev.database.Dao

import androidx.room.Insert
import androidx.room.OnConflictStrategy
import androidx.room.Query
import com.ruben.repaso2ev.Movie
import com.ruben.repaso2ev.database.entities.MovieEntity

interface MovieDao {

    @Query("SELECT * FROM movie_table ORDER BY id DESC")
    suspend fun getAllMovies():List<MovieEntity>

    @Insert(onConflict = OnConflictStrategy.REPLACE)
    suspend fun insertAllMovies(movies:List<MovieEntity>)

    @Query("DELETE FROM movie_table")
    suspend fun deleteAllMovies()
}