package com.sergio.aplicacionpmdm.BoardGamesApp

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import androidx.recyclerview.widget.LinearLayoutManager
import androidx.recyclerview.widget.RecyclerView
import com.sergio.aplicacionpmdm.BoardGamesApp.GameCategory.*
import com.sergio.aplicacionpmdm.R

class BoardGames : AppCompatActivity() {

//    importando la clase saldra así, mas escueto

    private val categories = listOf(
        Cooperative,
        Deckbuilding,
        Euro,
        LCG,
        Legacy
    )
    var games = mutableListOf(
        Game("Frostpunk",Cooperative),
        Game("Hero Realm",Deckbuilding),
        Game("Agricola",Euro),
        Game("Arkham Horror",LCG),
        Game("GloomHaven",Legacy)

    )


    private lateinit var rvCategories: RecyclerView
    private lateinit var rvGames: RecyclerView
    private lateinit var categoriesAdapter: CategoriesAdapter
    private lateinit var gamesAdapter: GamesAdapter
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_board_games)
        initcomponents()
        initUI()

    }

    private fun initUI(){
        categoriesAdapter = CategoriesAdapter(categories)
        gamesAdapter = GamesAdapter(games)
        rvGames.layoutManager = LinearLayoutManager(this, LinearLayoutManager.VERTICAL, false)
        rvCategories.layoutManager = LinearLayoutManager(this, LinearLayoutManager.HORIZONTAL, false)
        rvGames.adapter = gamesAdapter
        rvCategories.adapter = categoriesAdapter

    }


    private fun initcomponents() {
        rvCategories = findViewById<RecyclerView>(R.id.rvCategories)
        rvGames = findViewById<RecyclerView>(R.id.rvGames)
    }

}