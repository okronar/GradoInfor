package com.sergio.aplicacionpmdm.Tarea1

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import androidx.recyclerview.widget.LinearLayoutManager
import androidx.recyclerview.widget.RecyclerView
import com.sergio.aplicacionpmdm.R

class actividad_colores2 : AppCompatActivity() {

    private lateinit var rvVertical: RecyclerView
    private lateinit var rvAdapter: VerticalAdapter

    var Barras = mutableListOf(
        VerticalObject("V1(20%)", -871890688),
        VerticalObject("V2(35%)", -1509921024),
        VerticalObject("V3(50%)", -1131230976),
        VerticalObject("V4(65%)", -1509883935),
        VerticalObject("V5(80%)", -858717953)
    )


    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_actividad_colores2)
        initUi()
        initComponents()




    }

    private fun initUi() {
        rvVertical.layoutManager = LinearLayoutManager(this, LinearLayoutManager.HORIZONTAL, false)
        rvVertical.adapter = rvAdapter
    }

    private fun initComponents() {
        rvVertical = findViewById(R.id.recicler1)
        rvAdapter = VerticalAdapter(Barras)
    }
}