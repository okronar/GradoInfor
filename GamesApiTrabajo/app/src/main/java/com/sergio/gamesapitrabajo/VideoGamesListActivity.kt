package com.sergio.gamesapitrabajo

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.util.Log
import androidx.appcompat.widget.SearchView
import androidx.core.view.isVisible
import androidx.recyclerview.widget.LinearLayoutManager
import com.sergio.gamesapitrabajo.databinding.ActivityVideogamesListBinding
import kotlinx.coroutines.CoroutineScope
import kotlinx.coroutines.Dispatchers
import kotlinx.coroutines.launch
import retrofit2.Response
import retrofit2.Retrofit
import retrofit2.converter.gson.GsonConverterFactory

class VideoGamesListActivity : AppCompatActivity() {
    private lateinit var binding: ActivityVideogamesListBinding
    private lateinit var retrofit: Retrofit

    private lateinit var adapter: VideoGamesAdapter
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_videogames_list)
        binding = ActivityVideogamesListBinding.inflate(layoutInflater)
        setContentView(binding.root)

        retrofit = getRetrofit()
        initUI()
    }
    private fun initUI() {
        binding.searchView.setOnQueryTextListener(object: SearchView.OnQueryTextListener
        {
            override fun onQueryTextSubmit(query: String?): Boolean {
                searchByName(query.orEmpty())
                return false
            }
            override fun onQueryTextChange(newText: String?) = false
        })
        adapter = VideoGamesAdapter ()
        binding.rvVideoGames.setHasFixedSize(true)
        binding.rvVideoGames.layoutManager = LinearLayoutManager(this, LinearLayoutManager.HORIZONTAL, false)
        binding.rvVideoGames.adapter = adapter


    }

    private fun searchByName(query: String) {
        binding.progressBar.isVisible = true
        CoroutineScope(Dispatchers.IO).launch {
            val myResponse: Response<VideoGamesDataResponse> =
                retrofit.create(ApiService::class.java).getVideoGames(query)

            val response: VideoGamesDataResponse? = myResponse.body()

            if (myResponse.isSuccessful) {
                Log.i("Consulta", "Funciona :)")
                if (response != null) {
                    Log.i("Cuerpo de la consulta", response.toString())
                    runOnUiThread {
                        adapter.updateList(response.videoGames)
                        binding.progressBar.isVisible = false
                    }

                }

            } else {
                Log.i("Consulta", "No funciona :(")
            }
        }
    }
        private fun getRetrofit(): Retrofit {
        return Retrofit
            .Builder()
            .baseUrl("https://api.rawg.io/api/")
            .addConverterFactory(GsonConverterFactory.create())
            .build()
    }




}