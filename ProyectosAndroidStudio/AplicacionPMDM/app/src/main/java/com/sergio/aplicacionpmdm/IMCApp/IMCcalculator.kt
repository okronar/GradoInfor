package com.sergio.aplicacionpmdm.IMCApp

import android.content.Intent
import android.icu.text.DecimalFormat
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.util.Log
import android.widget.Button
import android.widget.TextView
import androidx.cardview.widget.CardView
import com.google.android.material.slider.RangeSlider
import com.sergio.aplicacionpmdm.R
import java.lang.Math.pow

class IMCcalculator : AppCompatActivity() {

    // mas variables , como en el layout el male esta puesto con el background selected pondremos a este como predeterminado
    private var isMaleSelected: Boolean = true
    private var isFemaleSelected: Boolean = false
    private var currentWeight = 70
    private var currentAge = 30
    private var currentHeight: Int = 120

    //acordarse de importar lo que salga en rojo
    private lateinit var tvHeight: TextView
    private lateinit var rsHeight: RangeSlider
    private lateinit var tvWeight: TextView
    private lateinit var btnSubstractWeight: CardView
    private lateinit var btnAddWeight: CardView
    private lateinit var tvAge: TextView
    private lateinit var btnSubstractAge: CardView
    private lateinit var btnAddAge: CardView
    private lateinit var btnCalculate: Button


    //iniciamos aqui las variables para que se puedan usar durante todo el codigo y LATEINIT significa que se inicializaran mas adelante.
    private lateinit var viewMale: CardView
    private lateinit var viewFemale: CardView

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_imccalculator)

        initComponents()
        initListeners()
        setWeight()
    }

    // R.id. viewMale por ejemplo es como hemos llamado a esa variable en el layout
    private fun initComponents() {
        viewMale = findViewById(R.id.viewMale)
        viewFemale = findViewById(R.id.viewFemale)
        tvHeight = findViewById(R.id.tvHeight)
        rsHeight = findViewById(R.id.rsHeight)
        tvWeight = findViewById(R.id.tvPeso)
        tvAge=findViewById(R.id.tvEdad)
        btnSubstractWeight = findViewById(R.id.iconMinus)
        btnAddWeight = findViewById(R.id.iconPlus)
        btnSubstractAge = findViewById(R.id.iconMinus2)
        btnAddAge = findViewById(R.id.iconPlus2)
        btnCalculate = findViewById(R.id.btnCalcular)

    }

    private fun initListeners() {
        viewMale.setOnClickListener { setComponentColorMale() }
        viewFemale.setOnClickListener { setComponentColorFeMale() }
//        este es el range slider hemos puesto la tercera y solo nos importa el value asi que las demas las rellenamos con _
        rsHeight.addOnChangeListener { _, value, _ ->
            val df = DecimalFormat("#")
            currentHeight = df.format(value).toInt()
            tvHeight.text = "$currentHeight cm"


        }
        btnSubstractWeight.setOnClickListener {
            currentWeight -= 1
            setWeight()
        }
        btnAddWeight.setOnClickListener {
            currentWeight += 1
            setWeight()
        }
        btnSubstractAge.setOnClickListener {
            currentAge -= 1
            setAge()
        }
        btnAddAge.setOnClickListener {
            currentAge += 1
            setAge()
        }
        btnCalculate.setOnClickListener {
            val result = calculateIMC()
             navigateToResult(result)
//            Log.i("IMC","El IMC es $result")
        }

    }

    private fun setWeight() {
        tvWeight.text = currentWeight.toString()
    }
    private fun setAge() {
        tvAge.text = currentAge.toString()
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

    // Log.i("IMC", "El IMC es $result") en el método
    // setOnClickListener para mostrarlo por consola
    private fun calculateIMC():Double {

        val df = DecimalFormat("#.##")
        val imc = currentWeight / pow(currentHeight.toDouble() /100, 2.0)
//df format saca un string por eso lo parseamos a double
        return df.format(imc).toDouble()
    }

    private fun navigateToResult(result : Double) {

        var intent = Intent(this, IMCActivity::class.java)
        intent.putExtra("IMC_extra",result)
        startActivity(intent)
    }



}