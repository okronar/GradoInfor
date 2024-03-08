package com.ruben.examen2dual

import android.view.View
import androidx.recyclerview.widget.RecyclerView
import com.ruben.examen2dual.databinding.ItemLayoutBinding
import com.squareup.picasso.Picasso

class MoviesViewHolder (view: View) : RecyclerView.ViewHolder(view) {
    private val binding = ItemLayoutBinding.bind(view)

    fun bind(movie: MovieEntity){
        Picasso.get().load(movie.image).into(binding.ivMovie)
        binding.tvDirector.text = movie.director
        binding.tvDuration.text = movie.duration
        binding.tvGenre.text = movie.genre
        binding.tvReleaseDate.text = movie.releaseDate
        binding.tvTitle.text = movie.title

    }
}