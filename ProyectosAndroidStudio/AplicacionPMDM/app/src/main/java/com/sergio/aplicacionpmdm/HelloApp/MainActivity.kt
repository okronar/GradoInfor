package com.sergio.aplicacionpmdm.HelloApp

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import com.sergio.aplicacionpmdm.R

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        var btnSend = findViewById<Button>(R.id.btnSend)
        var textName = findViewById<EditText>(R.id.etName)


        btnSend.setOnClickListener {
            var name = textName.text.toString()
            if (name.isNotEmpty()) {
                var textIntent = Intent(this, SecondActivity2::class.java)
                textIntent.putExtra("extra_name",name)
                startActivity(textIntent)
            }

        }//si el name no esta vacio, se crea una variable intent con padre "this" y que hace referencia a otra actividad


    }
}