package com.sergio.sintaxiskotlin

import java.lang.Math.PI

//ejercicio 1

fun main() {
    comprobarPar(5)
    areaYlongitud(6)
    diaSemana()
    diaSemanaLaborable()
    numeroRandom()
}

fun comprobarPar(numero: Int) {
    if ((numero % 2) == 0) {
        println("este numero es par")
    } else {
        println("este numero es impar")
    }
}

fun areaYlongitud(radio: Long) {
    var area: Double = PI * (radio + radio)
    var longitud: Double = 2 * PI + radio
    println("area: " + area + "longitud: " + longitud)
}

fun diaSemana() {
    var num: Int
    print("ingrese un numero : ")
    num = readLine()?.toInt() as Int
    when (num) {
        1 -> print(" Lunes")
        2 -> print(" Martes")
        3 -> print(" Miercoles")
        4 -> print(" Jueves")
        5 -> print(" Viernes")
        6 -> print(" Sábado")
        7 -> print(" Domingo")

        else -> print("día no valido")
    }
}

fun diaSemanaLaborable() {
    var num: Int
    print("ingrese un numero : ")
    num = readLine()?.toInt() as Int
    when (num) {
        1, 2, 3, 4, 5 -> print(" Laborable")
        6, 7 -> print(" Fiestuqui")

        else -> print("día no valido")
    }


}

fun ordenarNumeros(n1: Int, n2: Int, n3: Int) {
    if (n1 > n2 && n1 > n3) {
        println(n1)
        if (n2 > n3) {
            println(n2)
            println(n3)
        } else {
            println(n3)
            println(n2)
        }
    } else if (n1 > n2 && n1 < n3) {
        println(n3)
        println(n1)
        println(n2)
    } else if (n1 < n2 && n1 > n3) {
        println(n2)
        println(n1)
        println(n3)
    } else {
        println(n3)
        println(n2)
        println(n1)
    }

}

fun numeroRandom() {
    var num = (0..500).random()
    when (num) {
        in 0..100 -> print("Primer intervalo")
        in 100..200 -> print("Segundo intervalo")
        in 200..300 -> print("Tercer intervalo")
        in 300..400 -> print("Cuarto intervalo")
        in 400..500 -> print("Quinto intervalo")
        else -> "Error"

    }
}








