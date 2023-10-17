package com.sergio.aplicacionpmdm.HelloApp

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.TextView
import com.sergio.aplicacionpmdm.R

class SecondActivity2 : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_second2)


        var textoHola = findViewById<TextView>(R.id.helloText)
        var nombre: String = intent.extras?.getString("extra_name").orEmpty()
//                con esto tu asignas el string de lo que se ha metido ya en el saco de extras, y si es null, te devuelve vacio.
        textoHola.text = "Hola $nombre"

    }
}