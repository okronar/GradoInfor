package com.ruben.repaso2ev

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.util.Log
import androidx.room.Room
import com.ruben.repaso2ev.database.MovieDatabase
import com.ruben.repaso2ev.database.entities.toDatabase
import com.ruben.repaso2ev.databinding.ActivityMainBinding
import kotlinx.coroutines.CoroutineScope
import kotlinx.coroutines.Dispatchers
import kotlinx.coroutines.launch
import retrofit2.Response

class MainActivity : AppCompatActivity() {
    private lateinit var room: MovieDatabase
    private lateinit var binding: ActivityMainBinding

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityMainBinding.inflate(layoutInflater)
        setContentView(binding.root)
        room = Room.databaseBuilder(
            this,
            MovieDatabase::class.java, "movies"
        ).build()
        fillDatabase()
    }

    private fun fillDatabase() {
        var list = MoviesProvider.getMovies()
        CoroutineScope(Dispatchers.IO).launch {
                val lista = list.map {
                    it.toDatabase()
                }
                    room.getMovieDao().deleteAllMovies()
                    room.getMovieDao().insertAllMovies(lista)
        }
    }
}