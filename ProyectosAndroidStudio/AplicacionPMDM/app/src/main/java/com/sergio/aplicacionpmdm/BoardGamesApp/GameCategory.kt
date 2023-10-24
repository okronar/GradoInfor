package com.sergio.aplicacionpmdm.BoardGamesApp


//vamos a crear una clase que maneje luego las categorias
sealed class GameCategory(var isSelected:Boolean = true) {
    object Deckbuilding : GameCategory()
    object Euro : GameCategory()
    object LCG : GameCategory()
    object Cooperative : GameCategory()
    object Legacy : GameCategory()
}
