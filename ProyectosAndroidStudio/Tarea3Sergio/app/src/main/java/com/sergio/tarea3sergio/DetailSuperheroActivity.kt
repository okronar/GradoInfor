package com.sergio.tarea3sergio

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.util.TypedValue
import android.view.View
import androidx.room.Room
import com.sergio.tarea3sergio.SuperheroListActivity.Companion.EXTRA_ID
import com.sergio.tarea3sergio.database.SuperheroDatabase
import com.sergio.tarea3sergio.database.entities.DetailsEntity
import com.sergio.tarea3sergio.database.entities.RecyclerEntity

import com.sergio.tarea3sergio.databinding.ActivityDetailSuperheroBinding

import com.squareup.picasso.Picasso
import kotlinx.coroutines.CoroutineScope
import kotlinx.coroutines.Dispatchers
import kotlinx.coroutines.launch
import retrofit2.Retrofit
import retrofit2.converter.gson.GsonConverterFactory
import kotlin.math.roundToInt

class DetailSuperheroActivity : AppCompatActivity() {
    private lateinit var binding: ActivityDetailSuperheroBinding
    private lateinit var room : SuperheroDatabase
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityDetailSuperheroBinding.inflate(layoutInflater)
        room = Room.databaseBuilder(this,
            SuperheroDatabase::class.java, "superheroes").build()

        setContentView(binding.root)
        val id: Int = intent.getStringExtra(EXTRA_ID).orEmpty().toInt()
        getSuperheroInformation(id)




    }

    private fun getSuperheroInformation(id: Int) {
        CoroutineScope(Dispatchers.IO).launch {
            val superheroDetail =
                room.getDetailsDao().getAllDetails(id)
            val superheroRecycler = room.getRecyclerDao().getRecyclersByid(id)

            if(superheroDetail != null){
                //con el !! marcas que estas seguro que no es nulo sino dara problemas
                runOnUiThread { createUI(superheroDetail,superheroRecycler) }
            }


        }
    }
    private fun createUI(details: DetailsEntity, superheroRecycler: RecyclerEntity) {
        Picasso.get().load(superheroRecycler.image).into(binding.ivSuperhero)
        binding.tvSuperheroName.text = superheroRecycler.name
        binding.tvSuperheroRealName.text = details.fullName
        binding.tvPublisher.text = details.publisher
        prepareStats(details)
    }
    private fun prepareStats(powerstats: DetailsEntity) {
        updateHeight(binding.viewIntelligence, powerstats.intelligence)
        updateHeight(binding.viewStrength, powerstats.strength)
        updateHeight(binding.viewSpeed, powerstats.speed)
        updateHeight(binding.viewDurability, powerstats.durability)
        updateHeight(binding.viewPower, powerstats.power)
        updateHeight(binding.viewCombat, powerstats.combat)
    }
    private fun updateHeight(view: View, stat:String){
        val params = view.layoutParams
        if (stat != "null") {
            params.height = pxToDp(stat.toFloat())
        }else {
            params.height = pxToDp(0.toFloat())
        }

        view.layoutParams = params
    }

    private fun pxToDp(px:Float):Int{
        return TypedValue.applyDimension(TypedValue.COMPLEX_UNIT_DIP, px, resources.displayMetrics).roundToInt()
    }


    private fun getRetrofit(): Retrofit {
        return Retrofit
            .Builder()
            .baseUrl("https://superheroapi.com/api/122099224400128532/")
            .addConverterFactory(GsonConverterFactory.create())
            .build()
    }






}
