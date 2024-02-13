package com.sergio.aplicacionpmdm.superheroAPI

import android.view.View
import androidx.recyclerview.widget.RecyclerView
import com.sergio.tarea3sergio.databinding.ItemSuperheroBinding
import com.sergio.tarea3sergio.SuperheroItemResponse
import com.squareup.picasso.Picasso

class SuperheroViewHolder(view: View) : RecyclerView.ViewHolder(view) {
    private val binding = ItemSuperheroBinding.bind(view)
    fun bind(superheroItemResponse: SuperheroItemResponse, navigateToDetailActivity: (String) -> Unit) {
        binding.tvSuperheroName.text = superheroItemResponse.name
        Picasso.get().load(superheroItemResponse.superheroImage.url).into(binding.ivSuperhero)
        binding.root.setOnClickListener {
            navigateToDetailActivity(superheroItemResponse.superheroId)
        }
    }


}
