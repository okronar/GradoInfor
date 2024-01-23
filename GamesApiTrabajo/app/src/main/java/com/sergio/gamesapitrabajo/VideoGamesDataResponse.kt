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
    @SerializedName("rating") val rating:String

)
data class VideogamesImageResponse(@SerializedName("url") val url:String)



