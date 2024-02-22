package com.sergio.tarea3sergio

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.util.Log
import androidx.appcompat.widget.SearchView
import androidx.core.view.isVisible
import androidx.recyclerview.widget.LinearLayoutManager
import androidx.room.Room
import com.sergio.tarea3sergio.database.SuperheroDatabase
import com.sergio.tarea3sergio.database.entities.RecyclerEntity
import com.sergio.tarea3sergio.database.entities.toDatabase
import com.sergio.tarea3sergio.databinding.ActivitySuperheroListBinding
import kotlinx.coroutines.CoroutineScope
import kotlinx.coroutines.Dispatchers
import kotlinx.coroutines.launch
import retrofit2.Response
import retrofit2.Retrofit
import retrofit2.converter.gson.GsonConverterFactory

class SuperheroListActivity : AppCompatActivity() {
    private lateinit var room: SuperheroDatabase

    companion object {
        const val EXTRA_ID = "extra_id"
    }

    private lateinit var binding: ActivitySuperheroListBinding
    private lateinit var retrofit: Retrofit
    private lateinit var adapter: SuperheroAdapter

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivitySuperheroListBinding.inflate(layoutInflater)
        setContentView(binding.root)
        room = Room.databaseBuilder(
            this,
            SuperheroDatabase::class.java, "superheroes"
        ).build()

        retrofit = getRetrofit()
        fillDatabase()
        fillDatabaseDetails()
        initUI()
    }

    private fun initUI() {
        binding.searchView.setOnQueryTextListener(object : SearchView.OnQueryTextListener {
            override fun onQueryTextSubmit(query: String?): Boolean {
                searchByName(query.orEmpty())
                return false
            }

            override fun onQueryTextChange(newText: String?) = false
        })
        adapter = SuperheroAdapter { superheroId -> navigateToDetail(superheroId) }
        binding.rvSuperhero.setHasFixedSize(true)
        binding.rvSuperhero.layoutManager = LinearLayoutManager(this)
        binding.rvSuperhero.adapter = adapter
    }

    private fun searchByName(query: String) {

        binding.progressBar.isVisible = true
        CoroutineScope(Dispatchers.IO).launch {
            val peticion : String = "%${query}%"
            val superHeroEntityList :List<RecyclerEntity> = room.getRecyclerDao().getRecyclersByname(peticion)
            runOnUiThread {
                adapter.updateList(superHeroEntityList)
                binding.progressBar.isVisible = false
            }
        }
    }

    private fun getRetrofit(): Retrofit {
        return Retrofit
            .Builder()
            .baseUrl("https://superheroapi.com/api/122099224400128532/")
            .addConverterFactory(GsonConverterFactory.create())
            .build()
    }

    private fun navigateToDetail(id: Int) {
        val intent = Intent(this, DetailSuperheroActivity::class.java)
        intent.putExtra(EXTRA_ID, id)
        startActivity(intent)
    }

    private fun fillDatabase() {
        CoroutineScope(Dispatchers.IO).launch {
            val myResponse: Response<SuperHeroDataResponse> =
                retrofit.create(ApiService::class.java).getSuperheroes()
            if (myResponse.isSuccessful) {
                Log.i("Consulta", "Funciona :)")
                val response: SuperHeroDataResponse? = myResponse.body()
                if (response != null) {
                    val lista = response.superheroes.map {
                        it.toDatabase()
                    }
                    room.getRecyclerDao().deleteAllRecyclers()
                    room.getRecyclerDao().insertAllRecyclers(lista)
                    runOnUiThread {
                        // Do something if necessary
                    }
                }
            } else {
                Log.i("Consulta", "No funciona :(")
            }
        }
    }

    private fun fillDatabaseDetails() {
        CoroutineScope(Dispatchers.IO).launch {
            val myResponse: Response<SuperHeroDetailResponse> =
                getRetrofit().create(ApiService::class.java).getSuperheroDetail()
            val response: SuperHeroDetailResponse? = myResponse.body()
            if (response != null) {
                val lista = response.superheroesDetails.map {
                    it.toDatabase()
                }
                room.getDetailsDao().deleteAllDetails()
                room.getDetailsDao().insertAllDetails(lista)
                runOnUiThread {
                    // Do something if necessary
                }
            }
        }
    }
}
