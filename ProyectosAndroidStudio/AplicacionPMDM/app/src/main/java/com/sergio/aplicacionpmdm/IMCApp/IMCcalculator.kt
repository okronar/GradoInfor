package com.sergio.aplicacionpmdm.IMCApp

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import androidx.cardview.widget.CardView
import com.sergio.aplicacionpmdm.R

class IMCcalculator : AppCompatActivity() {

    //dos variables mas, como en el layout el male esta puesto con el background selected pondremos a este como predeterminado
    private var isMaleSelected: Boolean = true
    private var isFemaleSelected: Boolean = false

    //iniciamos aqui las variables para que se puedan usar durante todo el codigo y LATEINIT significa que se inicializaran mas adelante.
    private lateinit var viewMale: CardView
    private lateinit var viewFemale: CardView

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_imccalculator)

        initComponents()
        initListeners()
    }

    private fun initComponents() {
        viewMale = findViewById(R.id.viewMale)
        viewFemale = findViewById(R.id.viewFemale)
    }

    private fun initListeners() {
        viewMale.setOnClickListener { setComponentColorMale() }
        viewFemale.setOnClickListener { }
    }

//si no esta selecionado el male lo cambia de color y lo mismo al female
    private fun setComponentColorMale() {
        if (!isMaleSelected) {
            viewMale.setCardBackgroundColor(getColor(R.color.background_component_selected))
            viewFemale.setCardBackgroundColor(getColor(R.color.background_component))
            isMaleSelected = true
            isFemaleSelected = false
        }
    }
//aqui la comprobacion empieza en el female
    private fun setComponentColorFeMale() {
        if (!isFemaleSelected) {
            viewFemale.setCardBackgroundColor(getColor(R.color.background_component_selected))
            viewMale.setCardBackgroundColor(getColor(R.color.background_component))
            isFemaleSelected = true
            isMaleSelected = false

        }
    }


}