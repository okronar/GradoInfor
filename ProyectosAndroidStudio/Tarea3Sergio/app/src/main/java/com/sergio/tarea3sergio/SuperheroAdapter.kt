package com.sergio.tarea3sergio

import android.view.LayoutInflater
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView
import com.sergio.aplicacionpmdm.superheroAPI.SuperheroViewHolder
import com.sergio.tarea3sergio.database.entities.RecyclerEntity

class SuperheroAdapter(var superheroList: List<RecyclerEntity> = emptyList(), private val navigateToDetailActivity: (Int) -> Unit) : RecyclerView.Adapter<SuperheroViewHolder>() {

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
    override fun getItemCount() = superheroList.size

}
