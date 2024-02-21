package com.sergio.tarea3sergio.database.dao


import androidx.room.Dao
import androidx.room.Insert
import androidx.room.OnConflictStrategy
import androidx.room.Query
import com.sergio.tarea3sergio.database.entities.RecyclerEntity

@Dao
interface RecyclerDao {
    @Query("SELECT * FROM Recycler_table WHERE name LIKE :query")
    suspend fun getRecyclersByname(query:String):List<RecyclerEntity>
    @Query("SELECT * FROM Recycler_table WHERE id LIKE :query")
    suspend fun getRecyclersByid(query:Int):RecyclerEntity

    @Insert(onConflict = OnConflictStrategy.REPLACE)
    suspend fun insertAllRecyclers(quotes:List<RecyclerEntity>)

    @Query("DELETE FROM recycler_table")
    suspend fun deleteAllRecyclers()
}