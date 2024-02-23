package com.ruben.repaso2ev

import android.view.LayoutInflater
import android.view.ViewGroup
import com.ruben.repaso2ev.databinding.ItemLayoutBinding
import com.squareup.picasso.Picasso

class MoviesAdapter {

    fun updateList(list: List<RecyclerEntity>) {
        superheroList = list
        notifyDataSetChanged()
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): SuperheroViewHolder {
        return SuperheroViewHolder(
            LayoutInflater.from(parent.context).inflate(R.layout.item_superhero, parent, false)
        )
    }
    override fun onBindViewHolder(holder: SuperheroViewHolder, position: Int) {
        holder.bind(superheroList[position],navigateToDetailActivity)
    }



}