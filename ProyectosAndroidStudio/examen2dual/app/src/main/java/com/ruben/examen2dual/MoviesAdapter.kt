package com.ruben.examen2dual

import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView
import com.ruben.examen2dual.databinding.ItemLayoutBinding
import com.squareup.picasso.Picasso

class MoviesAdapter (private var moviesList: List<MovieEntity> = emptyList()) :
    RecyclerView.Adapter<MoviesViewHolder>() {
    fun updateList (list: List<MovieEntity>){
        moviesList = list
        notifyDataSetChanged()
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): MoviesViewHolder {
        return MoviesViewHolder(
            LayoutInflater.from(parent.context).inflate(R.layout.item_layout,parent,false)
        )
    }

    override fun getItemCount() = moviesList.size

    override fun onBindViewHolder(holder: MoviesViewHolder, position: Int) {
        holder.bind(moviesList[position])
    }

}