package com.sergio.examen1

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.TextView
import androidx.core.content.ContextCompat

class MainActivity : AppCompatActivity() {
    private lateinit var Consola: TextView
    private lateinit var instrucciones: TextView
    private lateinit var b1: TextView
    private lateinit var b2: TextView
    private lateinit var b3: TextView
    private lateinit var b4: TextView
    private lateinit var b5: TextView
    private lateinit var b6: TextView
    private lateinit var b7: TextView
    private lateinit var b8: TextView
    private lateinit var b9: TextView
    private lateinit var b0: TextView
    private lateinit var bSuma: TextView
    private lateinit var bResta: TextView
    private lateinit var bMulti: TextView
    private lateinit var bDiv: TextView
    private lateinit var bResto: TextView
    private lateinit var bEqual: TextView
    private lateinit var texto1: String
    private lateinit var simbolo: String
    private lateinit var texto2: String



    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        initComponents()
        initListeners()
    }



    private fun initComponents() {
        b1 = findViewById(R.id.uno)
        b2 = findViewById(R.id.dos)
        b3 = findViewById(R.id.tres)
        b4 = findViewById(R.id.cuatro)
        b5 = findViewById(R.id.cinco)
        b6 = findViewById(R.id.seis)
        b7 = findViewById(R.id.siete)
        b8 = findViewById(R.id.ocho)
        b9 = findViewById(R.id.nueve)
        b0 = findViewById(R.id.cero)
        bSuma = findViewById(R.id.plus)
        bResta = findViewById(R.id.minus)
        bDiv = findViewById(R.id.divide)
        bResto = findViewById(R.id.resto)
        bEqual = findViewById(R.id.equal)
        bMulti = findViewById(R.id.multi)
        Consola = findViewById(R.id.tvConsola)
        instrucciones = findViewById(R.id.tvInstrucciones)

    }
    private fun initListeners() {
        b1.setOnClickListener { fun1() }
        b2.setOnClickListener { fun2() }
        b3.setOnClickListener { fun3() }
        b4.setOnClickListener { fun4() }
        b5.setOnClickListener { fun5() }
        b6.setOnClickListener { fun6() }
        b7.setOnClickListener { fun7() }
        b8.setOnClickListener { fun8() }
        b9.setOnClickListener { fun9() }
        b0.setOnClickListener { fun0() }
        bSuma.setOnClickListener { funSuma() }
        bResta.setOnClickListener { funResta() }
        bDiv.setOnClickListener { funDiv() }
        bResto.setOnClickListener { funResto() }
        bEqual.setOnClickListener { funEquals() }
        bMulti.setOnClickListener { funMulti() }
    }
    private fun darInstrucciones(){
        when (Consola.text) {
            "" -> instrucciones.text= "Introduce un número"



    }}
    var resultado = 0.0
    var resultadoString = ""

    fun funEquals() {
        if (Consola.text == ""){
            instrucciones.text= "Introduce un algo machote "
        }
        if (Consola.text == "1"||Consola.text =="2"||Consola.text =="3"||Consola.text =="4"||Consola.text =="5"||Consola.text =="6"||Consola.text =="7"||Consola.text =="8"||Consola.text =="9"||Consola.text =="0")
        {
            instrucciones.text= "Conque hago yo operaciones"

        }
        if (Consola.text == texto1+simbolo){
            instrucciones.text= "Me falta un numero "
        }else
        {
            when (simbolo){

                "+" -> {
                    resultado = (texto1.toDouble() + texto2.toDouble())
                    resultadoString= texto1+simbolo+texto2+"="+resultado
                    Consola.text = resultadoString
                }

                "-" -> {resultado = (texto1.toDouble()-texto2.toDouble())
                    resultadoString = texto1+simbolo+texto2+"="+resultado
                Consola.text = resultadoString
            }
                "/" -> {resultado = (texto1.toDouble()/texto2.toDouble())
                    resultadoString = texto1+simbolo+texto2+"="+resultado
            Consola.text = resultadoString
        }
                "*"  -> {resultado = (texto1.toDouble()*texto2.toDouble())
                    resultadoString =texto1+simbolo+texto2+"="+resultado
        Consola.text = resultadoString
    }
                "%"  -> {resultado = (texto1.toDouble()%texto2.toDouble())
                    resultadoString = texto1+simbolo+texto2+"="+resultado
    Consola.text = resultadoString
}
             }
        }

    }
     fun funMulti() {
         if (Consola.text == ""){
             instrucciones.text= "Introduce un numero primero"
         }
         if (Consola.text == "1"||Consola.text =="2"||Consola.text =="3"||Consola.text =="4"||Consola.text =="5"||Consola.text =="6"||Consola.text =="7"||Consola.text =="8"||Consola.text =="9"||Consola.text =="0")
         {
             Consola.text = texto1 + "*"
             simbolo = "*"

         }
         else{
             instrucciones.text= "Ya vale de comandos"

         }
    }



     fun funResto() {
         if (Consola.text == ""){
             instrucciones.text= "Introduce un numero primero"
         }
         if (Consola.text == "1"||Consola.text =="2"||Consola.text =="3"||Consola.text =="4"||Consola.text =="5"||Consola.text =="6"||Consola.text =="7"||Consola.text =="8"||Consola.text =="9"||Consola.text =="0")
         {
             Consola.text = texto1 + "%"
             simbolo = "%"

         }
         else{
             instrucciones.text= "Ya vale de comandos"

         }
    }

     fun funDiv() {
         if (Consola.text == ""){
             instrucciones.text= "Introduce un numero primero"
         }
         if (Consola.text == "1"||Consola.text =="2"||Consola.text =="3"||Consola.text =="4"||Consola.text =="5"||Consola.text =="6"||Consola.text =="7"||Consola.text =="8"||Consola.text =="9"||Consola.text =="0")
         {
             Consola.text = texto1 + "/"
             simbolo = "/"

         }
         else{
             instrucciones.text= "Ya vale de comandos"

         }
    }

     fun funResta() {
         if (Consola.text == ""){
             instrucciones.text= "Introduce un numero primero"
         }
         if (Consola.text == "1"||Consola.text =="2"||Consola.text =="3"||Consola.text =="4"||Consola.text =="5"||Consola.text =="6"||Consola.text =="7"||Consola.text =="8"||Consola.text =="9"||Consola.text =="0")
         {
             Consola.text = texto1 + "-"
             simbolo = "-"

         }
         else{
             instrucciones.text= "Ya vale de comandos"

         }
    }

     fun funSuma() {
         if (Consola.text == ""){
             instrucciones.text= "Introduce un numero primero"
         }
         if (Consola.text == "1"||Consola.text =="2"||Consola.text =="3"||Consola.text =="4"||Consola.text =="5"||Consola.text =="6"||Consola.text =="7"||Consola.text =="8"||Consola.text =="9"||Consola.text =="0")
         {
             Consola.text = texto1 + "+"
             simbolo = "+"

         }
         else{
             instrucciones.text= "Ya vale de comandos"

         }
     }

     fun fun0() {
         if (Consola.text== resultadoString){
             Consola.text="0"
             texto1 = "0"
         }
         if (Consola.text == ""){
             Consola.text = "0"
             texto1 = "0"
         }
         if (Consola.text == "1"||Consola.text =="2"||Consola.text =="3"||Consola.text =="4"||Consola.text =="5"||Consola.text =="6"||Consola.text =="7"||Consola.text =="8"||Consola.text =="9"||Consola.text =="0"){
             instrucciones.text= "Introduce un Elige una operacion"
         }
         else {
             Consola.text = texto1 + simbolo + 0
             texto2 = "0"
         }
    }

     fun fun9() {
         if (Consola.text== resultadoString){
             Consola.text="9"
             texto1 = "9"
         }
         if (Consola.text == ""){
             Consola.text = "9"
             texto1 = "9"
         }
         if (Consola.text == "1"||Consola.text =="2"||Consola.text =="3"||Consola.text =="4"||Consola.text =="5"||Consola.text =="6"||Consola.text =="7"||Consola.text =="8"||Consola.text =="9"||Consola.text =="0"){
             instrucciones.text= "Introduce un Elige una operacion"
         }
         else {
             Consola.text = texto1 + simbolo + 9
             texto2 = "9"
         }
    }

     fun fun8() {
         if (Consola.text== resultadoString){
             Consola.text="8"
             texto1 = "8"
         }
         if (Consola.text == ""){
             Consola.text = "1"
             texto1 = "1"
         }
         if (Consola.text == "1"||Consola.text =="2"||Consola.text =="3"||Consola.text =="4"||Consola.text =="5"||Consola.text =="6"||Consola.text =="7"||Consola.text =="8"||Consola.text =="9"||Consola.text =="0"){
             instrucciones.text= "Introduce un Elige una operacion"
         }
         else {
             Consola.text = texto1 + simbolo + 8
             texto2 = "8"
         }
    }

     fun fun7() {
         if (Consola.text== resultadoString){
             Consola.text="7"
             texto1 = "7"
         }
         if (Consola.text == ""){
             Consola.text = "7"
             texto1 = "7"
         }
         if (Consola.text == "1"||Consola.text =="2"||Consola.text =="3"||Consola.text =="4"||Consola.text =="5"||Consola.text =="6"||Consola.text =="7"||Consola.text =="8"||Consola.text =="9"||Consola.text =="0"){
             instrucciones.text= "Introduce un Elige una operacion"
         }
         else {
             Consola.text = texto1 + simbolo + 7
             texto2 = "7"
         }
    }

     fun fun6() {
         if (Consola.text== resultadoString){
             Consola.text="6"
             texto1 = "6"
         }
         if (Consola.text == ""){
             Consola.text = "6"
             texto1 = "6"
         }
         if (Consola.text == "1"||Consola.text =="2"||Consola.text =="3"||Consola.text =="4"||Consola.text =="5"||Consola.text =="6"||Consola.text =="7"||Consola.text =="8"||Consola.text =="9"||Consola.text =="0"){
             instrucciones.text= "Introduce un Elige una operacion"
         }
         else {
             Consola.text = texto1 + simbolo + 6
             texto2 = "6"
         }
    }

     fun fun5() {
         if (Consola.text== resultadoString){
             Consola.text="5"
             texto1 = "5"
         }
         if (Consola.text == ""){
             Consola.text = "5"
             texto1 = "5"
         }
         if (Consola.text == "1"||Consola.text =="2"||Consola.text =="3"||Consola.text =="4"||Consola.text =="5"||Consola.text =="6"||Consola.text =="7"||Consola.text =="8"||Consola.text =="9"||Consola.text =="0"){
             instrucciones.text= "Introduce un Elige una operacion"
         }
         else {
             Consola.text = texto1 + simbolo + 5
             texto2 = "5"
         }
    }

     fun fun4() {
         if (Consola.text== resultadoString){
             Consola.text="4"
             texto1 = "4"
         }
         if (Consola.text == ""){
             Consola.text = "4"
             texto1 = "4"
         }
         if (Consola.text == "1"||Consola.text =="2"||Consola.text =="3"||Consola.text =="4"||Consola.text =="5"||Consola.text =="6"||Consola.text =="7"||Consola.text =="8"||Consola.text =="9"||Consola.text =="0"){
             instrucciones.text= "Introduce un Elige una operacion"
         }
         else {
             Consola.text = texto1 + simbolo + 4
             texto2 = "4"
         }
    }

     fun fun3() {
         if (Consola.text== resultadoString){
             Consola.text="3"
             texto1 = "3"
         }
         if (Consola.text == ""){
             Consola.text = "3"
             texto1 = "3"
         }
         if (Consola.text == "1"||Consola.text =="2"||Consola.text =="3"||Consola.text =="4"||Consola.text =="5"||Consola.text =="6"||Consola.text =="7"||Consola.text =="8"||Consola.text =="9"||Consola.text =="0"){
             instrucciones.text= "Introduce un Elige una operacion"
         }
         else {
             Consola.text = texto1 + simbolo + 3
             texto2 = "3"
         }
    }

     fun fun2() {
         if (Consola.text== resultadoString){
             Consola.text="2"
             texto1 = "2"
         }
         if (Consola.text == ""){
             Consola.text = "2"
             texto1 = "2"
         }
         if (Consola.text == "1"||Consola.text =="2"||Consola.text =="3"||Consola.text =="4"||Consola.text =="5"||Consola.text =="6"||Consola.text =="7"||Consola.text =="8"||Consola.text =="9"||Consola.text =="0"){
             instrucciones.text= "Introduce un Elige una operacion"
         }
         else {
             Consola.text = texto1 + simbolo + 2
             texto2 = "2"

         }
    }

     fun fun1() {
         if (Consola.text== resultadoString){
             Consola.text="1"
             texto1 = "1"
         }
         if (Consola.text == ""){
        Consola.text = "1"
        texto1 = "1"
         }
         if (Consola.text == "1"||Consola.text =="2"||Consola.text =="3"||Consola.text =="4"||Consola.text =="5"||Consola.text =="6"||Consola.text =="7"||Consola.text =="8"||Consola.text =="9"||Consola.text =="0"){
             instrucciones.text= "Introduce un Elige una operacion"
         }
         else {
             Consola.text = texto1 + simbolo + 1
             texto2 = "1"
         }
    }


}