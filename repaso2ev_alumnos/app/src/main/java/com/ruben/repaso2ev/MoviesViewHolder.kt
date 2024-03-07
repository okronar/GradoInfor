package com.ruben.repaso2ev

import android.view.View
import androidx.recyclerview.widget.RecyclerView
import com.ruben.repaso2ev.database.entities.MovieEntity
import com.ruben.repaso2ev.databinding.ItemLayoutBinding
import com.squareup.picasso.Picasso

class MoviesViewHolder (view: View) : RecyclerView.ViewHolder(view) {
    private val binding = ItemLayoutBinding.bind(view)

    fun bind(movie: MovieEntity){
        Picasso.get().load(movie.image).into(binding.ivMovie)
        binding.tvDirector.text = movie.director
        binding.tvDuration.text = movie.duration
        binding.tvGenre.text = movie.genre
        binding.tvLeadActor.text = movie.leadActor
        binding.tvReleaseDate.text = movie.releaseDate
        binding.tvSynopsis.text = movie.synopsis
        binding.tvTitle.text = movie.title
        binding.tvWriters.text = movie.writer1.plus(" ").plus(movie.writer2).plus(" ").plus(movie.writer3).plus(" ").plus(movie.writer4)
    }
}