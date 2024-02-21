package com.sergio.tarea3sergio.database.dao

import androidx.room.Dao
import androidx.room.Insert
import androidx.room.OnConflictStrategy
import androidx.room.Query
import com.sergio.tarea3sergio.database.entities.DetailsEntity

@Dao
interface DetailsDao {
    @Query("SELECT * FROM Details_table WHERE id LIKE :query")
    suspend fun getAllDetails(query:Int):DetailsEntity

    @Insert(onConflict = OnConflictStrategy.REPLACE)
    suspend fun insertAllDetails(quotes:List<DetailsEntity>)

    @Query("DELETE FROM details_table")
    suspend fun deleteAllDetails()
}