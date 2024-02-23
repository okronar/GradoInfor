package com.sergio.tarea3sergio

import android.view.View
import androidx.recyclerview.widget.RecyclerView
import com.sergio.tarea3sergio.databinding.ItemSuperheroBinding
import com.sergio.tarea3sergio.SuperheroItemResponse
import com.sergio.tarea3sergio.database.entities.RecyclerEntity
import com.squareup.picasso.Picasso

class SuperheroViewHolder(view: View) : RecyclerView.ViewHolder(view) {
    private val binding = ItemSuperheroBinding.bind(view)
    fun bind(superheroRecycler: RecyclerEntity, navigateToDetailActivity: (String) -> Unit) {
        binding.tvSuperheroName.text = superheroRecycler.name
        Picasso.get().load(superheroRecycler.image).into(binding.ivSuperhero)
        binding.root.setOnClickListener {
            navigateToDetailActivity(superheroRecycler.id.toString())
        }
    }
}
