package com.sergio.aplicacionpmdm.superheroAPI

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import com.sergio.aplicacionpmdm.R
import com.sergio.aplicacionpmdm.databinding.ActivityDetailSuperheroBinding
import com.sergio.aplicacionpmdm.superheroAPI.superheroListActivity.Companion.EXTRA_ID
import com.squareup.picasso.Picasso
import kotlinx.coroutines.CoroutineScope
import kotlinx.coroutines.Dispatchers
import kotlinx.coroutines.launch
import retrofit2.Retrofit
import retrofit2.converter.gson.GsonConverterFactory

class DetailSuperheroActivity : AppCompatActivity() {
    private lateinit var binding: ActivityDetailSuperheroBinding
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityDetailSuperheroBinding.inflate(layoutInflater)
        setContentView(binding.root)
        val id: String = intent.getStringExtra(EXTRA_ID).orEmpty()
        getSuperheroInformation(id)



    }

    private fun getSuperheroInformation(id: String) {
        CoroutineScope(Dispatchers.IO).launch {
            val superheroDetail =
                getRetrofit().create(ApiService::class.java).getSuperheroDetail(id)
            if(superheroDetail.body() != null){
                //con el !! marcas que estas seguro que no es nulo sino dara problemas
                runOnUiThread { createUI(superheroDetail.body()!!) }
            }


        }
    }
    private fun createUI(superhero: SuperHeroDetailResponse) {
        Picasso.get().load(superhero.image.url).into(binding.ivSuperhero)
    }


    private fun getRetrofit(): Retrofit {
        return Retrofit
            .Builder()
            .baseUrl("https://superheroapi.com/api/122099224400128532/")
            .addConverterFactory(GsonConverterFactory.create())
            .build()
    }



}
