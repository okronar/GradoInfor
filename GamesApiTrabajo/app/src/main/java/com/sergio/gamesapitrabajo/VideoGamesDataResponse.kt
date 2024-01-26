package com.sergio.gamesapitrabajo

import com.google.gson.annotations.SerializedName

data class VideoGamesDataResponse (

     @SerializedName("count") val response: Int,
     @SerializedName("results") val videoGames: List<VideogamesItemResponse>
)
data class VideogamesItemResponse(

    @SerializedName("id") val videoGameId: Int,
    @SerializedName("name") val name: String,
    @SerializedName("background_image") val videogameImage:String,
    @SerializedName("rating") val rating:String,
    @SerializedName("platforms") val PlataformasPadre: List<PlataformasItemResponse>

)
data class PlataformasItemResponse (
    @SerializedName("platform") val PlataformasHijo: NamesItemResponse
)

data class NamesItemResponse (
    @SerializedName("name") val NombrePlataforma: String
)







