package com.sergio.aplicacionpmdm.BoardGamesApp

import android.view.LayoutInflater
import android.view.ViewGroup
import android.widget.CheckBox
import com.sergio.aplicacionpmdm.R
import androidx.recyclerview.widget.RecyclerView


class GamesAdapter(var games: List<Game>, private val onGameSelected: (Int) -> Unit) :
    RecyclerView.Adapter<GamesViewHolder>() {


    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): GamesViewHolder {

        val view = LayoutInflater.from(parent.context).inflate(R.layout.item_game, parent, false)

        return GamesViewHolder(view)

    }

    override fun onBindViewHolder(holder: GamesViewHolder, position: Int) {
        holder.render(games[position])
        holder.itemView.setOnClickListener { gameSelected(position) }
        holder.itemView.findViewById<CheckBox>(R.id.cbGame)
            .setOnClickListener { gameSelected(position) }
    }

    override fun getItemCount(): Int = games.size

    private fun gameSelected(position: Int){
        games[position].isSelected = !games[position].isSelected
        onGameSelected(position)
    }
}

