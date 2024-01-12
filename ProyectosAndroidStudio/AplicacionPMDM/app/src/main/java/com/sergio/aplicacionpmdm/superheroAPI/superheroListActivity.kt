package com.sergio.aplicacionpmdm.superheroAPI

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.util.Log
import androidx.appcompat.widget.SearchView
import androidx.core.view.isVisible
import androidx.recyclerview.widget.LinearLayoutManager
import com.sergio.aplicacionpmdm.R
import com.sergio.aplicacionpmdm.databinding.ActivitySuperheroListBinding
import kotlinx.coroutines.CoroutineScope
import kotlinx.coroutines.Dispatchers
import kotlinx.coroutines.launch
import retrofit2.Response
import retrofit2.Retrofit
import retrofit2.converter.gson.GsonConverterFactory

class superheroListActivity : AppCompatActivity() {

    //valor constante, companion object significa que sera un valor que comparte entre todas las pestañas

    companion object {
        const val EXTRA_ID = "extra_id"
    }

    private lateinit var binding: ActivitySuperheroListBinding
    //el retrofit conecta con la base de datos y haremos querys
    private lateinit var retrofit: Retrofit
    private lateinit var adapter: SuperheroAdapter

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        //importante poner esto antes del setcontentview
        binding = ActivitySuperheroListBinding.inflate(layoutInflater)
        setContentView(R.layout.activity_superhero_list)
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
        adapter = SuperheroAdapter { superheroId ->  navigateToDetail(superheroId) }
        binding.rvSuperhero.setHasFixedSize(true)
        binding.rvSuperhero.layoutManager = LinearLayoutManager(this)
        binding.rvSuperhero.adapter = adapter

    }

    // Existen varios Dispatchers pero para cualquier acción como peticiones de red
// o BBDD utilizamos IO para que se ejecuten en un hilo secundario.
    private fun searchByName(query: String) {
        binding.progressBar.isVisible = true
        CoroutineScope(Dispatchers.IO).launch {
            //almacenamos la respuesta de la clase
            val myResponse: Response<SuperHeroDataResponse> =
                retrofit.create(ApiService::class.java).getSuperheroes(query)
            if (myResponse.isSuccessful) {
                Log.i("Consulta", "Funciona :)")
                val response: SuperHeroDataResponse? = myResponse.body()
                if (response != null) {
                    Log.i("Cuerpo de la consulta", response.toString())
//                    con esto se ejecuta en el main thread no en la corrutina
                    runOnUiThread {
                        adapter.updateList(response.superheroes)
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
                .baseUrl("https://superheroapi.com/api/122099224400128532/")
                .addConverterFactory(GsonConverterFactory.create())
                .build()
    }
    private fun navigateToDetail(id: String) {
        val intent = Intent(this, DetailSuperheroActivity::class.java)
        intent.putExtra(EXTRA_ID, id)
        startActivity(intent)
    }

}