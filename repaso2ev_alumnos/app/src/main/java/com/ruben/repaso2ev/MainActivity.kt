package com.ruben.repaso2ev

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.util.Log
import androidx.appcompat.widget.SearchView
import androidx.core.view.isVisible
import androidx.recyclerview.widget.LinearLayoutManager
import androidx.recyclerview.widget.RecyclerView
import androidx.recyclerview.widget.RecyclerView.Adapter
import androidx.recyclerview.widget.RecyclerView.LayoutManager
import androidx.room.Room
import com.ruben.repaso2ev.database.MovieDatabase
import com.ruben.repaso2ev.database.entities.MovieEntity
import com.ruben.repaso2ev.database.entities.toDatabase
import com.ruben.repaso2ev.databinding.ActivityMainBinding
import kotlinx.coroutines.CoroutineScope
import kotlinx.coroutines.Dispatchers
import kotlinx.coroutines.launch
import retrofit2.Response

class MainActivity : AppCompatActivity() {

    private lateinit var binding: ActivityMainBinding
    private lateinit var room: MovieDatabase
    private lateinit var adapter: MoviesAdapter

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityMainBinding.inflate(layoutInflater)
        room = Room.databaseBuilder(this, MovieDatabase::class.java, "peliculas").build()
        setContentView(binding.root)

        insertData()

        initUI()

    }

    private fun initUI() {
        binding.searchView.setOnQueryTextListener(object : SearchView.OnQueryTextListener{
            override fun onQueryTextSubmit(query: String?): Boolean {
                searchByTitle(query.orEmpty())
                return false
            }

            override fun onQueryTextChange(newText: String?) = false
        })
        adapter = MoviesAdapter()
        binding.rvMovies.setHasFixedSize(true)
        binding.rvMovies.layoutManager = LinearLayoutManager(this,LinearLayoutManager.HORIZONTAL,false)
        binding.rvMovies.adapter = adapter
    }

    private fun insertData() {
        CoroutineScope(Dispatchers.IO).launch {
            val movies: List<Movie> = MoviesProvider.getMovies()

            //Inserción de peliculas
            if (movies != null) {
                    room.getMovieDao().deleteAllMovies()

                    val listMovies = movies.map { it.toDatabase() }
                    room.getMovieDao().insertAllMovies(listMovies)
                    Log.i("Consulta", "Funciona :)")

                }  else {
                Log.i("Consulta", "No funciona :(")
            }

        }
    }

    private fun searchByTitle (query: String){
        binding.progressBar.isVisible= true
        var peticion: String = "%".plus(query).plus("%")

        CoroutineScope(Dispatchers.IO).launch {

            val myResponse: List<MovieEntity> =
                room.getMovieDao().getMovies(peticion)
            if (myResponse != null) {
                Log.i("Consulta", "Funciona :)")
                runOnUiThread {
                    adapter.updateList(myResponse)
                    binding.progressBar.isVisible = false
                }
            } else {
                Log.i("Consulta", "No funciona :(")
            }

        }
    }
}