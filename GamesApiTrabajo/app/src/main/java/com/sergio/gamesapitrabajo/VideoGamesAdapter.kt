package com.sergio.gamesapitrabajo

import android.view.LayoutInflater
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView

class VideoGamesAdapter ( var videogamesList: List<VideogamesItemResponse> = emptyList()) : RecyclerView.Adapter<VideoGamesViewHolder>(){

    fun updateList(list: List<VideogamesItemResponse>) {
        videogamesList = list
        notifyDataSetChanged()
    }


    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): VideoGamesViewHolder {
            return VideoGamesViewHolder(

                LayoutInflater.from(parent.context).inflate(R.layout.item_videogame, parent, false)
            )

        }

        override fun onBindViewHolder(holder: VideoGamesViewHolder, position: Int) {

            holder.bind(videogamesList[position])
        }
        override fun getItemCount(): Int= videogamesList.size


    }

