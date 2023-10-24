package com.sergio.aplicacionpmdm.BoardGamesApp

data class Game (val name:String, val category: GameCategory, var isSelected:Boolean = false)
