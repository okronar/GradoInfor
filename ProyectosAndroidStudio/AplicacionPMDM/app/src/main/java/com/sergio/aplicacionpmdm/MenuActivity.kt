package com.sergio.aplicacionpmdm

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button
import com.sergio.aplicacionpmdm.BoardGamesApp.BoardGames
import com.sergio.aplicacionpmdm.HelloApp.MainActivity
import com.sergio.aplicacionpmdm.IMCApp.IMCcalculator
import com.sergio.aplicacionpmdm.MessageApp.MessageActivity
import com.sergio.aplicacionpmdm.Tarea1.actividad_colores2

class MenuActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_menu)

        var btnHelloApp = findViewById<Button>(R.id.btnHelloApp)
        btnHelloApp.setOnClickListener {
            navigateToHelloApp()
        }
        var btnMessageApp = findViewById<Button>(R.id.btnMessageApp)

        btnMessageApp.setOnClickListener {
            navigateToMessageApp()
        }

        var btnIMCApp = findViewById<Button>(R.id.btnIMCApp)

        btnIMCApp.setOnClickListener {
            navigateToIMCApp()
        }
        var btnBoardGamesApp = findViewById<Button>(R.id.btnBoardGamesApp)

        btnBoardGamesApp.setOnClickListener {
            navigateToBoardGamesApp()
        }
        var btnColorear = findViewById<Button>(R.id.btnColorear)

        btnColorear.setOnClickListener {
            navigateToColorearApp()
        }

    }

    private fun navigateToBoardGamesApp() {
        var intent = Intent(this, BoardGames::class.java)
        startActivity(intent)
    }

    private fun navigateToIMCApp() {
        var intent = Intent(this, IMCcalculator::class.java)
        startActivity(intent)
    }

    //Fuera de la función onCreate()
    private fun navigateToHelloApp() {
        var intent = Intent(this, MainActivity::class.java)
        startActivity(intent)
    }

    private fun navigateToMessageApp() {
        var intent = Intent(this, MessageActivity::class.java)
        startActivity(intent)
    }
    private fun navigateToColorearApp() {
        var intent = Intent(this, actividad_colores2::class.java)
        startActivity(intent)
    }
}