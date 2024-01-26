package com.sergio.gamesapitrabajo

import android.view.View
import androidx.recyclerview.widget.RecyclerView
import com.sergio.gamesapitrabajo.databinding.ItemVideogameBinding
import com.squareup.picasso.Picasso

class VideoGamesViewHolder(view: View) : RecyclerView.ViewHolder(view) {

    private val binding = ItemVideogameBinding.bind(view)
    fun bind(VideoGameItemResponse: VideogamesItemResponse) {

        var plataformasNombres = ""

        for (platformP in VideoGameItemResponse.PlataformasPadre) {
            plataformasNombres += platformP.PlataformasHijo.NombrePlataforma + " "
        }
        plataformasNombres = plataformasNombres

        binding.tvVideoGameName.text = VideoGameItemResponse.name
        binding.tvVideoGamePlatforms.text = plataformasNombres
        binding.tvVideoRating.text = VideoGameItemResponse.rating


        Picasso.get().load(VideoGameItemResponse.videogameImage).into(binding.ivVideoGame)
    }
}


