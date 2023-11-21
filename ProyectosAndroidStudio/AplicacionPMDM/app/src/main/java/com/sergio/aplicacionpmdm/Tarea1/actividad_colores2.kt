package com.sergio.aplicacionpmdm.Tarea1

import android.app.Dialog
import android.content.res.ColorStateList
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.util.Log
import android.widget.Button
import android.widget.RadioButton
import android.widget.RadioGroup

import androidx.cardview.widget.CardView
import androidx.core.content.ContextCompat
import androidx.recyclerview.widget.LinearLayoutManager
import androidx.recyclerview.widget.RecyclerView

import com.sergio.aplicacionpmdm.R

class actividad_colores2 : AppCompatActivity() {

    private lateinit var rvVertical: RecyclerView
    private lateinit var rvAdapter: VerticalAdapter
    private lateinit var cVcambiar: CardView
    private lateinit var H1: CardView
    private lateinit var H2: CardView
    private lateinit var H3: CardView


    var Barras = mutableListOf(
        VerticalObject("V1(20%)",872415231),
        VerticalObject("V2(35%)", 1507460100),
        VerticalObject("V3(50%)",-2146615571),
        VerticalObject("V4(65%)", -1509949440),
        VerticalObject("V5(80%)",-857209884)
    )


    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_actividad_colores2)
        initComponents()
        initUi()
        initListeners()


    }

    private fun initUi() {
        rvVertical.layoutManager = LinearLayoutManager(this, LinearLayoutManager.HORIZONTAL, false)
        rvVertical.adapter = rvAdapter
    }

    private fun initComponents() {
        rvVertical = findViewById<RecyclerView>(R.id.recicler1)
        rvAdapter = VerticalAdapter(Barras)
        cVcambiar = findViewById(R.id.btnColor)
        H1 = findViewById(R.id.CardviewH1)
        H2 = findViewById(R.id.CardviewH2)
        H3 = findViewById(R.id.CardviewH3)
    }

    private fun initListeners() {
        cVcambiar.setOnClickListener {
            showDialog()
        }
    }

    private fun showDialog() {
        val dialog = Dialog(this)
        dialog.setContentView(R.layout.verticaldialog)
        val btnAddGame: Button = dialog.findViewById(R.id.btnAplicar)

        val rgColor: RadioGroup = dialog.findViewById(R.id.rgColor)
        val rgBarra: RadioGroup = dialog.findViewById(R.id.rgBarra)
        btnAddGame.setOnClickListener {


            val selectedColor = rgColor.checkedRadioButtonId
            val selectedRadioButtonColor: RadioButton = rgColor.findViewById(selectedColor)
            val selectedBarra = rgBarra.checkedRadioButtonId
            val selectedRadioButtonBarra: RadioButton = rgBarra.findViewById(selectedBarra)
            pintarCambios(selectedRadioButtonBarra, selectedRadioButtonColor)



            dialog.hide()
        }



        dialog.show()


    }

    private fun pintarCambios(
        selectedRadioButtonBarra: RadioButton,
        selectedRadioButtonColor: RadioButton
    ) {
        when (selectedRadioButtonBarra.text) {
            "H1(20%)" -> when (selectedRadioButtonColor.text) {
                "Blanco" -> H1.setCardBackgroundColor(
                    ContextCompat.getColor(
                        this,
                        R.color.blanco20
                    )
                )

                "Rojo" -> H1.setCardBackgroundColor(ContextCompat.getColor(this, R.color.rojo20))
                "Naranja" -> H1.setCardBackgroundColor(
                    ContextCompat.getColor(
                        this,
                        R.color.naranja20
                    )
                )

                "Azul" -> H1.setCardBackgroundColor(ContextCompat.getColor(this, R.color.azul20))
                "Rosa" -> H1.setCardBackgroundColor(ContextCompat.getColor(this, R.color.rosa20))
                "Amarillo" -> H1.setCardBackgroundColor(
                    ContextCompat.getColor(
                        this,
                        R.color.amarillo20
                    )
                )

                "Verde" -> H1.setCardBackgroundColor(ContextCompat.getColor(this, R.color.verde20))
                "Marrón" -> H1.setCardBackgroundColor(
                    ContextCompat.getColor(
                        this,
                        R.color.marron20
                    )
                )

                "Negro" -> H1.setCardBackgroundColor(ContextCompat.getColor(this, R.color.negro20))
            }

            "H2(50%)" -> when (selectedRadioButtonColor.text) {
                "Blanco" -> H2.setCardBackgroundColor(
                    ContextCompat.getColor(
                        this,
                        R.color.blanco50
                    )
                )

                "Rojo" -> H2.setCardBackgroundColor(ContextCompat.getColor(this, R.color.rojo50))
                "Naranja" -> H2.setCardBackgroundColor(
                    ContextCompat.getColor(
                        this,
                        R.color.naranja50
                    )
                )

                "Azul" -> H2.setCardBackgroundColor(ContextCompat.getColor(this, R.color.azul50))
                "Rosa" -> H2.setCardBackgroundColor(ContextCompat.getColor(this, R.color.rosa50))
                "Amarillo" -> H2.setCardBackgroundColor(
                    ContextCompat.getColor(
                        this,
                        R.color.amarillo50
                    )
                )

                "Verde" -> H2.setCardBackgroundColor(ContextCompat.getColor(this, R.color.verde50))
                "Marrón" -> H2.setCardBackgroundColor(
                    ContextCompat.getColor(
                        this,
                        R.color.marron50
                    )
                )

                "Negro" -> H2.setCardBackgroundColor(ContextCompat.getColor(this, R.color.negro50))
            }

            "H3(80%)" -> when (selectedRadioButtonColor.text) {
                "Blanco" -> H3.setCardBackgroundColor(
                    ContextCompat.getColor(
                        this,
                        R.color.blanco80
                    )
                )

                "Rojo" -> H3.setCardBackgroundColor(ContextCompat.getColor(this, R.color.rojo80))
                "Naranja" -> H3.setCardBackgroundColor(
                    ContextCompat.getColor(
                        this,
                        R.color.naranja80
                    )
                )

                "Azul" -> H3.setCardBackgroundColor(ContextCompat.getColor(this, R.color.azul80))
                "Rosa" -> H3.setCardBackgroundColor(ContextCompat.getColor(this, R.color.rosa80))
                "Amarillo" -> H3.setCardBackgroundColor(
                    ContextCompat.getColor(
                        this,
                        R.color.amarillo80
                    )
                )

                "Verde" -> H3.setCardBackgroundColor(ContextCompat.getColor(this, R.color.verde80))
                "Marrón" -> H3.setCardBackgroundColor(
                    ContextCompat.getColor(
                        this,
                        R.color.marron80
                    )
                )

                "Negro" -> H3.setCardBackgroundColor(ContextCompat.getColor(this, R.color.negro80))
            }



            "V1(20%)" -> when (selectedRadioButtonColor.text) {
                "Blanco" -> Barras[0].colorFondo = (ContextCompat.getColor(this, R.color.blanco20))
                "Rojo" -> Barras[0].colorFondo = (ContextCompat.getColor(this, R.color.rojo20))
                "Naranja" -> Barras[0].colorFondo =
                    (ContextCompat.getColor(this, R.color.naranja20))

                "Azul" -> Barras[0].colorFondo = (ContextCompat.getColor(this, R.color.azul20))
                "Rosa" -> Barras[0].colorFondo = (ContextCompat.getColor(this, R.color.rosa20))
                "Amarillo" -> Barras[0].colorFondo =
                    (ContextCompat.getColor(this, R.color.amarillo20))

                "Verde" -> Barras[0].colorFondo = (ContextCompat.getColor(this, R.color.verde20))
                "Marrón" -> Barras[0].colorFondo = (ContextCompat.getColor(this, R.color.marron20))
                "Negro" -> Barras[0].colorFondo = (ContextCompat.getColor(this, R.color.negro20))
            }

            "V2(35%)" -> when (selectedRadioButtonColor.text) {
                "Blanco" -> Barras[1].colorFondo = (ContextCompat.getColor(this, R.color.blanco35))
                "Rojo" -> Barras[1].colorFondo = (ContextCompat.getColor(this, R.color.rojo35))
                "Naranja" -> Barras[1].colorFondo =
                    (ContextCompat.getColor(this, R.color.naranja35))

                "Azul" -> Barras[1].colorFondo = (ContextCompat.getColor(this, R.color.azul35))
                "Rosa" -> Barras[1].colorFondo = (ContextCompat.getColor(this, R.color.rosa35))
                "Amarillo" -> Barras[1].colorFondo =
                    (ContextCompat.getColor(this, R.color.amarillo35))

                "Verde" -> Barras[1].colorFondo = (ContextCompat.getColor(this, R.color.verde35))
                "Marrón" -> Barras[1].colorFondo = (ContextCompat.getColor(this, R.color.marron35))
                "Negro" -> Barras[1].colorFondo = (ContextCompat.getColor(this, R.color.negro35))
            }

            "V3(50%)" -> when (selectedRadioButtonColor.text) {
                "Blanco" -> Barras[2].colorFondo = (ContextCompat.getColor(this, R.color.blanco50))
                "Rojo" -> Barras[2].colorFondo = (ContextCompat.getColor(this, R.color.rojo50))
                "Naranja" -> Barras[2].colorFondo =
                    (ContextCompat.getColor(this, R.color.naranja50))

                "Azul" -> Barras[2].colorFondo = (ContextCompat.getColor(this, R.color.azul50))
                "Rosa" -> Barras[2].colorFondo = (ContextCompat.getColor(this, R.color.rosa50))
                "Amarillo" -> Barras[2].colorFondo =
                    (ContextCompat.getColor(this, R.color.amarillo50))

                "Verde" -> Barras[2].colorFondo = (ContextCompat.getColor(this, R.color.verde50))
                "Marrón" -> Barras[2].colorFondo = (ContextCompat.getColor(this, R.color.marron50))
                "Negro" -> Barras[2].colorFondo = (ContextCompat.getColor(this, R.color.negro50))
            }

            "V4(65%)" -> when (selectedRadioButtonColor.text) {
                "Blanco" -> Barras[3].colorFondo = (ContextCompat.getColor(this, R.color.blanco65))
                "Rojo" -> Barras[3].colorFondo = (ContextCompat.getColor(this, R.color.rojo65))
                "Naranja" -> Barras[3].colorFondo =
                    (ContextCompat.getColor(this, R.color.naranja65))

                "Azul" -> Barras[3].colorFondo = (ContextCompat.getColor(this, R.color.azul65))
                "Rosa" -> Barras[3].colorFondo = (ContextCompat.getColor(this, R.color.rosa65))
                "Amarillo" -> Barras[3].colorFondo =
                    (ContextCompat.getColor(this, R.color.amarillo65))

                "Verde" -> Barras[3].colorFondo = (ContextCompat.getColor(this, R.color.verde65))
                "Marrón" -> Barras[3].colorFondo = (ContextCompat.getColor(this, R.color.marron65))
                "Negro" -> Barras[3].colorFondo = (ContextCompat.getColor(this, R.color.negro65))
            }

            "V1(80%)" -> when (selectedRadioButtonColor.text) {
                "Blanco" -> Barras[4].colorFondo = (ContextCompat.getColor(this, R.color.blanco80))
                "Rojo" -> Barras[4].colorFondo = (ContextCompat.getColor(this, R.color.rojo80))
                "Naranja" -> Barras[4].colorFondo =
                    (ContextCompat.getColor(this, R.color.naranja80))

                "Azul" -> Barras[4].colorFondo = (ContextCompat.getColor(this, R.color.azul80))
                "Rosa" -> Barras[4].colorFondo = (ContextCompat.getColor(this, R.color.rosa80))
                "Amarillo" -> Barras[4].colorFondo =
                    (ContextCompat.getColor(this, R.color.amarillo80))

                "Verde" -> Barras[4].colorFondo = (ContextCompat.getColor(this, R.color.verde80))
                "Marrón" -> Barras[4].colorFondo = (ContextCompat.getColor(this, R.color.marron80))
                "Negro" -> Barras[4].colorFondo = (ContextCompat.getColor(this, R.color.negro80))
            }


        }

        rvAdapter.notifyDataSetChanged()
    }


}