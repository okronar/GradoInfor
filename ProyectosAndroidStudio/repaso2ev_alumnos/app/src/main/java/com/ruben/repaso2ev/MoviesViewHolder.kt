package com.ruben.repaso2ev

import android.view.View
import androidx.recyclerview.widget.RecyclerView
import com.ruben.repaso2ev.database.entities.MovieEntity
import com.ruben.repaso2ev.databinding.ActivityMainBinding
import com.ruben.repaso2ev.databinding.ItemLayoutBinding
import com.squareup.picasso.Picasso

class MoviesViewHolder(view: View) : RecyclerView.ViewHolder(view) {

    private val binding = ItemLayoutBinding.bind(view)
    fun bind(MovieRecycler: MovieEntity) {
        binding.tvGenre.text =  MovieRecycler.genre
        binding.tvDirector.text = MovieRecycler.director
        binding.tvDuration.text = MovieRecycler.duration
        binding.tvLeadActor.text = MovieRecycler.leadActor

        Picasso.get().load(MovieRecycler.image).into(binding.ivMovie)

        }
    }


