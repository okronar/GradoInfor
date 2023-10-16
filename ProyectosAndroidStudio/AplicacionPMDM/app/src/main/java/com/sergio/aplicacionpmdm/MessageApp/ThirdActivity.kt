package com.sergio.aplicacionpmdm.MessageApp

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import android.widget.TextView
import com.sergio.aplicacionpmdm.R

class ThirdActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_third)
//aqui recibes el primer mensaje de messageactivity
        var textoTal = findViewById<TextView>(R.id.queTal)
        var mensaje: String = intent.extras?.getString("textoEnviar").orEmpty()
//                con esto tu asignas el string de lo que se ha metido ya en el saco de extras, y si es null, te devuelve vacio.
        textoTal.text = "$mensaje"

//y aqui devuelves un mensaje
        var btnSend = findViewById<Button>(R.id.btnEnviar)
        var textName = findViewById<EditText>(R.id.Escribir)

        btnSend.setOnClickListener {
            var mensaje = textName.text.toString()
            if (mensaje.isNotEmpty()) {
                var textIntent = Intent(this, MessageActivity::class.java)
                textIntent.putExtra("textoRecibir", mensaje)
                startActivity(textIntent)
            }

        }
    }
}