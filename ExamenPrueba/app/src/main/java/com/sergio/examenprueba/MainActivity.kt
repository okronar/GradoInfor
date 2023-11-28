package com.sergio.examenprueba

import android.app.Dialog
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button
import android.widget.RadioButton
import android.widget.RadioGroup
import android.widget.TextView
import androidx.cardview.widget.CardView
import androidx.core.content.ContextCompat

class MainActivity : AppCompatActivity() {
    private lateinit var primbtn: TextView
    private lateinit var segunbtn: TextView
    private lateinit var tercbtn: TextView
    private lateinit var cuartnbtn: TextView
    private lateinit var quintbtn: TextView
    private lateinit var sextbtn: TextView
    private lateinit var septbtn: TextView
    private lateinit var octvbtn: TextView
    private lateinit var novenbtn: TextView
    private lateinit var decimbtn: TextView



    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        initComponents()
        initListeners()


    }

    private fun initListeners() {
        primbtn.setOnClickListener{
            showDialog(primbtn)
        }
        segunbtn.setOnClickListener{
            showDialog(segunbtn)
        }
        tercbtn.setOnClickListener{
            showDialog(tercbtn)
        }
        cuartnbtn.setOnClickListener{
            showDialog(cuartnbtn)
        }
        quintbtn.setOnClickListener{
            showDialog(quintbtn)
        }
        sextbtn.setOnClickListener{
            showDialog(sextbtn)
        }
        septbtn.setOnClickListener{
            showDialog(septbtn)
        }
        octvbtn.setOnClickListener{
            showDialog(octvbtn)
        }
        novenbtn.setOnClickListener{
            showDialog(novenbtn)
        }
        decimbtn.setOnClickListener{
            showDialog(decimbtn)
        }

    }

    private fun showDialog(view: TextView) {
        val dialog = Dialog(this)
        dialog.setContentView(R.layout.dialog)
        val btnAplicar: Button = dialog.findViewById(R.id.btnApply)
        val rgColores: RadioGroup = dialog.findViewById(R.id.rgCategories)
        btnAplicar.setOnClickListener{
            val selectedColor = rgColores.checkedRadioButtonId
            val selectedRadioButtonColor: RadioButton = rgColores.findViewById(selectedColor)
            when (selectedRadioButtonColor.text) {
                "@string/blanco" -> view.setBackgroundColor(ContextCompat.getColor(this, R.color.white))
                "@string/red"-> view.setBackgroundColor(ContextCompat.getColor(this, R.color.rojo))
                "@string/orange"-> view.setBackgroundColor(ContextCompat.getColor(this, R.color.naranja))
                "@string/yellow"-> view.setBackgroundColor(ContextCompat.getColor(this, R.color.amarillo))
                "@string/green"-> view.setBackgroundColor(ContextCompat.getColor(this, R.color.verde))
                "@color/cian"-> view.setBackgroundColor(ContextCompat.getColor(this, R.color.cian))
                "@string/blue"-> view.setBackgroundColor(ContextCompat.getColor(this, R.color.azul))
                "@string/violet"-> view.setBackgroundColor(ContextCompat.getColor(this, R.color.violeta))
                "@string/grey"-> view.setBackgroundColor(ContextCompat.getColor(this, R.color.gris))
                "@string/black"-> view.setBackgroundColor(ContextCompat.getColor(this, R.color.black))

            }
            dialog.hide()
        }
        dialog.show()

    }

    private fun initComponents() {
        primbtn = findViewById(R.id.tvBlanco)
        segunbtn = findViewById(R.id.tvRojo)
        tercbtn = findViewById(R.id.tvnaranja)
        cuartnbtn = findViewById(R.id.tvAmarillo)
        quintbtn = findViewById(R.id.tvVerde)
        sextbtn = findViewById(R.id.tvCian)
        septbtn = findViewById(R.id.tvAzul)
        octvbtn = findViewById(R.id.tvVioleta)
        novenbtn = findViewById(R.id.tvGris)
        decimbtn = findViewById(R.id.tvNegro)



    }
}