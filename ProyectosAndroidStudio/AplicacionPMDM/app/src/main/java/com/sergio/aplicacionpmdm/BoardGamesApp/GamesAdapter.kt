package com.sergio.aplicacionpmdm.BoardGamesApp

import android.view.LayoutInflater
import android.view.ViewGroup
import com.sergio.aplicacionpmdm.R
import androidx.recyclerview.widget.RecyclerView


class GamesAdapter(private val games: List<Game>) : RecyclerView.Adapter<GamesViewHolder>() {


        override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): GamesViewHolder {

            val view = LayoutInflater.from(parent.context).inflate(R.layout.item_game, parent, false)

            return GamesViewHolder(view)

        }

        override fun onBindViewHolder(holder: GamesViewHolder, position: Int) {
            holder.render(games[position])

        }

        override fun getItemCount(): Int = games.size
    }

